namespace InvestorVirtual.Core.Contracts;

using InvestorVirtual.Core.Models.Request;
using InvestorVirtual.Core.Models.Response;

// This is the interface inherited by the services responsible for passing data to the learning controller
public interface ILearningService
{
    // A collection fetching from the DB and applying pagination to the learning terms through an EF Core query
    IEnumerable<LearningServiceModel> GetAllLearningTerms(int page);

    // Fetching a single learning term (used for edit and delete)
    LearningServiceModel? GetLearningTerm(int id, string slug);

    // A method for saving the new term to the DB
    void AddLeraningTerm(LearningTermRequestModel model);

    // A method for editing an existing term
    void EditLearningTerm(int id, string slug, LearningTermRequestModel model);

    // A method to change the IsDeleted field of a learning term to true
    void DeleteLearningTerm(int id);

    // A method to fetch the total number of learning terms (used for dynamic page button generation for the view)
    int GetTotalLearningTermsCount();

    // A method to check if a term exists
    bool LearningTermExists(string name, string slug);

    // A method to check if a term exists besides the one being currently edited
    bool LearningTermExistsForEdit(int currentId, string name, string slug);
}