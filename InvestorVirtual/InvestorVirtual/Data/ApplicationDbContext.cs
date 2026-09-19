namespace InvestorVirtual.Data;

using InvestorVirtual.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
{
    public virtual DbSet<Stock> Stocks { get; set; } = null!;

    public virtual DbSet<Event> Events { get; set; } = null!;

    public virtual DbSet<Price> Prices { get; set; } = null!;

    public virtual DbSet<News> News { get; set; } = null!;

    public virtual DbSet<Analysis> Analyses { get; set; } = null!;

    public virtual DbSet<LearningTerm> LearningTerms { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}