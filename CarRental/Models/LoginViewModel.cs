﻿using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string UserName {  get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
