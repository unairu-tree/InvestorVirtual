namespace InvestorVirtual.Web.ViewModels.Investment;

using InvestorVirtual.Services.Core.Data.Investment.Response;

public class DetailsViewModel
{
    // Stock details
    public int Id { get; set; }

    public string Ticker { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public string Sector { get; set; } = null!;

    public string LogoPath { get; set; } = null!;

    // Price details
    public bool IsBullishVolume { get; set; }

    // Day simulation details
    public int CurrentDay { get; set; }

    // Watchlist details
    public bool IsInWatchlist { get; set; }

    public IEnumerable<EventResponseModel> Events { get; set; } = new HashSet<EventResponseModel>();
}