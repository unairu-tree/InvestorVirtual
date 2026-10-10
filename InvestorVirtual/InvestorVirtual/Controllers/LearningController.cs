namespace InvestorVirtual.Controllers;

using Microsoft.AspNetCore.Mvc;

using Data;
using ViewModels.Learning;

using static Common.ApplicationConstants;

public class LearningController : Controller
{
    private readonly ApplicationDbContext applicationDbContext;

    public LearningController(ApplicationDbContext applicationDbContext)
    {
        this.applicationDbContext = applicationDbContext;
    }

    [HttpGet]
    public IActionResult Index([FromQuery] int page = 1)
    {
        IEnumerable<LearningIndexViewModel> learningIndexViewModels = this.applicationDbContext.LearningTerms
            .OrderBy(learningTerm => learningTerm.TermName)
            .Skip((page - 1) * DefaultPageSize)
            .Take(DefaultPageSize)
            .Select(learningTerm => new LearningIndexViewModel
            {
                TermName = learningTerm.TermName,
                Description = learningTerm.Description,
                Category = learningTerm.Category
            })
            .ToArray();

        return View(learningIndexViewModels);
    }
}