using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pfff.Migrations
{
    public partial class AddCameraToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gebruiker",
                columns: table => new
                {
                    GebruikerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GebruikersNaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Punten = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruiker", x => x.GebruikerID);
                });

            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    CameraID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitute = table.Column<float>(type: "real", nullable: false),
                    Longitude = table.Column<float>(type: "real", nullable: false),
                    Specificatie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GebruikerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.CameraID);
                    table.ForeignKey(
                        name: "FK_Cameras_Gebruiker_GebruikerID",
                        column: x => x.GebruikerID,
                        principalTable: "Gebruiker",
                        principalColumn: "GebruikerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_GebruikerID",
                table: "Cameras",
                column: "GebruikerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cameras");

            migrationBuilder.DropTable(
                name: "Gebruiker");
        }
    }
}
