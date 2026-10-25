namespace InvestorVirtual.Core.Services;

using InvestorVirtual.Core.Contracts;
using InvestorVirtual.Core.Models.Response;
using InvestorVirtual.Data.Common;
using InvestorVirtual.Data.Models;
using Microsoft.EntityFrameworkCore;

// This is the investing service inheriting and implementing the tasks from the interface
public class InvestmentService(IRepository repository) : IInvestmentService
{
    public IEnumerable<AllAssetsModel> GetAllAssets(string? searchQuery, string? sector, string? sorting) // TODO: Implement usage of milestone value
    {
        IQueryable<Stock> allStocks = repository.All<Stock>(); // Pull all stocks into the expression tree

        if (!string.IsNullOrWhiteSpace(searchQuery)) // If a NAME was given - enters this 'if'
        {
            string searchTerm = searchQuery.Trim().ToLower(); // "Trims" and "ToLowers" the name to normalize it
            allStocks = allStocks
                .Where(s => s.Ticker.ToLower().Contains(searchTerm) ||
                            s.CompanyName.ToLower().Contains(searchTerm)); // Searching both "Ticker" and "Company Name" in order to replicate the feel of searching in apps/sites like "Revolut" and "Yahoo Finance"
        }

        if (!string.IsNullOrWhiteSpace(sector)) // If a SECTOR was given - enters this 'if'
        {
            string sectorTerm = sector.Trim().ToLower(); // Normalizing the term
            allStocks = allStocks
                .Where(s => s.Sector.ToLower().Contains(sectorTerm)); // Attaching it to the expression tree
        }

        allStocks = sorting switch // More compact vesion of switch case to attach the kind of sorting the user desires to see
        {
            "AddedDesc" => allStocks.OrderByDescending(s => s.Id), // Since ID is auto-incremented (in our case I manually added ids for most entities to make sure EF core could seed them properly based on how their relations work) we can use the ID as a form of "when was it added"
            "AlphabeticalAsc" => allStocks.OrderBy(s => s.CompanyName), // Alphabetic ascending
            "AlphabeticalDesc" => allStocks.OrderByDescending(s => s.CompanyName), // Alphabetic descending
            // "PerformanceAsc" => allStocks.OrderBy()
            // "PerformanceDesc" => allStocks.OrderByDescending()
            _ => allStocks.OrderBy(s => s.Id) // Default added(id) ascending
        };

        return allStocks
            .Select(s => new AllAssetsModel
            {
                Ticker = s.Ticker,
                CompanyName = s.CompanyName,
                Sector = s.Sector,
                LogoPath = s.LogoPath,
                // TODO: Add price pulling logic when we handle the milestone steps so we can accurately pull the latest recorded price for the stock
            })
            .ToArray();
    }

    public StockDetailsModel? GetStockDetails(string ticker, int currentDay, string userId)
    {
        // Fetches the stock and includes its relational data
        Stock? stock = repository.All<Stock>()
            .Where(s => s.Ticker == ticker && !s.IsDeleted)
            .Include(s => s.Events)
                .ThenInclude(e => e.Price)
            .Include(s => s.Events)
                .ThenInclude(e => e.News)
            .Include(s => s.Events)
                .ThenInclude(e => e.Analysis)
            .FirstOrDefault();

        if (stock == null)
        {
            return null;
        }

        // Order events chronologically (in this case by ID since that is how they were ordered upon config) and restrict history up to the current simulation day
        List<Event> activeEvents = stock.Events
            .Where(e => !e.IsDeleted)
            .OrderBy(e => e.Id)
            .Take(currentDay)
            .ToList();

        // The latest event represents today's active price and metrics
        Event? todaysEvent = activeEvents.LastOrDefault();

        return new StockDetailsModel
        {
            Id = stock.Id,
            Ticker = stock.Ticker,
            CompanyName = stock.CompanyName,
            ShortDescription = stock.ShortDescription,
            Sector = stock.Sector,
            LogoPath = stock.LogoPath,

            // Current day trading stats
            CurrentPrice = todaysEvent?.Price?.PriceValue ?? 0m,
            Volume = todaysEvent?.Price?.Volume ?? 0,
            IsBullishVolume = todaysEvent?.Price?.IsBullishVolume ?? true,
            AnalysisSummary = todaysEvent?.Analysis?.Reasoning,

            IsInWatchlist = !string.IsNullOrEmpty(userId) && IsInWatchlist(userId, ticker),

            // Timeline events mapped for your view iteration
            Events = activeEvents.Select((e, index) => new StockEventModel
            {
                MilestoneDay = index + 1,
                Title = e.Title,
                NewsSource = e.News?.Source ?? string.Empty,
                NewsBody = e.News?.Body ?? string.Empty
            }).ToList()
        };
    }

    public bool ToggleWatchlist(string userId, string ticker)
    {
        Stock? stock = repository.All<Stock>()
            .FirstOrDefault(s => s.Ticker == ticker && !s.IsDeleted);

        if (stock == null) return false;

        Watchlist? existingEntry = repository.All<Watchlist>()
            .FirstOrDefault(w => w.UserId == userId
            && w.StockId == stock.Id);

        if (existingEntry != null)
        {
            // Remove from watchlist
            repository.Remove(existingEntry);
            repository.SaveChanges();
            return false; // Returns false indicating it is no longer in watchlist
        }
        else
        {
            // Add to watchlist
            var newWatchlistEntry = new Watchlist
            {
                UserId = userId,
                StockId = stock.Id
            };

            repository.Add(newWatchlistEntry);
            repository.SaveChanges();
            return true; // Returns true indicating it is now bookmarked
        }
    }

    public bool IsInWatchlist(string userId, string ticker) => repository.All<Watchlist>().Any(w => w.UserId == userId && w.Stock.Ticker == ticker);
}