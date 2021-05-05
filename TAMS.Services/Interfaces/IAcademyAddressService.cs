using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface IAcademyAddressService
    {
        Task<AcademyAddress> GetAcademyAddressByAcademyIdAsync(int academyId);
        Task<ICollection<AcademyAddress>> GetAllAcademyAddressesAsync();
    }
}
