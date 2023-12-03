using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First name please: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Last name name please: ");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Welcome {firstName} {lastName}");

            // 4.3
            Console.WriteLine("Write a number: ");
            int userNumber = int.Parse( Console.ReadLine() );
            Console.WriteLine($"User number: {userNumber}");

            Console.ReadKey();
        }
    }
}
