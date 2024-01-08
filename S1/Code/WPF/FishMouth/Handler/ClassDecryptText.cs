using System;
using System.Collections.Generic;
using System.Text;

namespace Handler
{
    public class ClassDecryptText
    {
        private List<string> listStringKey;

        public ClassDecryptText(List<string> inKey)
        {
            listStringKey = inKey;
        }

        public string DecryptString(string inString)
        {
            // Psudokode:
            // TODO Gennemløb hele den krypterede tekststreng og udvælg de tegn der er en del af nøglen.
            // TODO Når der findes et tegn der er en del af nøglen gemmes det i et temp string objekt.
            // TODO Så snart der ikke findes flere tegen der er en del af nøglen,
            // TODO konverteres temp string objektet til et int, som sendes til metoden MakeCharOfCode.
            // TODO Resultatet af MakeCharOfCode gemmes i res string objektet.
            // TODO Objektet temp nulstilles og processen gentages indtil hele den krypterede
            // TODO tekststreng er gennemløbet.

            string result = "";
            string tempString = "";

            Encoding enc1252 = Encoding.GetEncoding("Windows-1252");
            byte[] ascciBytes = enc1252.GetBytes(inString);

            foreach (char encryptedChar in ascciBytes)
            {
                if (listStringKey.Contains(encryptedChar.ToString()))
                {
                    tempString += encryptedChar.ToString();
                }
                else
                {
                    if (tempString.Length > 0)
                    {
                        result += MakeCharOfCode(tempString);
                        tempString = "";
                    }
                }
            }

            // WORKS
            //foreach (char encryptedChar in inString)
            //{
            //    if (listStringKey.Contains(encryptedChar.ToString()))
            //    {
            //        tempString += encryptedChar;
            //    }
            //    else
            //    {
            //        if (tempString.Length > 0)
            //        {
            //            result += MakeCharOfCode(tempString);
            //            tempString = "";
            //        }
            //    }
            //}

            return result;
        }

        private string MakeCharOfCode(string inCharString)
        {
            // Psudokode:
            // TODO Gennemløb inCharString tekststreng og omsæt tegne til tal der fremkommer ved at tegnet
            // TODO passer til en placering i List<string> key.
            // TODO Resultatet af omsætningen gemmes i res string objektet, som converteres til en char og indsættes i res.
            // TODO res returneres.


            string result = "";
            string tempString = "";

            foreach (char character in inCharString)
            {
                tempString += listStringKey.IndexOf(character.ToString());
            }

            result += (char)(Convert.ToInt32(tempString));

            // Jens
            //string res = "";

            //foreach (char inChar in inCharString)
            //{
            //    int intChar = listStringKey.IndexOf(inChar.ToString());
            //    res += intChar.ToString();
            //    //res += listStringKey.IndexOf(character.ToString());
            //}

            //return $"{(char)Convert.ToInt32(res)}";

            // Now do it with Regex.

            return result;
        }
    }
}
