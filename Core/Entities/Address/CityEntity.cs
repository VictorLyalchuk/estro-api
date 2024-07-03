using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Address
{
    public class CityEntity
    {
        [Key]
        public int Id { get; set; }
        public string? CityName { get; set; }
        public int? CountryID { get; set; }
        public CountryEntity? Country { get; set; }
    }
}
