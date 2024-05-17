using Core.Entities.Information;

namespace Core.DTOs.Information
{
    public class InfoDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Options> Options { get; set; }
    }
}
