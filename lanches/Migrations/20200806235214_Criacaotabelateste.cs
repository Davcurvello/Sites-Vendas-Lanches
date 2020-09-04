using Microsoft.EntityFrameworkCore.Migrations;

namespace lanches.Migrations
{
    public partial class Criacaotabelateste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhoCompraItems_Lanches_LancheId",
                table: "CarrinhoCompraItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Lanches_Categorias_CategoriaID",
                table: "Lanches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lanches",
                table: "Lanches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarrinhoCompraItems",
                table: "CarrinhoCompraItems");

            migrationBuilder.RenameTable(
                name: "Lanches",
                newName: "Lanche");

            migrationBuilder.RenameTable(
                name: "CarrinhoCompraItems",
                newName: "CarrinhoCompraItens");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "Lanche",
                newName: "Preco");

            migrationBuilder.RenameIndex(
                name: "IX_Lanches_CategoriaID",
                table: "Lanche",
                newName: "IX_Lanche_CategoriaID");

            migrationBuilder.RenameIndex(
                name: "IX_CarrinhoCompraItems_LancheId",
                table: "CarrinhoCompraItens",
                newName: "IX_CarrinhoCompraItens_LancheId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lanche",
                table: "Lanche",
                column: "LancheId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarrinhoCompraItens",
                table: "CarrinhoCompraItens",
                column: "CarrinhoCompraItemId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarrinhoCompraItens",
                table: "CarrinhoCompraItens");

            migrationBuilder.RenameTable(
                name: "Lanche",
                newName: "Lanches");

            migrationBuilder.RenameTable(
                name: "CarrinhoCompraItens",
                newName: "CarrinhoCompraItems");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Lanches",
                newName: "preco");

            migrationBuilder.RenameIndex(
                name: "IX_Lanche_CategoriaID",
                table: "Lanches",
                newName: "IX_Lanches_CategoriaID");

            migrationBuilder.RenameIndex(
                name: "IX_CarrinhoCompraItens_LancheId",
                table: "CarrinhoCompraItems",
                newName: "IX_CarrinhoCompraItems_LancheId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lanches",
                table: "Lanches",
                column: "LancheId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarrinhoCompraItems",
                table: "CarrinhoCompraItems",
                column: "CarrinhoCompraItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhoCompraItems_Lanches_LancheId",
                table: "CarrinhoCompraItems",
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
    }
}
