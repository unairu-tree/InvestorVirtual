namespace InvestorVirtual.Core.Services;

using Microsoft.Extensions.Logging;

using InvestorVirtual.Core.Contracts;
using InvestorVirtual.Core.Models.Request;
using InvestorVirtual.Core.Models.Response;

using InvestorVirtual.Data.Common;
using InvestorVirtual.Data.Models;
using InvestorVirtual.Data.Models.Enums;

using static InvestorVirtual.Common.ApplicationConstants;

// This is the learning service inheriting and implementing the tasks from the interface
public class LearningService(IRepository repository, ILogger<LearningService> logger) : ILearningService
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
                Slug = lt.Slug,
                TermName = lt.TermName,
                Description = lt.Description,
                Category = lt.Category
            })
            .ToArray();
    }

    public void AddLeraningTerm(LearningTermRequestModel model)
    {
        // Using try catch here to catch and handle the error in the back-end and log it for the developer
        try
        {
            LearningTerm learningTerm = new LearningTerm
            {
                TermName = model.TermName,
                Slug = model.Slug,
                Description = model.Description,
                Category = (TermCategory)model.CategoryId // Translating the id back into an enum
            };

            repository.Add(learningTerm);
            repository.SaveChanges();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while saving a new learning term.");

            throw;
        }
    }

    public int GetTotalLearningTermsCount() => repository.All<LearningTerm>().Count();
}