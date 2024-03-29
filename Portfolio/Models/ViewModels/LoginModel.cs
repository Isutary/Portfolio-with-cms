﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [UIHint("password")]
        public string Password { get; set; }
    }
}
