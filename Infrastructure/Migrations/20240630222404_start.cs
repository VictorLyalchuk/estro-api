using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Country = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    Street = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    BonusBalance = table.Column<decimal>(type: "numeric", nullable: true),
                    Birthday = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    BagId = table.Column<int>(type: "integer", nullable: true),
                    ClientId = table.Column<string>(type: "text", nullable: true),
                    AuthType = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CountryName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImageForHome",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ImagePath = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageForHome", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
                    URLName = table.Column<string>(type: "text", nullable: false),
                    ImagePath = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderPayment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Payment = table.Column<string>(type: "text", nullable: true),
                    PaymentMethod = table.Column<string>(type: "text", nullable: true),
                    CardNumber = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: true),
                    CardMonthExpires = table.Column<string>(type: "text", nullable: true),
                    CardYearExpires = table.Column<string>(type: "text", nullable: true),
                    CardHolderName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPayment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Bag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserEmail = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bag_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserBonuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<int>(type: "integer", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BonusesOperation = table.Column<string>(type: "text", nullable: true),
                    BonusesDescription = table.Column<string>(type: "text", nullable: true),
                    BonusesAccrued = table.Column<decimal>(type: "numeric", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBonuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBonuses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CityName = table.Column<string>(type: "text", nullable: true),
                    CountryID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    InfoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Info_InfoId",
                        column: x => x.InfoId,
                        principalTable: "Info",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
                    URLName = table.Column<string>(type: "text", nullable: false),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    MainCategoryId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_MainCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MainCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    EmailUser = table.Column<string>(type: "text", nullable: true),
                    Subtotal = table.Column<decimal>(type: "numeric", nullable: true),
                    Tax = table.Column<decimal>(type: "numeric", nullable: true),
                    Discount = table.Column<decimal>(type: "numeric", nullable: true),
                    OrderTotal = table.Column<decimal>(type: "numeric", nullable: true),
                    OrderPaymentId = table.Column<int>(type: "integer", nullable: true),
                    AddressId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AddressEntity_AddressId",
                        column: x => x.AddressId,
                        principalTable: "AddressEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_OrderPayment_OrderPaymentId",
                        column: x => x.OrderPaymentId,
                        principalTable: "OrderPayment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    WorkingHours = table.Column<string>(type: "text", nullable: true),
                    MapLink = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Store_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
                    URLName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    SubCategoryId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
                    Article = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Description = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Highlights = table.Column<List<string>>(type: "text[]", nullable: false),
                    Details = table.Column<string>(type: "text", nullable: false),
                    Purpose = table.Column<string>(type: "text", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false),
                    Material = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BagItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    BagId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BagItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BagItems_Bag_BagId",
                        column: x => x.BagId,
                        principalTable: "Bag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BagItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Step = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    DueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Article = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductQuantity = table.Column<int>(type: "integer", nullable: true),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    inStock = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Storage_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFavoriteProduct",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavoriteProduct", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_UserFavoriteProduct_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFavoriteProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CountryName" },
                values: new object[,]
                {
                    { 1, "Ukraine" },
                    { 2, "England" },
                    { 3, "Spain" },
                    { 4, "France" },
                    { 5, "Poland" },
                    { 6, "USA" },
                    { 7, "Japan" }
                });

            migrationBuilder.InsertData(
                table: "ImageForHome",
                columns: new[] { "Id", "ImagePath" },
                values: new object[,]
                {
                    { 1, "800_home_page_1.webp" },
                    { 2, "800_home_page_2.webp" },
                    { 3, "800_home_page_3.webp" },
                    { 4, "800_home_page_4.webp" },
                    { 5, "800_home_page_5.webp" },
                    { 6, "800_home_page_6.webp" },
                    { 7, "800_home_page_7.webp" },
                    { 8, "800_home_page_8.webp" },
                    { 9, "800_home_page_9.webp" },
                    { 10, "800_home_page_10.webp" },
                    { 11, "800_home_page_11.webp" },
                    { 12, "800_home_page_12.webp" },
                    { 13, "800_home_page_13.webp" },
                    { 14, "800_home_page_14.webp" },
                    { 15, "800_home_page_15.webp" },
                    { 16, "800_home_page_16.webp" },
                    { 17, "800_home_page_17.webp" }
                });

            migrationBuilder.InsertData(
                table: "Info",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Color", "color" },
                    { 2, "Material", "material" },
                    { 3, "Size", "size" },
                    { 4, "Purpose", "purpose" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "ImagePath", "Name", "URLName" },
                values: new object[,]
                {
                    { 1, null, "Woman", "woman" },
                    { 2, null, "Man", "man" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CityName", "CountryID" },
                values: new object[,]
                {
                    { 1, "Kiyv", 1 },
                    { 2, "Vinnytsia", 1 },
                    { 3, "Dnipro", 1 },
                    { 4, "Zhytomyr", 1 },
                    { 5, "Ivano-Frankivsk", 1 },
                    { 6, "Kovel", 1 },
                    { 7, "Lutsk", 1 },
                    { 8, "Lviv", 1 },
                    { 9, "Odesa", 1 },
                    { 10, "Rivne", 1 },
                    { 11, "Kharkiv", 1 },
                    { 12, "Chernivtsi", 1 }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "InfoId", "Label", "Value" },
                values: new object[,]
                {
                    { 1, 1, "Black", "black" },
                    { 2, 1, "Brown", "brown" },
                    { 3, 1, "Gray", "gray" },
                    { 4, 1, "Light Gray", "lightgray" },
                    { 5, 1, "White", "white" },
                    { 6, 1, "Milk", "milk" },
                    { 7, 1, "Navi", "navi" },
                    { 8, 1, "Blue", "blue" },
                    { 9, 2, "Leather", "leather" },
                    { 10, 2, "Suede", "suede" },
                    { 11, 2, "Nubuck", "nubuck" },
                    { 12, 2, "Textile", "textile" },
                    { 13, 2, "Synthetic", "synthetic" },
                    { 14, 2, "Eco Leather", "ecoleather" },
                    { 15, 3, "35", "35" },
                    { 16, 3, "36", "36" },
                    { 17, 3, "37", "37" },
                    { 18, 3, "38", "38" },
                    { 19, 3, "39", "39" },
                    { 20, 3, "40", "40" },
                    { 21, 3, "41", "41" },
                    { 25, 3, "42", "42" },
                    { 26, 3, "43", "43" },
                    { 27, 3, "44", "44" },
                    { 28, 3, "45", "45" },
                    { 29, 3, "46", "46" },
                    { 30, 4, "Winter", "winter" },
                    { 31, 4, "Spring", "spring" },
                    { 32, 4, "Summer", "summer" },
                    { 33, 4, "Autumn", "autumn" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "ImagePath", "MainCategoryId", "Name", "URLName" },
                values: new object[,]
                {
                    { 1, null, 1, "Woman Shoes", "woman-shoes" },
                    { 2, null, 2, "Man Shoes", "man-shoes" },
                    { 3, null, 1, "Woman Clothing", "woman-clothing" },
                    { 4, null, 2, "Man Clothing", "man-clothing" },
                    { 5, null, 1, "Woman Accessories", "woman-accessories" },
                    { 6, null, 2, "Man Accessories", "man-accessories" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ImagePath", "Name", "SubCategoryId", "URLName" },
                values: new object[,]
                {
                    { 1, null, null, "Open shoes", 1, "open-shoes" },
                    { 2, null, null, "Pumps and loafers", 1, "pumps-and-loafers" },
                    { 3, null, null, "Heeled shoes", 1, "heeled-shoes" },
                    { 4, null, null, "Women's athletic sneakers", 1, "women-s-athletic-sneakers" },
                    { 5, null, null, "Women's sneakers", 1, "women-sneakers" },
                    { 6, null, null, "High boots and Chelsea", 1, "high-boots-&-chelsea" },
                    { 7, null, null, "Boots on heels", 1, "boots-on-heels" },
                    { 8, null, null, "Boots and high boots", 1, "boots-and-high-boots" },
                    { 9, null, null, "Cossacks boots", 1, "cossacks-boots" },
                    { 10, null, null, "Winter footwear", 1, "winter-footwear" },
                    { 11, null, null, "Perforated shoes", 1, "perforated-shoes" },
                    { 12, null, null, "Men's boots", 2, "men-boots" },
                    { 13, null, null, "Men's athletic sneakers", 2, "man-athletic-sneakers" },
                    { 14, null, null, "Men's sneakers", 2, "man-sneakers" },
                    { 15, null, null, "Men's pumps", 2, "man-pumps" },
                    { 16, null, null, "Men's moccasins", 2, "man-moccasins" },
                    { 17, null, null, "Men's summer shoes", 2, "man-summer-shoes" },
                    { 18, null, null, "Women's outerwear", 3, "woman-outerwear" },
                    { 19, null, null, "Women's sweaters and suits", 3, "woman-sweaters-and-suits" },
                    { 20, null, null, "Women's t-shirts and sweatshirts", 3, "woman-t-shirts-and-sweatshirts" },
                    { 21, null, null, "Women's shawl", 3, "woman-shawl" },
                    { 22, null, null, "Women's scarves and hats", 3, "woman-scarves-and-hats" },
                    { 23, null, null, "Women's gloves", 3, "woman-gloves" },
                    { 24, null, null, "Women's socks and tights", 3, "woman-socks-and-tights" },
                    { 25, null, null, "Men's outerwear", 4, "man-outerwear" },
                    { 26, null, null, "Men's sweaters and suits", 4, "man-sweaters-and-suits" },
                    { 27, null, null, "Men's t-shirts and sweatshirts", 4, "man-t-shirts-and-sweatshirts" },
                    { 28, null, null, "Men's scarves and hats", 4, "man-scarves-and-hats" },
                    { 29, null, null, "Men's gloves", 4, "man-gloves" },
                    { 30, null, null, "Men's socks", 4, "man-socks" },
                    { 31, null, null, "Women's glasses", 5, "woman-glasses" },
                    { 32, null, null, "Women's home shoes", 5, "woman-home-shoes" },
                    { 33, null, null, "Women's bags", 5, "woman-bags" },
                    { 34, null, null, "Women's backpacks", 5, "woman-backpacks" },
                    { 35, null, null, "Women's care products", 5, "woman-care-products" },
                    { 36, null, null, "Men's glasses", 6, "man-glasses" },
                    { 37, null, null, "Men's home shoes", 6, "man-home-shoes" },
                    { 38, null, null, "Men's bags", 6, "man-bags" },
                    { 39, null, null, "Men's backpacks", 6, "man-backpacks" },
                    { 40, null, null, "Men's care products", 6, "man-care-products" }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "Address", "CityId", "MapLink", "Name", "WorkingHours" },
                values: new object[,]
                {
                    { 1, "Antonovycha, 176, Ground Floor", 1, "Link to map", "TRC Ocean Plaza", "Daily 10:00 - 22:00" },
                    { 2, "Dniprovska Naberezhna, 12, Second Floor", 1, "Link to map", "TRC River Mall", "Daily 10:00 - 22:00" },
                    { 3, "Prospekt Obolonsky, 1-B, First Floor", 1, "Link to map", "TRC DREAM Yellow", "Daily 10:00 - 22:00" },
                    { 4, "Berkovetska, 6-D, First Floor", 1, "Link to map", "TRC Lavina Mall", "Daily 10:00 - 22:00" },
                    { 5, "Kiltseva Doroga, 1, First Floor", 1, "Link to map", "TRC Respublika Park", "Daily 10:00 - 22:00" },
                    { 6, "Prospekt Pravdy, 47, First Floor", 1, "Link to map", "TRC Retroville", "Daily 10:00 - 22:00" },
                    { 7, "Prospekt Stepana Bandery, 36, First Floor", 1, "Link to map", "TRC Blockbuster Mall", "Daily 10:00 - 22:00" },
                    { 8, "Gnata Khotkevycha, 1-B, First Floor", 1, "Link to map", "TRK Prospekt", "Daily 10:00 - 22:00" },
                    { 9, "600-Richchia, 17, New Building, First Floor", 2, "Link to map", "TRC Megamall", "Daily 10:00 - 21:00" },
                    { 10, "Mykoly Ovodova, 51, First Floor", 2, "Link to map", "TRC Sky Park", "Daily 10:00 - 21:00" },
                    { 11, "Queen Elizabeth II (Hlinka), 2, Ground Floor", 3, "Link to map", "TRC MOST City", "Daily 10:00 - 21:00" },
                    { 12, "Nyzhnedniprovskaya, 17, First Floor", 3, "Link to map", "TRC Karavan", "Daily 10:00 - 21:00" },
                    { 13, "Kyivska, 77, First Floor", 4, "Link to map", "TRC Global", "Daily 10:00 - 21:00" },
                    { 14, "Ivana Mykolaychuka, 2", 5, "Link to map", "Shopping Mall ARSEN", "Daily 10:00 - 21:00" },
                    { 15, "4 Varshavska Street", 6, "Link to map", "Juvent Shopping Center (Boutique 110)", "Daily 10:00 - 18:00" },
                    { 16, "1 Sukhomlynskoho Street, Second Floor", 7, "Link to map", "PortCity Shopping Mall", "Daily 10:00 - 22:00" },
                    { 17, "1 Voli Avenue, Fourth Floor", 7, "Link to map", "TSUM Lutsk", "Daily 09:30 - 21:00" },
                    { 18, "9 Voli Avenue, Building Facade", 7, "Link to map", "ESTRO Store (Voli, 9)", "Daily 09:00 - 21:00" },
                    { 19, "1 Karpenka-Karyho Street", 7, "Link to map", "Juvent Shopping Center (Boutique 125)", "Daily 09:00 - 21:00" },
                    { 20, "7b Pid Dubom Street, Second Floor", 8, "Link to map", "Forum Lviv Shopping Mall", "Daily 10:00 - 21:00" },
                    { 21, "226-A Kulparkivska Street, First Floor", 8, "Link to map", "Victoria Gardens Shopping Mall", "Daily 10:00 - 20:00" },
                    { 22, "30 Stryiska Street, First Floor", 8, "Link to map", "King Cross Leopolis Shopping Mall", "Daily 10:00 - 21:00" },
                    { 23, "14 Doroshenka Street", 8, "Link to map", "ESTRO Store (Doroshenka, 14)", "Daily 10:00 - 20:00" },
                    { 24, "2 Prospekt Nezalezhnosti, First Floor", 9, "Link to map", "City Center Shopping Mall", "Daily 10:00 - 21:00" },
                    { 25, "23 Kulyka i Hudacheka", 10, "Link to map", "Equator Shopping Mall", "Daily 10:00 - 22:00" },
                    { 26, "1 Oleksandra Borysenka, First Floor", 10, "Link to map", "Zlata Plaza Shopping Mall", "Daily 10:00 - 21:00" },
                    { 27, "9 Heroiv Pratsi, First Floor", 11, "Link to map", "Dafi Shopping Mall", "Daily 10:00 - 20:00" },
                    { 28, "2a Pushkinska, Third Floor", 11, "Link to map", "Nikolsky Shopping Mall", "Daily 10:00 - 21:00" },
                    { 29, "265A Haharina, First Floor", 12, "Link to map", "DEPO't Center Shopping Mall", "Daily 10:00 - 20:00" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "CategoryId", "Color", "Description", "Details", "Highlights", "Material", "Name", "Price", "Purpose" },
                values: new object[,]
                {
                    { 1, "ER00113828", 8, "Black", "These stylish black leather boots-stockings are a perfect blend of fashion and comfort. Crafted with high-quality leather, they provide a sleek and sophisticated look. Ideal for various occasions, these boots-stockings are a must-have in your wardrobe.", "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, "Leather", "Boots-stockings are black leather", 7399m, "Autumn" },
                    { 2, "ER00112019", 8, "Brown", "Step into the season with elegance in these Autumn brown leather stretch boots. Meticulously crafted from premium leather, these boots offer both style and comfort. The stretch feature ensures a snug fit, while the rich brown color adds a touch of warmth to your autumn wardrobe. Perfect for any occasion, these boots are a fashion statement that complements your unique style. Embrace the essence of autumn with each step.", "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, "Leather", "Autumn brown leather stretch boots", 8899m, "Autumn" },
                    { 3, "ER00112018", 8, "Black", "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, "Leather", "Autumn leather stretch boots", 8899m, "Autumn" },
                    { 4, "ER00112022", 8, "Black", "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, "Leather", "Boots autumn leather black", 9899m, "Autumn" },
                    { 5, "ER00112011", 8, "Black", "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, "Leather", "Black autumn leather stretch boots", 9899m, "Autumn" },
                    { 6, "ER00113851", 8, "Black", "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, "Leather", "Black demi-season boots", 8799m, "Autumn" },
                    { 7, "ER00112023", 8, "Black", "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, "Leather", "Boots-stockings leather black", 9989m, "Autumn" },
                    { 8, "ER00114318", 8, "Burgundy", "Estro ER00112018 Burgundy Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, "Leather", "Boots-pipes with wide freebies are burgundy", 9989m, "Autumn" },
                    { 9, "ER00112298", 8, "Black", "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, "Leather", "Black leather Cossack boots", 8799m, "Autumn" },
                    { 10, "ER00112123", 8, "Black", "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, "Leather", "Boots-stockings on a stiletto are black", 8699m, "Autumn" },
                    { 11, "ER00112122", 8, "Milk", "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, "Leather", "Milk stiletto stocking boots", 8699m, "Autumn" },
                    { 12, "ER00114239", 8, "Brown", "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, "Leather", "Boots-stockings on a stiletto are brown", 8399m, "Autumn" },
                    { 13, "ER00114240", 8, "Black", "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, "Leather", "Boots-stockings on a stiletto are black", 8399m, "Autumn" },
                    { 14, "ER00113949", 7, "Black", "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, "Leather", "Ankle boots are black", 2890m, "Autumn" },
                    { 15, "ER00111942", 12, "Black", "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, "Leather", "Winter boots", 2290m, "Winter" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "ImagePath", "ProductId" },
                values: new object[,]
                {
                    { 1, "Product1_1.webp", 1 },
                    { 2, "Product1_2.webp", 1 },
                    { 3, "Product1_3.webp", 1 },
                    { 4, "Product1_4.webp", 1 },
                    { 5, "Product1_5.webp", 1 },
                    { 6, "Product1_6.webp", 1 },
                    { 7, "Product2_1.webp", 2 },
                    { 8, "Product2_2.webp", 2 },
                    { 9, "Product2_3.webp", 2 },
                    { 10, "Product2_4.webp", 2 },
                    { 11, "Product2_5.webp", 2 },
                    { 12, "Product2_6.webp", 2 },
                    { 13, "Product2_7.webp", 2 },
                    { 14, "Product2_8.webp", 2 },
                    { 15, "Product2_9.webp", 2 },
                    { 16, "Product3_1.webp", 3 },
                    { 17, "Product3_2.webp", 3 },
                    { 18, "Product3_3.webp", 3 },
                    { 19, "Product3_4.webp", 3 },
                    { 20, "Product3_5.webp", 3 },
                    { 21, "Product4_1.webp", 4 },
                    { 22, "Product4_2.webp", 4 },
                    { 23, "Product4_3.webp", 4 },
                    { 24, "Product4_4.webp", 4 },
                    { 25, "Product4_5.webp", 4 },
                    { 26, "Product4_6.webp", 4 },
                    { 27, "Product5_1.webp", 5 },
                    { 28, "Product5_2.webp", 5 },
                    { 29, "Product5_3.webp", 5 },
                    { 30, "Product5_4.webp", 5 },
                    { 31, "Product5_5.webp", 5 },
                    { 32, "Product5_6.webp", 5 },
                    { 33, "Product6_1.webp", 6 },
                    { 34, "Product6_2.webp", 6 },
                    { 35, "Product6_3.webp", 6 },
                    { 36, "Product6_4.webp", 6 },
                    { 37, "Product6_5.webp", 6 },
                    { 38, "Product6_6.webp", 6 },
                    { 39, "Product7_1.webp", 7 },
                    { 40, "Product7_2.webp", 7 },
                    { 41, "Product7_3.webp", 7 },
                    { 42, "Product7_4.webp", 7 },
                    { 43, "Product7_5.webp", 7 },
                    { 44, "Product8_1.webp", 8 },
                    { 45, "Product8_2.webp", 8 },
                    { 46, "Product8_3.webp", 8 },
                    { 47, "Product8_4.webp", 8 },
                    { 48, "Product8_5.webp", 8 },
                    { 49, "Product8_6.webp", 8 },
                    { 50, "Product8_7.webp", 8 },
                    { 51, "Product9_1.webp", 9 },
                    { 52, "Product9_2.webp", 9 },
                    { 53, "Product9_3.webp", 9 },
                    { 54, "Product9_4.webp", 9 },
                    { 55, "Product9_5.webp", 9 },
                    { 56, "Product9_6.webp", 9 },
                    { 57, "Product10_1.webp", 10 },
                    { 58, "Product10_2.webp", 10 },
                    { 59, "Product10_3.webp", 10 },
                    { 60, "Product10_4.webp", 10 },
                    { 61, "Product10_5.webp", 10 },
                    { 62, "Product10_6.webp", 10 },
                    { 63, "Product10_7.webp", 10 },
                    { 64, "Product10_8.webp", 10 },
                    { 65, "Product11_1.webp", 11 },
                    { 66, "Product11_2.webp", 11 },
                    { 67, "Product11_3.webp", 11 },
                    { 68, "Product11_4.webp", 11 },
                    { 69, "Product11_5.webp", 11 },
                    { 70, "Product11_6.webp", 11 },
                    { 71, "Product12_1.webp", 12 },
                    { 72, "Product12_2.webp", 12 },
                    { 73, "Product12_3.webp", 12 },
                    { 74, "Product12_4.webp", 12 },
                    { 75, "Product12_5.webp", 12 },
                    { 76, "Product12_6.webp", 12 },
                    { 77, "Product13_1.webp", 13 },
                    { 78, "Product13_2.webp", 13 },
                    { 79, "Product13_3.webp", 13 },
                    { 80, "Product13_4.webp", 13 },
                    { 81, "Product13_5.webp", 13 },
                    { 82, "Product13_6.webp", 13 },
                    { 83, "Product14_1.webp", 14 },
                    { 84, "Product14_2.webp", 14 },
                    { 85, "Product14_3.webp", 14 },
                    { 86, "Product14_4.webp", 14 },
                    { 87, "Product14_5.webp", 14 },
                    { 88, "Product14_6.webp", 14 },
                    { 89, "Product15_1.webp", 15 },
                    { 90, "Product15_2.webp", 15 },
                    { 91, "Product15_3.webp", 15 },
                    { 92, "Product15_4.webp", 15 },
                    { 93, "Product15_5.webp", 15 },
                    { 94, "Product15_6.webp", 15 }
                });

            migrationBuilder.InsertData(
                table: "Storage",
                columns: new[] { "Id", "ProductId", "ProductQuantity", "Size", "inStock" },
                values: new object[,]
                {
                    { 1, 1, 8, 36, true },
                    { 2, 1, 20, 37, true },
                    { 3, 1, 40, 38, true },
                    { 4, 1, 10, 39, true },
                    { 5, 1, 10, 40, true },
                    { 6, 1, 10, 41, true },
                    { 7, 2, 12, 36, true },
                    { 8, 2, 10, 37, true },
                    { 9, 2, 40, 38, true },
                    { 10, 2, 30, 39, true },
                    { 11, 2, 40, 40, true },
                    { 12, 2, 20, 41, true },
                    { 13, 3, 0, 36, false },
                    { 14, 3, 1, 37, true },
                    { 15, 3, 1, 38, true },
                    { 16, 3, 1, 39, true },
                    { 17, 3, 0, 40, false },
                    { 18, 3, 0, 41, false },
                    { 19, 4, 9, 36, true },
                    { 20, 4, 8, 37, true },
                    { 21, 4, 8, 38, true },
                    { 22, 4, 0, 39, false },
                    { 23, 4, 0, 40, false },
                    { 24, 4, 0, 41, false },
                    { 25, 5, 7, 36, true },
                    { 26, 5, 0, 37, false },
                    { 27, 5, 8, 38, true },
                    { 28, 5, 9, 39, true },
                    { 29, 5, 0, 40, false },
                    { 30, 5, 0, 41, false },
                    { 31, 6, 9, 36, true },
                    { 32, 6, 8, 37, true },
                    { 33, 6, 0, 38, false },
                    { 34, 6, 0, 39, false },
                    { 35, 6, 0, 40, false },
                    { 36, 6, 0, 41, false },
                    { 37, 7, 0, 36, false },
                    { 38, 7, 8, 37, true },
                    { 39, 7, 0, 38, false },
                    { 40, 7, 9, 39, true },
                    { 41, 7, 8, 40, false },
                    { 42, 7, 0, 41, false },
                    { 43, 8, 0, 36, false },
                    { 44, 8, 4, 37, true },
                    { 45, 8, 0, 38, false },
                    { 46, 8, 8, 39, true },
                    { 47, 8, 0, 40, false },
                    { 48, 8, 0, 41, false },
                    { 49, 9, 5, 36, true },
                    { 50, 9, 0, 37, false },
                    { 51, 9, 0, 38, false },
                    { 52, 9, 0, 39, false },
                    { 53, 9, 7, 40, true },
                    { 54, 9, 0, 41, false },
                    { 55, 10, 0, 36, false },
                    { 56, 10, 0, 37, false },
                    { 57, 10, 10, 38, true },
                    { 58, 10, 10, 39, true },
                    { 59, 10, 0, 40, false },
                    { 60, 10, 0, 41, false },
                    { 61, 11, 0, 36, false },
                    { 62, 11, 10, 37, true },
                    { 63, 11, 10, 38, true },
                    { 64, 11, 10, 39, true },
                    { 65, 11, 0, 40, false },
                    { 66, 11, 0, 41, false },
                    { 67, 12, 0, 36, false },
                    { 68, 12, 10, 37, true },
                    { 69, 12, 50, 38, true },
                    { 70, 12, 10, 39, true },
                    { 71, 12, 0, 40, false },
                    { 72, 12, 0, 41, false },
                    { 73, 13, 0, 36, false },
                    { 74, 13, 0, 37, false },
                    { 75, 13, 10, 38, true },
                    { 76, 13, 0, 39, false },
                    { 77, 13, 10, 40, true },
                    { 78, 13, 0, 41, false },
                    { 79, 14, 0, 36, false },
                    { 80, 14, 15, 37, true },
                    { 81, 14, 10, 38, true },
                    { 82, 14, 10, 39, true },
                    { 83, 14, 10, 40, true },
                    { 84, 14, 0, 41, false },
                    { 85, 15, 0, 39, false },
                    { 86, 15, 15, 40, true },
                    { 87, 15, 10, 41, true },
                    { 88, 15, 10, 42, true },
                    { 89, 15, 10, 43, true },
                    { 90, 15, 0, 44, false },
                    { 91, 15, 0, 45, false },
                    { 92, 15, 0, 46, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bag_UserId",
                table: "Bag",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BagItems_BagId",
                table: "BagItems",
                column: "BagId");

            migrationBuilder.CreateIndex(
                name: "IX_BagItems_ProductId",
                table: "BagItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SubCategoryId",
                table: "Categories",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryID",
                table: "City",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_InfoId",
                table: "Options",
                column: "InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderPaymentId",
                table: "Orders",
                column: "OrderPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Storage_ProductId",
                table: "Storage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_CityId",
                table: "Store",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_MainCategoryId",
                table: "SubCategories",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBonuses_UserId",
                table: "UserBonuses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavoriteProduct_ProductId",
                table: "UserFavoriteProduct",
                column: "ProductId");
        }

        /// <inheritdoc />
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
                name: "BagItems");

            migrationBuilder.DropTable(
                name: "ImageForHome");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "UserBonuses");

            migrationBuilder.DropTable(
                name: "UserFavoriteProduct");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Bag");

            migrationBuilder.DropTable(
                name: "Info");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AddressEntity");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "OrderPayment");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "MainCategories");
        }
    }
}
