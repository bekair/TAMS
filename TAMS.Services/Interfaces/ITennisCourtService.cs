using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface ITennisCourtService
    {
        Task<TennisCourt> GetTennisCourtByIdAsync(int id);
        Task<ICollection<TennisCourt>> GetTennisCourtsByClubIdAsync(int clubId);
    }
}
