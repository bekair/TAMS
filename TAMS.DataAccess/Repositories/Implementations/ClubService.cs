using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class ClubService : RepositoryBase<Club, TamsDbContext>, IClubRepository
    {
        public ClubService(TamsDbContext context) : base(context)
        {
        }
    }
}
