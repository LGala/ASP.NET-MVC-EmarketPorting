using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Emarket.ViewModels.Account
{
    public class SignUpViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 8, ErrorMessage = "password >= 8")]
        public string Password { get; set; }        
        
        [Required]
        [Compare("Password")]
        [StringLength(int.MaxValue, MinimumLength = 8, ErrorMessage = "password >= 8")]
        public string ReinsertedPassword { get; set; }
    }
}