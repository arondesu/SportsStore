using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsStore.Migrations
{
    /// <inheritdoc />
    public partial class RefreshCatalogAndThemeCopy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Featherlight road-running shoes with breathable mesh, responsive foam, and durable outsole grip for daily mileage.", 3799m, 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "High-cut basketball shoes with ankle lockdown, multi-court traction pattern, and impact-absorbing heel cushioning.", 4499m, 21 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Official-inspired football jersey using moisture-wicking fabric and breathable side panels for hot-weather play.", 2299m, 46 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Game-ready basketball jersey with lightweight knit texture, quick-dry comfort, and all-day relaxed fit.", 2599m, 34 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "FIFA-size style 5 football with machine-stitched panels, stable flight, and reinforced bladder for longer use.", 1399m, 55 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "All-surface basketball featuring deep channel grip, balanced bounce, and premium composite cover.", 1599m, 48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Set of 20 flexible training cones with carry rack for speed drills, footwork stations, and team practice sessions.", 949m, 62 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Large-capacity duffel with ventilated shoe compartment, padded shoulder strap, and water-resistant base panel.", 1999m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Double-wall insulated bottle that keeps drinks cool for training sessions, commutes, and weekend games.", 749m, 84 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Pair of stretch-fit wrist sweatbands with soft absorbent cotton blend for court, gym, and running workouts.", 449m, 95 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Goalkeeper gloves with latex palm grip, finger support zones, and secure wrist wrap for confident saves.", 1299m, 37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Adjustable speed rope with anti-slip handles and smooth bearings for HIIT, cardio intervals, and endurance sessions.", 599m, 76 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Indoor futsal shoes with non-marking outsole, close-touch upper, and quick-cut support for fast small-sided games.", 3399m, 24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Quick-dry training jersey with airflow mesh zones and lightweight stretch fit for gym circuits and team drills.", 2099m, 49 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Shock-absorbing knee pads with ergonomic contour and breathable knit for volleyball and basketball protection.", 849m, 61 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Durable 6-meter speed ladder with adjustable rungs for footwork, acceleration, and conditioning routines.", 1149m, 41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Curved-brim sports cap with sweatband lining, ventilated eyelets, and adjustable back strap for daily wear.", 699m, 68 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Stable low-drop training shoes with reinforced heel clip and grippy outsole for lifting and strength sessions.", 4099m, 23 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Lightweight running shoes for daily training.", 3599m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "High-grip shoes built for quick direction changes.", 4299m, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Breathable football jersey with moisture control.", 2199m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Comfort-fit basketball jersey for practice and games.", 2499m, 32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Durable size 5 football for school and club matches.", 1299m, 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Indoor and outdoor basketball with textured grip.", 1499m, 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Set of 20 cones for agility and speed drills.", 899m, 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Spacious bag with shoe compartment.", 1899m, 27 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Keeps drinks cool during long workouts.", 699m, 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Soft and absorbent sweatbands for training.", 399m, 90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Goalkeeper gloves with padded palm and strong wrist support.", 1199m, 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Adjustable speed jump rope for cardio and endurance workouts.", 549m, 70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Non-marking outsole shoes for indoor court speed and control.", 3199m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Quick-dry training jersey with lightweight mesh panels.", 1999m, 44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Comfort-fit knee pads for volleyball and basketball sessions.", 799m, 58 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Durable footwork ladder for team drills and conditioning.", 1099m, 38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Curved-brim sports cap with breathable fabric.", 649m, 64 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Stable sole shoes designed for gym and strength training.", 3899m, 19 });
        }
    }
}
