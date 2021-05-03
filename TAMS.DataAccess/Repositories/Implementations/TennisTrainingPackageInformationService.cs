using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class TennisTrainingPackageInformationService:RepositoryBase<TennisTrainingPackageInformation,TamsDbContext>, ITennisTrainingPackageInformationRepository
    {
        public TennisTrainingPackageInformationService(TamsDbContext context) : base(context)
        {
        }
    }
}
