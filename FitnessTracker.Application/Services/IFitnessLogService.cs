using FitnessTracker.Entities.Entities;

namespace FitnessTracker.Application.Services
{
    public interface IFitnessLogService
    {
        Task CreateService(Entities.Entities.FitnessTracker fitnessTracker);
        Task<IEnumerable<Entities.Entities.FitnessTracker>> GetAll();

    }
}