namespace InvestorVirtual.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Watchlist
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string UserId { get; set; } = null!;

    [ForeignKey(nameof(Stock))]
    public int StockId { get; set; }

    public virtual Stock Stock { get; set; } = null!;
}