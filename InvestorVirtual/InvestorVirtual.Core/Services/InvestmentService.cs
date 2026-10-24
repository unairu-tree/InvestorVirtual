namespace InvestorVirtual.Core.Services;

using InvestorVirtual.Core.Contracts;
using InvestorVirtual.Core.Models.Response;
using InvestorVirtual.Data.Common;
using InvestorVirtual.Data.Models;

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

        // DEPRECATED

        // return repository.All<Stock>()
        //     .OrderBy(stock => stock.Id)
        //     .Select(stock => new AllAssetsModel
        //     {
        //         Ticker = stock.Ticker,
        //         CompanyName = stock.CompanyName,
        //         Sector = stock.Sector,
        //         LogoPath = stock.LogoPath,
        //         // TODO: Add price pulling logic when we handle the milestone steps so we can accurately pull the latest recorded price for the stock
        //     })
        //     .ToArray();

        // DEPRECATED
    }
}