namespace InvestorVirtual.Core.Models.Response;

public class StockEventModel
{
    public int MilestoneDay { get; set; }

    public string Title { get; set; } = null!;

    public string NewsSource { get; set; } = null!;

    public string NewsBody { get; set; } = null!;

    // temp
    public decimal CurrentPrice { get; set; }

    public long Volume { get; set; }

    public bool IsBullishVolume { get; set; }

    public string? AnalysisSummary { get; set; }
    // temp
}