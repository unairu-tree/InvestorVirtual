namespace InvestorVirtual.Core.Contracts;

using InvestorVirtual.Core.Models.Response;

// This is the interface inherited by the services responsible for passing data to the investment controller
public interface IInvestmentService
{
    // A collection fetching from the DB all existing assets with applied search filters (if any exist)
    IEnumerable<AllAssetsModel> GetAllAssets(string? searchQuery, string? sector, string? sorting);
}