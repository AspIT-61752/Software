using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    /// <summary>
    /// Does everything related to files (reading, writing, etc.)
    /// </summary>
    public class FileHandler
    {
        /// <summary>
        /// Overwrites the content in the file with new content
        /// </summary>
        /// <param name="path">The path to the file that the user wants to write to</param>
        /// <param name="text">The text that the user wants to write to the file</param>
        public void WriteTextToFile(string path, string text)
        {
            try
            {
                // This will create the file if it doesn't exist
                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    // And write the text to the file
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

        /// <summary>
        /// Adds text to the end of a file
        /// </summary>
        /// <param name="path">The path to the file that the user wants to write to</param>
        /// <param name="text">The text that the user wants to write to the file</param>
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

        /// <summary>
        /// Gets the filepath from the user
        /// </summary>
        /// <returns>string - The filepath</returns>
        public string getFilepath()
        {
            // Open file dialog, so the user can choose a file they want to use
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "./"; // Set initial directory
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // Set file filter
                openFileDialog.FilterIndex = 1; // Set filter index to only show .txt files
                openFileDialog.RestoreDirectory = true; // Remember the directory the user was in last time

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Gets the path of specified file
                    return openFileDialog.FileName;
                }
            }
            return null;
        }
    }
}
