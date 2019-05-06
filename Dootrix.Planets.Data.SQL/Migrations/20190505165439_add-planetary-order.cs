using Microsoft.EntityFrameworkCore.Migrations;

namespace Dootrix.Planets.Data.SQL.Migrations
{
    public partial class addplanetaryorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlanetaryOrder",
                table: "Planets",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlanetaryOrder",
                table: "Planets");
        }
    }
}
