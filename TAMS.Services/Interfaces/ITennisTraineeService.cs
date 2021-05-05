using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface ITennisTraineeService
    {
        Task<TennisTrainee> GetTennisTraineeByIdAsync(int id);
        Task<ICollection<TennisTrainee>> GetTennisTraineesByTennisCoachIdAsync(int tennisCoachId);
        Task<ICollection<TennisTrainee>> GetTennisTraineesByClubIdAsync(int clubId);
    }
}
