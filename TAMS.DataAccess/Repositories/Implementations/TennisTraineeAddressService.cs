using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class TennisTraineeAddressService : RepositoryBase<TennisTraineeAddress, TamsDbContext>, ITennisTraineeAddressRepository
    {
        public TennisTraineeAddressService(TamsDbContext context) : base(context)
        {
        }
    }
}
