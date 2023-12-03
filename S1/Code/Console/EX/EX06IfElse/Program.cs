using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sale();
            //sort();
            //sameNumber();
            division();

            Console.ReadKey();
        }

        // 6.1
        static void sale()
        {
            Console.Write("Beløb: ");
            double price = double.Parse(Console.ReadLine());

            if (price > 1000)
            {
                // 5% discount
                price = price * 0.95;
            }

            Console.WriteLine($"Final price: {price}");
        }

        // 6.2 & 6.3
        static void sort()
        {
            double[] doubleArray = new double[3];

            double left, right;
            int whereInArray = 0;

            Console.WriteLine("Indtast tre tal, og jeg vil printe dem i stigende order.");

            // First number
            Console.Write("Indtast nu det første tal: ");
            doubleArray[0] = double.Parse(Console.ReadLine());

            // Second number
            Console.Write("Indtast nu det andet tal: ");
            doubleArray[1] = double.Parse(Console.ReadLine());

            // Third number
            Console.Write("Indtast nu det tredje tal: ");
            doubleArray[2] = double.Parse(Console.ReadLine());

            // Sorting ascending order
            for (int i = 0; i < doubleArray.Length; i++)
            {

                for (int j = doubleArray.Length - 1; j > i; j--)
                {
                    whereInArray = j - 1;
                    left = doubleArray[whereInArray];
                    right = doubleArray[j];

                    if (left > right)
                    {
                        doubleArray[j] = left;
                        doubleArray[whereInArray] = right;
                    }
                }
            }

            Console.WriteLine("I stigende order: ");
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.WriteLine(doubleArray[i]);
            }

            // Sorting descending order
            for (int i = 1; i < doubleArray.Length; i++)
            {
                for (int j = 0; j < doubleArray.Length - i; j++)
                {
                    whereInArray = j + 1;
                    left = doubleArray[j];
                    right = doubleArray[whereInArray];

                    if (left < right)
                    {
                        doubleArray[whereInArray] = left;
                        doubleArray[j] = right;
                    }
                }
            }

            Console.WriteLine("Faldende rækkefølge: ");
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.WriteLine(doubleArray[i]);
            }
            
            // Compare the numbers
            //if (numberOne < numberTwo)
            //{
            //    Console.WriteLine(numberOne);
            //    if (numberTwo < numberThree)
            //    {
            //        Console.WriteLine(numberTwo);
            //        Console.WriteLine(numberThree);
            //    }
            //    else
            //    {
            //        Console.WriteLine(numberThree);
            //        Console.WriteLine(numberTwo);
            //    }
            //}
            //else if (numberOne < numberThree)
            //{
            //    Console.WriteLine("2");
            //}

            // Sort


        }

        // 6.4
        static void sameNumber()
        {
            Console.Write("Er dit input ens eller ej?\nSkriv din første input her: ");
            string firstInput = Console.ReadLine();

            Console.Write("Skriv din andet input her: ");
            string secondInput = Console.ReadLine();

            if (firstInput == secondInput)
            {
                Console.WriteLine("De er ens!");
            }
            else
            {
                Console.WriteLine("De er ikke ens!");
            }

        }

        // 6.5
        static void division()
        {
            Console.Write("Division\nSkriv dit første tal her (tælleren): ");
            double firstInput = double.Parse(Console.ReadLine());

            Console.Write("Skriv din andet tal her (nævneren): ");
            double secondInput = double.Parse(Console.ReadLine());

            if (secondInput == 0)
            {
                Console.WriteLine("Man kan ikke dividere med 0");
            }
            else
            {
                Console.WriteLine($"Resultat: {firstInput/secondInput}");
            }

        }

    }
}
