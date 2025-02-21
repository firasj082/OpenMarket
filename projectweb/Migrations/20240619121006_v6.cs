using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectweb.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Company",
                table: "products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 1,
                column: "Description",
                value: "Test");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 2,
                column: "Description",
                value: "Test");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 4,
                column: "Description",
                value: "Test");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 5,
                column: "Description",
                value: "Test");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 6,
                column: "Description",
                value: "Test");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 7,
                column: "Description",
                value: "Test");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "products");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Company",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
