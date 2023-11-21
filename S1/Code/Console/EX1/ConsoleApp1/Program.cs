using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (counter < 9999)
            {
                string testString = $"Line: {counter}";
                Console.WriteLine(testString);
                counter++;
            }

            Console.WriteLine("Program ended successfully");
        }
    }
}
