using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs.Filter
{
    public class FilterDTO
    {
        public List<int>? Size { get; set; }
        public List<string>? Material { get; set; }
        public List<string>? Color { get; set; }
        public List<string>? Purpose { get; set; }
        public int page { get; set; }
    }
}