namespace InvestorVirtual.Data.Repository;

using InvestorVirtual.Data.Models;
using InvestorVirtual.Data.Repository.Common;
using InvestorVirtual.Data.Repository.Contracts;

public class PortfolioStockRepository(ApplicationDbContext context) : BaseRepository<PortfolioStock>(context), IPortfolioStockRepository
{

}