using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Infra.Data.Migrations
{
    public partial class Pessoas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Contatos_ContatoId",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Pessoas");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_ContatoId",
                table: "Pessoas",
                newName: "IX_Pessoas_ContatoId");

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Pessoas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Contatos_ContatoId",
                table: "Pessoas",
                column: "ContatoId",
                principalTable: "Contatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Pessoas_PessoaId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Contatos_ContatoId",
                table: "Pessoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_PessoaId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Pessoas",
                newName: "Clientes");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoas_ContatoId",
                table: "Clientes",
                newName: "IX_Clientes_ContatoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Contatos_ContatoId",
                table: "Clientes",
                column: "ContatoId",
                principalTable: "Contatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
