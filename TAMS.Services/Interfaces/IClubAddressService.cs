using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface IClubAddressService
    {
        Task<ClubAddress> GetClubAddressByClubIdAsync(int clubId);
        Task<ICollection<ClubAddress>> GetClubAddressesByAcademyIdAsync(int academyId);
    }
}
