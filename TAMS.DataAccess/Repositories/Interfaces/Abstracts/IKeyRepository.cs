using System.Threading.Tasks;
using TAMS.Entity.Interfaces;

namespace TAMS.DataAccess.Repositories.Interfaces.Abstracts
{
    public interface IKeyRepository<TEntity> where TEntity : class, IKey, new()
    {
        Task<TEntity> GetByIdAsync(int id);
    }
}
