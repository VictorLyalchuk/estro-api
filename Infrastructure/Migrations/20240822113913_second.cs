using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CityName_en", "CityName_es", "CityName_fr", "CityName_uk", "CountryID" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Highlights_en", "Highlights_es", "Highlights_fr", "Highlights_uk" },
                values: new object[] { new List<string> { "Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton" }, new List<string> { "Cortado y cosido a mano localmente", "Teñido con nuestros colores patentados", "Prelavado y preencogido", "Ultra suave 100% algodón" }, new List<string> { "Coupé et cousu à la main localement", "Teint avec nos couleurs exclusives", "Pré-lavé et pré-rétréci", "Ultra-doux 100% coton" }, new List<string> { "Вирізані вручну та зшиті на місці", "Пофарбовано в наші фірмові кольори", "Попереднє прання та усадка", "Надм’яка 100% бавовна" } });
        }
    }
}
