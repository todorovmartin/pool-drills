using Microsoft.EntityFrameworkCore.Migrations;

namespace PoolDrills.Data.Migrations
{
    public partial class AddedDifficultyToDrill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Difficulty",
                table: "Drills",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "Drills");
        }
    }
}
