using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TAMS.DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Academies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademyFounder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Academies_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Academies_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Role_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisCoaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    YearsOfExperience = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisCoaches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TennisCoaches_User_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisCoaches_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisCoaches_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisTrainingPackageInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TennisTrainingType = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(12,3)", precision: 12, scale: 3, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisTrainingPackageInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TennisTrainingPackageInformation_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTrainingPackageInformation_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaim_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserClaim_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserClaim_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogin_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserLogin_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserLogin_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserToken",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserToken_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserToken_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserToken_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AcademyAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademyId = table.Column<int>(type: "int", nullable: false),
                    AddressType = table.Column<int>(type: "int", nullable: false),
                    AddressName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                        name: "FK_AcademyAddresses_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AcademyAddresses_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademyId = table.Column<int>(type: "int", nullable: true),
                    ClubName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClubAbbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClubFounder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Clubs_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clubs_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaim_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RoleClaim_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RoleClaim_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserRole_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserRole_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClubAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubId = table.Column<int>(type: "int", nullable: false),
                    AddressType = table.Column<int>(type: "int", nullable: false),
                    AddressName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClubAddresses_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClubAddresses_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClubAddresses_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisCourts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubId = table.Column<int>(type: "int", nullable: false),
                    CourtName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourtNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourtSurface = table.Column<int>(type: "int", nullable: false),
                    CourtType = table.Column<int>(type: "int", nullable: false),
                    IsHeatingExist = table.Column<bool>(type: "bit", nullable: false),
                    IsLightingExist = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisCourts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TennisCourts_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisCourts_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisCourts_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisTrainees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TraineeType = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisTrainees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TennisTrainees_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTrainees_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTrainees_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisTraineeAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TennisTraineeId = table.Column<int>(type: "int", nullable: false),
                    AddressType = table.Column<int>(type: "int", nullable: false),
                    AddressName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisTraineeAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TennisTraineeAddresses_TennisTrainees_TennisTraineeId",
                        column: x => x.TennisTraineeId,
                        principalTable: "TennisTrainees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTraineeAddresses_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTraineeAddresses_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisTraineeTennisCoaches",
                columns: table => new
                {
                    CoachListId = table.Column<int>(type: "int", nullable: false),
                    TennisTraineeListId = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TennisTraineeId = table.Column<int>(type: "int", nullable: false),
                    TennisTrainingPackageInformationId = table.Column<int>(type: "int", nullable: false),
                    TotalNumberOfTraining = table.Column<int>(type: "int", nullable: false),
                    NumberOfRemainingTraining = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(12,3)", precision: 12, scale: 3, nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisTrainingPackages", x => x.Id);
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
                    table.ForeignKey(
                        name: "FK_TennisTrainingPackages_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTrainingPackages_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisTrainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TennisTrainingPackageId = table.Column<int>(type: "int", nullable: true),
                    TennisCoachId = table.Column<int>(type: "int", nullable: false),
                    TennisCourtId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(12,3)", precision: 12, scale: 3, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainingStatus = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisTrainings", x => x.Id);
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
                    table.ForeignKey(
                        name: "FK_TennisTrainings_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisTrainings_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisCourtSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TennisCourtId = table.Column<int>(type: "int", nullable: false),
                    TennisTrainingId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisCourtSchedules", x => x.Id);
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
                    table.ForeignKey(
                        name: "FK_TennisCourtSchedules_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisCourtSchedules_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TennisTraineeTennisTrainings",
                columns: table => new
                {
                    TennisTraineeListId = table.Column<int>(type: "int", nullable: false),
                    TennisTrainingListId = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_Role_CreatedBy",
                table: "Role",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Role_UpdatedBy",
                table: "Role",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Role",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaim_CreatedBy",
                table: "RoleClaim",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaim_RoleId",
                table: "RoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaim_UpdatedBy",
                table: "RoleClaim",
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

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatedBy",
                table: "User",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_User_UpdatedBy",
                table: "User",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaim_CreatedBy",
                table: "UserClaim",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaim_UpdatedBy",
                table: "UserClaim",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaim_UserId",
                table: "UserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_CreatedBy",
                table: "UserLogin",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_UpdatedBy",
                table: "UserLogin",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_UserId",
                table: "UserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_CreatedBy",
                table: "UserRole",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UpdatedBy",
                table: "UserRole",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserToken_CreatedBy",
                table: "UserToken",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserToken_UpdatedBy",
                table: "UserToken",
                column: "UpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademyAddresses");

            migrationBuilder.DropTable(
                name: "ClubAddresses");

            migrationBuilder.DropTable(
                name: "RoleClaim");

            migrationBuilder.DropTable(
                name: "TennisCourtSchedules");

            migrationBuilder.DropTable(
                name: "TennisTraineeAddresses");

            migrationBuilder.DropTable(
                name: "TennisTraineeTennisCoaches");

            migrationBuilder.DropTable(
                name: "TennisTraineeTennisTrainings");

            migrationBuilder.DropTable(
                name: "UserClaim");

            migrationBuilder.DropTable(
                name: "UserLogin");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "UserToken");

            migrationBuilder.DropTable(
                name: "TennisTrainings");

            migrationBuilder.DropTable(
                name: "Role");

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
                name: "User");
        }
    }
}
