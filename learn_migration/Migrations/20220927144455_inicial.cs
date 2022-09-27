using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace learn_migration.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_genero",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    genero = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_genero", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_instituicao",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_instituicao", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_jogador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    sobrenome = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Mae = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_nasc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_jogador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_inscrito",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jogador = table.Column<int>(type: "int", nullable: false),
                    instituicao = table.Column<int>(type: "int", nullable: false),
                    data_pub = table.Column<DateTime>(type: "datetime2", nullable: true),
                    genero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_inscrito", x => x.id);
                    table.ForeignKey(
                        name: "tb_inscrito_genero_fkey",
                        column: x => x.genero,
                        principalTable: "tb_genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "tb_inscrito_instituicao_fkey",
                        column: x => x.instituicao,
                        principalTable: "tb_instituicao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "tb_inscrito_jogador_fkey",
                        column: x => x.jogador,
                        principalTable: "tb_jogador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "tb_genero_genero_key",
                table: "tb_genero",
                column: "genero",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_inscrito_genero",
                table: "tb_inscrito",
                column: "genero");

            migrationBuilder.CreateIndex(
                name: "IX_tb_inscrito_instituicao",
                table: "tb_inscrito",
                column: "instituicao");

            migrationBuilder.CreateIndex(
                name: "IX_tb_inscrito_jogador",
                table: "tb_inscrito",
                column: "jogador");

            migrationBuilder.CreateIndex(
                name: "tb_instituicao_nome_key",
                table: "tb_instituicao",
                column: "nome",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_inscrito");

            migrationBuilder.DropTable(
                name: "tb_genero");

            migrationBuilder.DropTable(
                name: "tb_instituicao");

            migrationBuilder.DropTable(
                name: "tb_jogador");
        }
    }
}
