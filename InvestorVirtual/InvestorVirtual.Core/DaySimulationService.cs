namespace InvestorVirtual.Services.Core;

using InvestorVirtual.Data.Models;
using InvestorVirtual.Data.Repository.Contracts;

using InvestorVirtual.Services.Core.Contracts;
using InvestorVirtual.Services.Core.Data.Investment.Response;
using Microsoft.EntityFrameworkCore;
using static InvestorVirtual.GCommon.ApplicationConstants;

// This service handles the simulation of passing days with 3 simple methods
public class DaySimulationService(IDaySimulationRepository daySimulationRepository) : IDaySimulationService
{
    // This method sends the current day from the database up for the controller to use
    public async Task<DaySimulationModel> GetSimulationStatusAsync()
    {
        return await daySimulationRepository
            .AllAsNoTracking()
            .Select(s => new DaySimulationModel
            {
                Day = s.Day
            })
            .FirstAsync();
    }
        

    // This method is used by the controller's specific action that is tied to specific buttons in the view
    public async Task<int> AdvanceDayAsync()
    {
        DaySimulation currentDay = await daySimulationRepository
            .All()
            .FirstAsync();    

        if (currentDay.Day < MaxSimulationDays)
        {
            currentDay.Day++;
            await daySimulationRepository.SaveChangesAsync();
        }

        return currentDay.Day;
    }

    // Similarly to day advancing this method is used by the controller's other specific action tied to another button in the view
    public async Task ResetSimulationAsync()
    {
        DaySimulation simulation = daySimulationRepository
            .All()
            .First();

        simulation.Day = StartingDay;

        await daySimulationRepository.SaveChangesAsync();
    }
}