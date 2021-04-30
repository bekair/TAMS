using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TAMS.Entity.Interfaces;

namespace TAMS.DataAccess.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        Task AddAsync(TEntity addedEntity);

        Task AddRangeAsync(ICollection<TEntity> addedEntityList);

        Task<TEntity> GetByIdAsync(int id);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression);

        void Remove(TEntity removedEntity);

        void RemoveRange(ICollection<TEntity> removedEntityList);
    }
}
