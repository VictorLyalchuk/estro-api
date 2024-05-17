using System.ComponentModel.DataAnnotations;
using Core.Entities.DashBoard;

namespace Core.Entities.Information
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string EmailUser { get; set; }
        public string Address { get; set; }
        public string Payment { get; set; }
        public string UserId { get; set; }
        public string Status { get; set; }
        public User User { get; set; }
        //public List<OrderItems> BagItems { get; set; }
        public List<OrderItems> OrderItems { get; set; }
    }
}
