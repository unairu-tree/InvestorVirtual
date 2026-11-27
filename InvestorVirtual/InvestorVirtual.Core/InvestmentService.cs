namespace InvestorVirtual.Services.Core;

using Microsoft.EntityFrameworkCore;

using InvestorVirtual.Data.Models;
using InvestorVirtual.Data.Repository.Contracts;
using InvestorVirtual.Services.Core.Contracts;
using InvestorVirtual.Services.Core.Data.Investment.Response;

using static InvestorVirtual.GCommon.ApplicationConstants;

// This is the investing service inheriting and implementing the tasks from the interface
public class InvestmentService(
    IStockRepository stockRepository,
    IEventRepository eventRepository,
    IPortfolioStockRepository portfolioStockRepository,
    IPortfolioRepository portfolioRepository,
    ITransactionRepository transactionRepository
    ) : IInvestmentService
{
    // Fetching all assets with optional search and sector filters
    public IQueryable<AssetsResponseModel> GetAllAssets(string? searchQuery, string? sector)
    {
        IQueryable<Stock> allStocks = stockRepository
            .AllAsNoTracking()
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

    // Fetching a single asset by its ticker symbol
    public async Task<AssetsResponseModel?> GetAssetAsync(string ticker)
    {
        return await stockRepository
            .AllAsNoTracking()
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
            .FirstOrDefaultAsync();
    }

    // Fetching all events for a specific stock up to the current day
    public async Task<IEnumerable<EventResponseModel>> GetAllEventsAsync(int stockId, int currentDay)
    {
        return await eventRepository
            .AllAsNoTracking()
            .Where(e => !e.IsDeleted && e.Stock.Id == stockId)
            .OrderBy(e => e.Date)
            .ThenBy(e => e.Id)
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
            .ToListAsync();
    }

    // Checking if the latest event's price is higher than the previous event's price to determine if the market is bullish or bearish
    public async Task<bool> IsBullishVolumeAsync(string ticker, int currentDay)
    {
        // If we are on day 1, we return true because today's price is higher than 0 (since there was no day before the first day)
        if (currentDay <= 1)
            return true;

        // I could check the ticker here, but this method is called from the details controller where I already have 2 null checks so I can be almost certain that the ticker is given and is legitimate

        // Gets a list of the events up to the current day for the given stock ticker, ordered by Date
        List<Event> eventsUpToCurrentDay = await eventRepository
            .AllAsNoTracking()
            .Include(e => e.Price)
            .Where(e => !e.IsDeleted && e.Stock.Ticker == ticker)
            .OrderBy(e => e.Date)
            .Take(currentDay)
            .ToListAsync();

        // Gets latest and previous events
        Event latestEvent = eventsUpToCurrentDay[^1]; // Shorthand expression for getting the last element of a list (.Count - 1)
        Event previousEvent = eventsUpToCurrentDay[^2]; // Shorthand expression for getting the second last element of a list (.Count - 2)

        // Compares to see if the market is bullish (latest price > previous price), or bearish (latest price < previous price)
        return latestEvent.Price.PriceValue > previousEvent.Price.PriceValue;
    }

    // Toggling a stock in the user's watchlist. If it exists, it removes it; if it doesn't exist, it adds it.
    public async Task<bool> ToggleWatchlistAsync(string portfolioGuidOrUserId, string ticker)
    {
        // Finds a non-deleted stock with the given ticker
        Stock? stock = await stockRepository
            .AllAsNoTracking()
            .FirstOrDefaultAsync(s => s.Ticker == ticker && !s.IsDeleted);

        if (stock == null)
        {
            return false;
        }

        // Query the entry so we can check if it exists and make changes to it if it does
        PortfolioStock? existingEntry = await portfolioStockRepository
            .All()
            .FirstOrDefaultAsync(ps => ps.PortfolioGuid == portfolioGuidOrUserId && ps.StockId == stock.Id);

        if (existingEntry != null)
        {
            if (existingEntry.IsInWatchlist)
            {
                // Removes from watchlist
                existingEntry.IsInWatchlist = false;

                if (!existingEntry.IsOwned)
                {
                    // If it is not owned when removing it from the watchlist, erases the entry entirely
                    portfolioStockRepository.Remove(existingEntry);
                }

                await portfolioStockRepository.SaveChangesAsync();
                return false; // No longer in watchlist
            }

            // Adds to watchlist
            existingEntry.IsInWatchlist = true;

            await portfolioStockRepository.SaveChangesAsync();
            return true; // Now bookmarked
        }

        // Adds to watchlist
        PortfolioStock newEntry = new()
        {
            PortfolioGuid = portfolioGuidOrUserId,
            StockId = stock.Id,
            IsInWatchlist = true,
            SharesOwned = 0m
        };

        await portfolioStockRepository.AddAsync(newEntry);
        await portfolioStockRepository.SaveChangesAsync();
        return true; // Now bookmarked
    }

    // Checks if a stock is in the user's watchlist for displaying the correct button state in the UI
    public async Task<bool> IsInWatchlistAsync(string portfolioGuidOrUserId, string ticker)
    {
        return await portfolioStockRepository
            .AllAsNoTracking()
            .AnyAsync(ps => ps.PortfolioGuid == portfolioGuidOrUserId
                            && ps.IsInWatchlist
                            && !ps.Stock.IsDeleted
                            && ps.Stock.Ticker == ticker);
    }

    // Checks if a stock is owned by the user for displaying the correct button state in the UI
    public async Task<bool> IsOwnedAsync(string portfolioGuidOrUserId, string ticker)
    {
        return await portfolioStockRepository
            .AllAsNoTracking()
            .AnyAsync(ps => ps.PortfolioGuid == portfolioGuidOrUserId
                            && ps.SharesOwned > 0m
                            && !ps.Stock.IsDeleted
                            && ps.Stock.Ticker == ticker);
    }

    // Fetches the user's portfolio GUID or creates a new portfolio if it doesn't exist (portfolio and user guid are tied 1:1)
    public async Task<string> GetOrCreatePortfolioGuidAsync(string userId)
    {
        // Checks to see if a portfolio exists
        Portfolio? portfolio = await portfolioRepository
            .All()
            .FirstOrDefaultAsync(p => p.UserGuid == userId);

        if (portfolio == null) // If not - creates a new portfolio
        {
            portfolio = new Portfolio
            {
                Guid = userId, // Sets matching GUID to user GUID
                UserGuid = userId, // Binds to the user
                Balance = StartingBalance // Sets starting balance
            };

            await portfolioRepository.AddAsync(portfolio);
            await portfolioRepository.SaveChangesAsync();
        }

        return portfolio.Guid.ToString(); // If yes - returns the portfolio GUID
    }

    // Checks if a portfolio exists for a given GUID
    public async Task<bool> PortfolioExistsAsync(string guid)
    {
        // Checks to see if a portfolio exists
        Portfolio? portfolio = await portfolioRepository
            .AllAsNoTracking()
            .FirstOrDefaultAsync(p => p.Guid == guid);

        if (portfolio == null)
            return false; // If not - return false

        return true; // If it does - return true
    }

    // Fetches the user's portfolio and all of its associated data (watchlist, transactions, balance)
    public async Task<PortfolioResponseModel?> GetPortfolioAsync(string portfolioGuidOrUserId)
    {
        Portfolio? portfolio = await portfolioRepository
            .AllAsNoTracking()
            .Include(p => p.PortfolioStocks)
                .ThenInclude(ps => ps.Stock)
            .Include(p => p.Transactions)
            .FirstOrDefaultAsync(p => p.Guid == portfolioGuidOrUserId);

        if (portfolio == null)
        {
            return null;
        }

        return new PortfolioResponseModel
        {
            Balance = portfolio.Balance,
            PortfolioStocks = portfolio.PortfolioStocks,
            Transactions = portfolio.Transactions
        };
    }

    // Resets the user's portfolio to the starting balance and removes all transactions
    public async Task ResetSimulationAsync(string portfolioGuidOrUserId)
    {
        Portfolio? currentPortfolio = await portfolioRepository
            .All()
            .FirstOrDefaultAsync(p => p.Guid == portfolioGuidOrUserId);

        if (currentPortfolio == null)
            return; // Defensive safety check

        // Resets the starting balance
        currentPortfolio.Balance = StartingBalance;

        // Resets the transactions list
        IEnumerable<Transaction> transactionsToRemove = await transactionRepository
            .All()
            .Where(t => t.PortfolioId == currentPortfolio.Guid)
            .ToListAsync();

        transactionRepository.RemoveRange(transactionsToRemove);

        await transactionRepository.SaveChangesAsync();
    }
}