using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class RoleClaimService : IRoleClaimService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoleClaimService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<ICollection<RoleClaim>> GetRoleClaimsByRoleIdAsync(int roleId)
        {
            throw new NotImplementedException();
        }
    }
}
