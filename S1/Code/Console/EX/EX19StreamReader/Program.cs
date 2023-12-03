using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace EX19StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\Users\\tsh40\\Desktop\\School\\AspIT S1\\Software\\S1\\Code\\Console\\EX\\EX19StreamReader\\Values.txt");

            int sum = 0, counter = 0;

            while (sr.EndOfStream != true)
            {
                sum += Convert.ToInt32(sr.ReadLine());
                Console.WriteLine(sum);
                counter++;
            }
            sr.Close();

            Console.WriteLine($"\nSum: {sum}");

            Console.ReadKey();

        }
    }
}
