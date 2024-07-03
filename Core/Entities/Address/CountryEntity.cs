using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Address
{
    public class CountryEntity
    {
        [Key]
        public int Id { get; set; }
        public string? CountryName { get; set; }
    }
}
