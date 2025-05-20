using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class linkUserToRentals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Rental_Request",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rental_Request_UserId",
                table: "Rental_Request",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rental_Request_User_UserId",
                table: "Rental_Request",
                column: "UserId",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rental_Request_User_UserId",
                table: "Rental_Request");

            migrationBuilder.DropIndex(
                name: "IX_Rental_Request_UserId",
                table: "Rental_Request");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Rental_Request");
        }
    }
}
