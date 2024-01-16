using System;
using System.Diagnostics;

namespace FærdighedsDelOpg3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            byte numberToGuess = 0;
            byte userGuess = 0;
            Random random = new Random();

            numberToGuess = (byte)random.Next(1, 11); // Generate a random number between 1 and 10
            Debug.WriteLine($"numberToGuess: {numberToGuess}"); // For testing purposes. It will print the number to the output window in Visual Studio

            while (running)
            {
                // Prompt user for input
                Console.Write("Gæt et tal mellem 1 og 10: ");

                // Read input from user
                try
                {
                    userGuess = byte.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    // If the user enters something that isn't a number or out of range, we catch the exception and tell the user that it wasn't a valid number
                    Console.WriteLine("Fejl. Ikke gyldigt tal.");
                }

                // Check if user guessed correctly
                if (userGuess == numberToGuess)
                {
                    Console.WriteLine("Du gættede rigtigt!");
                    running = false;
                }
                else
                {
                    Console.WriteLine("Du gættede forkert, prøv igen.");
                }
            }

            // Wait for keypress
            Console.ReadKey();
        }
    }
}
