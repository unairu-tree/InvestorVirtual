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
    public IActionResult Error(int? statusCode)
    {
        int resolvedStatusCode = statusCode ?? StatusCodes.Status500InternalServerError;

        (string title, string message) = resolvedStatusCode switch
        {
            StatusCodes.Status400BadRequest => ("Bad request", "The request could not be processed. Check the information you submitted and try again."),
            StatusCodes.Status401Unauthorized => ("Sign-in required", "This market terminal requires an authenticated session. Sign in to continue."),
            StatusCodes.Status403Forbidden => ("Access restricted", "Your account does not have permission to access this part of the terminal."),
            StatusCodes.Status404NotFound => ("Page not found", "The page or market resource you requested could not be found."),
            StatusCodes.Status500InternalServerError => ("Market interruption", "An unexpected server issue interrupted this request. Please try again later."),
            _ => ("Request unavailable", "The request could not be completed. Return to the dashboard or try again later.")
        };

        ErrorViewModel model = new()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
            StatusCode = resolvedStatusCode,
            Title = title,
            Message = message
        };

        Response.StatusCode = resolvedStatusCode;

        return resolvedStatusCode switch
        {
            StatusCodes.Status400BadRequest => View("BadRequest", model),
            StatusCodes.Status401Unauthorized => View("Unauthorized", model),
            StatusCodes.Status403Forbidden => View("Forbidden", model),
            StatusCodes.Status404NotFound => View("NotFound", model),
            StatusCodes.Status500InternalServerError => View("ServerError", model),
            _ => View("Error", model)
        };
    }
}