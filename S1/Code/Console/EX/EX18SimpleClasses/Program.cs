using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX18SimpleClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 18.1 & 18.2
            Car firstCar = new Car("Dacai", "Logan", "Beige", 170000, false);
            Car secondCar = new Car("Toyota", "Yaris", "Rød", 89000, true);
            Car thirdCar = new Car("Honda", "Civic", "Hvid", 199000, false);

            firstCar.PrintInfo();
            secondCar.PrintInfo();

            // 18.3
            //thirdCar.PrintInfo();
            Console.WriteLine(thirdCar.ToString());

            Console.ReadKey();
        }
    }
}
