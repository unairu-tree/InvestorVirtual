namespace InvestorVirtual.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Models;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
{
    public virtual DbSet<Stock> Stocks { get; set; } = null!;

    public virtual DbSet<Event> Events { get; set; } = null!;

    public virtual DbSet<Price> Prices { get; set; } = null!;

    public virtual DbSet<News> News { get; set; } = null!;

    public virtual DbSet<Analysis> Analyses { get; set; } = null!;

    public virtual DbSet<LearningTerm> LearningTerms { get; set; } = null!;

    public virtual DbSet<Transaction> Transactions { get; set; } = null!;

    public virtual DbSet<Portfolio> Portfolios { get; set; } = null!;

    public virtual DbSet<PortfolioStock> PortfolioStocks { get; set; } = null!;

    public virtual DbSet<DaySimulation> DaySimulations { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}