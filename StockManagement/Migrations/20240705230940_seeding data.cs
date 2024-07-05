using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StockManagement.Migrations
{
    /// <inheritdoc />
    public partial class seedingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { -10, "Huawei P40 Pro with 256GB storage", "Huawei P40 Pro", 899 },
                    { -9, "Asus ROG Phone 5 with 256GB storage", "Asus ROG Phone 5", 999 },
                    { -8, "Nokia 8.3 5G with 128GB storage", "Nokia 8.3 5G", 699 },
                    { -7, "Oppo Find X3 Pro with 256GB storage", "Oppo Find X3 Pro", 1149 },
                    { -6, "Xiaomi Mi 11 with 128GB storage", "Xiaomi Mi 11", 749 },
                    { -5, "Sony Xperia 5 II with 128GB storage", "Sony Xperia 5 II", 949 },
                    { -4, "OnePlus 9 with 128GB storage", "OnePlus 9", 729 },
                    { -3, "Google Pixel 6 with 128GB storage", "Google Pixel 6", 599 },
                    { -2, "Samsung Galaxy S21 with 128GB storage", "Samsung Galaxy S21", 799 },
                    { -1, "Apple iPhone 13 with 128GB storage", "iPhone 13", 999 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { -10, "707 Digital Street", "Digital Market" },
                    { -9, "606 Gizmo Place", "Gizmo Place" },
                    { -8, "505 Techie Circle", "Techie Corner" },
                    { -7, "404 Smartphone Way", "Smartphone Shop" },
                    { -6, "303 Device Drive", "Device Depot" },
                    { -5, "202 Electro Boulevard", "Electro Store" },
                    { -4, "101 Mobile Lane", "Mobile Center" },
                    { -3, "789 Phone Road", "Phone Plaza" },
                    { -2, "456 Gadget Avenue", "Gadget Hub" },
                    { -1, "123 Tech Street", "Tech World" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
