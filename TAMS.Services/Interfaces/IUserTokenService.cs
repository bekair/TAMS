using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface IUserTokenService
    {
        Task<UserToken> GetActiveUserTokenByUserId(int userId);
    }
}
