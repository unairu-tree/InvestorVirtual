namespace InvestorVirtual.Data.Models;

using System.ComponentModel.DataAnnotations;

using static Common.EntityValidation;

// This model represents the stocks each user can interact with, that includes...
public class Stock
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(TickerMaxLength)]
    public string Ticker { get; set; } = null!; // the company ticker (a short, 3-4 letter, all caps name specific to stocks trading)

    [Required]
    [MaxLength(CompanyNameMaxLength)]
    public string CompanyName { get; set; } = null!; // the company name

    [Required]
    [MaxLength(ShortDescriptionMaxLength)]
    public string ShortDescription { get; set; } = null!; // a short description for the company and their business

    [Required]
    [MaxLength(SectorMaxLength)]
    public string Sector { get; set; } = null!; // the sector said company operates in

    [Required]
    [MaxLength(LogoPathMaxLength)]
    public string LogoPath { get; set; } = null!; // the company logo

    public virtual ICollection<Event> Events { get; set; } = new HashSet<Event>();
}