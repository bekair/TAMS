using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Common.Enums;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface IUserClaimService
    {
        Task<ICollection<UserClaim>> GetUserClaimsByUserIdAsync(int userId);
        Task<ICollection<UserClaim>> GetUserClaimsByClaimTypeAsync(ClaimType claimType);
    }
}
