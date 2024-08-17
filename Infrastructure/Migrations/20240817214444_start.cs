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
                    CountryName_en = table.Column<string>(type: "text", nullable: true),
                    CountryName_es = table.Column<string>(type: "text", nullable: true),
                    CountryName_fr = table.Column<string>(type: "text", nullable: true),
                    CountryName_uk = table.Column<string>(type: "text", nullable: true)
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
                    Name_en = table.Column<string>(type: "text", nullable: false),
                    Name_es = table.Column<string>(type: "text", nullable: false),
                    Name_fr = table.Column<string>(type: "text", nullable: false),
                    Name_uk = table.Column<string>(type: "text", nullable: false),
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
                    Name_en = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
                    Name_es = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
                    Name_uk = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
                    Name_fr = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
                    Description_en = table.Column<string>(type: "text", nullable: true),
                    Description_uk = table.Column<string>(type: "text", nullable: true),
                    Description_es = table.Column<string>(type: "text", nullable: true),
                    Description_fr = table.Column<string>(type: "text", nullable: true),
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
                    BonusesOperation_en = table.Column<string>(type: "text", nullable: true),
                    BonusesOperation_uk = table.Column<string>(type: "text", nullable: true),
                    BonusesOperation_es = table.Column<string>(type: "text", nullable: true),
                    BonusesOperation_fr = table.Column<string>(type: "text", nullable: true),
                    BonusesDescription_en = table.Column<string>(type: "text", nullable: true),
                    BonusesDescription_uk = table.Column<string>(type: "text", nullable: true),
                    BonusesDescription_es = table.Column<string>(type: "text", nullable: true),
                    BonusesDescription_fr = table.Column<string>(type: "text", nullable: true),
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
                    CityName_en = table.Column<string>(type: "text", nullable: true),
                    CityName_es = table.Column<string>(type: "text", nullable: true),
                    CityName_fr = table.Column<string>(type: "text", nullable: true),
                    CityName_uk = table.Column<string>(type: "text", nullable: true),
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
                name: "ProductColor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "text", nullable: false),
                    Name_en = table.Column<string>(type: "text", nullable: true),
                    Name_es = table.Column<string>(type: "text", nullable: true),
                    Name_uk = table.Column<string>(type: "text", nullable: true),
                    Name_fr = table.Column<string>(type: "text", nullable: true),
                    InfoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductColor_Info_InfoId",
                        column: x => x.InfoId,
                        principalTable: "Info",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "text", nullable: false),
                    Name_en = table.Column<string>(type: "text", nullable: true),
                    Name_es = table.Column<string>(type: "text", nullable: true),
                    Name_uk = table.Column<string>(type: "text", nullable: true),
                    Name_fr = table.Column<string>(type: "text", nullable: true),
                    InfoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductMaterial_Info_InfoId",
                        column: x => x.InfoId,
                        principalTable: "Info",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductSeason",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "text", nullable: false),
                    Name_en = table.Column<string>(type: "text", nullable: true),
                    Name_es = table.Column<string>(type: "text", nullable: true),
                    Name_uk = table.Column<string>(type: "text", nullable: true),
                    Name_fr = table.Column<string>(type: "text", nullable: true),
                    InfoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSeason", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSeason_Info_InfoId",
                        column: x => x.InfoId,
                        principalTable: "Info",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "text", nullable: false),
                    Name_en = table.Column<string>(type: "text", nullable: true),
                    Name_es = table.Column<string>(type: "text", nullable: true),
                    Name_uk = table.Column<string>(type: "text", nullable: true),
                    Name_fr = table.Column<string>(type: "text", nullable: true),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    InfoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSize_Info_InfoId",
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
                    Name_en = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
                    Name_es = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
                    Name_uk = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
                    Name_fr = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
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
                    Name_en = table.Column<string>(type: "text", nullable: true),
                    Name_es = table.Column<string>(type: "text", nullable: true),
                    Name_fr = table.Column<string>(type: "text", nullable: true),
                    Name_uk = table.Column<string>(type: "text", nullable: true),
                    WorkingHours = table.Column<string>(type: "text", nullable: true),
                    MapLink = table.Column<string>(type: "text", nullable: true),
                    Address_en = table.Column<string>(type: "text", nullable: true),
                    Address_es = table.Column<string>(type: "text", nullable: true),
                    Address_fr = table.Column<string>(type: "text", nullable: true),
                    Address_uk = table.Column<string>(type: "text", nullable: true),
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
                    Name_en = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
                    Name_es = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
                    Name_uk = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
                    Name_fr = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
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
                    Name_en = table.Column<string>(type: "character varying(180)", maxLength: 180, nullable: false),
                    Name_uk = table.Column<string>(type: "text", nullable: false),
                    Name_es = table.Column<string>(type: "text", nullable: false),
                    Name_fr = table.Column<string>(type: "text", nullable: false),
                    Article = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Description_en = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Description_uk = table.Column<string>(type: "text", nullable: false),
                    Description_es = table.Column<string>(type: "text", nullable: false),
                    Description_fr = table.Column<string>(type: "text", nullable: false),
                    Highlights_en = table.Column<List<string>>(type: "text[]", nullable: true),
                    Highlights_uk = table.Column<List<string>>(type: "text[]", nullable: true),
                    Highlights_es = table.Column<List<string>>(type: "text[]", nullable: true),
                    Highlights_fr = table.Column<List<string>>(type: "text[]", nullable: true),
                    SeasonId = table.Column<int>(type: "integer", nullable: false),
                    ColorId = table.Column<int>(type: "integer", nullable: false),
                    MaterialId = table.Column<int>(type: "integer", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Products_ProductColor_ColorId",
                        column: x => x.ColorId,
                        principalTable: "ProductColor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductMaterial_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "ProductMaterial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductSeason_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "ProductSeason",
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
                    Size = table.Column<string>(type: "text", nullable: false),
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
                    Name_en = table.Column<string>(type: "text", nullable: false),
                    Name_uk = table.Column<string>(type: "text", nullable: false),
                    Name_es = table.Column<string>(type: "text", nullable: false),
                    Name_fr = table.Column<string>(type: "text", nullable: false),
                    Description_en = table.Column<string>(type: "text", nullable: false),
                    Description_uk = table.Column<string>(type: "text", nullable: false),
                    Description_es = table.Column<string>(type: "text", nullable: false),
                    Description_fr = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Step = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    DueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Article = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Size = table.Column<string>(type: "text", nullable: true),
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
                    Size = table.Column<string>(type: "text", nullable: false),
                    inStock = table.Column<bool>(type: "boolean", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "UserProductReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Author = table.Column<string>(type: "text", nullable: false),
                    Avatar = table.Column<string>(type: "text", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProductReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProductReview_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProductReview_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CountryName_en", "CountryName_es", "CountryName_fr", "CountryName_uk" },
                values: new object[,]
                {
                    { 1, "Ukraine", "Ucrania", "Ukraine", "Україна" },
                    { 2, "England", "Inglaterra", "Angleterre", "Англія" },
                    { 3, "Spain", "España", "Espagne", "Іспанія" },
                    { 4, "France", "Francia", "France", "Франція" },
                    { 5, "Poland", "Polonia", "Pologne", "Польща" },
                    { 6, "USA", "Estados Unidos", "États-Unis", "США" },
                    { 7, "Japan", "Japón", "Japon", "Японія" }
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
                columns: new[] { "Id", "Name_en", "Name_es", "Name_fr", "Name_uk", "Value" },
                values: new object[,]
                {
                    { 1, "Color", "Color", "Couleur", "Колір", "color" },
                    { 2, "Material", "Material", "Matériau", "Матеріал", "material" },
                    { 3, "Size", "Tamaño", "Taille", "Розмір", "size" },
                    { 4, "Season", "Estación", "Saison", "Сезон", "season" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Description_en", "Description_es", "Description_fr", "Description_uk", "ImagePath", "Name_en", "Name_es", "Name_fr", "Name_uk", "URLName" },
                values: new object[,]
                {
                    { 1, null, null, null, null, "800_home_page_16.webp", "Women", "Mujer", "Femme", "Жіноче", "women" },
                    { 2, null, null, null, null, "800_home_page_17.webp", "Men", "Hombre", "Homme", "Чоловіче", "men" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CityName_en", "CityName_es", "CityName_fr", "CityName_uk", "CountryID" },
                values: new object[,]
                {
                    { 1, "Kyiv", "Kiev", "Kiev", "Київ", 1 },
                    { 2, "Vinnytsia", "Vinnitsa", "Vinnitsa", "Вінниця", 1 },
                    { 3, "Dnipro", "Dniepr", "Dniepr", "Дніпро", 1 },
                    { 4, "Zhytomyr", "Jytomyr", "Jytomyr", "Житомир", 1 },
                    { 5, "Ivano-Frankivsk", "Ivano-Frankivsk", "Ivano-Frankivsk", "Івано-Франківськ", 1 },
                    { 6, "Kovel", "Kovel", "Kovel", "Ковель", 1 },
                    { 7, "Lutsk", "Loutsk", "Loutsk", "Луцьк", 1 },
                    { 8, "Lviv", "Lviv", "Lviv", "Львів", 1 },
                    { 9, "Odesa", "Odessa", "Odessa", "Одеса", 1 },
                    { 10, "Rivne", "Rovno", "Rovno", "Рівне", 1 },
                    { 11, "Kharkiv", "Kharkov", "Kharkov", "Харків", 1 },
                    { 12, "Chernivtsi", "Tchernivtsi", "Tchernivtsi", "Чернівці", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductColor",
                columns: new[] { "Id", "InfoId", "Name_en", "Name_es", "Name_fr", "Name_uk", "Value" },
                values: new object[,]
                {
                    { 1, 1, "Beige", "Beige", "Beige", "Бежевий", "beige" },
                    { 2, 1, "Black", "Negro", "Noir", "Чорний", "black" },
                    { 3, 1, "Blue", "Azul", "Bleu", "Синій", "blue" },
                    { 4, 1, "Brown", "Marrón", "Brun", "Коричневий", "brown" },
                    { 5, 1, "Burgundy", "Borgoña", "Bourgogne", "Бордовий", "burgundy" },
                    { 6, 1, "Gray", "Gris", "Gris", "Сірий", "gray" },
                    { 7, 1, "Light Gray", "Gris claro", "Gris clair", "Світло-сірий", "lightgray" },
                    { 8, 1, "Milk", "Leche", "Lait", "Молочний", "milk" },
                    { 9, 1, "Navi", "Navi", "Navi", "Наві", "navi" },
                    { 10, 1, "White", "Blanco", "Blanche", "Білий", "white" }
                });

            migrationBuilder.InsertData(
                table: "ProductMaterial",
                columns: new[] { "Id", "InfoId", "Name_en", "Name_es", "Name_fr", "Name_uk", "Value" },
                values: new object[,]
                {
                    { 1, 2, "Eco Leather", "Сuero ecológico", "Eco Leather", "Еко шкіра", "ecoleather" },
                    { 2, 2, "Leather", "Сuero", "Cuir", "Шкіра", "leather" },
                    { 3, 2, "Nubuck", "Nubuck", "Nubuck", "Нубук", "nubuck" },
                    { 4, 2, "Synthetic", "Sintética", "Synthétique", "Синтетика", "synthetic" },
                    { 5, 2, "Suede", "Ante", "Suède", "Замша", "suede" },
                    { 6, 2, "Textile", "Textil", "Textile", "Текстиль", "textile" }
                });

            migrationBuilder.InsertData(
                table: "ProductSeason",
                columns: new[] { "Id", "InfoId", "Name_en", "Name_es", "Name_fr", "Name_uk", "Value" },
                values: new object[,]
                {
                    { 1, 4, "Winter", "Invierno", "Hiver", "Зима", "winter" },
                    { 2, 4, "Spring", "Primavera", "Printemps", "Весна", "spring" },
                    { 3, 4, "Summer", "Verano", "Été", "Літо", "summer" },
                    { 4, 4, "Autumn", "Otoño", "Automne", "Осінь", "autumn" }
                });

            migrationBuilder.InsertData(
                table: "ProductSize",
                columns: new[] { "Id", "InfoId", "Name_en", "Name_es", "Name_fr", "Name_uk", "SortOrder", "Value" },
                values: new object[,]
                {
                    { 1, 3, "35", "35", "35", "35", 1, "35" },
                    { 2, 3, "36", "36", "36", "36", 2, "36" },
                    { 3, 3, "37", "37", "37", "37", 3, "37" },
                    { 4, 3, "38", "38", "38", "38", 4, "38" },
                    { 5, 3, "39", "39", "39", "39", 5, "39" },
                    { 6, 3, "40", "40", "40", "40", 6, "40" },
                    { 7, 3, "41", "41", "41", "41", 7, "41" },
                    { 8, 3, "42", "42", "42", "42", 8, "42" },
                    { 9, 3, "43", "43", "43", "43", 9, "43" },
                    { 10, 3, "44", "44", "44", "44", 10, "44" },
                    { 11, 3, "45", "45", "45", "45", 11, "45" },
                    { 12, 3, "46", "46", "46", "46", 12, "46" },
                    { 13, 3, "XS", "XS", "XS", "XS", 13, "XS" },
                    { 14, 3, "S", "S", "S", "S", 14, "S" },
                    { 15, 3, "M", "M", "M", "M", 15, "M" },
                    { 16, 3, "L", "L", "L", "L", 16, "L" },
                    { 17, 3, "XL", "XL", "XL", "XL", 17, "XL" },
                    { 18, 3, "XXL", "XXL", "XXL", "XXL", 18, "XXL" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "ImagePath", "MainCategoryId", "Name_en", "Name_es", "Name_fr", "Name_uk", "URLName" },
                values: new object[,]
                {
                    { 1, null, 1, "Women's Shoes", "Zapatos de mujer", "Chaussures pour femmes", "Жіноче взуття", "woman-shoes" },
                    { 2, null, 2, "Men's Shoes", "Zapatos de hombre", "Chaussures pour hommes", "Чоловіче взуття", "man-shoes" },
                    { 3, null, 1, "Women's Clothing", "Ropa de mujer", "Vêtements pour femmes", "Жіночий одяг", "woman-clothing" },
                    { 4, null, 2, "Men's Clothing", "Ropa de hombre", "Vêtements pour hommes", "Чоловічий одяг", "man-clothing" },
                    { 5, null, 1, "Women's Accessories", "Accesorios de mujer", "Accessoires pour femmes", "Жіночі аксесуари", "woman-accessories" },
                    { 6, null, 2, "Men's Accessories", "Accesorios de hombre", "Accessoires pour hommes", "Чоловічі аксесуари", "man-accessories" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ImagePath", "Name_en", "Name_es", "Name_fr", "Name_uk", "SubCategoryId", "URLName" },
                values: new object[,]
                {
                    { 1, null, null, "Open shoes", "Zapatos abiertos", "Chaussures ouvertes", "Відкрите взуття", 1, "open-shoes" },
                    { 2, null, null, "Pumps and loafers", "Zapatos de tacón y mocasines", "Escarpins et mocassins", "Туфлі та лофери", 1, "pumps-and-loafers" },
                    { 3, null, null, "Heeled shoes", "Zapatos de tacón", "Chaussures à talons", "Туфлі на підборах", 1, "heeled-shoes" },
                    { 4, null, null, "Women's athletic sneakers", "Zapatillas deportivas para mujeres", "Baskets de sport pour femmes", "Кросівки жіночі", 1, "women-s-athletic-sneakers" },
                    { 5, null, null, "Women's sneakers", "Zapatillas para mujeres", "Baskets pour femmes", "Жіночі кеди", 1, "women-sneakers" },
                    { 6, null, null, "High boots and Chelsea", "Botas altas y Chelsea", "Bottes hautes et Chelsea", "Високі черевики, челсі", 1, "high-boots-&-chelsea" },
                    { 7, null, null, "Boots on heels", "Botas de tacón", "Bottes à talons", "Черевики на підборах", 1, "boots-on-heels" },
                    { 8, null, null, "Boots and high boots", "Botas y botas altas", "Bottes et bottes hautes", "Чоботи та ботфорти", 1, "boots-and-high-boots" },
                    { 9, null, null, "Cossacks boots", "Botas de cosaco", "Bottes Cossacks", "Козаки", 1, "cossacks-boots" },
                    { 10, null, null, "Winter footwear", "Calzado de invierno", "Chaussures d'hiver", "Зимове взуття", 1, "winter-footwear" },
                    { 11, null, null, "Perforated shoes", "Zapatos perforados", "Chaussures perforées", "Перфороване взуття", 1, "perforated-shoes" },
                    { 12, null, null, "Men's boots", "Botas para hombres", "Bottes pour hommes", "Чоловічі черевики", 2, "men-boots" },
                    { 13, null, null, "Men's athletic sneakers", "Zapatillas deportivas para hombres", "Baskets de sport pour hommes", "Чоловічі кросівки", 2, "man-athletic-sneakers" },
                    { 14, null, null, "Men's sneakers", "Zapatillas para hombres", "Baskets pour hommes", "Чоловічі кеди", 2, "man-sneakers" },
                    { 15, null, null, "Men's pumps", "Zapatos de tacón para hombres", "Escarpins pour hommes", "Чоловічі туфлі", 2, "man-pumps" },
                    { 16, null, null, "Men's moccasins", "Mocasines para hombres", "Mocassins pour hommes", "Чоловічі мокасини", 2, "man-moccasins" },
                    { 17, null, null, "Men's summer shoes", "Zapatos de verano para hombres", "Chaussures d'été pour hommes", "Чоловічі літнє взуття", 2, "man-summer-shoes" },
                    { 18, null, null, "Women's outerwear", "Ropa exterior para mujeres", "Vêtements d'extérieur pour femmes", "Жіночий верхній одяг", 3, "woman-outerwear" },
                    { 19, null, null, "Women's sweaters and suits", "Suéteres y trajes para mujeres", "Pulls et costumes pour femmes", "Жіночі светри та костюми", 3, "woman-sweaters-and-suits" },
                    { 20, null, null, "Women's t-shirts and sweatshirts", "Camisetas y sudaderas para mujeres", "T-shirts et sweatshirts pour femmes", "Жіночі футболки та світшоти", 3, "woman-t-shirts-and-sweatshirts" },
                    { 21, null, null, "Women's shawl", "Chal para mujeres", "Châle pour femmes", "Жіночі хустки", 3, "woman-shawl" },
                    { 22, null, null, "Women's scarves and hats", "Bufandas y sombreros para mujeres", "Écharpes et chapeaux pour femmes", "Жіночі шарфи та шапки", 3, "woman-scarves-and-hats" },
                    { 23, null, null, "Women's gloves", "Guantes para mujeres", "Gants pour femmes", "Жіночі рукавички", 3, "woman-gloves" },
                    { 24, null, null, "Women's socks and tights", "Calcetines y pantimedias para mujeres", "Chaussettes et collants pour femmes", "Жіночі шкарпетки та колготи", 3, "woman-socks-and-tights" },
                    { 25, null, null, "Men's outerwear", "Ropa exterior para hombres", "Vêtements d'extérieur pour hommes", "Чоловічий верхній одяг", 4, "man-outerwear" },
                    { 26, null, null, "Men's sweaters and suits", "Suéteres y trajes para hombres", "Pulls et costumes pour hommes", "Чоловічі светри та костюми", 4, "man-sweaters-and-suits" },
                    { 27, null, null, "Men's t-shirts and sweatshirts", "Camisetas y sudaderas para hombres", "T-shirts et sweatshirts pour hommes", "Чоловікі футболки та світшоти", 4, "man-t-shirts-and-sweatshirts" },
                    { 28, null, null, "Men's scarves and hats", "Bufandas y sombreros para hombres", "Écharpes et chapeaux pour hommes", "Чоловічі шарфи та шапки", 4, "man-scarves-and-hats" },
                    { 29, null, null, "Men's gloves", "Guantes para hombres", "Gants pour hommes", "Чоловічі рукавички", 4, "man-gloves" },
                    { 30, null, null, "Men's socks", "Calcetines para hombres", "Chaussettes pour hommes", "Чоловічі шкарпетки", 4, "man-socks" },
                    { 31, null, null, "Women's glasses", "Gafas para mujeres", "Lunettes pour femmes", "Жіночі окуляри", 5, "woman-glasses" },
                    { 32, null, null, "Women's home shoes", "Zapatos de casa para mujeres", "Chaussures de maison pour femmes", "Жіноче домашнє взуття", 5, "woman-home-shoes" },
                    { 33, null, null, "Women's bags", "Bolsos para mujeres", "Sacs pour femmes", "Жіночі сумки", 5, "woman-bags" },
                    { 34, null, null, "Women's backpacks", "Mochilas para mujeres", "Sacs à dos pour femmes", "Жіночі рюкзаки для жінок", 5, "woman-backpacks" },
                    { 35, null, null, "Women's care products", "Productos de cuidado para mujeres", "Produits de soin pour femmes", "Жіночі засоби для догляду", 5, "woman-care-products" },
                    { 36, null, null, "Men's glasses", "Gafas para hombres", "Lunettes pour hommes", "Чоловічі окуляри", 6, "man-glasses" },
                    { 37, null, null, "Men's home shoes", "Zapatos de casa para hombres", "Chaussures de maison pour hommes", "Чоловіче домашнє взуття", 6, "man-home-shoes" },
                    { 38, null, null, "Men's bags", "Bolsos para hombres", "Sacs pour hommes", "Чоловічі сумки", 6, "man-bags" },
                    { 39, null, null, "Men's backpacks", "Mochilas para hombres", "Sacs à dos pour hommes", "Чоловічі рюкзаки", 6, "man-backpacks" },
                    { 40, null, null, "Men's care products", "Productos de cuidado para hombres", "Produits de soin pour hommes", "Чоловічі засоби для догляду", 6, "man-care-products" }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "Address_en", "Address_es", "Address_fr", "Address_uk", "CityId", "MapLink", "Name_en", "Name_es", "Name_fr", "Name_uk", "WorkingHours" },
                values: new object[,]
                {
                    { 1, "Antonovycha, 176, Ground Floor", "Antonovycha, 176, Planta Baja", "Antonovycha, 176, Rez-de-chaussée", "вул. Антоновича, 176, перший поверх", 1, "Link to map", "TRC Ocean Plaza", "TRC Ocean Plaza", "TRC Ocean Plaza", "ТРЦ Ocean Plaza", "10:00 - 22:00" },
                    { 2, "Dniprovska Naberezhna, 12, Second Floor", "Dniprovska Naberezhna, 12, Segunda Planta", "Dniprovska Naberezhna, 12, Deuxième étage", "вул. Дніпровська набережна, 12, другий поверх", 1, "Link to map", "TRC River Mall", "TRC River Mall", "TRC River Mall", "ТРЦ River Mall", "10:00 - 22:00" },
                    { 3, "Prospekt Obolonsky, 1-B, First Floor", "Prospekt Obolonsky, 1-B, Primer Piso", "Prospekt Obolonsky, 1-B, Premier étage", "просп. Оболонський, 1-Б, перший поверх", 1, "Link to map", "TRC DREAM Yellow", "TRC DREAM Yellow", "TRC DREAM Yellow", "ТРЦ DREAM Yellow", "10:00 - 22:00" },
                    { 4, "Berkovetska, 6-D, First Floor", "Berkovetska, 6-D, Primer Piso", "Berkovetska, 6-D, Premier étage", "вул. Берковецька, 6-Д, перший поверх", 1, "Link to map", "TRC Lavina Mall", "TRC Lavina Mall", "TRC Lavina Mall", "ТРЦ Lavina Mall", "10:00 - 22:00" },
                    { 5, "Kiltseva Doroga, 1, First Floor", "Kiltseva Doroga, 1, Primer Piso", "Kiltseva Doroga, 1, Premier étage", "вул. Кільцева дорога, 1, перший поверх", 1, "Link to map", "TRC Respublika Park", "TRC Respublika Park", "TRC Respublika Park", "ТРЦ Respublika Park", "10:00 - 22:00" },
                    { 6, "Prospekt Pravdy, 47, First Floor", "Prospekt Pravdy, 47, Primer Piso", "Prospekt Pravdy, 47, Premier étage", "просп. Правди, 47, перший поверх", 1, "Link to map", "TRC Retroville", "TRC Retroville", "TRC Retroville", "ТРЦ Retroville", "10:00 - 22:00" },
                    { 7, "Prospekt Stepana Bandery, 36, First Floor", "Prospekt Stepana Bandery, 36, Primer Piso", "Prospekt Stepana Bandery, 36, Premier étage", "просп. Степана Бандери, 36, перший поверх", 1, "Link to map", "TRC Blockbuster Mall", "TRC Blockbuster Mall", "TRC Blockbuster Mall", "ТРЦ Blockbuster Mall", "10:00 - 22:00" },
                    { 8, "Gnata Khotkevycha, 1-B, First Floor", "Gnata Khotkevycha, 1-B, Primer Piso", "Gnata Khotkevycha, 1-B, Premier étage", "вул. Гната Хоткевича, 1-Б, перший поверх", 1, "Link to map", "TRK Prospekt", "TRK Prospekt", "TRK Prospekt", "ТРК Проспект", "10:00 - 22:00" },
                    { 9, "600-Richchia, 17, New Building, First Floor", "600-Richchia, 17, Nuevo Edificio, Primer Piso", "600-Richchia, 17, Nouveau Bâtiment, Premier étage", "вул. 600-річчя, 17, нова будівля, перший поверх", 2, "Link to map", "TRC Megamall", "TRC Megamall", "TRC Megamall", "ТРЦ Megamall", "10:00 - 21:00" },
                    { 10, "Mykoly Ovodova, 51, First Floor", "Mykoly Ovodova, 51, Primer Piso", "Mykoly Ovodova, 51, Premier étage", "вул. Миколи Оводова, 51, перший поверх", 2, "Link to map", "TRC Sky Park", "TRC Sky Park", "TRC Sky Park", "ТРЦ Sky Park", "10:00 - 21:00" },
                    { 11, "Queen Elizabeth II (Hlinka), 2, Ground Floor", "Queen Elizabeth II (Hlinka), 2, Planta Baja", "Queen Elizabeth II (Hlinka), 2, Rez-de-chaussée", "вул. Глінки (колиш. Єлизавети II), 2, перший поверх", 3, "Link to map", "TRC MOST City", "TRC MOST City", "TRC MOST City", "ТРЦ MOST City", "10:00 - 21:00" },
                    { 12, "Nyzhnedniprovskaya, 17, First Floor", "Nyzhnedniprovskaya, 17, Primer Piso", "Nyzhnedniprovskaya, 17, Premier étage", "вул. Нижньодніпровська, 17, перший поверх", 3, "Link to map", "TRC Karavan", "TRC Karavan", "TRC Karavan", "ТРЦ Karavan", "10:00 - 21:00" },
                    { 13, "Kyivska, 77, First Floor", "Kyivska, 77, Primer Piso", "Kyivska, 77, Premier étage", "вул. Київська, 77, перший поверх", 4, "Link to map", "TRC Global", "TRC Global", "TRC Global", "ТРЦ Global", "10:00 - 21:00" },
                    { 14, "Ivana Mykolaychuka, 2", "Ivana Mykolaychuka, 2", "Ivana Mykolaychuka, 2", "вул. Івана Миколайчука, 2", 5, "Link to map", "Shopping Mall ARSEN", "Centro Comercial ARSEN", "Centre Commercial ARSEN", "ТЦ Арсен", "10:00 - 21:00" },
                    { 15, "4 Varshavska Street", "Calle Varsovia, 4", "Rue Varsovie, 4", "вул. Варшавська, 4", 6, "Link to map", "Juvent Shopping Center (Boutique 110)", "Juvent Centre Commercial (Boutique 110)", "Juvent Centre Commercial (Boutique 110)", "ТЦ Ювент (бутик 110)", "10:00 - 18:00" },
                    { 16, "1 Sukhomlynskoho Street, Second Floor", "Calle Sukhomlynskoho, 1, Segunda Planta", "Rue Sukhomlynskoho, 1, Deuxième étage", "вул. Сухомлинського, 1, другий поверх", 7, "Link to map", "PortCity Shopping Mall", "PortCity Centro Comercial", "PortCity Centre Commercial", "ТЦ PortCity", "10:00 - 22:00" },
                    { 17, "1 Voli Avenue, Fourth Floor", "Avenida Voli, 1, Cuarto Piso", "Avenue Voli, 1, Quatrième étage", "просп. Волі, 1, четвертий поверх", 7, "Link to map", "TSUM Lutsk", "TSUM Lutsk", "TSUM Lutsk", "ЦУМ Луцьк", "09:30 - 21:00" },
                    { 18, "9 Voli Avenue, Building Facade", "Avenida Voli, 9, Fachada del Edificio", "Avenue Voli, 9, Façade du Bâtiment", "просп. Волі, 9, фасад будівлі", 7, "Link to map", "ESTRO Store (Voli, 9)", "ESTRO Store (Voli, 9)", "ESTRO Store (Voli, 9)", "Магазин ЕСТРО (Волі, 9)", "09:00 - 21:00" },
                    { 19, "1 Karpenka-Karyho Street", "Calle Karpenka-Karyho, 1", "Rue Karpenka-Karyho, 1", "вул. Карпенка-Карого, 1", 7, "Link to map", "Juvent Shopping Center (Boutique 125)", "Juvent Shopping Center (Boutique 125)", "Juvent Shopping Center (Boutique 125)", "ТЦ Ювент (бутик 125)", "09:00 - 21:00" },
                    { 20, "7b Pid Dubom Street, Second Floor", "Calle Pid Dubom, 7b, Segunda Planta", "Rue Pid Dubom, 7b, Deuxième étage", "вул. Під Дубом, 7б, другий поверх", 8, "Link to map", "Forum Lviv Shopping Mall", "Forum Lviv Centro Comercial", "Forum Lviv Centre Commercial", "ТЦ Форум Львів", "10:00 - 21:00" },
                    { 21, "226-A Kulparkivska Street, First Floor", "Calle Kulparkivska, 226-A, Primer Piso", "Rue Kulparkivska, 226-A, Premier étage", "вул. Кульпарківська, 226-А, перший поверх", 8, "Link to map", "Victoria Gardens Shopping Mall", "Victoria Gardens Centro Comercial", "Victoria Gardens Centre Commercial", "ТЦ Вікторія Гарденс", "10:00 - 20:00" },
                    { 22, "30 Stryiska Street, First Floor", "Calle Stryiska, 30, Primer Piso", "Rue Stryiska, 30, Premier étage", "вул. Стрийська, 30, перший поверх", 8, "Link to map", "King Cross Leopolis Shopping Mall", "King Cross Leopolis Centro Comercial", "King Cross Leopolis Centre Commercial", "ТЦ King Cross Leopolis", "10:00 - 21:00" },
                    { 23, "14 Doroshenka Street", "Calle Doroshenka, 14", "Rue Doroshenka, 14", "вул. Дорошенка, 14", 8, "Link to map", "ESTRO Store (Doroshenka, 14)", "ESTRO Store (Doroshenka, 14)", "ESTRO Store (Doroshenka, 14)", "Магазин ЕСТРО (Дорошенка, 14)", "10:00 - 20:00" },
                    { 24, "2 Prospekt Nezalezhnosti, First Floor", "Avenida Prospekt Nezalezhnosti, 2, Primer Piso", "Avenue Prospekt Nezalezhnosti, 2, Premier étage", "просп. Незалежності, 2, перший поверх", 9, "Link to map", "City Center Shopping Mall", "City Center Centro Comercial", "City Center Centre Commercial", "ТЦ City Center", "10:00 - 21:00" },
                    { 25, "23 Kulyka i Hudacheka", "Calle Kulyka i Hudacheka, 23", "Rue Kulyka i Hudacheka, 23", "вул. Кулика і Гудачека, 23", 10, "Link to map", "Equator Shopping Mall", "Equator Centro Comercial", "Equator Centre Commercial", "ТЦ Екватор", "10:00 - 22:00" },
                    { 26, "1 Oleksandra Borysenka, First Floor", "Calle Oleksandra Borysenka, 1, Primer Piso", "Rue Oleksandra Borysenka, 1, Premier étage", "вул. Олександра Борисенка, 1, перший поверх", 10, "Link to map", "Zlata Plaza Shopping Mall", "Zlata Plaza Centro Comercial", "Zlata Plaza Centre Commercial", "ТЦ Злата Плаза", "10:00 - 21:00" },
                    { 27, "9 Heroiv Pratsi, First Floor", "Calle Heroiv Pratsi, 9, Primer Piso", "Rue Heroiv Pratsi, 9, Premier étage", "вул. Героїв Праці, 9, перший поверх", 11, "Link to map", "Dafi Shopping Mall", "Dafi Centro Comercial", "Dafi Centre Commercial", "ТЦ Дафі", "10:00 - 20:00" },
                    { 28, "2a Pushkinska, Third Floor", "Calle Pushkinska, 2a, Tercer Piso", "Rue Pushkinska, 2a, Troisième étage", "вул. Пушкінська, 2а, третій поверх", 11, "Link to map", "Nikolsky Shopping Mall", "Nikolsky Centro Comercial", "Nikolsky Centre Commercial", "ТЦ Нікольський", "10:00 - 21:00" },
                    { 29, "265A Haharina, First Floor", "Calle Haharina, 265A, Primer Piso", "Rue Haharina, 265A, Premier étage", "вул. Гагаріна, 265А, перший поверх", 12, "Link to map", "DEPO't Center Shopping Mall", "DEPO't Center Centro Comercial", "DEPO't Center Centre Commercial", "ТЦ Депо", "10:00 - 20:00" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "CategoryId", "ColorId", "Description_en", "Description_es", "Description_fr", "Description_uk", "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk", "MaterialId", "Name_en", "Name_es", "Name_fr", "Name_uk", "Price", "SeasonId" },
                values: new object[,]
                {
                    { 1, "ER00113828", 8, 2, "These stylish black leather boots-stockings are a perfect blend of fashion and comfort. Crafted with high-quality leather, they provide a sleek and sophisticated look. Ideal for various occasions, these boots-stockings are a must-have in your wardrobe.", "Estas elegantes botas-medias de cuero negro son una combinación perfecta de moda y comodidad. Confeccionadas con cuero de alta calidad, brindan una apariencia elegante y sofisticada. Ideales para varias ocasiones, estas botas-medias son imprescindibles en tu guardarropa.", "Ces bottes-bas élégantes en cuir noir sont un mélange parfait de mode et de confort. Confectionnées dans un cuir de haute qualité, elles offrent un look élégant et sophistiqué. Idéales pour diverses occasions, ces bottes-bas sont un incontournable de votre garde-robe.", "Ці стильні чорні шкіряні чоботи-панчохи — це ідеальне поєднання моди та комфорту. Виготовлені з високоякісної шкіри, вони створюють елегантний і витончений вигляд. Ці чоботи-панчохи ідеально підходять для різних випадків, тому їх необхідно мати у вашому гардеробі.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Boots-stockings are black leather", "Las botas-medias son de cuero negro", "Les bottes-bas sont en cuir noir", "Чоботи-панчохи шкіряні чорного кольору", 7399m, 4 },
                    { 2, "ER00112019", 8, 4, "Step into the season with elegance in these Autumn brown leather stretch boots. Meticulously crafted from premium leather, these boots offer both style and comfort. The stretch feature ensures a snug fit, while the rich brown color adds a touch of warmth to your autumn wardrobe. Perfect for any occasion, these boots are a fashion statement that complements your unique style. Embrace the essence of autumn with each step.", "Entra en la temporada con elegancia con estas botas elásticas de cuero marrón Autumn. Meticulosamente elaboradas con cuero de primera calidad, estas botas ofrecen estilo y comodidad. La característica elástica garantiza un ajuste cómodo, mientras que el rico color marrón añade un toque de calidez a tu guardarropa de otoño. Perfectas para cualquier ocasión, estas botas son una declaración de moda que complementa tu estilo único. Abraza la esencia del otoño en cada paso.", "Entrez dans la saison avec élégance avec ces bottes stretch en cuir marron d'automne. Méticuleusement confectionnées à partir de cuir de première qualité, ces bottes offrent à la fois style et confort. La fonction extensible assure un ajustement parfait, tandis que la riche couleur marron ajoute une touche de chaleur à votre garde-robe d'automne. Parfaites pour toutes les occasions, ces bottes sont une déclaration de mode qui complète votre style unique. Embrassez l’essence de l’automne à chaque étape.", "Увійдіть у сезон з елегантністю в цих осінньо-коричневих шкіряних еластичних черевиках. Ретельно виготовлені з високоякісної шкіри, ці черевики пропонують стиль і комфорт. Еластична функція забезпечує щільне прилягання, а насичений коричневий колір додає нотку тепла у ваш осінній гардероб. Ідеально підходять для будь-якого випадку, ці черевики є модним виразом, який доповнює ваш унікальний стиль. З кожним кроком сприймайте сутність осені.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Autumn brown leather stretch boots", "Botas elásticas de piel marrón otoño", "Bottes stretch en cuir marron d'automne", "Осінні коричневі шкіряні еластичні черевики", 8899m, 4 },
                    { 3, "ER00112018", 8, 2, "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "Estro ER00112018 Botas elásticas de cuero negro\r\n\r\nEleva tu estilo otoñal con las botas elásticas de cuero negro Estro ER00112018. Confeccionadas con una mezcla de cuero de alta calidad y material elástico, estas botas combinan a la perfección moda y comodidad. El elemento elástico proporciona elasticidad, lo que garantiza un ajuste ceñido y flexible para facilitar su uso. El elegante color negro añade versatilidad y permite combinarlo sin esfuerzo con varios estilos de vestimenta.", "Estro ER00112018 Bottes stretch en cuir noir\\r\\n\\r\\nÉlevez votre style automnal avec les bottes Estro ER00112018 en cuir stretch noir. Fabriquées avec un mélange de cuir de haute qualité et de matériaux extensibles, ces bottes allient harmonieusement mode et confort. L'élément extensible offre de l'élasticité, assurant un ajustement serré et flexible pour un port facile. La couleur noire élégante ajoute de la polyvalence, permettant une association sans effort avec différents styles de tenues.", "Чорні еластичні шкіряні черевики Estro ER00112018\r\n\r\nПокращіть свій осінній стиль за допомогою чорних еластичних шкіряних черевиків Estro ER00112018. Виготовлені із суміші високоякісної шкіри та еластичного матеріалу, ці черевики ідеально поєднують моду та комфорт. Стрейчовий елемент забезпечує еластичність, забезпечуючи щільне та гнучке прилягання для легкого носіння. Гладкий чорний колір додає універсальності, дозволяючи легко поєднувати з різними стилями одягу.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Autumn leather stretch boots", "Botas elásticas de piel de otoño", "Bottes d'automne en cuir stretch", "Чоботи осінні шкіряні стрейч", 8899m, 4 },
                    { 4, "ER00112022", 8, 2, "Demi-season boots of black color made of durable shoe leather will become reliable companions in all your adventures, travels, and beautiful companions for parties with friends. Stable heels in the shape of a trapezoid - not too high, and not too low. Seven centimeters of comfort and confidence in your walk. The grooved sole will protect against any inconvenience that may occur on the way - be it dirt, gravel, cobblestones or slippery surfaces. Nothing will prevent you from feeling confident.", "Las botas de entretiempo en color negro hechas de cuero duradero para zapatos se convertirán en compañeras confiables en todas tus aventuras, viajes y hermosas compañeras para fiestas con amigos. Tacones estables en forma de trapezoide, ni demasiado altos ni demasiado bajos. Siete centímetros de comodidad y confianza en tu caminar. La suela estriada protegerá contra cualquier inconveniente que pueda surgir en el camino, ya sea tierra, grava, adoquines o superficies resbaladizas. Nada te impedirá sentirte seguro.", "Les bottes demi-saison de couleur noire en cuir de chaussure durable deviendront des compagnons fiables dans toutes vos aventures, voyages et de beaux compagnons pour les fêtes entre amis. Talons stables en forme de trapèze – ni trop hauts ni trop bas. Sept centimètres de confort et de confiance dans votre marche. La semelle rainurée protégera contre tous les désagréments pouvant survenir sur le chemin, qu'il s'agisse de saleté, de graviers, de pavés ou de surfaces glissantes. Rien ne vous empêchera de vous sentir en confiance.", "Демісезонні ботфорти чорного кольору з міцної взуттєвої шкіри стануть надійними компаньйонами у всіх ваших авантюрах, подорожах, та красивими супутниками для вечірок з друзями. Стійкі підбори у формі трапеції — не дуже високі, і не занадто низькі. Сім сантиметрів зручності та впевненості у вашій ході. Рифлена підошва захистить від будь-яких незручностей, які траплятимуться на шляху — будь-то бруд, гравій, бруківка чи слизька поверхня. Ніщо не завадить почуватись впевнено.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Boots autumn leather black", "Botas otoño cuero negro", "Bottes automne cuir noir", "Чоботи осінні шкіряні чорні", 9899m, 4 },
                    { 5, "ER00112011", 8, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Black autumn leather stretch boots", "Botas elásticas de piel de otoño negras", "Bottines stretch en cuir d'automne noires", "Чорні осінні шкіряні еластичні чоботи", 9899m, 4 },
                    { 6, "ER00113851", 8, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Black demi-season boots", "Botas negras de entretiempo", "Bottes demi-saison noires", "Чорні демісезонні черевики", 8799m, 4 },
                    { 7, "ER00112023", 8, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Boots-stockings leather black", "Botas-medias cuero negro", "Bottes-bas cuir noir", "Чоботи-панчохи шкіряні чорні", 9989m, 4 },
                    { 8, "ER00114318", 8, 5, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Boots-pipes with wide freebies", "Las botas con pipas anchas son de color", "Les bottes-pipes avec de larges cadeaux", "Черевики-дудочки з широкими халявами", 9989m, 4 },
                    { 9, "ER00112298", 8, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Black leather Cossack boots", "Botas cosacas de cuero negro", "Bottes cosaques en cuir noir", "Чорні шкіряні козацькі чоботи", 8799m, 4 },
                    { 10, "ER00112123", 8, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Boots-stockings on a stiletto are black", "Las botas-medias con tacones de aguja son negras.", "Les bottes-bas sur un talon aiguille sont noires", "Чоботи-панчохи на шпильці чорні", 8699m, 4 },
                    { 11, "ER00112122", 8, 8, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Milk stiletto stocking boots", "Botas medias con tacón de aguja color leche", "Bottes bas à talons aiguilles au lait", "Чоботи панчохи на шпильці молочного кольору", 8699m, 4 },
                    { 12, "ER00114239", 8, 4, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Boots-stockings on a stiletto are brown", "Las botas-medias con tacón de aguja son marrones", "Les bottes-bas sur un talon aiguille sont marron", "Чоботи-панчохи на шпильці коричневі", 8399m, 4 },
                    { 13, "ER00114240", 8, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Boots-stockings on a stiletto are black", "Las botas-medias con tacón de aguja son negras", "Les bottes-bas sur un talon aiguille sont noires", "Чоботи-панчохи на шпильці чорні", 8399m, 4 },
                    { 14, "ER00113949", 7, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Ankle boots are black", "Los botines son negros", "Les bottines sont noires", "Ботильйони чорні", 2890m, 4 },
                    { 15, "ER00111942", 12, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Winter boots", "Las botas de invierno son negras", "Bottes d'hiver", "Зимові черевики", 2290m, 1 }
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
                columns: new[] { "Id", "ProductId", "ProductQuantity", "Size", "SortOrder", "inStock" },
                values: new object[,]
                {
                    { 1, 1, 8, "36", 2, true },
                    { 2, 1, 20, "37", 3, true },
                    { 3, 1, 40, "38", 4, true },
                    { 4, 1, 10, "39", 5, true },
                    { 5, 1, 10, "40", 6, true },
                    { 6, 1, 10, "41", 7, true },
                    { 7, 2, 12, "36", 2, true },
                    { 8, 2, 10, "37", 3, true },
                    { 9, 2, 40, "38", 4, true },
                    { 10, 2, 30, "39", 5, true },
                    { 11, 2, 40, "40", 6, true },
                    { 12, 2, 20, "41", 7, true },
                    { 13, 3, 0, "36", 2, false },
                    { 14, 3, 1, "37", 3, true },
                    { 15, 3, 1, "38", 4, true },
                    { 16, 3, 1, "39", 5, true },
                    { 17, 3, 0, "40", 6, false },
                    { 18, 3, 0, "41", 7, false },
                    { 19, 4, 9, "36", 2, true },
                    { 20, 4, 8, "37", 3, true },
                    { 21, 4, 8, "38", 4, true },
                    { 22, 4, 0, "39", 5, false },
                    { 23, 4, 0, "40", 6, false },
                    { 24, 4, 0, "41", 7, false },
                    { 25, 5, 7, "36", 2, true },
                    { 26, 5, 0, "37", 3, false },
                    { 27, 5, 8, "38", 4, true },
                    { 28, 5, 9, "39", 5, true },
                    { 29, 5, 0, "40", 6, false },
                    { 30, 5, 0, "41", 7, false },
                    { 31, 6, 9, "36", 2, true },
                    { 32, 6, 8, "37", 3, true },
                    { 33, 6, 0, "38", 4, false },
                    { 34, 6, 0, "39", 5, false },
                    { 35, 6, 0, "40", 6, false },
                    { 36, 6, 0, "41", 7, false },
                    { 37, 7, 0, "36", 2, false },
                    { 38, 7, 8, "37", 3, true },
                    { 39, 7, 0, "38", 4, false },
                    { 40, 7, 9, "39", 5, true },
                    { 41, 7, 8, "40", 6, false },
                    { 42, 7, 0, "41", 7, false },
                    { 43, 8, 0, "36", 2, false },
                    { 44, 8, 4, "37", 3, true },
                    { 45, 8, 0, "38", 4, false },
                    { 46, 8, 8, "39", 5, true },
                    { 47, 8, 0, "40", 6, false },
                    { 48, 8, 0, "41", 7, false },
                    { 49, 9, 5, "36", 2, true },
                    { 50, 9, 0, "37", 3, false },
                    { 51, 9, 0, "38", 4, false },
                    { 52, 9, 0, "39", 5, false },
                    { 53, 9, 7, "40", 6, true },
                    { 54, 9, 0, "41", 7, false },
                    { 55, 10, 0, "36", 2, false },
                    { 56, 10, 0, "37", 3, false },
                    { 57, 10, 10, "38", 4, true },
                    { 58, 10, 10, "39", 5, true },
                    { 59, 10, 0, "40", 6, false },
                    { 60, 10, 0, "41", 7, false },
                    { 61, 11, 0, "36", 2, false },
                    { 62, 11, 10, "37", 3, true },
                    { 63, 11, 10, "38", 4, true },
                    { 64, 11, 10, "39", 5, true },
                    { 65, 11, 0, "40", 6, false },
                    { 66, 11, 0, "41", 7, false },
                    { 67, 12, 0, "36", 2, false },
                    { 68, 12, 10, "37", 3, true },
                    { 69, 12, 50, "38", 4, true },
                    { 70, 12, 10, "39", 5, true },
                    { 71, 12, 0, "40", 6, false },
                    { 72, 12, 0, "41", 7, false },
                    { 73, 13, 0, "36", 2, false },
                    { 74, 13, 0, "37", 3, false },
                    { 75, 13, 10, "38", 4, true },
                    { 76, 13, 0, "39", 5, false },
                    { 77, 13, 10, "40", 6, true },
                    { 78, 13, 0, "41", 7, false },
                    { 79, 14, 0, "36", 2, false },
                    { 80, 14, 15, "37", 3, true },
                    { 81, 14, 10, "38", 4, true },
                    { 82, 14, 10, "39", 5, true },
                    { 83, 14, 10, "40", 6, true },
                    { 84, 14, 0, "41", 7, false },
                    { 85, 15, 0, "39", 5, false },
                    { 86, 15, 15, "40", 6, true },
                    { 87, 15, 10, "41", 7, true },
                    { 88, 15, 10, "42", 8, true },
                    { 89, 15, 10, "43", 9, true },
                    { 90, 15, 0, "44", 10, false },
                    { 91, 15, 0, "45", 11, false },
                    { 92, 15, 0, "46", 12, false }
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
                name: "IX_ProductColor_InfoId",
                table: "ProductColor",
                column: "InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterial_InfoId",
                table: "ProductMaterial",
                column: "InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorId",
                table: "Products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MaterialId",
                table: "Products",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SeasonId",
                table: "Products",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSeason_InfoId",
                table: "ProductSeason",
                column: "InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_InfoId",
                table: "ProductSize",
                column: "InfoId");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserProductReview_ProductId",
                table: "UserProductReview",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProductReview_UserId",
                table: "UserProductReview",
                column: "UserId");
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
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "UserBonuses");

            migrationBuilder.DropTable(
                name: "UserFavoriteProduct");

            migrationBuilder.DropTable(
                name: "UserProductReview");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Bag");

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
                name: "ProductColor");

            migrationBuilder.DropTable(
                name: "ProductMaterial");

            migrationBuilder.DropTable(
                name: "ProductSeason");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Info");

            migrationBuilder.DropTable(
                name: "MainCategories");
        }
    }
}
