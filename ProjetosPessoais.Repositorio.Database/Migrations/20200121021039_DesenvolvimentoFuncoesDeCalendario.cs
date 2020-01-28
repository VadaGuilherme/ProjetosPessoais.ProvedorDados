using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetosPessoais.Repositorio.Database.Migrations
{
    public partial class DesenvolvimentoFuncoesDeCalendario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "compromissos");

            migrationBuilder.CreateTable(
                name: "Calendario",
                schema: "compromissos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(type: "varchar(55)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(55)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horario = table.Column<DateTime>(nullable: false),
                    Local = table.Column<string>(type: "varchar(55)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendario", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("ecf874f1-8a05-4daa-936e-5161145d6cf4"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("59b66633-f2db-42c2-82a6-33292cc3f056"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("305b236a-df44-42da-a829-1456c020f6b7"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("ff97df7c-0cc7-4138-85c2-3c1919e7026b"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("28458097-4258-404b-bbab-f7aac868e055"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calendario",
                schema: "compromissos");

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("46897f5a-cd01-48dd-87b3-4c4f6e20de79"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("3d690cba-1247-4b5e-a36e-93826a35f86e"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("2a25aaf8-9e07-49bf-b7d4-ffdb5f02d174"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("dc4d0d09-5c9e-4c40-9ad1-96ca14b4fb9e"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("0cc15f3e-b670-4323-8c07-6a8c890d1195"));
        }
    }
}
