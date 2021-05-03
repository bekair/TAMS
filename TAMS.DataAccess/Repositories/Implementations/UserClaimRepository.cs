using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class UserClaimRepository : RepositoryBase<UserClaim, TamsDbContext>, IUserClaimRepository
    {
        public UserClaimRepository(TamsDbContext context) : base(context)
        {
        }
    }
}
