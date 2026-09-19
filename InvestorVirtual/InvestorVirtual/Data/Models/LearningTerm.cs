namespace InvestorVirtual.Data.Models;

using System.ComponentModel.DataAnnotations;

using Enums;

using static Common.EntityValidation;

// This model is independent from the others and represents the financial terms with descriptions about them for the users to read and learn
public class LearningTerm
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(TermNameMaxLength)]
    public string TermName { get; set; } = null!; // This is what the name of the term is

    [Required]
    public string Description { get; set; } = null!; // This will hold the explanation and description of the term with or without examples

    public TermCategory Category { get; set; } // This will show the category of the term
}