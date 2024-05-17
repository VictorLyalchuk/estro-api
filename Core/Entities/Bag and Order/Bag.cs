using Core.Entities.DashBoard;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Information
{
    public class Bag
    {
        [Key]
        public int Id { get; set; }
        public int CountProduct { get; set; }
        public DateTime OrderDate { get; set; }
        public List<BagItems>? BagItems { get; set; }
        public string UserEmail { get; set; }
        public string UserId { get; set; } = string.Empty;
        public User? User { get; set; }
    }
}
