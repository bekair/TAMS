using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class TennisTraineeAddressRepository : RepositoryBase<TennisTraineeAddress, TamsDbContext>, ITennisTraineeAddressRepository
    {
        public TennisTraineeAddressRepository(TamsDbContext context) : base(context)
        {
        }
    }
}
