using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using TAMS.DataAccess.Repositories.Interfaces.Abstracts;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Interfaces
{
    public interface IUserRepository : IRepositoryBase<AppUser>
    {
        Task<IdentityResult> RegisterUserAsync(string email, string userName, string password);
    }
}
