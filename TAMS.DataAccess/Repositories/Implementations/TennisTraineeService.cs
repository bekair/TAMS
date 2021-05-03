using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class TennisTraineeService : RepositoryBase<TennisTrainee, TamsDbContext>, ITennisTraineeRepository
    {
        public TennisTraineeService(TamsDbContext context) : base(context)
        {
        }
    }
}