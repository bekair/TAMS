using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Common.DTOs.ResponseDTOs;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface IUserService
    {
        Task<RegisterResultDTO> RegisterUserAsync(string email, string userName, string password);
        Task<RegisterUserDTO> GetUserByIdAsync(int id);
        Task<int> GetIdByUserNameAsync(string userName);
        Task<ICollection<RegisterUserDTO>> GetAllUsersAsync();
    }
}
