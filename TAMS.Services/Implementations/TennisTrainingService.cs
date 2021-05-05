using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class TennisTrainingService : ITennisTrainingService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TennisTrainingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<ICollection<TennisTraining>> GetTennisTrainingsInAPeriodByTennisCoachIdAsync(int tennisCoachId, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TennisTraining>> GetTennisTrainingsInAPeriodByTennisCourtIdAsync(int tennisCourtId, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
