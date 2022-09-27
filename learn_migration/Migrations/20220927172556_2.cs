using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace learn_migration.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mae",
                table: "tb_jogador");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mae",
                table: "tb_jogador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
