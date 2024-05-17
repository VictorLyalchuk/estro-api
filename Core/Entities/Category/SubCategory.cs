using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Category
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string URLName { get; set; }
        public string? ImagePath { get; set; }
        public ICollection<CategoryEntity> Categories { get; set; } = new List<CategoryEntity>();
        public int? MainCategoryId { get; set; }
        public MainCategory? MainCategory { get; set; }
    }
}
