using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Infra.Data.Migrations
{
    public partial class Retirando_FK_Pessoas_Recursiva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Pessoas_PessoaId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_PessoaId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Pessoas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Pessoas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_PessoaId",
                table: "Pessoas",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Pessoas_PessoaId",
                table: "Pessoas",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
