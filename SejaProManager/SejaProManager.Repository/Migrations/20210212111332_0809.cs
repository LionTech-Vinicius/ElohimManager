using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SejaProManager.Repository.Migrations
{
    public partial class _0809 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_CONGREGACAO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    NomeResp = table.Column<string>(type: "varchar(150) CHARACTER SET utf8mb4", maxLength: 150, nullable: true),
                    DtFundacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CONGREGACAO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_PESSOA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    NomeMae = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    NomePai = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    DtNascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    GrauInstrucao = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    Sexo = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: true),
                    Rg = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: true),
                    RgEmissao = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    Cpf = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: true),
                    Nacionalidade = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    Naturalidade = table.Column<string>(type: "varchar(150) CHARACTER SET utf8mb4", maxLength: 150, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Active = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PESSOA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_CONTATO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    Descricao = table.Column<string>(type: "varchar(150) CHARACTER SET utf8mb4", maxLength: 150, nullable: true),
                    PessoaId = table.Column<int>(type: "int", nullable: true),
                    CongregacaoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CONTATO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_CONTATO_T_CONGREGACAO_CongregacaoId",
                        column: x => x.CongregacaoId,
                        principalTable: "T_CONGREGACAO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_CONTATO_T_PESSOA_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "T_PESSOA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_ENDERECO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(150) CHARACTER SET utf8mb4", maxLength: 150, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(150) CHARACTER SET utf8mb4", maxLength: 150, nullable: true),
                    Uf = table.Column<string>(type: "varchar(2) CHARACTER SET utf8mb4", maxLength: 2, nullable: true),
                    Cep = table.Column<string>(type: "varchar(15) CHARACTER SET utf8mb4", maxLength: 15, nullable: true),
                    Complemento = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    PessoaId = table.Column<int>(type: "int", nullable: true),
                    CongregacaoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ENDERECO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_ENDERECO_T_CONGREGACAO_CongregacaoId",
                        column: x => x.CongregacaoId,
                        principalTable: "T_CONGREGACAO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_ENDERECO_T_PESSOA_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "T_PESSOA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_MEMBRO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Profissao = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    AtividadeProfissional = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    DtBatismo = table.Column<DateTime>(type: "datetime", nullable: false),
                    NomeIgrejaBat = table.Column<string>(type: "varchar(150) CHARACTER SET utf8mb4", maxLength: 150, nullable: true),
                    BatismoComES = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    RecebidoPorCarta = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    RecebidoPorAclamacao = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DtRecebido = table.Column<DateTime>(type: "datetime", nullable: false),
                    Motivo = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    IgrejaProcedencia = table.Column<string>(type: "varchar(150) CHARACTER SET utf8mb4", maxLength: 150, nullable: true),
                    CargoOcupado = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    TempoOcupado = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    Observacao = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    LiderFamiliar = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    EstadoCivil = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: true),
                    DtCasamento = table.Column<DateTime>(type: "datetime", nullable: false),
                    NomeConjuge = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    QtdFilhos = table.Column<int>(type: "int", nullable: false),
                    CongregacaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_MEMBRO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_MEMBRO_T_CONGREGACAO_CongregacaoId",
                        column: x => x.CongregacaoId,
                        principalTable: "T_CONGREGACAO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_MEMBRO_T_PESSOA_Id",
                        column: x => x.Id,
                        principalTable: "T_PESSOA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_CONTATO_CongregacaoId",
                table: "T_CONTATO",
                column: "CongregacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_T_CONTATO_PessoaId",
                table: "T_CONTATO",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ENDERECO_CongregacaoId",
                table: "T_ENDERECO",
                column: "CongregacaoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_ENDERECO_PessoaId",
                table: "T_ENDERECO",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_T_MEMBRO_CongregacaoId",
                table: "T_MEMBRO",
                column: "CongregacaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_CONTATO");

            migrationBuilder.DropTable(
                name: "T_ENDERECO");

            migrationBuilder.DropTable(
                name: "T_MEMBRO");

            migrationBuilder.DropTable(
                name: "T_CONGREGACAO");

            migrationBuilder.DropTable(
                name: "T_PESSOA");
        }
    }
}
