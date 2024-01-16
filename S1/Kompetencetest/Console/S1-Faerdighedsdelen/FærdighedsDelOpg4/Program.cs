using System;

namespace FærdighedsDelOpg4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * [X] - **Input handling**
             * [X] - Prompt user for input
             * [X] - Read input from user
             *
             * [X] - **Math**
             * [X] - Addition
             * [X] - Subtraction
             * [X] - Multiplication
             * [X] - Division
             * [X] - Modulus
             */

            // Variables
            double firstNumber = 0;
            double secondNumber = 0;
            string operation = "";
            bool stop = false;

            while (!stop)
            {
                Console.WriteLine("Velkommen til lommeregneren!");

                // Prompt user for input
                Console.WriteLine("Indtast +, -, *, / eller % for at vælge en operation.");
                Console.WriteLine("Indtast q for at afslutte.");

                // Gets user choice of operation
                operation = Console.ReadLine();

                // Check which operation the user chose
                switch (operation)
                {
                    case "+":
                        firstNumber = PromptUserForInput("første");
                        secondNumber = PromptUserForInput("anden");
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {Addition(firstNumber, secondNumber)}");
                        break;
                    case "-":
                        firstNumber = PromptUserForInput("første");
                        secondNumber = PromptUserForInput("anden");
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {Subtraction(firstNumber, secondNumber)}");
                        break;
                    case "*":
                        firstNumber = PromptUserForInput("første");
                        secondNumber = PromptUserForInput("anden");
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {Multiplication(firstNumber, secondNumber)}");
                        break;
                    case "/":
                        firstNumber = PromptUserForInput("første");
                        secondNumber = PromptUserForInput("anden");
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {Division(firstNumber, secondNumber)}");
                        break;
                    case "%":
                        firstNumber = PromptUserForInput("første");
                        secondNumber = PromptUserForInput("anden");
                        Console.WriteLine($"{firstNumber} % {secondNumber} = {Modulus(firstNumber, secondNumber)}");
                        break;
                    case "q":
                        stop = true;
                        Console.WriteLine("Farvel.");
                        break;

                    // If the user enters something that isn't a valid operation, we tell the user that it wasn't a valid operation
                    default:
                        Console.WriteLine("Fejl, ikke en gyldig operation.");
                        break;
                }

                // Wait for keypress
                Console.Write("Venter på tastetryk...");
                Console.ReadKey();

                // Clear console
                Console.Clear();
            }

        }

        /// <summary>
        /// Returns the sum of two numbers.
        /// </summary>
        /// <param name="firstNumber">The first number to add.</param>
        /// <param name="secondNumber">The second number to add with.</param>
        /// <returns>double - The sum of two numbers.</returns>
        static double Addition(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        /// <summary>
        /// Returns the difference of two numbers.
        /// </summary>
        /// <param name="firstNumber">The first number to subtract from.</param>
        /// <param name="secondNumber">The second number to subtract with.</param>
        /// <returns>double - The difference of two numbers.</returns>
        static double Subtraction(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        /// <summary>
        /// Returns the product of two numbers.
        /// </summary>
        /// <param name="firstNumber">The first number to multiply.</param>
        /// <param name="secondNumber">The second number to multiply.</param>
        /// <returns>double - The product of two numbers.</returns>
        static double Multiplication(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        /// <summary>
        /// Returns the quotient of two numbers.
        /// </summary>
        /// <param name="firstNumber">The dividend.</param>
        /// <param name="secondNumber">The divisor.</param>
        /// <returns>double - The quotient of two numbers.</returns>
        static double Division(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        /// <summary>
        /// Returns the remainder of the division of two numbers.
        /// </summary>
        /// <param name="firstNumber">The dividend.</param>
        /// <param name="secondNumber">The divisor.</param>
        /// <returns>double - The remainder of the division of two numbers.</returns>
        static double Modulus(double firstNumber, double secondNumber)
        {
            return firstNumber % secondNumber;
        }

        /// <summary>
        /// Prompts the user for input and returns the input as a double.
        /// </summary>
        /// <param name="textInbetween">The text inbetween "Indtast" and "tal".</param>
        /// <returns>double - The input from the user.</returns>
        static double PromptUserForInput(string textInbetween)
        {
            double result = 0;
            bool stop = false;

            while (!stop)
            {
                // Prompt user for input
                Console.Write($"Indtast {textInbetween} tal: ");

                // Read input from user
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    stop = true;
                }
                else
                {
                    Console.WriteLine("Fejl, ikke et gyldigt input. Prøv igen.");
                }
            }

            return result;
        }
    }
}
