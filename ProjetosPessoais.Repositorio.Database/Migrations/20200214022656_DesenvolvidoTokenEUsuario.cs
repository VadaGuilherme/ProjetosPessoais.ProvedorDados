using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetosPessoais.Repositorio.Database.Migrations
{
    public partial class DesenvolvidoTokenEUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "autenticacao");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                schema: "autenticacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(55)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(55)", nullable: false),
                    Email = table.Column<string>(type: "varchar(55)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("fe1ca0b9-1ebb-4f07-8c42-0c2f4da22f34"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("d73a6bf6-b176-4f52-9b27-4e94c582f5a0"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("bc560e93-19de-4fab-b3c1-8a35e1eb0822"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("cf62b69f-d0a4-49a8-acfe-1c794369f43c"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("0329b07d-de03-4688-9b51-2b048061d5a1"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios",
                schema: "autenticacao");

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("fdc72818-8d66-4527-bef6-14d011ff556f"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("9fe867a9-fe59-4150-aa2e-01f723de7e31"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("059a1218-9a8d-4a45-8b04-226f5dc49d84"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("7bc0cb01-c15b-4a48-a5fd-f0ab313067c8"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("c321180e-1733-479d-b585-d5cd922260b6"));
        }
    }
}
