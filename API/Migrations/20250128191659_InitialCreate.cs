using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ProductPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "IsActive", "ProductName", "ProductPrice", "Stock" },
                values: new object[,]
                {
                    { 1, "Telefon açıklaması.", "1.png", true, "IPhone 16 Pro", 87999m, 50 },
                    { 2, "Telefon açıklaması2.", "2.png", true, "IPhone 11 Pro Max", 41000m, 15 },
                    { 3, "Telefon açıklaması3.", "3.png", true, "Poco", 21000m, 50 },
                    { 4, "Telefon açıklaması4.", "4.png", true, "Samsung Galaxy S24", 45000m, 40 },
                    { 5, "Telefon açıklaması5.", "5.png", true, "IPhone 15 Pro", 99999m, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
