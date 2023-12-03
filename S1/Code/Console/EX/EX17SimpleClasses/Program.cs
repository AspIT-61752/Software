using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX17SimpleClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 17.1
            Box myBox = new Box();

            myBox.Height = 40;
            myBox.Length = 60;
            myBox.Width = 20;

            //Console.WriteLine($"\nKassen har følgende mål:" +
            //                  $"\nHøjde: {myBox.Height} cm" +
            //                  $"\nLængde: {myBox.Length} cm" +
            //                  $"\nBredde: {myBox.Width} cm\n");

            // 17.2
            //myBox.PrintInfo();

            // 17.3
            myBox.CalculateVolume();

            // 17.4
            myBox.CalculateSurface();
            myBox.PrintInfo();

            Console.ReadKey();

        }
    }
}
