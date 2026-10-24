namespace InvestorVirtual.Data.Models;

using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;

using Enums;

using static InvestorVirtual.Common.EntityValidation.LearningTerm;

// This model is independent from the others and represents the financial terms with descriptions about them for the users to read and learn
[Comment("This model is independent from the others and represents the financial terms with descriptions about them for the users to read and learn")]
public class LearningTerm
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(SlugMaxLength)]
    [Comment("This is the field that will hold the slug used for extra security and SEO")]
    public string Slug { get; set; } = null!;

    [Required]
    [MaxLength(TermNameMaxLength)]
    [Comment("This is what the name of the term is")]
    public string TermName { get; set; } = null!; // This is what the name of the term is

    [Required]
    [Comment("This is the description of the term")]
    public string Description { get; set; } = null!; // This will hold the explanation and description of the term with or without examples

    [Comment("This will show the category of the term")]
    public TermCategory Category { get; set; } // This will show the category of the term

    [Comment("Soft-delete boolean")]
    public bool IsDeleted { get; set; }
}