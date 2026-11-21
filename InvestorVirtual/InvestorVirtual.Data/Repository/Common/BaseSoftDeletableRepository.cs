namespace InvestorVirtual.Data.Repository.Common;

using Microsoft.EntityFrameworkCore;

using InvestorVirtual.Data.Common.Models;
using InvestorVirtual.Data.Repository.Contracts.Common;

public abstract class BaseSoftDeletableRepository<TEntity>(ApplicationDbContext context) : BaseRepository<TEntity>(context), ISoftDeletableRepository<TEntity>
    where TEntity : class, ISoftDeletableEntity
{
    public IQueryable<TEntity> AllWithDeleted()
    {
        return DbSet
            .IgnoreQueryFilters()
            .AsQueryable();
    }

    public IQueryable<TEntity> AllWithDeletedAsNoTracking()
    {
        return DbSet
            .IgnoreQueryFilters()
            .AsNoTracking()
            .AsQueryable();
    }

    public void SoftDelete(TEntity entity)
    {
        entity.IsDeleted = true;
    }

    public void Recover(TEntity entity)
    {
        entity.IsDeleted = false;
    }
}