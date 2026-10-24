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
        }
        catch (Exception)
        {
            ModelState.AddModelError(string.Empty, "An unexpected error occurred while saving your data! Please try again later or contact an administrator!");

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
        return View();
    }

    [HttpPost]
    public IActionResult Edit(LearningTermInputModel model)
    {
        return RedirectToAction(nameof(Index));
    }
}