using System;

namespace Opgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Heltal
            byte byteNumber = 128;
            sbyte sByteNumber = 127;
            short shortNumber = 32000;
            ushort uShortNumber = 65000;
            int intNumber = 2000000;
            uint uIntNumber = 4000000;
            long longNumber = 84169418;
            ulong uLongNumber = 685988755;

            // Decimal
            float floatNumber = 0.1f;
            double doubleNumber = 0.2;
            decimal decimalNumber = 0.4m;

            // Heltal
            Console.WriteLine($"Byte\nMin: {byte.MinValue}\nMax: {byte.MaxValue}\n");
            Console.WriteLine($"sByte\nMin: {sbyte.MinValue}\nMax: {sbyte.MaxValue}\n");
            Console.WriteLine($"Short\nMin: {short.MinValue}\nMax: {short.MaxValue}\n");
            Console.WriteLine($"uShort\nMin: {ushort.MinValue}\nMax: {ushort.MaxValue}\n");

            Console.WriteLine($"Int\nMin: {int.MinValue}\nMax: {int.MaxValue}\n");
            Console.WriteLine($"uInt\nMin: {uint.MinValue}\nMax: {uint.MaxValue}\n");
            Console.WriteLine($"Long\nMin: {long.MinValue}\nMax: {long.MaxValue}\n");
            Console.WriteLine($"uLong\nMin: {ulong.MinValue}\nMax: {ulong.MaxValue}\n");

            // Decimal
            Console.WriteLine($"Float\nMin: {float.MinValue}\nMax: {float.MaxValue}\n");
            Console.WriteLine($"Double\nMin: {double.MinValue}\nMax: {double.MaxValue}\n");
            Console.WriteLine($"Decimal\nMin: {decimal.MinValue}\nMax: {decimal.MaxValue}\n");

            Console.WriteLine($"Pi casting.\nInt: {(int)Math.PI}\n");
            Console.WriteLine($"Float: {(float)Math.PI}\n");
            Console.WriteLine($"Decimal: {(decimal)Math.PI}\n");

            Console.ReadKey();

        }
    }
}
