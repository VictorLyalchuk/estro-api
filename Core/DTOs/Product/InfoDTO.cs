using Core.Entities.Product;

namespace Core.DTOs.Product
{
    public class InfoDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Options> Options { get; set; }
    }
}
