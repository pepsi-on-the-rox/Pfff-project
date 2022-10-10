using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pfff.Migrations
{
    public partial class gebruikerint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cameras_Gebruiker_GebruikerID",
                table: "Cameras");

            migrationBuilder.DropTable(
                name: "Gebruiker");

            migrationBuilder.DropIndex(
                name: "IX_Cameras_GebruikerID",
                table: "Cameras");

            migrationBuilder.RenameColumn(
                name: "GebruikerID",
                table: "Cameras",
                newName: "Gebruiker");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gebruiker",
                table: "Cameras",
                newName: "GebruikerID");

            migrationBuilder.CreateTable(
                name: "Gebruiker",
                columns: table => new
                {
                    GebruikerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cameras = table.Column<int>(type: "int", nullable: false),
                    GebruikersNaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Punten = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruiker", x => x.GebruikerID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_GebruikerID",
                table: "Cameras",
                column: "GebruikerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cameras_Gebruiker_GebruikerID",
                table: "Cameras",
                column: "GebruikerID",
                principalTable: "Gebruiker",
                principalColumn: "GebruikerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
