using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagemnet.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(6994), new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(7003), "Black", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(7005), new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(7005), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(7138), new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(7138), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(7140), new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(7140), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(7192), new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(7193), "I4", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(7194), new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(7195), "X5", "System" },
                    { 3, "System", new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(7196), new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(7197), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(7198), new DateTime(2025, 12, 3, 15, 16, 9, 738, DateTimeKind.Local).AddTicks(7198), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
