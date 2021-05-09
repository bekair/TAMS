using System.Threading.Tasks;
using TAMS.DataAccess.Repositories.Interfaces.Abstracts;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Interfaces
{
    public interface IUserRepository : IRepositoryBase<AppUser>
    {
        Task<bool> RegisterUserAsync(string email, string userName, string password);
    }
}
