using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using IO;
using System.Windows.Controls;
using System.Collections.Specialized;

namespace Handler
{
    public class ClassHandler
    {

        //private Repository.ClassRepository _classRepository;

        // Remember to change the path so it fits the computer this program runs on.
        ClassIO fileIO = new ClassIO(@"C:\Users\tsh40\Desktop\School\AspIT S1\Software\S1\Res\Uge 3 - WPF\admiralen.txt");

        public ClassHandler()
        {
            strInText = new ClassTextData();
            strOutText = new ClassTextData();

            strInText.strData = fileIO.ReadAllTextFromFile();
            strOutText.strData = "Her kommer min OutData";
        }

        public ClassTextData strInText { get; set; }
        public ClassTextData strOutText { get; set; }

        // Used to test if the binding still works. TODO: Delete this method when you're done.
        public void test()
        {
            strOutText.strData = "Button 1 is pressed!!!!!";
        }

        // Assignment 1. 
        /// <summary>
        /// Counts all lines in the given textbox.
        /// </summary>
        /// <param name="textBox">TextBox you want to know the linecount of</param>
        /// <returns>Amount of lines in the TextBox</returns>
        public int CountAllLines(TextBox textBox)
        {
            int result = 0;
            int lineCount = textBox.LineCount;

            for (int i = 0; i < lineCount; i++)
            {
                // If the line is empty, don't count it.
                if (textBox.GetLineText(i).Trim().Length > 0)
                {
                    result++;
                }

                // This will count all lines, even if they're empty.
                //if (textBox.GetLineText(i).Length > 0)
                //{
                //    result++;
                //}
            }

            // Could also do this instead:
            //strOutText.strData = result.ToString();

            return result;
        }

        // Assignment 2.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public int CountAllChars(TextBox textBox)
        {
            int charCount = 0;

            foreach (char c in textBox.Text)
            {
                charCount++;
            }

            return charCount;
        }

        // Assignment 3.
        /// <summary>
        /// Counts all vowels in the given TextBox.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>The amount of vowels found.</returns>
        public int CountAllVowels(TextBox textBox)
        {
            int vowelCount = 0;
            string vowels = "aeiouyæøå";

            foreach (char c in textBox.Text.ToLower())
            {
                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }

        // Assignment 4.
        /// <summary>
        /// Removes all vowels from the given TextBox.
        /// </summary>
        /// <param name="textBox">Input TextBox. Result will be displayed in strOutText.</param>
        public void RemoveAllVowels(TextBox textBox)
        {
            string vowels = "aeiouyæøå";
            string textCopy = textBox.Text;

            foreach (char c in textBox.Text.ToLower())
            {
                if (vowels.Contains(c))
                {
                    textCopy = textCopy.Replace(c.ToString(), "");
                }
            }

            strOutText.strData = textCopy;
        }

        // Assignment 5.
        /// <summary>
        /// Searches the TextBox for a given word.
        /// </summary>
        /// <param name="textBox">TextBox with to be searched.</param>
        /// <param name="searchTextBoxFor">String of text</param>
        public void SearchForWord(TextBox textBox, string searchTextBoxFor)
        {
            string text = textBox.Text;
            int i = text.IndexOf(searchTextBoxFor); // -1 if not found

            if (searchTextBoxFor != "")
            {
                while (i != -1)
                {
                    text = text.Insert(i, "#>");
                    i = text.IndexOf(searchTextBoxFor, i + 3); // +3 to avoid infinite loop. (+2 because of the two extra characters, and +1 to avoid starting at the same word)
                }
                strOutText.strData = text;
            }
            else
            {
                strOutText.strData = "Du skal skrive noget i søgefeltet.";
            }

        }

        // Assignment 6.
        /// <summary>
        /// Counts and returns a list of length of words in the given TextBox.
        /// </summary>
        /// <param name="textBox"></param>
        public void CountLengthOfWords(TextBox textBox)
        {
            string result = "";
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            List<string> words = new List<string>(textBox.Text.Split(' ')); // Creates a list of all words in the TextBox.

            // Goes through each word in the list, and adds the length to the dictionary.
            foreach (string word in words)
            {
                //Debug.WriteLine(word);
                if (dictionary.TryGetValue(word.Length, out int countValue))
                {
                    countValue++;
                    dictionary[word.Length] = countValue;
                }
                else
                {
                    dictionary.Add(word.Length, 1);
                }
            }

            List<int> list = dictionary.Keys.ToList();
            list.Sort();

            foreach (int i in list)
            {
                result += $"Ord med længde {i}: {dictionary[i]} stk\n";
            }

            strOutText.strData = result;
        }

        // Assignment 7.
        /// <summary>
        /// Counts the frequency of a given words in the given TextBox.
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="wordToSearchFor"></param>
        public void WordFrequencyCounter(TextBox textBox, string wordToSearchFor)
        {
            // https://www.tutorialsteacher.com/linq/what-is-linq 
            // https://www.tutorialsteacher.com/linq/linq-method-syntax
            // LINQ = Language Integrated Query

            //string result = "";
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            List<string> words = new List<string>(textBox.Text.Split().Select(x => x.TrimEnd(",.:;-".ToCharArray())).ToList()); // Creates a list of all words in the TextBox.

            foreach (string word in words)
            {
                if (dictionary.TryGetValue(word, out int count))
                {
                    count++;
                    dictionary[word] = count;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            var list = dictionary.Keys.ToList();
            list.Sort();

            // I could also do this: (Remember to uncomment the result variable)
            //foreach (string s in list)
            //{
            //    result += $"Ordet >> {s} << forekommer: {dictionary[s]} antal gange.\n";
            //}

            string result = list.Aggregate("", (current, s) => current + $"Ordet >> {s} << forekommer: {dictionary[s]} antal gange.\n");

            strOutText.strData = result;
        }

        // Assignment 8.
        /// <summary>
        /// Removes the last letter of all words that are longer than three characters.
        /// </summary>
        /// <param name="textBox"></param>
        public void RemoveLastLetterIfWordIsLongerThanThreeCharacters(TextBox textBox)
        {
            // Substring(int, int)
            // https://www.dotnetperls.com/substring
            // StringCollection
            // https://www.c-sharpcorner.com/UploadFile/mahesh/stringcollection-in-C-Sharp/

            string result = "";
            StringCollection lines = new StringCollection();
            int lineCount = textBox.LineCount;

            for (int i = 0; i < lineCount; i++)
            {
                lines.Add(textBox.GetLineText(i));
            }

            foreach (string line in lines)
            {
                string newLine = "";
                List<string> words = new List<string>(line.Split().Select(x => x.TrimEnd(",.:;-".ToCharArray())).ToList());
                foreach (string word in words)
                {
                    if (word.Length > 3)
                    {
                        newLine += $" {word.Substring(0, (word.Length - 1))}";
                    }
                    else
                    {
                        newLine += $" {word}";
                    }
                }
                result += $"{newLine}\n";
            }

            strOutText.strData = result;
        }
    }
}
