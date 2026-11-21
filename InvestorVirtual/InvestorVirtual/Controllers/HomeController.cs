namespace InvestorVirtual.Web.Controllers;

using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using InvestorVirtual.Web.ViewModels;

using InvestorVirtual.Services.Core.Contracts;
using InvestorVirtual.Services.Core.Data.Investment.Response;

[AllowAnonymous]
public class HomeController(IHomeService homeService) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        IEnumerable<AssetShowcaseModel> assetShowcases = await homeService.GetAssetShowcasesAsync();

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