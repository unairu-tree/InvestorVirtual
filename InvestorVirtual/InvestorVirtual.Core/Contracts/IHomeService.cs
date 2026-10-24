namespace InvestorVirtual.Core.Contracts;

using InvestorVirtual.Core.Models.Response;

// This is the interface inherited by the services responsible for passing data to the home controller
public interface IHomeService
{
    // A collection fetching from the DB an exact number of assets to showcase on the welcome screen (the exact number is configured in the service)
    IEnumerable<AssetShowcaseModel> GetAssetShowcases();
}