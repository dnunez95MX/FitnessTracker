using FitnessTracker.Domain.DTO;
using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Domain.Entities;

public class TrainingEntry
{
    [Key]
    public int Id { get; set; }
    public string ExerciseName { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public float Weight { get; set; }
    public DateTime Date { get; set; }
    public GroupBodyExerciseCategory ExerciseCategory { get; set; }
}
