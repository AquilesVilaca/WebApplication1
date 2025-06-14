using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class AjusteChavesExtrangeiras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredientes_ItensDrink_ItemDrinkId",
                table: "Ingredientes");

            migrationBuilder.DropIndex(
                name: "IX_Ingredientes_ItemDrinkId",
                table: "Ingredientes");

            migrationBuilder.DropColumn(
                name: "ItemDrinkId",
                table: "Ingredientes");

            migrationBuilder.AddColumn<int>(
                name: "IngredientesIngredienteId",
                table: "ItensDrink",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ItensDrink_IngredientesIngredienteId",
                table: "ItensDrink",
                column: "IngredientesIngredienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensDrink_Ingredientes_IngredientesIngredienteId",
                table: "ItensDrink",
                column: "IngredientesIngredienteId",
                principalTable: "Ingredientes",
                principalColumn: "IngredienteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensDrink_Ingredientes_IngredientesIngredienteId",
                table: "ItensDrink");

            migrationBuilder.DropIndex(
                name: "IX_ItensDrink_IngredientesIngredienteId",
                table: "ItensDrink");

            migrationBuilder.DropColumn(
                name: "IngredientesIngredienteId",
                table: "ItensDrink");

            migrationBuilder.AddColumn<int>(
                name: "ItemDrinkId",
                table: "Ingredientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_ItemDrinkId",
                table: "Ingredientes",
                column: "ItemDrinkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredientes_ItensDrink_ItemDrinkId",
                table: "Ingredientes",
                column: "ItemDrinkId",
                principalTable: "ItensDrink",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
