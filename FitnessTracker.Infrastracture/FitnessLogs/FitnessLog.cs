using FitnessTracker.Entities.Interfaces;
using FitnessTracker.Infrastracture.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Infrastracture.Logs
{
    public class FitnessLog : IFitnessLog
    {
        private readonly FitnessTrackerDbContext _dBcontext;
        public FitnessLog(FitnessTrackerDbContext dbContext)
        {
            _dBcontext = dbContext;
        }
        public async Task Create(Entities.Entities.FitnessTracker log)
        {
            _dBcontext.Add(log);
            await _dBcontext.SaveChangesAsync();
        }
    }
}
