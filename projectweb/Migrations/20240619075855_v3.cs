using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectweb.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "users",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "ccnum",
                table: "users",
                newName: "Ccnum");

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 1,
                columns: new[] { "Company", "Location" },
                values: new object[] { "AhmadTechnology", "China" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 2,
                columns: new[] { "Company", "Location" },
                values: new object[] { "AhmadTechnology", "China" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 3,
                columns: new[] { "Company", "Location" },
                values: new object[] { "AhmadTechnology", "China" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 4,
                columns: new[] { "Company", "Location" },
                values: new object[] { "AhmadTechnology", "China" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 5,
                columns: new[] { "Company", "Location" },
                values: new object[] { "AhmadTechnology", "China" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 6,
                columns: new[] { "Company", "Location" },
                values: new object[] { "AhmadTechnology", "China" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productid",
                keyValue: 7,
                columns: new[] { "Company", "Location" },
                values: new object[] { "AhmadTechnology", "China" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "userid",
                keyValue: 1,
                column: "Password",
                value: "11");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Company",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "users",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "users",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Ccnum",
                table: "users",
                newName: "ccnum");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "userid",
                keyValue: 1,
                column: "password",
                value: "123456789123456789");
        }
    }
}
