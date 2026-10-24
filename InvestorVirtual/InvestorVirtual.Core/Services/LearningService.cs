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
            .Where(lt => lt.IsDeleted == false)
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

    public LearningServiceModel? GetLearningTerm(int id, string slug)
    {
        return repository.All<LearningTerm>()
            .Where(lt => lt.Id == id
            && lt.Slug == slug
            && lt.IsDeleted == false)
            .Select(lt => new LearningServiceModel
            {
                Id = lt.Id,
                Slug = lt.Slug,
                TermName = lt.TermName,
                Description = lt.Description,
                Category = lt.Category
            })
            .FirstOrDefault();
    }

    // A check for if a term exists before creating a new one
    public bool LearningTermExists(string name, string slug)
    {
        return repository.All<LearningTerm>()
            .Any(t => t.Slug == slug
            && t.TermName == name
            && !t.IsDeleted);
    }

    // A specific check for if a term exists when editing. Checks ANY other term besides the one being edited.
    public bool LearningTermExistsForEdit(int currentId, string name, string slug)
    {
        return repository.All<LearningTerm>()
            .Any(t => t.Id != currentId
            && (t.Slug == slug || t.TermName == name)
            && !t.IsDeleted);
    }

    public void AddLeraningTerm(LearningTermRequestModel model)
    {
        // Using try catch here to catch and handle the error in the back-end and log it for the developer
        try
        {
            // Switching the soft-delete off and applying the changes to the term
            LearningTerm? existingTerm = repository.All<LearningTerm>()
                .FirstOrDefault(t => t.Slug == model.Slug || t.TermName == model.TermName);

            if (existingTerm != null && existingTerm.IsDeleted)
            {
                // Removing soft-delete on terms when a user tries submitting a term very similar to past deleted one.
                UndeleteAndModifyTerm(existingTerm, model);
            }
            else
            {
                // Adding the new term if it does not exist yet
                LearningTerm learningTerm = new LearningTerm
                {
                    TermName = model.TermName,
                    Slug = model.Slug,
                    Description = model.Description,
                    Category = (TermCategory)model.CategoryId // Translating the id back into an enum
                };

                repository.Add(learningTerm);
            }

            repository.SaveChanges();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while saving a new learning term!");

            throw;
        }
    }

    public void EditLearningTerm(int id, string slug, LearningTermRequestModel model)
    {
        try
        {
            LearningTerm? existingTerm = repository.All<LearningTerm>()
                .FirstOrDefault(lt => lt.Id == id && lt.Slug == slug && !lt.IsDeleted);

            if (existingTerm == null)
            {
                throw new InvalidOperationException($"Learning term with ID {id} and slug '{slug}' was not found.");
            }

            existingTerm.TermName = model.TermName;
            existingTerm.Slug = model.Slug;
            existingTerm.Description = model.Description;
            existingTerm.Category = (TermCategory)model.CategoryId;

            repository.SaveChanges();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while editing a learning term!");
            throw;
        }
    }

    public void DeleteLearningTerm(int id)
    {
        LearningTerm? term = repository.All<LearningTerm>().FirstOrDefault(t => t.Id == id);

        if (term != null)
        {
            term.IsDeleted = true;
            repository.SaveChanges();
        }
    }

    public int GetTotalLearningTermsCount() => repository
        .All<LearningTerm>()
        .Where(lt => lt.IsDeleted == false)
        .Count();

    /* PRIVATE METHODS FOR USE IN THE SERVICE ONLY */
    private void UndeleteAndModifyTerm(LearningTerm existingTerm, LearningTermRequestModel model)
    {
        existingTerm.TermName = model.TermName;
        existingTerm.Slug = model.Slug;
        existingTerm.Description = model.Description;
        existingTerm.Category = (TermCategory)model.CategoryId;
        existingTerm.IsDeleted = false;
    }
}