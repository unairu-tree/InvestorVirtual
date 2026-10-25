namespace InvestorVirtual.Core.Contracts;

using InvestorVirtual.Core.Models.Response;

// This is the interface inherited by the services responsible for passing data to the investment controller
public interface IInvestmentService
{
    // A collection fetching from the DB all existing assets with applied search filters (if any exist)
    IEnumerable<AllAssetsModel> GetAllAssets(string? searchQuery, string? sector, string? sorting);

    // Gets details for a single stock (useful for displaying it's details)
    StockDetailsModel? GetStockDetails(string ticker, int currentDay, string userId);

    // A method to add a stock to the watchlist
    bool ToggleWatchlist(string userId, string ticker);

    // A method to check if the stock is already in a watchlist
    bool IsInWatchlist(string userId, string ticker);

    // A helper method that extracts the portfolio tied to the user id (or creates one automatically if a portfolio does not exist)
    string GetOrCreatePortfolioGuid(string userId);

    PortfolioResponseModel GetPortfolioViewModel(string portfolioGuid);
}