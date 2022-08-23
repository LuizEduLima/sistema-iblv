using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IBVL.Data.Migrations
{
    public partial class trocadocampoAtivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "usuarios");
        }
    }
}
