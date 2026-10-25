namespace InvestorVirtual.Core.Contracts;

using InvestorVirtual.Core.Models.Response;

public interface IDaySimulationService
{
    DaySimulationModel GetSimulationStatus();

    int AdvanceDay();

    void ResetSimulation();
}