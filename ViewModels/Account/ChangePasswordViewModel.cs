using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Emarket.ViewModels.Account
{
    public class ChangePasswordViewModel
    {
        public string Username { get; set; }

        public string Password { get; set; }

        // int.MaxValue to be coherent with the PHP version
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 8, ErrorMessage = "password >= 8")]
        public string NewPassword { get; set; }

        [Required]
        [Compare("NewPassword")]
        public string ReinsertedNewPassword { get; set; }
    }
}