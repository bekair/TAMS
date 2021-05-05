using System;
using System.Threading.Tasks;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class UserTokenService : IUserTokenService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserTokenService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<UserToken> GetActiveUserTokenByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
