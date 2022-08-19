using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ONGWebAPI.Migrations
{
    public partial class OitavaAtualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InteresseAdocao_Usuarios_UsuarioId",
                table: "InteresseAdocao");

            migrationBuilder.DropIndex(
                name: "IX_InteresseAdocao_UsuarioId",
                table: "InteresseAdocao");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "InteresseAdocao");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "InteresseAdocao",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "InteresseAdocao",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "InteresseAdocao",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "InteresseAdocao");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "InteresseAdocao");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "InteresseAdocao");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "InteresseAdocao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InteresseAdocao_UsuarioId",
                table: "InteresseAdocao",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_InteresseAdocao_Usuarios_UsuarioId",
                table: "InteresseAdocao",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
