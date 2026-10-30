namespace InvestorVirtual.Services.Core;

using InvestorVirtual.Data.Models;
using InvestorVirtual.Data.Repository;

using InvestorVirtual.Services.Core.Contracts;
using InvestorVirtual.Services.Core.Data.Investment.Response;

using static InvestorVirtual.GCommon.ApplicationConstants;

public class DaySimulationService(IRepository repository) : IDaySimulationService
{
    public DaySimulationModel GetSimulationStatus() => repository.All<DaySimulation>()
        .Select(s => new DaySimulationModel
        {
            Day = s.Day
        })
        .First();

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

    public void ResetSimulation()
    {
        DaySimulation simulation = repository.All<DaySimulation>()
            .First();

        simulation.Day = StartingDay;
        repository.SaveChanges();
    }
}