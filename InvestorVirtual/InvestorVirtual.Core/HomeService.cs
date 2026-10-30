namespace InvestorVirtual.Services.Core;

using InvestorVirtual.Data.Models;
using InvestorVirtual.Data.Repository;

using InvestorVirtual.Services.Core.Contracts;
using InvestorVirtual.Services.Core.Data.Investment.Response;

// This is the home service inheriting and implementing the tasks from the interface
public class HomeService(IRepository repository) : IHomeService
{
    public IEnumerable<AssetShowcaseModel> GetAssetShowcases()
    {
        return repository.All<Stock>()
            .OrderBy(stock => stock.Id)
            .Take(10) // The configurable amount of showcased assets on the home page (not implemented as an application constant since the logic might change entirely later)
            .Select(stock => new AssetShowcaseModel
            {
                Ticker = stock.Ticker,
                LogoPath = stock.LogoPath
            })
            .ToArray();
    }
}