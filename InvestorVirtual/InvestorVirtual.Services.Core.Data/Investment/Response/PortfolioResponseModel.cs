namespace InvestorVirtual.Services.Core.Data.Investment.Response;

using InvestorVirtual.Data.Models;

public class PortfolioResponseModel
{
    public Portfolio Portfolio { get; set; } = null!;

    public IEnumerable<PortfolioStock> Watchlist { get; set; } = new List<PortfolioStock>();

    public IEnumerable<Transaction> Transactions { get; set; } = new List<Transaction>();
}