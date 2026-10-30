namespace InvestorVirtual.Web.ViewModels.Investment;

using InvestorVirtual.Data.Models;

using InvestorVirtual.Services.Core.Data.Investment.Response;

// TODO: DISCONNECT THE PROJECT DEPENDENCY OF VIEWMODELS TO DATA
public class PortfolioViewModel
{
    public DaySimulationModel Simulation { get; set; } = null!;

    public Portfolio Portfolio { get; set; } = null!;

    public IEnumerable<PortfolioStock> Watchlist { get; set; } = new List<PortfolioStock>();

    public IEnumerable<Transaction> Transactions { get; set; } = new List<Transaction>();
}