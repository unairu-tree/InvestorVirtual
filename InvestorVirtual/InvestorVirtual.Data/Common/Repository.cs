namespace InvestorVirtual.Data.Common;

public class Repository(ApplicationDbContext context) : IRepository
{
    public void Add<T>(T entity) where T : class
    {
        context.Set<T>().Add(entity);
    }

    public IQueryable<T> All<T>() where T : class
    {
        return context.Set<T>();
    }

    public void Remove<T>(T entity) where T : class
    {
        context.Set<T>().Remove(entity);
    }

    public int SaveChanges()
    {
        return context.SaveChanges();
    }
}