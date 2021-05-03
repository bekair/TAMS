using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class TennisCourtRepository : RepositoryBase<TennisCourt, TamsDbContext>, ITennisCourtRepository
    {
        public TennisCourtRepository(TamsDbContext context) : base(context)
        {
        }
    }
}
