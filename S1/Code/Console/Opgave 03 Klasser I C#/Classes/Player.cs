using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes
{
    
    internal class Player
    {
        string name;
        int score;

        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        // 4.2
        public void Play()
        {
            int playerThrows = 0;
            int dieResult = 0;

            Random rand = new Random();

            Console.WriteLine($"{CLI.Variables.spacing}Welcome to the Dice Rolling Game.\n{CLI.Variables.spacing}Roll as many times as you like, but be careful not to hit a 1 or you'll lose the game.");
            playerThrows = CLI.GetUserInputInt("How many times to you want to throw the die?");

            for (int i = 1; i < playerThrows+1; i++)
            {
                dieResult = rand.Next(1, 7);
                Console.WriteLine($"{CLI.Variables.spacing}Throw {i}) And you got a {dieResult}");
                if (dieResult == 1)
                {
                    CLI.CLIColoredTextRed($"{CLI.Variables.spacing}GAME OVER\n\n");
                    break;
                }
            }
        }

        public override string ToString()
        {
            return $"{name} got a score of: {score}";
        }

        public string GetName()
        {
            return name;
        }

        public void AddScore(int scoreToAdd)
        {
            score += scoreToAdd;
        }

        public int GetScore()
        {
            return score;
        }
    }
}
