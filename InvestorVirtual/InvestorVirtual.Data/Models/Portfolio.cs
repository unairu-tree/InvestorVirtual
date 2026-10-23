namespace InvestorVirtual.Data.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static InvestorVirtual.Common.ApplicationConstants;

// This model is empty and not configured on startup. It gets configured through the site UI.
[Comment("This model represents the portfolio that the user creates upon starting a simulation. It will be the central hub of operations, showing the user's investment holdings, their watchlist, and their current balance.")]
public class Portfolio
{
    [Key]
    [Comment("Matches the user's GUID.")]
    public string Guid { get; set; } = null!;

    [ForeignKey(nameof(User))]
    [Comment("The GUID of the user to whom this portfolio belongs.")]
    public string UserGuid { get; set; } = null!;

    public virtual IdentityUser User { get; set; } = null!;

    [Column(TypeName = DefaultDecimalColumnType)]
    [Comment("The current balance of the portfolio, representing the amount of money available for investment.")]
    public decimal Balance { get; set; }

    [Comment("A list of all the stocks watchlisted in this portfolio.")]
    public virtual ICollection<PortfolioStock> PortfolioStocks { get; set; } = new List<PortfolioStock>();

    [Comment("A list of all the transactions associated with this portfolio.")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    [Comment("Indicates whether this portfolio is soft-deleted.")]
    public bool isDeleted { get; set; }
}