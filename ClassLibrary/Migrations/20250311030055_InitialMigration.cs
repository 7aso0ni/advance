using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Available_Status",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Available_Status", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Condition_Status",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condition_Status", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Document_Type",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_Type", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Equipment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Notification_Type",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification_Type", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Payment_Status",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_Status", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product_Status",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Available_ID = table.Column<int>(type: "int", nullable: false),
                    Condition_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Status", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rental_Status",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental_Status", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User_Role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Available_ID = table.Column<int>(type: "int", nullable: false),
                    Condition_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Equipment_Available_Status",
                        column: x => x.Available_ID,
                        principalTable: "Available_Status",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Equipment_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Equipment_Condition_Status",
                        column: x => x.Condition_ID,
                        principalTable: "Condition_Status",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Lname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_User_Role",
                        column: x => x.RoleID,
                        principalTable: "User_Role",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Rental_Request",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipment_ID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    RentalStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental_Request", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rental_Request_Equipment",
                        column: x => x.Equipment_ID,
                        principalTable: "Equipment",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Rental_Request_Product_Status",
                        column: x => x.RentalStatus,
                        principalTable: "Product_Status",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Rental_Request_Rental_Status",
                        column: x => x.RentalStatus,
                        principalTable: "Rental_Status",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Return_Record",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipment = table.Column<int>(type: "int", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Condition = table.Column<int>(type: "int", nullable: false),
                    LateFees = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Return_Record", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Return_Record_Condition_Status",
                        column: x => x.Condition,
                        principalTable: "Condition_Status",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Return_Record_Equipment",
                        column: x => x.Equipment,
                        principalTable: "Equipment",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    UploadeDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    FileType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    StoragePath = table.Column<byte[]>(type: "varbinary(50)", maxLength: 50, nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Document_Document_Type",
                        column: x => x.DocumentType,
                        principalTable: "Document_Type",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Document_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FeedBack",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Equipment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table2", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FeedBack_Equipment",
                        column: x => x.Equipment,
                        principalTable: "Equipment",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FeedBack_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Action = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    AffectedData = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Source = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Log_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Message = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NotificationTypeID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Notification_Notification_Type",
                        column: x => x.NotificationTypeID,
                        principalTable: "Notification_Type",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Notification_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Rental_Transaction",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentalStatus = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Pickup = table.Column<DateTime>(type: "datetime", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Period = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Deposit = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental_Transaction", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rental_Transaction_Payment_Status",
                        column: x => x.PaymentStatus,
                        principalTable: "Payment_Status",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Rental_Transaction_Rental_Status",
                        column: x => x.RentalStatus,
                        principalTable: "Rental_Status",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Rental_Transaction_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "User_Role",
                columns: new[] { "ID", "Role" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" },
                    { 3, "Customer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_DocumentType",
                table: "Document",
                column: "DocumentType");

            migrationBuilder.CreateIndex(
                name: "IX_Document_UserID",
                table: "Document",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_Available_ID",
                table: "Equipment",
                column: "Available_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_CategoryID",
                table: "Equipment",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_Condition_ID",
                table: "Equipment",
                column: "Condition_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBack_Equipment",
                table: "FeedBack",
                column: "Equipment");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBack_UserID",
                table: "FeedBack",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Log_UserID",
                table: "Log",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_NotificationTypeID",
                table: "Notification",
                column: "NotificationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_UserID",
                table: "Notification",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_Request_Equipment_ID",
                table: "Rental_Request",
                column: "Equipment_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_Request_RentalStatus",
                table: "Rental_Request",
                column: "RentalStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_Transaction_PaymentStatus",
                table: "Rental_Transaction",
                column: "PaymentStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_Transaction_RentalStatus",
                table: "Rental_Transaction",
                column: "RentalStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_Transaction_UserID",
                table: "Rental_Transaction",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Return_Record_Condition",
                table: "Return_Record",
                column: "Condition");

            migrationBuilder.CreateIndex(
                name: "IX_Return_Record_Equipment",
                table: "Return_Record",
                column: "Equipment");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleID",
                table: "User",
                column: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "FeedBack");

            migrationBuilder.DropTable(
                name: "FeedBacks");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "Rental_Request");

            migrationBuilder.DropTable(
                name: "Rental_Transaction");

            migrationBuilder.DropTable(
                name: "Return_Record");

            migrationBuilder.DropTable(
                name: "Document_Type");

            migrationBuilder.DropTable(
                name: "Notification_Type");

            migrationBuilder.DropTable(
                name: "Product_Status");

            migrationBuilder.DropTable(
                name: "Payment_Status");

            migrationBuilder.DropTable(
                name: "Rental_Status");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "User_Role");

            migrationBuilder.DropTable(
                name: "Available_Status");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Condition_Status");
        }
    }
}
