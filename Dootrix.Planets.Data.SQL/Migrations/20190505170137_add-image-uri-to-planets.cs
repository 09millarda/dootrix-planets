using Microsoft.EntityFrameworkCore.Migrations;

namespace Dootrix.Planets.Data.SQL.Migrations
{
    public partial class addimageuritoplanets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUri",
                table: "Planets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUri",
                table: "Planets");
        }
    }
}
