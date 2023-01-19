using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site_Ilian_DanRaul.Migrations
{
    public partial class NotaAnime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nota",
                table: "ListaAnimecs");

            migrationBuilder.AddColumn<int>(
                name: "NotaID",
                table: "ListaAnimecs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Nota",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotaAnime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nota", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListaAnimecs_NotaID",
                table: "ListaAnimecs",
                column: "NotaID");

            migrationBuilder.AddForeignKey(
                name: "FK_ListaAnimecs_Nota_NotaID",
                table: "ListaAnimecs",
                column: "NotaID",
                principalTable: "Nota",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListaAnimecs_Nota_NotaID",
                table: "ListaAnimecs");

            migrationBuilder.DropTable(
                name: "Nota");

            migrationBuilder.DropIndex(
                name: "IX_ListaAnimecs_NotaID",
                table: "ListaAnimecs");

            migrationBuilder.DropColumn(
                name: "NotaID",
                table: "ListaAnimecs");

            migrationBuilder.AddColumn<decimal>(
                name: "Nota",
                table: "ListaAnimecs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
