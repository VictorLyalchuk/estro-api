using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Product
{
    public class Info
    {
        [Key]
        public int Id { get; set; }
        public string Name_en { get; set; }
        public string Name_es { get; set; }
        public string Name_fr { get; set; }
        public string Name_uk { get; set; }
        public string Value { get; set; }
        public IEnumerable<Options>? Options { get; set; }
    }
}
