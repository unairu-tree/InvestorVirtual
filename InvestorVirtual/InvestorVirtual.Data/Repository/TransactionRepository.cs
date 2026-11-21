namespace InvestorVirtual.Data.Repository;

using InvestorVirtual.Data.Models;
using InvestorVirtual.Data.Repository.Common;
using InvestorVirtual.Data.Repository.Contracts;

public class TransactionRepository(ApplicationDbContext context) : BaseRepository<Transaction>(context), ITransactionRepository
{

}