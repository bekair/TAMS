using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class TennisCourtService : ITennisCourtService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TennisCourtService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<TennisCourt> GetTennisCourtByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TennisCourt>> GetTennisCourtsByClubIdAsync(int clubId)
        {
            throw new NotImplementedException();
        }
    }
}
