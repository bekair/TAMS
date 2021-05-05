using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class TennisCourtScheduleService : ITennisCourtScheduleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TennisCourtScheduleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<TennisCourtSchedule> GetTennisCourtScheduleByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TennisCourtSchedule>> GetTennisCourtScheduleByTennisCourtIdAsync(int tennisCourtId)
        {
            throw new NotImplementedException();
        }
    }
}
