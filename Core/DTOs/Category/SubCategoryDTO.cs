using Core.Entities.Category;

namespace Core.DTOs.Category
{
    public class SubCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ImagePath { get; set; }
        public IEnumerable<CategoryEntity> Categories { get; set; } = new List<CategoryEntity>();
        public int? MainCategoryId { get; set; }
        public MainCategory? MainCategory { get; set; }
    }
};

