using FitnessTracker.Infrastracture.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Infrastracture.Data_Seeders
{
    public class FitnessTrackerSeeder
    {
        private readonly FitnessTrackerDbContext _dbContext;
        public FitnessTrackerSeeder(FitnessTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
            
        }
        public async Task SeedData()
        {
            if(await _dbContext.Database.CanConnectAsync())
            {
                if(!_dbContext.FitnessTrackers.Any())
                {
                    var training1 = new Entities.Entities.FitnessTracker()
                    {
                        Name = "Push ups",
                        Description = "Short brakes(100). It was great.",
                        Sets = 3,
                        Reps = "40,29,26",
                    };
                    _dbContext.FitnessTrackers.Add(training1);
                    await _dbContext.SaveChangesAsync();
                   

                }


            }
        }
    }
}
