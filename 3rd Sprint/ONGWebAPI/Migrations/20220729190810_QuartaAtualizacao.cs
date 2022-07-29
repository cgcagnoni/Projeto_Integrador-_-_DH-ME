using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ONGWebAPI.Migrations
{
    public partial class QuartaAtualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
