namespace InvestorVirtual.Data.Models;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

// This model is empty and not configured on startup. It gets configured through the site UI.
[PrimaryKey(nameof(PortfolioGuid), nameof(StockId))]
[Comment("This is the mapping table that is used for handling a portfolio's watchlist.")]
public class PortfolioStock
{
    [Required]
    [Comment("The GUID of the portfolio to which this stock belongs.")]
    public string PortfolioGuid { get; set; } = null!;

    public virtual Portfolio Portfolio { get; set; } = null!;

    [Comment("The ID of the stock that is watchlisted.")]
    public int StockId { get; set; }

    public virtual Stock Stock { get; set; } = null!;
}