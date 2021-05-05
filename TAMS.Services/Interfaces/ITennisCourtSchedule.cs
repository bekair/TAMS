﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface ITennisCourtSchedule
    {
        Task<TennisCourtSchedule> GetTennisCourtScheduleByIdAsync(int id);
        Task<ICollection<TennisCourtSchedule>> GetTennisCourtScheduleByTennisCourtIdAsync(int tennisCourtId);
    }
}
