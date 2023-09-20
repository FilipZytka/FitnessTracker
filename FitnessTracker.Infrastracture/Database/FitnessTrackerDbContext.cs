using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTracker.Entities.Entities;

namespace FitnessTracker.Infrastracture.Database
{
    public class FitnessTrackerDbContext : DbContext
    {

        public FitnessTrackerDbContext(DbContextOptions<FitnessTrackerDbContext> options) : base(options)
        {
            
        }
        public DbSet<Entities.Entities.FitnessTracker> FitnessTrackers { get; set; }
    
        
    
    
    }
}
