namespace InvestorVirtual.Core.Contracts;

using InvestorVirtual.Core.Models;

public interface IHomeService
{
    IEnumerable<AssetShowcaseModel> GetAssetShowcases();
}