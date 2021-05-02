using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class AcademyAddressService : RepositoryBase<AcademyAddress, TamsDbContext>, IAcademyAddressRepository
    {
        public AcademyAddressService(TamsDbContext context) : base(context)
        {
        }
    }
}
