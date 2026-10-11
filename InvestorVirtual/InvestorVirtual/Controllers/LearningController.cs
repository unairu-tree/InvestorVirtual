namespace InvestorVirtual.Controllers;

using Microsoft.AspNetCore.Mvc;

using InvestorVirtual.Core.Models;
using InvestorVirtual.Core.Contracts;

// DEPRECATED USINGS
using ViewModels.Learning;
using InvestorVirtual.Data;

using static Common.ApplicationConstants;
// DEPRECATED USINGS

public class LearningController(ILearningService learningService) : Controller
{
    [HttpGet]
    public IActionResult Index([FromQuery] int page = 1)
    {
        // DEPRECATED - logic moved to the service layer

        // IEnumerable<LearningIndexViewModel> learningIndexViewModels = this.applicationDbContext.LearningTerms
        //     .OrderBy(learningTerm => learningTerm.TermName)
        //     .Skip((page - 1) * DefaultPageSize)
        //     .Take(DefaultPageSize)
        //     .Select(learningTerm => new LearningIndexViewModel
        //     {
        //         TermName = learningTerm.TermName,
        //         Description = learningTerm.Description,
        //         Category = learningTerm.Category
        //     })
        //     .ToArray();

        IEnumerable<LearningServiceModel> learningTerms = learningService.GetAllLearningTerms(page);

        return View(learningTerms);
    }
}