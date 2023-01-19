using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site_Ilian_DanRaul.Migrations
{
    public partial class Titlu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Titlu",
                table: "ListaAnimecs");

            migrationBuilder.AddColumn<int>(
                name: "TitluID",
                table: "ListaAnimecs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Titlu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitluAnime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titlu", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListaAnimecs_TitluID",
                table: "ListaAnimecs",
                column: "TitluID");

            migrationBuilder.AddForeignKey(
                name: "FK_ListaAnimecs_Titlu_TitluID",
                table: "ListaAnimecs",
                column: "TitluID",
                principalTable: "Titlu",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListaAnimecs_Titlu_TitluID",
                table: "ListaAnimecs");

            migrationBuilder.DropTable(
                name: "Titlu");

            migrationBuilder.DropIndex(
                name: "IX_ListaAnimecs_TitluID",
                table: "ListaAnimecs");

            migrationBuilder.DropColumn(
                name: "TitluID",
                table: "ListaAnimecs");

            migrationBuilder.AddColumn<string>(
                name: "Titlu",
                table: "ListaAnimecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
