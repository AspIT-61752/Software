using System;

namespace FærdighedsDelOpg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prints the multiplication table for 7
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * 7 = {i * 7}");
            }

            Console.ReadKey(); // Wait for keypress
        }
    }
}
