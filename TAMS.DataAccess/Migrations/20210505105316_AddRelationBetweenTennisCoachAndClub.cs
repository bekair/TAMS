using Microsoft.EntityFrameworkCore.Migrations;

namespace TAMS.DataAccess.Migrations
{
    public partial class AddRelationBetweenTennisCoachAndClub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClubId",
                table: "TennisCoaches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TennisCoaches_ClubId",
                table: "TennisCoaches",
                column: "ClubId");

            migrationBuilder.AddForeignKey(
                name: "FK_TennisCoaches_Clubs_ClubId",
                table: "TennisCoaches",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TennisCoaches_Clubs_ClubId",
                table: "TennisCoaches");

            migrationBuilder.DropIndex(
                name: "IX_TennisCoaches_ClubId",
                table: "TennisCoaches");

            migrationBuilder.DropColumn(
                name: "ClubId",
                table: "TennisCoaches");
        }
    }
}
