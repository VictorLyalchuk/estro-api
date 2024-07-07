using Core.Entities.Category;
using Core.Entities.Product;
using Core.Entities.Store;
using Core.Entities.Address;

namespace Infrastructure.Data
{
    public static class SeedData
    {

        public static List<MainCategory> SeedMainCategory() =>
        new List<MainCategory>() {
            new MainCategory(){ Id = 1, Name_en = "Women", Name_uk = "Жіноче", Name_fr = "Femme", Name_es = "Mujer", URLName = "woman" }, 
            new MainCategory(){ Id = 2, Name_en = "Men", Name_uk = "Чоловіче", Name_fr = "Homme", Name_es = "Hombre", URLName = "man"}, 
        };

        public static List<SubCategory> SeedSubCategory() =>
        new List<SubCategory>() {
            new SubCategory(){ Id = 1, Name_en = "Women's Shoes", Name_fr = "Chaussures pour femmes", Name_uk = "Жіноче взуття", Name_es = "Zapatos de mujer", MainCategoryId = 1, URLName = "woman-shoes" },
            new SubCategory(){ Id = 2, Name_en = "Men's Shoes", Name_fr = "Chaussures pour hommes", Name_uk = "Чоловіче взуття", Name_es = "Zapatos de hombre", MainCategoryId = 2, URLName = "man-shoes" },
            new SubCategory(){ Id = 3, Name_en = "Women's Clothing", Name_fr = "Vêtements pour femmes", Name_uk = "Жіночий одяг", Name_es = "Ropa de mujer", MainCategoryId = 1, URLName = "woman-clothing" },
            new SubCategory(){ Id = 4, Name_en = "Men's Clothing", Name_fr = "Vêtements pour hommes", Name_uk = "Чоловічий одяг", Name_es = "Ropa de hombre", MainCategoryId = 2, URLName = "man-clothing" },
            new SubCategory(){ Id = 5, Name_en = "Women's Accessories", Name_fr = "Accessoires pour femmes", Name_uk = "Жіночі аксесуари", Name_es = "Accesorios de mujer", MainCategoryId = 1, URLName = "woman-accessories" },
            new SubCategory(){ Id = 6, Name_en = "Men's Accessories", Name_fr = "Accessoires pour hommes", Name_uk = "Чоловічі аксесуари", Name_es = "Accesorios de hombre", MainCategoryId = 2, URLName = "man-accessories" },
        };

        public static List<CategoryEntity> SeedCategory() =>
     new List<CategoryEntity>() {
        new CategoryEntity(){ Id = 1, Name_en = "Open shoes", Name_fr = "Chaussures ouvertes", Name_uk = "Відкрите взуття", Name_es = "Zapatos abiertos", SubCategoryId = 1, URLName = "open-shoes" },
        new CategoryEntity(){ Id = 2, Name_en = "Pumps and loafers", Name_fr = "Escarpins et mocassins", Name_uk = "Туфлі та лофери", Name_es = "Zapatos de tacón y mocasines", SubCategoryId = 1, URLName = "pumps-and-loafers" },
        new CategoryEntity(){ Id = 3, Name_en = "Heeled shoes", Name_fr = "Chaussures à talons", Name_uk = "Туфлі на підборах", Name_es = "Zapatos de tacón", SubCategoryId = 1, URLName = "heeled-shoes" },
        new CategoryEntity(){ Id = 4, Name_en = "Women's athletic sneakers", Name_fr = "Baskets de sport pour femmes", Name_uk = "Кросівки жіночі", Name_es = "Zapatillas deportivas para mujeres", SubCategoryId = 1, URLName = "women-s-athletic-sneakers" },
        new CategoryEntity(){ Id = 5, Name_en = "Women's sneakers", Name_fr = "Baskets pour femmes", Name_uk = "Жіночі кеди", Name_es = "Zapatillas para mujeres", SubCategoryId = 1, URLName = "women-sneakers" },
        new CategoryEntity(){ Id = 6, Name_en = "High boots and Chelsea", Name_fr = "Bottes hautes et Chelsea", Name_uk = "Високі черевики, челсі", Name_es = "Botas altas y Chelsea", SubCategoryId = 1, URLName = "high-boots-&-chelsea" },
        new CategoryEntity(){ Id = 7, Name_en = "Boots on heels", Name_fr = "Bottes à talons", Name_uk = "Черевики на підборах", Name_es = "Botas de tacón", SubCategoryId = 1, URLName = "boots-on-heels" },
        new CategoryEntity(){ Id = 8, Name_en = "Boots and high boots", Name_fr = "Bottes et bottes hautes", Name_uk = "Чоботи та ботфорти", Name_es = "Botas y botas altas", SubCategoryId = 1, URLName = "boots-and-high-boots" },
        new CategoryEntity(){ Id = 9, Name_en = "Cossacks boots", Name_fr = "Bottes Cossacks", Name_uk = "Козаки", Name_es = "Botas de cosaco", SubCategoryId = 1, URLName = "cossacks-boots" },
        new CategoryEntity(){ Id = 10, Name_en = "Winter footwear", Name_fr = "Chaussures d'hiver", Name_uk = "Зимове взуття", Name_es = "Calzado de invierno", SubCategoryId = 1, URLName = "winter-footwear" },
        new CategoryEntity(){ Id = 11, Name_en = "Perforated shoes", Name_fr = "Chaussures perforées", Name_uk = "Перфороване взуття", Name_es = "Zapatos perforados", SubCategoryId = 1, URLName = "perforated-shoes" },
        new CategoryEntity(){ Id = 12, Name_en = "Men's boots", Name_fr = "Bottes pour hommes", Name_uk = "Чоловічі черевики", Name_es = "Botas para hombres", SubCategoryId = 2, URLName = "men-boots" },
        new CategoryEntity(){ Id = 13, Name_en = "Men's athletic sneakers", Name_fr = "Baskets de sport pour hommes", Name_uk = "Чоловічі кросівки", Name_es = "Zapatillas deportivas para hombres", SubCategoryId = 2, URLName = "man-athletic-sneakers" },
        new CategoryEntity(){ Id = 14, Name_en = "Men's sneakers", Name_fr = "Baskets pour hommes", Name_uk = "Чоловічі кеди", Name_es = "Zapatillas para hombres", SubCategoryId = 2, URLName = "man-sneakers" },
        new CategoryEntity(){ Id = 15, Name_en = "Men's pumps", Name_fr = "Escarpins pour hommes", Name_uk = "Чоловічі туфлі", Name_es = "Zapatos de tacón para hombres", SubCategoryId = 2, URLName = "man-pumps" },
        new CategoryEntity(){ Id = 16, Name_en = "Men's moccasins", Name_fr = "Mocassins pour hommes", Name_uk = "Чоловічі мокасини", Name_es = "Mocasines para hombres", SubCategoryId = 2, URLName = "man-moccasins" },
        new CategoryEntity(){ Id = 17, Name_en = "Men's summer shoes", Name_fr = "Chaussures d'été pour hommes", Name_uk = "Чоловічі літнє взуття", Name_es = "Zapatos de verano para hombres", SubCategoryId = 2, URLName = "man-summer-shoes" },
        new CategoryEntity(){ Id = 18, Name_en = "Women's outerwear", Name_fr = "Vêtements d'extérieur pour femmes", Name_uk = "Жіночий верхній одяг", Name_es = "Ropa exterior para mujeres", SubCategoryId = 3, URLName = "woman-outerwear" },
        new CategoryEntity(){ Id = 19, Name_en = "Women's sweaters and suits", Name_fr = "Pulls et costumes pour femmes", Name_uk = "Жіночі светри та костюми", Name_es = "Suéteres y trajes para mujeres", SubCategoryId = 3, URLName = "woman-sweaters-and-suits" },
        new CategoryEntity(){ Id = 20, Name_en = "Women's t-shirts and sweatshirts", Name_fr = "T-shirts et sweatshirts pour femmes", Name_uk = "Жіночі футболки та світшоти", Name_es = "Camisetas y sudaderas para mujeres", SubCategoryId = 3, URLName = "woman-t-shirts-and-sweatshirts" },
        new CategoryEntity(){ Id = 21, Name_en = "Women's shawl", Name_fr = "Châle pour femmes", Name_uk = "Жіночі хустки", Name_es = "Chal para mujeres", SubCategoryId = 3, URLName = "woman-shawl" },
        new CategoryEntity(){ Id = 22, Name_en = "Women's scarves and hats", Name_fr = "Écharpes et chapeaux pour femmes", Name_uk = "Жіночі шарфи та шапки", Name_es = "Bufandas y sombreros para mujeres", SubCategoryId = 3, URLName = "woman-scarves-and-hats" },
        new CategoryEntity(){ Id = 23, Name_en = "Women's gloves", Name_fr = "Gants pour femmes", Name_uk = "Жіночі рукавички", Name_es = "Guantes para mujeres", SubCategoryId = 3, URLName = "woman-gloves" },
        new CategoryEntity(){ Id = 24, Name_en = "Women's socks and tights", Name_fr = "Chaussettes et collants pour femmes", Name_uk = "Жіночі шкарпетки та колготи", Name_es = "Calcetines y pantimedias para mujeres", SubCategoryId = 3, URLName = "woman-socks-and-tights" },
        new CategoryEntity(){ Id = 25, Name_en = "Men's outerwear", Name_fr = "Vêtements d'extérieur pour hommes", Name_uk = "Чоловічий верхній одяг", Name_es = "Ropa exterior para hombres", SubCategoryId = 4, URLName = "man-outerwear" },
        new CategoryEntity(){ Id = 26, Name_en = "Men's sweaters and suits", Name_fr = "Pulls et costumes pour hommes", Name_uk = "Чоловічі светри та костюми", Name_es = "Suéteres y trajes para hombres", SubCategoryId = 4, URLName = "man-sweaters-and-suits" },
        new CategoryEntity(){ Id = 27, Name_en = "Men's t-shirts and sweatshirts", Name_fr = "T-shirts et sweatshirts pour hommes", Name_uk = "Чоловікі футболки та світшоти", Name_es = "Camisetas y sudaderas para hombres", SubCategoryId = 4, URLName = "man-t-shirts-and-sweatshirts" },
        new CategoryEntity(){ Id = 28, Name_en = "Men's scarves and hats", Name_fr = "Écharpes et chapeaux pour hommes", Name_uk = "Чоловічі шарфи та шапки", Name_es = "Bufandas y sombreros para hombres", SubCategoryId = 4, URLName = "man-scarves-and-hats" },
        new CategoryEntity(){ Id = 29, Name_en = "Men's gloves", Name_fr = "Gants pour hommes", Name_uk = "Чоловічі рукавички", Name_es = "Guantes para hombres", SubCategoryId = 4, URLName = "man-gloves" },
        new CategoryEntity(){ Id = 30, Name_en = "Men's socks", Name_fr = "Chaussettes pour hommes", Name_uk = "Чоловічі шкарпетки", Name_es = "Calcetines para hombres", SubCategoryId = 4, URLName = "man-socks" },
        new CategoryEntity(){ Id = 31, Name_en = "Women's glasses", Name_fr = "Lunettes pour femmes", Name_uk = "Жіночі окуляри", Name_es = "Gafas para mujeres", SubCategoryId = 5, URLName = "woman-glasses" },
        new CategoryEntity(){ Id = 32, Name_en = "Women's home shoes", Name_fr = "Chaussures de maison pour femmes", Name_uk = "Жіноче домашнє взуття", Name_es = "Zapatos de casa para mujeres", SubCategoryId = 5, URLName = "woman-home-shoes" },
        new CategoryEntity(){ Id = 33, Name_en = "Women's bags", Name_fr = "Sacs pour femmes", Name_uk = "Жіночі сумки", Name_es = "Bolsos para mujeres", SubCategoryId = 5, URLName = "woman-bags" },
        new CategoryEntity(){ Id = 34, Name_en = "Women's backpacks", Name_fr = "Sacs à dos pour femmes", Name_uk = "Жіночі рюкзаки для жінок", Name_es = "Mochilas para mujeres", SubCategoryId = 5, URLName = "woman-backpacks" },
        new CategoryEntity(){ Id = 35, Name_en = "Women's care products", Name_fr = "Produits de soin pour femmes", Name_uk = "Жіночі засоби для догляду", Name_es = "Productos de cuidado para mujeres", SubCategoryId = 5, URLName = "woman-care-products" },
        new CategoryEntity(){ Id = 36, Name_en = "Men's glasses", Name_fr = "Lunettes pour hommes", Name_uk = "Чоловічі окуляри", Name_es = "Gafas para hombres", SubCategoryId = 6, URLName = "man-glasses" },
        new CategoryEntity(){ Id = 37, Name_en = "Men's home shoes", Name_fr = "Chaussures de maison pour hommes", Name_uk = "Чоловіче домашнє взуття", Name_es = "Zapatos de casa para hombres", SubCategoryId = 6, URLName = "man-home-shoes" },
        new CategoryEntity(){ Id = 38, Name_en = "Men's bags", Name_fr = "Sacs pour hommes", Name_uk = "Чоловічі сумки", Name_es = "Bolsos para hombres", SubCategoryId = 6, URLName = "man-bags" },
        new CategoryEntity(){ Id = 39, Name_en = "Men's backpacks", Name_fr = "Sacs à dos pour hommes", Name_uk = "Чоловічі рюкзаки", Name_es = "Mochilas para hombres", SubCategoryId = 6, URLName = "man-backpacks" },
        new CategoryEntity(){ Id = 40, Name_en = "Men's care products", Name_fr = "Produits de soin pour hommes", Name_uk = "Чоловічі засоби для догляду", Name_es = "Productos de cuidado para hombres", SubCategoryId = 6, URLName = "man-care-products" },
     };

        public static List<ProductEntity> SeedProduct() =>
        new List<ProductEntity>() {
            new ProductEntity(){ Id = 1, Name = "Boots-stockings are black leather", Article = "ER00113828", Color = "Black", Material = "Leather", Description = "These stylish black leather boots-stockings are a perfect blend of fashion and comfort. Crafted with high-quality leather, they provide a sleek and sophisticated look. Ideal for various occasions, these boots-stockings are a must-have in your wardrobe.", Purpose = "Autumn", Price = 7399, CategoryId = 8, Details = "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", Highlights = ["Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton"] },
            new ProductEntity(){ Id = 2, Name = "Autumn brown leather stretch boots", Article = "ER00112019", Color = "Brown", Material = "Leather", Description = "Step into the season with elegance in these Autumn brown leather stretch boots. Meticulously crafted from premium leather, these boots offer both style and comfort. The stretch feature ensures a snug fit, while the rich brown color adds a touch of warmth to your autumn wardrobe. Perfect for any occasion, these boots are a fashion statement that complements your unique style. Embrace the essence of autumn with each step.", Purpose = "Autumn", Price = 8899, CategoryId = 8, Details = "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", Highlights = ["Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton"] },
            new ProductEntity(){ Id = 3, Name = "Autumn leather stretch boots", Article = "ER00112018", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 8899, CategoryId = 8, Details = "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", Highlights = ["Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton"] },
            new ProductEntity(){ Id = 4, Name = "Boots autumn leather black", Article = "ER00112022", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 9899, CategoryId = 8, Details = "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", Highlights = ["Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton"] },
            new ProductEntity(){ Id = 5, Name = "Black autumn leather stretch boots", Article = "ER00112011", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 9899, CategoryId = 8, Details = "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", Highlights = ["Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton"] },
            new ProductEntity(){ Id = 6, Name = "Black demi-season boots", Article = "ER00113851", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 8799, CategoryId = 8, Details = "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", Highlights = ["Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton"] },
            new ProductEntity(){ Id = 7, Name = "Boots-stockings leather black", Article = "ER00112023", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 9989, CategoryId = 8, Details = "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", Highlights = ["Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton"] },
            new ProductEntity(){ Id = 8, Name = "Boots-pipes with wide freebies are burgundy", Article = "ER00114318", Color = "Burgundy", Material = "Leather", Description = "Estro ER00112018 Burgundy Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 9989, CategoryId = 8, Details = "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", Highlights = ["Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton"] },
            new ProductEntity(){ Id = 9, Name = "Black leather Cossack boots", Article = "ER00112298", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 8799, CategoryId = 8, Details = "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", Highlights = ["Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton"] },
            new ProductEntity(){ Id = 10, Name = "Boots-stockings on a stiletto are black", Article = "ER00112123", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 8699, CategoryId = 8, Details = "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", Highlights = ["Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton"] },
            new ProductEntity(){ Id = 11, Name = "Milk stiletto stocking boots", Article = "ER00112122", Color = "Milk", Material = "Leather", Description = "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 8699, CategoryId = 8, Details = "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", Highlights = ["Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton"] },
            new ProductEntity(){ Id = 12, Name = "Boots-stockings on a stiletto are brown", Article = "ER00114239", Color = "Brown", Material = "Leather", Description = "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 8399, CategoryId = 8, Details = "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", Highlights = ["Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton"] },
            new ProductEntity(){ Id = 13, Name = "Boots-stockings on a stiletto are black", Article = "ER00114240", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 8399, CategoryId = 8, Details = "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", Highlights = ["Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton"] },
            new ProductEntity(){ Id = 14, Name = "Ankle boots are black", Article = "ER00113949", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Autumn", Price = 2890, CategoryId = 7, Details = "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", Highlights = ["Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton"] },
            new ProductEntity(){ Id = 15, Name = "Winter boots", Article = "ER00111942", Color = "Black", Material = "Leather", Description = "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", Purpose = "Winter", Price = 2290, CategoryId = 12, Details = "The Basic Tee 6-Pack allows you to fully express your vibrant personality with three grayscale options. Feeling adventurous? Put on a heather gray tee. Want to be a trendsetter? Try our exclusive colorway: \"Black\". Need to add an extra pop of color to your outfit? Our white tee has you covered.", Highlights = ["Hand cut and sewn locally", "Dyed with our proprietary colors", "Pre-washed & pre-shrunk", "Ultra-soft 100% cotton"] },
        };
        public static List<ImageEntity> SeedImage() =>
            new List<ImageEntity>() {
            new ImageEntity(){ Id = 1, ImagePath = "Product1_1.webp", ProductId = 1},
            new ImageEntity(){ Id = 2, ImagePath = "Product1_2.webp", ProductId = 1},
            new ImageEntity(){ Id = 3, ImagePath = "Product1_3.webp", ProductId = 1},
            new ImageEntity(){ Id = 4, ImagePath = "Product1_4.webp", ProductId = 1},
            new ImageEntity(){ Id = 5, ImagePath = "Product1_5.webp", ProductId = 1},
            new ImageEntity(){ Id = 6, ImagePath = "Product1_6.webp", ProductId = 1},

            new ImageEntity(){ Id = 7, ImagePath = "Product2_1.webp", ProductId = 2},
            new ImageEntity(){ Id = 8, ImagePath = "Product2_2.webp", ProductId = 2},
            new ImageEntity(){ Id = 9, ImagePath = "Product2_3.webp", ProductId = 2},
            new ImageEntity(){ Id = 10, ImagePath = "Product2_4.webp", ProductId = 2},
            new ImageEntity(){ Id = 11, ImagePath = "Product2_5.webp", ProductId = 2},
            new ImageEntity(){ Id = 12, ImagePath = "Product2_6.webp", ProductId = 2},
            new ImageEntity(){ Id = 13, ImagePath = "Product2_7.webp", ProductId = 2},
            new ImageEntity(){ Id = 14, ImagePath = "Product2_8.webp", ProductId = 2},
            new ImageEntity(){ Id = 15, ImagePath = "Product2_9.webp", ProductId = 2},

            new ImageEntity(){ Id = 16, ImagePath = "Product3_1.webp", ProductId = 3},
            new ImageEntity(){ Id = 17, ImagePath = "Product3_2.webp", ProductId = 3},
            new ImageEntity(){ Id = 18, ImagePath = "Product3_3.webp", ProductId = 3},
            new ImageEntity(){ Id = 19, ImagePath = "Product3_4.webp", ProductId = 3},
            new ImageEntity(){ Id = 20, ImagePath = "Product3_5.webp", ProductId = 3},

            new ImageEntity(){ Id = 21, ImagePath = "Product4_1.webp", ProductId = 4},
            new ImageEntity(){ Id = 22, ImagePath = "Product4_2.webp", ProductId = 4},
            new ImageEntity(){ Id = 23, ImagePath = "Product4_3.webp", ProductId = 4},
            new ImageEntity(){ Id = 24, ImagePath = "Product4_4.webp", ProductId = 4},
            new ImageEntity(){ Id = 25, ImagePath = "Product4_5.webp", ProductId = 4},
            new ImageEntity(){ Id = 26, ImagePath = "Product4_6.webp", ProductId = 4},

            new ImageEntity(){ Id = 27, ImagePath = "Product5_1.webp", ProductId = 5},
            new ImageEntity(){ Id = 28, ImagePath = "Product5_2.webp", ProductId = 5},
            new ImageEntity(){ Id = 29, ImagePath = "Product5_3.webp", ProductId = 5},
            new ImageEntity(){ Id = 30, ImagePath = "Product5_4.webp", ProductId = 5},
            new ImageEntity(){ Id = 31, ImagePath = "Product5_5.webp", ProductId = 5},
            new ImageEntity(){ Id = 32, ImagePath = "Product5_6.webp", ProductId = 5},

            new ImageEntity(){ Id = 33, ImagePath = "Product6_1.webp", ProductId = 6},
            new ImageEntity(){ Id = 34, ImagePath = "Product6_2.webp", ProductId = 6},
            new ImageEntity(){ Id = 35, ImagePath = "Product6_3.webp", ProductId = 6},
            new ImageEntity(){ Id = 36, ImagePath = "Product6_4.webp", ProductId = 6},
            new ImageEntity(){ Id = 37, ImagePath = "Product6_5.webp", ProductId = 6},
            new ImageEntity(){ Id = 38, ImagePath = "Product6_6.webp", ProductId = 6},

            new ImageEntity(){ Id = 39, ImagePath = "Product7_1.webp", ProductId = 7},
            new ImageEntity(){ Id = 40, ImagePath = "Product7_2.webp", ProductId = 7},
            new ImageEntity(){ Id = 41, ImagePath = "Product7_3.webp", ProductId = 7},
            new ImageEntity(){ Id = 42, ImagePath = "Product7_4.webp", ProductId = 7},
            new ImageEntity(){ Id = 43, ImagePath = "Product7_5.webp", ProductId = 7},

            new ImageEntity(){ Id = 44, ImagePath = "Product8_1.webp", ProductId = 8},
            new ImageEntity(){ Id = 45, ImagePath = "Product8_2.webp", ProductId = 8},
            new ImageEntity(){ Id = 46, ImagePath = "Product8_3.webp", ProductId = 8},
            new ImageEntity(){ Id = 47, ImagePath = "Product8_4.webp", ProductId = 8},
            new ImageEntity(){ Id = 48, ImagePath = "Product8_5.webp", ProductId = 8},
            new ImageEntity(){ Id = 49, ImagePath = "Product8_6.webp", ProductId = 8},
            new ImageEntity(){ Id = 50, ImagePath = "Product8_7.webp", ProductId = 8},

            new ImageEntity(){ Id = 51, ImagePath = "Product9_1.webp", ProductId = 9},
            new ImageEntity(){ Id = 52, ImagePath = "Product9_2.webp", ProductId = 9},
            new ImageEntity(){ Id = 53, ImagePath = "Product9_3.webp", ProductId = 9},
            new ImageEntity(){ Id = 54, ImagePath = "Product9_4.webp", ProductId = 9},
            new ImageEntity(){ Id = 55, ImagePath = "Product9_5.webp", ProductId = 9},
            new ImageEntity(){ Id = 56, ImagePath = "Product9_6.webp", ProductId = 9},

            new ImageEntity(){ Id = 57, ImagePath = "Product10_1.webp", ProductId = 10},
            new ImageEntity(){ Id = 58, ImagePath = "Product10_2.webp", ProductId = 10},
            new ImageEntity(){ Id = 59, ImagePath = "Product10_3.webp", ProductId = 10},
            new ImageEntity(){ Id = 60, ImagePath = "Product10_4.webp", ProductId = 10},
            new ImageEntity(){ Id = 61, ImagePath = "Product10_5.webp", ProductId = 10},
            new ImageEntity(){ Id = 62, ImagePath = "Product10_6.webp", ProductId = 10},
            new ImageEntity(){ Id = 63, ImagePath = "Product10_7.webp", ProductId = 10},
            new ImageEntity(){ Id = 64, ImagePath = "Product10_8.webp", ProductId = 10},

            new ImageEntity(){ Id = 65, ImagePath = "Product11_1.webp", ProductId = 11},
            new ImageEntity(){ Id = 66, ImagePath = "Product11_2.webp", ProductId = 11},
            new ImageEntity(){ Id = 67, ImagePath = "Product11_3.webp", ProductId = 11},
            new ImageEntity(){ Id = 68, ImagePath = "Product11_4.webp", ProductId = 11},
            new ImageEntity(){ Id = 69, ImagePath = "Product11_5.webp", ProductId = 11},
            new ImageEntity(){ Id = 70, ImagePath = "Product11_6.webp", ProductId = 11},

            new ImageEntity(){ Id = 71, ImagePath = "Product12_1.webp", ProductId = 12},
            new ImageEntity(){ Id = 72, ImagePath = "Product12_2.webp", ProductId = 12},
            new ImageEntity(){ Id = 73, ImagePath = "Product12_3.webp", ProductId = 12},
            new ImageEntity(){ Id = 74, ImagePath = "Product12_4.webp", ProductId = 12},
            new ImageEntity(){ Id = 75, ImagePath = "Product12_5.webp", ProductId = 12},
            new ImageEntity(){ Id = 76, ImagePath = "Product12_6.webp", ProductId = 12},

            new ImageEntity(){ Id = 77, ImagePath = "Product13_1.webp", ProductId = 13},
            new ImageEntity(){ Id = 78, ImagePath = "Product13_2.webp", ProductId = 13},
            new ImageEntity(){ Id = 79, ImagePath = "Product13_3.webp", ProductId = 13},
            new ImageEntity(){ Id = 80, ImagePath = "Product13_4.webp", ProductId = 13},
            new ImageEntity(){ Id = 81, ImagePath = "Product13_5.webp", ProductId = 13},
            new ImageEntity(){ Id = 82, ImagePath = "Product13_6.webp", ProductId = 13},

            new ImageEntity(){ Id = 83, ImagePath = "Product14_1.webp", ProductId = 14},
            new ImageEntity(){ Id = 84, ImagePath = "Product14_2.webp", ProductId = 14},
            new ImageEntity(){ Id = 85, ImagePath = "Product14_3.webp", ProductId = 14},
            new ImageEntity(){ Id = 86, ImagePath = "Product14_4.webp", ProductId = 14},
            new ImageEntity(){ Id = 87, ImagePath = "Product14_5.webp", ProductId = 14},
            new ImageEntity(){ Id = 88, ImagePath = "Product14_6.webp", ProductId = 14},

            new ImageEntity(){ Id = 89, ImagePath = "Product15_1.webp", ProductId = 15},
            new ImageEntity(){ Id = 90, ImagePath = "Product15_2.webp", ProductId = 15},
            new ImageEntity(){ Id = 91, ImagePath = "Product15_3.webp", ProductId = 15},
            new ImageEntity(){ Id = 92, ImagePath = "Product15_4.webp", ProductId = 15},
            new ImageEntity(){ Id = 93, ImagePath = "Product15_5.webp", ProductId = 15},
            new ImageEntity(){ Id = 94, ImagePath = "Product15_6.webp", ProductId = 15},
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
            new ImageForHome(){ Id = 5, ImagePath = "800_home_page_5.webp"},
            new ImageForHome(){ Id = 6, ImagePath = "800_home_page_6.webp"},
            new ImageForHome(){ Id = 7, ImagePath = "800_home_page_7.webp"},
            new ImageForHome(){ Id = 8, ImagePath = "800_home_page_8.webp"},
            new ImageForHome(){ Id = 9, ImagePath = "800_home_page_9.webp"},
            new ImageForHome(){ Id = 10, ImagePath = "800_home_page_10.webp"},
            new ImageForHome(){ Id = 11, ImagePath = "800_home_page_11.webp"},
            new ImageForHome(){ Id = 12, ImagePath = "800_home_page_12.webp"},
            new ImageForHome(){ Id = 13, ImagePath = "800_home_page_13.webp"},
            new ImageForHome(){ Id = 14, ImagePath = "800_home_page_14.webp"},
            new ImageForHome(){ Id = 15, ImagePath = "800_home_page_15.webp"},
            new ImageForHome(){ Id = 16, ImagePath = "800_home_page_16.webp"},
            new ImageForHome(){ Id = 17, ImagePath = "800_home_page_17.webp"},
            };



        public static List<Info> SeedInfos() =>
            new List<Info>() {
                new Info() { Id = 1, Name_en = "Color", Name_es = "Color", Name_fr = "Couleur", Name_uk = "Колір", Value = "color" },
                new Info() { Id = 2, Name_en = "Material", Name_es = "Material", Name_fr = "Matériau", Name_uk = "Матеріал", Value = "material" },
                new Info() { Id = 3, Name_en = "Size", Name_es = "Tamaño", Name_fr = "Taille", Name_uk = "Розмір", Value = "size" },
                new Info() { Id = 4, Name_en = "Purpose", Name_es = "Propósito", Name_fr = "But", Name_uk = "Сезон", Value = "purpose" }
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

                    new Options () { Id = 30, Value = "winter", Label = "Winter", InfoId = 4 },
                    new Options () { Id = 31, Value = "spring", Label = "Spring", InfoId = 4 },
                    new Options () { Id = 32, Value = "summer", Label = "Summer", InfoId = 4 },
                    new Options () { Id = 33, Value = "autumn", Label = "Autumn", InfoId = 4 },

            };
        public static List<CountryEntity> SeedCountry() =>
            new List<CountryEntity>()
            {
                new CountryEntity() { Id = 1, CountryName_en = "Ukraine", CountryName_fr = "Ukraine", CountryName_uk = "Україна", CountryName_es = "Ucrania" },
                new CountryEntity() { Id = 2, CountryName_en = "England", CountryName_fr = "Angleterre", CountryName_uk = "Англія", CountryName_es = "Inglaterra" },
                new CountryEntity() { Id = 3, CountryName_en = "Spain", CountryName_fr = "Espagne", CountryName_uk = "Іспанія", CountryName_es = "España" },
                new CountryEntity() { Id = 4, CountryName_en = "France", CountryName_fr = "France", CountryName_uk = "Франція", CountryName_es = "Francia" },
                new CountryEntity() { Id = 5, CountryName_en = "Poland", CountryName_fr = "Pologne", CountryName_uk = "Польща", CountryName_es = "Polonia" },
                new CountryEntity() { Id = 6, CountryName_en = "USA", CountryName_fr = "États-Unis", CountryName_uk = "США", CountryName_es = "Estados Unidos" },
                new CountryEntity() { Id = 7, CountryName_en = "Japan", CountryName_fr = "Japon", CountryName_uk = "Японія", CountryName_es = "Japón" },
            };

        public static List<CityEntity> SeedCity() =>
            new List<CityEntity>()
            {
                new CityEntity() { Id = 1, CityName_en = "Kyiv", CityName_fr = "Kiev", CityName_uk = "Київ", CityName_es = "Kiev", CountryID = 1 },
                new CityEntity() { Id = 2, CityName_en = "Vinnytsia", CityName_fr = "Vinnitsa", CityName_uk = "Вінниця", CityName_es = "Vinnitsa", CountryID = 1 },
                new CityEntity() { Id = 3, CityName_en = "Dnipro", CityName_fr = "Dniepr", CityName_uk = "Дніпро", CityName_es = "Dniepr", CountryID = 1 },
                new CityEntity() { Id = 4, CityName_en = "Zhytomyr", CityName_fr = "Jytomyr", CityName_uk = "Житомир", CityName_es = "Jytomyr", CountryID = 1 },
                new CityEntity() { Id = 5, CityName_en = "Ivano-Frankivsk", CityName_fr = "Ivano-Frankivsk", CityName_uk = "Івано-Франківськ", CityName_es = "Ivano-Frankivsk", CountryID = 1 },
                new CityEntity() { Id = 6, CityName_en = "Kovel", CityName_fr = "Kovel", CityName_uk = "Ковель", CityName_es = "Kovel", CountryID = 1 },
                new CityEntity() { Id = 7, CityName_en = "Lutsk", CityName_fr = "Loutsk", CityName_uk = "Луцьк", CityName_es = "Loutsk", CountryID = 1 },
                new CityEntity() { Id = 8, CityName_en = "Lviv", CityName_fr = "Lviv", CityName_uk = "Львів", CityName_es = "Lviv", CountryID = 1 },
                new CityEntity() { Id = 9, CityName_en = "Odesa", CityName_fr = "Odessa", CityName_uk = "Одеса", CityName_es = "Odessa", CountryID = 1 },
                new CityEntity() { Id = 10, CityName_en = "Rivne", CityName_fr = "Rovno", CityName_uk = "Рівне", CityName_es = "Rovno", CountryID = 1 },
                new CityEntity() { Id = 11, CityName_en = "Kharkiv", CityName_fr = "Kharkov", CityName_uk = "Харків", CityName_es = "Kharkov", CountryID = 1 },
                new CityEntity() { Id = 12, CityName_en = "Chernivtsi", CityName_fr = "Tchernivtsi", CityName_uk = "Чернівці", CityName_es = "Tchernivtsi", CountryID = 1 },
            };

        public static List<StoreEntity> SeedStores() =>
            new List<StoreEntity>() {
                    new StoreEntity() { Id = 1, Name_en = "TRC Ocean Plaza", Name_es = "TRC Ocean Plaza", Name_fr = "TRC Ocean Plaza", Name_uk = "ТРЦ Ocean Plaza", Address_en = "Antonovycha, 176, Ground Floor", Address_es = "Antonovycha, 176, Planta Baja", Address_fr = "Antonovycha, 176, Rez-de-chaussée", Address_uk = "вул. Антоновича, 176, перший поверх", WorkingHours = "10:00 - 22:00", MapLink = "Link to map", CityId = 1 },
new StoreEntity() { Id = 2, Name_en = "TRC River Mall", Name_es = "TRC River Mall", Name_fr = "TRC River Mall", Name_uk = "ТРЦ River Mall", Address_en = "Dniprovska Naberezhna, 12, Second Floor", Address_es = "Dniprovska Naberezhna, 12, Segunda Planta", Address_fr = "Dniprovska Naberezhna, 12, Deuxième étage", Address_uk = "вул. Дніпровська набережна, 12, другий поверх", WorkingHours = "10:00 - 22:00", MapLink = "Link to map", CityId = 1 },
new StoreEntity() { Id = 3, Name_en = "TRC DREAM Yellow", Name_es = "TRC DREAM Yellow", Name_fr = "TRC DREAM Yellow", Name_uk = "ТРЦ DREAM Yellow", Address_en = "Prospekt Obolonsky, 1-B, First Floor", Address_es = "Prospekt Obolonsky, 1-B, Primer Piso", Address_fr = "Prospekt Obolonsky, 1-B, Premier étage", Address_uk = "просп. Оболонський, 1-Б, перший поверх", WorkingHours = "10:00 - 22:00", MapLink = "Link to map", CityId = 1 },
new StoreEntity() { Id = 4, Name_en = "TRC Lavina Mall", Name_es = "TRC Lavina Mall", Name_fr = "TRC Lavina Mall", Name_uk = "ТРЦ Lavina Mall", Address_en = "Berkovetska, 6-D, First Floor", Address_es = "Berkovetska, 6-D, Primer Piso", Address_fr = "Berkovetska, 6-D, Premier étage", Address_uk = "вул. Берковецька, 6-Д, перший поверх", WorkingHours = "10:00 - 22:00", MapLink = "Link to map", CityId = 1 },
new StoreEntity() { Id = 5, Name_en = "TRC Respublika Park", Name_es = "TRC Respublika Park", Name_fr = "TRC Respublika Park", Name_uk = "ТРЦ Respublika Park", Address_en = "Kiltseva Doroga, 1, First Floor", Address_es = "Kiltseva Doroga, 1, Primer Piso", Address_fr = "Kiltseva Doroga, 1, Premier étage", Address_uk = "вул. Кільцева дорога, 1, перший поверх", WorkingHours = "10:00 - 22:00", MapLink = "Link to map", CityId = 1 },
new StoreEntity() { Id = 6, Name_en = "TRC Retroville", Name_es = "TRC Retroville", Name_fr = "TRC Retroville", Name_uk = "ТРЦ Retroville", Address_en = "Prospekt Pravdy, 47, First Floor", Address_es = "Prospekt Pravdy, 47, Primer Piso", Address_fr = "Prospekt Pravdy, 47, Premier étage", Address_uk = "просп. Правди, 47, перший поверх", WorkingHours = "10:00 - 22:00", MapLink = "Link to map", CityId = 1 },
new StoreEntity() { Id = 7, Name_en = "TRC Blockbuster Mall", Name_es = "TRC Blockbuster Mall", Name_fr = "TRC Blockbuster Mall", Name_uk = "ТРЦ Blockbuster Mall", Address_en = "Prospekt Stepana Bandery, 36, First Floor", Address_es = "Prospekt Stepana Bandery, 36, Primer Piso", Address_fr = "Prospekt Stepana Bandery, 36, Premier étage", Address_uk = "просп. Степана Бандери, 36, перший поверх", WorkingHours = "10:00 - 22:00", MapLink = "Link to map", CityId = 1 },
new StoreEntity() { Id = 8, Name_en = "TRK Prospekt", Name_es = "TRK Prospekt", Name_fr = "TRK Prospekt", Name_uk = "ТРК Проспект", Address_en = "Gnata Khotkevycha, 1-B, First Floor", Address_es = "Gnata Khotkevycha, 1-B, Primer Piso", Address_fr = "Gnata Khotkevycha, 1-B, Premier étage", Address_uk = "вул. Гната Хоткевича, 1-Б, перший поверх", WorkingHours = "10:00 - 22:00", MapLink = "Link to map", CityId = 1 },
new StoreEntity() { Id = 9, Name_en = "TRC Megamall", Name_es = "TRC Megamall", Name_fr = "TRC Megamall", Name_uk = "ТРЦ Megamall", Address_en = "600-Richchia, 17, New Building, First Floor", Address_es = "600-Richchia, 17, Nuevo Edificio, Primer Piso", Address_fr = "600-Richchia, 17, Nouveau Bâtiment, Premier étage", Address_uk = "вул. 600-річчя, 17, нова будівля, перший поверх", WorkingHours = "10:00 - 21:00", MapLink = "Link to map", CityId = 2 },
new StoreEntity() { Id = 10, Name_en = "TRC Sky Park", Name_es = "TRC Sky Park", Name_fr = "TRC Sky Park", Name_uk = "ТРЦ Sky Park", Address_en = "Mykoly Ovodova, 51, First Floor", Address_es = "Mykoly Ovodova, 51, Primer Piso", Address_fr = "Mykoly Ovodova, 51, Premier étage", Address_uk = "вул. Миколи Оводова, 51, перший поверх", WorkingHours = "10:00 - 21:00", MapLink = "Link to map", CityId = 2 },

                  new StoreEntity() { Id = 11, Name_en = "TRC MOST City", Name_es = "TRC MOST City", Name_fr = "TRC MOST City", Name_uk = "ТРЦ MOST City", Address_en = "Queen Elizabeth II (Hlinka), 2, Ground Floor", Address_es = "Queen Elizabeth II (Hlinka), 2, Planta Baja", Address_fr = "Queen Elizabeth II (Hlinka), 2, Rez-de-chaussée", Address_uk = "вул. Глінки (колиш. Єлизавети II), 2, перший поверх", WorkingHours = "10:00 - 21:00", MapLink = "Link to map", CityId = 3 },
new StoreEntity() { Id = 12, Name_en = "TRC Karavan", Name_es = "TRC Karavan", Name_fr = "TRC Karavan", Name_uk = "ТРЦ Karavan", Address_en = "Nyzhnedniprovskaya, 17, First Floor", Address_es = "Nyzhnedniprovskaya, 17, Primer Piso", Address_fr = "Nyzhnedniprovskaya, 17, Premier étage", Address_uk = "вул. Нижньодніпровська, 17, перший поверх", WorkingHours = "10:00 - 21:00", MapLink = "Link to map", CityId = 3 },
new StoreEntity() { Id = 13, Name_en = "TRC Global", Name_es = "TRC Global", Name_fr = "TRC Global", Name_uk = "ТРЦ Global", Address_en = "Kyivska, 77, First Floor", Address_es = "Kyivska, 77, Primer Piso", Address_fr = "Kyivska, 77, Premier étage", Address_uk = "вул. Київська, 77, перший поверх", WorkingHours = "10:00 - 21:00", MapLink = "Link to map", CityId = 4 },
new StoreEntity() { Id = 14, Name_en = "Shopping Mall ARSEN", Name_es = "Centro Comercial ARSEN", Name_fr = "Centre Commercial ARSEN", Name_uk = "ТЦ Арсен", Address_en = "Ivana Mykolaychuka, 2", Address_es = "Ivana Mykolaychuka, 2", Address_fr = "Ivana Mykolaychuka, 2", Address_uk = "вул. Івана Миколайчука, 2", WorkingHours = "10:00 - 21:00", MapLink = "Link to map", CityId = 5 },
new StoreEntity() { Id = 15, Name_en = "Juvent Shopping Center (Boutique 110)", Name_es = "Juvent Centre Commercial (Boutique 110)", Name_fr = "Juvent Centre Commercial (Boutique 110)", Name_uk = "ТЦ Ювент (бутик 110)", Address_en = "4 Varshavska Street", Address_es = "Calle Varsovia, 4", Address_fr = "Rue Varsovie, 4", Address_uk = "вул. Варшавська, 4", WorkingHours = "10:00 - 18:00", MapLink = "Link to map", CityId = 6 },
new StoreEntity() { Id = 16, Name_en = "PortCity Shopping Mall", Name_es = "PortCity Centro Comercial", Name_fr = "PortCity Centre Commercial", Name_uk = "ТЦ PortCity", Address_en = "1 Sukhomlynskoho Street, Second Floor", Address_es = "Calle Sukhomlynskoho, 1, Segunda Planta", Address_fr = "Rue Sukhomlynskoho, 1, Deuxième étage", Address_uk = "вул. Сухомлинського, 1, другий поверх", WorkingHours = "10:00 - 22:00", MapLink = "Link to map", CityId = 7 },
new StoreEntity() { Id = 17, Name_en = "TSUM Lutsk", Name_es = "TSUM Lutsk", Name_fr = "TSUM Lutsk", Name_uk = "ЦУМ Луцьк", Address_en = "1 Voli Avenue, Fourth Floor", Address_es = "Avenida Voli, 1, Cuarto Piso", Address_fr = "Avenue Voli, 1, Quatrième étage", Address_uk = "просп. Волі, 1, четвертий поверх", WorkingHours = "09:30 - 21:00", MapLink = "Link to map", CityId = 7 },
new StoreEntity() { Id = 18, Name_en = "ESTRO Store (Voli, 9)", Name_es = "ESTRO Store (Voli, 9)", Name_fr = "ESTRO Store (Voli, 9)", Name_uk = "Магазин ЕСТРО (Волі, 9)", Address_en = "9 Voli Avenue, Building Facade", Address_es = "Avenida Voli, 9, Fachada del Edificio", Address_fr = "Avenue Voli, 9, Façade du Bâtiment", Address_uk = "просп. Волі, 9, фасад будівлі", WorkingHours = "09:00 - 21:00", MapLink = "Link to map", CityId = 7 },
new StoreEntity() { Id = 19, Name_en = "Juvent Shopping Center (Boutique 125)", Name_es = "Juvent Shopping Center (Boutique 125)", Name_fr = "Juvent Shopping Center (Boutique 125)", Name_uk = "ТЦ Ювент (бутик 125)", Address_en = "1 Karpenka-Karyho Street", Address_es = "Calle Karpenka-Karyho, 1", Address_fr = "Rue Karpenka-Karyho, 1", Address_uk = "вул. Карпенка-Карого, 1", WorkingHours = "09:00 - 21:00", MapLink = "Link to map", CityId = 7 },
new StoreEntity() { Id = 20, Name_en = "Forum Lviv Shopping Mall", Name_es = "Forum Lviv Centro Comercial", Name_fr = "Forum Lviv Centre Commercial", Name_uk = "ТЦ Форум Львів", Address_en = "7b Pid Dubom Street, Second Floor", Address_es = "Calle Pid Dubom, 7b, Segunda Planta", Address_fr = "Rue Pid Dubom, 7b, Deuxième étage", Address_uk = "вул. Під Дубом, 7б, другий поверх", WorkingHours = "10:00 - 21:00", MapLink = "Link to map", CityId = 8 },

                  new StoreEntity() { Id = 21, Name_en = "Victoria Gardens Shopping Mall", Name_es = "Victoria Gardens Centro Comercial", Name_fr = "Victoria Gardens Centre Commercial", Name_uk = "ТЦ Вікторія Гарденс", Address_en = "226-A Kulparkivska Street, First Floor", Address_es = "Calle Kulparkivska, 226-A, Primer Piso", Address_fr = "Rue Kulparkivska, 226-A, Premier étage", Address_uk = "вул. Кульпарківська, 226-А, перший поверх", WorkingHours = "10:00 - 20:00", MapLink = "Link to map", CityId = 8 },
new StoreEntity() { Id = 22, Name_en = "King Cross Leopolis Shopping Mall", Name_es = "King Cross Leopolis Centro Comercial", Name_fr = "King Cross Leopolis Centre Commercial", Name_uk = "ТЦ King Cross Leopolis", Address_en = "30 Stryiska Street, First Floor", Address_es = "Calle Stryiska, 30, Primer Piso", Address_fr = "Rue Stryiska, 30, Premier étage", Address_uk = "вул. Стрийська, 30, перший поверх", WorkingHours = "10:00 - 21:00", MapLink = "Link to map", CityId = 8 },
new StoreEntity() { Id = 23, Name_en = "ESTRO Store (Doroshenka, 14)", Name_es = "ESTRO Store (Doroshenka, 14)", Name_fr = "ESTRO Store (Doroshenka, 14)", Name_uk = "Магазин ЕСТРО (Дорошенка, 14)", Address_en = "14 Doroshenka Street", Address_es = "Calle Doroshenka, 14", Address_fr = "Rue Doroshenka, 14", Address_uk = "вул. Дорошенка, 14", WorkingHours = "10:00 - 20:00", MapLink = "Link to map", CityId = 8 },
new StoreEntity() { Id = 24, Name_en = "City Center Shopping Mall", Name_es = "City Center Centro Comercial", Name_fr = "City Center Centre Commercial", Name_uk = "ТЦ City Center", Address_en = "2 Prospekt Nezalezhnosti, First Floor", Address_es = "Avenida Prospekt Nezalezhnosti, 2, Primer Piso", Address_fr = "Avenue Prospekt Nezalezhnosti, 2, Premier étage", Address_uk = "просп. Незалежності, 2, перший поверх", WorkingHours = "10:00 - 21:00", MapLink = "Link to map", CityId = 9 },
new StoreEntity() { Id = 25, Name_en = "Equator Shopping Mall", Name_es = "Equator Centro Comercial", Name_fr = "Equator Centre Commercial", Name_uk = "ТЦ Екватор", Address_en = "23 Kulyka i Hudacheka", Address_es = "Calle Kulyka i Hudacheka, 23", Address_fr = "Rue Kulyka i Hudacheka, 23", Address_uk = "вул. Кулика і Гудачека, 23", WorkingHours = "10:00 - 22:00", MapLink = "Link to map", CityId = 10 },
new StoreEntity() { Id = 26, Name_en = "Zlata Plaza Shopping Mall", Name_es = "Zlata Plaza Centro Comercial", Name_fr = "Zlata Plaza Centre Commercial", Name_uk = "ТЦ Злата Плаза", Address_en = "1 Oleksandra Borysenka, First Floor", Address_es = "Calle Oleksandra Borysenka, 1, Primer Piso", Address_fr = "Rue Oleksandra Borysenka, 1, Premier étage", Address_uk = "вул. Олександра Борисенка, 1, перший поверх", WorkingHours = "10:00 - 21:00", MapLink = "Link to map", CityId = 10 },
new StoreEntity() { Id = 27, Name_en = "Dafi Shopping Mall", Name_es = "Dafi Centro Comercial", Name_fr = "Dafi Centre Commercial", Name_uk = "ТЦ Дафі", Address_en = "9 Heroiv Pratsi, First Floor", Address_es = "Calle Heroiv Pratsi, 9, Primer Piso", Address_fr = "Rue Heroiv Pratsi, 9, Premier étage", Address_uk = "вул. Героїв Праці, 9, перший поверх", WorkingHours = "10:00 - 20:00", MapLink = "Link to map", CityId = 11 },
new StoreEntity() { Id = 28, Name_en = "Nikolsky Shopping Mall", Name_es = "Nikolsky Centro Comercial", Name_fr = "Nikolsky Centre Commercial", Name_uk = "ТЦ Нікольський", Address_en = "2a Pushkinska, Third Floor", Address_es = "Calle Pushkinska, 2a, Tercer Piso", Address_fr = "Rue Pushkinska, 2a, Troisième étage", Address_uk = "вул. Пушкінська, 2а, третій поверх", WorkingHours = "10:00 - 21:00", MapLink = "Link to map", CityId = 11 },
new StoreEntity() { Id = 29, Name_en = "DEPO't Center Shopping Mall", Name_es = "DEPO't Center Centro Comercial", Name_fr = "DEPO't Center Centre Commercial", Name_uk = "ТЦ Депо", Address_en = "265A Haharina, First Floor", Address_es = "Calle Haharina, 265A, Primer Piso", Address_fr = "Rue Haharina, 265A, Premier étage", Address_uk = "вул. Гагаріна, 265А, перший поверх", WorkingHours = "10:00 - 20:00", MapLink = "Link to map", CityId = 12 }

                    };
             };
};