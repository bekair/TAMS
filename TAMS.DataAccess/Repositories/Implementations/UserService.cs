using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class UserService : RepositoryBase<AppUser, TamsDbContext>, IUserRepository
    {
        public UserService(TamsDbContext context) : base(context)
        {
        }
    }
}
