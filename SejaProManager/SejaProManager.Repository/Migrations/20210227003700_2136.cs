using Microsoft.EntityFrameworkCore.Migrations;

namespace SejaProManager.Repository.Migrations
{
    public partial class _2136 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Financeiros",
                table: "Financeiros");

            migrationBuilder.RenameTable(
                name: "Financeiros",
                newName: "Financeiro");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Financeiro",
                table: "Financeiro",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Financeiro",
                table: "Financeiro");

            migrationBuilder.RenameTable(
                name: "Financeiro",
                newName: "Financeiros");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Financeiros",
                table: "Financeiros",
                column: "Id");
        }
    }
}
