using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    
    public partial class tabelaCaixa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Entrada",
                table: "saidaProduto",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Saida",
                table: "saidaProduto",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Valor",
                table: "saidaProduto",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Entrada",
                table: "Produto",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Saida",
                table: "Produto",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Valor",
                table: "Produto",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Entrada",
                table: "entradaProduto",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Saida",
                table: "entradaProduto",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Valor",
                table: "entradaProduto",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "tabelaCaixa",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    validade = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Categoria = table.Column<string>(type: "TEXT", nullable: false),
                    Entrada = table.Column<float>(type: "REAL", nullable: false),
                    Saida = table.Column<float>(type: "REAL", nullable: false),
                    Valor = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabelaCaixa", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "Entrada",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "Saida",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "Entrada",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Saida",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Entrada",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "Saida",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "entradaProduto");
        }
    }
}
