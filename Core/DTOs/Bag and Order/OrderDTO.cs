using Core.Entities.Information;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs.Information
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItems>? BagItems { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string EmailUser { get; set; }
        public string Address { get; set; }
        public string Payment { get; set; }
        public string UserId { get; set; }
        public string Status { get; set; }
    }
}
