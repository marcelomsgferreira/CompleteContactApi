using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Database.Migrations
{
    /// <inheritdoc />
    public partial class CorrectNameMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Addresses_ContactAddressId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "ContactContactGroup");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "ContactAddressId",
                table: "Contacts",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_ContactAddressId",
                table: "Contacts",
                newName: "IX_Contacts_AddressId");

            migrationBuilder.CreateTable(
                name: "ContactGroup",
                columns: table => new
                {
                    ContactsId = table.Column<int>(type: "int", nullable: false),
                    GroupsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactGroup", x => new { x.ContactsId, x.GroupsId });
                    table.ForeignKey(
                        name: "FK_ContactGroup_ContactsGroup_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "ContactsGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactGroup_Contacts_ContactsId",
                        column: x => x.ContactsId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "ContactsGroup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "ContactsGroup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "ContactsGroup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "ContactsGroup",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "ContactsGroup",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.CreateIndex(
                name: "IX_ContactGroup_GroupsId",
                table: "ContactGroup",
                column: "GroupsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Addresses_AddressId",
                table: "Contacts",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Addresses_AddressId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "ContactGroup");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Contacts",
                newName: "ContactAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_AddressId",
                table: "Contacts",
                newName: "IX_Contacts_ContactAddressId");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Contacts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "CreatedAt" },
                values: new object[] { "123 Main Street, New York, NY", new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "CreatedAt" },
                values: new object[] { "456 Oak Avenue, Los Angeles, CA", new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "CreatedAt" },
                values: new object[] { "789 Pine Road, Chicago, IL", new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "CreatedAt" },
                values: new object[] { "123 Oak Street, Houston, TX", new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "CreatedAt" },
                values: new object[] { "456 Maple Avenue, Seattle, WA", new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "CreatedAt" },
                values: new object[] { "789 Cedar Street, Miami, FL", new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "CreatedAt" },
                values: new object[] { "123 Birch Avenue, Dallas, TX", new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "ContactsGroup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "ContactsGroup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "ContactsGroup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "ContactsGroup",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "ContactsGroup",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 17, 59, 34, 264, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.CreateIndex(
                name: "IX_ContactContactGroup_ContactsId",
                table: "ContactContactGroup",
                column: "ContactsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Addresses_ContactAddressId",
                table: "Contacts",
                column: "ContactAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
