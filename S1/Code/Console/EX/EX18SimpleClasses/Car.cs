using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX18SimpleClasses
{
    internal class Car
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public string Color { get; private set; }
        public double Price { get; private set; }
        public bool IsSold { get; private set; }
        public bool IsOnSale { get; private set; }

        public Car(string make, string model, string color, double price, bool isSold)
        {
            Make = make;
            Model = model;
            Color = color;
            Price = price;
            IsSold = isSold;
            IsOnSale = false;
        }

        public void PrintInfo()
        {
            if (IsSold == true)
            {
                Console.WriteLine($"SOLGT! Bilen er en {Make} {Model} i farven {Color}. Prisen er {Price} DKK.");
            }
            else
            {
                Console.WriteLine($"Bilen er en {Make} {Model} i farven {Color}. Prisen er {Price} DKK.");
            }
        }

        public override string ToString()
        {
            if (IsSold == true)
            {
                return $"SOLGT! Bilen er en {Make} {Model} i farven {Color}. Prisen er {Price} DKK.";
            }
            else
            {
                return $"Bilen er en {Make} {Model} i farven {Color}. Prisen er {Price} DKK.";
            }
        }

        public void PutOnSale()
        {
            IsOnSale = true;

            // I'm lazy, so I'm just doing this
            Price = Price * 0.9;
        }
    }
}
