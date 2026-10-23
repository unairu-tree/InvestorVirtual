namespace InvestorVirtual.Controllers;

using Microsoft.AspNetCore.Mvc;

using InvestorVirtual.Core.Models;
using InvestorVirtual.Core.Contracts;

public class LearningController(ILearningService learningService) : BaseController
{
    [HttpGet]
    public IActionResult Index([FromQuery] int page = 1)
    {
        IEnumerable<LearningServiceModel> learningTerms = learningService.GetAllLearningTerms(page);

        return View(learningTerms);
    }
}