using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidationUsingRegex
{
   public class RegexUserRegistration

    {

        public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3,}$";
        public static string MOBILENUMBER_REGEX = "^[+][0-9]{2}[\\s][6-9]{1}[0-9]{9}$";
        public static string EMAIL_REGEX = "^[0-9a-zA-z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static string PASSWORD_REGEX = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";


         public bool ValidateFirstName(string name)
         {
             return Regex.IsMatch(name, NAME_REGEX);
         }
 
     // public bool ToCheckName(string name) => (Regex.IsMatch(name, NAME_REGEX));
        public bool ValidateLastName( string name)
        {
            return Regex.IsMatch(name, NAME_REGEX);
        }

        public bool ValidateMobileNumber(string number)
        {
            return Regex.IsMatch(number, MOBILENUMBER_REGEX);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, EMAIL_REGEX);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, PASSWORD_REGEX);
        }
    }
}
