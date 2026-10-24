namespace InvestorVirtual.Controllers;

using Microsoft.AspNetCore.Mvc;

using InvestorVirtual.Core.Contracts;
using InvestorVirtual.Core.Models.Response;

public class InvestmentController(IInvestmentService investmentService) : BaseController
{
    [HttpGet]
    public IActionResult Index(string? searchQuery, string? sector, string? sorting)
    {
        IEnumerable<AllAssetsModel> allAssets = investmentService.GetAllAssets(searchQuery, sector, sorting);

        return View(allAssets);
    }

    [HttpGet]
    public IActionResult Portfolio()
    {
        return View();
    }
}