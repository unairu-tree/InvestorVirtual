namespace InvestorVirtual.Core.Services;

using InvestorVirtual.Core.Contracts;
using InvestorVirtual.Data.Models.Enums;
using InvestorVirtual.Common.Extensions;
using InvestorVirtual.Core.Models.Response;

public class TermCategoryService : ITermCategoryService
{
    // Sending the enum values up for the dropdowns by separating them cleanly into IDs and readable text
    public IEnumerable<AllLearningTermCategoriesModel> GetAllCategories()
    {
        return Enum.GetValues<TermCategory>()
            .Select(c => new AllLearningTermCategoriesModel
            {
                Id = (int)c, // Translates the enum into an id
                Name = c.GetDisplayName() // Again using the help of the extension method
            });
    }
}