using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SejaProManager.Repository.Migrations
{
    public partial class _1935 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Login = table.Column<string>(type: "varchar CHARACTER SET utf8mb4", nullable: true),
                    Nome = table.Column<string>(type: "varchar CHARACTER SET utf8mb4", nullable: true),
                    Senha = table.Column<string>(type: "varchar CHARACTER SET utf8mb4", nullable: true),
                    Perfil = table.Column<string>(type: "varchar CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
