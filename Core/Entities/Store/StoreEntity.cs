using Core.Entities.Address;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Store
{
    public class StoreEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? WorkingHours { get; set; }
        public string? MapLink { get; set; }
        public string? Address { get; set; }
        public int? CityId { get; set; }
        public CityEntity? City { get; set; }
    }
}
