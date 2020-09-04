using Microsoft.EntityFrameworkCore.Migrations;

namespace lanches.Migrations
{
    public partial class removertabelateste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhoCompraItens_Lanche_LancheId",
                table: "CarrinhoCompraItens");

            migrationBuilder.DropForeignKey(
                name: "FK_Lanche_Categorias_CategoriaID",
                table: "Lanche");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lanche",
                table: "Lanche");

            migrationBuilder.RenameTable(
                name: "Lanche",
                newName: "Lanches");

            migrationBuilder.RenameIndex(
                name: "IX_Lanche_CategoriaID",
                table: "Lanches",
                newName: "IX_Lanches_CategoriaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lanches",
                table: "Lanches",
                column: "LancheId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhoCompraItens_Lanches_LancheId",
                table: "CarrinhoCompraItens",
                column: "LancheId",
                principalTable: "Lanches",
                principalColumn: "LancheId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lanches_Categorias_CategoriaID",
                table: "Lanches",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhoCompraItens_Lanches_LancheId",
                table: "CarrinhoCompraItens");

            migrationBuilder.DropForeignKey(
                name: "FK_Lanches_Categorias_CategoriaID",
                table: "Lanches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lanches",
                table: "Lanches");

            migrationBuilder.RenameTable(
                name: "Lanches",
                newName: "Lanche");

            migrationBuilder.RenameIndex(
                name: "IX_Lanches_CategoriaID",
                table: "Lanche",
                newName: "IX_Lanche_CategoriaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lanche",
                table: "Lanche",
                column: "LancheId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhoCompraItens_Lanche_LancheId",
                table: "CarrinhoCompraItens",
                column: "LancheId",
                principalTable: "Lanche",
                principalColumn: "LancheId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lanche_Categorias_CategoriaID",
                table: "Lanche",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
