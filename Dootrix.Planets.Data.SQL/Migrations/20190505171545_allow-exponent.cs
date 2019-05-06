using Microsoft.EntityFrameworkCore.Migrations;

namespace Dootrix.Planets.Data.SQL.Migrations
{
    public partial class allowexponent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mass",
                table: "Planets",
                nullable: true,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Mass",
                table: "Planets",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
