using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Entities.Entities
{
    public class FitnessTracker
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public int Sets { get; set; } = default!;
        public int Reps { get; set; } = default!;
        public DateTime? CreatedTime { get; set; } = DateTime.UtcNow;
        
    }
}
