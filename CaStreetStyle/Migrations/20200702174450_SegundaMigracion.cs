using Microsoft.EntityFrameworkCore.Migrations;

namespace CaStreetStyle.Migrations
{
    public partial class SegundaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "GananciaAumentada",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GananciaAumentada",
                table: "Articulos");
        }
    }
}
