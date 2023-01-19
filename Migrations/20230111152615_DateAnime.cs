using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site_Ilian_DanRaul.Migrations
{
    public partial class DateAnime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Final",
                table: "ListaAnimecs");

            migrationBuilder.DropColumn(
                name: "Inceput",
                table: "ListaAnimecs");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFinal",
                table: "ListaAnimecs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInceput",
                table: "ListaAnimecs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataFinal",
                table: "ListaAnimecs");

            migrationBuilder.DropColumn(
                name: "DataInceput",
                table: "ListaAnimecs");

            migrationBuilder.AddColumn<string>(
                name: "Final",
                table: "ListaAnimecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Inceput",
                table: "ListaAnimecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
