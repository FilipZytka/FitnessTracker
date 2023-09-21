using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Entities.Entities
{
    public class FitnessTracker
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        [Required(ErrorMessage ="Please enter the amount of sets performed")]
        public int Sets { get; set; } = default!;
        [Required(ErrorMessage = "Please enter the amount of reps performed")]
        public string Reps { get; set; } = default!;
        public DateTime? CreatedTime { get; set; } = DateTime.UtcNow;
        
    }
}
