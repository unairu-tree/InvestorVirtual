namespace InvestorVirtual.Core.Models.Response;

public class StockEventModel
{
    public int MilestoneDay { get; set; }

    public string Title { get; set; } = null!;

    public string NewsSource { get; set; } = null!;

    public string NewsBody { get; set; } = null!;
}