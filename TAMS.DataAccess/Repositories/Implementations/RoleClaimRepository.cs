using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.DataAccess.Repositories.Abstracts;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class RoleClaimRepository : RepositoryBase<RoleClaim, TamsDbContext>, IRoleClaimRepository
    {
        public RoleClaimRepository(TamsDbContext context) : base(context)
        {
        }
    }
}
