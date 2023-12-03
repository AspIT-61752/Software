using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 14.1
            List<int> ages = new List<int>();

            ages.Add(5);
            ages.Add(17);
            ages.Add(20);
            ages.Add(40);
            ages.Add(51);

            List<string> names = new List<string>();

            names.Add("Jens");
            names.Add("Karl");
            names.Add("Johannes");
            names.Add("Anton");
            names.Add("Nicklas");

            // 14.2
            List<double> percentages = new List<double>() { 0.75, 0.23, 0.86, 0.17 };

            List<bool> areMarried = new List<bool>() { true, false, false, true, true };

            // 14.3 
            for (int i = 0; i < ages.Count; i++)
            {
                Console.WriteLine(ages[i]);
            }

            for (int i = 0; i < ages.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (double percentage in percentages)
            {
                Console.WriteLine(percentage);
            }

            foreach (bool isMarried in areMarried)
            {
                Console.WriteLine(isMarried);
            }

            // 14.4
            List<string> namesList = new List<string>() { "Hans", "Kristian", "Jens", "Karsten", "Ib" };

            namesList.Insert(3, "Anders");
            namesList.Insert(2, "Lars");

            foreach (string name in namesList)
            {
                Console.WriteLine($"Name: {name}");
            }

            // 14.5
            List<int> agesList = new List<int>() { 13, 14, 13, 15, 13, 14, 14, 15 };
            agesList.Remove(13);
            agesList.Remove(15);

            foreach (int age in agesList)
            {
                Console.WriteLine($"age: {age}");
            }

            agesList.RemoveAt(3);

            Console.WriteLine("Remove number at index 3");
            foreach (int age in agesList)
            {
                Console.WriteLine($"age: {age}");
            }

            // Done
            Console.ReadKey();
        }
    }
}
