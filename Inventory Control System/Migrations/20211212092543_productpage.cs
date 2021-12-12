using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory_Control_System.Migrations
{
    public partial class productpage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    ProductPrice = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDetails");
        }
    }
}
