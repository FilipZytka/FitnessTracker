using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Entities.Interfaces
{
    public interface IFitnessLog
    {
        Task CreateLog(Entities.FitnessTracker log);
        Task<IEnumerable<Entities.FitnessTracker>> GetAll();
    }
}
