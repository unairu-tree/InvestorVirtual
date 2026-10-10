namespace InvestorVirtual.Controllers;

using Microsoft.AspNetCore.Mvc;

public class InvestmentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Portfolio()
    {
        return View();
    }
}