namespace InvestorVirtual.Services.Core.Data.Learning.Request;

public class LearningTermRequestModel
{
    public string TermName { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int CategoryId { get; set; }
}