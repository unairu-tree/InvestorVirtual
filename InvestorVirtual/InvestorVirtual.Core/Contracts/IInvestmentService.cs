namespace InvestorVirtual.Services.Core.Contracts;

using InvestorVirtual.Services.Core.Data.Investment.Response;

// This is the interface inherited by the services responsible for passing data to the investment controller
public interface IInvestmentService
{
    // A collection fetching from the DB all existing assets with applied search filters (if any exist)
    IQueryable<AssetsResponseModel> GetAllAssets(string? searchQuery, string? sector);

    // A method to get a single asset by its ticker
    Task<AssetsResponseModel?> GetAssetAsync(string ticker);

    // TODO: Add a method to get all events
    Task<IEnumerable<EventResponseModel>> GetAllEventsAsync(int stockId, int currentDay);

    // A method to check if the stock has bullish volume on a given day
    Task<bool> IsBullishVolumeAsync(string ticker, int currentDay);

    // A method to add a stock to the watchlist
    Task<bool> ToggleWatchlistAsync(string userId, string ticker);

    // A method to check if the stock is already in a watchlist
    Task<bool> IsInWatchlistAsync(string portfolioGuidOrUserId, string ticker);

    // A method to check if the stock is owned by the user
    Task<bool> IsOwnedAsync(string portfolioGuidOrUserId, string ticker);

    // A helper method that extracts the portfolio tied to the user id (or creates one automatically if a portfolio does not exist)
    Task<string> GetOrCreatePortfolioGuidAsync(string userId);

    // A helper method that checks if a portfolio exists (main usage will be to check in case someone uses apps like PostMan to bypass the front end)
    Task<bool> PortfolioExistsAsync(string guid);

    // A method to get the portfolio tied to a user id and all of its associated data (watchlist, transactions, balance)
    Task<PortfolioResponseModel?> GetPortfolioAsync(string portfolioGuidOrUserId);

    // A method to restart the simulation - for the portfolio it sets balance back to default and clears all transactions, but keeps the watchlist
    Task ResetSimulationAsync(string portfolioGuidOrUserId);
}