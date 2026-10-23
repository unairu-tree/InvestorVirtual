namespace InvestorVirtual.Core.Contracts;

using Models;

// This is the interface inherited by the services responsible for passing data to the learning controller
public interface ILearningService
{
    // A collection fetching from the DB and applying pagination to the learning terms through an EF Core query
    IEnumerable<LearningServiceModel> GetAllLearningTerms(int page);
}