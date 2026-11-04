namespace InvestorVirtual.Services.Core;

using Microsoft.EntityFrameworkCore;

using InvestorVirtual.Data.Models;
using InvestorVirtual.Data.Repository;

using InvestorVirtual.Services.Core.Contracts;
using InvestorVirtual.Services.Core.Data.Investment.Response;

using static InvestorVirtual.GCommon.ApplicationConstants;

// This is the investing service inheriting and implementing the tasks from the interface
public class InvestmentService(IRepository repository) : IInvestmentService
{
    public IQueryable<AssetsResponseModel> GetAllAssets(string? searchQuery, string? sector)
    {
        IQueryable<Stock> allStocks = repository.All<Stock>()
            .Where(s => !s.IsDeleted); // Pull all stocks into the expression tree

        if (!string.IsNullOrWhiteSpace(searchQuery)) // If a NAME was given - enters this 'if'
        {
            string searchTerm = searchQuery.Trim().ToLower(); // "Trims" and "ToLowers" the name to normalize it
            allStocks = allStocks
                .Where(s => s.Ticker.ToLower().Contains(searchTerm) ||     // Reverted to using .ToLower() since the previously commited version was unable to be translated by EF Core
                            s.CompanyName.ToLower().Contains(searchTerm)); // Searching both "Ticker" and "Company Name" in order to replicate the feel of searching in apps/sites like "Revolut" and "Yahoo Finance"
        }

        if (!string.IsNullOrWhiteSpace(sector)) // If a SECTOR was given - enters this 'if'
        {
            string sectorTerm = sector.Trim().ToLower(); // Normalizing the term
            allStocks = allStocks
                .Where(s => s.Sector.ToLower().Contains(sectorTerm)); // Attaching it to the expression tree
        }

        // DEPRECATED - Moved logic to controller since the price preformance will come from another service and the ordering should be done in the controller where the viewmodel accepts all the combined information

        //allStocks = sorting switch // More compact vesion of switch case to attach the kind of sorting the user desires to see
        //{
        //    "AddedDesc" => allStocks.OrderByDescending(s => s.Id), // Since ID is auto-incremented (in our case I manually added ids for most entities to make sure EF core could seed them properly based on how their relations work) we can use the ID as a form of "when was it added"
        //    "AlphabeticalAsc" => allStocks.OrderBy(s => s.CompanyName), // Alphabetic ascending
        //    "AlphabeticalDesc" => allStocks.OrderByDescending(s => s.CompanyName), // Alphabetic descending
        //    // "PerformanceAsc" => allStocks.OrderBy()
        //    // "PerformanceDesc" => allStocks.OrderByDescending()
        //    _ => allStocks.OrderBy(s => s.Id) // Default added(id) ascending
        //};

        // DEPRECATED

        return allStocks
            .Select(s => new AssetsResponseModel
            {
                Id = s.Id,
                Ticker = s.Ticker,
                CompanyName = s.CompanyName,
                ShortDescription = s.ShortDescription,
                Sector = s.Sector,
                LogoPath = s.LogoPath,
            });
    }

    public AssetsResponseModel? GetAsset(string ticker)
    {
        return repository.All<Stock>()
            .Where(s => !s.IsDeleted && s.Ticker == ticker)
            .Select(s => new AssetsResponseModel
            {
                Id = s.Id,
                Ticker = s.Ticker,
                CompanyName = s.CompanyName,
                ShortDescription = s.ShortDescription,
                Sector = s.Sector,
                LogoPath = s.LogoPath,
            })
            .FirstOrDefault();
    }

    public IEnumerable<EventResponseModel> GetAllEvents(int stockId, int currentDay)
    {   
        return repository.All<Event>()
            .Where(e => !e.IsDeleted && e.Stock.Id == stockId)
            .Take(currentDay)
            .Select(e => new EventResponseModel
            {
                Id = e.Id,
                Title = e.Title,
                Date = e.Date,
                Price = e.Price,
                News = e.News,
                Analysis = e.Analysis
            })
            .ToList();
    }

    public bool IsBullishVolume(string ticker, int currentDay)
    {
        // If we are on day 1, we return true because today's price is higher than 0 (since there was no day before the first day)
        if (currentDay == 1)
            return true;

        // I could check the ticker here, but this method is called from the details controller where I already have 2 null checks so I can be almost certain that the ticker is given and is legitimate

        // Gets latest event
        Event latestEvent = repository.All<Event>()
            .Include(e => e.Price)
            .Where(le => !le.IsDeleted && le.Stock.Ticker == ticker)
            .OrderBy(le => le.Id)
            .Take(currentDay)
            .Last();

        // Gets previous event
        Event previousEvent = repository.All<Event>()
            .Include(e => e.Price)
            .Where(le => !le.IsDeleted && le.Stock.Ticker == ticker)
            .OrderBy(le => le.Id)
            .Take(currentDay - 1)
            .Last();

        // Takes the prices
        decimal latestPrice = latestEvent.Price.PriceValue;
        decimal previousPrice = previousEvent.Price.PriceValue;

        // Compares to see if the market is bullish (latest price > previous price), or bearish (latest price < previous price)
        if (latestPrice - previousPrice > 0)
            return true;
        else
            return false;
    }

    public bool ToggleWatchlist(string portfolioGuid, string ticker)
    {
        // Finds a non-deleted stock with the given ticker
        Stock? stock = repository.All<Stock>()
            .FirstOrDefault(s => s.Ticker == ticker && !s.IsDeleted);

        if (stock == null) return false;

        // Checks if the stock is already in the user's watchlist
        PortfolioStock? existingEntry = repository.All<PortfolioStock>()
            .FirstOrDefault(ps => ps.PortfolioGuid == portfolioGuid
                               && ps.StockId == stock.Id);

        if (existingEntry != null)
        {
            // Removes from watchlist
            repository.Remove(existingEntry);
            repository.SaveChanges();
            return false; // No longer in watchlist
        }
        else
        {
            // Adds to watchlist
            PortfolioStock newEntry = new()
            {
                PortfolioGuid = portfolioGuid,
                StockId = stock.Id
            };

            repository.Add(newEntry);
            repository.SaveChanges();
            return true; // Now bookmarked
        }
    }

    public bool IsInWatchlist(string portfolioGuid, string ticker) => repository.All<PortfolioStock>().Any(ps => ps.PortfolioGuid == portfolioGuid && ps.Stock.Ticker == ticker);

    public string GetOrCreatePortfolioGuid(string userId)
    {
        // Checks to see if a portfolio exists
        Portfolio? portfolio = repository.All<Portfolio>()
            .FirstOrDefault(p => p.UserGuid == userId);

        if (portfolio == null) // If not - creates a new portfolio
        {
            portfolio = new Portfolio
            {
                Guid = userId, // Sets matching GUID to user GUID
                UserGuid = userId, // Binds to the user
                Balance = StartingBalance // Sets starting balance
            };

            repository.Add(portfolio);
            repository.SaveChanges();
        }

        return portfolio.Guid.ToString(); // If yes - returns the portfolio GUID
    }

    public bool PortfolioExists(string guid)
    {
        // Checks to see if a portfolio exists
        Portfolio? portfolio = repository.All<Portfolio>()
            .FirstOrDefault(p => p.Guid == guid);

        if (portfolio == null)
            return false; // If not - return false

        return true; // If it does - return true
    }

    public void ResetSimulation(string portfolioGuid)
    {
        Portfolio? currentPortfolio = repository.All<Portfolio>()
            .FirstOrDefault(p => p.Guid == portfolioGuid);

        if (currentPortfolio == null)
            return; // Defensive safety check

        // Resets the starting balance
        currentPortfolio.Balance = StartingBalance;

        // Resets the transactions list
        IQueryable<Transaction> transactionsToRemove = repository.All<Transaction>()
            .Where(t => t.PortfolioId == currentPortfolio.Guid);

        repository.RemoveRange(transactionsToRemove);

        repository.SaveChanges();
    }
}