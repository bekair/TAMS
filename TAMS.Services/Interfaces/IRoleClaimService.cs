using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface IRoleClaimService
    {
        Task<ICollection<RoleClaim>> GetRoleClaimsByRoleIdAsync(int roleId);
    }
}
