using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes
{
    internal class CLI
    {
        /// <summary>
        /// A class used for the commands list.
        /// </summary>
        public class Commands
        {
            //public string command { get; set; }

            //public string description { get; set; }

            private string command;
            private string description;

            public Commands(string command, string description)
            {
                this.command = command;
                this.description = description;
            }

            public string Command
            {
                get { return command; }
                set { command = value; }
            }

            public string Description
            {
                get { return description; }
                set { description = value; }
            }
        }

        /// <summary>
        /// Contains every variable that's used for the CLI methods.
        /// </summary>
        public static class Variables
        {
            public static string choice = " ";

            public static bool stop = false;
            public const string spacing = "\t  ";
            public const string input = "\t> ";

            public static List<Commands> commandsList = new List<Commands>();
        }

        /// <summary>
        /// Starts and runs the CLI.
        /// </summary>
        public static void Menu()
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

            // TODO: Maybe add this to a CLIInit() method. 
            // Adds every command with it's description to the list of commands
            Variables.commandsList.Add(new Commands("help", "Writes out every command to the console."));
            Variables.commandsList.Add(new Commands("clear", "Clears the screen."));
            Variables.commandsList.Add(new Commands("stop", "stops the CLI."));
            Variables.commandsList.Add(new Commands("date", "Writes the current date and time to the console."));
            Variables.commandsList.Add(new Commands("for", "A simple for-loop \"demo\"."));

            // Only for this assignment (Classes 03)
            Variables.commandsList.Add(new Commands("printarray", "Prints the player array to the console."));

            // Writes the "Welcome" msg
            Console.Write(
                "\n" +
                " ***********************\n" +
                " ** Tobsi CLI         **\n" +
                " ** Fueled by Pepsi");

            CLIColoredTextRed("Max");

            Console.Write(" **\n" +
                " ***********************\n\n" +
                "\ttype help to display commands\n");

            // Starts the loop
            while (!Variables.stop == true)
            {
                MenuHandler();
            }
        }

        /// <summary>
        /// Reads the users input and executes the command.
        /// </summary>
        public static void MenuHandler()
        {
            Console.Write(Variables.input);
            Variables.choice = Console.ReadLine();

            switch (Variables.choice)
            {
                case "clear":
                    Clear();
                    break;
                case "stop":
                    Variables.stop = true;
                    Console.WriteLine("\n");
                    break;
                case "help":
                    PrintOptions();
                    break;
                case "date":
                    Console.WriteLine($"{Variables.spacing}Local date: {DateTime.Now}\n");
                    break;
                case "for":
                    ForL();
                    break;
                case "printarray":
                    Program.PrintArray();
                    break;
                case "play":
                    Program.player.Play();
                    break;
                case "playmu":
                    Program.PlayMult();
                    break;
                default:
                    Console.WriteLine($"{Variables.spacing}{Variables.choice} is not a command\n");
                    break;
            }
        }

        /// <summary>
        /// Clears the console. Works like cls.
        /// </summary>
        public static void Clear()
        {
            Console.Clear();
        }

        /// <summary>
        /// This is a test command.
        /// </summary>
        static void ForL()
        {
            Random random = new Random();
            int rand = random.Next(1, 100); // Gives a random number.
            int res = 0;

            for (int i = 1; i < 11; i++)
            {
                res = i * rand;
                Console.WriteLine($"{Variables.spacing}{rand} * {i} = {res}");
            }
        }

        /// <summary>
        /// Prints every command with a description from the commands list.
        /// </summary>
        static void PrintOptions()
        {

            foreach (var print in Variables.commandsList)
            {
                Console.WriteLine("{0}{1}\n{2} {3}", Variables.spacing, print.Command, Variables.spacing, print.Description);
            }
        }

        public static string GetUserInputString(string msg)
        {
            
            Console.Write($"\n{Variables.spacing}{msg}\n{Variables.input}");
            return Console.ReadLine();
        }

        public static double GetUserInputDouble(string msg)
        {
            double userInput = 0;

            bool resume = false; // Couldn't use continue

            while (resume == false)
            {
                Console.Write($"\n{Variables.spacing}{msg}\n{Variables.input}");
                if (double.TryParse(Console.ReadLine(), out userInput))
                {
                    resume = true;
                }
                else
                {
                    CLIColoredTextRed($"\n{Variables.spacing}Parsing error.\n");
                }
            }

            return userInput;
        }

        public static int GetUserInputInt(string msg)
        {
            int userInput = 0;

            bool resume = false; // Couldn't use continue

            while (resume == false)
            {
                Console.Write($"\n{Variables.spacing}{msg}\n{Variables.input}");
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    resume = true;
                }
                else
                {
                    CLIColoredTextRed($"\n{Variables.spacing}Parsing error.\n");
                }
            }

            return userInput;
        }

        // These methods are used a lot

        /// <summary>
        /// Prints a string of text to the console. Color: Cyan
        /// </summary>
        /// <param name="msg">Will be printed to the console.</param>
        public static void CLIColoredText(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(msg);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Prints a string of text to the console. Color: Red
        /// </summary>
        /// <param name="msg">Will be printed to the console.</param>
        public static void CLIColoredTextRed(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(msg);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}


