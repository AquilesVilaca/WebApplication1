using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class DiminuirModeloDominio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensDrink_Ingredientes_IngredientesIngredienteId",
                table: "ItensDrink");

            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropIndex(
                name: "IX_ItensDrink_IngredientesIngredienteId",
                table: "ItensDrink");

            migrationBuilder.DropColumn(
                name: "IngredientesIngredienteId",
                table: "ItensDrink");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "ItensDrink",
                newName: "QuantidadeEIngrediente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuantidadeEIngrediente",
                table: "ItensDrink",
                newName: "Quantidade");

            migrationBuilder.AddColumn<int>(
                name: "IngredientesIngredienteId",
                table: "ItensDrink",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    IngredienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.IngredienteId);
                });

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
    }
}
