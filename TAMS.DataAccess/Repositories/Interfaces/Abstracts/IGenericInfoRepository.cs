using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TAMS.Entity.Interfaces;

namespace TAMS.DataAccess.Repositories.Interfaces.Abstracts
{
    public interface IGenericInfoRepository<TEntity> where TEntity : class, IGenericInfo, new()
    {
        Task AddAsync(TEntity addedEntity);

        Task AddRangeAsync(ICollection<TEntity> addedEntityList);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression);

        void Update(TEntity updatedEntity);

        void UpdateRange(ICollection<TEntity> updatedEntityList);

        void Remove(TEntity removedEntity);

        void RemoveRange(ICollection<TEntity> removedEntityList);
    }
}
