namespace InvestorVirtual.Core.Services;

using InvestorVirtual.Data.Common;

using Models;
using Contracts;

using static InvestorVirtual.Common.ApplicationConstants;
using InvestorVirtual.Data.Models;

public class LearningService(IRepository repository) : ILearningService
{
    public IEnumerable<LearningServiceModel> GetAllLearningTerms(int page)
    {
        // DEPRECATED - Tried adjusting this code to work before I rewatched the lecture and understood how to handle it in the 'return'

        // IEnumerable<LearningServiceModel> learningServiceModel = this.applicationDbContext.LearningTerms
        //     .OrderBy(learningTerm => learningTerm.TermName)
        //     .Skip((page - 1) * DefaultPageSize)
        //     .Take(DefaultPageSize)
        //     .Select(learningTerm => new LearningServiceModel
        //     {
        //         TermName = learningTerm.TermName,
        //         Description = learningTerm.Description,
        //         Category = learningTerm.Category
        //     })
        //     .ToArray();

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