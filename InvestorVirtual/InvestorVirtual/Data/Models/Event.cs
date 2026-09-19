namespace InvestorVirtual.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static Common.EntityValidation;

// This model represents the main hub that links the price, news, analysis together and then links to the stock
public class Event
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(TitleMaxLength)]
    public string Title { get; set; } = null!; // This will hold the title and will cover important aspects of a company's events

    public DateTime Date { get; set; } // This will record the date of the event and is the main reason all other models connect to it, because on a specific date an event happens which triggers a price change, a news article written, and a new analysis made

    [ForeignKey(nameof(Stock))]
    public int StockId { get; set; } // Here I reference the stock

    public virtual Stock Stock { get; set; } = null!;

    [ForeignKey(nameof(Price))]
    public int PriceId { get; set; } // Here I reference the price

    public virtual Price Price { get; set; } = null!;

    [ForeignKey(nameof(News))]
    public int NewsId { get; set; } // Here I reference the news

    public virtual News News { get; set; } = null!;

    [ForeignKey(nameof(Analysis))]
    public int AnalysisId { get; set; } // Here I reference the analysis

    public virtual Analysis Analysis { get; set; } = null!;
}