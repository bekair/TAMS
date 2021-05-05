using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface IUserService
    {
        Task<AppUser> GetUserByIdAsync(int id);
        Task<int> GetIdByUserNameAsync(string userName);
        Task<ICollection<AppUser>> GetAllUsersAsync();
    }
}
