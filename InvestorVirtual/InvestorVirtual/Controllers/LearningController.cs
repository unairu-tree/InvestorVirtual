namespace InvestorVirtual.Controllers;

using Microsoft.AspNetCore.Mvc;

using InvestorVirtual.Core.Models;
using InvestorVirtual.Core.Contracts;
using Microsoft.AspNetCore.Authorization;

public class LearningController(ILearningService learningService) : BaseController
{
    [HttpGet]
    [AllowAnonymous]
    public IActionResult Index([FromQuery] int page = 1) // The view hands a page number in the query and I pull it with this attribute to hand to the service
    {
        IEnumerable<LearningServiceModel> learningTerms = learningService.GetAllLearningTerms(page);

        return View(learningTerms);
    }
}