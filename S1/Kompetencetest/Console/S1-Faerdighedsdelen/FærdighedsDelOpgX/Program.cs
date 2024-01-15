using System;

namespace FærdighedsDelOpgX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string fornavn = "John";
            string efternavn = "Doe";

            // Prompt user for input
            Console.Write("Indtast fornavn: ");

            // Read input from user
            fornavn = Console.ReadLine();

            // Same thing for efternavn
            Console.Write("Indtast efternavn: ");
            efternavn = Console.ReadLine();

            // Print the result and wait for keypress
            Console.WriteLine("\nDu hedder {0} {1}", fornavn, efternavn);
            Console.ReadKey();
        }
    }
}
