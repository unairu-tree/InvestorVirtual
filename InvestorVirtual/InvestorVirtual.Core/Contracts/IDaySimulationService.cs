namespace InvestorVirtual.Services.Core.Contracts;

using InvestorVirtual.Services.Core.Data.Investment.Response;

public interface IDaySimulationService
{
    DaySimulationModel GetSimulationStatus();

    int AdvanceDay();

    void ResetSimulation();
}