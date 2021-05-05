using System;
using System.Threading.Tasks;
using TAMS.DataAccess.Repositories.Interfaces;

namespace TAMS.DataAccess.UnitOfWork.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAcademyAddressRepository AcademyAddresses { get; }
        IAcademyRepository Academies { get; }
        IClubAddressRepository ClubAddresses { get; }
        IClubRepository Clubs { get; }
        IRoleClaimRepository RoleClaims { get; }
        IRoleRepository Roles { get; }
        ITennisCoachRepository TennisCoachs { get; }
        ITennisCourtRepository TennisCourts { get; }
        ITennisCourtScheduleRepository TennisCourtSchedules { get; }
        ITennisTraineeAddressRepository TennisTraineeAddresses { get; }
        ITennisTraineeRepository TennisTrainees { get; }
        ITennisTrainingPackageInformationRepository TennisTrainingPackageInformation { get; }
        ITennisTrainingPackageRepository TennisTrainingPackages { get; }
        ITennisTrainingRepository TennisTrainings { get; }
        IUserClaimRepository UserClaims { get; }
        IUserLoginRepository UserLogins { get; }
        IUserRepository Users { get; }
        IUserRoleRepository UserRoles { get; }
        IUserTokenRepository UserTokens { get; }
        Task<int> SaveChangesAsync();
    }
}