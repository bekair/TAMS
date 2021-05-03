using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class TennisCourtService : RepositoryBase<TennisCourt, TamsDbContext>, ITennisCourtRepository
    {
        public TennisCourtService(TamsDbContext context) : base(context)
        {
        }
    }
}
