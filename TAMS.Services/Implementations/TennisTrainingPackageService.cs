using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class TennisTrainingPackageService : ITennisTrainingPackageService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TennisTrainingPackageService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<ICollection<TennisTrainingPackage>> GetTennisTrainingPackagesByTennisTraineeIdAsync(int tennisTraineeId)
        {
            throw new NotImplementedException();
        }
    }
}
