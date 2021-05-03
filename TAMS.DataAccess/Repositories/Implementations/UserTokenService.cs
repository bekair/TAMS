using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class UserTokenService : GenericInfoRepositoryBase<UserToken, TamsDbContext>, IUserTokenRepository
    {
        public UserTokenService(TamsDbContext context) : base(context)
        {
        }
    }
}
