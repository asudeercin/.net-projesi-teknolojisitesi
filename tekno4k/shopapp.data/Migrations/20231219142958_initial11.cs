using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shopapp.data.Migrations
{
    public partial class initial11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Name", "Price", "Url" },
                values: new object[] { "4.jpg", "Samsung galaxy", 4000.0, "Samsung galaxy" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "IsApproved", "IsHome", "Name", "Price", "Url" },
                values: new object[] { 6, "çok iyi telefon", "3.jpg", true, false, "iphone x", 4000.0, "iphone x" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "IsApproved", "IsHome", "Name", "Price", "Url" },
                values: new object[] { 7, "iyi bilgisayar", "asus.jpg", true, false, "asus1", 4000.0, "asus1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "IsApproved", "IsHome", "Name", "Price", "Url" },
                values: new object[] { 9, "iyi telefon", "lenovo.jpg", true, false, "lenovo legion", 4000.0, "lenovo legion" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name", "Url" },
                values: new object[] { 4, "Beyaz Eşya", "beyaz-esya" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Name", "Price", "Url" },
                values: new object[] { "5.jpg", "Samsung S9", 6000.0, "samsung-s9" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "DateAdded", "Description", "ImageUrl", "IsApproved", "IsHome", "Name", "Price", "Url" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iyi telefon", "4.jpg", false, false, "Samsung S8", 5000.0, "samsung-s8" });
        }
    }
}
