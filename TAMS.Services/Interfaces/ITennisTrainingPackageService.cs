using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface ITennisTrainingPackageService
    {
        Task<ICollection<TennisTrainingPackage>> GetTennisTrainingPackagesByTennisTraineeIdAsync(int tennisTraineeId);
    }
}
