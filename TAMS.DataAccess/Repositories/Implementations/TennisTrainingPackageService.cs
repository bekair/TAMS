using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class TennisTrainingPackageService:RepositoryBase<TennisTrainingPackage,TamsDbContext>, ITennisTrainingPackageRepository
    {
        public TennisTrainingPackageService(TamsDbContext context) : base(context)
        {
        }
    }
}
