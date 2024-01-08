using System;
using System.Collections.Generic;
using System.Text;

namespace Handler
{
    public class ClassDummyText
    {
        private List<string> key;
        private Random rnd;
        private Encoding win1252 = Encoding.GetEncoding("Windows-1252");

        public ClassDummyText(List<string> inKey)
        {
            key = inKey;
            rnd = new Random();
        }

        public string MakeDummyString()
        {
            string result = "";
            int numberOfChars = rnd.Next(5, 16); // Random number between 5 and 15

            for (int i = 1; i <= numberOfChars; i++)
            {
                result += MakeDummyChar();
            }

            return result;
        }

        private string MakeDummyChar()
        {
            string result = "";
            bool foundInKey = false;

            do
            {
                result = win1252.GetString(new byte[] { (byte)rnd.Next(33, 123) }); // Casts the random int to a byte and converts it to a string
                foundInKey = key.Contains(result); // Checks if the string is in the key and sets foundInKey to true if it is
            } while (foundInKey);

            int rndChar = rnd.Next(33, 123); // Random number between 33 and 122

            return result;
        }

    }
}
