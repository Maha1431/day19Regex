using System;

namespace ValidationUsingRegex

{
    class Program
    {
        static void Main(string[] args)
        {
            /* RegexUserRegistration regex  = new RegexUserRegistration();
             RegexLamda lamda = new RegexLamda();
             bool validResult = regex.ValidateFirstName("maha");
             bool validLastNameResult = regex.ValidateLastName("Lakshmi");
             bool validMobileResult = regex.ValidateMobileNumber("8727261515");
             bool validEmailResult = regex.ValidateEmail("mmahaece.lakshmi@bc.co.in");
             bool validPasswordResult = regex.ValidatePassword("sgh$j77bx");


             Console.WriteLine("Firstname" +" "+ validResult);
             Console.WriteLine("Lastname" +" "+validLastNameResult);
             Console.WriteLine("Mobilenumber" +" "+validMobileResult);
             Console.WriteLine("Email" +" "+validEmailResult);
             Console.WriteLine("Password" +" "+validPasswordResult);*/

            UserDemo demo = new UserDemo();


            Console.WriteLine("Name To Enter");
            string Name = Console.ReadLine();
            Console.WriteLine("Last Name To Enter");
            string LastName = Console.ReadLine();
            Console.WriteLine("Email To Enter");
            string Email = Console.ReadLine();
            Console.WriteLine("Number to Enter using Country Code");
            string Number = Console.ReadLine();
            Console.WriteLine("Password To Enter ");
            Console.WriteLine("1 . Must Have Atleat 8 character" + "\n" + "2 . One Character Should be in upper case" + "\n" + "3 . One character Should Be in Lower Case " + "\n" + "4 . One Special Character " + "\n" + "5. Should Have One Numberic Value");
            string Password = Console.ReadLine();
            if (demo.ToCheckName(Name) == true)
                Console.WriteLine("Valid Input");
            else
                Console.WriteLine("InValid Input");
            if (demo.ToCheckLastName(LastName) == true)
                Console.WriteLine("Valid Input");
            else
                Console.WriteLine("InValid Input");
            if (demo.ToCheckMail(Email) == true)
                Console.WriteLine("Valid Input");
            else
                Console.WriteLine("InValid Input");
            if (demo.ToCheckNumber(Number) == true)
                Console.WriteLine("Vaild Input");
            else
                Console.WriteLine("Invalid Input");
            if (demo.ToCheckPassword(Password) == true)
                Console.WriteLine("Vaild Input");
            else
                Console.WriteLine("Invalid Input");
        }
    }
}

