namespace InvestorVirtual.Services.Core.Data.Investment.Response;

// Data flow from the database (trusted) to the client (untrusted)
public class AssetsResponseModel
{
    public int Id { get; set; }

    public string Ticker { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public string Sector { get; set; } = null!;

    public string LogoPath { get; set; } = null!;
}