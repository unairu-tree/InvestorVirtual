namespace InvestorVirtual.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Enums;

using static Common.EntityValidation;

// This model represents the analysis surrounding each stock based on the events that happen in the world
public class Analysis
{
    [Key]
    public int Id { get; set; }

    public Rating Rating { get; set; } // This represents the rating from 'Strong-Sell' to "Strong-Buy" given by the analysts

    [Required]
    [MaxLength(ReasoningMaxLength)]
    public string Reasoning { get; set; } = null!; // This is the explanation the analysts give to explain their rating

    [Column(TypeName = "DECIMAL(6, 2)")]
    public decimal TargetPrice { get; set; } // This is the price expected by analysts to be reached by the stock

    public int AnalystCount { get; set; } // This is the count of analysts that have taken part in the analysis of the stock
}