namespace InvestorVirtual.Core.Models.Response;

// Data flow from the database (trusted) to the client (untrusted)
public class AssetShowcaseModel
{
    public string Ticker { get; set; } = null!;

    public string LogoPath { get; set; } = null!;
}