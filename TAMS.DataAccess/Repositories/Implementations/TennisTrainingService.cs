using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class TennisTrainingService : RepositoryBase<TennisTraining, TamsDbContext>, ITennisTrainingRepository
    {
        public TennisTrainingService(TamsDbContext context) : base(context)
        {
        }
    }
}
