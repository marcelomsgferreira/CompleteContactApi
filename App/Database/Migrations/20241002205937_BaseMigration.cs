using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Database.Migrations
{
    /// <inheritdoc />
    public partial class BaseMigration : Migration
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
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactsGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactsGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactAddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Addresses_ContactAddressId",
                        column: x => x.ContactAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactContactGroup",
                columns: table => new
                {
                    ContactGroupsId = table.Column<int>(type: "int", nullable: false),
                    ContactsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactContactGroup", x => new { x.ContactGroupsId, x.ContactsId });
                    table.ForeignKey(
                        name: "FK_ContactContactGroup_ContactsGroup_ContactGroupsId",
                        column: x => x.ContactGroupsId,
                        principalTable: "ContactsGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactContactGroup_Contacts_ContactsId",
                        column: x => x.ContactsId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressType", "City", "Country", "CreatedAt", "PostalCode", "State", "Street", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Home", "New York", "USA", new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(7879), "10001", "NY", "123 Main Street", null },
                    { 2, "Work", "Los Angeles", "USA", new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(7898), "90001", "CA", "456 Oak Avenue", null },
                    { 3, "Billing", "Chicago", "USA", new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(7901), "60601", "IL", "789 Pine Road", null }
                });

            migrationBuilder.InsertData(
                table: "ContactsGroup",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8083), "Family members and relatives", "Family", null },
                    { 2, new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8086), "Close and personal friends", "Friends", null },
                    { 3, new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8088), "Colleagues from work", "Work", null },
                    { 4, new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8090), "Business clients and partners", "Clients", null },
                    { 5, new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8092), "Suppliers and vendors for business", "Suppliers", null }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "ContactAddressId", "CreatedAt", "DateOfBirth", "Email", "FirstName", "LastName", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "123 Main Street, New York, NY", 1, new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8131), new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John", "Doe", "(123) 456-7890", null },
                    { 2, "456 Oak Avenue, Los Angeles, CA", 2, new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8134), new DateTime(1985, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "Jane", "Smith", "(234) 567-8901", null },
                    { 3, "789 Pine Road, Chicago, IL", 3, new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8137), new DateTime(1995, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael.brown@example.com", "Michael", "Brown", "(345) 678-9012", null },
                    { 4, "123 Oak Street, Houston, TX", 1, new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8141), new DateTime(1992, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.davis@example.com", "Emily", "Davis", "(456) 789-0123", null },
                    { 5, "456 Maple Avenue, Seattle, WA", 2, new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8144), new DateTime(1987, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.miller@example.com", "David", "Miller", "(567) 890-1234", null },
                    { 6, "789 Cedar Street, Miami, FL", 3, new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8146), new DateTime(1993, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarah.wilson@example.com", "Sarah", "Wilson", "(678) 901-2345", null },
                    { 7, "123 Birch Avenue, Dallas, TX", 1, new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8148), new DateTime(1989, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "christopher.moore@example.com", "Christopher", "Moore", "(789) 012-3456", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactContactGroup_ContactsId",
                table: "ContactContactGroup",
                column: "ContactsId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ContactAddressId",
                table: "Contacts",
                column: "ContactAddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactContactGroup");

            migrationBuilder.DropTable(
                name: "ContactsGroup");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
