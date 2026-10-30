namespace InvestorVirtual.Data.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using InvestorVirtual.Data.Models;

public class DaySimulationConfiguration : IEntityTypeConfiguration<DaySimulation>
{
    public static readonly DaySimulation daySimulation = new()
    {
        Id = 1,
        Day = 1
    };

    public void Configure(EntityTypeBuilder<DaySimulation> builder)
    {
        builder.HasData(daySimulation);
    }
}