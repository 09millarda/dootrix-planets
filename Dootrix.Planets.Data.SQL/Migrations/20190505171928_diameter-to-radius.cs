using Microsoft.EntityFrameworkCore.Migrations;

namespace Dootrix.Planets.Data.SQL.Migrations
{
    public partial class diametertoradius : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Diameter",
                table: "Planets",
                newName: "Radius");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Radius",
                table: "Planets",
                newName: "Diameter");
        }
    }
}
