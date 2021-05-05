using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class TennisCoachService : ITennisCoachService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TennisCoachService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<TennisCoach> GetTennisCoachByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<TennisCoach> GetTennisCoachByTrainerIdAsync(int trainerId)
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<TennisCoach>> GetTennisCoachesByClubIdAsync(int clubId)
        {
            throw new System.NotImplementedException();
        }
    }
}
