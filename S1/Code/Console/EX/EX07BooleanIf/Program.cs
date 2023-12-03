using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07BooleanIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int x = 0;

            // 8.1
            if (a == 1)
            {
                x = 1;
            }
            if (b == 1)
            {
                x = 2;
            }
            if (c == 3)
            {
                x = 3;
            }

            Console.WriteLine($"OPG 8.1 x: {x}");

            // 8.2
            if (a == 2)
            {
                x = 1;
            }
            else if (b == 3)
            {
                x = 2;
            }
            else if (c == 3)
            {
                x = 3;
            }

            Console.WriteLine($"OPG 8.2 x: {x}");

            // 8.3
            if (a == 2)
            {
                x = 1;
                if (b == 2)
                {
                    x = 2;
                }
            }
            else if (c == 1)
            {
                x = 3;
            }

            Console.WriteLine($"OPG 8.3 x: {x}");

            // 8.4
            if (a == 2)
            {
                x = 1;
            }
            else
            {
                if (b - a == a)
                {
                    x = 2;
                }
                if (c - b == b)
                {
                    x = 3;
                }
            }

            Console.WriteLine($"OPG 8.4 x: {x}");

        }
    }
}
