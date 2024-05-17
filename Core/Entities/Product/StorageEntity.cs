using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Product
{
    public class StorageEntity
    {
        [Key]
        public int Id { get; set; }
        public int? ProductQuantity { get; set; }
        public int Size { get; set; }
        public int ProductId { get; set; }
        public bool inStock  { get; set; } = false;
        public ProductEntity? Product { get; set; }
    }
}
