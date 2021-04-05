using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Emarket.ViewModels.Account
{
    public class SignInViewModel
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}