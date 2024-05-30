using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Product
{
    public class Options
    {
        [Key]
        public int Id { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        public int? InfoId { get; set; }
        public Info? Info { get; set; }
    }
}
