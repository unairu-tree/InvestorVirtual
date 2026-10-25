namespace InvestorVirtual.Core.Services;

using InvestorVirtual.Data.Common;
using InvestorVirtual.Data.Models;

using InvestorVirtual.Core.Contracts;
using InvestorVirtual.Core.Models.Response;

using static InvestorVirtual.Common.ApplicationConstants;

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