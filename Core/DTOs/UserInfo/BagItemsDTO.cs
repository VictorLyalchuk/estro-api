using System.ComponentModel.DataAnnotations;


namespace Core.DTOs.UserInfo
{
    public class BagItemsDTO
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Size { get; set; }
        public int BagId { get; set; }
        public string Name { get; set; } 
        public string Article { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}
