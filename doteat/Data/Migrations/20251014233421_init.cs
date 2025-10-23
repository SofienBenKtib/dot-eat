using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace doteat.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 1,
                column: "Name",
                value: "Beef");

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 2,
                column: "Name",
                value: "Chicken");

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 3,
                column: "Name",
                value: "Fish");

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 4,
                column: "Name",
                value: "Tortilla");

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 5,
                column: "Name",
                value: "Lettuce");

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 6,
                column: "Name",
                value: "Mushroom");

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 7,
                column: "Name",
                value: "Tomato");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 1,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 2,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 3,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 4,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 5,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 6,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 7,
                column: "Name",
                value: null);
        }
    }
}
