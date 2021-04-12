using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TAMS.DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Academies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademyFounder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Academies_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Academies_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisCoaches",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<long>(type: "bigint", nullable: false),
                    YearsOfExperience = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisCoaches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TennisCoaches_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisCoaches_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisCoaches_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisTrainingPackageInformation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TennisTrainingType = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(12,3)", precision: 12, scale: 3, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisTrainingPackageInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TennisTrainingPackageInformation_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTrainingPackageInformation_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AcademyAddresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademyId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddressType = table.Column<int>(type: "int", nullable: false),
                    AddressName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademyAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcademyAddresses_Academies_AcademyId",
                        column: x => x.AcademyId,
                        principalTable: "Academies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AcademyAddresses_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AcademyAddresses_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademyId = table.Column<long>(type: "bigint", nullable: true),
                    ClubName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClubAbbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClubFounder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clubs_Academies_AcademyId",
                        column: x => x.AcademyId,
                        principalTable: "Academies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clubs_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clubs_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClubAddresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddressType = table.Column<int>(type: "int", nullable: false),
                    AddressName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClubAddresses_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClubAddresses_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClubAddresses_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisCourts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubId = table.Column<long>(type: "bigint", nullable: false),
                    CourtName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourtNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourtSurface = table.Column<int>(type: "int", nullable: false),
                    CourtType = table.Column<int>(type: "int", nullable: false),
                    IsHeatingExist = table.Column<bool>(type: "bit", nullable: false),
                    IsLightingExist = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisCourts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TennisCourts_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisCourts_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisCourts_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisTrainees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TraineeType = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisTrainees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TennisTrainees_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTrainees_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTrainees_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisTraineeAddresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TennisTraineeId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddressType = table.Column<int>(type: "int", nullable: false),
                    AddressName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisTraineeAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TennisTraineeAddresses_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTraineeAddresses_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTraineeAddresses_TennisTrainees_TennisTraineeId",
                        column: x => x.TennisTraineeId,
                        principalTable: "TennisTrainees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisTraineeTennisCoaches",
                columns: table => new
                {
                    CoachListId = table.Column<long>(type: "bigint", nullable: false),
                    TennisTraineeListId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisTraineeTennisCoaches", x => new { x.CoachListId, x.TennisTraineeListId });
                    table.ForeignKey(
                        name: "FK_TennisTraineeTennisCoaches_TennisCoaches_CoachListId",
                        column: x => x.CoachListId,
                        principalTable: "TennisCoaches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTraineeTennisCoaches_TennisTrainees_TennisTraineeListId",
                        column: x => x.TennisTraineeListId,
                        principalTable: "TennisTrainees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisTrainingPackages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TennisTraineeId = table.Column<long>(type: "bigint", nullable: false),
                    TennisTrainingPackageInformationId = table.Column<long>(type: "bigint", nullable: false),
                    TotalNumberOfTraining = table.Column<int>(type: "int", nullable: false),
                    NumberOfRemainingTraining = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(12,3)", precision: 12, scale: 3, nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisTrainingPackages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TennisTrainingPackages_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTrainingPackages_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTrainingPackages_TennisTrainees_TennisTraineeId",
                        column: x => x.TennisTraineeId,
                        principalTable: "TennisTrainees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTrainingPackages_TennisTrainingPackageInformation_TennisTrainingPackageInformationId",
                        column: x => x.TennisTrainingPackageInformationId,
                        principalTable: "TennisTrainingPackageInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisTrainings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TennisTrainingPackageId = table.Column<long>(type: "bigint", nullable: true),
                    TennisCoachId = table.Column<long>(type: "bigint", nullable: false),
                    TennisCourtId = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(12,3)", precision: 12, scale: 3, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainingStatus = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisTrainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TennisTrainings_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTrainings_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTrainings_TennisCoaches_TennisCoachId",
                        column: x => x.TennisCoachId,
                        principalTable: "TennisCoaches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTrainings_TennisCourts_TennisCourtId",
                        column: x => x.TennisCourtId,
                        principalTable: "TennisCourts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTrainings_TennisTrainingPackages_TennisTrainingPackageId",
                        column: x => x.TennisTrainingPackageId,
                        principalTable: "TennisTrainingPackages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisCourtSchedules",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TennisCourtId = table.Column<long>(type: "bigint", nullable: false),
                    TennisTrainingId = table.Column<long>(type: "bigint", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisCourtSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TennisCourtSchedules_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisCourtSchedules_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisCourtSchedules_TennisCourts_TennisCourtId",
                        column: x => x.TennisCourtId,
                        principalTable: "TennisCourts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisCourtSchedules_TennisTrainings_TennisTrainingId",
                        column: x => x.TennisTrainingId,
                        principalTable: "TennisTrainings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisTraineeTennisTrainings",
                columns: table => new
                {
                    TennisTraineeListId = table.Column<long>(type: "bigint", nullable: false),
                    TennisTrainingListId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisTraineeTennisTrainings", x => new { x.TennisTraineeListId, x.TennisTrainingListId });
                    table.ForeignKey(
                        name: "FK_TennisTraineeTennisTrainings_TennisTrainees_TennisTraineeListId",
                        column: x => x.TennisTraineeListId,
                        principalTable: "TennisTrainees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTraineeTennisTrainings_TennisTrainings_TennisTrainingListId",
                        column: x => x.TennisTrainingListId,
                        principalTable: "TennisTrainings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Academies_CreatedBy",
                table: "Academies",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Academies_UpdatedBy",
                table: "Academies",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AcademyAddresses_AcademyId",
                table: "AcademyAddresses",
                column: "AcademyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AcademyAddresses_CreatedBy",
                table: "AcademyAddresses",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AcademyAddresses_UpdatedBy",
                table: "AcademyAddresses",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CreatedBy",
                table: "AspNetUsers",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UpdatedBy",
                table: "AspNetUsers",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClubAddresses_ClubId",
                table: "ClubAddresses",
                column: "ClubId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClubAddresses_CreatedBy",
                table: "ClubAddresses",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClubAddresses_UpdatedBy",
                table: "ClubAddresses",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_AcademyId",
                table: "Clubs",
                column: "AcademyId");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_CreatedBy",
                table: "Clubs",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_UpdatedBy",
                table: "Clubs",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisCoaches_AppUserId",
                table: "TennisCoaches",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TennisCoaches_CreatedBy",
                table: "TennisCoaches",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisCoaches_UpdatedBy",
                table: "TennisCoaches",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisCourts_ClubId",
                table: "TennisCourts",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_TennisCourts_CreatedBy",
                table: "TennisCourts",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisCourts_UpdatedBy",
                table: "TennisCourts",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisCourtSchedules_CreatedBy",
                table: "TennisCourtSchedules",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisCourtSchedules_TennisCourtId",
                table: "TennisCourtSchedules",
                column: "TennisCourtId");

            migrationBuilder.CreateIndex(
                name: "IX_TennisCourtSchedules_TennisTrainingId",
                table: "TennisCourtSchedules",
                column: "TennisTrainingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TennisCourtSchedules_UpdatedBy",
                table: "TennisCourtSchedules",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTraineeAddresses_CreatedBy",
                table: "TennisTraineeAddresses",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTraineeAddresses_TennisTraineeId",
                table: "TennisTraineeAddresses",
                column: "TennisTraineeId");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTraineeAddresses_UpdatedBy",
                table: "TennisTraineeAddresses",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTrainees_ClubId",
                table: "TennisTrainees",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTrainees_CreatedBy",
                table: "TennisTrainees",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTrainees_UpdatedBy",
                table: "TennisTrainees",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTraineeTennisCoaches_TennisTraineeListId",
                table: "TennisTraineeTennisCoaches",
                column: "TennisTraineeListId");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTraineeTennisTrainings_TennisTrainingListId",
                table: "TennisTraineeTennisTrainings",
                column: "TennisTrainingListId");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTrainingPackageInformation_CreatedBy",
                table: "TennisTrainingPackageInformation",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTrainingPackageInformation_TennisTrainingType",
                table: "TennisTrainingPackageInformation",
                column: "TennisTrainingType",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TennisTrainingPackageInformation_UpdatedBy",
                table: "TennisTrainingPackageInformation",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTrainingPackages_CreatedBy",
                table: "TennisTrainingPackages",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTrainingPackages_TennisTraineeId",
                table: "TennisTrainingPackages",
                column: "TennisTraineeId");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTrainingPackages_TennisTrainingPackageInformationId",
                table: "TennisTrainingPackages",
                column: "TennisTrainingPackageInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTrainingPackages_UpdatedBy",
                table: "TennisTrainingPackages",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTrainings_CreatedBy",
                table: "TennisTrainings",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTrainings_TennisCoachId",
                table: "TennisTrainings",
                column: "TennisCoachId");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTrainings_TennisCourtId",
                table: "TennisTrainings",
                column: "TennisCourtId");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTrainings_TennisTrainingPackageId",
                table: "TennisTrainings",
                column: "TennisTrainingPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_TennisTrainings_UpdatedBy",
                table: "TennisTrainings",
                column: "UpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademyAddresses");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ClubAddresses");

            migrationBuilder.DropTable(
                name: "TennisCourtSchedules");

            migrationBuilder.DropTable(
                name: "TennisTraineeAddresses");

            migrationBuilder.DropTable(
                name: "TennisTraineeTennisCoaches");

            migrationBuilder.DropTable(
                name: "TennisTraineeTennisTrainings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "TennisTrainings");

            migrationBuilder.DropTable(
                name: "TennisCoaches");

            migrationBuilder.DropTable(
                name: "TennisCourts");

            migrationBuilder.DropTable(
                name: "TennisTrainingPackages");

            migrationBuilder.DropTable(
                name: "TennisTrainees");

            migrationBuilder.DropTable(
                name: "TennisTrainingPackageInformation");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Academies");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
