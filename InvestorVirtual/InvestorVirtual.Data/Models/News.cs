namespace InvestorVirtual.Data.Models;

using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static InvestorVirtual.Common.EntityValidation.News;

// This model represents the news articles that are written for each of the stocks to keep track of what is happening in the stock market
[Comment("This model represents the news articles that are written for each of the stocks to keep track of what is happening in the stock market")]
public class News
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(HeadlineMaxLength)]
    [Comment("This is the news article's headline")]
    public string Headline { get; set; } = null!; // This is the news article's headline   --will most likely be the only thing visible if I make a list or article catalog that holds all articles, before clicking on it to open said article

    [Required]
    [Comment("This is the main story surrounding the stock")]
    public string Body { get; set; } = null!; // This is the main story surrounding the stock

    [Required]
    [MaxLength(SourceMaxLength)]
    [Comment("This is the source or sources of the article")]
    public string Source { get; set; } = null!; // This is the source or sources of the article

    [ForeignKey(nameof(Event))]
    [Comment("This will reference the event associated with the news")]
    public int EventId { get; set; } // Here I reference the event

    public virtual Event Event { get; set; } = null!;

    // Lacks soft-delete boolean because all news articles are queried through the event, which has a soft-delete boolean
}