using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class SeedDocumentTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Document_Type",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Rental Agreement" },
                    { 2, "Payment Receipt" },
                    { 3, "Return Report" },
                    { 4, "ID Proof" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Document_Type",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Document_Type",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Document_Type",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Document_Type",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
