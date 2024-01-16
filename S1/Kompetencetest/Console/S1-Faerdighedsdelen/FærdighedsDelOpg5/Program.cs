﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FærdighedsDelOpg5
{
    internal class Program
    {
        /*
         * [ ] - **Menu**
         * [X] - Display menu
         * [ ] - Display text file content
         * [ ] - Add content to text file
         * [X] - Exit
         * 
         * [ ] - **Text file**
         * [X] - Create text file
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
            "Skift tekstfil",
            "Afslut "
        };

        [STAThread]
        static void Main(string[] args)
        {
            bool stop = false;
            string userInput = "";
            string path = "gaming.txt";

            while (!stop)
            {
                DisplayMenu();

                // Get user input
                userInput = Console.ReadLine();

                // Handle user input
                switch (userInput)
                {
                    case "1":
                        DisplayTextFileContent(path);
                        break;
                    case "2":
                        DisplayMenuWriteToFile(path);
                        break;
                    case "3":
                        // Credit to the Microsoft C# Doc: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog.restoredirectory?view=windowsdesktop-8.0 

                        // Open file dialog, so the user can choose a file they want to use
                        using (OpenFileDialog openFileDialog = new OpenFileDialog())
                        {
                            openFileDialog.InitialDirectory = "./"; // Set initial directory
                            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // Set file filter
                            openFileDialog.FilterIndex = 1; // Set filter index to only show .txt files
                            openFileDialog.RestoreDirectory = true;

                            if (openFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                // Gets the path of specified file
                                path = openFileDialog.FileName;
                            }
                        }
                        break;
                    case "4":
                        stop = true;
                        break;
                    default:
                        Console.Write("Fejl. Ikke gyldigt valg.");
                        break;
                }

                Console.Write("\nTryk på en tast for at fortsætte...");
                Console.ReadKey();
            }

        }

        static void DisplayMenu()
        {
            // TODO: Make this look better. Meybe center the text and add some kind of border?
            int menuOptionNumber = 1;

            Console.Clear();

            Console.Write(CenterText(" Menu ", '=', -1));
            foreach (string menuOption in menuList)
            {
                Console.Write("\n* {0}{1}*", menuOptionNumber, CenterText(menuOption, ' ', 2));
                menuOptionNumber++;
            }
            Console.Write("\n{0}\n\n >", CenterText("", '=', -1));
        }

        static void DisplayMenuWriteToFile(string path)
        {
            bool stop = false;

            while (!stop)
            {
                Console.Clear();

                Console.Write("1) Skriv til fil\n2) Overskriv alt i fil\n3) Tilbage\n\n >");
            }
            AddContentToTextFile(path, 0);
        }

        static void DisplayTextFileContent(string path)
        {
            FileHandler fileHandler = new FileHandler();

            Console.Clear();
            Console.WriteLine(fileHandler.ReadTextFromFile(path));
        }

        static void AddContentToTextFile(string path, int option)
        {
            FileHandler fileHandler = new FileHandler();

            Console.Clear();
            switch (option)
            {
                case 0:
                    fileHandler.WriteTextToFile_Append(path, "Hello World! 23");
                    break;
                case 1:
                    fileHandler.WriteTextToFile(path, "Hello World! 23");
                    break;
            }
        }

        /// <summary>
        /// Centers the text in the console window (It's on the left side, but it looks better)
        /// </summary>
        /// <param name="text">Text in the middle</param>
        /// <param name="characterToFill">Char that fills the rest of the line</param>
        /// <param name="numbersOfCharsToRemove"></param>
        /// <returns>string - The centered text</returns>
        static string CenterText(string text, char characterToFill, int numbersOfCharsToRemove)
        {
            int consoleWidth = Console.WindowWidth;
            int textLength = text.Length;
            int spaces = (consoleWidth / 4) - (textLength / 2);

            return (new string(characterToFill, spaces - numbersOfCharsToRemove) + text + new string(characterToFill, spaces - numbersOfCharsToRemove));
        }
    }

    internal class FileHandler
    {
        public string ReadTextFromFile(string path)
        {
            // Initialisering af den variabel der skal indeholde teksten fra filen.
            string resText = "";
            // Validering af om der er modtaget en path
            if (path.Trim().Length == 0)
            {
                // Hvis der ikke er modtaget en path
                return $"Der er ikke angivet nogen sti til filen.";
            }

            // Validering af om filen findes på den angivne placering som fremgår af path.
            if (!File.Exists(path))
            {
                // Hvis filen ikke findes, returneres følgende tekst.
                return $"Filen med følgende sti\n\n{path}\n\n blev IKKE fundet.";
            }

            // Der benyttes Try-Catch for at kunne håndtere fejl/exceptions der kan
            // opstå ved kommunikation med eksterne enheder.
            try
            {
                // Der benyttes Using for at gøre håndteringen af resurserne FileStream og
                // StreamReader nemmere og mere sikker. GarbageCollectoren i styresystemet
                // vil håndtere handlingerne med at lukke for resurserne når de længer skal
                // benyttes.

                // FileStream åbner forbindelsen til filen
                using (FileStream fileStream = new FileStream(path, FileMode.Open))
                {
                    // StreamReader giver mulighed for at tilgå indholdet af filen
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        // reader læser indholdet af filen og skriver det ind i resText.
                        resText = reader.ReadToEnd();
                    }
                }
            }
            // Fanger en evt. Exception.
            catch (IOException ex)
            {
                // Tager den opståede Exception og sender den bagud til den metode der har
                // kaldt denne metode. 
                throw ex;
            }
            // Returnere indholdet af filen.
            return resText;
        }

        public void WriteTextToFile(string path, string text)
        {
            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        writer.AutoFlush = true;
                        writer.WriteLine(text);
                    }
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }

        public void WriteTextToFile_Append(string path, string text)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(path))
                {
                    writer.AutoFlush = true;
                    writer.WriteLine(text);
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
    }
}
