namespace InvestorVirtual.Core.Services;

using Models;
using Contracts;

using InvestorVirtual.Data.Models;
using InvestorVirtual.Data.Common;

using static InvestorVirtual.Common.ApplicationConstants;

// This is the learning service inheriting and implementing the tasks from the interface
public class LearningService(IRepository repository) : ILearningService
{
    // Learning terms fetching with implemented .Skip()/.Take() pagination logic. "int page" comes from the controller.
    public IEnumerable<LearningServiceModel> GetAllLearningTerms(int page)
    {
        return repository.All<LearningTerm>()
            .OrderBy(lt => lt.TermName)
            .Skip((page - 1) * DefaultPageSize)
            .Take(DefaultPageSize)
            .Select(lt => new LearningServiceModel
            {
                Id = lt.Id,
                TermName = lt.TermName,
                Description = lt.Description,
                Category = lt.Category
            })
            .ToArray();
    }
}