using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class TennisTrainingPackageInformationService : ITennisTrainingPackageInformationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TennisTrainingPackageInformationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<ICollection<TennisTrainingPackageInformation>> GetAllTennisTrainingPackageInformationAsync()
        {
            throw new NotImplementedException();
        }
    }
}
