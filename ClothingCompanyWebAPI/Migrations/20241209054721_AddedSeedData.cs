using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClothingCompanyWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "CustomerAddress", "CustomerBirthDate", "CustomerCity", "CustomerEmail", "CustomerFirstName", "CustomerLastName", "CustomerPhoneNumber", "CustomerState", "CustomerZipCode" },
                values: new object[,]
                {
                    { 1, "23 Jk Hwy", new DateTime(2024, 12, 8, 21, 47, 20, 970, DateTimeKind.Local).AddTicks(4649), "Chehalis", "jps@gmail.com", "Jean Paul", "Sidi", "123 456 7890", "WA", "12345" },
                    { 2, "45 K Street", new DateTime(2024, 12, 8, 21, 47, 20, 970, DateTimeKind.Local).AddTicks(4696), "Centralia", "kerly@gmail.com", "Kerly", "Image", "360 444 2345", "OR", "00345" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "CustomerId", "OrderAmount", "OrderDate" },
                values: new object[,]
                {
                    { 1, 0, 125m, new DateTime(2024, 12, 8, 21, 47, 20, 970, DateTimeKind.Local).AddTicks(4835) },
                    { 2, 0, 68m, new DateTime(2024, 12, 8, 21, 47, 20, 970, DateTimeKind.Local).AddTicks(4838) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, "Nice men shirt...", "Shirt", 20m },
                    { 2, "Nice women winter coat...", "Coat", 65m },
                    { 3, "Nice Trousers for men...", "Trousers", 34m }
                });

            migrationBuilder.InsertData(
                table: "OrderProduct",
                columns: new[] { "OrderProductId", "OrderId", "ProductId", "QuantityProductOrdered" },
                values: new object[,]
                {
                    { 1, 1, 1, 3 },
                    { 2, 2, 3, 2 },
                    { 3, 1, 2, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumn: "OrderProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumn: "OrderProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumn: "OrderProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3);
        }
    }
}
