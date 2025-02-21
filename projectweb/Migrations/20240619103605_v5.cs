using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectweb.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 1,
                column: "Price",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 2,
                column: "Price",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 3,
                column: "Price",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 4,
                column: "Price",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 5,
                column: "Price",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 6,
                column: "Price",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 7,
                column: "Price",
                value: 100.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 1,
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 2,
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 3,
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 4,
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 5,
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 6,
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 7,
                column: "Price",
                value: 0.0);
        }
    }
}
