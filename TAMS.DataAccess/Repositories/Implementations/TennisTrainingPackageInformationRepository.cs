using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class TennisTrainingPackageInformationRepository : RepositoryBase<TennisTrainingPackageInformation, TamsDbContext>, ITennisTrainingPackageInformationRepository
    {
        public TennisTrainingPackageInformationRepository(TamsDbContext context) : base(context)
        {
        }
    }
}
