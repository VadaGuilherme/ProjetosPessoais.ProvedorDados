using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetosPessoais.Repositorio.Database.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "contapagar");

            migrationBuilder.CreateTable(
                name: "Bancos",
                schema: "contapagar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(nullable: false),
                    CodBanco = table.Column<string>(type: "varchar(55)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(55)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bancos", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "contapagar",
                table: "Bancos",
                columns: new[] { "Id", "CodBanco", "Descricao", "Guid" },
                values: new object[,]
                {
                    { 1, "001", "Banco do Brasil S.A.", new Guid("770603c5-d640-4fed-ac57-af71280fe913") },
                    { 2, "341", "Itaú S.A", new Guid("71507bb8-3f46-4133-aed1-89f2225c792a") },
                    { 3, "033", "Santander", new Guid("78b422fb-fb0e-4ffe-877b-337c6eace195") },
                    { 4, "237", "Banco Bradesco S.A.", new Guid("f9f26ba3-b888-45ff-b2e8-08bf9fe8e21d") },
                    { 5, "104", "Caixa Econômica Federal", new Guid("547028a5-0463-4061-b17a-b4a774737f98") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bancos",
                schema: "contapagar");
        }
    }
}
