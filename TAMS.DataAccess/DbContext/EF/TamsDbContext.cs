using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.DbContext.EF
{
    public class TamsDbContext : IdentityDbContext
    {
        public TamsDbContext(DbContextOptions<TamsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Ignore IdentityUser table not to create it in our db.
            builder.Ignore<IdentityUser>();


        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<TennisTraining> TennisTrainings { get; set; }
        public DbSet<TennisTrainingPackage> TennisTrainingPackages { get; set; }
        public DbSet<TraineeTennisTraining> TraineeTennisTrainings { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<TraineeAddress> TraineeAddresses { get; set; }
        public DbSet<Academy> Academies { get; set; }
        public DbSet<AcademyAddress> AcademyAddresses { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubAddress> ClubAddresses { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<TennisCourt> TennisCourts { get; set; }
        public DbSet<TraineeCoach> TraineeCoaches { get; set; }
        public DbSet<TennisCourtSchedule> TennisCourtSchedules { get; set; }
    }
}
