using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Product
{
    public class ImageEntity
    {
        [Key]
        public int Id { get; set; }
        public string? ImagePath { get; set; }
        public int? ProductId { get; set; }
        public ProductEntity? Product { get; set; }
    }
}
