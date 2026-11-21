namespace InvestorVirtual.Services.Core.Contracts;

using InvestorVirtual.Services.Core.Data.Learning.Request;
using InvestorVirtual.Services.Core.Data.Learning.Response;

// This is the interface inherited by the services responsible for passing data to the learning controller
public interface ILearningService
{
    // A collection fetching from the DB and applying pagination to the learning terms through an EF Core query
    Task<IEnumerable<LearningServiceModel>> GetAllLearningTermsAsync(int page);

    // Fetching a single learning term (used for edit and delete)
    Task<LearningServiceModel?> GetLearningTermAsync(int id, string slug);

    // A method for saving the new term to the DB
    Task AddLearningTermAsync(LearningTermRequestModel model);

    // A method for editing an existing term
    Task EditLearningTermAsync(int id, string slug, LearningTermRequestModel model);

    // A method to change the IsDeleted field of a learning term to true
    Task DeleteLearningTermAsync(int id);

    // A method to fetch the total number of learning terms (used for dynamic page button generation for the view)
    Task<int> GetTotalLearningTermsCountAsync();

    // A method to check if a term exists
    Task<bool> LearningTermExistsAsync(string name, string slug);

    // A method to check if a term exists besides the one being currently edited
    Task<bool> LearningTermExistsForEditAsync(int currentId, string name, string slug);
}