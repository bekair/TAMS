using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class UserTokenRepository : GenericInfoRepositoryBase<UserToken, TamsDbContext>, IUserTokenRepository
    {
        public UserTokenRepository(TamsDbContext context) : base(context)
        {
        }
    }
}
