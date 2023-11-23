using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        // Part of 3.5
        public static Player player = new Player("Nervous Carrot", 0);
        //public static Player player1 = new Player();
        //public static Player player2 = new Player();
        //public static Player player3 = new Player();
        //public static Player player4 = new Player();
        //public static Player player5 = new Player();

        // Variables for this assignment
        public static Player[] playerArray = new Player[5];

        static void Main(string[] args)
        {

            InitPlayerArray();
            CLI.Menu();

            Console.ReadKey();

        }

        // 3.5
        private static void InitPlayerArray()
        {
            //playerArray[0] = player1;
            //playerArray[1] = player2;
            //playerArray[2] = player3;
            //playerArray[3] = player4;
            //playerArray[4] = player5;
        }

        // Command: printarray
        public static void PrintArray()
        {
            for (int i = 0; i < playerArray.Length; i++)
            {
                Console.WriteLine(playerArray[i].ToString());
            }
        }

        public static void PlayMult()
        {
            int playerThrows = 0;
            int dieResult = 0;
            int playerCount = 0;
            int counter = 1;
            bool run = true;

            Random rand = new Random();

            // Welcome msg
            Console.WriteLine(
                $"{CLI.Variables.spacing}Welcome to the Dice Rolling Game.\n{CLI.Variables.spacing}Roll as many times as you like, but be careful not to hit a 1 or you'll lose the game.");

            // Asks for a number between 1-5
            while (!(playerCount > 0 && playerCount <= 5))
            {
                playerCount = CLI.GetUserInputInt("How many participants? (1-5)");
                if (playerCount <= 0 || playerCount > 5)
                {
                    Console.WriteLine($"{CLI.Variables.spacing}Please pick a number between 1-5");
                }
            }

            // Gives a name to the players
            Console.WriteLine($"{CLI.Variables.spacing}Naming the players");

            for (int i = 0; i < playerCount; i++)
            {
                playerArray[i] = new Player(CLI.GetUserInputString($"Player {i + 1}:"), 0);
            }

            playerThrows = CLI.GetUserInputInt("How many times to you want to throw the die?");

            // Starts the game
            while (run == true && counter <= playerThrows)
            {
                for (int j = 0; j < playerCount; j++)
                {
                    dieResult = rand.Next(1, 7);
                    Console.WriteLine($"{CLI.Variables.spacing}{playerArray[j].GetName()} | Throw {counter}) And you got a {dieResult}");
                    playerArray[j].AddScore(dieResult);
                    if (dieResult == 1)
                    {
                        CLI.CLIColoredTextRed($"{CLI.Variables.spacing}GAME OVER\n\n");
                        run = false;
                        break;
                    }
                }

                counter++;
                Console.WriteLine();

                // Displays the score at the end
                if (run == false)
                {
                    for (int j = 0; j < playerCount; j++)
                    {
                        Console.WriteLine($"{CLI.Variables.spacing}{playerArray[j].ToString()}");
                    }

                    // Spacing 
                    Console.WriteLine();
                }
            }

            // Displays the score at the end if they didn't get a 1
            if (run == true)
            {
                for (int j = 0; j < playerCount; j++)
                {
                    Console.WriteLine($"{CLI.Variables.spacing}{playerArray[j].ToString()}");
                }

                // Spacing 
                Console.WriteLine();
            }
        }
    }
}
