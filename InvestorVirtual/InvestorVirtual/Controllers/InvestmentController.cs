namespace InvestorVirtual.Web.Controllers;

using Microsoft.AspNetCore.Mvc;

using InvestorVirtual.Web.ViewModels.Investment;

using InvestorVirtual.Services.Core.Contracts;
using InvestorVirtual.Services.Core.Data.Investment.Response;

public class InvestmentController(IInvestmentService investmentService, IDaySimulationService simulationService) : BaseController
{
    [HttpGet]
    public IActionResult Index(string? searchQuery, string? sector, string? sorting)
    {
        // Deprecated
        // IEnumerable<AllAssetsModel> allAssets = investmentService.GetAllAssets(searchQuery, sector);

        int currentDay = simulationService.GetSimulationStatus().Day;

        IQueryable<AssetsResponseModel> allAssets = investmentService.GetAllAssets(searchQuery, sector);

        allAssets = sorting switch // More compact vesion of switch case to attach the kind of sorting the user desires to see
        {
            "AddedDesc" => allAssets.OrderByDescending(s => s.Id), // Since ID is auto-incremented (in our case I manually added ids for most entities to make sure EF core could seed them properly based on how their relations work) we can use the ID as a form of "when was it added"
            "AlphabeticalAsc" => allAssets.OrderBy(s => s.CompanyName), // Alphabetic ascending
            "AlphabeticalDesc" => allAssets.OrderByDescending(s => s.CompanyName), // Alphabetic descending
            // "PerformanceAsc" => allAssets.OrderBy()
            // "PerformanceDesc" => allAssets.OrderByDescending()
            _ => allAssets.OrderBy(s => s.Id) // Default: Added(id) ascending
        };

        IEnumerable<AssetsViewModel> assetsViewModel = allAssets
            .Select(a => new AssetsViewModel
            {
                Ticker = a.Ticker,
                CompanyName = a.CompanyName,
                Sector = a.Sector,
                LogoPath = a.LogoPath
            })
            .ToArray();

        return View(assetsViewModel);
    }

    [HttpGet]
    public IActionResult Details(string ticker)
    {
        int currentDay = simulationService.GetSimulationStatus().Day;
        string? userId = GetUserId();

        AssetsResponseModel? asset = investmentService.GetAsset(ticker);

        if (asset == null) // Potentially add a user ID check, but the [Authorize] on the base controller that this controlelr inherits from guarantees me that the user cannot reach details without logging in or registering first
            return NotFound();

        IEnumerable<EventResponseModel> events = investmentService.GetAllEvents(asset.Id , currentDay);

        // Normally at this point I have confirmed that there is an actual asset and the day is seeded to start at 1, but I left this check here just in case
        if (!events.Any()) // .Any() instead of null, because the service method is returning a list that if the query goes wrong will return an empty list instead of a null
            return NotFound();

        DetailsViewModel detailsViewModel = new()
        {
            Id = asset.Id,
            Ticker = asset.Ticker,
            CompanyName = asset.CompanyName,
            ShortDescription = asset.ShortDescription,
            Sector = asset.Sector,
            LogoPath = asset.LogoPath,

            IsBullishVolume = investmentService.IsBullishVolume(ticker, currentDay),

            IsInWatchlist = investmentService.IsInWatchlist(userId!, ticker),

            Events = events
        };

        return View(detailsViewModel);
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
            TempData["SuccessMessage"] = $"{ticker} removed from your Watchlist.";
        }

        return RedirectToAction(nameof(Details), new { ticker });
    }

    [HttpGet]
    public IActionResult Portfolio()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AdvanceDay()
    {
        // Gets the current day from the simulation
        int currentDay = simulationService.GetSimulationStatus().Day;

        // If the day is equal to or higher than 10 notifies the user that they are on the last day of simulation
        if (currentDay >= 10)
        {
            TempData["Message"] = "Simulation is already at Day 10!";
            return RedirectToAction(nameof(Portfolio));
        }

        // Otherwise it advances the day and gets the new value
        int newDay = simulationService.AdvanceDay();

        if (newDay == 10)
        {
            // If the new value is 10 it notifies the user they reached the last day of the simulation
            TempData["Message"] = "You have reached Day 10! Simulation complete.";
        }
        else
        {
            // Otherwise it notifies them which day out of 10 they are on right now
            TempData["SuccessMessage"] = $"Advanced to Day {newDay} of 10.";
        }

        return RedirectToAction(nameof(Portfolio));
    }

    [HttpPost]
    public IActionResult ResetSimulation() // Accept no outside parameters to avoid parameter tampering
    {
        // Resets simulation back to day 1
        simulationService.ResetSimulation(); // Days are seeded by default and method does not accept parameter as well, attacks shouldn't be able to break this

        string? userId = GetUserId(); // Uses base controller method to get the user ID

        if (string.IsNullOrEmpty(userId))
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" }); // If an attack is done without an actual user the logic will prompt the user to the log-in page
        }

        if (!investmentService.PortfolioExists(userId)) // If by any chance they are able to send a false request I utilize the matching guids for user/portfolio and use the base controller's method-found user guid to check if a portfolio exits
            return NotFound(); // If not I return 404 (Will be changed to custom 404 later down the line for exam requirements)

        investmentService.ResetSimulation(userId); // After all those security checks and handles - resets the portfolio too

        TempData["SuccessMessage"] = "Simulation has been reset to Day 1."; // Displays a message

        return RedirectToAction(nameof(Portfolio)); // Returns to portfolio
    }
}