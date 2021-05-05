using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class AcademyAddressService : IAcademyAddressService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AcademyAddressService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<AcademyAddress> GetAcademyAddressByAcademyIdAsync(int academyId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<AcademyAddress>> GetAllAcademyAddressesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
