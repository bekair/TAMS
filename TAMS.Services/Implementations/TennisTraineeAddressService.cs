using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class TennisTraineeAddressService : ITennisTraineeAddressService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TennisTraineeAddressService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<ICollection<TennisTraineeAddress>> GetTennisTraineeAddressesByClubIdAsync(int clubId)
        {
            throw new NotImplementedException();
        }
    }
}
