using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Email_data_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;
            Console.WriteLine("Enter your email id");
            email = Console.ReadLine();
            if (IsValidEmail(email))
            {
                Console.WriteLine("entered email is valid");
            }
            else
                Console.WriteLine("entered email is not valid");

            Console.ReadLine();
        }

        public static bool IsValidEmail(string email)
        {

            if (string.IsNullOrWhiteSpace(email))
                return false;
            try
            {
                if (Regex.IsMatch(email,
                        @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception )
            {
                return false;
            }
            
        }
    }
}

