﻿using System.ComponentModel.DataAnnotations;

namespace EmpAppBlazor.Shared.Auth
{
    public class UserLogin
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}