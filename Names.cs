using System;

namespace FullName
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine(); // First Name

            Console.WriteLine("Enter your second name:");
            string secondName = Console.ReadLine(); // Second Name

            string fullName = firstName + " " + secondName; // Cancatation of both Strings

            Console.WriteLine("");
            Console.WriteLine("Your full name is: " + fullName); // Prints the full name

            Console.WriteLine("");
            Console.WriteLine("Is this correct? Type Yes or No"); 
            Console.WriteLine("");

            string Answer = Console.ReadLine();


            if (Answer is "Yes")
            {
                Console.WriteLine("Wonderful!");
            }
            else if (Answer is "No")
            {
                Console.WriteLine("Oh, sorry about that");
            }
            else
            {
                Console.WriteLine("What?");
            }
            Console.WriteLine("");

        }
    }
}
