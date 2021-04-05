using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Emarket.ViewModels.Account
{
    public class RecoverPasswordViewModel
    {
        public string Username { get; set; }

        public string Email { get; set; }
    }
}