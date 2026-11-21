namespace InvestorVirtual.Data.Repository;

using InvestorVirtual.Data.Models;
using InvestorVirtual.Data.Repository.Common;
using InvestorVirtual.Data.Repository.Contracts;

public class LearningRepository(ApplicationDbContext context) : BaseSoftDeletableRepository<LearningTerm>(context), ILearningRepository
{

}