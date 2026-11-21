namespace InvestorVirtual.Services.Core.Contracts;

using InvestorVirtual.Services.Core.Data.Investment.Response;

// This is the interface inherited by the services responsible for passing data to the home controller
public interface IHomeService
{
    // A collection fetching from the DB an exact number of assets to showcase on the welcome screen (the exact number is configured in the service)
    Task<IEnumerable<AssetShowcaseModel>> GetAssetShowcasesAsync();
}