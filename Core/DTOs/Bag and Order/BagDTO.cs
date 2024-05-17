using Core.Entities.Information;
using System.ComponentModel.DataAnnotations;

namespace Core.DTOs.Information
{
    public class BagDTO
    {
        [Key]
        public int Id { get; set; }
        public int CountProduct { get; set; }
        public int ProductId { get; set; }
        public int Size { get; set; }
        public DateTime OrderDate { get; set; }
        public List<BagItems>? BagItems { get; set; }
        public string UserEmail { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
    }
}
