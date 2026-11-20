namespace InvestorVirtual.Services.Core.Data.Learning.Request;

using System.ComponentModel.DataAnnotations;

using static InvestorVirtual.GCommon.EntityValidation.LearningTerm;

public class LearningTermRequestModel
{
    [Required]
    [StringLength(TermNameMaxLength, MinimumLength = TermNameMinLength)]
    public string TermName { get; set; } = null!;

    [Required]
    [StringLength(SlugMaxLength, MinimumLength = SlugMinLength)]
    [RegularExpression(SlugRegEx, ErrorMessage = SlugRegExErrorMessage)]
    public string Slug { get; set; } = null!;

    [Required]
    [MinLength(DescriptionMinLength)]
    public string Description { get; set; } = null!;

    public int CategoryId { get; set; }
}