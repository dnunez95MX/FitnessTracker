using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Domain.Entities;

public class DailyEntry
{
    [Key]
    public int Id { get; set; }
    [Required]
    public float Weight { get; set; }
    [Required]
    public DateTime Date { get; set; }
}
