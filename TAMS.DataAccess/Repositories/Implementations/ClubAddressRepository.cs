using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class ClubAddressRepository : RepositoryBase<ClubAddress, TamsDbContext>, IClubAddressRepository
    {
        public ClubAddressRepository(TamsDbContext context) : base(context)
        {
        }
    }
}
