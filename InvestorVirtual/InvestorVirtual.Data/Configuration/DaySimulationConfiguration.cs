namespace InvestorVirtual.Data.Configuration;

using InvestorVirtual.Data.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class DaySimulationConfiguration : IEntityTypeConfiguration<DaySimulation>
{
    public static readonly DaySimulation daySimulation = new DaySimulation
    {
        Id = 1,
        Day = 1
    };

    public void Configure(EntityTypeBuilder<DaySimulation> builder)
    {
        builder.HasData(daySimulation);
    }
}