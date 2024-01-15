using System;
using System.Collections.Generic;

namespace FærdighedsDelOpg5
{
    internal class Program
    {
        /*
         * [ ] - **Menu**
         * [ ] - Display menu
         * [ ] - Display text file content
         * [ ] - Add content to text file
         * [ ] - Exit
         * 
         * [ ] - **Text file**
         * [ ] - Create text file
         * [ ] - Read text file
         * [ ] - Write to text file
         * [ ] - Append to text file
         * [ ] - Delete text file
         * 
         * [ ] - **Input handling**
         * [ ] - Prompt user for input
         * [ ] - Read input from user
         * [ ] - Validate input
         * 
         * [ ] - **Misc**
         * [ ] - Wait for keypress
         */

        public static List<string> menuList = new List<string>()
        {
            "Vis indhold af tekstfil",
            "Tilføj indhold til tekstfil",
            "Afslut"
        };

        static void Main(string[] args)
        {
            bool stop = false;

            while (!stop)
            {
                DisplayMenu();

                // For testing purposes. Remove when done.
                stop = true;
            }

            Console.ReadKey();
        }

        static void DisplayMenu()
        {
            // TODO: Make this look better. Meybe center the text and add some kind of border?
            int menuOptionNumber = 1;

            //Console.WriteLine("Menu");
            CenterText(" Menu ", '=', -2);
            foreach (string menuOption in menuList)
            {
                Console.Write('\n');
                //Console.WriteLine($" {menuOptionNumber}) {menuOption}");
                Console.Write('*');
                CenterText(menuOption, ' ', 1);
                Console.Write('*');
                menuOptionNumber++;
            }
        }

        static void CenterText(string text, char characterToFill, int numbersOfCharsToRemove)
        {
            int consoleWidth = Console.WindowWidth;
            int textLength = text.Length;
            int spaces = (consoleWidth / 6) - (textLength / 2);

            Console.Write(new string(characterToFill, spaces - numbersOfCharsToRemove) + text + new string(characterToFill, spaces - numbersOfCharsToRemove));
        }

        static void DisplayTextFileContent()
        {

        }

        static void AddContentToTextFile()
        {

        }
    }
}
