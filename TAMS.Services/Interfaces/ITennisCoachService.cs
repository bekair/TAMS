using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface ITennisCoachService
    {
        Task<TennisCoach> GetTennisCoachByTrainerIdAsync(int trainerId);
        Task<TennisCoach> GetTennisCoachByIdAsync(int id);
        Task<ICollection<TennisCoach>> GetTennisCoachesByClubIdAsync(int clubId);
    }
}
