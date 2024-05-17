using Core.Entities.Category;
using Core.Entities.DashBoard;
using Core.Entities.Information;
using Core.Entities.Product;

namespace Infrastructure.Data
{
    public static class SeedData
    {
        public static List<MainCategory> SeedMainCategory() =>
        new List<MainCategory>() {
            new MainCategory(){ Id = 1, Name = "Woman", URLName = "woman" },                                        // Woman
            new MainCategory(){ Id = 2, Name = "Man", URLName = "man"},                                         // Man
        };
        public static List<SubCategory> SeedSubCategory() =>
        new List<SubCategory>() {
            new SubCategory(){ Id = 1, Name = "Woman Shoes", MainCategoryId = 1, URLName = "woman_shoes" },
            new SubCategory(){ Id = 2, Name = "Man Shoes", MainCategoryId = 2, URLName = "man_shoes" },
            new SubCategory(){ Id = 3, Name = "Woman Clothing", MainCategoryId = 1, URLName = "woman_clothing" },
            new SubCategory(){ Id = 4, Name = "Man Clothing", MainCategoryId = 2, URLName = "man_clothing" },
            new SubCategory(){ Id = 5, Name = "Woman Accessories", MainCategoryId = 1, URLName = "woman_accessories" },
            new SubCategory(){ Id = 6, Name = "Man Accessories", MainCategoryId = 2, URLName = "man_accessories" },
        };
        public static List<CategoryEntity> SeedCategory() =>
        new List<CategoryEntity>() {
            new CategoryEntity(){ Id = 1, Name = "Open shoes", SubCategoryId = 1, URLName = "open_shoes" },                  // Відкрите взуття
            new CategoryEntity(){ Id = 2, Name = "Pumps and loafers", SubCategoryId = 1, URLName = "pumps_and_loafers" },           // Туфлі та лофери
            new CategoryEntity(){ Id = 3, Name = "Heeled shoes", SubCategoryId = 1, URLName = "heeled_shoes" },                // Туфлі на підборах
            new CategoryEntity(){ Id = 4, Name = "Women's athletic sneakers", SubCategoryId = 1, URLName = "women's_athletic_sneakers" },   // Кросівки жіночі
            new CategoryEntity(){ Id = 5, Name = "Women's sneakers", SubCategoryId = 1, URLName = "women_sneakers" },            // Жіночі кеди
            new CategoryEntity(){ Id = 6, Name = "High boots and Chelsea", SubCategoryId = 1, URLName = "high_boots_&_chelsea" },         // Високі черевики, челсі
            new CategoryEntity(){ Id = 7, Name = "Boots on heels", SubCategoryId = 1, URLName = "boots_on_heels" },              // Черевики на підборах
            new CategoryEntity(){ Id = 8, Name = "Boots and high boots", SubCategoryId = 1, URLName = "boots_and_high_boots" },        // Чоботи та ботфорти
            new CategoryEntity(){ Id = 9, Name = "Cossacks boots", SubCategoryId = 1, URLName = "cossacks_boots" },              // Козаки
            new CategoryEntity(){ Id = 10, Name = "Winter footwear", SubCategoryId = 1, URLName = "winter_footwear" },            // Зимове взуття
            new CategoryEntity(){ Id = 11, Name = "Perforated shoes", SubCategoryId = 1, URLName = "perforated_shoes" },           // Перфороване взуття

            new CategoryEntity(){ Id = 12, Name = "Men's boots", SubCategoryId = 2, URLName = "men_boots" },                // Черевики чоловічі
            new CategoryEntity(){ Id = 13, Name = "Men's athletic sneakers", SubCategoryId = 2, URLName = "man_athletic_sneakers" },    // Кросівки чоловічі
            new CategoryEntity(){ Id = 14, Name = "Men's sneakers", SubCategoryId = 2, URLName = "man_sneakers" },             // Чоловічі кеди
            new CategoryEntity(){ Id = 15, Name = "Men's pumps", SubCategoryId = 2, URLName = "man_pumps" },                // Туфлі чоловічі
            new CategoryEntity(){ Id = 16, Name = "Men's moccasins", SubCategoryId = 2, URLName = "man_moccasins" },            // Мокасини чоловічі
            new CategoryEntity(){ Id = 17, Name = "Men's summer shoes", SubCategoryId = 2, URLName = "man_summer_shoes" },

            new CategoryEntity(){ Id = 18, Name = "Women's outerwear", SubCategoryId = 3, URLName = "woman_outerwear" },                // Верхній одяг
            new CategoryEntity(){ Id = 19, Name = "Women's sweaters and suits", SubCategoryId = 3, URLName = "woman_sweaters_and_suits" },       // Светри та костюми
            new CategoryEntity(){ Id = 20, Name = "Women's t-shirts and sweatshirts", SubCategoryId = 3, URLName = "woman_t_shirts_and_sweatshirts" }, // Футболки та світшоти
            new CategoryEntity(){ Id = 21, Name = "Women's shawl", SubCategoryId = 3, URLName = "woman_shawl" },                    // Хустки
            new CategoryEntity(){ Id = 22, Name = "Women's scarves and hats", SubCategoryId = 3, URLName = "woman_scarves_and_hats" },         // Шарфи та шапки
            new CategoryEntity(){ Id = 23, Name = "Women's gloves", SubCategoryId = 3, URLName = "woman_gloves" },                   // Рукавички
            new CategoryEntity(){ Id = 24, Name = "Women's socks and tights", SubCategoryId = 3, URLName = "woman_socks_and_tights" },         // Шкарпетки та колготи
            
            new CategoryEntity(){ Id = 25, Name = "Men's outerwear", SubCategoryId = 4, URLName = "man_outerwear" },                // Верхній одяг
            new CategoryEntity(){ Id = 26, Name = "Men's sweaters and suits", SubCategoryId = 4, URLName = "man_sweaters_and_suits" },       // Светри та костюми
            new CategoryEntity(){ Id = 27, Name = "Men's t-shirts and sweatshirts", SubCategoryId = 4, URLName = "man_t_shirts_and_sweatshirts" }, // Футболки та світшоти
            new CategoryEntity(){ Id = 28, Name = "Men's scarves and hats", SubCategoryId = 4, URLName = "man_scarves_and_hats" },         // Шарфи та шапки
            new CategoryEntity(){ Id = 29, Name = "Men's gloves", SubCategoryId = 4, URLName = "man_gloves" },                   // Рукавички
            new CategoryEntity(){ Id = 30, Name = "Men's socks", SubCategoryId = 4, URLName = "man_socks" },         // Шкарпетки та колготи
            
            new CategoryEntity(){ Id = 31, Name = "Women's glasses", SubCategoryId = 5, URLName = "woman_glasses" },                   // Окуляри
            new CategoryEntity(){ Id = 32, Name = "Women's home shoes", SubCategoryId = 5, URLName = "woman_home_shoes" },                // Домашнє взуття
            new CategoryEntity(){ Id = 33, Name = "Women's bags", SubCategoryId = 5, URLName = "woman_bags" },                      // Сумки
            new CategoryEntity(){ Id = 34, Name = "Women's backpacks", SubCategoryId = 5, URLName = "woman_backpacks" },                 // Окуляри
            new CategoryEntity(){ Id = 35, Name = "Women's care products", SubCategoryId = 5, URLName = "woman_care_products" },             // Засоби по догляду
            
            new CategoryEntity(){ Id = 36, Name = "Men's glasses", SubCategoryId = 6, URLName = "man_glasses" },                   // Окуляри
            new CategoryEntity(){ Id = 37, Name = "Men's home shoes", SubCategoryId = 6, URLName = "man_home_shoes" },                // Домашнє взуття
            new CategoryEntity(){ Id = 38, Name = "Men's bags", SubCategoryId = 6, URLName = "man_bags" },                      // Сумки
            new CategoryEntity(){ Id = 39, Name = "Men's backpacks", SubCategoryId = 6, URLName = "man_backpacks" },                 // Окуляри
            new CategoryEntity(){ Id = 40, Name = "Men's care products", SubCategoryId = 6, URLName = "man_care_products" },             // Засоби по догляду
        
        };
        public static List<ProductEntity> SeedProduct() =>
        new List<ProductEntity>() {
            new ProductEntity(){ Id = 1, Name = "Boots-stockings are black leather", Article = "ER00113828", Color = "Black", Material = "Leather", Description = "These stylish black leather boots-stockings are a perfect blend of fashion and comfort. Crafted with high-quality leather, they provide a sleek and sophisticated look. Ideal for various occasions, these boots-stockings are a must-have in your wardrobe.", Purpose = "Autumn", Price = 7399, CategoryId = 8},
            new ProductEntity(){ Id = 2, Name = "Autumn brown leather stretch boots", Article = "ER00112019", Color = "Brown", Material = "Leather", Description = "Step into the season with elegance in these Autumn brown leather stretch boots. Meticulously crafted from premium leather, these boots offer both style and comfort. The stretch feature ensures a snug fit, while the rich brown color adds a touch of warmth to your autumn wardrobe. Perfect for any occasion, these boots are a fashion statement that complements your unique style. Embrace the essence of autumn with each step.", Purpose = "Autumn", Price = 8899, CategoryId = 8},
            new ProductEntity(){ Id = 3, Name = "Autumn leather stretch boots", Article = "ER00112018", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 8899, CategoryId = 8},
            new ProductEntity(){ Id = 4, Name = "Boots autumn leather black", Article = "ER00112022", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 9899, CategoryId = 8},
            new ProductEntity(){ Id = 5, Name = "Black autumn leather stretch boots", Article = "ER00112011", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 9899, CategoryId = 8},
            new ProductEntity(){ Id = 6, Name = "Black demi-season boots", Article = "ER00113851", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 8799, CategoryId = 8},
            new ProductEntity(){ Id = 7, Name = "Boots-stockings leather black", Article = "ER00112023", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 9989, CategoryId = 8},
            new ProductEntity(){ Id = 8, Name = "Boots-pipes with wide freebies are burgundy", Article = "ER00114318", Color = "Burgundy", Material = "Leather", Description = "Estro ER00112018 Burgundy Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 9989, CategoryId = 8},
            new ProductEntity(){ Id = 9, Name = "Black leather Cossack boots", Article = "ER00112298", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 8799, CategoryId = 8},
            new ProductEntity(){ Id = 10, Name = "Boots-stockings on a stiletto are black", Article = "ER00112123", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 8699, CategoryId = 8},
            new ProductEntity(){ Id = 11, Name = "Milk stiletto stocking boots", Article = "ER00112122", Color = "Milk", Material = "Leather", Description = "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 8699, CategoryId = 8},
            new ProductEntity(){ Id = 12, Name = "Boots-stockings on a stiletto are brown", Article = "ER00114239", Color = "Brown", Material = "Leather", Description = "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 8399, CategoryId = 8},
            new ProductEntity(){ Id = 13, Name = "Boots-stockings on a stiletto are black", Article = "ER00114240", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 8399, CategoryId = 8},
            new ProductEntity(){ Id = 14, Name = "Ankle boots are black", Article = "ER00113949", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 2890, CategoryId = 7},
            new ProductEntity(){ Id = 15, Name = "Winter boots", Article = "ER00111942", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Winter", Price = 2290, CategoryId = 12},
        };
        public static List<ImageEntity> SeedImage() =>
            new List<ImageEntity>() {
            new ImageEntity(){ Id = 1, ImagePath = "Product1_1.jpg", ProductId = 1},
            new ImageEntity(){ Id = 2, ImagePath = "Product1_2.jpg", ProductId = 1},
            new ImageEntity(){ Id = 3, ImagePath = "Product1_3.jpg", ProductId = 1},
            new ImageEntity(){ Id = 4, ImagePath = "Product1_4.jpg", ProductId = 1},
            new ImageEntity(){ Id = 5, ImagePath = "Product1_5.jpg", ProductId = 1},
            new ImageEntity(){ Id = 6, ImagePath = "Product1_6.jpg", ProductId = 1},

            new ImageEntity(){ Id = 7, ImagePath = "Product2_1.jpg", ProductId = 2},
            new ImageEntity(){ Id = 8, ImagePath = "Product2_2.jpg", ProductId = 2},
            new ImageEntity(){ Id = 9, ImagePath = "Product2_3.jpg", ProductId = 2},
            new ImageEntity(){ Id = 10, ImagePath = "Product2_4.jpg", ProductId = 2},
            new ImageEntity(){ Id = 11, ImagePath = "Product2_5.jpg", ProductId = 2},
            new ImageEntity(){ Id = 12, ImagePath = "Product2_6.jpg", ProductId = 2},
            new ImageEntity(){ Id = 13, ImagePath = "Product2_7.jpg", ProductId = 2},
            new ImageEntity(){ Id = 14, ImagePath = "Product2_8.jpg", ProductId = 2},
            new ImageEntity(){ Id = 15, ImagePath = "Product2_9.jpg", ProductId = 2},

            new ImageEntity(){ Id = 16, ImagePath = "Product3_1.jpg", ProductId = 3},
            new ImageEntity(){ Id = 17, ImagePath = "Product3_2.jpg", ProductId = 3},
            new ImageEntity(){ Id = 18, ImagePath = "Product3_3.jpg", ProductId = 3},
            new ImageEntity(){ Id = 19, ImagePath = "Product3_4.jpg", ProductId = 3},
            new ImageEntity(){ Id = 20, ImagePath = "Product3_5.jpg", ProductId = 3},

            new ImageEntity(){ Id = 21, ImagePath = "Product4_1.jpg", ProductId = 4},
            new ImageEntity(){ Id = 22, ImagePath = "Product4_2.jpg", ProductId = 4},
            new ImageEntity(){ Id = 23, ImagePath = "Product4_3.jpg", ProductId = 4},
            new ImageEntity(){ Id = 24, ImagePath = "Product4_4.jpg", ProductId = 4},
            new ImageEntity(){ Id = 25, ImagePath = "Product4_5.jpg", ProductId = 4},
            new ImageEntity(){ Id = 26, ImagePath = "Product4_6.jpg", ProductId = 4},

            new ImageEntity(){ Id = 27, ImagePath = "Product5_1.jpg", ProductId = 5},
            new ImageEntity(){ Id = 28, ImagePath = "Product5_2.jpg", ProductId = 5},
            new ImageEntity(){ Id = 29, ImagePath = "Product5_3.jpg", ProductId = 5},
            new ImageEntity(){ Id = 30, ImagePath = "Product5_4.jpg", ProductId = 5},
            new ImageEntity(){ Id = 31, ImagePath = "Product5_5.jpg", ProductId = 5},
            new ImageEntity(){ Id = 32, ImagePath = "Product5_6.jpg", ProductId = 5},

            new ImageEntity(){ Id = 33, ImagePath = "Product6_1.jpg", ProductId = 6},
            new ImageEntity(){ Id = 34, ImagePath = "Product6_2.jpg", ProductId = 6},
            new ImageEntity(){ Id = 35, ImagePath = "Product6_3.jpg", ProductId = 6},
            new ImageEntity(){ Id = 36, ImagePath = "Product6_4.jpg", ProductId = 6},
            new ImageEntity(){ Id = 37, ImagePath = "Product6_5.jpg", ProductId = 6},
            new ImageEntity(){ Id = 38, ImagePath = "Product6_6.jpg", ProductId = 6},

            new ImageEntity(){ Id = 39, ImagePath = "Product7_1.jpg", ProductId = 7},
            new ImageEntity(){ Id = 40, ImagePath = "Product7_2.jpg", ProductId = 7},
            new ImageEntity(){ Id = 41, ImagePath = "Product7_3.jpg", ProductId = 7},
            new ImageEntity(){ Id = 42, ImagePath = "Product7_4.jpg", ProductId = 7},
            new ImageEntity(){ Id = 43, ImagePath = "Product7_5.jpg", ProductId = 7},

            new ImageEntity(){ Id = 44, ImagePath = "Product8_1.jpg", ProductId = 8},
            new ImageEntity(){ Id = 45, ImagePath = "Product8_2.jpg", ProductId = 8},
            new ImageEntity(){ Id = 46, ImagePath = "Product8_3.jpg", ProductId = 8},
            new ImageEntity(){ Id = 47, ImagePath = "Product8_4.jpg", ProductId = 8},
            new ImageEntity(){ Id = 48, ImagePath = "Product8_5.jpg", ProductId = 8},
            new ImageEntity(){ Id = 49, ImagePath = "Product8_6.jpg", ProductId = 8},
            new ImageEntity(){ Id = 50, ImagePath = "Product8_7.jpg", ProductId = 8},

            new ImageEntity(){ Id = 51, ImagePath = "Product9_1.jpg", ProductId = 9},
            new ImageEntity(){ Id = 52, ImagePath = "Product9_2.jpg", ProductId = 9},
            new ImageEntity(){ Id = 53, ImagePath = "Product9_3.jpg", ProductId = 9},
            new ImageEntity(){ Id = 54, ImagePath = "Product9_4.jpg", ProductId = 9},
            new ImageEntity(){ Id = 55, ImagePath = "Product9_5.jpg", ProductId = 9},
            new ImageEntity(){ Id = 56, ImagePath = "Product9_6.jpg", ProductId = 9},

            new ImageEntity(){ Id = 57, ImagePath = "Product10_1.jpg", ProductId = 10},
            new ImageEntity(){ Id = 58, ImagePath = "Product10_2.jpg", ProductId = 10},
            new ImageEntity(){ Id = 59, ImagePath = "Product10_3.jpg", ProductId = 10},
            new ImageEntity(){ Id = 60, ImagePath = "Product10_4.jpg", ProductId = 10},
            new ImageEntity(){ Id = 61, ImagePath = "Product10_5.jpg", ProductId = 10},
            new ImageEntity(){ Id = 62, ImagePath = "Product10_6.jpg", ProductId = 10},
            new ImageEntity(){ Id = 63, ImagePath = "Product10_7.jpg", ProductId = 10},
            new ImageEntity(){ Id = 64, ImagePath = "Product10_8.jpg", ProductId = 10},

            new ImageEntity(){ Id = 65, ImagePath = "Product11_1.jpg", ProductId = 11},
            new ImageEntity(){ Id = 66, ImagePath = "Product11_2.jpg", ProductId = 11},
            new ImageEntity(){ Id = 67, ImagePath = "Product11_3.jpg", ProductId = 11},
            new ImageEntity(){ Id = 68, ImagePath = "Product11_4.jpg", ProductId = 11},
            new ImageEntity(){ Id = 69, ImagePath = "Product11_5.jpg", ProductId = 11},
            new ImageEntity(){ Id = 70, ImagePath = "Product11_6.jpg", ProductId = 11},

            new ImageEntity(){ Id = 71, ImagePath = "Product12_1.jpg", ProductId = 12},
            new ImageEntity(){ Id = 72, ImagePath = "Product12_2.jpg", ProductId = 12},
            new ImageEntity(){ Id = 73, ImagePath = "Product12_3.jpg", ProductId = 12},
            new ImageEntity(){ Id = 74, ImagePath = "Product12_4.jpg", ProductId = 12},
            new ImageEntity(){ Id = 75, ImagePath = "Product12_5.jpg", ProductId = 12},
            new ImageEntity(){ Id = 76, ImagePath = "Product12_6.jpg", ProductId = 12},

            new ImageEntity(){ Id = 77, ImagePath = "Product13_1.jpg", ProductId = 13},
            new ImageEntity(){ Id = 78, ImagePath = "Product13_2.jpg", ProductId = 13},
            new ImageEntity(){ Id = 79, ImagePath = "Product13_3.jpg", ProductId = 13},
            new ImageEntity(){ Id = 80, ImagePath = "Product13_4.jpg", ProductId = 13},
            new ImageEntity(){ Id = 81, ImagePath = "Product13_5.jpg", ProductId = 13},
            new ImageEntity(){ Id = 82, ImagePath = "Product13_6.jpg", ProductId = 13},

            new ImageEntity(){ Id = 83, ImagePath = "Product14_1.jpg", ProductId = 14},
            new ImageEntity(){ Id = 84, ImagePath = "Product14_2.jpg", ProductId = 14},
            new ImageEntity(){ Id = 85, ImagePath = "Product14_3.jpg", ProductId = 14},
            new ImageEntity(){ Id = 86, ImagePath = "Product14_4.jpg", ProductId = 14},
            new ImageEntity(){ Id = 87, ImagePath = "Product14_5.jpg", ProductId = 14},
            new ImageEntity(){ Id = 88, ImagePath = "Product14_6.jpg", ProductId = 14},

            new ImageEntity(){ Id = 89, ImagePath = "Product15_1.jpg", ProductId = 15},
            new ImageEntity(){ Id = 90, ImagePath = "Product15_2.jpg", ProductId = 15},
            new ImageEntity(){ Id = 91, ImagePath = "Product15_3.jpg", ProductId = 15},
            new ImageEntity(){ Id = 92, ImagePath = "Product15_4.jpg", ProductId = 15},
            new ImageEntity(){ Id = 93, ImagePath = "Product15_5.jpg", ProductId = 15},
            new ImageEntity(){ Id = 94, ImagePath = "Product15_6.jpg", ProductId = 15},
            };
        public static List<StorageEntity> SeedStorage() =>
            new List<StorageEntity>() {
            new StorageEntity(){ Id = 1, ProductId = 1, Size = 36, ProductQuantity = 8, inStock = true },
            new StorageEntity(){ Id = 2, ProductId = 1, Size = 37, ProductQuantity = 20, inStock = true  },
            new StorageEntity(){ Id = 3, ProductId = 1, Size = 38, ProductQuantity = 40, inStock = true  },
            new StorageEntity(){ Id = 4, ProductId = 1, Size = 39, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 5, ProductId = 1, Size = 40, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 6, ProductId = 1, Size = 41, ProductQuantity = 10, inStock = true  },

            new StorageEntity(){ Id = 7, ProductId = 2, Size = 36, ProductQuantity = 12, inStock = true  },
            new StorageEntity(){ Id = 8, ProductId = 2, Size = 37, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 9, ProductId = 2, Size = 38, ProductQuantity = 40, inStock = true  },
            new StorageEntity(){ Id = 10, ProductId = 2, Size = 39, ProductQuantity = 30, inStock = true  },
            new StorageEntity(){ Id = 11, ProductId = 2, Size = 40, ProductQuantity = 40, inStock = true  },
            new StorageEntity(){ Id = 12, ProductId = 2, Size = 41, ProductQuantity = 20, inStock = true  },

            new StorageEntity(){ Id = 13, ProductId = 3, Size = 36, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 14, ProductId = 3, Size = 37, ProductQuantity = 1, inStock = true  },
            new StorageEntity(){ Id = 15, ProductId = 3, Size = 38, ProductQuantity = 1, inStock = true  },
            new StorageEntity(){ Id = 16, ProductId = 3, Size = 39, ProductQuantity = 1, inStock = true  },
            new StorageEntity(){ Id = 17, ProductId = 3, Size = 40, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 18, ProductId = 3, Size = 41, ProductQuantity = 0, inStock = false  },

            new StorageEntity(){ Id = 19, ProductId = 4, Size = 36, ProductQuantity = 9, inStock = true  },
            new StorageEntity(){ Id = 20, ProductId = 4, Size = 37, ProductQuantity = 8, inStock = true  },
            new StorageEntity(){ Id = 21, ProductId = 4, Size = 38, ProductQuantity = 8, inStock = true  },
            new StorageEntity(){ Id = 22, ProductId = 4, Size = 39, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 23, ProductId = 4, Size = 40, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 24, ProductId = 4, Size = 41, ProductQuantity = 0, inStock = false  },

            new StorageEntity(){ Id = 25, ProductId = 5, Size = 36, ProductQuantity = 7, inStock = true  },
            new StorageEntity(){ Id = 26, ProductId = 5, Size = 37, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 27, ProductId = 5, Size = 38, ProductQuantity = 8, inStock = true  },
            new StorageEntity(){ Id = 28, ProductId = 5, Size = 39, ProductQuantity = 9, inStock = true  },
            new StorageEntity(){ Id = 29, ProductId = 5, Size = 40, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 30, ProductId = 5, Size = 41, ProductQuantity = 0, inStock = false  },

            new StorageEntity(){ Id = 31, ProductId = 6, Size = 36, ProductQuantity = 9, inStock = true  },
            new StorageEntity(){ Id = 32, ProductId = 6, Size = 37, ProductQuantity = 8, inStock = true  },
            new StorageEntity(){ Id = 33, ProductId = 6, Size = 38, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 34, ProductId = 6, Size = 39, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 35, ProductId = 6, Size = 40, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 36, ProductId = 6, Size = 41, ProductQuantity = 0, inStock = false  },

            new StorageEntity(){ Id = 37, ProductId = 7, Size = 36, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 38, ProductId = 7, Size = 37, ProductQuantity = 8, inStock = true  },
            new StorageEntity(){ Id = 39, ProductId = 7, Size = 38, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 40, ProductId = 7, Size = 39, ProductQuantity = 9, inStock = true  },
            new StorageEntity(){ Id = 41, ProductId = 7, Size = 40, ProductQuantity = 8, inStock = false  },
            new StorageEntity(){ Id = 42, ProductId = 7, Size = 41, ProductQuantity = 0, inStock = false  },

            new StorageEntity(){ Id = 43, ProductId = 8, Size = 36, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 44, ProductId = 8, Size = 37, ProductQuantity = 4, inStock = true  },
            new StorageEntity(){ Id = 45, ProductId = 8, Size = 38, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 46, ProductId = 8, Size = 39, ProductQuantity = 8, inStock = true  },
            new StorageEntity(){ Id = 47, ProductId = 8, Size = 40, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 48, ProductId = 8, Size = 41, ProductQuantity = 0, inStock = false  },

            new StorageEntity(){ Id = 49, ProductId = 9, Size = 36, ProductQuantity = 5, inStock = true  },
            new StorageEntity(){ Id = 50, ProductId = 9, Size = 37, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 51, ProductId = 9, Size = 38, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 52, ProductId = 9, Size = 39, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 53, ProductId = 9, Size = 40, ProductQuantity = 7, inStock = true  },
            new StorageEntity(){ Id = 54, ProductId = 9, Size = 41, ProductQuantity = 0, inStock = false  },

            new StorageEntity(){ Id = 55, ProductId = 10, Size = 36, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 56, ProductId = 10, Size = 37, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 57, ProductId = 10, Size = 38, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 58, ProductId = 10, Size = 39, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 59, ProductId = 10, Size = 40, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 60, ProductId = 10, Size = 41, ProductQuantity = 0, inStock = false  },

            new StorageEntity(){ Id = 61, ProductId = 11, Size = 36, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 62, ProductId = 11, Size = 37, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 63, ProductId = 11, Size = 38, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 64, ProductId = 11, Size = 39, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 65, ProductId = 11, Size = 40, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 66, ProductId = 11, Size = 41, ProductQuantity = 0, inStock = false  },

            new StorageEntity(){ Id = 67, ProductId = 12, Size = 36, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 68, ProductId = 12, Size = 37, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 69, ProductId = 12, Size = 38, ProductQuantity = 50, inStock = true  },
            new StorageEntity(){ Id = 70, ProductId = 12, Size = 39, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 71, ProductId = 12, Size = 40, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 72, ProductId = 12, Size = 41, ProductQuantity = 0, inStock = false  },

            new StorageEntity(){ Id = 73, ProductId = 13, Size = 36, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 74, ProductId = 13, Size = 37, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 75, ProductId = 13, Size = 38, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 76, ProductId = 13, Size = 39, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 77, ProductId = 13, Size = 40, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 78, ProductId = 13, Size = 41, ProductQuantity = 0, inStock = false  },

            new StorageEntity(){ Id = 79, ProductId = 14, Size = 36, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 80, ProductId = 14, Size = 37, ProductQuantity = 15, inStock = true  },
            new StorageEntity(){ Id = 81, ProductId = 14, Size = 38, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 82, ProductId = 14, Size = 39, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 83, ProductId = 14, Size = 40, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 84, ProductId = 14, Size = 41, ProductQuantity = 0, inStock = false  },

            new StorageEntity(){ Id = 85, ProductId = 15, Size = 39, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 86, ProductId = 15, Size = 40, ProductQuantity = 15, inStock = true  },
            new StorageEntity(){ Id = 87, ProductId = 15, Size = 41, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 88, ProductId = 15, Size = 42, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 89, ProductId = 15, Size = 43, ProductQuantity = 10, inStock = true  },
            new StorageEntity(){ Id = 90, ProductId = 15, Size = 44, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 91, ProductId = 15, Size = 45, ProductQuantity = 0, inStock = false  },
            new StorageEntity(){ Id = 92, ProductId = 15, Size = 46, ProductQuantity = 0, inStock = false  },



            };
        public static List<ImageForHome> SeedImageForHome() =>
            new List<ImageForHome>() {
            new ImageForHome(){ Id = 1, ImagePath = "800_home_page_1.webp"},
            new ImageForHome(){ Id = 2, ImagePath = "800_home_page_2.webp"},
            new ImageForHome(){ Id = 3, ImagePath = "800_home_page_3.webp"},
            new ImageForHome(){ Id = 4, ImagePath = "800_home_page_4.webp"},
            };

        public static List<User> SeedUser() =>
    new List<User>() {
            new User(){ Email = "admin@ukr.net", Role = "Admin", UserName = "Admin", FirstName = "Admin", Password = "Qwerty-7"  },

    };

        public static List<Info> SeedInfos() =>
            new List<Info>() {
            new Info () { Id = 1, Name = "Color" },
            new Info () { Id = 2, Name = "Material" },
            new Info () { Id = 3, Name = "Size" },
            //new Info () { Id = 4, Name = "Size" },
            new Info () { Id = 5, Name = "Purpose" },
        };


        public static List<Options> SeedOptions() =>
            new List<Options>() {
                    new Options () { Id = 1, Value = "black", Label = "Black", InfoId = 1 },
                    new Options () { Id = 2, Value = "brown", Label = "Brown", InfoId = 1 },
                    new Options () { Id = 3, Value = "gray", Label = "Gray", InfoId = 1 },
                    new Options () { Id = 4, Value = "lightgray", Label = "Light Gray", InfoId = 1 },
                    new Options () { Id = 5, Value = "white", Label = "White", InfoId = 1 },
                    new Options () { Id = 6, Value = "milk", Label = "Milk", InfoId = 1 },
                    new Options () { Id = 7, Value = "navi", Label = "Navi", InfoId = 1 },
                    new Options () { Id = 8, Value = "blue", Label = "Blue", InfoId = 1 },

                    new Options () { Id = 9, Value = "leather", Label = "Leather", InfoId = 2 },
                    new Options () { Id = 10, Value = "suede", Label = "Suede", InfoId = 2 },
                    new Options () { Id = 11, Value = "nubuck", Label = "Nubuck", InfoId = 2 },
                    new Options () { Id = 12, Value = "textile", Label = "Textile", InfoId = 2 },
                    new Options () { Id = 13, Value = "synthetic", Label = "Synthetic", InfoId = 2 },
                    new Options () { Id = 14, Value = "ecoleather", Label = "Eco Leather", InfoId = 2 },

                    new Options () { Id = 15, Value = "35", Label = "35", InfoId = 3 },
                    new Options () { Id = 16, Value = "36", Label = "36", InfoId = 3 },
                    new Options () { Id = 17, Value = "37", Label = "37", InfoId = 3 },
                    new Options () { Id = 18, Value = "38", Label = "38", InfoId = 3 },
                    new Options () { Id = 19, Value = "39", Label = "39", InfoId = 3 },
                    new Options () { Id = 20, Value = "40", Label = "40", InfoId = 3 },
                    new Options () { Id = 21, Value = "41", Label = "41", InfoId = 3 },
                    
                    new Options () { Id = 25, Value = "42", Label = "42", InfoId = 3 },
                    new Options () { Id = 26, Value = "43", Label = "43", InfoId = 3 },
                    new Options () { Id = 27, Value = "44", Label = "44", InfoId = 3 },
                    new Options () { Id = 28, Value = "45", Label = "45", InfoId = 3 },
                    new Options () { Id = 29, Value = "46", Label = "46", InfoId = 3 },


                    //new Options () { Id = 22, Value = "39", Label = "39", InfoId = 4 },
                    //new Options () { Id = 23, Value = "40", Label = "40", InfoId = 4 },
                    //new Options () { Id = 24, Value = "41", Label = "41", InfoId = 4 },
                    //new Options () { Id = 25, Value = "42", Label = "42", InfoId = 4 },
                    //new Options () { Id = 26, Value = "43", Label = "43", InfoId = 4 },
                    //new Options () { Id = 27, Value = "44", Label = "44", InfoId = 4 },
                    //new Options () { Id = 28, Value = "45", Label = "45", InfoId = 4 },
                    //new Options () { Id = 29, Value = "46", Label = "46", InfoId = 4 },

                    new Options () { Id = 30, Value = "winter", Label = "Winter", InfoId = 5 },
                    new Options () { Id = 31, Value = "spring", Label = "Spring", InfoId = 5 },
                    new Options () { Id = 32, Value = "summer", Label = "Summer", InfoId = 5 },
                    new Options () { Id = 33, Value = "autumn ", Label = "Autumn", InfoId = 5 },

            };
    };


};
