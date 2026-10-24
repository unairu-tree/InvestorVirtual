namespace InvestorVirtual.Core.Contracts;

using InvestorVirtual.Core.Models.Response;

public interface ITermCategoryService
{
    IEnumerable<AllLearningTermCategoriesModel> GetAllCategories();
}