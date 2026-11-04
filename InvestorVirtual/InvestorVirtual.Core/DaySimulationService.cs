namespace InvestorVirtual.Services.Core;

using InvestorVirtual.Data.Models;
using InvestorVirtual.Data.Repository;

using InvestorVirtual.Services.Core.Contracts;
using InvestorVirtual.Services.Core.Data.Investment.Response;

using static InvestorVirtual.GCommon.ApplicationConstants;

// This service handles the simulation of passing days with 3 simple methods
public class DaySimulationService(IRepository repository) : IDaySimulationService
{
    // This method sends the current day from the database up for the controller to use
    public DaySimulationModel GetSimulationStatus() => repository.All<DaySimulation>()
        .Select(s => new DaySimulationModel
        {
            Day = s.Day
        })
        .First();

    // This method is used by the controller's specific action that is tied to specific buttons in the view
    public int AdvanceDay()
    {
        DaySimulation currentDay = repository.All<DaySimulation>()
            .First();    

        if (currentDay.Day < MaxSimulationDays)
        {
            currentDay.Day++;
            repository.SaveChanges();
        }

        return currentDay.Day;
    }

    // Similarly to day advancing this method is used by the controller's other specific action tied to another button in the view
    public void ResetSimulation()
    {
        DaySimulation simulation = repository.All<DaySimulation>()
            .First();

        simulation.Day = StartingDay;

        repository.SaveChanges();
    }
}