using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidationUsingRegex
{
    class RegexUserRegistration

    {

        public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3,}$";
        public static string MOBILENUMBER_REGEX = "^[6-9]{1}[0-9]{9}$";
        public static string EMAIL_REGEX = "^[0-9a-zA-z]+[.+-_][0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public static string PASSWORD_REGEX = "^[a-zA-Z0-9]{8,}[&%$@]{1}";


        public bool ValidateFirstName()
        {
            return Regex.IsMatch("Maha", NAME_REGEX);
        }

        public bool ValidateLastName()
        {
            return Regex.IsMatch("Lakshmi", NAME_REGEX);
        }

        public bool ValideMobileNumber()
        {
            return Regex.IsMatch("9123456781", MOBILENUMBER_REGEX);
        }
        public bool ValidateEmail()
        {
            return Regex.IsMatch("abc.XYZ@bl.co.in", EMAIL_REGEX);
        }
        public bool ValidatePassword()
        {
            return Regex.IsMatch("asZ2d34f$", PASSWORD_REGEX);
        }
    }
}
