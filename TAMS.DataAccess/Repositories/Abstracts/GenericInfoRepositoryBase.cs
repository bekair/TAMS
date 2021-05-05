using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TAMS.DataAccess.Repositories.Interfaces.Abstracts;
using TAMS.Entity.Interfaces;

namespace TAMS.DataAccess.Repositories.Abstracts
{
    public abstract class GenericInfoRepositoryBase<TEntity, TContext> : IGenericInfoRepository<TEntity>
        where TEntity : class, IGenericInfo, new()
        where TContext : DbContext
    {
        protected readonly TContext _context;

        protected GenericInfoRepositoryBase(TContext context)
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

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Where(expression);
        }

        public void Update(TEntity updatedEntity)
        {
            _context.Update(updatedEntity);
        }

        public void UpdateRange(ICollection<TEntity> updatedEntityList)
        {
            _context.UpdateRange(updatedEntityList);
        }

        public void Remove(TEntity removedEntity)
        {
            _context.Remove(removedEntity);
        }

        public void RemoveRange(ICollection<TEntity> removedEntityList)
        {
            _context.RemoveRange(removedEntityList);
        }
    }
}
