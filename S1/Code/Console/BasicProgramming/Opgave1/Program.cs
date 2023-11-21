using System;

namespace Opgave1
{
    internal class Program
    {
        // Public variables
        public string name = "John";

        static void Main(string[] args)
        {
            //WriteToConsole(GetUserInput());
            //Hello();
            //CountUp();
            //TaxiCalculator();

            //ConvertReadLine();
            NameAndHobby();

        }

        // 2.1
        static void Hello()
        {
            Console.WriteLine("Hello World");
        }

        // 2.3
        static void WriteToConsole(string text)
        {
            Console.WriteLine(text);
        }

        static string GetUserInput()
        {
            Console.WriteLine("Who's your favorite teacher");
            return Console.ReadLine();
        }

        // 4.4.3
        static void CountUp()
        {
            double initialValue, result;

            Console.Write("Skriv et tal: ");

            // Remember to check the return type.
            initialValue = double.Parse(Console.ReadLine());

            result = initialValue + 12;

            Console.WriteLine($"Variablen er nu øget med 12 og har fået værdien: {result}");
        }

        // 4.5
        static void TaxiCalculator()
        {
            //På hverdagskørsel fra kl. 04 til kl. 20 opkræves en starttakst på 29 kr.og en kilometertakst på 9 kr
            /*
             * 04 - 20 (20 - 4 = 16 hours; maxPrice = 9 * 16 + 20 = 54 + 90 + 20 = 110 + 54 = 164 dkk)
             * Start price: 20 dkk
             * 9 dkk/km
             * */

            decimal pricePrKM = 9;      // In DKK
            decimal startPrice = 20;    // In DKK

            decimal result = 0;         // In DKK

            int userKM = 0;

            Console.WriteLine(">>Velkommen til taxaberegner<<");
            Console.Write("Indtast antal kilometer: ");
            userKM = int.Parse(Console.ReadLine());

            Console.Write("Indtast pris pr. KM: ");
            pricePrKM = decimal.Parse(Console.ReadLine());

            result = (pricePrKM * (decimal)userKM) + startPrice;

            // Debug
            //Console.WriteLine($"Result: {result}");

            Console.WriteLine($"Prisen bliver: {result}");

        }

        // 4.5.2
        static void TestParsing()
        {
            int age;
            decimal price;
            double height;

            // age = int.Parse("33"); // Do like this
            // age = int.Parse(Console.ReadLine()); // Do like this
            // age = int.Parse("33 år"); // Error

            height = 1.78; // Use "." In C#
            // height = double.Parse("1,78"); // Use "," outside C# (Danish komma)
            // height = double.Parse(Console.ReadLine()); // Parse input

            // TryParse - no crash
            int.TryParse("33", out age);
            decimal.TryParse("331,95", out price);

            Console.WriteLine($"age: {age}, height: {height}, price: {price}");
        }

        // 4.5.3
        static void ConvertReadLine()
        {
            double firstNumber = 0;
            double secondNumber = 0;
            double sum = 0;

            Console.Write("Indtast tal: ");
            double.TryParse(Console.ReadLine(), out firstNumber);

            Console.Write("Indtast tal: ");
            double.TryParse(Console.ReadLine(), out secondNumber);

            sum = firstNumber + secondNumber;

            Console.WriteLine($"Summen af {firstNumber} og {secondNumber} er: {sum}");
        }

        // 4.6
        static void NameAndHobby()
        {

            // User Variables
            string name = "John";
            string hobby = "Dying";
            int age = 12;
            int hobbyYears = 1;

            int startYear = 1984;
            int userHobbyStartAge = 12;

            // Private variables
            int currentYear = int.Parse(DateTime.Now.Year.ToString()); // Get current year

            //string name = "John";

            Console.Write("God dag. Kan du skrive dit navn: ");
            name = Console.ReadLine();

            Console.Write($"Hej {name}, hvad er din hobby?: ");
            hobby = Console.ReadLine();

            Console.Write($"Interesandt. Hvor mange år har du haft {hobby} som hobby?: ");
            //hobbyYears = ((int)(Console.ReadLine()));
            //int.TryParse(str, out hobbyYears);
            //hobbyYears = Convert.ToInt32(Convert.ToDouble(Console.ReadLine()));

            //Int doesn't recognize floatingpoint numbers. So you have to convert it a lot of times. 
            hobbyYears = Convert.ToInt32(Math.Floor(double.Parse(Console.ReadLine())));

            Console.Write($"Hvor gammel er du?: ");
            age = Convert.ToInt32(Math.Floor(double.Parse(Console.ReadLine())));

            startYear = currentYear - hobbyYears;
            userHobbyStartAge = age - hobbyYears;


            Console.WriteLine($"Hej {name}, din hobby er {hobby}. Du begyndte at dyrke {hobby} i {startYear} i en alder af {userHobbyStartAge} år.");
        }

    }
}
