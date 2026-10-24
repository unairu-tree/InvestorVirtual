namespace InvestorVirtual.ViewModels.Learning;

using System.ComponentModel.DataAnnotations;
using InvestorVirtual.Core.Models.Response;
using static InvestorVirtual.Common.EntityValidation.LearningTerm;

public class LearningTermInputModel
{
    // Input model (Validation required)
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

    // Used to populate the dropdown with the enums from .Data (No validation required)
    public IEnumerable<AllLearningTermCategoriesModel> Categories { get; set; } = new List<AllLearningTermCategoriesModel>();
}