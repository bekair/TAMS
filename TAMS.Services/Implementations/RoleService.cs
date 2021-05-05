using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<ICollection<Role>> GetAllRolesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Role> GetRoleByNameAsync(int roleName)
        {
            throw new System.NotImplementedException();
        }
    }
}
