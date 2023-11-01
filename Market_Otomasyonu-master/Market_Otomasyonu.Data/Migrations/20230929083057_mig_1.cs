using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Market_Otomasyonu.Data.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProfitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SaleID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsWorking = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkUnit = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Markets",
                columns: table => new
                {
                    MarketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstablishmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markets", x => x.MarketID);
                    table.ForeignKey(
                        name: "FK_Markets_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxRatio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsContinued = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    MarketID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK_Products_Markets_MarketID",
                        column: x => x.MarketID,
                        principalTable: "Markets",
                        principalColumn: "MarketID");
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    ShoppingCartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    SaleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.ShoppingCartID);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Sales_SaleID",
                        column: x => x.SaleID,
                        principalTable: "Sales",
                        principalColumn: "SaleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, "Pasif", "Belirtilmemiş" },
                    { 2, "Aktif", "Su & İçecek" },
                    { 3, "Aktif", "Meyve & Sebze" },
                    { 4, "Aktif", "Fırın Ürünleri" },
                    { 5, "Aktif", "Temel Gıda" },
                    { 6, "Aktif", "Süt Ürünleri" },
                    { 7, "Aktif", "Kahvaltılık" },
                    { 8, "Aktif", "Atıştırmalık" },
                    { 9, "Aktif", "Kişisel Bakım" },
                    { 10, "Aktif", "Temizlik Malzemeleri" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Worker" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Brand", "CategoryID", "ExpirationDate", "IsContinued", "MarketID", "Name", "PurchasePrice", "Quantity", "SalePrice", "Stock", "TaxRatio", "Unit", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Erikli", 2, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Su (500mL)", 6.80m, 1m, 5m, 100, 0.01m, 4, 0m },
                    { 2, "Erikli", 2, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Su (1,5L)", 71.8m, 6m, 52m, 100, 0.01m, 4, 0m },
                    { 3, "Coca-Cola", 2, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Kola (1L)", 28.99m, 1m, 18.7m, 100, 0.01m, 4, 0m },
                    { 4, "", 3, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "İthal Muz", 52.99m, 1m, 41.49m, 100, 0.01m, 1, 0m },
                    { 5, "", 3, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Salkım Domates", 32.99m, 1m, 27.79m, 100, 0.01m, 1, 0m },
                    { 6, "", 3, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Kuru Soğan", 26.49m, 1m, 24.00m, 100, 0.01m, 1, 0m },
                    { 7, "", 4, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Ekmek", 6.50m, 1m, 6.0m, 100, 0.01m, 4, 0m },
                    { 8, "", 4, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Simit", 7.5m, 1m, 4.50m, 100, 0.01m, 4, 0m },
                    { 9, "", 4, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Peynirli Poğaça", 11.50m, 1m, 6.50m, 100, 0.01m, 4, 0m },
                    { 10, "Yayla", 5, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Pirinç (1kg)", 76.90m, 1m, 69.00m, 100, 0.01m, 4, 0m },
                    { 11, "Sinangil", 5, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Un (1kg)", 21.99m, 1m, 16.99m, 100, 0.01m, 4, 0m },
                    { 12, "Komili", 5, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Ayçiçek Yağı", 119.90m, 1m, 80.00m, 100, 0.01m, 4, 0m },
                    { 13, "İçim (1L)", 6, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Süt", 34.99m, 1m, 29.99m, 100, 0.01m, 4, 0m },
                    { 14, "Tahsildaroğlu", 6, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Beyaz Peynir (450g)", 174.95m, 1m, 148.00m, 100, 0.01m, 4, 0m },
                    { 15, "Pınar", 6, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Yoğurt (750g)", 43.99m, 1m, 39.99m, 100, 0.01m, 4, 0m },
                    { 16, "CP", 7, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Yumurta (10'lu)", 73.99m, 1m, 65.00m, 100, 0.01m, 4, 0m },
                    { 17, "Cumhuriyet", 7, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Sucuk (220g)", 176.50m, 1m, 140.00m, 100, 0.01m, 4, 0m },
                    { 18, "Balparmak", 7, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Bal (460g)", 196.80m, 1m, 140.00m, 100, 0.01m, 4, 0m },
                    { 19, "Lay's", 8, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Lay's Klasik (107g)", 23.99m, 1m, 19.00m, 100, 0.01m, 4, 0m },
                    { 20, "Peyman", 8, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Karışık Kuruyemiş (180g)", 87.50m, 1m, 62.49m, 100, 0.01m, 4, 0m },
                    { 21, "Ülker", 8, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Çikolatalı Gofret", 5.50m, 1m, 4.5m, 100, 0.01m, 4, 0m },
                    { 22, "Signal", 9, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Signal White Now Gold", 133.11m, 1m, 130.00m, 100, 0.1m, 4, 0m },
                    { 23, "Elidor", 9, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Şampuan", 103.50m, 1m, 84.99m, 100, 0.1m, 4, 0m },
                    { 24, "Dove", 9, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Sıvı El Sabunu", 90.56m, 1m, 80.00m, 100, 0.1m, 4, 0m },
                    { 25, "Domestos", 10, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Domestos Dağ Esintisi", 39.50m, 1m, 33.49m, 100, 0.2m, 4, 0m },
                    { 26, "Solo", 10, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Tuvalet Kağıdı (16'lı)", 164.39m, 1m, 130.00m, 100, 0.2m, 4, 0m },
                    { 27, "Finish", 10, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satışa Açık", null, "Finish Quantum (40'lı)", 71.10m, 1m, 54.00m, 100, 0.2m, 4, 0m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "ConfirmPassword", "CreatedDate", "Gender", "IsWorking", "Name", "Password", "RoleID", "Surname", "Username", "WorkUnit" },
                values: new object[,]
                {
                    { 1, "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7", new DateTime(2023, 9, 29, 11, 30, 57, 612, DateTimeKind.Local).AddTicks(9873), "Erkek", "Çalışıyor", "Enes", "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7", 1, "Fevzi", "enesfevzi", null },
                    { 2, "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7", new DateTime(2023, 9, 29, 11, 30, 57, 612, DateTimeKind.Local).AddTicks(9885), "Erkek", "Çalışıyor", "İhsan", "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7", 2, "Tapan", "ihsantapan", 1 },
                    { 3, "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7", new DateTime(2023, 9, 29, 11, 30, 57, 612, DateTimeKind.Local).AddTicks(9888), "Kadın", "Çalışıyor", "Ebru", "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7", 2, "Çevik", "ebrucevik", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Markets_UserID",
                table: "Markets",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MarketID",
                table: "Products",
                column: "MarketID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductID",
                table: "ShoppingCarts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_SaleID",
                table: "ShoppingCarts",
                column: "SaleID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Markets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
