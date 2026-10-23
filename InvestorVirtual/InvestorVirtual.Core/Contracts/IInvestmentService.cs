namespace InvestorVirtual.Core.Contracts;

using InvestorVirtual.Core.Models;

public interface IInvestmentService
{
    IEnumerable<AllAssetsModel> GetAllAssets();
}