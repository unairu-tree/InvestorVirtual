namespace InvestorVirtual.Core.Services;

using InvestorVirtual.Data.Common;
using InvestorVirtual.Data.Models;

using InvestorVirtual.Core.Models;
using InvestorVirtual.Core.Contracts;

public class HomeService(IRepository repository) : IHomeService
{
    public IEnumerable<AssetShowcaseModel> GetAssetShowcases()
    {
        return repository.All<Stock>()
            .OrderBy(stock => stock.Id)
            .Take(10)
            .Select(stock => new AssetShowcaseModel
            {
                Ticker = stock.Ticker,
                LogoPath = stock.LogoPath
            })
            .ToArray();
    }
}