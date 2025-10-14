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
                column: "IngredientName",
                value: "Beef");

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 2,
                column: "IngredientName",
                value: "Chicken");

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 3,
                column: "IngredientName",
                value: "Fish");

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 4,
                column: "IngredientName",
                value: "Tortilla");

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 5,
                column: "IngredientName",
                value: "Lettuce");

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 6,
                column: "IngredientName",
                value: "Mushroom");

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 7,
                column: "IngredientName",
                value: "Tomato");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 1,
                column: "IngredientName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 2,
                column: "IngredientName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 3,
                column: "IngredientName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 4,
                column: "IngredientName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 5,
                column: "IngredientName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 6,
                column: "IngredientName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 7,
                column: "IngredientName",
                value: null);
        }
    }
}
