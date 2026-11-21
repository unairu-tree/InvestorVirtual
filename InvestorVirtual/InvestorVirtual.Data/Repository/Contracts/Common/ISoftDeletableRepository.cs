using InvestorVirtual.Data.Common.Models;

namespace InvestorVirtual.Data.Repository.Contracts.Common;

public interface ISoftDeletableRepository<TEntity> : IRepository<TEntity>
    where TEntity : class, ISoftDeletableEntity
{
    // This method will be used to query all entities including the soft-deleted ones.
    IQueryable<TEntity> AllWithDeleted();

    // AsNoTracking version of the above method for read-only scenarios.
    IQueryable<TEntity> AllWithDeletedAsNoTracking();

    // This method will be used to perform the soft delete on a entity.
    void SoftDelete(TEntity entity);

    // This method will be used to recover a soft-deleted entity.
    void Recover(TEntity entity);
}
