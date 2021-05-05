using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface IUserLoginService
    {
        Task<ICollection<UserLogin>> GetUserLoginsByUserIdAsync(int userId);
    }
}
