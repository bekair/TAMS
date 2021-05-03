using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class AcademyRepository : RepositoryBase<Academy, TamsDbContext>, IAcademyRepository
    {
        public AcademyRepository(TamsDbContext context) : base(context)
        {
        }
    }
}
