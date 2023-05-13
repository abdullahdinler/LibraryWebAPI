using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library.Repository.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Addres = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Cover = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowedRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    BorrowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowedRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BorrowedRecords_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BorrowedRecords_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnedRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnedRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnedRecords_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnedRecords_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Addres" },
                values: new object[,]
                {
                    { 1, "Ev adresi 1" },
                    { 2, "Ev adresi 2" },
                    { 3, "Ev adresi 3" },
                    { 4, "Ev adresi 4" },
                    { 5, "Ev adresi 5" },
                    { 6, "Ev adresi 6" },
                    { 7, "Ev adresi 7" },
                    { 8, "Ev adresi 8" },
                    { 9, "Ev adresi 9" },
                    { 10, "Ev adresi 10" },
                    { 11, "Ev adresi 11" },
                    { 12, "Ev adresi 12" },
                    { 13, "Ev adresi 13" },
                    { 14, "Ev adresi 14" },
                    { 15, "Ev adresi 15" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Author 1", "Author LastName 1" },
                    { 2, "Author 2", "Author LastName 2" },
                    { 3, "Author 3", "Author LastName 3" },
                    { 4, "Author 4", "Author LastName 4" },
                    { 5, "Author 5", "Author LastName 5" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Genre 1" },
                    { 2, "Genre 2" },
                    { 3, "Genre 3" },
                    { 4, "Genre 4" },
                    { 5, "Genre 5" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Cover", "DateAdded", "GenreId", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Cover 1", new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1219), 1, "Status 1", "Book 1" },
                    { 2, 2, "Cover 2", new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1237), 2, "Status 2", "Book 2" },
                    { 3, 3, "Cover 3", new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1239), 3, "Status 3", "Book 3" },
                    { 4, 4, "Cover 4", new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1241), 4, "Status 4", "Book 4" },
                    { 5, 5, "Cover 5", new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1243), 5, "Status 5", "Book 5" },
                    { 6, 1, "Cover 6", new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1245), 1, "Status 6", "Book 6" },
                    { 7, 2, "Cover 7", new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1246), 2, "Status 7", "Book 7" },
                    { 8, 3, "Cover 8", new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1248), 3, "Status 8", "Book 8" },
                    { 9, 4, "Cover 9", new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1250), 4, "Status 9", "Book 9" },
                    { 10, 5, "Cover 10", new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1252), 5, "Status 10", "Book 10" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddressId", "Email", "FirstName", "LastName", "Phone", "Status" },
                values: new object[,]
                {
                    { 1, 1, "mail1@mail.com", "User 1", "User LastName 1", "11111111111", "Status 1" },
                    { 2, 2, "mail2@mail.com", "User 2", "User LastName 2", "22222222222", "Status 2" },
                    { 3, 3, "mail3@mail.com", "User 3", "User LastName 3", "33333333333", "Status 3" },
                    { 4, 4, "mail4@mail.com", "User 4", "User LastName 4", "44444444444", "Status 4" },
                    { 5, 5, "mail5@mail.com", "User 5", "User LastName 5", "55555555555", "Status 5" }
                });

            migrationBuilder.InsertData(
                table: "BorrowedRecords",
                columns: new[] { "Id", "BookId", "BorrowDate", "ReturnDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1568), new DateTime(2023, 5, 28, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1573), "Status 1", 1 },
                    { 2, 2, new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1582), new DateTime(2023, 5, 28, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1583), "Status 2", 2 },
                    { 3, 3, new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1585), new DateTime(2023, 5, 28, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1585), "Status 3", 3 },
                    { 4, 4, new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1587), new DateTime(2023, 5, 28, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1588), "Status 4", 4 },
                    { 5, 5, new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1589), new DateTime(2023, 5, 28, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(1590), "Status 5", 5 }
                });

            migrationBuilder.InsertData(
                table: "ReturnedRecords",
                columns: new[] { "Id", "BookId", "ReturnDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(2270), "Status 1", 1 },
                    { 2, 2, new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(2277), "Status 2", 2 },
                    { 3, 3, new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(2279), "Status 3", 3 },
                    { 4, 4, new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(2281), "Status 4", 4 },
                    { 5, 5, new DateTime(2023, 5, 13, 17, 6, 23, 431, DateTimeKind.Local).AddTicks(2283), "Status 5", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedRecords_BookId",
                table: "BorrowedRecords",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedRecords_UserId",
                table: "BorrowedRecords",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnedRecords_BookId",
                table: "ReturnedRecords",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnedRecords_UserId",
                table: "ReturnedRecords",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressId",
                table: "Users",
                column: "AddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowedRecords");

            migrationBuilder.DropTable(
                name: "ReturnedRecords");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
