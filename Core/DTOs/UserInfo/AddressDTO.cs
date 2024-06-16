namespace Core.DTOs.UserInfo
{
    public class AddressDTO
    {
        public int Id { get; set; }
        public string? State { get; set; }
        public string? Region { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
    }
}
