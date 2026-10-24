namespace InvestorVirtual.Core.Contracts;

using InvestorVirtual.Core.Models.Request;
using InvestorVirtual.Core.Models.Response;

// This is the interface inherited by the services responsible for passing data to the learning controller
public interface ILearningService
{
    // A collection fetching from the DB and applying pagination to the learning terms through an EF Core query
    IEnumerable<LearningServiceModel> GetAllLearningTerms(int page);

    // A method for saving the new term to the DB
    void AddLeraningTerm(LearningTermRequestModel model);

    // A method to fetch the total number of learning terms (used for dynamic page button generation for the view)
    int GetTotalLearningTermsCount();
}