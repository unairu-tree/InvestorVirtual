namespace InvestorVirtual.Services.Core;

using InvestorVirtual.Data.Models.Enums;

using InvestorVirtual.Services.Core.Contracts;
using InvestorVirtual.Services.Core.Data.Learning.Response;

using static InvestorVirtual.GCommon.Extensions.EnumNameExtensions;
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