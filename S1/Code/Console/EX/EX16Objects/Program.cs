using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarHandler;

namespace EX16Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 16.1
            Car myCar = new Car("Ford", "Mustang", 1966, "Rød");
            Console.WriteLine(myCar.ToString()); // Doesn't give us the color
            Console.WriteLine(myCar.GetInfo()); // Gives the color

            Console.WriteLine(myCar
                .StartCar()); // There's a chance the car doesn't start. And if it's a skoda it doesn't start at all.

            // 16.2
            List<Car> cars = new List<Car>();

            Car car1 = new Car("Ford", "Mustang", 1966, "Rød");
            Car car2 = new Car("Porsche", "911", 2004, "Sølv");

            cars.Add(car1);
            cars.Add(car2);

            Console.WriteLine("Informationer om bilerne:");
            foreach (Car car in cars)
            {
                Console.WriteLine(car.GetInfo());
                //Console.WriteLine(car);
            }

            //16.3
            bool run = true;
            string userChoice = "";

            string newMake = "";
            string newModel = "";
            string newColor = "";

            int newProductionYear = 0;

            while (run)
            {
                // Clears the screen
                Console.Clear();

                // Start
                Console.WriteLine("Velkommen til Biladministrationen Version 1997");
                Console.Write("Du har nu to muligheder. Ønsker du at:" +
                              "\nIndtaste en bil (1)?" +
                              "\nSe informationer om alle biler (2)?" +
                              "\nAfslut (0)?" +
                              "\nTast dit ønske: ");

                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":

                        // Adds a new car to the list
                        cars.Add(new Car(userMake(), userModel(), userProductionYear(), userColor()));
                        break;

                    case "2":

                        // Prints the info
                        foreach (Car car in cars)
                        {
                            Console.WriteLine(car.GetInfo());
                        }
                        break;

                    case "0":
                        Console.WriteLine("\nSes");
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Ikke muligt.");
                        break;
                }

                Console.WriteLine("\nVenter på vilkårligt input for at fortsætte.");
                Console.ReadKey();
            }

            Console.ReadKey();
        }

        private static string userMake()
        {
            Console.Write("\nMærke: ");
            return Console.ReadLine();
        }

        private static string userModel()
        {
            Console.Write("\nModel: ");
            return Console.ReadLine();
        }

        private static string userColor()
        {
            Console.Write("\nFarve: ");
            return Console.ReadLine();
        }

        private static int userProductionYear()
        {
            // Year
            bool resume = false; // Couldn't use continue
            int newProductionYear = 0;

            while (resume == false)
            {
                Console.Write($"\nProduktions år: ");
                if (int.TryParse(Console.ReadLine(), out newProductionYear))
                {
                    resume = true;
                }
                else
                {
                    Console.WriteLine($"\nTaste fejl, ikke et år");
                }
            }

            return newProductionYear;
        }
    }
}
