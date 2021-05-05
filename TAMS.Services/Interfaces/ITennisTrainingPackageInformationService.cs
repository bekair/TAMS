using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface ITennisTrainingPackageInformationService
    {
        Task<ICollection<TennisTrainingPackageInformation>> GetAllTennisTrainingPackageInformationAsync();
    }
}
