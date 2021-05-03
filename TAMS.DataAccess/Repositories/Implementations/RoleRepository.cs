using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class RoleRepository : RepositoryBase<Role, TamsDbContext>, IRoleRepository
    {
        public RoleRepository(TamsDbContext context) : base(context)
        {
        }
    }
}
