using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class UserLoginRepository : GenericInfoRepositoryBase<UserLogin, TamsDbContext>, IUserLoginRepository
    {
        public UserLoginRepository(TamsDbContext context) : base(context)
        {
        }
    }
}
