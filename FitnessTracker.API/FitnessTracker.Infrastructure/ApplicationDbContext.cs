using FitnessTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<DailyEntry> DailyEntries { get; set; }
    public DbSet<WeeklyEntry> WeeklyEntries { get; set; }
    public DbSet<TrainingEntry> Measurements { get; set; }
}
