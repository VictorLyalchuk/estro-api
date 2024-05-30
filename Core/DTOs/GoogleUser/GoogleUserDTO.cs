using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs.GoogleUser
{
    public class GoogleUserDTO
    {
        public string ID { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool EmailConfirmed { get; set; }
        public string Password { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        public string ClientId { get; set; } = string.Empty;
        public string AuthType { get; set; } = string.Empty;

    }
}
