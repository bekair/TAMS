using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class UserLoginService : GenericInfoRepositoryBase<UserLogin, TamsDbContext>, IUserLoginRepository
    {
        public UserLoginService(TamsDbContext context) : base(context)
        {
        }
    }
}
