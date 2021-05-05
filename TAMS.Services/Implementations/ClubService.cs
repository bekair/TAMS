using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Interfaces;

namespace TAMS.Services.Implementations
{
    public class ClubService : IClubService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClubService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<ICollection<Club>> GetAllClubsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Club> GetClubByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Club>> GetClubsByAcademyIdAsync(int academyId)
        {
            throw new NotImplementedException();
        }
    }
}
