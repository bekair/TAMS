using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class TennisCourtScheduleService : RepositoryBase<TennisCourtSchedule, TamsDbContext>, ITennisCourtScheduleRepository
    {
        public TennisCourtScheduleService(TamsDbContext context) : base(context)
        {
        }
    }
}
