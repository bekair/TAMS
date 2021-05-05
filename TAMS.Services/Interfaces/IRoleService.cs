using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface IRoleService
    {
        Task<Role> GetRoleByNameAsync(int roleName);
        Task<ICollection<Role>> GetAllRolesAsync();
    }
}
