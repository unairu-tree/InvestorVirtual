namespace InvestorVirtual.Core.Models.Response;

using InvestorVirtual.Data.Models.Enums;

// Data flow from the database (trusted) to the client (untrusted)
public class LearningServiceModel
{
    public int Id { get; set; }

    public string Slug { get; set; } = null!;

    public string TermName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public TermCategory Category { get; set; } // Kept as an enum so we can pull its display name in the view with the help of a custom extension method
}