using System.ComponentModel.DataAnnotations;
using Core.Entities.Product;


namespace Core.Entities.Category
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string URLName { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public ICollection<ProductEntity> Products { get; } = new List<ProductEntity>();
        public int? SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }
    }
}
