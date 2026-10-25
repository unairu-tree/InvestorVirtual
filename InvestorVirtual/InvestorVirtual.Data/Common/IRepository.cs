namespace InvestorVirtual.Data.Common;

public interface IRepository
{
    IQueryable<T> All<T>() where T : class;

    void Add<T>(T entity) where T : class;

    void Remove<T>(T entity) where T : class;

    int SaveChanges();
}