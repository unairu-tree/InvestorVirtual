namespace InvestorVirtual.Core.Services;

using InvestorVirtual.Core.Models;
using InvestorVirtual.Core.Contracts;

using InvestorVirtual.Data.Common;
using InvestorVirtual.Data.Models;

public class InvestmentService(IRepository repository) : IInvestmentService
{
    public IEnumerable<AllAssetsModel> GetAllAssets() // TODO: Implement usage of milestone value
    {
        return repository.All<Stock>()
            .OrderBy(stock => stock.Id)
            .Select(stock => new AllAssetsModel
            {
                Ticker = stock.Ticker,
                CompanyName = stock.CompanyName,
                Sector = stock.Sector,
                LogoPath = stock.LogoPath,
                // TODO: Add price pulling logic when we handle the milestone steps so we can accurately pull the latest recorded price for the stock
            })
            .ToArray();
    }
}