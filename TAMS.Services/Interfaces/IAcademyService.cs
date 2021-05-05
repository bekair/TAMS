using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface IAcademyService
    {
        Task<Academy> GetAcademyByIdAsync(int id);
        Task<ICollection<Academy>> GetAllAcademiesAsync();
    }
}
