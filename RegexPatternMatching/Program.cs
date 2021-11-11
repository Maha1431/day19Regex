using System;

namespace ValidationUsingRegex

{
    class Program
    {
        static void Main(string[] args)
        {
            RegexUserRegistration regex  = new RegexUserRegistration();
            bool validResult = regex.ValidateFirstName();
            bool validLastNameResult = regex.ValidateLastName();
            bool validMobileResult = regex.ValideMobileNumber();
            bool validEmailResult = regex.ValidateEmail();
            bool validPasswordResult = regex.ValidatePassword();

            Console.WriteLine("Firstname" +" "+ validResult);
            Console.WriteLine("Lastname" +" "+validLastNameResult);
            Console.WriteLine("Mobilenumber" +" "+validMobileResult);
            Console.WriteLine("Email" +" "+validEmailResult);
            Console.WriteLine("Password" +" "+validPasswordResult);
        }
    }
}
