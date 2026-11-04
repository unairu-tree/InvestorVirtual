using InvestorVirtual.Data.Models;

namespace InvestorVirtual.Services.Core.Data.Investment.Response;

// Data flow from the database (trusted) to the client (untrusted)
public class EventResponseModel
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public DateTime Date { get; set; }

    public Price Price { get; set; } = null!;

    public News News { get; set; } = null!;

    public Analysis Analysis { get; set; } = null!;
}