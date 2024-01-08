using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO;

using Repository;
using Microsoft.Win32;

namespace Handler
{
    public class ClassHandler
    {
        private ClassFileHandler fileIO;
        private ClassZIP zip;

        public ClassHandler()
        {
            fileIO = new ClassFileHandler();
            zip = new ClassZIP(); 
            clearText = new ClassText();
            encryptedText = new ClassText();
        }

        public ClassText clearText { get; set; }
        public ClassText encryptedText { get; set; }

        public void MakeEncryptedText()
        {
            // TODO: Add functionality here
        }

        public void MakeDecryptedText()
        {
            // TODO: Add functionality here
        }

        public void MakeRollingEncryptedText()
        {
            // TODO: Add functionality here
        }

        public void MakeRollingDecryptedText()
        {
            // TODO: Add functionality here
        }

        public void MakeExtraEncryptedText()
        {
            // TODO: Add functionality here
        }

        public void MakeExtraDecryptedText()
        {
            // TODO: Add functionality here
        }

        public void ReadClearTextFromFile()
        {
            clearText.fishText = fileIO.ReadTextFromFile(GiveMeLoadPath());
        }

        public void ReadEncryptedTextFromFile()
        {
            encryptedText.fishText = fileIO.ReadTextFromFile(GiveMeLoadPath());
        }

        public void WriteEncryptedTextToFile()
        {
            fileIO.WriteTextToFile_StreamWriter(GiveMeSavePath(), encryptedText.ToString());
        }

        public void WriteClearTextToFile()
        {
            fileIO.WriteTextToFile_StreamWriter(GiveMeSavePath(), clearText.ToString());
        }

        private string GiveMeLoadPath()
        {
            string path = "";

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == true)
            {
                path = ofd.FileName;
            }

            return path;
        }

        private string GiveMeSavePath()
        {
            string path = "";

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "c:\\";
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == true)
            {
                path = sfd.FileName;
            }

            return path;
        }

    }
}
