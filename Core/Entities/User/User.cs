using Core.Entities.Information;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.DashBoard
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public Bag? Bag { get; set; }
        public int? BagId { get; set; }

        // type
        public string ClientId { get; set; } = string.Empty;
        public string AuthType {  get; set; } = string.Empty;
    }

    
}
