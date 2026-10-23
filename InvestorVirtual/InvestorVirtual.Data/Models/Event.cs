namespace InvestorVirtual.Data.Models;

using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static InvestorVirtual.Common.EntityValidation.Event;

// This model represents the main hub that links the price, news, analysis together and then links to the stock
[Comment("This model represents the main hub that links the price, news, analysis together and then links to the stock")]
public class Event
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(TitleMaxLength)]
    [Comment("This will hold the title and will cover important aspects of a company's events")]
    public string Title { get; set; } = null!; // This will hold the title and will cover important aspects of a company's events

    [Comment("This will record the date of the event")]
    public DateTime Date { get; set; } // It is the main reason all other models connect to it, because on a specific date an event happens which triggers a price change, a news article written, and a new analysis made

    [ForeignKey(nameof(Stock))]
    [Comment("This will reference the stock associated with the event")]
    public int StockId { get; set; } // Here I reference the stock

    public virtual Stock Stock { get; set; } = null!;

    public virtual Price Price { get; set; } = null!;

    public virtual News News { get; set; } = null!;

    public virtual Analysis Analysis { get; set; } = null!;

    [Comment("Soft-delete boolean")]
    public bool isDeleted { get; set; } = false;
}