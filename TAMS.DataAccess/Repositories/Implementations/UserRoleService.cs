using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class UserRoleService : GenericInfoRepositoryBase<UserRole, TamsDbContext>, IUserRoleRepository
    {
        public UserRoleService(TamsDbContext context) : base(context)
        {
        }
    }
}
