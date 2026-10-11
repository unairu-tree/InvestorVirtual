namespace InvestorVirtual.ViewModels.Learning;

using InvestorVirtual.Data.Models.Enums;

public class LearningIndexViewModel
{
    // Data flow from the database (trusted) to the client (untrusted)
    public string TermName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public TermCategory Category { get; set; } // Kept as an enum so we can pull its display name in the view with the help of a custom extension method
}