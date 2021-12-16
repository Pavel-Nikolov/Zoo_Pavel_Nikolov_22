using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class temp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TempreturePreference",
                table: "Reptiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TempreturePreference",
                table: "Mamals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TempreturePreference",
                table: "Birds",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TempreturePreference",
                table: "Reptiles");

            migrationBuilder.DropColumn(
                name: "TempreturePreference",
                table: "Mamals");

            migrationBuilder.DropColumn(
                name: "TempreturePreference",
                table: "Birds");
        }
    }
}
