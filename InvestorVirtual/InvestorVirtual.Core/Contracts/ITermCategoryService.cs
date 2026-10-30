namespace InvestorVirtual.Services.Core.Contracts;

using InvestorVirtual.Services.Core.Data.Learning.Response;

public interface ITermCategoryService
{
    IEnumerable<AllLearningTermCategoriesModel> GetAllCategories();
}