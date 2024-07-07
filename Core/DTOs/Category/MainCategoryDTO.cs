using Core.Entities.Category;

namespace Core.DTOs.Category
{
    public class MainCategoryDTO
    {
        public int Id { get; set; }
        public string Name_en { get; set; } = string.Empty;
        public string Name_es { get; set; } = string.Empty;
        public string Name_uk { get; set; } = string.Empty;
        public string Name_fr { get; set; } = string.Empty;
        public string? ImagePath { get; set; }
        public string URLCategoryName { get; set; } = string.Empty;
        public string URLSubCategoryName { get; set; } = string.Empty;
        public string URLName { get; set; } = string.Empty;
        public IEnumerable<SubCategory> SubCategories { get; set; } = new List<SubCategory>();

    }
}
