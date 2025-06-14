using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class CriacaoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrinksPreparoEImagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDoDrink = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UrlImagem = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DescricaoPreparo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrinkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinksPreparoEImagem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItensDrink",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DrinkId = table.Column<int>(type: "int", nullable: false),
                    DrinkPreparoEImagemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensDrink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensDrink_DrinksPreparoEImagem_DrinkPreparoEImagemId",
                        column: x => x.DrinkPreparoEImagemId,
                        principalTable: "DrinksPreparoEImagem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    IngredienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemDrinkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.IngredienteId);
                    table.ForeignKey(
                        name: "FK_Ingredientes_ItensDrink_ItemDrinkId",
                        column: x => x.ItemDrinkId,
                        principalTable: "ItensDrink",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_ItemDrinkId",
                table: "Ingredientes",
                column: "ItemDrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensDrink_DrinkPreparoEImagemId",
                table: "ItensDrink",
                column: "DrinkPreparoEImagemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "ItensDrink");

            migrationBuilder.DropTable(
                name: "DrinksPreparoEImagem");
        }
    }
}
