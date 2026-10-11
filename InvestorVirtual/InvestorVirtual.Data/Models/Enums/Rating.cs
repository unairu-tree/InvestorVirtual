namespace InvestorVirtual.Data.Models.Enums;

using System.ComponentModel.DataAnnotations;

// These ratings are used by the analysts to rate the stock based on their analysis
public enum Rating
{
    [Display(Name = "Strong Sell")]
    StrongSell = 1,

    [Display(Name = "Sell")]
    Sell = 2,

    [Display(Name = "Hold")]
    Hold = 3,

    [Display(Name = "Buy")]
    Buy = 4,

    [Display(Name = "Strong Buy")]
    StrongBuy = 5
}