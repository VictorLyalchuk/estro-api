using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Bag_and_Order
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string? Region { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
    }
}
