using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ONGWebAPI.Migrations
{
    public partial class NonaAtualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animais_RegistroAdocao_RegistroAdocaoId",
                table: "Animais");

            migrationBuilder.DropForeignKey(
                name: "FK_Animais_RegistroDoacao_RegistroDoacaoId",
                table: "Animais");

            migrationBuilder.DropTable(
                name: "RegistroAdocao");

            migrationBuilder.DropTable(
                name: "RegistroDoacao");

            migrationBuilder.DropIndex(
                name: "IX_Animais_RegistroAdocaoId",
                table: "Animais");

            migrationBuilder.DropIndex(
                name: "IX_Animais_RegistroDoacaoId",
                table: "Animais");

            migrationBuilder.DropColumn(
                name: "RegistroAdocaoId",
                table: "Animais");

            migrationBuilder.DropColumn(
                name: "RegistroDoacaoId",
                table: "Animais");

            migrationBuilder.AddColumn<string>(
                name: "AutorizacaoNotificacao",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Animais",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Porte",
                table: "Animais",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Localizacao",
                table: "Animais",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutorizacaoNotificacao",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "Sexo",
                table: "Animais",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Porte",
                table: "Animais",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Localizacao",
                table: "Animais",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegistroAdocaoId",
                table: "Animais",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegistroDoacaoId",
                table: "Animais",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RegistroAdocao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroAdocao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistroDoacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroDoacao", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animais_RegistroAdocaoId",
                table: "Animais",
                column: "RegistroAdocaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Animais_RegistroDoacaoId",
                table: "Animais",
                column: "RegistroDoacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animais_RegistroAdocao_RegistroAdocaoId",
                table: "Animais",
                column: "RegistroAdocaoId",
                principalTable: "RegistroAdocao",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Animais_RegistroDoacao_RegistroDoacaoId",
                table: "Animais",
                column: "RegistroDoacaoId",
                principalTable: "RegistroDoacao",
                principalColumn: "Id");
        }
    }
}
