
namespace Core.DTOs.Storage
{
    public class StorageDTO
    {
        public int Id { get; set; }
        public int? ProductQuantity { get; set; }
        public int Size { get; set; }
        public int ProductId { get; set; }
        public bool inStock { get; set; }
    }
}
