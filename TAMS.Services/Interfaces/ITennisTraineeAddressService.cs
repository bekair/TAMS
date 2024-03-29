﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.Entity.Concrete;

namespace TAMS.Services.Interfaces
{
    public interface ITennisTraineeAddressService
    {
        Task<ICollection<TennisTraineeAddress>> GetTennisTraineeAddressesByClubIdAsync(int clubId);
    }
}
