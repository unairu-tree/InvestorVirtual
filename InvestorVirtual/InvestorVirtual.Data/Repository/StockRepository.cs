namespace InvestorVirtual.Data.Repository;

using InvestorVirtual.Data.Models;
using InvestorVirtual.Data.Repository.Common;
using InvestorVirtual.Data.Repository.Contracts;

public class StockRepository : BaseSoftDeletableRepository<Stock>, IStockRepository
{
    public StockRepository(ApplicationDbContext context)
        : base(context)
    {

    }
}