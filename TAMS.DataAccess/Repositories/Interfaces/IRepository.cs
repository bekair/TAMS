using TAMS.Entity.Interfaces;

namespace TAMS.DataAccess.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, IEntity, new()
    {
    }
}
