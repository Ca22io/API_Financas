using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Financas.Migrations
{
    /// <inheritdoc />
    public partial class versao2 : Migration
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipos",
                table: "Tipos");

            migrationBuilder.DropIndex(
                name: "IX_Tipos_IdTipo",
                table: "Tipos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_IdCategoria",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Tipos");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Categorias");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Transacoes",
                newName: "IdTransacao");

            migrationBuilder.AlterColumn<int>(
                name: "IdTipo",
                table: "Tipos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdCategoria",
                table: "Categorias",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipos",
                table: "Tipos",
                column: "IdTipo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "IdCategoria");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Transacoes_IdCategoria",
                table: "Categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipos_Transacoes_IdTipo",
                table: "Tipos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipos",
                table: "Tipos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.RenameColumn(
                name: "IdTransacao",
                table: "Transacoes",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "IdTipo",
                table: "Tipos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Tipos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "IdCategoria",
                table: "Categorias",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Categorias",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipos",
                table: "Tipos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tipos_IdTipo",
                table: "Tipos",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_IdCategoria",
                table: "Categorias",
                column: "IdCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Transacoes_IdCategoria",
                table: "Categorias",
                column: "IdCategoria",
                principalTable: "Transacoes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipos_Transacoes_IdTipo",
                table: "Tipos",
                column: "IdTipo",
                principalTable: "Transacoes",
                principalColumn: "Id");
        }
    }
}
