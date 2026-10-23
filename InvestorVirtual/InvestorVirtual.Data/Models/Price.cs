namespace InvestorVirtual.Data.Models;

using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static InvestorVirtual.Common.ApplicationConstants;

// This model represents the price movements and buy/sell volume of every stock on a daily basis
[Comment("This model represents the price movements and buy/sell volume of every stock on a daily basis")]
public class Price
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = PricePerShareColumnType)]
    [Comment("This is the current price for 1 share of a stock")]
    public decimal PriceValue { get; set; } // This is the current price for 1 share of a stock

    [Comment("This is how much shares of a stock were bought/sold in a specific time span (e.g. a day, a week, a month,)")]
    public long Volume { get; set; } // This is how much shares of a stock were bought/sold in a specific time span (e.g. a day, a week, a month,)

    [Comment("This is a boolean that will determine if the volume is bullish or bearish, if the volume is bullish it will be true, if it is bearish it will be false")]
    public bool IsBullishVolume { get; set; } // This is a boolean that will determine if the volume is bullish or bearish, if the volume is bullish it will be true, if it is bearish it will be false

    [ForeignKey(nameof(Event))]
    [Comment("This will reference the event associated with the price")]
    public int EventId { get; set; } // Here I reference the event

    public virtual Event Event { get; set; } = null!;

    // Lacks soft-delete boolean because all prices are queried through the event, which has a soft-delete boolean
}