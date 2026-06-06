using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetMatcher.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedPetsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Breed", "Color", "IsVaccinated", "Name", "Personality", "Species", "WeightInLbs" },
                values: new object[,]
                {
                    { 1, 3, "Golden Retriever", "Golden", true, "Max", "Friendly, energetic, and highly social", "Dog", 65.400000000000006 },
                    { 2, 2, "Siamese", "Seal Point", true, "Luna", "Vocal, affectionate, and demanding of attention", "Cat", 8.5 },
                    { 3, 1, "French Bulldog", "Brindle", true, "Charlie", "Playful couch potato, loves naps and treats", "Dog", 22.100000000000001 },
                    { 4, 5, "Labrador Retriever", "Black", true, "Bella", "Loyal, gentle, and excellent swimmers", "Dog", 72.0 },
                    { 5, 4, "Domestic Shorthair", "Tabby", true, "Oliver", "Calm, independent, but loves a good chin scratch", "Cat", 11.199999999999999 },
                    { 6, 1, "Bengal", "Spotted Rosette", false, "Milo", "High energy, highly intelligent, and loves water", "Cat", 10.6 },
                    { 7, 2, "Beagle", "Tricolor", true, "Daisy", "Curious, driven by scent, and very vocal", "Dog", 24.5 },
                    { 8, 4, "German Shepherd", "Black and Tan", true, "Rocky", "Protective, disciplined, and quick to learn", "Dog", 83.099999999999994 },
                    { 9, 7, "Persian", "White", true, "Cleo", "Quiet, dignified, and prefers a peaceful home", "Cat", 9.0 },
                    { 10, 6, "Chihuahua", "Fawn", true, "Coco", "Feisty, fiercely loyal to one person, alert", "Dog", 5.2999999999999998 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
