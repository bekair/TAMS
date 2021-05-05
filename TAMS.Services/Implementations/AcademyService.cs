using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class AcademyService : IAcademyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AcademyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<Academy> GetAcademyByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<Academy>> GetAllAcademiesAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
