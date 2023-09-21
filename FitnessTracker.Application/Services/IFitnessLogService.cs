namespace FitnessTracker.Application.Services
{
    public interface IFitnessLogService
    {
        Task Create(Entities.Entities.FitnessTracker fitnessTracker);
    }
}