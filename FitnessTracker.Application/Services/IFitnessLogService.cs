namespace FitnessTracker.Application.Services
{
    public interface IFitnessLogService
    {
        Task CreateLog(Entities.Entities.FitnessTracker fitnessTracker);
    }
}