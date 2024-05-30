using Core.Entities.Product;

namespace Core.DTOs.Product
{
    public class EditProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Highlights { get; set; }
        public string Details { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Purpose { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Article { get; set; } = string.Empty;
        public string Material { get; set; } = string.Empty;
        public List<ImageEntity>? ImagesFile { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public int? StorageId { get; set; }
        public int StorageQuantity { get; set; }
    }
}
