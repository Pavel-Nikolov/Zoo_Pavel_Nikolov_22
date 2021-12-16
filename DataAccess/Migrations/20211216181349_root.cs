using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class root : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birds",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EnclosureNumber = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Species = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birds", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mamals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPregnant = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EnclosureNumber = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Species = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mamals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Reptiles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EnclosureNumber = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Species = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reptiles", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Birds_Name",
                table: "Birds",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Birds_Species",
                table: "Birds",
                column: "Species");

            migrationBuilder.CreateIndex(
                name: "IX_Mamals_Name",
                table: "Mamals",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Mamals_Species",
                table: "Mamals",
                column: "Species");

            migrationBuilder.CreateIndex(
                name: "IX_Reptiles_Name",
                table: "Reptiles",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Reptiles_Species",
                table: "Reptiles",
                column: "Species");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Birds");

            migrationBuilder.DropTable(
                name: "Mamals");

            migrationBuilder.DropTable(
                name: "Reptiles");
        }
    }
}
