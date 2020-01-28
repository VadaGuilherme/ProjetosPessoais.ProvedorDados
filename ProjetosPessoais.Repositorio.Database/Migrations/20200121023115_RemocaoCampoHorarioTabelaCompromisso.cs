using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetosPessoais.Repositorio.Database.Migrations
{
    public partial class RemocaoCampoHorarioTabelaCompromisso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Horario",
                schema: "compromissos",
                table: "Calendario");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Horario",
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
    }
}
