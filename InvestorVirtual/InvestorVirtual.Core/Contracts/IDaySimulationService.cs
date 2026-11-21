namespace InvestorVirtual.Services.Core.Contracts;

using InvestorVirtual.Services.Core.Data.Investment.Response;

// This is the interface inherited by the services responsible for the day simulation and simulation status passing to the controller
public interface IDaySimulationService
{
    // A method to get the current simulation status
    Task<DaySimulationModel> GetSimulationStatusAsync();

    // A method to advance and return the current day
    Task<int> AdvanceDayAsync();

    // A method to restart the simulation - for the day it resets it back to 1
    Task ResetSimulationAsync();
}