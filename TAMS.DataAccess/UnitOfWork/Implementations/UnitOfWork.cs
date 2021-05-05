using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Interfaces;

namespace TAMS.DataAccess.UnitOfWork.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(TamsDbContext context, IAcademyAddressRepository academyAddressRepository, IAcademyRepository academyRepository,
            IClubAddressRepository clubAddressRepository, IClubRepository clubRepository, IRoleClaimRepository roleClaimRepository,
            IRoleRepository roleRepository, ITennisCoachRepository tennisCoachRepository, ITennisCourtRepository tennisCourtRepository,
            ITennisCourtScheduleRepository tennisCourtScheduleRepository, ITennisTraineeAddressRepository tennisTraineeAddressRepository,
            ITennisTraineeRepository tennisTraineeRepository, ITennisTrainingPackageInformationRepository tennisTrainingPackageInformationRepository,
            ITennisTrainingPackageRepository tennisTrainingPackageRepository, ITennisTrainingRepository tennisTrainingRepository,
            IUserClaimRepository userClaimRepository, IUserLoginRepository userLoginRepository, IUserRepository userRepository,
            IUserRoleRepository userRoleRepository, IUserTokenRepository userTokenRepository)
        {
            _context = context;
            AcademyAddresses = academyAddressRepository;
            Academies = academyRepository;
            ClubAddresses = clubAddressRepository;
            Clubs = clubRepository;
            RoleClaims = roleClaimRepository;
            Roles = roleRepository;
            TennisCoachs = tennisCoachRepository;
            TennisCourts = tennisCourtRepository;
            TennisCourtSchedules = tennisCourtScheduleRepository;
            TennisTraineeAddresses = tennisTraineeAddressRepository;
            TennisTrainees = tennisTraineeRepository;
            TennisTrainingPackageInformation = tennisTrainingPackageInformationRepository;
            TennisTrainingPackages = tennisTrainingPackageRepository;
            TennisTrainings = tennisTrainingRepository;
            UserClaims = userClaimRepository;
            UserLogins = userLoginRepository;
            Users = userRepository;
            UserRoles = userRoleRepository;
            UserTokens = userTokenRepository;
        }

        private readonly TamsDbContext _context;

        public IAcademyAddressRepository AcademyAddresses { get; }
        public IAcademyRepository Academies { get; }
        public IClubAddressRepository ClubAddresses { get; }
        public IClubRepository Clubs { get; }
        public IRoleClaimRepository RoleClaims { get; }
        public IRoleRepository Roles { get; }
        public ITennisCoachRepository TennisCoachs { get; }
        public ITennisCourtRepository TennisCourts { get; }
        public ITennisCourtScheduleRepository TennisCourtSchedules { get; }
        public ITennisTraineeAddressRepository TennisTraineeAddresses { get; }
        public ITennisTraineeRepository TennisTrainees { get; }
        public ITennisTrainingPackageInformationRepository TennisTrainingPackageInformation { get; }
        public ITennisTrainingPackageRepository TennisTrainingPackages { get; }
        public ITennisTrainingRepository TennisTrainings { get; }
        public IUserClaimRepository UserClaims { get; }
        public IUserLoginRepository UserLogins { get; }
        public IUserRepository Users { get; }
        public IUserRoleRepository UserRoles { get; }
        public IUserTokenRepository UserTokens { get; }

        public async Task<int> SaveChangesAsync()
        {
            DateTime now = DateTime.Now;
            //var user = _context.HttpContext.Current.User.Identity.Name;

            _context.ChangeTracker.Entries().Where(e => e.State == EntityState.Added)
                                            .ToList()
                                            .ForEach(e =>
                                            {
                                                ((IGenericInfo)e).CreatedDate = now;
                                                //((IGenericInfo)e).CreatedBy = user.Id;
                                            });

            _context.ChangeTracker.Entries().Where(e => e.State == EntityState.Modified)
                                            .ToList()
                                            .ForEach(e =>
                                            {
                                                ((IGenericInfo)e).UpdatedDate = now;
                                                //((IGenericInfo)e).UpdatedBy = user.Id;
                                            });

            _context.ChangeTracker.Entries().Where(e => e.State == EntityState.Deleted)
                                            .ToList()
                                            .ForEach(e =>
                                            {
                                                e.State = EntityState.Unchanged;
                                                ((IGenericInfo)e).IsActive = false;
                                                ((IGenericInfo)e).UpdatedDate = now;
                                                //((IGenericInfo)e).UpdatedBy = user.Id;
                                            });

            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
