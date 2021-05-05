using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class TennisTraineeService : ITennisTraineeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TennisTraineeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<TennisTrainee> GetTennisTraineeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TennisTrainee>> GetTennisTraineesByClubIdAsync(int clubId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TennisTrainee>> GetTennisTraineesByTennisCoachIdAsync(int tennisCoachId)
        {
            throw new NotImplementedException();
        }
    }
}
