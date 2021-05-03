using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class AcademyAddressRepository : RepositoryBase<AcademyAddress, TamsDbContext>, IAcademyAddressRepository
    {
        public AcademyAddressRepository(TamsDbContext context) : base(context)
        {
        }
    }
}
