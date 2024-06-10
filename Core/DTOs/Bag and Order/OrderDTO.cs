using Core.DTOs.Bag_and_Order;
using Core.Entities.Bag_and_Order;

namespace Core.DTOs.Information
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? EmailUser { get; set; }
        public string? Payment { get; set; }
        public int? AddressId { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Discount { get; set; }
        public decimal? OrderTotal { get; set; }
        public Address? Address { get; set; }
        public string? UserId { get; set; }
        public List<OrderItemsDTO>? OrderItems { get; set; }
    }
}
