using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "602f8858-2f37-43aa-afab-15ed412db616");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BagId", "Birthday", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "ImagePath", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ee263e43-6587-43ce-b118-0c09f4ee9bef", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "56a9c67d-2930-47b2-8431-73bd911aa9b0", "User", "admin@ukr.net", false, "Admin", "", "", false, null, null, null, "Qwerty-7", null, null, false, "Admin", "eb62485b-99ca-4064-9fb8-b0da58908535", false, "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee263e43-6587-43ce-b118-0c09f4ee9bef");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BagId", "Birthday", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "ImagePath", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "602f8858-2f37-43aa-afab-15ed412db616", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "405dceca-cc05-4a0a-861e-ad8b1e518813", "User", "admin@ukr.net", false, "Admin", "", "", false, null, null, null, "Qwerty-7", null, null, false, "Admin", "9491db3f-97e5-4edc-9a8c-7070afb3702f", false, "Admin" });
        }
    }
}
