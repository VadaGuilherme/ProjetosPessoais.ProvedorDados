using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetosPessoais.Repositorio.Database.Migrations
{
    public partial class AlteracaoTipoDataTabelaCompromisso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                schema: "compromissos",
                table: "Calendario");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCompromisso",
                schema: "compromissos",
                table: "Calendario",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("2a0c2920-e59b-4b5d-9f44-86a2438371b4"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("26899535-d1fd-49bd-8c6a-8a88efd7da7b"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("6a3ca4be-6997-41ea-b4f1-dcbba4d97207"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("5e345ced-8498-4b1e-a0bc-77dc52e805ae"));

            migrationBuilder.UpdateData(
                schema: "contapagar",
                table: "Bancos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("22a695db-618c-4e2f-8721-9d876f9cd226"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCompromisso",
                schema: "compromissos",
                table: "Calendario");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                schema: "compromissos",
                table: "Calendario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
