using FitnessTracker.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Application.Services
{
    public class FitnessLogService : IFitnessLogService
    {
        private readonly IFitnessLog _log;
        public FitnessLogService(IFitnessLog log)
        {
            _log = log;
        }
        public async Task CreateService(Entities.Entities.FitnessTracker fitnessTracker)
        {
            await _log.CreateLog(fitnessTracker);

        }

        public async Task<IEnumerable<Entities.Entities.FitnessTracker>> GetAll()
        {
            var fitnessLogs = await _log.GetAll();

            return fitnessLogs;
        }
    }
}
