namespace InvestorVirtual.Core.Services;

using Models;
using Contracts;

using InvestorVirtual.Data.Models;
using InvestorVirtual.Data.Common;

using static InvestorVirtual.Common.ApplicationConstants;

public class LearningService(IRepository repository) : ILearningService
{
    public IEnumerable<LearningServiceModel> GetAllLearningTerms(int page)
    {
        return repository.All<LearningTerm>()
            .OrderBy(learningTerm => learningTerm.TermName)
            .Skip((page - 1) * DefaultPageSize)
            .Take(DefaultPageSize)
            .Select(learningTerm => new LearningServiceModel
            {
                TermName = learningTerm.TermName,
                Description = learningTerm.Description,
                Category = learningTerm.Category
            })
            .ToArray();
    }
}