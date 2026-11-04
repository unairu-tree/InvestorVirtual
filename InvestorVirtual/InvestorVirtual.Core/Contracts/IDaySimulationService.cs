namespace InvestorVirtual.Services.Core.Contracts;

using InvestorVirtual.Services.Core.Data.Investment.Response;

// This is the interface inherited by the services responsible for the day simulation and simulation status passing to the controller
public interface IDaySimulationService
{
    // A method to get the current simulation status
    DaySimulationModel GetSimulationStatus();

    // A method to advance and return the current day
    int AdvanceDay();

    // A method to restart the simulation - for the day it resets it back to 1
    void ResetSimulation();
}