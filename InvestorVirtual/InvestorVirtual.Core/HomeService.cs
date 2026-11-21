namespace InvestorVirtual.Services.Core;

using Microsoft.EntityFrameworkCore;

using InvestorVirtual.Data.Repository.Contracts;
using InvestorVirtual.Services.Core.Contracts;
using InvestorVirtual.Services.Core.Data.Investment.Response;

// This is the home service inheriting and implementing the tasks from the interface
public class HomeService(IStockRepository stockRepository) : IHomeService
{
    // Fetches a list of assets to showcase on the home page, limited to 10 items
    public async Task<IEnumerable<AssetShowcaseModel>> GetAssetShowcasesAsync()
    {
        return await stockRepository
            .AllAsNoTracking()
            .OrderBy(stock => stock.Id)
            .Take(10) // The configurable amount of showcased assets on the home page (not implemented as an application constant since the logic might change entirely later)
            .Select(stock => new AssetShowcaseModel
            {
                Ticker = stock.Ticker,
                LogoPath = stock.LogoPath
            })
            .ToArrayAsync();
    }
}