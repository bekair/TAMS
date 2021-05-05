using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserRoleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
