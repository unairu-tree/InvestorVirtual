namespace InvestorVirtual.Core.Contracts;

using Models;

public interface ILearningService
{
    IEnumerable<LearningServiceModel> GetAllLearningTerms(int page);
}