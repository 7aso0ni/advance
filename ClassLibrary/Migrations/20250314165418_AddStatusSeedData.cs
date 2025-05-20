using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Available_Status",
                columns: new[] { "ID", "Status" },
                values: new object[,]
                {
                    { 1, "Available" },
                    { 2, "Unavailable" },
                    { 3, "Under Maintenance" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Power Tools" },
                    { 2, "Cameras" },
                    { 3, "Construction" },
                    { 4, "Event Supplies" }
                });

            migrationBuilder.InsertData(
                table: "Condition_Status",
                columns: new[] { "ID", "Status" },
                values: new object[,]
                {
                    { 1, "New" },
                    { 2, "Good" },
                    { 3, "Damaged" },
                    { 4, "Refurbished" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Available_Status",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Available_Status",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Available_Status",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Condition_Status",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Condition_Status",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Condition_Status",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Condition_Status",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
