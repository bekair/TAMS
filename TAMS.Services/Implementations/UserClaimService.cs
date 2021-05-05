using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Common.Enums;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class UserClaimService : IUserClaimService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserClaimService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<ICollection<UserClaim>> GetUserClaimsByClaimTypeAsync(ClaimType claimType)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<UserClaim>> GetUserClaimsByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
