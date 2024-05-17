using Core.Entities.Information;

namespace Core.DTOs.Information
{
    public class OptionsDTO
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        public int? Info { get; set; }
        public Info? InfoId { get; set; }
    }
}
