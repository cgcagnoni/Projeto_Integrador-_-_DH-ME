using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ONGWebAPI.Migrations
{
    public partial class SegundaAtualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animais_Usuarios_UsuarioAdotanteId",
                table: "Animais");

            migrationBuilder.DropForeignKey(
                name: "FK_Animais_Usuarios_UsuarioDoadorId",
                table: "Animais");

            migrationBuilder.DropIndex(
                name: "IX_Animais_UsuarioAdotanteId",
                table: "Animais");

            migrationBuilder.DropIndex(
                name: "IX_Animais_UsuarioDoadorId",
                table: "Animais");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UsuarioDoador_Telefone",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UsuarioAdotanteId",
                table: "Animais");

            migrationBuilder.DropColumn(
                name: "UsuarioDoadorId",
                table: "Animais");

            migrationBuilder.AddColumn<bool>(
                name: "Disponibilidade",
                table: "Animais",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Animais",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Animais_UsuarioId",
                table: "Animais",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animais_Usuarios_UsuarioId",
                table: "Animais",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animais_Usuarios_UsuarioId",
                table: "Animais");

            migrationBuilder.DropIndex(
                name: "IX_Animais_UsuarioId",
                table: "Animais");

            migrationBuilder.DropColumn(
                name: "Disponibilidade",
                table: "Animais");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Animais");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioDoador_Telefone",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioAdotanteId",
                table: "Animais",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioDoadorId",
                table: "Animais",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animais_UsuarioAdotanteId",
                table: "Animais",
                column: "UsuarioAdotanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Animais_UsuarioDoadorId",
                table: "Animais",
                column: "UsuarioDoadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animais_Usuarios_UsuarioAdotanteId",
                table: "Animais",
                column: "UsuarioAdotanteId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Animais_Usuarios_UsuarioDoadorId",
                table: "Animais",
                column: "UsuarioDoadorId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
