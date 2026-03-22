using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Domain.Entities;
public class WeeklyEntry
{
    [Key]
    public int Id { get; set; }
    public float AverageWeight { get; set; }
    public float BodyFatPercentage { get; set; }
    public float ChestSize { get; set; }
    public float WaistSize { get; set; }
    public float CuadricepsSize { get; set; }
    public float BicepsSize { get; set; }
    public DateTime Date { get; set; }
    public int WeekNumber { get; set; }
    public string? Notes { get; set; }
    public List<DailyEntry> DailyEntries { get; set; } = new List<DailyEntry>();
}
