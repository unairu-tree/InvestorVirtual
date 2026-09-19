namespace InvestorVirtual.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static Common.EntityValidation;

// This model represents the news articles that are written for each of the stocks to keep track of what is happening in the stock market
public class News
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(HeadlineMaxLength)]
    public string Headline { get; set; } = null!; // This is the news article's headline   --will most likely be the only thing visible if I make a list or article catalog that holds all articles, before clicking on it to open said article

    [Required]
    public string Body { get; set; } = null!; // This is the main story surrounding the stock

    [Required]
    [MaxLength(SourceMaxLength)]
    public string Source { get; set; } = null!; // This is the source or sources of the article
}