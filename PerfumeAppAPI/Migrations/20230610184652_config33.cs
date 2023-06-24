using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerfumeAppAPI.Migrations
{
    public partial class config33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AuthLevel = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    ProductType = table.Column<int>(type: "int", nullable: false),
                    OnSale = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsSale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsSale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29", "c3655448-09d7-49b4-aab6-bdea60203714", "Visitor", "VISITOR" },
                    { "c32f66ed-c960-4cb7-a468-90662e1fb37a", "7a03b52f-cf58-46a0-b0d2-cb9c5475a10a", "Admin", "ADMIN" },
                    { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "3b75166d-a5b2-4d1b-a500-210fdfafb093", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AuthLevel", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, 0, "3f2fefd0-e5a0-4bcb-b58a-a90013359a0b", "admin@email.com", true, false, null, "ADMIN@EMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEFi0KPOImexOTF6rdWUQvrHF+1pXYar7qqSDAf4TE3TwCzauq+ieEFeKOdG0ZjnzeQ==", null, false, "23af14d5-2a31-4d82-bea1-f8abab5e121d", false, "Admin" },
                    { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", 0, 1, "4434e2b8-aa3d-45d4-881b-192cb4c4d87b", "yoni@email.com", true, false, null, "YONI@EMAIL.COM", "YONI", "AQAAAAEAACcQAAAAEDSe1ji8nkC3ajbkPSxJPQ0A/dIL6nADvyU4i75QKeP5yQuiqe2EavH2qJcl+CNVxw==", null, false, "2ef42859-bc95-45d9-aca3-dcaba543ad6a", false, "Yoni" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Gender", "ImgSrc", "Name", "OnSale", "Price", "ProductType" },
                values: new object[,]
                {
                    { 1, 1, "https://img.zap.co.il/pics/6/9/5/0/47700596c.gif", "chanelBlu", false, 245.0, 0 },
                    { 2, 1, "https://ksp.co.il/shop/items/512/50083.jpg?V=23020508", "SauvageDior", false, 200.0, 0 },
                    { 3, 1, "https://la-essence.com/wp-content/uploads/2021/12/Cat_491009_1064-300x300.jpg", "Lacost Home", false, 185.0, 0 },
                    { 4, 1, "./assets/Images/PerfumesImages/Explorer.jpg", "Explorer", true, 175.0, 0 },
                    { 5, 1, "./assets/Images/PerfumesImages/Hermes-Terre-DHermes-Parfum-200ml-.jpeg", "Terre DHermes", true, 160.0, 0 },
                    { 6, 1, "https://www.lovenmour.co.il/images/thumbs/002/0022419_-tester-dior-homme-sport-125ml-edt-_360.jpeg", "DIOR HOMME SPORT", false, 190.0, 0 },
                    { 7, 1, "./assets/Images/PerfumesImages/StrongerArmaniMan.jpg", "STRONGER ARMANI", false, 245.0, 0 },
                    { 8, 1, "./assets/Images/PerfumesImages/HUGO_BOSS_BOTTLED.jpg", "HUGO BOSS BOTTLED", false, 150.0, 0 },
                    { 9, 0, "https://img.zap.co.il/pics/2/2/9/3/41023922c.gif", "Coco Chanel", true, 145.0, 0 },
                    { 10, 0, "./assets/Images/PerfumesImages/ChanelWoman.jpeg", "Gabrielle", true, 245.0, 0 },
                    { 11, 0, "./assets/Images/PerfumesImages/ChanelWoman.jpeg", "Icon Roses", true, 200.0, 0 },
                    { 12, 0, "https://img.zap.co.il/pics/5/2/5/6/51736525c.gif", "Icon Sense", true, 120.0, 0 },
                    { 13, 0, "./assets/Images/PerfumesImages/MonParisWoman.png", "Mon Paris", false, 250.0, 0 },
                    { 14, 0, "./assets/Images/PerfumesImages/Lancom1Woman.jpg", "Lancom", false, 180.0, 0 },
                    { 15, 0, "https://img.zap.co.il/pics/0/6/1/1/42951160c.gif", "ROBERTO CAVALLI", false, 200.0, 0 },
                    { 16, 0, "./assets/Images/PerfumesImages/EuphoriaWoman.jpg", "Euphoria", false, 175.0, 0 },
                    { 17, 0, "https://il.loccitane.com/media/catalog/product/cache/868d7666b4c2dfc365705813a2412c33/2/4/24et050c20.png", "Loccitane", false, 100.0, 0 },
                    { 18, 0, "https://www.kerastase-usa.com/on/demandware.static/-/Sites-kerastase-master-catalog/default/dw855b5ca9/2019/full-size/blond-absolu/kerastase-blond-absolu-masque-ultra-violet-purple-hair-mask.png", "Kerastase", false, 45.0, 1 },
                    { 19, 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR-G7m_QiKgKe4h8dVKMgFSM29-Ns3lNqeoPA&usqp=CAU", "SheaMoisture", false, 13.0, 1 },
                    { 20, 0, "https://media.allure.com/photos/60ae7a8d05e44d9caa4bda2a/1:1/w_1200,h_1200,c_limit/Pantene%20Pro-V%20Soothing%20Recovery%20Mask%20for%20Unruly%20Frizzy%20Hair.jpg", "Pantene", false, 15.0, 1 },
                    { 21, 0, "https://media.allure.com/photos/60ae83569b3b5f2e8e7ae2d0/1:1/w_1300,h_1300,c_limit/Eva%20NYC%20Therapy%20Session%20Hair%20Mask.jpg", "Eva NYC", false, 20.0, 1 },
                    { 22, 0, "./assets/Images/BlowDryConcentrate.png", "Blow Dry Concentrate", false, 45.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c32f66ed-c960-4cb7-a468-90662e1fb37a", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "ddc1ddb9-2495-40d6-b278-633bc6ca29c6" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductsSale");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
