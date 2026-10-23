namespace InvestorVirtual.Data.Models;

using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;

using static InvestorVirtual.Common.EntityValidation.Stock;

// This model represents the stocks each user can interact with, that includes...
[Comment("This model represents the stocks each user can interact with")]
public class Stock
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(TickerMaxLength)]
    [Comment("This is the company ticker (a short, 3-4 letter, all caps name specific to stocks trading)")]
    public string Ticker { get; set; } = null!; // the company ticker (a short, 3-4 letter, all caps name specific to stocks trading)

    [Required]
    [MaxLength(CompanyNameMaxLength)]
    [Comment("This is the company name")]
    public string CompanyName { get; set; } = null!; // the company name

    [Required]
    [MaxLength(ShortDescriptionMaxLength)]
    [Comment("This is a short description for the company and their business")]
    public string ShortDescription { get; set; } = null!; // a short description for the company and their business

    [Required]
    [MaxLength(SectorMaxLength)]
    [Comment("This is the sector the company operates in")]
    public string Sector { get; set; } = null!; // the sector said company operates in

    [Required]
    [MaxLength(LogoPathMaxLength)]
    [Comment("This is the path to the company logo")]
    public string LogoPath { get; set; } = null!; // the company logo

    public virtual ICollection<Event> Events { get; set; } = new HashSet<Event>();

    [Comment("Soft-delete boolean")]
    public bool isDeleted { get; set; } = false;
}