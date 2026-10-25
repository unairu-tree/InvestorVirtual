namespace InvestorVirtual.Data.Models;

using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;

using static InvestorVirtual.Common.ApplicationConstants;

// The whole purpose of this entity is for me to be able to save a variable across different sessions and requests
[Comment("This is a solo model used for the day simulation mechanic of the app")]
public class DaySimulation
{
    [Key]
    public int Id { get; set; }

    [Range(1, MaxSimulationDays)]
    [Comment("The simulation starts on day 1 and has a maximum of 10 days")]
    public int Day { get; set; }
}