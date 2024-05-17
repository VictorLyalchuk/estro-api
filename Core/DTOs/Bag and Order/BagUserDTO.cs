using Core.Entities.Information;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs.Information
{
    public class BagUserDTO
    {
        [Key]
        public int Id { get; set; }
        public int CountProduct { get; set; }
        public DateTime OrderDate { get; set; }
        public List<BagItems>? BagItems { get; set; }
        public string UserEmail { get; set; }
        public string UserId { get; set; } = string.Empty;
    }
}
