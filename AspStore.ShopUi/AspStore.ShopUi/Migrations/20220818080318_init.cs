using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspStore.ShopUi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tbl_Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 1, "Mobile", "آخرین محصول اپل", "Apple Iphone 13", 25000000m });

            migrationBuilder.InsertData(
                table: "Tbl_Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 2, "Mobile", "آخرین محصول سونی", "Sony Xperia xz", 15000000m });

            migrationBuilder.InsertData(
                table: "Tbl_Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 3, "Mobile", "آخرین محصول ساسمونگ", "Samsung s20", 20000000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Products");
        }
    }
}
