namespace InvestorVirtual.Core.Models.Response;

public class WatchlistItemModel
{
    public string Ticker { get; set; } = null!;
    public string CompanyName { get; set; } = null!;
    public decimal CurrentPrice { get; set; }
}