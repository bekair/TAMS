using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class ClubAddressService : RepositoryBase<ClubAddress, TamsDbContext>, IClubAddressRepository
    {
        public ClubAddressService(TamsDbContext context) : base(context)
        {
        }
    }
}
