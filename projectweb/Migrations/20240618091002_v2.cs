using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectweb.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.productid);
                    table.ForeignKey(
                        name: "FK_products_users_userid",
                        column: x => x.userid,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "productid", "productname", "userid" },
                values: new object[,]
                {
                    { 1, "car bm2", 1 },
                    { 2, "Comedy", 1 },
                    { 3, "Drama", 1 },
                    { 4, "Horror", 1 },
                    { 5, "Musical", 1 },
                    { 6, "RomCom", 1 },
                    { 7, "SciFi", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_userid",
                table: "products",
                column: "userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
