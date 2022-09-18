using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class UserRegistration
    {

        public static void firstName()
        {
            Console.WriteLine ("Enter the first name: ");
            String name = Console.ReadLine();
            string pattern = "(^[^a-z][A-z]{1}[a-z]{2,}$)";
            

                if (Regex.IsMatch(name, pattern))
                Console.WriteLine("Name is valid");
            else
            {
                Console.WriteLine("Name is invalid, Try with another name.");
                firstName();
            }   
        }

        public static void lastName()
        {

            Console.WriteLine ("Enter the last name: ");
            String lastname = Console.ReadLine();
            string pattern = "(^[^a-z][A-z]{1}[a-z]{2,}$)";

            if (Regex.IsMatch(lastname, pattern))
                Console.WriteLine("entered name is valid");
            else
            {
                Console.WriteLine("Entered name is Invalid\n for valid name please give first character in capital and give minimum 3 character");
                lastName();
            }
        }
        public static void Validemail()
        {
            Console.WriteLine("Enter email");
            string mail = Console.ReadLine();
            string pattern = "^[a-zA-Z0-9]{3,7}([._+-][0-9a-zA-Z]{1,7})*@[0-9a-zA-Z]+[.]?([a-zA-Z]{2,4})+[.]?([a-zA-Z]{2,3})*$";
            if (Regex.IsMatch(mail, pattern))
            {
                Console.WriteLine("entered email is valid");

                Validemail();
            }
            else
            {
                Console.WriteLine("entered email invalid");

                Validemail();
            }
        }
    }
}
