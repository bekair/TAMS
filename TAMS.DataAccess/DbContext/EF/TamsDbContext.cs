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

            //Ignore AddressBase table not to create it in our db.
            //builder.Ignore<AddressBase>();


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

            //One-to-One Relationship between AppUser and TennisCoach
            builder.Entity<AppUser>()
                .HasOne(m => m.TennisCoach)
                .WithOne(m => m.AppUser)
                .HasForeignKey<TennisCoach>(m => m.AppUserId);

            //One-to-Many Relationship between TennisCourt and Club
            builder.Entity<TennisCourt>()
                .HasOne(m => m.Club)
                .WithMany(m => m.TennisCourtList)
                .HasForeignKey(m => m.ClubId);

            //One-to-Many Relationship between TennisTrainee and Club
            builder.Entity<TennisTrainee>()
                .HasOne(m => m.Club)
                .WithMany(m => m.TennisTraineeList)
                .HasForeignKey(m => m.ClubId);

            //One-to-One Relationship between Club and ClubAddress
            builder.Entity<Club>()
                .HasOne(m => m.ClubAddress)
                .WithOne(m => m.Club)
                .HasForeignKey<ClubAddress>(m => m.ClubId);

            //Many-to-Many Relationship between TennisCoach and TennisTrainee
            builder.Entity<TennisCoach>()
                .HasMany(p => p.TennisTraineeList)
                .WithMany(p => p.CoachList)
                .UsingEntity(j => j.ToTable("TennisTraineeTennisCoach"));

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

            //One-to-Many Relationship between TennisTraining and TennisCoach
            builder.Entity<TennisTraining>()
                .HasOne(m => m.TennisCoach)
                .WithMany(m => m.TennisTrainingList)
                .HasForeignKey(m => m.TennisCoachId);

            //One-to-Many Relationship between TennisTraining and TennisTrainingPackage
            builder.Entity<TennisTraining>()
                .HasOne(m => m.TennisTrainingPackage)
                .WithMany(m => m.TennisTrainingList)
                .HasForeignKey(m => m.TennisTrainingPackageId);

            //Many-to-Many Relationship between TennisTrainee and TennisTraining
            builder.Entity<TennisTrainee>()
                .HasMany(p => p.TennisTrainingList)
                .WithMany(p => p.TennisTraineeList)
                .UsingEntity(j => j.ToTable("TennisTraineeTennisTraining"));

            //One-to-Many Relationship between TennisTrainee and TennisTrainingPackage
            builder.Entity<TennisTrainingPackage>()
                .HasOne(m => m.TennisTrainee)
                .WithMany(m => m.TennisTrainingPackage)
                .HasForeignKey(m => m.TennisTraineeId);

            //One-to-Many Relationship between TennisTrainee and TennisTraineeAddresses
            builder.Entity<TennisTraineeAddress>()
                .HasOne(m => m.TennisTrainee)
                .WithMany(m => m.TennisTraineeAddressList)
                .HasForeignKey(m => m.TennisTraineeId);

            //One-to-Many Relationship between TennisTrainingPackage and TennisTrainingPackageInformation
            builder.Entity<TennisTrainingPackage>()
                .HasOne(m => m.TennisTrainingPackageInformation)
                .WithMany(m => m.TennisTrainingPackageList)
                .HasForeignKey(m => m.TennisTrainingPackageInformationId);

            builder.Entity<TennisTrainingPackageInformation>()
                .HasIndex(t => t.TennisTrainingType)
                .IsUnique();
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<TennisTraining> TennisTrainings { get; set; }
        public DbSet<TennisTrainingPackage> TennisTrainingPackages { get; set; }
        public DbSet<TennisTrainee> TennisTrainees { get; set; }
        public DbSet<TennisTraineeAddress> TennisTraineeAddresses { get; set; }
        public DbSet<Academy> Academies { get; set; }
        public DbSet<AcademyAddress> AcademyAddresses { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubAddress> ClubAddresses { get; set; }
        public DbSet<TennisCoach> Coaches { get; set; }
        public DbSet<TennisCourt> TennisCourts { get; set; }
        public DbSet<TennisCourtSchedule> TennisCourtSchedules { get; set; }
        public DbSet<TennisTrainingPackageInformation> TennisTrainingPackageInformation { get; set; }
    }
}
