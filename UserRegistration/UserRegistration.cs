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

        public void lastName()
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
    }
}
