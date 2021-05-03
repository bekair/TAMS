using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.DataAccess.Repositories.Abstracts;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class RoleClaimService : RepositoryBase<RoleClaim, TamsDbContext>, IRoleClaimRepository
    {
        public RoleClaimService(TamsDbContext context) : base(context)
        {
        }
    }
}
