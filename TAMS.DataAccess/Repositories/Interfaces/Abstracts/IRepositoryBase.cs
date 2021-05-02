using TAMS.Entity.Interfaces;

namespace TAMS.DataAccess.Repositories.Interfaces.Abstracts
{
    public interface IRepositoryBase<TEntity> : IGenericInfoRepository<TEntity>, IKeyRepository<TEntity>
        where TEntity : class, IGenericInfo, IKey, new()
    {
    }
}
