﻿using System;

namespace Core.DTOs.User
{
    public class UserEditDTO
    {
        public string? ID { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string? Password { get; set; }
        public string? ImagePath { get; set; }
        public string? Role { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
    }
}
