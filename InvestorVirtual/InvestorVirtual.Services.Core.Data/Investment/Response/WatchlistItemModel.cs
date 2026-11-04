namespace InvestorVirtual.Services.Core.Data.Investment.Response;

// Data flow from the database (trusted) to the client (untrusted)
public class WatchlistItemModel
{
    public string Ticker { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public decimal CurrentPrice { get; set; }
}