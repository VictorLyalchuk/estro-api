
namespace Core.DTOs.Bag_and_Order
{
    public class OrderItemsDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int Step { get; set; }
        public string? Status { get; set; }
        public string? ImagePath { get; set; }
        public DateTime DueDate { get; set; }
        public string? Article { get; set; }
        public int Quantity { get; set; }
        public int Size { get; set; }
        public int? OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
