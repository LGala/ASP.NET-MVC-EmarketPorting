using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Emarket.Models
{
    public partial class UserAccount
    {        
        public UserAccount(string name, string surname, string birthdate, string username, string email, string password)
        {
            if (!DateIsInThatFormat(birthdate, "dd-MM-yyyy"))
            {
                throw new FormatException("date format is not valid");
            }

            this.name = name;
            this.surname = surname;
            this.birthdate = birthdate;
            this.username = username;
            this.email = email;
            this.password = password;
        }

        private bool DateIsInThatFormat(string date, string format)
        {
            return DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }
    }

    // My idea was to have a custome type for the variable Birthdate, i thought it was a good solution for readeability,
    // but unfourtunately it doesn't work and i can't figure out why

    //class CustomDate
    //{
    //    public string Date { get; private set; }

    //    private readonly string[] format = { "dd-MM-yyyy" };

    //    public CustomDate(string date)
    //    {
    //        if (dateIsInACorrectFormat(date))
    //        {
    //            Date = date;
    //        }
    //        else
    //        {
    //            throw new FormatException("date format is not valid");
    //        }
    //    }

    //    private bool dateIsInACorrectFormat(string date)
    //    {
    //        return DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
    //    }
    //}
}