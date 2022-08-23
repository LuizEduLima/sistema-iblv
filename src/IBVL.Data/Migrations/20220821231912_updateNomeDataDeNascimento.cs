using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IBVL.Data.Migrations
{
    public partial class updateNomeDataDeNascimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateDeNascimmento",
                table: "Membros",
                newName: "DataDeNascimmento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataDeNascimmento",
                table: "Membros",
                newName: "DateDeNascimmento");
        }
    }
}
