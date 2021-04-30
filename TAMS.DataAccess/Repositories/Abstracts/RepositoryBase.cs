using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TAMS.DataAccess.DbContext.EF;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Interfaces;

namespace TAMS.DataAccess.Repositories.Abstracts
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly TamsDbContext _context;

        public RepositoryBase(TamsDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity addedEntity)
        {
            await _context.Set<TEntity>().AddAsync(addedEntity);
        }

        public async Task AddRangeAsync(ICollection<TEntity> addedEntityList)
        {
            await _context.Set<TEntity>().AddRangeAsync(addedEntityList);
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().Where(entity => entity.IsActive && entity.Id == id).FirstOrDefaultAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Where(expression);
        }

        public void Remove(TEntity removedEntity)
        {
            removedEntity.IsActive = false;
        }

        public void RemoveRange(ICollection<TEntity> removedEntityList)
        {
            removedEntityList.ToList().ForEach(entity => entity.IsActive = false);
        }
    }
}
