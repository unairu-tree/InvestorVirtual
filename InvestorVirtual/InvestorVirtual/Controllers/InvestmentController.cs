namespace InvestorVirtual.Controllers;

using Microsoft.AspNetCore.Mvc;

using InvestorVirtual.Core.Contracts;
using InvestorVirtual.Core.Models.Response;
using InvestorVirtual.ViewModels.Investment;

public class InvestmentController(IInvestmentService investmentService, IDaySimulationService simulationService) : BaseController
{
    [HttpGet]
    public IActionResult Index(string? searchQuery, string? sector, string? sorting)
    {
        IEnumerable<AllAssetsModel> allAssets = investmentService.GetAllAssets(searchQuery, sector, sorting);

        return View(allAssets);
    }

    [HttpGet]
    public IActionResult Details(string ticker)
    {
        int currentDay = simulationService.GetSimulationStatus().Day;
        string? userId = GetUserId();

        StockDetailsModel? model = investmentService.GetStockDetails(ticker, currentDay, userId ?? string.Empty);

        if (model == null)
        {
            return NotFound();
        }

        return View(model);
    }

    [HttpPost]
    public IActionResult ToggleWatchlist(string ticker)
    {
        string? userId = GetUserId();

        if (string.IsNullOrEmpty(userId))
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        string portfolioGuid = investmentService.GetOrCreatePortfolioGuid(userId);

        bool isBookmarked = investmentService.ToggleWatchlist(portfolioGuid, ticker);

        if (isBookmarked)
        {
            TempData["SuccessMessage"] = $"{ticker} added to your Watchlist!";
        }
        else
        {
            TempData["Message"] = $"{ticker} removed from your Watchlist.";
        }

        return RedirectToAction(nameof(Details), new { ticker = ticker });
    }

    [HttpGet]
    public IActionResult Portfolio()
    {
        string? userId = GetUserId();

        if (string.IsNullOrEmpty(userId))
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        string portfolioGuid = investmentService.GetOrCreatePortfolioGuid(userId);

        DaySimulationModel dayModel = simulationService.GetSimulationStatus();

        PortfolioResponseModel portfolioModel = investmentService.GetPortfolioViewModel(portfolioGuid);

        PortfolioViewModel viewModel = new PortfolioViewModel
        { 
            Simulation = dayModel,
            Portfolio = portfolioModel.Portfolio,
            Watchlist = portfolioModel.Watchlist,
            Transactions = portfolioModel.Transactions
        };

        return View(viewModel);
    }

    [HttpPost]
    public IActionResult AdvanceDay()
    {
        int currentDay = simulationService.GetSimulationStatus().Day;

        if (currentDay >= 10)
        {
            TempData["Message"] = "Simulation is already at Day 10!";
            return RedirectToAction(nameof(Portfolio));
        }

        int newDay = simulationService.AdvanceDay();

        if (newDay == 10)
        {
            TempData["Message"] = "You have reached Day 10! Simulation complete.";
        }
        else
        {
            TempData["SuccessMessage"] = $"Advanced to Day {newDay} of 10.";
        }

        return RedirectToAction(nameof(Portfolio));
    }

    [HttpPost]
    public IActionResult ResetSimulation()
    {
        simulationService.ResetSimulation();

        TempData["SuccessMessage"] = "Simulation has been reset to Day 1.";

        return RedirectToAction(nameof(Portfolio));
    }
}