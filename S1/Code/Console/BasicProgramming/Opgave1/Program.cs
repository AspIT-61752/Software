using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;

namespace Opgave1
{
    public enum BMIResult
    {
        [Description("Undervægtig Mand")]
        underWeightM = 1,

        [Description("Undervægtig Kvinde")]
        underWeightF = 2,

        [Description("Normalvægtig Mand")]
        normalWeightM = 3,

        [Description("Normalvægtig Kvinde")]
        normalWeightF = 4,

        [Description("Overvægtig Mand")]
        overWeightM = 5,

        [Description("Overvægtig Kvinde")]
        overWeightF = 6,

        [Description("Svært overvægtig Mand")]
        sOverWeightM = 7,

        [Description("Svært overvægtig Kvinde")]
        sOverWeightF = 8,
    }

    public static class CLIVariables
    {
        public static string CLIChoice = " ";

        public static bool CLIStop = false;
        public const string CLISpacing = "\t  ";
        public const string CLIInput = "\t> ";

    }

    public enum CLIChoices
    {
        exit = 0,
        start = 1,
        about = 2,
        randomNumber = 3,

    }

    internal class Program
    {
        // Public variables
        public string name = "John";

        static void Main(string[] args)
        {
            // This is for consistency.
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;

            //WriteToConsole(GetUserInput());
            //Hello();
            //CountUp();
            //TaxiCalculator();

            //ConvertReadLine();
            //NameAndHobby();
            //BMICalc();

            /*Console.Write("gaming, ");
            CLIColoredText("more ");
            Console.Write("and something else");
            CLIMenu();*/

            CLIMenu();

            // Wait for input
            Console.ReadKey();
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

            // Prompt 1
            Console.Write("God dag. Kan du skrive dit navn: ");
            name = Console.ReadLine();

            // Prompt 2
            Console.Write($"Hej {name}, hvad er din hobby?: ");
            hobby = Console.ReadLine();

            // Prompt 3
            Console.Write($"Interesandt. Hvor mange år har du haft {hobby} som hobby?: ");

            //Int doesn't recognize floatingpoint numbers. So you have to convert it a lot of times. 
            hobbyYears = Convert.ToInt32(Math.Floor(double.Parse(Console.ReadLine())));

            // Prompt 4
            Console.Write($"Hvor gammel er du?: ");
            age = Convert.ToInt32(Math.Floor(double.Parse(Console.ReadLine())));

            // Math
            startYear = currentYear - hobbyYears;
            userHobbyStartAge = age - hobbyYears;

            // Displaying the info
            Console.WriteLine($"Hej {name}, din hobby er {hobby}. Du begyndte at dyrke {hobby} i {startYear} i en alder af {userHobbyStartAge} år.");
        }

        // 5.7
        static void BMICalc()
        {
            /*
                Indtast din højde i meter: 1,78
                Indtast din vægt i kilo: 74
                Indtast køn M/K: M
                BMI: 23,355636914530993561419012751
                Normalvægtig mand

                https://nexs.ku.dk/forskning/vidensbanken/bmi-udregning/ 
                https://hjemmetraeningudstyr.dk/bmi-beregner/
                Formel: weight/height^2
                Under 18,5	Undervægtig
                18,5-25	Normalvægtig
                25-30	Overvægtig
                Over 30	Svært overvægtig

                BUGS:
                    Can't use . because C# looks at the local standardized decimal separator character (In Denmark it's ,).
                    I haven't made any try-catch error handling. 
            */

            double height = 0.2;
            double weight = 36.4;
            string gender = "N";

            double userBMI = 15.3;


            Console.Write("Indtast din højde i meter: ");
            double.TryParse(Console.ReadLine(), out height);

            Console.Write("Indtast din vægt i kilo: ");
            double.TryParse(Console.ReadLine(), out weight);

            Console.Write("Indtast dit køn M/K: ");
            gender = Console.ReadLine().ToLower();

            Console.WriteLine($"GENDER: {gender}");

            userBMI = weight / Math.Pow(height, 2);

            Console.WriteLine($"BMI: {userBMI}");

            /*
             CPR number strat:
            Uneven numbers => Male
            To check if it's a male or female person divide by 2 and check if there's a remainder. 
            Starts at underwheight
             */

            // Checks if they're male
            if (gender.StartsWith("m"))
            {
                // Under
                if (userBMI <= 18.5)
                {
                    Console.Write(GetEnumDescription(BMIResult.underWeightM));
                }
                // Normal
                else if (userBMI > 18.5 && userBMI <= 25)
                {
                    Console.Write(GetEnumDescription(BMIResult.normalWeightM));
                }
                // Over
                else if (userBMI > 25 && userBMI <= 30)
                {
                    Console.Write(GetEnumDescription(BMIResult.overWeightM));
                }
                // Very
                else
                {
                    Console.Write(GetEnumDescription(BMIResult.sOverWeightM));
                }
            }
            else
            {
                // Female
                // Under
                if (userBMI <= 18.5)
                {
                    Console.Write(GetEnumDescription(BMIResult.underWeightF));
                }
                // Normal
                else if (userBMI > 18.5 && userBMI <= 25)
                {
                    Console.Write(GetEnumDescription(BMIResult.normalWeightF));
                }
                // Over
                else if (userBMI > 25 && userBMI <= 30)
                {
                    Console.Write(GetEnumDescription(BMIResult.overWeightF));
                }
                // Very
                else
                {
                    Console.Write(GetEnumDescription(BMIResult.sOverWeightF));
                }
            }
        }

        // 6.5 START

        static void CLIMenu()
        {
            /*
             Commands I want to make:
             clear
             date
             stop
             */

            // Start
            Console.Clear();
            //Console.Write(
            //    "***********************\n" +
            //    "** Tobsi CLI         **" +
            //    "** Fuled by PepsiMax **" +
            //    "***********************\n");

            Console.Write(
                "\n" +
                " ***********************\n" +
                " ** Tobsi CLI         **\n" +
                " ** Fueled by Pepsi");

            CLIColoredTextRed("Max");

            Console.Write(" **\n" +
                " ***********************\n\n" +
                "\ttype help to display commands\n");

            while (!CLIVariables.CLIStop == true)
            {
                CLIMenuHandler();
            }
        }

        static void CLIMenuHandler()
        {
            Console.Write(CLIVariables.CLIInput);
            CLIVariables.CLIChoice = Console.ReadLine();

            switch (CLIVariables.CLIChoice)
            {
                case "clear":
                    CLIClear();
                    break;
                case "stop":
                    CLIVariables.CLIStop = true;
                    Console.WriteLine("\n");
                    break;
                case "help":
                    CLIPrintOptions();
                    break;
                case "date":
                    Console.WriteLine($"{CLIVariables.CLISpacing}Local date: {DateTime.Now}\n");
                    break;
                case "for":
                    CLIFor();
                    break;
                case "div":
                    Division();
                    break;
                case "fore":
                    Fore();
                    break;
                default:
                    Console.WriteLine($"\t{CLIVariables.CLIChoice} is not a command\n");
                    break;
            }
        }

        static void CLIClear()
        {
            Console.Clear();
        }

        static void CLIFor()
        {
            Random random = new Random();
            int rand = random.Next(1, 100); // Gives a random number.
            int res = 0;

            for (int i = 1; i < 11; i++)
            {
                res = i * rand;
                Console.WriteLine($"{CLIVariables.CLISpacing}{rand} * {i} = {res}");
            }
        }

        static void CLIPrintOptions()
        {
            Console.WriteLine(
                $"{CLIVariables.CLISpacing}help\n" +
                $"{CLIVariables.CLISpacing} Writes out every command to the console.\n" +
                $"{CLIVariables.CLISpacing}clear\n" +
                $"{CLIVariables.CLISpacing} Clears the screen.\n" +
                $"{CLIVariables.CLISpacing}stop\n" +
                $"{CLIVariables.CLISpacing} Stops the CLI.\n" +
                $"{CLIVariables.CLISpacing}date\n" +
                $"{CLIVariables.CLISpacing} Writes the current date and time to the console.\n" +
                $"{CLIVariables.CLISpacing}for\n" +
                $"{CLIVariables.CLISpacing} A simple for-loop \"demo\".\n" +
                $"{CLIVariables.CLISpacing}div\n" +
                $"{CLIVariables.CLISpacing} A simple division program.\n" +
                $"{CLIVariables.CLISpacing}fore\n" +
                $"{CLIVariables.CLISpacing} A for-each \"demo\".\n"
                );
        }

        // TODO: Rewrite all of this. I read the assignment wrong. 
        /*static void CLIMenu()
        {
            CLIPrintMenu();

            Console.Write("User choice: ");
            // Choice
            Console.ForegroundColor = ConsoleColor.Cyan;
            string coice = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

        }

        static void CLIPrintMenu()
        {
            Console.Clear(); // Clears the console

            Console.WriteLine("=== Menu ===");*/

        /*
         === Menu ===
        empty
            1)  Option 1
            2)  Option 2
            0)  Exit
         */

        /*CLIColoredText(" 0");
        Console.WriteLine(") Exit");
        }*/

        // 6.5 END

        // 6.9
        static void Division()
        {
            double firstNumber = 0;
            double secondNumber = 0;
            double result = 0;

            bool resume = false; // Couldn't use continue

            // Number 1
            while (resume == false)
            {
                Console.Write($"\n{CLIVariables.CLISpacing}Write the numerator here:\n{CLIVariables.CLIInput}");
                if (double.TryParse(Console.ReadLine(), out firstNumber))
                {
                    resume = true;
                }
                else
                {
                    CLIColoredTextRed($"\n{CLIVariables.CLISpacing}Parsing error.\n");
                }
            }

            // Resets the boolean so it can be used again
            resume = false;

            // Number 2
            while (resume == false)
            {
                Console.Write($"\n{CLIVariables.CLISpacing}Write the denominator here:\n{CLIVariables.CLIInput}");
                if (double.TryParse(Console.ReadLine(), out secondNumber))
                {
                    resume = true;
                }
                else
                {
                    CLIColoredTextRed($"\n{CLIVariables.CLISpacing}Parsing error.\n");
                }
            }

            // Calculates and writes the result
            result = firstNumber / secondNumber;
            Console.WriteLine($"\n{CLIVariables.CLISpacing}{firstNumber} / {secondNumber} = {result}");
        }
        
        // 6.10
        static void Fore()
        {

        }

        // These methods are used a lot

        // From https://codereview.stackexchange.com/questions/157871/method-that-returns-description-attribute-of-enum-value
        public static string GetEnumDescription(Enum value)
        {
            // How it works
            // https://stackoverflow.com/questions/28352072/what-does-question-mark-and-dot-operator-mean-in-c-sharp-6-0
            // https://learn.microsoft.com/en-in/dotnet/csharp/language-reference/operators/null-coalescing-operator // The null-coalescing operator ?? returns the value of its left-hand operand if it isn't null;
            return value.GetType().GetMember(value.ToString()).FirstOrDefault()?.GetCustomAttribute<DescriptionAttribute>()?.Description ?? value.ToString();
        }

        // A quick debugging method I use
        public static void dbgStr(string variableName, string value)
        {
            Console.WriteLine($"{variableName}: {value}");
        }

        // CLI methods
        static void CLIColoredText(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(msg);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void CLIColoredTextRed(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(msg);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
