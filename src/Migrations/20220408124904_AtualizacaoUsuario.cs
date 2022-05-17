using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDWebAPI.Migrations
{
    public partial class AtualizacaoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "tb-usuario");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tb-usuario",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb-usuario",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "tb-usuario",
                newName: "data_nascimento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb-usuario",
                table: "tb-usuario",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb-usuario",
                table: "tb-usuario");

            migrationBuilder.RenameTable(
                name: "tb-usuario",
                newName: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Usuarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "data_nascimento",
                table: "Usuarios",
                newName: "DataNascimento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");
        }
    }
}
