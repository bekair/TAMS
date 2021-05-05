using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class ClubAddressService : IClubAddressService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClubAddressService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<ClubAddress> GetClubAddressByClubIdAsync(int clubId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ClubAddress>> GetClubAddressesByAcademyIdAsync(int academyId)
        {
            throw new NotImplementedException();
        }
    }
}
