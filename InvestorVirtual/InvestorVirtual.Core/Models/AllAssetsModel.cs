namespace InvestorVirtual.Core.Models;

public class AllAssetsModel
{
    public string Ticker { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string Sector { get; set; } = null!;

    public string LogoPath { get; set; } = null!;

    // public decimal Price { get; set; } ---TODO: Implement when milestone steps are created
}