namespace Core.DTOs.Address
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string? CityName { get; set; }
        public int? CountryID { get; set; }
        public string? CountryName { get; set; }
    }
}
