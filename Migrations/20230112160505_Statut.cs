using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site_Ilian_DanRaul.Migrations
{
    public partial class Statut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Opinie",
                table: "ListaAnimecs");

            migrationBuilder.AddColumn<int>(
                name: "StatutID",
                table: "ListaAnimecs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stare = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListaAnimecs_StatutID",
                table: "ListaAnimecs",
                column: "StatutID");

            migrationBuilder.AddForeignKey(
                name: "FK_ListaAnimecs_Status_StatutID",
                table: "ListaAnimecs",
                column: "StatutID",
                principalTable: "Status",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListaAnimecs_Status_StatutID",
                table: "ListaAnimecs");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropIndex(
                name: "IX_ListaAnimecs_StatutID",
                table: "ListaAnimecs");

            migrationBuilder.DropColumn(
                name: "StatutID",
                table: "ListaAnimecs");

            migrationBuilder.AddColumn<string>(
                name: "Opinie",
                table: "ListaAnimecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
