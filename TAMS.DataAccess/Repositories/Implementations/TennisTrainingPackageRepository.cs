using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class TennisTrainingPackageRepository : RepositoryBase<TennisTrainingPackage, TamsDbContext>, ITennisTrainingPackageRepository
    {
        public TennisTrainingPackageRepository(TamsDbContext context) : base(context)
        {
        }
    }
}
