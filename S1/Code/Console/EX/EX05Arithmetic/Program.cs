using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5.1
            Console.WriteLine("Velkommen til lommeregneren V1.\nJeg er en simpel lommeregner, som udelukkende kan lægge to tal sammen.");

            Console.Write("Indtast et tal, efterfulgt af enter: ");
            double userFirstNumber = double.Parse(Console.ReadLine());

            Console.Write("Indtast endnu et tal, efterfulgt af enter: ");
            double userSecondNumber = double.Parse(Console.ReadLine());

            double resAdd = userFirstNumber + userSecondNumber;

            Console.WriteLine($"Resultatet af de to tal lagt sammen er: {resAdd}");

            // 5.2
            double resSub = userFirstNumber - userSecondNumber;
            Console.WriteLine($"Resultatet af de to tal trukket fra hinanden er: {resSub}");

            double resMul = userFirstNumber * userSecondNumber;
            Console.WriteLine($"Resultatet af de to tal ganget sammen er: {resMul}");

            double resDiv = userFirstNumber / userSecondNumber;
            Console.WriteLine($"Resultatet af de to tal divideret med hinanden: {resDiv}");

            // 5.3
            double resMod = userFirstNumber % userSecondNumber;
            Console.WriteLine($"Resultatet af de to tal modulo med hinanden: {resDiv}");

            Console.ReadKey();
        }
    }
}
