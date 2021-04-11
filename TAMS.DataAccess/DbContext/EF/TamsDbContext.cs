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

            //One-to-One Relationship between Academy and AcademyAddress
            builder.Entity<Academy>()
                .HasOne(m => m.AcademyAddress)
                .WithOne(m => m.Academy)
                .HasForeignKey<AcademyAddress>(m => m.AcademyId);

            //One-to-Many Relationship between Club and Academy
            builder.Entity<Club>()
                .HasOne(m => m.Academy)
                .WithMany(m => m.ClubList)
                .HasForeignKey(m => m.AcademyId);

            //One-to-One Relationship between AppUser and Coach
            builder.Entity<AppUser>()
                .HasOne(m => m.Coach)
                .WithOne(m => m.AppUser)
                .HasForeignKey<Coach>(m => m.AppUserId);

            //One-to-Many Relationship between TennisCourt and Club
            builder.Entity<TennisCourt>()
                .HasOne(m => m.Club)
                .WithMany(m => m.TennisCourtList)
                .HasForeignKey(m => m.ClubId);

            //One-to-Many Relationship between Trainee and Club
            builder.Entity<Trainee>()
                .HasOne(m => m.Club)
                .WithMany(m => m.TraineeList)
                .HasForeignKey(m => m.ClubId);

            //One-to-One Relationship between Club and ClubAddress
            builder.Entity<Club>()
                .HasOne(m => m.ClubAddress)
                .WithOne(m => m.Club)
                .HasForeignKey<ClubAddress>(m => m.ClubId);

            //Many-to-Many Relationship between Coach and Trainee
            builder.Entity<Coach>()
                .HasMany(p => p.TraineeList)
                .WithMany(p => p.CoachList)
                .UsingEntity(j => j.ToTable("TraineeCoach"));

            //One-to-Many Relationship between TennisCourtSchedule and TennisCourt
            builder.Entity<TennisCourtSchedule>()
                .HasOne(m => m.TennisCourt)
                .WithMany(m => m.TennisCourtScheduleList)
                .HasForeignKey(m => m.TennisCourtId);

            //One-to-One Relationship between TennisTraining and TennisCourtSchedule
            builder.Entity<TennisTraining>()
                .HasOne(m => m.TennisCourtSchedule)
                .WithOne(m => m.TennisTraining)
                .HasForeignKey<TennisCourtSchedule>(m => m.TennisTrainingId);

            //One-to-Many Relationship between TennisTraining and Coach
            builder.Entity<TennisTraining>()
                .HasOne(m => m.Coach)
                .WithMany(m => m.TennisTrainingList)
                .HasForeignKey(m => m.CoachId);

            //One-to-Many Relationship between TennisTraining and TennisTrainingPackage
            builder.Entity<TennisTraining>()
                .HasOne(m => m.TennisTrainingPackage)
                .WithMany(m => m.TennisTrainingList)
                .HasForeignKey(m => m.TennisTrainingPackageId);

            //Many-to-Many Relationship between Trainee and TennisTraining
            builder.Entity<Trainee>()
                .HasMany(p => p.TennisTrainingList)
                .WithMany(p => p.TraineeList)
                .UsingEntity(j => j.ToTable("TraineeTennisTraining"));

            //One-to-Many Relationship between Trainee and TennisTrainingPackage
            builder.Entity<TennisTrainingPackage>()
                .HasOne(m => m.Trainee)
                .WithMany(m => m.TennisTrainingPackageList)
                .HasForeignKey(m => m.TraineeId);

            //One-to-Many Relationship between Trainee and TraineeAddress
            builder.Entity<TraineeAddress>()
                .HasOne(m => m.Trainee)
                .WithMany(m => m.TraineeAddressList)
                .HasForeignKey(m => m.TraineeId);
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<TennisTraining> TennisTrainings { get; set; }
        public DbSet<TennisTrainingPackage> TennisTrainingPackages { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<TraineeAddress> TraineeAddresses { get; set; }
        public DbSet<Academy> Academies { get; set; }
        public DbSet<AcademyAddress> AcademyAddresses { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubAddress> ClubAddresses { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<TennisCourt> TennisCourts { get; set; }
        public DbSet<TennisCourtSchedule> TennisCourtSchedules { get; set; }
    }
}
