using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Financas.Migrations
{
    /// <inheritdoc />
    public partial class version4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Transacoes_IdCategoria",
                table: "Categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipos_Transacoes_IdTipo",
                table: "Tipos");

            migrationBuilder.AlterColumn<int>(
                name: "IdTipo",
                table: "Tipos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "IdCategoria",
                table: "Categorias",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_IdCategoria",
                table: "Transacoes",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_IdTipo",
                table: "Transacoes",
                column: "IdTipo");

            migrationBuilder.AddForeignKey(
                name: "FK_Transacoes_Categorias_IdCategoria",
                table: "Transacoes",
                column: "IdCategoria",
                principalTable: "Categorias",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transacoes_Tipos_IdTipo",
                table: "Transacoes",
                column: "IdTipo",
                principalTable: "Tipos",
                principalColumn: "IdTipo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacoes_Categorias_IdCategoria",
                table: "Transacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Transacoes_Tipos_IdTipo",
                table: "Transacoes");

            migrationBuilder.DropIndex(
                name: "IX_Transacoes_IdCategoria",
                table: "Transacoes");

            migrationBuilder.DropIndex(
                name: "IX_Transacoes_IdTipo",
                table: "Transacoes");

            migrationBuilder.AlterColumn<int>(
                name: "IdTipo",
                table: "Tipos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "IdCategoria",
                table: "Categorias",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Transacoes_IdCategoria",
                table: "Categorias",
                column: "IdCategoria",
                principalTable: "Transacoes",
                principalColumn: "IdTransacao",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tipos_Transacoes_IdTipo",
                table: "Tipos",
                column: "IdTipo",
                principalTable: "Transacoes",
                principalColumn: "IdTransacao",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
