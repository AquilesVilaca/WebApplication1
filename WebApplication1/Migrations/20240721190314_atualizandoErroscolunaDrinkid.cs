using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class atualizandoErroscolunaDrinkid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DrinkId",
                table: "ItensDrink");

            migrationBuilder.DropColumn(
                name: "DrinkId",
                table: "DrinksPreparoEImagem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DrinkId",
                table: "ItensDrink",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DrinkId",
                table: "DrinksPreparoEImagem",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
