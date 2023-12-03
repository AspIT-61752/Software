using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX15Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHello("Karsten");
            SayGoodbye("Tom");

            Console.WriteLine(DoubleUp(5));

            Console.ReadKey();
        }

        private static void SayGoodbye(string name)
        {
            Console.WriteLine($"Goodbye {name}");
        }

        private static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        private static int DoubleUp(int number)
        {
            return number * 2;
        }

        private static int Addition(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        private static int FindGreatestNumber(int numberOne, int numberTwo)
        {
            if (numberOne > numberTwo)
            {
                return numberOne;
            }
            else
            {
                return numberTwo;
            }
        }

        private static void printArray(string[] strings)
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}
