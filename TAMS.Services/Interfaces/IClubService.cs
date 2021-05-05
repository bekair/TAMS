using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface IClubService
    {
        Task<Club> GetClubByIdAsync(int id);
        Task<ICollection<Club>> GetClubsByAcademyIdAsync(int academyId);
        Task<ICollection<Club>> GetAllClubsAsync();
    }
}
