using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface ITennisTrainingService
    {
        Task<ICollection<TennisTraining>> GetTennisTrainingsInAPeriodByTennisCoachIdAsync(int tennisCoachId, DateTime startDate, DateTime endDate);
        Task<ICollection<TennisTraining>> GetTennisTrainingsInAPeriodByTennisCourtIdAsync(int tennisCourtId, DateTime startDate, DateTime endDate);
    }
}