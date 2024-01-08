using System.Collections.Generic;
using System.Text;

namespace Handler
{
    public class ClassEncryptText
    {
        private List<string> key;
        private ClassDummyText CDT;

        public ClassEncryptText(List<string> inKey)
        {
            key = inKey;
            CDT = new ClassDummyText(key);
        }

        public string EncryptString(string inString)
        {
            string result = CDT.MakeDummyString();

            // We use Windows-1252 encoding to convert the string to a byte array
            Encoding enc1252 = Encoding.GetEncoding("Windows-1252");
            byte[] ascciBytes = enc1252.GetBytes(inString); // Converts input string to byte array

            foreach (byte ascciByte in ascciBytes)
            {
                char aChar = (char)ascciByte; // Casts the byte to a char
                // char aChar = ascciByte as char; // does the same thing as the line above
                MakeCodeOfChar(aChar);
                result += MakeCodeOfChar(aChar) + CDT.MakeDummyString();
            }

            return result;
        }

        private string MakeCodeOfChar(char aChar)
        {
            string result = "";

            int intChar = (int)aChar; // Casts the char to an int
            string strChar = intChar.ToString(); // Converts the int to a string

            foreach (char aDigit in strChar)
            {
                result += key[int.Parse(aDigit.ToString())]; // Converts the digit to an int and uses it as an index to get the key value
            }

            return result;
        }
    }
}
