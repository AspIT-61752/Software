using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX20StreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (StreamWriter writer = new StreamWriter(@"C:\Users\tsh40\Desktop\MyFile.txt"))

            // 20.1
            //using (StreamWriter writer = new StreamWriter("MyFile.txt"))
            //{
            //    writer.Write("Dette bliver skrevet på en linje");
            //    writer.Write(".. og det her fortsætter på samme linje");

            //    writer.WriteLine(".. det her står på samme linje, men afsluttes med nyt linjeskift");
            //    writer.WriteLine(
            //        "Forskellen på Write og Writeline er altså om den bliver afsluttet med nyt linjeskift eller ej");

            //    writer.WriteLine("1");
            //    writer.WriteLine("2");
            //}

            Random rnd = new Random();

            using (StreamWriter sw = new StreamWriter("MyFile.txt"))
            {
                for (int i = 0; i < 100; i++)
                {
                    sw.WriteLine($"Number: {i+1}) {rnd.Next(1, 7)}");
                }
            }

        }
    }
}
