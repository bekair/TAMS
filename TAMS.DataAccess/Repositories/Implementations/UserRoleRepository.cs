using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class UserRoleRepository : GenericInfoRepositoryBase<UserRole, TamsDbContext>, IUserRoleRepository
    {
        public UserRoleRepository(TamsDbContext context) : base(context)
        {
        }
    }
}
