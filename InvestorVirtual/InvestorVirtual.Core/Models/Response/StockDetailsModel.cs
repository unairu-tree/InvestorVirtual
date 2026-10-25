namespace InvestorVirtual.Core.Models.Response;

public class StockDetailsModel
{
    public int Id { get; set; }

    public string Ticker { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public string Sector { get; set; } = null!;

    public string LogoPath { get; set; } = null!;

    public decimal CurrentPrice { get; set; }

    public long Volume { get; set; }

    public bool IsBullishVolume { get; set; }

    public string? AnalysisSummary { get; set; }

    public bool IsInWatchlist { get; set; }

    public ICollection<StockEventModel> Events { get; set; } = new HashSet<StockEventModel>();
}