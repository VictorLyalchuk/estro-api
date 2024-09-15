﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
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
                    Description_en = table.Column<string>(type: "text", nullable: true),
                    Description_uk = table.Column<string>(type: "text", nullable: true),
                    Description_es = table.Column<string>(type: "text", nullable: true),
                    Description_fr = table.Column<string>(type: "text", nullable: true),
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
                    Description_en = table.Column<string>(type: "text", nullable: true),
                    Description_uk = table.Column<string>(type: "text", nullable: true),
                    Description_es = table.Column<string>(type: "text", nullable: true),
                    Description_fr = table.Column<string>(type: "text", nullable: true),
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
                    OrderPaymentId = table.Column<int>(type: "integer", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_OrderPayment_OrderPaymentId",
                        column: x => x.OrderPaymentId,
                        principalTable: "OrderPayment",
                        principalColumn: "Id");
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
                    { 12, "Chernivtsi", "Tchernivtsi", "Tchernivtsi", "Чернівці", 1 },
                    { 13, "London", "Londres", "Londres", "Лондон", 2 },
                    { 14, "Madrid", "Madrid", "Madrid", "Мадрид", 3 },
                    { 15, "Barcelona", "Barcelona", "Barcelone", "Барселона", 3 },
                    { 16, "Valencia", "Valencia", "Valence", "Валенсія", 3 },
                    { 17, "Seville", "Sevilla", "Séville", "Севілья", 3 },
                    { 18, "Bilbao", "Bilbao", "Bilbao", "Більбао", 3 },
                    { 19, "Granada", "Granada", "Grenade", "Гранада", 3 },
                    { 20, "Málaga", "Málaga", "Málaga", "Малага", 3 },
                    { 21, "Paris", "París", "Paris", "Париж", 4 },
                    { 22, "Lyon", "Lyon", "Lyon", "Ліон", 4 },
                    { 23, "Marseille", "Marsella", "Marseille", "Марсель", 4 },
                    { 24, "Toulouse", "Toulouse", "Toulouse", "Тулуза", 4 },
                    { 25, "Nice", "Niza", "Nice", "Ніцца", 4 },
                    { 26, "Bordeaux", "Burdeos", "Bordeaux", "Бордо", 4 },
                    { 27, "Lille", "Lille", "Lille", "Лілль", 4 },
                    { 28, "Warsaw", "Varsovia", "Varsovie", "Варшава", 5 },
                    { 29, "Kraków", "Cracovia", "Cracovie", "Краків", 5 },
                    { 30, "Gdańsk", "Gdansk", "Gdańsk", "Гданськ", 5 },
                    { 31, "Wrocław", "Breslavia", "Wrocław", "Вроцлав", 5 },
                    { 32, "Poznań", "Poznan", "Poznań", "Познань", 5 },
                    { 33, "Łódź", "Łódź", "Łódź", "Лодзь", 5 },
                    { 34, "Szczecin", "Szczecin", "Szczecin", "Щецин", 5 },
                    { 35, "New York", "Nueva York", "New York", "Нью-Йорк", 6 },
                    { 36, "Los Angeles", "Los Ángeles", "Los Angeles", "Лос-Анджелес", 6 },
                    { 37, "Chicago", "Chicago", "Chicago", "Чикаго", 6 },
                    { 38, "Houston", "Houston", "Houston", "Г'юстон", 6 },
                    { 39, "Phoenix", "Phoenix", "Phoenix", "Фінікс", 6 },
                    { 40, "Philadelphia", "Filadelfia", "Philadelphie", "Філадельфія", 6 },
                    { 41, "Miami", "Miami", "Miami", "Маямі", 6 },
                    { 42, "Tokyo", "Tokio", "Tokyo", "Токіо", 7 },
                    { 43, "Osaka", "Osaka", "Osaka", "Осака", 7 },
                    { 44, "Kyoto", "Kioto", "Kyoto", "Кіото", 7 },
                    { 45, "Yokohama", "Yokohama", "Yokohama", "Йокогама", 7 },
                    { 46, "Nagoya", "Nagoya", "Nagoya", "Нагоя", 7 },
                    { 47, "Fukuoka", "Fukuoka", "Fukuoka", "Фукуока", 7 },
                    { 48, "Hiroshima", "Hiroshima", "Hiroshima", "Хіросіма", 7 },
                    { 49, "Manchester", "Mánchester", "Manchester", "Манчестер", 2 },
                    { 50, "Birmingham", "Birmingham", "Birmingham", "Бірмінгем", 2 },
                    { 51, "Liverpool", "Liverpool", "Liverpool", "Ліверпуль", 2 },
                    { 52, "Leeds", "Leeds", "Leeds", "Лідс", 2 },
                    { 53, "Bristol", "Bristol", "Bristol", "Бристоль", 2 },
                    { 54, "Newcastle", "Newcastle", "Newcastle", "Ньюкасл", 2 }
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
                    { 9, 1, "Pink", "Rosa", "Rose", "Рожевий", "pink" },
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
                    { 6, 2, "Textile", "Textil", "Textile", "Текстиль", "textile" },
                    { 7, 2, "Polyester", "Polyester", "Polyester", "Поліестер", "polyester" }
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
                    { 18, 3, "XXL", "XXL", "XXL", "XXL", 18, "XXL" },
                    { 19, 3, "One Size", "One Size", "One Size", "One Size", 19, "OneSize" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Description_en", "Description_es", "Description_fr", "Description_uk", "ImagePath", "MainCategoryId", "Name_en", "Name_es", "Name_fr", "Name_uk", "URLName" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, 1, "Women's Shoes", "Zapatos de mujer", "Chaussures pour femmes", "Жіноче взуття", "woman-shoes" },
                    { 2, null, null, null, null, null, 2, "Men's Shoes", "Zapatos de hombre", "Chaussures pour hommes", "Чоловіче взуття", "man-shoes" },
                    { 3, null, null, null, null, null, 1, "Women's Clothing", "Ropa de mujer", "Vêtements pour femmes", "Жіночий одяг", "woman-clothing" },
                    { 4, null, null, null, null, null, 2, "Men's Clothing", "Ropa de hombre", "Vêtements pour hommes", "Чоловічий одяг", "man-clothing" },
                    { 5, null, null, null, null, null, 1, "Women's Accessories", "Accesorios de mujer", "Accessoires pour femmes", "Жіночі аксесуари", "woman-accessories" },
                    { 6, null, null, null, null, null, 2, "Men's Accessories", "Accesorios de hombre", "Accessoires pour hommes", "Чоловічі аксесуари", "man-accessories" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description_en", "Description_es", "Description_fr", "Description_uk", "ImagePath", "Name_en", "Name_es", "Name_fr", "Name_uk", "SubCategoryId", "URLName" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, "Open shoes", "Zapatos abiertos", "Chaussures ouvertes", "Відкрите взуття", 1, "open-shoes" },
                    { 2, null, null, null, null, null, "Pumps and loafers", "Zapatos de tacón y mocasines", "Escarpins et mocassins", "Туфлі та лофери", 1, "pumps-and-loafers" },
                    { 3, null, null, null, null, null, "Heeled shoes", "Zapatos de tacón", "Chaussures à talons", "Туфлі на підборах", 1, "heeled-shoes" },
                    { 4, null, null, null, null, null, "Women's athletic sneakers", "Zapatillas deportivas para mujeres", "Baskets de sport pour femmes", "Кросівки жіночі", 1, "women-s-athletic-sneakers" },
                    { 5, null, null, null, null, null, "Women's sneakers", "Zapatillas para mujeres", "Baskets pour femmes", "Жіночі кеди", 1, "women-sneakers" },
                    { 6, null, null, null, null, null, "High boots and Chelsea", "Botas altas y Chelsea", "Bottes hautes et Chelsea", "Високі черевики, челсі", 1, "high-boots-&-chelsea" },
                    { 7, null, null, null, null, null, "Boots on heels", "Botas de tacón", "Bottes à talons", "Черевики на підборах", 1, "boots-on-heels" },
                    { 8, null, null, null, null, null, "Boots and high boots", "Botas y botas altas", "Bottes et bottes hautes", "Чоботи та ботфорти", 1, "boots-and-high-boots" },
                    { 9, null, null, null, null, null, "Cossacks boots", "Botas de cosaco", "Bottes Cossacks", "Козаки", 1, "cossacks-boots" },
                    { 10, null, null, null, null, null, "Winter footwear", "Calzado de invierno", "Chaussures d'hiver", "Зимове взуття", 1, "winter-footwear" },
                    { 11, null, null, null, null, null, "Perforated shoes", "Zapatos perforados", "Chaussures perforées", "Перфороване взуття", 1, "perforated-shoes" },
                    { 12, null, null, null, null, null, "Men's boots", "Botas para hombres", "Bottes pour hommes", "Чоловічі черевики", 2, "men-boots" },
                    { 13, null, null, null, null, null, "Men's athletic sneakers", "Zapatillas deportivas para hombres", "Baskets de sport pour hommes", "Чоловічі кросівки", 2, "man-athletic-sneakers" },
                    { 14, null, null, null, null, null, "Men's sneakers", "Zapatillas para hombres", "Baskets pour hommes", "Чоловічі кеди", 2, "man-sneakers" },
                    { 15, null, null, null, null, null, "Men's pumps", "Zapatos de tacón para hombres", "Escarpins pour hommes", "Чоловічі туфлі", 2, "man-pumps" },
                    { 16, null, null, null, null, null, "Men's moccasins", "Mocasines para hombres", "Mocassins pour hommes", "Чоловічі мокасини", 2, "man-moccasins" },
                    { 17, null, null, null, null, null, "Men's summer shoes", "Zapatos de verano para hombres", "Chaussures d'été pour hommes", "Чоловічі літнє взуття", 2, "man-summer-shoes" },
                    { 18, null, null, null, null, null, "Women's outerwear", "Ropa exterior para mujeres", "Vêtements d'extérieur pour femmes", "Жіночий верхній одяг", 3, "woman-outerwear" },
                    { 19, null, null, null, null, null, "Women's sweaters and suits", "Suéteres y trajes para mujeres", "Pulls et costumes pour femmes", "Жіночі светри та костюми", 3, "woman-sweaters-and-suits" },
                    { 20, null, null, null, null, null, "Women's t-shirts and sweatshirts", "Camisetas y sudaderas para mujeres", "T-shirts et sweatshirts pour femmes", "Жіночі футболки та світшоти", 3, "woman-t-shirts-and-sweatshirts" },
                    { 21, null, null, null, null, null, "Women's shawl", "Chal para mujeres", "Châle pour femmes", "Жіночі хустки", 3, "woman-shawl" },
                    { 22, null, null, null, null, null, "Women's scarves and hats", "Bufandas y sombreros para mujeres", "Écharpes et chapeaux pour femmes", "Жіночі шарфи та шапки", 3, "woman-scarves-and-hats" },
                    { 23, null, null, null, null, null, "Women's gloves", "Guantes para mujeres", "Gants pour femmes", "Жіночі рукавички", 3, "woman-gloves" },
                    { 24, null, null, null, null, null, "Women's socks and tights", "Calcetines y pantimedias para mujeres", "Chaussettes et collants pour femmes", "Жіночі шкарпетки та колготи", 3, "woman-socks-and-tights" },
                    { 25, null, null, null, null, null, "Men's outerwear", "Ropa exterior para hombres", "Vêtements d'extérieur pour hommes", "Чоловічий верхній одяг", 4, "man-outerwear" },
                    { 26, null, null, null, null, null, "Men's sweaters and suits", "Suéteres y trajes para hombres", "Pulls et costumes pour hommes", "Чоловічі светри та костюми", 4, "man-sweaters-and-suits" },
                    { 27, null, null, null, null, null, "Men's t-shirts and sweatshirts", "Camisetas y sudaderas para hombres", "T-shirts et sweatshirts pour hommes", "Чоловікі футболки та світшоти", 4, "man-t-shirts-and-sweatshirts" },
                    { 28, null, null, null, null, null, "Men's scarves and hats", "Bufandas y sombreros para hombres", "Écharpes et chapeaux pour hommes", "Чоловічі шарфи та шапки", 4, "man-scarves-and-hats" },
                    { 29, null, null, null, null, null, "Men's gloves", "Guantes para hombres", "Gants pour hommes", "Чоловічі рукавички", 4, "man-gloves" },
                    { 30, null, null, null, null, null, "Men's socks", "Calcetines para hombres", "Chaussettes pour hommes", "Чоловічі шкарпетки", 4, "man-socks" },
                    { 31, null, null, null, null, null, "Women's glasses", "Gafas para mujeres", "Lunettes pour femmes", "Жіночі окуляри", 5, "woman-glasses" },
                    { 32, null, null, null, null, null, "Women's home shoes", "Zapatos de casa para mujeres", "Chaussures de maison pour femmes", "Жіноче домашнє взуття", 5, "woman-home-shoes" },
                    { 33, null, null, null, null, null, "Women's bags", "Bolsos para mujeres", "Sacs pour femmes", "Жіночі сумки", 5, "woman-bags" },
                    { 34, null, null, null, null, null, "Women's backpacks", "Mochilas para mujeres", "Sacs à dos pour femmes", "Жіночі рюкзаки для жінок", 5, "woman-backpacks" },
                    { 35, null, null, null, null, null, "Women's care products", "Productos de cuidado para mujeres", "Produits de soin pour femmes", "Жіночі засоби для догляду", 5, "woman-care-products" },
                    { 36, null, null, null, null, null, "Men's glasses", "Gafas para hombres", "Lunettes pour hommes", "Чоловічі окуляри", 6, "man-glasses" },
                    { 37, null, null, null, null, null, "Men's home shoes", "Zapatos de casa para hombres", "Chaussures de maison pour hommes", "Чоловіче домашнє взуття", 6, "man-home-shoes" },
                    { 38, null, null, null, null, null, "Men's bags", "Bolsos para hombres", "Sacs pour hommes", "Чоловічі сумки", 6, "man-bags" },
                    { 39, null, null, null, null, null, "Men's backpacks", "Mochilas para hombres", "Sacs à dos pour hommes", "Чоловічі рюкзаки", 6, "man-backpacks" },
                    { 40, null, null, null, null, null, "Men's care products", "Productos de cuidado para hombres", "Produits de soin pour hommes", "Чоловічі засоби для догляду", 6, "man-care-products" }
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
                    { 29, "265A Haharina, First Floor", "Calle Haharina, 265A, Primer Piso", "Rue Haharina, 265A, Premier étage", "вул. Гагаріна, 265А, перший поверх", 12, "Link to map", "DEPO't Center Shopping Mall", "DEPO't Center Centro Comercial", "DEPO't Center Centre Commercial", "ТЦ Депо", "10:00 - 20:00" },
                    { 30, "Ariel Way, Shepherd's Bush", "Calle Ariel, Shepherd's Bush", "Rue Ariel, Shepherd's Bush", "вул. Аріель, Шепердс Буш", 13, "Link to map", "Westfield London", "Westfield Londres", "Westfield Londres", "Вестфілд Лондон", "10:00 - 22:00" },
                    { 31, "87-135 Brompton Road", "Calle Brompton, 87-135", "Rue Brompton, 87-135", "вул. Бромптон, 87-135", 13, "Link to map", "Harrods", "Harrods", "Harrods", "Гарродс", "10:00 - 21:00" },
                    { 32, "400 Oxford Street", "Calle Oxford, 400", "Rue Oxford, 400", "вул. Оксфорд, 400", 13, "Link to map", "Selfridges", "Selfridges", "Selfridges", "Селфріджес", "09:30 - 22:00" },
                    { 33, "Market Street", "Calle Market", "Rue Market", "вул. Маркет", 49, "Link to map", "Manchester Arndale", "Manchester Arndale", "Manchester Arndale", "Манчестер Арндейл", "09:00 - 20:00" },
                    { 34, "Stretford", "Stretford", "Stretford", "Стретфорд", 49, "Link to map", "Trafford Centre", "Centro Trafford", "Centre Trafford", "ТЦ Траффорд", "10:00 - 22:00" },
                    { 35, "Spinningfields", "Spinningfields", "Spinningfields", "Спінінгфілдс", 49, "Link to map", "The Avenue", "La Avenida", "L'Avenue", "Авеню", "10:00 - 20:00" },
                    { 36, "Moor Street", "Calle Moor", "Rue Moor", "вул. Мур", 50, "Link to map", "Bullring & Grand Central", "Bullring y Grand Central", "Bullring et Grand Central", "Буллрінг і Гранд Централ", "10:00 - 21:00" },
                    { 37, "Wharfside Street", "Calle Wharfside", "Rue Wharfside", "вул. Уорфсайд", 50, "Link to map", "Mailbox Birmingham", "Mailbox Birmingham", "Mailbox Birmingham", "Мейлбокс Бірмінгем", "10:00 - 20:00" },
                    { 38, "New Street Station", "Estación de la Calle Nueva", "Gare de New Street", "Нова вулиця, Станція", 50, "Link to map", "Grand Central", "Gran Central", "Grand Central", "Гранд Централ", "10:00 - 20:00" },
                    { 39, "5 Wall Street", "Calle Wall, 5", "Rue Wall, 5", "вул. Волл, 5", 51, "Link to map", "Liverpool ONE", "Liverpool Uno", "Liverpool Un", "Ліверпуль Ван", "10:00 - 20:00" },
                    { 40, "35 Whitechapel", "Calle Whitechapel, 35", "Rue Whitechapel, 35", "вул. Вайтчепел, 35", 51, "Link to map", "Metquarter", "Metquarter", "Metquarter", "Метквотер", "09:00 - 19:00" },
                    { 41, "St George's Place", "Plaza de St George", "Place St George", "місце Сент Джордж", 51, "Link to map", "St Johns Shopping Centre", "Centro Comercial St Johns", "Centre Commercial St Johns", "ТЦ Сент Джонс", "09:00 - 18:00" },
                    { 42, "Albion Street", "Calle Albion", "Rue Albion", "вул. Альбіон", 52, "Link to map", "Trinity Leeds", "Trinidad Leeds", "Trinité Leeds", "Триніті Лідс", "09:00 - 20:00" },
                    { 43, "George Street", "Calle George", "Rue George", "вул. Джордж", 52, "Link to map", "Victoria Leeds", "Victoria Leeds", "Victoria Leeds", "Вікторія Лідс", "09:00 - 19:00" },
                    { 44, "Lands Lane", "Calle Lands", "Rue Lands", "вул. Лендс", 52, "Link to map", "The Core Shopping Centre", "Centro Comercial The Core", "Centre Commercial The Core", "ТЦ Кор", "09:00 - 18:00" },
                    { 45, "Glass House", "Casa de Cristal", "Maison de Verre", "Скляний будинок", 53, "Link to map", "Cabot Circus", "Circo Cabot", "Cirque Cabot", "Кабот Циркус", "10:00 - 20:00" },
                    { 46, "Broadmead", "Broadmead", "Broadmead", "Бродмід", 53, "Link to map", "The Galleries", "Las Galerías", "Les Galeries", "Галереї", "09:00 - 18:00" },
                    { 47, "Cribbs Causeway", "Cribbs Causeway", "Cribbs Causeway", "Крибс Козвей", 53, "Link to map", "The Mall at Cribbs Causeway", "El Centro Comercial en Cribbs Causeway", "Le Centre Commercial à Cribbs Causeway", "ТЦ Крибс Козвей", "10:00 - 22:00" },
                    { 48, "Blackettbridge", "Puente de Blackett", "Pont de Blackett", "Блакеттібридж", 54, "Link to map", "Eldon Square", "Plaza Eldon", "Place Eldon", "Площа Елдон", "09:00 - 20:00" },
                    { 49, "Gateshead", "Gateshead", "Gateshead", "Гейтсхед", 54, "Link to map", "Metrocentre", "Centro Metro", "Centre Metro", "Метроцентр", "10:00 - 22:00" },
                    { 50, "Grainger Street", "Calle Grainger", "Rue Grainger", "вул. Грейнджер", 54, "Link to map", "Grainger Market", "Mercado Grainger", "Marché Grainger", "Ринок Грейнджер", "09:00 - 17:30" },
                    { 51, "Calle Menorca, 19", "Calle Menorca, 19", "Rue Menorca, 19", "вул. Менорка, 19", 16, "Link to map", "Centro Comercial Aqua", "Centro Comercial Aqua", "Centre Commercial Aqua", "ТЦ Аква", "10:00 - 22:00" },
                    { 52, "Calle de la Constitución, 4", "Calle de la Constitución, 4", "Rue de la Constitution, 4", "вул. Конституції, 4", 16, "Link to map", "Gran Turia", "Gran Turia", "Gran Turia", "Гран Турія", "10:00 - 21:00" },
                    { 53, "Avenida de la Constitución, 8", "Avenida de la Constitución, 8", "Avenue de la Constitution, 8", "ав. Конституції, 8", 17, "Link to map", "El Corte Inglés", "El Corte Inglés", "El Corte Inglés", "Ель Кортé Інґлés", "10:00 - 21:00" },
                    { 54, "Calle de las Armas, 5", "Calle de las Armas, 5", "Rue des Armes, 5", "вул. Армас, 5", 17, "Link to map", "Plaza de Armas", "Plaza de Armas", "Place des Armes", "Площа Армас", "10:00 - 20:00" },
                    { 55, "Gran Vía 74", "Gran Vía 74", "Gran Vía 74", "Гран Віа, 74", 18, "Link to map", "Zubiarte", "Zubiarte", "Zubiarte", "Зубіарт", "10:00 - 21:00" },
                    { 56, "Calle de Evaristo Churruca, 13", "Calle de Evaristo Churruca, 13", "Rue Evaristo Churruca, 13", "вул. Еварісто Чуррука, 13", 18, "Link to map", "El Corte Inglés", "El Corte Inglés", "El Corte Inglés", "Ель Кортé Інґлés", "10:00 - 21:00" },
                    { 57, "Calle de la Alegría, 1", "Calle de la Alegría, 1", "Rue de l'Allégresse, 1", "вул. Радості, 1", 19, "Link to map", "Centro Comercial Serrallo Plaza", "Centro Comercial Serrallo Plaza", "Centre Commercial Serrallo Plaza", "ТЦ Серрало Плаза", "10:00 - 21:00" },
                    { 58, "Calle del Sur, 4", "Calle del Sur, 4", "Rue du Sud, 4", "вул. Південь, 4", 19, "Link to map", "Centro Comercial Granada", "Centro Comercial Granada", "Centre Commercial Granada", "ТЦ Гранада", "10:00 - 21:00" },
                    { 59, "Calle Compositor Rodríguez Cerní, 8", "Calle Compositor Rodríguez Cerní, 8", "Rue Compositeur Rodríguez Cerní, 8", "вул. Композитор Родрігес Серні, 8", 20, "Link to map", "Centro Comercial Larios", "Centro Comercial Larios", "Centre Commercial Larios", "ТЦ Ларіос", "10:00 - 22:00" },
                    { 60, "Avenida de la Estación, 5", "Avenida de la Estación, 5", "Avenue de la Gare, 5", "ав. Станція, 5", 20, "Link to map", "Vialia Málaga", "Vialia Málaga", "Vialia Málaga", "Віалія Малага", "10:00 - 21:00" },
                    { 61, "9 Quai du Lazaret", "9 Quai du Lazaret", "9 Quai du Lazaret", "9 набережна Лазарет", 23, "Link to map", "Les Terrasses du Port", "Les Terrasses du Port", "Les Terrasses du Port", "Ле Террас ду Порт", "10:00 - 20:00" },
                    { 62, "Cours Belsunce, 4", "Cours Belsunce, 4", "Cours Belsunce, 4", "Курс Бельсюнс, 4", 23, "Link to map", "Centre Bourse", "Centre Bourse", "Centre Bourse", "Центр Бурс", "10:00 - 20:00" },
                    { 63, "Avenue du Général de Gaulle, 1", "Avenue du Général de Gaulle, 1", "Avenue du Général de Gaulle, 1", "ав. Ж.-Де-Ґолля, 1", 24, "Link to map", "Centre Commercial Toulouse Portet-sur-Garonne", "Centre Commercial Toulouse Portet-sur-Garonne", "Centre Commercial Toulouse Portet-sur-Garonne", "ТЦ Тулуз Порте-сюр-Гарон", "10:00 - 20:00" },
                    { 64, "Boulevard de Strasbourg, 40", "Boulevard de Strasbourg, 40", "Boulevard de Strasbourg, 40", "бульвар Страсбург, 40", 24, "Link to map", "Galeries Lafayette Toulouse", "Galerías Lafayette Toulouse", "Galeries Lafayette Toulouse", "Галері Лафайєт Тулуз", "10:00 - 19:00" },
                    { 65, "Avenue des Louvans, 220", "Avenue des Louvans, 220", "Avenue des Louvans, 220", "ав. Лу́ванс, 220", 25, "Link to map", "Cap3000", "Cap3000", "Cap3000", "Кап3000", "10:00 - 21:00" },
                    { 66, "Avenue Jean Médecin, 30", "Avenue Jean Médecin, 30", "Avenue Jean Médecin, 30", "ав. Жан Медсін, 30", 25, "Link to map", "Centre Commercial Nice Etoile", "Centre Commercial Nice Etoile", "Centre Commercial Nice Etoile", "ТЦ Ніцца Етюаль", "10:00 - 20:00" },
                    { 67, "Złota 59", "Złota 59", "Złota 59", "вул. Злотa, 59", 28, "Link to map", "Złote Tarasy", "Złote Tarasy", "Złote Tarasy", "Злоті Тараси", "10:00 - 21:00" },
                    { 68, "Emilii Plater 54", "Emilii Plater 54", "Emilii Plater 54", "вул. Емілії Платер, 54", 28, "Link to map", "Arkadia", "Arkadia", "Arkadia", "Аркадія", "10:00 - 22:00" },
                    { 69, "Pawia 5", "Pawia 5", "Pawia 5", "вул. Пава, 5", 29, "Link to map", "Galeria Krakowska", "Galería Krakowska", "Galeria Krakowska", "Галерея Краківська", "10:00 - 21:00" },
                    { 70, "Podgórska 34", "Podgórska 34", "Podgórska 34", "вул. Подгурська, 34", 29, "Link to map", "Galeria Kazimierz", "Galería Kazimierz", "Galeria Kazimierz", "Галерея Казімєж", "10:00 - 20:00" },
                    { 71, "151 W 34th St", "151 W 34th St", "151 W 34th St", "151 В 34-й вулиці", 35, "Link to map", "Macy's Herald Square", "Macy's Herald Square", "Macy's Herald Square", "Мейсіс Хералд Сквер", "10:00 - 21:00" },
                    { 72, "10 Columbus Cir", "10 Columbus Cir", "10 Columbus Cir", "10 Колумбус Кіркл", 35, "Link to map", "The Shops at Columbus Circle", "The Shops at Columbus Circle", "The Shops at Columbus Circle", "Магазини на Колумбус Серкл", "10:00 - 20:00" },
                    { 73, "189 The Grove Dr", "189 The Grove Dr", "189 The Grove Dr", "189 Гров Др", 36, "Link to map", "The Grove", "The Grove", "The Grove", "Гров", "10:00 - 22:00" },
                    { 74, "6801 Hollywood Blvd", "6801 Hollywood Blvd", "6801 Hollywood Blvd", "6801 Голлівуд Блвд", 36, "Link to map", "Hollywood & Highland Center", "Hollywood & Highland Center", "Hollywood & Highland Center", "Голлівуд і Хайленд Центр", "10:00 - 21:00" },
                    { 75, "835 N Michigan Ave", "835 N Michigan Ave", "835 N Michigan Ave", "835 Н Мічиган Авеню", 37, "Link to map", "Water Tower Place", "Water Tower Place", "Water Tower Place", "Ватер Тауер Плейс", "10:00 - 21:00" },
                    { 76, "520 N Michigan Ave", "520 N Michigan Ave", "520 N Michigan Ave", "520 Н Мічиган Авеню", 37, "Link to map", "The Shops at Northbridge", "The Shops at Northbridge", "The Shops at Northbridge", "Магазини на Нортбридж", "10:00 - 20:00" },
                    { 77, "5085 Westheimer Rd", "5085 Westheimer Rd", "5085 Westheimer Rd", "5085 Вестгеймер Рд", 38, "Link to map", "The Galleria", "The Galleria", "The Galleria", "Галерея", "10:00 - 21:00" },
                    { 78, "29300 Hempstead Rd", "29300 Hempstead Rd", "29300 Hempstead Rd", "29300 Хемпстед Рд", 38, "Link to map", "Houston Premium Outlets", "Houston Premium Outlets", "Houston Premium Outlets", "Х'юстон Преміум Аутлетс", "10:00 - 21:00" },
                    { 79, "21001 N Tatum Blvd", "21001 N Tatum Blvd", "21001 N Tatum Blvd", "21001 Н Татум Блвд", 39, "Link to map", "Desert Ridge Marketplace", "Desert Ridge Marketplace", "Desert Ridge Marketplace", "Дезерт Ридж Маркетплейс", "10:00 - 22:00" },
                    { 80, "2502 E Camelback Rd", "2502 E Camelback Rd", "2502 E Camelback Rd", "2502 Е Камелбек Рд", 39, "Link to map", "Biltmore Fashion Park", "Biltmore Fashion Park", "Biltmore Fashion Park", "Білтмор Фешн Парк", "10:00 - 21:00" },
                    { 81, "9-7-1 Akasaka", "9-7-1 Akasaka", "9-7-1 Akasaka", "9-7-1 Акасака", 42, "Link to map", "Tokyo Midtown", "Tokyo Midtown", "Tokyo Midtown", "Токіо Мідтаун", "10:00 - 21:00" },
                    { 82, "2-29-1 Shibuya", "2-29-1 Shibuya", "2-29-1 Shibuya", "2-29-1 Сібуя", 42, "Link to map", "Shibuya 109", "Shibuya 109", "Shibuya 109", "Сібуя 109", "10:00 - 21:00" },
                    { 83, "2-10-70 Namba", "2-10-70 Namba", "2-10-70 Namba", "2-10-70 Намба", 43, "Link to map", "Namba Parks", "Namba Parks", "Namba Parks", "Намба Паркс", "10:00 - 21:00" },
                    { 84, "8-7 Kakudacho", "8-7 Kakudacho", "8-7 Kakudacho", "8-7 Какудачо", 43, "Link to map", "Hankyu Umeda Main Store", "Hankyu Umeda Main Store", "Hankyu Umeda Main Store", "Ханкю Умеда Головний Магазин", "10:00 - 20:00" },
                    { 85, "721-1 Higashishiokoji", "721-1 Higashishiokoji", "721-1 Higashishiokoji", "721-1 Хіґашісіокоджі", 44, "Link to map", "Kyoto Tower Sando", "Kyoto Tower Sando", "Kyoto Tower Sando", "Кіото Тауер Сандо", "10:00 - 19:00" },
                    { 86, "Karasuma-dori", "Karasuma-dori", "Karasuma-dori", "Карасума-дорі", 44, "Link to map", "Kyoto Station Building", "Kyoto Station Building", "Kyoto Station Building", "Будівля Кіото Станції", "10:00 - 21:00" },
                    { 87, "1-1-1 Sakuragicho", "1-1-1 Sakuragicho", "1-1-1 Sakuragicho", "1-1-1 Сакурагічо", 45, "Link to map", "Mark IS Yokohama", "Mark IS Yokohama", "Mark IS Yokohama", "Маркуй ІС Йокогама", "10:00 - 21:00" },
                    { 88, "1-10 Shinko", "1-10 Shinko", "1-10 Shinko", "1-10 Шінко", 45, "Link to map", "Yokohama Bay Quarter", "Yokohama Bay Quarter", "Yokohama Bay Quarter", "Йокогама Бей Кварт", "10:00 - 20:00" },
                    { 89, "4-7-1 Meieki", "4-7-1 Meieki", "4-7-1 Meieki", "4-7-1 Меєкі", 46, "Link to map", "Nagoya Midland Square", "Nagoya Midland Square", "Nagoya Midland Square", "Нагоя Мідленд Сквер", "10:00 - 21:00" },
                    { 90, "1-1-1 Meieki", "1-1-1 Meieki", "1-1-1 Meieki", "1-1-1 Меєкі", 46, "Link to map", "JR Nagoya Takashimaya", "JR Nagoya Takashimaya", "JR Nagoya Takashimaya", "JR Нагоя Такашімайа", "10:00 - 20:00" },
                    { 91, "1-2 Sumiyoshi", "1-2 Sumiyoshi", "1-2 Sumiyoshi", "1-2 Сумійосі", 47, "Link to map", "Canal City Hakata", "Canal City Hakata", "Canal City Hakata", "Канал Сіті Хаката", "10:00 - 21:00" },
                    { 92, "1-1 Hakataekimae", "1-1 Hakataekimae", "1-1 Hakataekimae", "1-1 Хакатаекімае", 47, "Link to map", "Hakata Station Building", "Hakata Station Building", "Hakata Station Building", "Будівля Хаката Станції", "10:00 - 20:00" },
                    { 93, "6-27 Motomachi", "6-27 Motomachi", "6-27 Motomachi", "6-27 Мотомачі", 48, "Link to map", "Sogo Hiroshima", "Sogo Hiroshima", "Sogo Hiroshima", "Сого Хіросіма", "10:00 - 20:00" },
                    { 94, "10-1 Hondori", "10-1 Hondori", "10-1 Hondori", "10-1 Хондорі", 48, "Link to map", "Hiroshima Parco", "Hiroshima Parco", "Hiroshima Parco", "Хіросіма Парк", "10:00 - 21:00" },
                    { 95, "140 Avenue des Champs-Élysées", "140 Avenida de los Campos Elíseos", "140 Avenue des Champs-Élysées", "140 Авеню де Шампс-Елізе", 21, "Link to map", "Champs-Élysées Flagship", "Champs-Élysées Flagship", "Champs-Élysées Flagship", "Флагман на Шампс-Елізе", "10:00 - 21:00" },
                    { 96, "40 Boulevard Haussmann", "40 Boulevard Haussmann", "40 Boulevard Haussmann", "40 Булевард Осман", 21, "Link to map", "Galeries Lafayette", "Galeries Lafayette", "Galeries Lafayette", "Галері Лафайєт", "09:30 - 20:30" },
                    { 97, "17 Rue du Dr Bouchut", "17 Rue du Dr Bouchut", "17 Rue du Dr Bouchut", "17 Рю дю Доктор Бушу", 22, "Link to map", "La Part-Dieu", "La Part-Dieu", "La Part-Dieu", "Ла Парт-Дьє", "10:00 - 20:00" },
                    { 98, "112 Cour Suchet", "112 Cour Suchet", "112 Cour Suchet", "112 Кур Сюше", 22, "Link to map", "Confluence", "Confluence", "Confluence", "Конфлюенс", "10:00 - 21:00" },
                    { 99, "2 Place des Grands Hommes", "2 Plaza de los Grandes Hombres", "2 Place des Grands Hommes", "2 Плейс дез Гран Ом", 26, "Link to map", "Les Grands Hommes", "Les Grands Hommes", "Les Grands Hommes", "Ле Гран Ом", "10:00 - 19:00" },
                    { 100, "15 Cours du Médoc", "15 Cours du Médoc", "15 Cours du Médoc", "15 Кур дю Медок", 26, "Link to map", "Mériadeck", "Mériadeck", "Mériadeck", "Меріадек", "10:00 - 20:00" },
                    { 101, "2 Rue du Maréchal Foch", "2 Rue du Maréchal Foch", "2 Rue du Maréchal Foch", "2 Рю дю Марешаль Фош", 27, "Link to map", "Euralille", "Euralille", "Euralille", "Еураліль", "10:00 - 20:00" },
                    { 102, "1 Boulevard des Cités-Unies", "1 Boulevard des Cités-Unies", "1 Boulevard des Cités-Unies", "1 Булевард дез Сіте-Юні", 27, "Link to map", "Lille Grand Palais", "Lille Grand Palais", "Lille Grand Palais", "Лілль Гранд Пале", "10:00 - 19:00" },
                    { 103, "1a Targ Sienny", "1a Targ Sienny", "1a Targ Sienny", "1a Тарг Сенні", 30, "Link to map", "Forum Gdańsk", "Forum Gdańsk", "Forum Gdańsk", "Форум Гданськ", "10:00 - 21:00" },
                    { 104, "al. Grunwaldzka 141", "al. Grunwaldzka 141", "al. Grunwaldzka 141", "ал. Грунвальдська 141", 30, "Link to map", "Galeria Bałtycka", "Galeria Bałtycka", "Galeria Bałtycka", "Галерея Балтійська", "10:00 - 21:00" },
                    { 105, "ul. Karskiego 5", "ul. Karskiego 5", "ul. Karskiego 5", "ул. Карського 5", 33, "Link to map", "Manufaktura", "Manufaktura", "Manufaktura", "Маніфактура", "10:00 - 21:00" },
                    { 106, "ul. Piłsudskiego 15", "ul. Piłsudskiego 15", "ul. Piłsudskiego 15", "ул. Пілсудського 15", 33, "Link to map", "Galeria Łódzka", "Galeria Łódzka", "Galeria Łódzka", "Галерея Лодзька", "10:00 - 20:00" },
                    { 107, "ul. Półwiejską 42", "ul. Półwiejską 42", "ul. Półwiejską 42", "ул. Піввейська 42", 32, "Link to map", "Stary Browar", "Stary Browar", "Stary Browar", "Старий Бровар", "10:00 - 21:00" },
                    { 108, "ul. Polan 1", "ul. Polan 1", "ul. Polan 1", "ул. Полан 1", 32, "Link to map", "Galeria Malta", "Galeria Malta", "Galeria Malta", "Галерея Мальта", "10:00 - 20:00" },
                    { 109, "ul. Dominikańska 3", "ul. Dominikańska 3", "ul. Dominikańska 3", "ул. Домініканська 3", 31, "Link to map", "Galeria Dominikańska", "Galeria Dominikańska", "Galeria Dominikańska", "Галерея Домініканська", "10:00 - 21:00" },
                    { 110, "ul. Suchej 10", "ul. Suchej 10", "ul. Suchej 10", "ул. Сухої 10", 31, "Link to map", "Wroclavia", "Wroclavia", "Wroclavia", "Вроцлавія", "10:00 - 20:00" },
                    { 111, "35 Passeig de Gràcia", "35 Passeig de Gràcia", "35 Passeig de Gràcia", "35 Пассейг де Граса", 15, "Link to map", "Passeig de Gràcia", "Passeig de Gràcia", "Passeig de Gràcia", "Пассейг де Граса", "10:00 - 21:00" },
                    { 112, "1 Carrer de Riera de Sant Miquel", "1 Calle de Riera de Sant Miquel", "1 Carrer de Riera de Sant Miquel", "1 Каррер де Рьера де Сант Мікель", 15, "Link to map", "La Maquinista", "La Maquinista", "La Maquinista", "Ла Макинiста", "10:00 - 20:00" },
                    { 113, "85 Paseo de la Castellana", "85 Paseo de la Castellana", "85 Paseo de la Castellana", "85 Пасео де ла Кастельяна", 14, "Link to map", "El Corte Inglés Castellana", "El Corte Inglés Castellana", "El Corte Inglés Castellana", "Ель Корт Англеса Кастельяна", "10:00 - 21:00" },
                    { 114, "1 Calle Aracne", "1 Calle Aracne", "1 Calle Aracne", "1 Калі Аркне", 14, "Link to map", "Plenilunio", "Plenilunio", "Plenilunio", "Пленілуніо", "10:00 - 20:00" },
                    { 115, "701 South Miami Avenue", "701 South Miami Avenue", "701 South Miami Avenue", "701 Саут Майамі Авеню", 41, "Link to map", "Brickell City Centre", "Brickell City Centre", "Brickell City Centre", "Брікелл Сіті Центр", "10:00 - 21:00" },
                    { 116, "19501 Biscayne Blvd", "19501 Biscayne Blvd", "19501 Biscayne Blvd", "19501 Біскейні Бульвар", 41, "Link to map", "Aventura Mall", "Aventura Mall", "Aventura Mall", "Авентура Молл", "10:00 - 20:00" },
                    { 117, "160 N Gulph Rd", "160 N Gulph Rd", "160 N Gulph Rd", "160 Н Гулф Роуд", 40, "Link to map", "King of Prussia Mall", "King of Prussia Mall", "King of Prussia Mall", "Кінг оф Прюша Молл", "10:00 - 21:00" },
                    { 118, "1625 Chestnut St", "1625 Chestnut St", "1625 Chestnut St", "1625 Честнат Стріт", 40, "Link to map", "The Shops at Liberty Place", "The Shops at Liberty Place", "The Shops at Liberty Place", "Шопс ат Ліберті Плейс", "10:00 - 20:00" },
                    { 119, "901 Higashishiokoji Kamikyo-ku", "901 Higashishiokoji Kamikyo-ku", "901 Higashishiokoji Kamikyo-ku", "901 Хіґашісіокоджі Камікьо-Ку", 44, "Link to map", "Kyoto Station Building", "Kyoto Station Building", "Kyoto Station Building", "Будівля Станції Кіото", "10:00 - 20:00" },
                    { 120, "721-1 Karasuma-dori", "721-1 Karasuma-dori", "721-1 Karasuma-dori", "721-1 Карасума-дорі", 44, "Link to map", "Kyoto Tower", "Kyoto Tower", "Kyoto Tower", "Кіото Тауер", "10:00 - 19:00" },
                    { 121, "al. Wyzwolenia 18", "al. Wyzwolenia 18", "al. Wyzwolenia 18", "ал. Визволення 18", 34, "Link to map", "Galaxy Centrum", "Galaxy Centrum", "Galaxy Centrum", "Галаксі Центрум", "10:00 - 21:00" },
                    { 122, "al. Jana Pawła II 42", "al. Jana Pawła II 42", "al. Jana Pawła II 42", "ал. Яна Павла II 42", 34, "Link to map", "Kaskada", "Kaskada", "Kaskada", "Каскада", "10:00 - 20:00" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "CategoryId", "ColorId", "Description_en", "Description_es", "Description_fr", "Description_uk", "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk", "MaterialId", "Name_en", "Name_es", "Name_fr", "Name_uk", "Price", "SeasonId" },
                values: new object[,]
                {
                    { 1, "ER00113828", 8, 2, "These stylish black leather boots-stockings are a perfect blend of fashion and comfort. Crafted with high-quality leather, they provide a sleek and sophisticated look. Ideal for various occasions, these boots-stockings are a must-have in your wardrobe.", "Estas elegantes botas-medias de cuero negro son una combinación perfecta de moda y comodidad. Confeccionadas con cuero de alta calidad, brindan una apariencia elegante y sofisticada. Ideales para varias ocasiones, estas botas-medias son imprescindibles en tu guardarropa.", "Ces bottes-bas élégantes en cuir noir sont un mélange parfait de mode et de confort. Confectionnées dans un cuir de haute qualité, elles offrent un look élégant et sophistiqué. Idéales pour diverses occasions, ces bottes-bas sont un incontournable de votre garde-robe.", "Ці стильні чорні шкіряні чоботи-панчохи — це ідеальне поєднання моди та комфорту. Виготовлені з високоякісної шкіри, вони створюють елегантний і витончений вигляд. Ці чоботи-панчохи ідеально підходять для різних випадків, тому їх необхідно мати у вашому гардеробі.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Boots-stockings are black leather", "Las botas-medias son de cuero negro", "Les bottes-bas sont en cuir noir", "Чоботи-панчохи шкіряні чорного кольору", 180m, 4 },
                    { 2, "ER00112019", 8, 4, "Step into the season with elegance in these Autumn brown leather stretch boots. Meticulously crafted from premium leather, these boots offer both style and comfort. The stretch feature ensures a snug fit, while the rich brown color adds a touch of warmth to your autumn wardrobe. Perfect for any occasion, these boots are a fashion statement that complements your unique style. Embrace the essence of autumn with each step.", "Entra en la temporada con elegancia con estas botas elásticas de cuero marrón Autumn. Meticulosamente elaboradas con cuero de primera calidad, estas botas ofrecen estilo y comodidad. La característica elástica garantiza un ajuste cómodo, mientras que el rico color marrón añade un toque de calidez a tu guardarropa de otoño. Perfectas para cualquier ocasión, estas botas son una declaración de moda que complementa tu estilo único. Abraza la esencia del otoño en cada paso.", "Entrez dans la saison avec élégance avec ces bottes stretch en cuir marron d'automne. Méticuleusement confectionnées à partir de cuir de première qualité, ces bottes offrent à la fois style et confort. La fonction extensible assure un ajustement parfait, tandis que la riche couleur marron ajoute une touche de chaleur à votre garde-robe d'automne. Parfaites pour toutes les occasions, ces bottes sont une déclaration de mode qui complète votre style unique. Embrassez l’essence de l’automne à chaque étape.", "Увійдіть у сезон з елегантністю в цих осінньо-коричневих шкіряних еластичних черевиках. Ретельно виготовлені з високоякісної шкіри, ці черевики пропонують стиль і комфорт. Еластична функція забезпечує щільне прилягання, а насичений коричневий колір додає нотку тепла у ваш осінній гардероб. Ідеально підходять для будь-якого випадку, ці черевики є модним виразом, який доповнює ваш унікальний стиль. З кожним кроком сприймайте сутність осені.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Autumn brown leather stretch boots", "Botas elásticas de piel marrón otoño", "Bottes stretch en cuir marron d'automne", "Осінні коричневі шкіряні еластичні черевики", 210m, 4 },
                    { 3, "ER00112018", 8, 2, "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "Estro ER00112018 Botas elásticas de cuero negro\r\n\r\nEleva tu estilo otoñal con las botas elásticas de cuero negro Estro ER00112018. Confeccionadas con una mezcla de cuero de alta calidad y material elástico, estas botas combinan a la perfección moda y comodidad. El elemento elástico proporciona elasticidad, lo que garantiza un ajuste ceñido y flexible para facilitar su uso. El elegante color negro añade versatilidad y permite combinarlo sin esfuerzo con varios estilos de vestimenta.", "Estro ER00112018 Bottes stretch en cuir noir\\r\\n\\r\\nÉlevez votre style automnal avec les bottes Estro ER00112018 en cuir stretch noir. Fabriquées avec un mélange de cuir de haute qualité et de matériaux extensibles, ces bottes allient harmonieusement mode et confort. L'élément extensible offre de l'élasticité, assurant un ajustement serré et flexible pour un port facile. La couleur noire élégante ajoute de la polyvalence, permettant une association sans effort avec différents styles de tenues.", "Чорні еластичні шкіряні черевики Estro ER00112018\r\n\r\nПокращіть свій осінній стиль за допомогою чорних еластичних шкіряних черевиків Estro ER00112018. Виготовлені із суміші високоякісної шкіри та еластичного матеріалу, ці черевики ідеально поєднують моду та комфорт. Стрейчовий елемент забезпечує еластичність, забезпечуючи щільне та гнучке прилягання для легкого носіння. Гладкий чорний колір додає універсальності, дозволяючи легко поєднувати з різними стилями одягу.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Autumn leather stretch boots", "Botas elásticas de piel de otoño", "Bottes d'automne en cuir stretch", "Чоботи осінні шкіряні стрейч", 210m, 4 },
                    { 4, "ER00112022", 8, 2, "Demi-season boots of black color made of durable shoe leather will become reliable companions in all your adventures, travels, and beautiful companions for parties with friends. Stable heels in the shape of a trapezoid - not too high, and not too low. Seven centimeters of comfort and confidence in your walk. The grooved sole will protect against any inconvenience that may occur on the way - be it dirt, gravel, cobblestones or slippery surfaces. Nothing will prevent you from feeling confident.", "Las botas de entretiempo en color negro hechas de cuero duradero para zapatos se convertirán en compañeras confiables en todas tus aventuras, viajes y hermosas compañeras para fiestas con amigos. Tacones estables en forma de trapezoide, ni demasiado altos ni demasiado bajos. Siete centímetros de comodidad y confianza en tu caminar. La suela estriada protegerá contra cualquier inconveniente que pueda surgir en el camino, ya sea tierra, grava, adoquines o superficies resbaladizas. Nada te impedirá sentirte seguro.", "Les bottes demi-saison de couleur noire en cuir de chaussure durable deviendront des compagnons fiables dans toutes vos aventures, voyages et de beaux compagnons pour les fêtes entre amis. Talons stables en forme de trapèze – ni trop hauts ni trop bas. Sept centimètres de confort et de confiance dans votre marche. La semelle rainurée protégera contre tous les désagréments pouvant survenir sur le chemin, qu'il s'agisse de saleté, de graviers, de pavés ou de surfaces glissantes. Rien ne vous empêchera de vous sentir en confiance.", "Демісезонні ботфорти чорного кольору з міцної взуттєвої шкіри стануть надійними компаньйонами у всіх ваших авантюрах, подорожах, та красивими супутниками для вечірок з друзями. Стійкі підбори у формі трапеції — не дуже високі, і не занадто низькі. Сім сантиметрів зручності та впевненості у вашій ході. Рифлена підошва захистить від будь-яких незручностей, які траплятимуться на шляху — будь-то бруд, гравій, бруківка чи слизька поверхня. Ніщо не завадить почуватись впевнено.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Boots autumn leather black", "Botas otoño cuero negro", "Bottes automne cuir noir", "Чоботи осінні шкіряні чорні", 250m, 4 },
                    { 5, "ER00112011", 8, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Black autumn leather stretch boots", "Botas elásticas de piel de otoño negras", "Bottines stretch en cuir d'automne noires", "Чорні осінні шкіряні еластичні чоботи", 300m, 4 },
                    { 6, "ER00113851", 8, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Black demi-season boots", "Botas negras de entretiempo", "Bottes demi-saison noires", "Чорні демісезонні черевики", 260m, 4 },
                    { 7, "ER00112023", 8, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Boots-stockings leather black", "Botas-medias cuero negro", "Bottes-bas cuir noir", "Чоботи-панчохи шкіряні чорні", 300m, 4 },
                    { 8, "ER00114318", 8, 5, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Boots-pipes with wide freebies", "Las botas con pipas anchas son de color", "Les bottes-pipes avec de larges cadeaux", "Черевики-дудочки з широкими халявами", 300m, 4 },
                    { 9, "ER00112298", 8, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Black leather Cossack boots", "Botas cosacas de cuero negro", "Bottes cosaques en cuir noir", "Чорні шкіряні козацькі чоботи", 260m, 4 },
                    { 10, "ER00112123", 8, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Boots-stockings on a stiletto are black", "Las botas-medias con tacones de aguja son negras.", "Les bottes-bas sur un talon aiguille sont noires", "Чоботи-панчохи на шпильці чорні", 250m, 4 },
                    { 11, "ER00112122", 8, 8, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Milk stiletto stocking boots", "Botas medias con tacón de aguja color leche", "Bottes bas à talons aiguilles au lait", "Чоботи панчохи на шпильці молочного кольору", 250m, 4 },
                    { 12, "ER00114239", 8, 4, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Boots-stockings on a stiletto are brown", "Las botas-medias con tacón de aguja son marrones", "Les bottes-bas sur un talon aiguille sont marron", "Чоботи-панчохи на шпильці коричневі", 250m, 4 },
                    { 13, "ER00114240", 8, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Boots-stockings on a stiletto are black", "Las botas-medias con tacón de aguja son negras", "Les bottes-bas sur un talon aiguille sont noires", "Чоботи-панчохи на шпильці чорні", 250m, 4 },
                    { 14, "ER00113949", 7, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Ankle boots are black", "Los botines son negros", "Les bottines sont noires", "Ботильйони чорні", 150m, 4 },
                    { 15, "ER00111942", 12, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені — повсякденні ботфорти на низькому ходу. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею — гарний тандем для вишуканих ботфортів. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Winter boots", "Las botas de invierno son negras", "Bottes d'hiver", "Зимові черевики", 150m, 1 },
                    { 16, "ER00114744", 1, 1, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Satin sandals with powder flowers", "Sandalias de raso con flores empolvadas", "Sandales en satin à fleurs poudrées", "Сатинові босоніжки з квітами пудрові", 150m, 3 },
                    { 17, "ER00115440", 1, 8, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Ankle strap sandals", "Sandalias con tira al tobillo", "Sandales à bride cheville", "Босоніжки Ankle strap", 150m, 3 },
                    { 18, "ER00115454", 1, 4, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Brown leather sandals", "Sandalias de piel marrón", "Sandales en cuir marron", "Сандалі шкіряні коричнев", 150m, 3 },
                    { 19, "ER00115470", 1, 8, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Milk leather sandals", "Sandalias piel leche", "Sandales en cuir de lait", "Сандалі шкіряні молочні", 80m, 3 },
                    { 20, "ER00112869", 1, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Peep Toe Ankle Boots", "Botines peep toe", "Bottines à bout ouvert", "Ботильйони Peep Toe", 180m, 2 },
                    { 21, "ER00114243", 1, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 6, "Boat shoes with rhinestones", "Náuticos con pedrería", "Chaussures bateau avec strass", "Туфлі-човники зі стразами", 120m, 3 },
                    { 22, "ER00114767", 3, 10, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 6, "Satin shoes d'Orsay", "Zapatos de raso de Orsay", "Chaussures en satin d'Orsay", "Сатинові туфлі д'Орсе", 180m, 2 },
                    { 23, "ER00114627", 3, 3, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 6, "Shoes denim texture", "Textura de mezclilla de zapatos", "Texture de chaussures en jean", "Туфлі джинсова текстура", 120m, 2 },
                    { 24, "ER00115098", 3, 8, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Milk leather boat shoes", "Náuticos de piel color leche", "Chaussures bateau en cuir de lait", "Туфлі-човники шкіряні молочні", 220m, 2 },
                    { 25, "ER00115612", 3, 6, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Gray leather boat shoes", "Náuticos de piel gris", "Chaussures bateau en cuir gris", "Туфлі-човники шкіряні сірі", 120m, 2 },
                    { 26, "ER00115757", 3, 5, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Lacquered burgundy boat shoes", "Náuticos lacados burdeos", "Chaussures bateau laquées bordeaux", "Туфлі-човники лаковані бордові", 250m, 2 },
                    { 27, "ER00111716", 3, 1, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Leather stilettos", "Stilettos de cuero", "Escarpins en cuir", "Туфлі на шпильках шкіряні", 180m, 2 },
                    { 28, "ER00111716", 2, 4, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "High leather loafers", "Mocasines altos de piel", "Mocassins hauts en cuir", "Високі лофери шкіряні", 100m, 4 },
                    { 29, "ER00113578", 2, 4, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Leather penny loafers", "Mocasines de piel", "Mocassins en cuir", "Пенні-лофери шкіряні", 120m, 4 },
                    { 30, "ER00114615", 2, 4, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 5, "Slip-ons with rhinestones", "Slip-ons de con strass", "Slip-ons en avec strass", "Сліпони зі стразами", 90m, 4 },
                    { 31, "ER00115105", 2, 10, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Leather shoes", "Zapatos de cuero", "Chaussures en cuir", "Туфлі шкіряні", 120m, 2 },
                    { 32, "ER00115762", 2, 6, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 5, "Gray velor loafers", "Mocasines terciopelo gris", "Mocassins en velours gris", "Лофери велюрові сірі", 90m, 2 },
                    { 33, "ER00115568", 2, 1, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Mary Jane leather ballet flats", "Bailarinas Mary Jane de piel", "Ballerines Mary Jane en cuir", "Балетки Мері Джейн шкіряні", 120m, 2 },
                    { 34, "ER00112445", 4, 9, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 6, "Pastel pink textile sneakers", "Deportivas textil rosa pastel", "Baskets en textile rose pastel", "Кросівки текстильні пастельно рожеві", 70m, 3 },
                    { 35, "ER00112715", 4, 1, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Beige sneakers with perforations", "Zapatillas beige con perforaciones", "Baskets beiges à perforations", "Кросівки з перфорацією бежеві", 90m, 3 },
                    { 36, "ER00112712", 4, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 6, "Black sneakers ES8", "Zapatillas negras ES8", "Baskets noires ES8", "Кросівки чорні ES8", 80m, 3 },
                    { 37, "ER00114620", 4, 1, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Sneakers on a thick sole", "Zapatillas con suela gruesa", "Baskets à semelle épaisse", "Кросівки на товстій підошві", 100m, 2 },
                    { 38, "ER00115442", 4, 10, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 6, "Summer sneakers transparent mesh", "Zapatillas de verano de malla transparente", "Baskets d'été en maille transparente", "Літні кросівки прозора сіточка", 120m, 3 },
                    { 39, "ER00112613", 4, 1, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Beige leather sneakers", "Zapatillas de piel beige", "Baskets en cuir beiges", "Кросівки шкіряні бежеві", 90m, 3 },
                    { 40, "ER00113212", 5, 10, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 6, "Beige leather sneakers", "Zapatillas altas textil", "Baskets montantes en textile", "Високі кеди текстильні", 70m, 3 },
                    { 41, "ER00114676", 5, 8, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Milk leather sneakers", "Zapatillas de piel color leche", "Baskets en cuir lait", "Кеди шкіряні молочні", 110m, 2 },
                    { 42, "ER00115649", 5, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Black leather sneakers", "Zapatillas de cuero negras", "Baskets en cuir noir", "Кеди шкіряні чорні", 100m, 2 },
                    { 43, "ER00115923", 5, 1, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 5, "Light brown velor sneakers", "Zapatillas de terciopelo marrón claro", "Baskets en velours marron clair", "Кеди велюрові світло-коричневі", 120m, 2 },
                    { 44, "ER00115729", 5, 4, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Brown leather sneakers", "Zapatillas de piel marrón", "Baskets en cuir marron", "Кеди шкіряні коричневі", 140m, 2 },
                    { 45, "ER00112702", 5, 10, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "White leather sneakers", "Zapatillas de cuero blancas", "Baskets en cuir blanc", "Кеди шкіряні білі", 80m, 2 },
                    { 46, "ER00112624", 6, 8, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Chelsea leather milk", "Leche de cuero chelsea", "Lait de cuir Chelsea", "Челсі шкіряні молочні", 100m, 4 },
                    { 47, "ER00113294", 6, 4, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 5, "Brown velor Chelsea boots", "Botas Chelsea de terciopelo marrón", "Bottines Chelsea en velours marron", "Челсі велюрові коричневі", 120m, 4 },
                    { 48, "ER00111762", 6, 4, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Chelsea demi-season brown", "Chelsea entretiempo marrón", "Chelsea demi-saison marron", "Челсі демісезонні коричневі", 120m, 4 },
                    { 49, "ER00113883", 6, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Chelsea leather black", "Chelsea cuero negro", "Cuir Chelsea noir", "Челсі шкіряні чорні", 150m, 4 },
                    { 50, "ER00114053", 6, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Chelsea leather black with decoration", "Chelsea de piel negra con decoración", "Cuir Chelsea noir avec décoration", "Челсі шкіряні чорні з прикрасою", 180m, 4 },
                    { 51, "ER00114136", 6, 8, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Chelsea leather milk", "Leche de cuero chelsea", "Lait de cuir Chelsea", "Челсі шкіряні молочні", 240m, 4 },
                    { 52, "ER00113595", 7, 1, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Beige leather ankle boots", "Botines de piel beige", "Bottines en cuir beiges", "Ботильйони шкіряні бежеві", 180m, 4 },
                    { 53, "ER00113885", 7, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 5, "Black leather heeled boots", "Botas de tacón de piel negras", "Bottines à talons en cuir noir", "Черевики на підборах шкіряні чорні", 200m, 4 },
                    { 54, "ER00113920", 7, 10, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Boots on milky leather heels", "Botas con tacones de cuero lechoso", "Bottes sur talons en cuir laiteux", "Черевики на підборах шкіряні молочні", 200m, 4 },
                    { 55, "ER00114699", 7, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Black leather ankle boots with lacing", "Botines de piel negros con cordones", "Bottines en cuir noir à laçage", "Ботильйони зі шнуруванням шкіряні чорні", 160m, 4 },
                    { 56, "ER00113714", 7, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Black leather ankle boots", "Botines de piel negros", "Bottines en cuir noir", "Ботильйони шкіряні чорні", 160m, 4 },
                    { 57, "ER00112046", 9, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Tall black cowgirls", "Vaqueras negras altas", "Grandes cowgirls noires", "Ковбойки високі чорні", 160m, 4 },
                    { 58, "ER00114037", 9, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "High black leather cowboy boots", "Bota cowboy alta piel negra", "Bottes de cowboy hautes en cuir noir", "Високі ковбойки шкіряні чорні", 190m, 4 },
                    { 59, "ER00113887", 9, 1, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 5, "Beige suede cowboy boots", "Botas cowboy ante beige", "Santiags en daim beige", "Ковбойські чоботи замшеві бежеві", 180m, 4 },
                    { 60, "ER00114057", 9, 1, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 5, "Light beige velor cowboy boots", "Botas cowboy velour beige claro", "Santiags en velours beige clair", "Ковбойки велюрові світло-бежеві", 120m, 4 },
                    { 61, "ER00114138", 9, 8, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Milk leather Cossacks", "Cosacos de cuero de leche", "Cosaques en cuir de lait", "Козаки шкіряні молочні", 200m, 4 },
                    { 62, "ER00114337", 9, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Black leather Cossacks", "Cosacos de cuero negro", "Cosaques en cuir noir", "Козаки шкіряні чорні", 100m, 4 },
                    { 63, "ER00110752", 10, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Shoes on fur", "Zapatos en piel", "Chaussures en fourrure", "Кеди на хутрі", 110m, 1 },
                    { 64, "ER00112250", 10, 2, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "High sneakers on fur are black", "Las zapatillas altas con piel son negras", "Les baskets hautes sur fourrure sont noires", "Високі кеди на хутрі чорні", 130m, 1 },
                    { 65, "ER00114225", 10, 4, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Light brown leather Ugg boots", "Botas Ugg de piel marrón claro", "Bottes Ugg en cuir marron clair", "Уггі шкіряні світло-коричневі", 190m, 1 },
                    { 66, "ER00114234", 10, 1, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Beige leather Ugg boots", "Botas Ugg de piel beige", "Bottes Ugg en cuir beiges", "Уггі шкіряні бежеві", 150m, 1 },
                    { 67, "ER00114147", 10, 1, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Beige winter leather sneakers", "Zapatillas de piel de invierno beige", "Baskets d'hiver en cuir beiges", "Зимові кеди шкіряні бежеві", 130m, 1 },
                    { 68, "ER00115579", 10, 1, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Beige uggs", "Botas ugg beige", "Uggs beiges", "Уггі бежеві", 90m, 1 },
                    { 69, "ER00112457", 11, 1, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Beige leather sneakers with perforations", "Deportivas de piel beige con perforaciones", "Baskets en cuir beige à perforations", "Кеди з перфорацією шкіряні бежеві", 70m, 3 },
                    { 70, "ER00112456", 11, 10, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "White leather sneakers with perforations", "Deportivas de piel blanca con perforaciones", "Baskets en cuir blanc avec perforations", "Кеди з перфорацією шкіряні білі", 70m, 3 },
                    { 71, "ER00115200", 11, 10, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "White leather summer sneakers with perforations", "Zapatillas de verano de piel blanca con perforaciones", "Baskets d'été en cuir blanc avec perforations", "Літні кеди з перфорацією шкіряні білі", 100m, 3 },
                    { 72, "ER00112411", 18, 1, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 7, "Beige jacket", "Chaqueta beige", "Veste beige", "Куртка бежева", 110m, 4 },
                    { 73, "ER00113708", 18, 4, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 7, "Winter brown jacket", "Chaqueta de invierno marrón", "Veste marron d'hiver", "Куртка зимова коричнева", 130m, 2 },
                    { 74, "ER00113820", 18, 6, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 7, "Gray down jacket", "Chaqueta de plumas gris", "Doudoune grise", "Пуховик сірий", 150m, 1 },
                    { 75, "ER00115682", 18, 4, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 7, "Brown jacket", "Chaqueta marrón", "Veste marron", "Куртка коричнева", 100m, 2 },
                    { 76, "ER00115699", 18, 4, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Brown leatherback", "Laúd marrón", "Tortue luth brune", "Куртка коричнева", 680m, 2 },
                    { 77, "ER00115934", 18, 6, "The most relevant women's shoes this fall are low-cut casual boots. They perfectly fit an active lifestyle: long walks, meetings, trips to work and on business. The knee height guarantees you warmth and protection from the piercing autumn wind. Pleasant to the touch pile and genuine leather with a smooth shiny surface - a good tandem for exquisite boots. The tractor sole with a small stable ring guarantees comfort and ease when walking. The highlight of this pair is the through lock that runs from the back of the calf and wraps around the foot. It is incredibly comfortable to wear and fix the leg with such a long zipper.", "El calzado de mujer más relevante este otoño son las botas casual de caña baja. Se adaptan perfectamente a un estilo de vida activo: largos paseos, reuniones, viajes al trabajo y de negocios. La altura de la rodilla te garantiza calidez y protección contra el penetrante viento otoñal. Pelo agradable al tacto y cuero genuino con una superficie lisa y brillante: un buen tándem para botas exquisitas. La suela del tractor con un pequeño anillo estable garantiza comodidad y facilidad al caminar. Lo más destacado de este par es el cierre pasante que va desde la parte posterior de la pantorrilla y envuelve el pie. Es increíblemente cómodo de llevar y fijar la pierna con una cremallera tan larga.", "Les chaussures pour femmes les plus pertinentes cet automne sont les bottes basses décontractées. Ils s'adaptent parfaitement à un mode de vie actif : longues promenades, réunions, déplacements professionnels et professionnels. La hauteur des genoux vous garantit chaleur et protection contre le vent perçant de l'automne. Pile agréable au toucher et cuir véritable avec une surface lisse et brillante - un bon tandem pour des bottes exquises. La semelle du tracteur avec un petit anneau stable garantit confort et facilité de marche. Le point fort de cette paire est le verrou traversant qui part de l'arrière du mollet et s'enroule autour du pied. Il est incroyablement confortable à porter et à fixer la jambe avec une fermeture éclair aussi longue.", "Найактуальніше жіноче взуття цієї осені. Вони ідеально пасують до активного стилю життя: тривалих прогулянок,  зустрічей, походів на роботу та у справах. Висота за коліно гарантує вам тепло і захищеність від пронизливого осіннього вітру. Приємний на дотик ворсин та натуральна шкіра з гладенькою блискучою поверхнею. Тракторна підошва з невеличким стійким каблучком гарантує зручність та легкість при ходьбі. Родзинка цієї пари — наскрізний замок, який йде ззаду від литки та загортається хвилькою по стопі. Неймовірно комфортно одягати та фіксувати ногу при такій довжині блискавки.", new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" }, 2, "Vintage gray leather biker jacket", "Chaqueta biker de cuero gris vintage", "Veste motard en cuir gris vintage", "Байкерська куртка шкіряна сірий вінтаж", 500m, 2 }
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
                    { 94, "Product15_6.webp", 15 },
                    { 95, "Product16_1.webp", 16 },
                    { 96, "Product16_2.webp", 16 },
                    { 97, "Product16_3.webp", 16 },
                    { 98, "Product17_1.webp", 17 },
                    { 99, "Product17_2.webp", 17 },
                    { 100, "Product17_3.webp", 17 },
                    { 101, "Product17_4.webp", 17 },
                    { 102, "Product18_1.webp", 18 },
                    { 103, "Product18_2.webp", 18 },
                    { 104, "Product18_3.webp", 18 },
                    { 105, "Product18_4.webp", 18 },
                    { 106, "Product19_1.webp", 19 },
                    { 107, "Product19_2.webp", 19 },
                    { 108, "Product19_3.webp", 19 },
                    { 109, "Product20_1.webp", 20 },
                    { 110, "Product20_2.webp", 20 },
                    { 111, "Product20_3.webp", 20 },
                    { 112, "Product21_1.webp", 21 },
                    { 113, "Product21_2.webp", 21 },
                    { 114, "Product21_3.webp", 21 },
                    { 115, "Product21_4.webp", 21 },
                    { 116, "Product22_1.webp", 22 },
                    { 117, "Product22_2.webp", 22 },
                    { 118, "Product22_3.webp", 22 },
                    { 119, "Product23_1.webp", 23 },
                    { 120, "Product23_2.webp", 23 },
                    { 121, "Product23_3.webp", 23 },
                    { 122, "Product24_1.webp", 24 },
                    { 123, "Product24_2.webp", 24 },
                    { 124, "Product24_3.webp", 24 },
                    { 125, "Product24_4.webp", 24 },
                    { 126, "Product25_1.webp", 25 },
                    { 127, "Product25_2.webp", 25 },
                    { 128, "Product25_3.webp", 25 },
                    { 129, "Product26_1.webp", 26 },
                    { 130, "Product26_2.webp", 26 },
                    { 131, "Product26_3.webp", 26 },
                    { 132, "Product27_1.webp", 27 },
                    { 133, "Product27_2.webp", 27 },
                    { 134, "Product27_3.webp", 27 },
                    { 135, "Product27_4.webp", 27 },
                    { 136, "Product28_1.webp", 28 },
                    { 137, "Product28_2.webp", 28 },
                    { 138, "Product28_3.webp", 28 },
                    { 139, "Product28_4.webp", 28 },
                    { 140, "Product29_1.webp", 29 },
                    { 141, "Product29_2.webp", 29 },
                    { 142, "Product29_3.webp", 29 },
                    { 143, "Product30_1.webp", 30 },
                    { 144, "Product30_2.webp", 30 },
                    { 145, "Product30_3.webp", 30 },
                    { 146, "Product31_1.webp", 31 },
                    { 147, "Product31_2.webp", 31 },
                    { 148, "Product31_3.webp", 31 },
                    { 149, "Product32_1.webp", 32 },
                    { 150, "Product32_2.webp", 32 },
                    { 151, "Product32_3.webp", 32 },
                    { 152, "Product33_1.webp", 33 },
                    { 153, "Product33_2.webp", 33 },
                    { 154, "Product33_3.webp", 33 },
                    { 155, "Product34_1.webp", 34 },
                    { 156, "Product34_2.webp", 34 },
                    { 157, "Product34_3.webp", 34 },
                    { 158, "Product35_1.webp", 35 },
                    { 159, "Product35_2.webp", 35 },
                    { 160, "Product35_3.webp", 35 },
                    { 161, "Product36_1.webp", 36 },
                    { 162, "Product36_2.webp", 36 },
                    { 163, "Product36_3.webp", 36 },
                    { 164, "Product37_1.webp", 37 },
                    { 165, "Product37_2.webp", 37 },
                    { 166, "Product37_3.webp", 37 },
                    { 167, "Product38_1.webp", 38 },
                    { 168, "Product38_2.webp", 38 },
                    { 169, "Product38_3.webp", 38 },
                    { 170, "Product39_1.webp", 39 },
                    { 171, "Product39_2.webp", 39 },
                    { 172, "Product39_3.webp", 39 },
                    { 173, "Product40_1.webp", 40 },
                    { 174, "Product40_2.webp", 40 },
                    { 175, "Product40_3.webp", 40 },
                    { 176, "Product41_1.webp", 41 },
                    { 177, "Product41_2.webp", 41 },
                    { 178, "Product41_3.webp", 41 },
                    { 179, "Product42_1.webp", 42 },
                    { 180, "Product42_2.webp", 42 },
                    { 181, "Product42_3.webp", 42 },
                    { 182, "Product43_1.webp", 43 },
                    { 183, "Product43_2.webp", 43 },
                    { 184, "Product43_3.webp", 43 },
                    { 185, "Product44_1.webp", 44 },
                    { 186, "Product44_2.webp", 44 },
                    { 187, "Product44_3.webp", 44 },
                    { 188, "Product45_1.webp", 45 },
                    { 189, "Product45_2.webp", 45 },
                    { 190, "Product45_3.webp", 45 },
                    { 191, "Product45_4.webp", 45 },
                    { 192, "Product46_1.webp", 46 },
                    { 193, "Product46_2.webp", 46 },
                    { 194, "Product46_3.webp", 46 },
                    { 195, "Product47_1.webp", 47 },
                    { 196, "Product47_2.webp", 47 },
                    { 197, "Product47_3.webp", 47 },
                    { 198, "Product48_1.webp", 48 },
                    { 199, "Product48_2.webp", 48 },
                    { 200, "Product48_3.webp", 48 },
                    { 201, "Product49_1.webp", 49 },
                    { 202, "Product49_2.webp", 49 },
                    { 203, "Product49_3.webp", 49 },
                    { 204, "Product50_1.webp", 50 },
                    { 205, "Product50_2.webp", 50 },
                    { 206, "Product50_3.webp", 50 },
                    { 207, "Product51_1.webp", 51 },
                    { 208, "Product51_2.webp", 51 },
                    { 209, "Product51_3.webp", 51 },
                    { 210, "Product52_1.webp", 52 },
                    { 211, "Product52_2.webp", 52 },
                    { 212, "Product52_3.webp", 52 },
                    { 213, "Product53_1.webp", 53 },
                    { 214, "Product53_2.webp", 53 },
                    { 215, "Product53_3.webp", 53 },
                    { 216, "Product54_1.webp", 54 },
                    { 217, "Product54_2.webp", 54 },
                    { 218, "Product54_3.webp", 54 },
                    { 219, "Product55_1.webp", 55 },
                    { 220, "Product55_2.webp", 55 },
                    { 221, "Product55_3.webp", 55 },
                    { 222, "Product56_1.webp", 56 },
                    { 223, "Product56_2.webp", 56 },
                    { 224, "Product56_3.webp", 56 },
                    { 225, "Product57_1.webp", 57 },
                    { 226, "Product57_2.webp", 57 },
                    { 227, "Product57_3.webp", 57 },
                    { 228, "Product58_1.webp", 58 },
                    { 229, "Product58_2.webp", 58 },
                    { 230, "Product58_3.webp", 58 },
                    { 231, "Product59_1.webp", 59 },
                    { 232, "Product59_2.webp", 59 },
                    { 233, "Product59_3.webp", 59 },
                    { 234, "Product60_1.webp", 60 },
                    { 235, "Product60_2.webp", 60 },
                    { 236, "Product60_3.webp", 60 },
                    { 237, "Product61_1.webp", 61 },
                    { 238, "Product61_2.webp", 61 },
                    { 239, "Product61_3.webp", 61 },
                    { 240, "Product62_1.webp", 62 },
                    { 241, "Product62_2.webp", 62 },
                    { 242, "Product62_3.webp", 62 },
                    { 243, "Product63_1.webp", 63 },
                    { 244, "Product63_2.webp", 63 },
                    { 245, "Product63_3.webp", 63 },
                    { 246, "Product64_1.webp", 64 },
                    { 247, "Product64_2.webp", 64 },
                    { 248, "Product64_3.webp", 64 },
                    { 249, "Product65_1.webp", 65 },
                    { 250, "Product65_2.webp", 65 },
                    { 251, "Product65_3.webp", 65 },
                    { 252, "Product66_1.webp", 66 },
                    { 253, "Product66_2.webp", 66 },
                    { 254, "Product66_3.webp", 66 },
                    { 255, "Product67_1.webp", 67 },
                    { 256, "Product67_2.webp", 67 },
                    { 257, "Product67_3.webp", 67 },
                    { 258, "Product68_1.webp", 68 },
                    { 259, "Product68_2.webp", 68 },
                    { 260, "Product68_3.webp", 68 },
                    { 261, "Product69_1.webp", 69 },
                    { 262, "Product69_2.webp", 69 },
                    { 263, "Product69_3.webp", 69 },
                    { 264, "Product70_1.webp", 70 },
                    { 265, "Product70_2.webp", 70 },
                    { 266, "Product70_3.webp", 70 },
                    { 267, "Product71_1.webp", 71 },
                    { 268, "Product71_2.webp", 71 },
                    { 269, "Product71_3.webp", 71 },
                    { 270, "Product72_1.webp", 72 },
                    { 271, "Product72_2.webp", 72 },
                    { 272, "Product72_3.webp", 72 },
                    { 273, "Product73_1.webp", 73 },
                    { 274, "Product73_2.webp", 73 },
                    { 275, "Product73_3.webp", 73 },
                    { 276, "Product74_1.webp", 74 },
                    { 277, "Product74_2.webp", 74 },
                    { 278, "Product74_3.webp", 74 },
                    { 279, "Product75_1.webp", 75 },
                    { 280, "Product75_2.webp", 75 },
                    { 281, "Product75_3.webp", 75 },
                    { 282, "Product76_1.webp", 76 },
                    { 283, "Product76_2.webp", 76 },
                    { 284, "Product76_3.webp", 76 },
                    { 285, "Product77_1.webp", 77 },
                    { 286, "Product77_2.webp", 77 },
                    { 287, "Product77_3.webp", 77 }
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
                    { 92, 15, 0, "46", 12, false },
                    { 93, 16, 0, "36", 2, false },
                    { 94, 16, 15, "37", 3, true },
                    { 95, 16, 10, "38", 4, true },
                    { 96, 16, 10, "39", 5, true },
                    { 97, 16, 10, "40", 6, true },
                    { 98, 16, 0, "41", 7, false },
                    { 99, 17, 0, "36", 2, false },
                    { 100, 17, 15, "37", 3, true },
                    { 101, 17, 10, "38", 4, true },
                    { 102, 17, 10, "39", 5, true },
                    { 103, 17, 10, "40", 6, true },
                    { 104, 17, 0, "41", 7, false },
                    { 105, 18, 0, "36", 2, false },
                    { 106, 18, 15, "37", 3, true },
                    { 107, 18, 10, "38", 4, true },
                    { 108, 18, 10, "39", 5, true },
                    { 109, 18, 10, "40", 6, true },
                    { 110, 18, 0, "41", 7, false },
                    { 111, 19, 0, "36", 2, false },
                    { 112, 19, 15, "37", 3, true },
                    { 113, 19, 10, "38", 4, true },
                    { 114, 19, 10, "39", 5, true },
                    { 115, 19, 10, "40", 6, true },
                    { 116, 19, 0, "41", 7, false },
                    { 117, 20, 0, "36", 2, false },
                    { 118, 20, 15, "37", 3, true },
                    { 119, 20, 10, "38", 4, true },
                    { 120, 20, 10, "39", 5, true },
                    { 121, 20, 10, "40", 6, true },
                    { 122, 20, 0, "41", 7, false },
                    { 123, 21, 0, "36", 2, false },
                    { 124, 21, 15, "37", 3, true },
                    { 125, 21, 10, "38", 4, true },
                    { 126, 21, 10, "39", 5, true },
                    { 127, 21, 10, "40", 6, true },
                    { 128, 21, 0, "41", 7, false },
                    { 129, 22, 0, "36", 2, false },
                    { 130, 22, 15, "37", 3, true },
                    { 131, 22, 10, "38", 4, true },
                    { 132, 22, 10, "39", 5, true },
                    { 133, 22, 10, "40", 6, true },
                    { 134, 22, 0, "41", 7, false },
                    { 135, 23, 0, "36", 2, false },
                    { 136, 23, 15, "37", 3, true },
                    { 137, 23, 10, "38", 4, true },
                    { 138, 23, 10, "39", 5, true },
                    { 139, 23, 10, "40", 6, true },
                    { 140, 23, 0, "41", 7, false },
                    { 141, 24, 0, "36", 2, false },
                    { 142, 24, 15, "37", 3, true },
                    { 143, 24, 10, "38", 4, true },
                    { 144, 24, 10, "39", 5, true },
                    { 145, 24, 10, "40", 6, true },
                    { 146, 24, 0, "41", 7, false },
                    { 147, 25, 0, "36", 2, false },
                    { 148, 25, 15, "37", 3, true },
                    { 149, 25, 10, "38", 4, true },
                    { 150, 25, 10, "39", 5, true },
                    { 151, 25, 10, "40", 6, true },
                    { 152, 25, 0, "41", 7, false },
                    { 153, 26, 0, "36", 2, false },
                    { 154, 26, 15, "37", 3, true },
                    { 155, 26, 10, "38", 4, true },
                    { 156, 26, 10, "39", 5, true },
                    { 157, 26, 10, "40", 6, true },
                    { 158, 26, 0, "41", 7, false },
                    { 159, 27, 0, "36", 2, false },
                    { 160, 27, 15, "37", 3, true },
                    { 161, 27, 10, "38", 4, true },
                    { 162, 27, 10, "39", 5, true },
                    { 163, 27, 10, "40", 6, true },
                    { 164, 27, 0, "41", 7, false },
                    { 165, 28, 10, "36", 2, true },
                    { 166, 28, 15, "37", 3, true },
                    { 167, 28, 0, "38", 4, false },
                    { 168, 28, 0, "39", 5, false },
                    { 169, 28, 0, "40", 6, false },
                    { 170, 28, 10, "41", 7, true },
                    { 171, 29, 10, "36", 2, true },
                    { 172, 29, 15, "37", 3, true },
                    { 173, 29, 10, "38", 4, true },
                    { 174, 29, 10, "39", 5, true },
                    { 175, 29, 30, "40", 6, true },
                    { 176, 29, 10, "41", 7, true },
                    { 177, 30, 10, "36", 2, true },
                    { 178, 30, 15, "37", 3, true },
                    { 179, 30, 0, "38", 4, false },
                    { 180, 30, 0, "39", 5, false },
                    { 181, 30, 0, "40", 6, false },
                    { 182, 30, 10, "41", 7, true },
                    { 183, 31, 10, "36", 2, true },
                    { 184, 31, 15, "37", 3, true },
                    { 185, 31, 10, "38", 4, true },
                    { 186, 31, 10, "39", 5, true },
                    { 187, 31, 10, "40", 6, true },
                    { 188, 31, 10, "41", 7, true },
                    { 189, 32, 10, "36", 2, true },
                    { 190, 32, 15, "37", 3, true },
                    { 191, 32, 10, "38", 4, true },
                    { 192, 32, 10, "39", 5, true },
                    { 193, 32, 10, "40", 6, true },
                    { 194, 32, 10, "41", 7, true },
                    { 195, 33, 10, "36", 2, true },
                    { 196, 33, 15, "37", 3, true },
                    { 197, 33, 10, "38", 4, true },
                    { 198, 33, 10, "39", 5, true },
                    { 199, 33, 10, "40", 6, true },
                    { 200, 33, 10, "41", 7, true },
                    { 201, 34, 10, "36", 2, true },
                    { 202, 34, 15, "37", 3, true },
                    { 203, 34, 10, "38", 4, true },
                    { 204, 34, 10, "39", 5, true },
                    { 205, 34, 10, "40", 6, true },
                    { 206, 34, 10, "41", 7, true },
                    { 207, 35, 10, "36", 2, true },
                    { 208, 35, 15, "37", 3, true },
                    { 209, 35, 10, "38", 4, true },
                    { 210, 35, 10, "39", 5, true },
                    { 211, 35, 10, "40", 6, true },
                    { 212, 35, 10, "41", 7, true },
                    { 213, 36, 10, "36", 2, true },
                    { 214, 36, 15, "37", 3, true },
                    { 215, 36, 10, "38", 4, true },
                    { 216, 36, 10, "39", 5, true },
                    { 217, 36, 10, "40", 6, true },
                    { 218, 36, 10, "41", 7, true },
                    { 219, 37, 10, "36", 2, true },
                    { 220, 37, 15, "37", 3, true },
                    { 221, 37, 10, "38", 4, true },
                    { 222, 37, 10, "39", 5, true },
                    { 223, 37, 10, "40", 6, true },
                    { 224, 37, 10, "41", 7, true },
                    { 225, 38, 10, "36", 2, true },
                    { 226, 38, 15, "37", 3, true },
                    { 227, 38, 10, "38", 4, true },
                    { 228, 38, 10, "39", 5, true },
                    { 229, 38, 10, "40", 6, true },
                    { 230, 38, 10, "41", 7, true },
                    { 231, 39, 10, "36", 2, true },
                    { 232, 39, 15, "37", 3, true },
                    { 233, 39, 10, "38", 4, true },
                    { 234, 39, 10, "39", 5, true },
                    { 235, 39, 10, "40", 6, true },
                    { 236, 39, 10, "41", 7, true },
                    { 237, 40, 10, "36", 2, true },
                    { 238, 40, 15, "37", 3, true },
                    { 239, 40, 10, "38", 4, true },
                    { 240, 40, 10, "39", 5, true },
                    { 241, 40, 10, "40", 6, true },
                    { 242, 40, 10, "41", 7, true },
                    { 243, 41, 10, "36", 2, true },
                    { 244, 41, 15, "37", 3, true },
                    { 245, 41, 10, "38", 4, true },
                    { 246, 41, 10, "39", 5, true },
                    { 247, 41, 10, "40", 6, true },
                    { 248, 41, 10, "41", 7, true },
                    { 249, 42, 10, "36", 2, true },
                    { 250, 42, 15, "37", 3, true },
                    { 251, 42, 10, "38", 4, true },
                    { 252, 42, 10, "39", 5, true },
                    { 253, 42, 10, "40", 6, true },
                    { 254, 42, 10, "41", 7, true },
                    { 255, 43, 10, "36", 2, true },
                    { 256, 43, 15, "37", 3, true },
                    { 257, 43, 10, "38", 4, true },
                    { 258, 43, 10, "39", 5, true },
                    { 259, 43, 10, "40", 6, true },
                    { 260, 43, 10, "41", 7, true },
                    { 261, 44, 10, "36", 2, true },
                    { 262, 44, 15, "37", 3, true },
                    { 263, 44, 10, "38", 4, true },
                    { 264, 44, 10, "39", 5, true },
                    { 265, 44, 10, "40", 6, true },
                    { 266, 44, 10, "41", 7, true },
                    { 267, 45, 10, "36", 2, true },
                    { 268, 45, 15, "37", 3, true },
                    { 269, 45, 10, "38", 4, true },
                    { 270, 45, 10, "39", 5, true },
                    { 271, 45, 10, "40", 6, true },
                    { 272, 45, 10, "41", 7, true },
                    { 273, 46, 10, "36", 2, true },
                    { 274, 46, 15, "37", 3, true },
                    { 275, 46, 10, "38", 4, true },
                    { 276, 46, 10, "39", 5, true },
                    { 277, 46, 10, "40", 6, true },
                    { 278, 46, 10, "41", 7, true },
                    { 279, 47, 10, "36", 2, true },
                    { 280, 47, 15, "37", 3, true },
                    { 281, 47, 10, "38", 4, true },
                    { 282, 47, 10, "39", 5, true },
                    { 283, 47, 10, "40", 6, true },
                    { 284, 47, 10, "41", 7, true },
                    { 285, 48, 10, "36", 2, true },
                    { 286, 48, 15, "37", 3, true },
                    { 287, 48, 10, "38", 4, true },
                    { 288, 48, 10, "39", 5, true },
                    { 289, 48, 10, "40", 6, true },
                    { 290, 48, 10, "41", 7, true },
                    { 291, 49, 10, "36", 2, true },
                    { 292, 49, 15, "37", 3, true },
                    { 293, 49, 10, "38", 4, true },
                    { 294, 49, 10, "39", 5, true },
                    { 295, 49, 10, "40", 6, true },
                    { 296, 49, 10, "41", 7, true },
                    { 297, 50, 10, "36", 2, true },
                    { 298, 50, 15, "37", 3, true },
                    { 299, 50, 10, "38", 4, true },
                    { 300, 50, 10, "39", 5, true },
                    { 301, 50, 10, "40", 6, true },
                    { 302, 50, 10, "41", 7, true },
                    { 303, 51, 10, "36", 2, true },
                    { 304, 51, 15, "37", 3, true },
                    { 305, 51, 10, "38", 4, true },
                    { 306, 51, 10, "39", 5, true },
                    { 307, 51, 10, "40", 6, true },
                    { 308, 51, 10, "41", 7, true },
                    { 309, 52, 10, "36", 2, true },
                    { 310, 52, 15, "37", 3, true },
                    { 311, 52, 10, "38", 4, true },
                    { 312, 52, 10, "39", 5, true },
                    { 313, 52, 10, "40", 6, true },
                    { 314, 52, 10, "41", 7, true },
                    { 315, 53, 10, "36", 2, true },
                    { 316, 53, 15, "37", 3, true },
                    { 317, 53, 10, "38", 4, true },
                    { 318, 53, 10, "39", 5, true },
                    { 319, 53, 10, "40", 6, true },
                    { 320, 53, 10, "41", 7, true },
                    { 321, 54, 10, "36", 2, true },
                    { 322, 54, 15, "37", 3, true },
                    { 323, 54, 10, "38", 4, true },
                    { 324, 54, 10, "39", 5, true },
                    { 325, 54, 10, "40", 6, true },
                    { 326, 54, 10, "41", 7, true },
                    { 327, 55, 10, "36", 2, true },
                    { 328, 55, 15, "37", 3, true },
                    { 329, 55, 10, "38", 4, true },
                    { 330, 55, 10, "39", 5, true },
                    { 331, 55, 10, "40", 6, true },
                    { 332, 55, 10, "41", 7, true },
                    { 333, 56, 10, "36", 2, true },
                    { 334, 56, 15, "37", 3, true },
                    { 335, 56, 10, "38", 4, true },
                    { 336, 56, 10, "39", 5, true },
                    { 337, 56, 10, "40", 6, true },
                    { 338, 56, 10, "41", 7, true },
                    { 339, 57, 10, "36", 2, true },
                    { 340, 57, 15, "37", 3, true },
                    { 341, 57, 10, "38", 4, true },
                    { 342, 57, 10, "39", 5, true },
                    { 343, 57, 10, "40", 6, true },
                    { 344, 57, 10, "41", 7, true },
                    { 345, 58, 10, "36", 2, true },
                    { 346, 58, 15, "37", 3, true },
                    { 347, 58, 10, "38", 4, true },
                    { 348, 58, 10, "39", 5, true },
                    { 349, 58, 10, "40", 6, true },
                    { 350, 58, 10, "41", 7, true },
                    { 351, 59, 10, "36", 2, true },
                    { 352, 59, 15, "37", 3, true },
                    { 353, 59, 10, "38", 4, true },
                    { 354, 59, 10, "39", 5, true },
                    { 355, 59, 10, "40", 6, true },
                    { 356, 59, 10, "41", 7, true },
                    { 357, 60, 10, "36", 2, true },
                    { 358, 60, 15, "37", 3, true },
                    { 359, 60, 10, "38", 4, true },
                    { 360, 60, 10, "39", 5, true },
                    { 361, 60, 10, "40", 6, true },
                    { 362, 60, 10, "41", 7, true },
                    { 363, 61, 10, "36", 2, true },
                    { 364, 61, 15, "37", 3, true },
                    { 365, 61, 10, "38", 4, true },
                    { 366, 61, 10, "39", 5, true },
                    { 367, 61, 10, "40", 6, true },
                    { 368, 61, 10, "41", 7, true },
                    { 369, 62, 10, "36", 2, true },
                    { 370, 62, 15, "37", 3, true },
                    { 371, 62, 10, "38", 4, true },
                    { 372, 62, 10, "39", 5, true },
                    { 373, 62, 10, "40", 6, true },
                    { 374, 62, 10, "41", 7, true },
                    { 375, 63, 10, "36", 2, true },
                    { 376, 63, 15, "37", 3, true },
                    { 377, 63, 10, "38", 4, true },
                    { 378, 63, 10, "39", 5, true },
                    { 379, 63, 10, "40", 6, true },
                    { 380, 63, 10, "41", 7, true },
                    { 381, 64, 10, "36", 2, true },
                    { 382, 64, 15, "37", 3, true },
                    { 383, 64, 10, "38", 4, true },
                    { 384, 64, 10, "39", 5, true },
                    { 385, 64, 10, "40", 6, true },
                    { 386, 64, 10, "41", 7, true },
                    { 387, 65, 10, "36", 2, true },
                    { 388, 65, 15, "37", 3, true },
                    { 389, 65, 10, "38", 4, true },
                    { 390, 65, 10, "39", 5, true },
                    { 391, 65, 10, "40", 6, true },
                    { 392, 65, 10, "41", 7, true },
                    { 393, 66, 10, "36", 2, true },
                    { 394, 66, 15, "37", 3, true },
                    { 395, 66, 10, "38", 4, true },
                    { 396, 66, 10, "39", 5, true },
                    { 397, 66, 10, "40", 6, true },
                    { 398, 66, 10, "41", 7, true },
                    { 399, 67, 10, "36", 2, true },
                    { 400, 67, 15, "37", 3, true },
                    { 401, 67, 10, "38", 4, true },
                    { 402, 67, 10, "39", 5, true },
                    { 403, 67, 10, "40", 6, true },
                    { 404, 67, 10, "41", 7, true },
                    { 405, 68, 10, "36", 2, true },
                    { 406, 68, 15, "37", 3, true },
                    { 407, 68, 10, "38", 4, true },
                    { 408, 68, 10, "39", 5, true },
                    { 409, 68, 10, "40", 6, true },
                    { 410, 68, 10, "41", 7, true },
                    { 411, 69, 10, "36", 2, true },
                    { 412, 69, 15, "37", 3, true },
                    { 413, 69, 10, "38", 4, true },
                    { 414, 69, 10, "39", 5, true },
                    { 415, 69, 10, "40", 6, true },
                    { 416, 69, 10, "41", 7, true },
                    { 417, 70, 10, "36", 2, true },
                    { 418, 70, 15, "37", 3, true },
                    { 419, 70, 10, "38", 4, true },
                    { 420, 70, 10, "39", 5, true },
                    { 421, 70, 10, "40", 6, true },
                    { 422, 70, 10, "41", 7, true },
                    { 423, 71, 10, "36", 2, true },
                    { 424, 71, 15, "37", 3, true },
                    { 425, 71, 10, "38", 4, true },
                    { 426, 71, 10, "39", 5, true },
                    { 427, 71, 10, "40", 6, true },
                    { 428, 71, 10, "41", 7, true },
                    { 429, 72, 10, "XS", 13, true },
                    { 430, 72, 15, "S", 14, true },
                    { 431, 72, 10, "M", 15, true },
                    { 432, 72, 10, "L", 16, true },
                    { 433, 72, 10, "XL", 17, true },
                    { 434, 72, 10, "XXL", 18, true },
                    { 435, 73, 10, "XS", 13, true },
                    { 436, 73, 15, "S", 14, true },
                    { 437, 73, 10, "M", 15, true },
                    { 438, 73, 10, "L", 16, true },
                    { 439, 73, 10, "XL", 17, true },
                    { 440, 73, 10, "XXL", 18, true },
                    { 441, 74, 10, "XS", 13, true },
                    { 442, 74, 15, "S", 14, true },
                    { 443, 74, 10, "M", 15, true },
                    { 444, 74, 10, "L", 16, true },
                    { 445, 74, 10, "XL", 17, true },
                    { 446, 74, 10, "XXL", 18, true },
                    { 447, 75, 10, "XS", 13, true },
                    { 448, 75, 15, "S", 14, true },
                    { 449, 75, 10, "M", 15, true },
                    { 450, 75, 10, "L", 16, true },
                    { 451, 75, 10, "XL", 17, true },
                    { 452, 75, 10, "XXL", 18, true },
                    { 453, 76, 10, "XS", 13, true },
                    { 454, 76, 15, "S", 14, true },
                    { 455, 76, 10, "M", 15, true },
                    { 456, 76, 10, "L", 16, true },
                    { 457, 76, 10, "XL", 17, true },
                    { 458, 76, 10, "XXL", 18, true },
                    { 459, 77, 10, "XS", 13, true },
                    { 460, 77, 15, "S", 14, true },
                    { 461, 77, 10, "M", 15, true },
                    { 462, 77, 10, "L", 16, true },
                    { 463, 77, 10, "XL", 17, true },
                    { 464, 77, 10, "XXL", 18, true }
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
                name: "IX_OrderItems_OrderPaymentId",
                table: "OrderItems",
                column: "OrderPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");

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
                name: "OrderPayment");

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
