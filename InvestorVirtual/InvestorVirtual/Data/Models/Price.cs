namespace InvestorVirtual.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// This model represents the price movements and buy/sell volume of every stock on a daily basis
public class Price
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "DECIMAL(6, 2)")]
    public decimal PriceValue { get; set; } // This is the current price for 1 share of a stock

    public long BuyVolume { get; set; } // This is how much shares of a stock were bought in a specific time span (e.g. a day, a week, a month,)

    public long SellVolume { get; set; } // This is how much shares of a stock were sold in a specific time span (e.g. a day, a week, a month,)

    [NotMapped] // Not mapped, because we don't really need them to increase the DB storage
    public long TotalVolume => BuyVolume + SellVolume;  // This calculates the total volume of market movements
                                                        // Will calculate dynamically every time we reference it and will not exist anywhere before that
    [NotMapped]
    public bool IsBullishVolume => BuyVolume >= SellVolume; // This checks if buyers or sellers were driving the market movements that day
                                                            // Will dynamically return true/false every time we reference it and will not exist anywhere before that
}