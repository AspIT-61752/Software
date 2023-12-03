using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07BooleanAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;

            // t = true
            // f = false

            // f
            Console.WriteLine(a == b);

            // f
            Console.WriteLine(a > b);

            // t
            Console.WriteLine(a <= b);

            // f
            Console.WriteLine(a - b > 0);

            // t
            Console.WriteLine(a + b > 0);

            // t
            Console.WriteLine(a > 1 - b);

            // t 2 > 0
            Console.WriteLine(a == b || a > 0);

            // t 6 > 0 && 2 > 0
            Console.WriteLine(a + b > 0 && a > 0);

            // f
            Console.WriteLine(a == 5 && a + b > 0);

            // f (true) && 2 > 4
            Console.WriteLine((true || false) && a > b);

            // f 3 > 5 && true
            Console.WriteLine(3 > 5 && true || a == b);

            // true 4 > 2 && true
            Console.WriteLine(b > a && true || false || b > 4);

            // It's true? WHY?!
            Console.WriteLine("A");
            Console.WriteLine(a);
            Console.WriteLine("B");
            Console.WriteLine(b);
            Console.WriteLine($"b<4 {b < 4}");
            Console.WriteLine($"a < b || a + b > 4 {a < b || a + b > 4}");
            Console.WriteLine($"Tr");
            Console.WriteLine(b < 4 && a < b || a + b > 4 && true);

            // t
            Console.WriteLine(true && true || false);

            // f
            Console.WriteLine(true && false && true);

            // t
            Console.WriteLine(true || false || false);

            // f
            Console.WriteLine(false && false);

            // 
            Console.WriteLine(false && true && true);

            Console.ReadKey();
        }
    }
}
