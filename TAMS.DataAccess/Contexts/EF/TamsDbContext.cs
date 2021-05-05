using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Contexts.EF
{
    public class TamsDbContext : IdentityDbContext<AppUser, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public TamsDbContext(DbContextOptions<TamsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Overrides of Identity entity names which gives its name to Tables as defaults
            builder.Entity<AppUser>().ToTable("User");
            builder.Entity<RoleClaim>().ToTable(nameof(RoleClaim));
            builder.Entity<Role>().ToTable(nameof(Role));
            builder.Entity<UserClaim>().ToTable(nameof(UserClaim));
            builder.Entity<UserRole>().ToTable(nameof(UserRole));
            builder.Entity<UserLogin>().ToTable(nameof(UserLogin));
            builder.Entity<UserToken>().ToTable(nameof(UserToken));

            //Precision and Scale configuration for TennisTraining => Price property
            builder.Entity<TennisTraining>()
                .Property(tt => tt.Price)
                .HasPrecision(12, 3);

            //Precision and Scale configuration for TennisTrainingPackage => TotalPrice property
            builder.Entity<TennisTrainingPackage>()
                .Property(ttp => ttp.TotalPrice)
                .HasPrecision(12, 3);

            //Precision and Scale configuration for TennisTrainingPackageInformation => UnitPrice property
            builder.Entity<TennisTrainingPackageInformation>()
                .Property(ttp => ttp.UnitPrice)
                .HasPrecision(12, 3);

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

            //One-to-Many Relationship between TennisCoach and Club
            builder.Entity<TennisCoach>()
                .HasOne(m => m.Club)
                .WithMany(m => m.TennisCoachList)
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
                .UsingEntity(j => j.ToTable("TennisTraineeTennisCoaches"));

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
                .UsingEntity(j => j.ToTable("TennisTraineeTennisTrainings"));

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

            //One-to-Many Relationship between AppUser and AppUser (CreatedBy)
            builder.Entity<AppUser>()
                .HasOne(m => m.CreatedByUser)
                .WithMany(m => m.CreatedUserList)
                .HasForeignKey(m => m.CreatedBy);

            //One-to-Many Relationship between AppUser and AppUser (UpdatedBy)
            builder.Entity<AppUser>()
                .HasOne(m => m.UpdatedByUser)
                .WithMany(m => m.UpdatedUserList)
                .HasForeignKey(m => m.UpdatedBy);

            //Unique Constraint in TennisTrainingPackageInformation => TennisTrainingType property
            builder.Entity<TennisTrainingPackageInformation>()
                .HasIndex(t => t.TennisTrainingType)
                .IsUnique();

            //This row should be last row after the foreign key definitons.
            //OnDelete Cascade prevention. To prevent the 'Introducing FOREIGN KEY constraint for all tables
            //which may cause cycles or multiple cascade paths.' error, OnDelete NoAction raw has been added.
            foreach (var foreignKey in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.NoAction;
            }
        }

        public DbSet<TennisTraining> TennisTrainings { get; set; }
        public DbSet<TennisTrainingPackage> TennisTrainingPackages { get; set; }
        public DbSet<TennisTrainee> TennisTrainees { get; set; }
        public DbSet<TennisTraineeAddress> TennisTraineeAddresses { get; set; }
        public DbSet<Academy> Academies { get; set; }
        public DbSet<AcademyAddress> AcademyAddresses { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubAddress> ClubAddresses { get; set; }
        public DbSet<TennisCoach> TennisCoaches { get; set; }
        public DbSet<TennisCourt> TennisCourts { get; set; }
        public DbSet<TennisCourtSchedule> TennisCourtSchedules { get; set; }
        public DbSet<TennisTrainingPackageInformation> TennisTrainingPackageInformation { get; set; }
    }
}
