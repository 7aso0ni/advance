using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class TransactionFKToRentalRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RentalTransactionId",
                table: "Rental_Request",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rental_Request_RentalTransactionId",
                table: "Rental_Request",
                column: "RentalTransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rental_Request_Rental_Transaction",
                table: "Rental_Request",
                column: "RentalTransactionId",
                principalTable: "Rental_Transaction",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rental_Request_Rental_Transaction",
                table: "Rental_Request");

            migrationBuilder.DropIndex(
                name: "IX_Rental_Request_RentalTransactionId",
                table: "Rental_Request");

            migrationBuilder.DropColumn(
                name: "RentalTransactionId",
                table: "Rental_Request");
        }
    }
}
