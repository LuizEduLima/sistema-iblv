using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IBVL.Data.Migrations
{
    public partial class datacriacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "usuarios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "Membros",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "Enderecos",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "Membros");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "Enderecos");
        }
    }
}
