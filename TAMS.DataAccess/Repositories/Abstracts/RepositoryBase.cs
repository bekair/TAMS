using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TAMS.DataAccess.Repositories.Interfaces.Abstracts;
using TAMS.Entity.Interfaces;

namespace TAMS.DataAccess.Repositories.Abstracts
{
    public abstract class RepositoryBase<TEntity, TContext> : GenericInfoRepositoryBase<TEntity, TContext>, IRepositoryBase<TEntity>
        where TEntity : class, IGenericInfo, IKey, new()
        where TContext : DbContext
    {
        protected RepositoryBase(TContext context) : base(context)
        {
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().Where(entity => entity.IsActive &&
                                                                 entity.Id == id
                                                )
                                                .FirstOrDefaultAsync();
        }
    }
}
