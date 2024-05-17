using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Filter
{
    public class Filter
    {
        [Key]
        public int Id { get; set; }
        public decimal Price { get; set; }
        //public List<Purpose>? Purpose { get; set; }
        //public List<Color>? Color { get; set; }
        //public List<Material>? Material { get; set; }
        //public List<Size>? Size { get; set; }
        public string? MainCategory { get; set; }
        public string? SubCategory { get; set; }
        public string? Category { get; set; }
    }
}