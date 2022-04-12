using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthBasicwithDB.Migrations
{
    public partial class Stock2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Beers_CategoriaId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_CategoriaId",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Stock");

            migrationBuilder.RenameColumn(
                name: "BeerID",
                table: "Stock",
                newName: "BeerId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_BeerId",
                table: "Stock",
                column: "BeerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Beers_BeerId",
                table: "Stock",
                column: "BeerId",
                principalTable: "Beers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Beers_BeerId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_BeerId",
                table: "Stock");

            migrationBuilder.RenameColumn(
                name: "BeerId",
                table: "Stock",
                newName: "BeerID");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Stock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stock_CategoriaId",
                table: "Stock",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Beers_CategoriaId",
                table: "Stock",
                column: "CategoriaId",
                principalTable: "Beers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
