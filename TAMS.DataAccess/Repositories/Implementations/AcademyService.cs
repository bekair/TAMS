using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class AcademyService : RepositoryBase<Academy, TamsDbContext>, IAcademyRepository
    {
        public AcademyService(TamsDbContext context) : base(context)
        {
        }
    }
}
