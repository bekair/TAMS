using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class UserRepository : RepositoryBase<AppUser, TamsDbContext>, IUserRepository
    {
        public UserRepository(TamsDbContext context) : base(context)
        {
        }
    }
}
