namespace InvestorVirtual.Data.Models;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static InvestorVirtual.Common.ApplicationConstants;

// This model is empty and not configured on startup. It gets configured through the site UI.
[Comment("Represents a transaction in the portfolio, either a buy or sell order.")]
public class Transaction
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey(nameof(Portfolio))]
    [Comment("The GUID of the portfolio to which this transaction belongs.")]
    public string PortfolioId { get; set; } = null!;

    public virtual Portfolio Portfolio { get; set; } = null!;

    [ForeignKey(nameof(Stock))]
    [Comment("The ID of the stock involved in this transaction.")]
    public int StockId { get; set; }

    public virtual Stock Stock { get; set; } = null!;

    [Column(TypeName = DefaultDecimalColumnType)]
    [Comment("The number of shares involved in this transaction.")]
    public decimal Shares { get; set; }
    
    [Column(TypeName = PricePerShareColumnType)]
    [Comment("The price per share at the time of the transaction.")]
    public decimal PricePerShare { get; set; }

    [NotMapped]
    [Comment("The total value of this transaction, calculated as Shares * PricePerShare.")]
    public decimal TotalValue => Shares * PricePerShare;

    [Comment("The step in the milestone sequence to which this transaction belongs.")]
    public int MilestoneStep { get; set; }

    [Comment("Indicates whether this transaction is a buy order (true) or a sell order (false).")]
    public bool IsBuyOrder { get; set; }
}