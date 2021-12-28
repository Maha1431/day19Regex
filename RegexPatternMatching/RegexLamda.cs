using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidationUsingRegex
{
   public class RegexLamda
    {

        public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3,}$";
        public static string MOBILENUMBER_REGEX = "^[+][0-9]{2}[\\s][6-9]{1}[0-9]{9}$";
        public static string EMAIL_REGEX = "^[0-9a-zA-z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static string PASSWORD_REGEX = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";

    }
    
    // bool ToCheckName(string name) => Regex.IsMatch(name, NAME_REGEX);
    
        
        

}
