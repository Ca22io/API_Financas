using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Financas.Migrations
{
    /// <inheritdoc />
    public partial class versao1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Valor = table.Column<decimal>(type: "TEXT", nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IdTipo = table.Column<int>(type: "INTEGER", nullable: false),
                    IdCategoria = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    IdCategoria = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categorias_Transacoes_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Transacoes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    IdTipo = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tipos_Transacoes_IdTipo",
                        column: x => x.IdTipo,
                        principalTable: "Transacoes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_IdCategoria",
                table: "Categorias",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Tipos_IdTipo",
                table: "Tipos",
                column: "IdTipo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Tipos");

            migrationBuilder.DropTable(
                name: "Transacoes");
        }
    }
}
