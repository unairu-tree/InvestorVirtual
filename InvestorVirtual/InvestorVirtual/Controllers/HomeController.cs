namespace InvestorVirtual.Controllers;

using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using InvestorVirtual.ViewModels;
using InvestorVirtual.Core.Contracts;
using InvestorVirtual.Core.Models.Response;

[AllowAnonymous]
public class HomeController(IHomeService homeService) : BaseController
{
    [HttpGet]
    public IActionResult Index()
    {
        IEnumerable<AssetShowcaseModel> assetShowcases = homeService.GetAssetShowcases();

        return View(assetShowcases);
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Journey()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}