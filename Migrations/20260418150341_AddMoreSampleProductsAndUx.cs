using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsStore.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSampleProductsAndUx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 13, "Shoes", "Non-marking outsole shoes for indoor court speed and control.", "https://images.unsplash.com/photo-1551107696-a4b0c5a0d9a2?auto=format&fit=crop&w=900&q=80", "Velocity Indoor Futsal Shoes", 3199m, 22 },
                    { 14, "Jerseys", "Quick-dry training jersey with lightweight mesh panels.", "https://images.unsplash.com/photo-1562771242-a02d9090c90c?auto=format&fit=crop&w=900&q=80", "Elite Training Jersey", 1999m, 44 },
                    { 15, "Accessories", "Comfort-fit knee pads for volleyball and basketball sessions.", "https://images.unsplash.com/photo-1597074866923-dc0589150358?auto=format&fit=crop&w=900&q=80", "All-Court Knee Pads", 799m, 58 },
                    { 16, "Equipment", "Durable footwork ladder for team drills and conditioning.", "https://images.unsplash.com/photo-1517963628607-235ccdd5476b?auto=format&fit=crop&w=900&q=80", "Agility Speed Ladder", 1099m, 38 },
                    { 17, "Accessories", "Curved-brim sports cap with breathable fabric.", "https://images.unsplash.com/photo-1588850561407-ed78c282e89b?auto=format&fit=crop&w=900&q=80", "Stadium Cap", 649m, 64 },
                    { 18, "Shoes", "Stable sole shoes designed for gym and strength training.", "https://images.unsplash.com/photo-1600185365926-3a2ce3cdb9eb?auto=format&fit=crop&w=900&q=80", "PowerLift Training Shoes", 3899m, 19 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
