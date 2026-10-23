namespace InvestorVirtual.Controllers;

using Microsoft.AspNetCore.Mvc;

using InvestorVirtual.Core.Models;
using InvestorVirtual.Core.Contracts;

public class InvestmentController(IInvestmentService investmentService) : BaseController
{
    public IActionResult Index()
    {
        IEnumerable<AllAssetsModel> allAssets = investmentService.GetAllAssets();

        return View(allAssets);
    }

    public IActionResult Portfolio()
    {
        return View();
    }
}