using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ONGWebAPI.Migrations
{
    public partial class TerceiraAtualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animais_Usuarios_UsuarioId",
                table: "Animais");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Animais",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Animais_Usuarios_UsuarioId",
                table: "Animais",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animais_Usuarios_UsuarioId",
                table: "Animais");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Animais",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Animais_Usuarios_UsuarioId",
                table: "Animais",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
