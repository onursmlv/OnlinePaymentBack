﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Service.DTO
{
    public class RegisterDto
    {
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
