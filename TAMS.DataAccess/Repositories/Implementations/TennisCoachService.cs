using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class TennisCoachService : RepositoryBase<TennisCoach, TamsDbContext>, ITennisCoachRepository
    {
        public TennisCoachService(TamsDbContext context) : base(context)
        {
        }
    }
}
