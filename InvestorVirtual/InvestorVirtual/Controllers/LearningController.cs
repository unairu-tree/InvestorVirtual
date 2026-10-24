namespace InvestorVirtual.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using InvestorVirtual.Core.Contracts;
using InvestorVirtual.Core.Models.Request;
using InvestorVirtual.Core.Models.Response;

using InvestorVirtual.ViewModels.Learning;

using static InvestorVirtual.Common.ApplicationConstants;

public class LearningController(ILearningService learningService, ITermCategoryService termCategoryService) : BaseController
{
    [HttpGet]
    [AllowAnonymous]
    public IActionResult Index([FromQuery] int page = 1) // The view hands a page number in the query and I pull it with this attribute to hand to the service
    {
        IEnumerable<LearningServiceModel> learningTerms = learningService.GetAllLearningTerms(page);

        int totalTerms = learningService.GetTotalLearningTermsCount(); // Using the count of the total terms to dynamically calculate the amount of pages needed for viewing

        int pageSize = DefaultPageSize;
        int totalPages = (int)Math.Ceiling(totalTerms / (double)pageSize);

        ViewBag.TotalPages = totalPages;
        ViewBag.CurrentPage = page;

        return View(learningTerms);
    }

    [HttpGet]
    public IActionResult Create()
    {
        // Populating the "multi-way" model's category collection
        LearningTermInputModel model = new LearningTermInputModel
        {
            Categories = termCategoryService.GetAllCategories()
        };

        return View(model);
    }

    [HttpPost]
    public IActionResult Create(LearningTermInputModel model)
    {
        if (!ModelState.IsValid)
        {
            ModelState.AddModelError(string.Empty, "Invalid data was detected! Please try again!");

            // Re-populating the "multi-way" model's category collection
            model.Categories = termCategoryService.GetAllCategories();
            return View(model);
        }

        bool isCategoryValid = termCategoryService.GetAllCategories()
            .Any(c => c.Id == model.CategoryId);

        if (!isCategoryValid)
        {
            ModelState.AddModelError(nameof(model.CategoryId), "Please select a valid category.");

            // Re-populating the "multi-way" model's category collection
            model.Categories = termCategoryService.GetAllCategories();
            return View(model);
        }

        if (learningService.LearningTermExists(model.TermName, model.Slug))
        {
            ModelState.AddModelError(string.Empty, "A learning term with this name or slug already exists.");

            // Re-populating the "multi-way" model's category collection
            model.Categories = termCategoryService.GetAllCategories();
            return View(model);
        }

        // Using try-catch here to catch the deeper error and show it to the end user as well
        try
        {
            LearningTermRequestModel serviceModel = new LearningTermRequestModel
            {
                TermName = model.TermName,
                Slug = model.Slug,
                Description = model.Description,
                CategoryId = model.CategoryId
            };

            learningService.AddLeraningTerm(serviceModel);

            TempData["SuccessMessage"] = "Successfully added new learning term!";
        }
        catch (Exception)
        {
            TempData["ErrorMessage"] = "An unexpected error occurred while saving your data! Please try again later or contact an administrator!";

            // Re-populating the "multi-way" model's category collection
            model.Categories = termCategoryService.GetAllCategories();
            return View(model);
        }

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    [Route("Learning/Edit/{id}/{slug}")]
    public IActionResult Edit(int id, string slug)
    {
        LearningServiceModel? existingTerm = learningService.GetLearningTerm(id, slug);

        if (existingTerm == null)
        {
            return NotFound();
        }

        LearningTermInputModel model = new LearningTermInputModel
        {
            TermName = existingTerm.TermName,
            Slug = existingTerm.Slug,
            Description = existingTerm.Description,
            CategoryId = (int)existingTerm.Category,
            Categories = termCategoryService.GetAllCategories()
        };

        return View(model);
    }

    [HttpPost]
    [Route("Learning/Edit/{id}/{slug}")]
    public IActionResult Edit(int id, string slug, LearningTermInputModel model)
    {
        LearningServiceModel? existingTerm = learningService.GetLearningTerm(id, slug);

        if (existingTerm == null)
        {
            TempData["ErrorMessage"] = "Security validation failed! Editing aborted!";
            return RedirectToAction(nameof(Index));
        }

        if (!ModelState.IsValid)
        {
            // Re-populating the "multi-way" model's category collection
            model.Categories = termCategoryService.GetAllCategories();
            return View(model);
        }

        if (learningService.LearningTermExistsForEdit(id, model.TermName, model.Slug))
        {
            ModelState.AddModelError(string.Empty, "A learning term with this name already exists.");

            // Re-populating the "multi-way" model's category collection
            model.Categories = termCategoryService.GetAllCategories();
            return View(model);
        }

        try
        {
            LearningTermRequestModel serviceModel = new LearningTermRequestModel
            {
                TermName = model.TermName,
                Slug = model.Slug,
                Description = model.Description,
                CategoryId = model.CategoryId
            };

            learningService.EditLearningTerm(id, slug, serviceModel);

            TempData["SuccessMessage"] = "Successfully edited the learning term!";
        }
        catch (Exception)
        {
            TempData["ErrorMessage"] = "An unexpected error occurred while saving your data! Please try again later or contact an administrator!";

            // Re-populating the "multi-way" model's category collection
            model.Categories = termCategoryService.GetAllCategories();
            return View(model);
        }

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    [Route("Learning/Delete/{id}/{slug}")]
    public async Task<IActionResult> Delete(int id, string slug) // Using both the ID and Slug so the user does not tamper their way into opening a wrong term deletion screen
    {
        LearningServiceModel? term = learningService.GetLearningTerm(id, slug);

        if (term == null)
        {
            return NotFound();
        }

        return View(term);
    }

    [HttpPost]
    [ActionName("Delete")]
    [Route("Learning/Delete/{id}/{slug}")]
    public IActionResult DeleteConfirmed(int id, string slug) // Using both the ID and Slug so even if the user opens a deletion screen normally, they don't tamper their way into deleting the wrong term
    {
        LearningServiceModel? term = learningService.GetLearningTerm(id, slug);

        if (term == null)
        {
            TempData["ErrorMessage"] = "Security validation failed! Deletion aborted!";

            return RedirectToAction(nameof(Index));
        }

        try
        {
            learningService.DeleteLearningTerm(id); // Not sending the slug down to .Core since it has already been checked for tampering
            TempData["SuccessMessage"] = "Learning term successfully deleted!";
        }
        catch (Exception)
        {
            TempData["ErrorMessage"] = "An error occurred while trying to delete the term.";
        }

        return RedirectToAction(nameof(Index));
    }
}