using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Store
{
    public class StoreEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string WorkingHours { get; set; } = string.Empty;
        public string MapLink { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}
