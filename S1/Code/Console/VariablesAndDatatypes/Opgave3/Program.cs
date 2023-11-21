using System;
using System.Linq;

namespace Opgave3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0
            string frugt = "Pære";
            Console.WriteLine(frugt);

            frugt = "Banan";
            Console.WriteLine(frugt);

            // 1
            string firstName = "Tobias";
            string lastName = "Hansen";

            // 2
            string name = firstName + lastName;
            Console.WriteLine(name);

            // 3
            string firstName2 = "Tobias";
            string lastName2 = "Hansen";
            Console.WriteLine($"My name is: {firstName2} {lastName2}");

            // 4
            string formattedString = String.Format("My name is: {0} {1}", firstName, lastName);
            Console.WriteLine(formattedString);

            // 6
            string opgaveText = "I C# er \"string\" en datatype, der bruges til at repræsentere en sekvens af tegn. En \"string\" i C# er en\r\nreference type, hvilket betyder, at den er baseret på en objektreference snarere end at være en\r\nværditype som \"int\" eller \"float\". Strenge i C# er uundgåeligt en vigtig del af mange programmer,\r\nda de bruges til at håndtere tekst og karakterdata. C# tilbyder også en række nyttige metoder og\r\negenskaber til at arbejde med strenge, såsom at finde længden af en streng, ændre tegn i en\r\nstreng, opdele en streng i substrings, og meget mere.";
            Console.WriteLine(opgaveText);
            // Adds a new line to make it more readable
            Console.WriteLine();

            // 7
            Console.WriteLine(opgaveText.ToUpper());
            // Adds a new line to make it more readable
            Console.WriteLine();

            // 8
            Console.WriteLine(opgaveText.ToLower());
            // Adds a new line to make it more readable
            Console.WriteLine();

            // 9
            Console.WriteLine(opgaveText.Count());
            // Adds a new line to make it more readable
            Console.WriteLine();

            // 10
            string temp = opgaveText;

            // 11
            temp = temp.Replace(' ', '¤');
            Console.WriteLine(temp);

            // 12
            int firstPositionOfChar = temp.IndexOf('¤') + 1; // +1 because it starts counting from 0
            Console.WriteLine($"First occurrence of the character \'¤\' is at position: {firstPositionOfChar}");

            int lastPositionOfChar = temp.LastIndexOf('¤') + 1; // +1 because it starts counting from 0
            Console.WriteLine($"Last occurrence of the character \'¤\' is at position: {lastPositionOfChar}");

            // 13
            Console.WriteLine(opgaveText.Length);

            // 14
            // If it's ONLY the word "at" they want, we need to add a space before and after to make sure.
            // Just remember to add the offset to the xIndexOfWord int.
            int firstIndexOfWord = opgaveText.IndexOf("at"); // +1 because it starts counting from 0
            Console.WriteLine($"First occurrence of the word \'at\' is at position: {firstIndexOfWord}");

            int lastIndexOfWord = opgaveText.LastIndexOf("at"); // +1 because it starts counting from 0
            Console.WriteLine($"Last occurrence of the word \'at\' is at position: {lastIndexOfWord}");

            // 15
            int lengthOfText = lastIndexOfWord - firstIndexOfWord;
            // Added a -
            string textInbetween = opgaveText.Substring(firstIndexOfWord--, lengthOfText);
            //Console.WriteLine($"\n\nTextLength: {lengthOfText}"); // Debug
            Console.WriteLine($"\n\n{textInbetween}");

        }
    }
}
