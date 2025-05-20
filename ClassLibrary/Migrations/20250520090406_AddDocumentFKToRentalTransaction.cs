using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddDocumentFKToRentalTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocumentId",
                table: "Rental_Transaction",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rental_Transaction_DocumentId",
                table: "Rental_Transaction",
                column: "DocumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rental_Transaction_Document",
                table: "Rental_Transaction",
                column: "DocumentId",
                principalTable: "Document",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rental_Transaction_Document",
                table: "Rental_Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Rental_Transaction_DocumentId",
                table: "Rental_Transaction");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "Rental_Transaction");
        }
    }
}
