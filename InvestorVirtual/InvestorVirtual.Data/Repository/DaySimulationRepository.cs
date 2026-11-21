namespace InvestorVirtual.Data.Repository;

using InvestorVirtual.Data.Models;
using InvestorVirtual.Data.Repository.Common;
using InvestorVirtual.Data.Repository.Contracts;

public class DaySimulationRepository : BaseRepository<DaySimulation>, IDaySimulationRepository
{
    public DaySimulationRepository(ApplicationDbContext context)
        : base(context)
    {

    }
}