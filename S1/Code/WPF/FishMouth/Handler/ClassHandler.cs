using IO;
using Microsoft.Win32;
using Repository;
using System.Collections.Generic;

namespace Handler
{
    public class ClassHandler
    {
        private ClassFileHandler fileIO;
        private ClassZIP zip;
        List<string> cryptKey = new List<string>() { "T", "O", "R", "S", "K", "E", "M", "U", "N", "D" };
        //List<string> cryptKey = new List<string>() { "‡", "‰", "Œ", "…", "÷", "E", "M", "U", "N", "D" };
        //List<string> cryptKey = new List<string>() { "R", "E", "G", "U", "L", "A", "T", "I", "O", "N" };

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
            ClassEncryptText CET = new ClassEncryptText(cryptKey);
            encryptedText.fishText = CET.EncryptString(clearText.fishText);
        }

        public void MakeDecryptedText()
        {
            // TODO: Add functionality here
            ClassDecryptText CDT = new ClassDecryptText(cryptKey);
            clearText.fishText = CDT.DecryptString(encryptedText.fishText);

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
