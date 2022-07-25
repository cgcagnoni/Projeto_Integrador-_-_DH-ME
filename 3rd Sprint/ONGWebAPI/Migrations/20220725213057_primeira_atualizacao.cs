using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ONGWebAPI.Migrations
{
    public partial class primeira_atualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localizacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioDoador_Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animais_Usuarios_UsuarioAdotanteId",
                table: "Animais");

            migrationBuilder.DropForeignKey(
                name: "FK_Animais_Usuarios_UsuarioDoadorId",
                table: "Animais");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Animais_UsuarioAdotanteId",
                table: "Animais");

            migrationBuilder.DropIndex(
                name: "IX_Animais_UsuarioDoadorId",
                table: "Animais");

            migrationBuilder.DropColumn(
                name: "UsuarioAdotanteId",
                table: "Animais");

            migrationBuilder.DropColumn(
                name: "UsuarioDoadorId",
                table: "Animais");
        }
    }
}
