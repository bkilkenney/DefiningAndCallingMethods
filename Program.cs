using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningAndCallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What city were you born?");
            string city = Console.ReadLine();

            //Start calling methods below*******************************************************************************************************************


            Console.Write("Results: ");
            ReverseString(firstName);
            ReverseString(lastName);
            ReverseString(city);

            Console.ReadLine();

        }

        //Below is the method we called above******************************************************************************************************

        private static void ReverseString(string message)  /*private means can only be accessed in this class
                                               static means this method belongs to the class as a whole, not a particular instance
                                               void means it doesn't return a value*/
        {
            
            char[] messageArray = message.ToCharArray(); //This instructor loves to convert strings to char arrays and reverse them
            Array.Reverse(messageArray);
            foreach (char item in messageArray)
            {
                Console.Write(item);
                
            }
        }

    }
}
