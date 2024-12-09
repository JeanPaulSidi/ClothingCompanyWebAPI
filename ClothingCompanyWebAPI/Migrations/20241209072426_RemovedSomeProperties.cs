using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothingCompanyWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class RemovedSomeProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderAmount",
                table: "Order",
                newName: "OrderTotalAmount");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "CustomerBirthDate",
                value: new DateTime(2024, 12, 8, 23, 24, 25, 889, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "CustomerBirthDate",
                value: new DateTime(2024, 12, 8, 23, 24, 25, 889, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 12, 8, 23, 24, 25, 889, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 12, 8, 23, 24, 25, 889, DateTimeKind.Local).AddTicks(400));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderTotalAmount",
                table: "Order",
                newName: "OrderAmount");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "CustomerBirthDate",
                value: new DateTime(2024, 12, 8, 21, 47, 20, 970, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "CustomerBirthDate",
                value: new DateTime(2024, 12, 8, 21, 47, 20, 970, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 12, 8, 21, 47, 20, 970, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 12, 8, 21, 47, 20, 970, DateTimeKind.Local).AddTicks(4838));
        }
    }
}
