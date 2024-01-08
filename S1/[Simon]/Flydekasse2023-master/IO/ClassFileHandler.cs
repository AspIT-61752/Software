using Microsoft.Win32;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace IO
{
    /// <summary>
    /// Denne Class har til formål at håndtere alle former for kommunikation mellem
    /// et program og filer der findes eksternt fra koden.
    /// Der håndteres kommunikation af tekstfiler og binær data baserede filer som f.eks. 
    /// billeder og .exe filer.
    /// </summary>
    public class ClassFileHandler
    {
        // Instanser af encoding med ref. til specifikke tegntabeller
        Encoding enc1252;
        Encoding encUTF8;

        /// <summary>
        /// Default Constructor.
        /// Her initialiseres de to Encoding instanser.
        /// </summary>
        public ClassFileHandler()
        {
            enc1252 = Encoding.GetEncoding("Windows-1252");
            encUTF8 = Encoding.GetEncoding("UTF-8");
        }

        /// <summary>
        /// Denne metode kan læse indholdet af tekstbaseret fil og returnere indholdet
        /// af filen som datatype string.
        /// Metoden skal modtage en string, der indeholder den fulde sti til en given
        /// fil. Det vil sige: Path + Filename med extention.
        /// EKS: C:\CodeMappe\Admiralen.txt
        /// </summary>
        /// <param name="path">string</param>
        /// <returns>string</returns>
        public string ReadTextFromFile(string path)
        {
            // Initialisering af den variabel der skal indeholde teksten fra filen.
            string resText = "";
            // Validering af om der er modtaget en path
            if (path.Trim().Length == 0)
            {
                // Hvis der ikke er modtaget en path
                return $"Der er ikke angivet nogen sti til filen.";
            }

            // Validering af om filen findes på den angivne placering som fremgår af path.
            if (!File.Exists(path))
            {
                // Hvis filen ikke findes, returneres følgende tekst.
                return $"Filen med følgende sti\n\n{path}\n\n blev IKKE fundet.";
            }

            // Der benyttes Try-Catch for at kunne håndtere fejl/exceptions der kan
            // opstå ved kommunikation med eksterne enheder.
            try
            {
                // Der benyttes Using for at gøre håndteringen af resurserne FileStream og
                // StreamReader nemmere og mere sikker. GarbageCollectoren i styresystemet
                // vil håndtere handlingerne med at lukke for resurserne når de længer skal
                // benyttes.

                // FileStream åbner forbindelsen til filen
                using (FileStream fileStream = new FileStream(path, FileMode.Open))
                {
                    // StreamReader giver mulighed for at tilgå indholdet af filen
                    using (StreamReader reader = new StreamReader(fileStream, enc1252))
                    {
                        // reader læser indholdet af filen og skriver det ind i resText.
                        resText = reader.ReadToEnd();
                    }
                }
            }
            // Fanger en evt. Exception.
            catch (IOException ex)
            {
                // Tager den opståede Exception og sender den bagud til den metode der har
                // kaldt denne metode. 
                throw ex;
            }
            // Returnere indholdet af filen.
            return resText;
        }

        public void WriteTextToServerFile_StreamWriter(string text)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text file (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == true)
                {
                    string path = saveFileDialog.FileName;
                    using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        using (StreamWriter writer = new StreamWriter(fileStream, encUTF8))
                        {
                            writer.AutoFlush = true;
                            writer.WriteLine(text);
                        }
                    }
                    Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Denne metode har til formål at skrive tekst til en fil.
        /// Hvis filen findes i forvejen, vil dens indhold blive overskrevet.
        /// Den skal modtage to parameter:
        /// path: En string med den fulde sti til filen (sti og navn).
        /// data: Den tekst der skal skrives i filen.
        /// </summary>
        /// <param name="path">string</param>
        /// <param name="data">string</param>
        public void WriteTextToFile(string path, string data)
        {
            // Der benyttes Try-Catch for at kunne håndtere fejl/exceptions der kan
            // opstå ved kommunikation med eksterne enheder.
            try
            {
                // File.Create vil sikre at filen er oprettet inden der forsøges at skrive til den.
                // Hvis filen findes, sker der ingen ændringer.
                File.Create(path);
                // File.WriteAllText skriver teksten i data til filen der er angivet i path.
                File.WriteAllText(path, data);
            }
            // Fanger en evt. Exception.
            catch (IOException ex)
            {
                // Tager den opståede Exception og sender den bagud til den metode der har
                // kaldt denne metode. 
                throw ex;
            }
        }

        /// <summary>
        /// Denne metode har til formål at skrive tekst til en fil.
        /// Hvis filen findes i forvejen, vil dens indhold blive overskrevet.
        /// Den skal modtage to parameter:
        /// path: En string med den fulde sti til filen (sti og navn).
        /// data: Den tekst der skal skrives i filen.
        /// </summary>
        /// <param name="path">string</param>
        /// <param name="data">string</param>
        public void WriteTextToFile2(string path, string data)
        {
            // Der benyttes Try-Catch for at kunne håndtere fejl/exceptions der kan
            // opstå ved kommunikation med eksterne enheder.
            try
            {
                // Der benyttes Using for at gøre håndteringen af resursen
                // StreamWriter nemmere og mere sikker. GarbageCollectoren i styresystemet
                // vil håndtere handlingerne med at lukke for resurserne når de IKKE længere
                // skal benyttes.

                // En StreamWriter har den egenskab, at man kan angive hvilken tegntabel (Encoding)
                // der skal benyttes og at man kan sikre sig at filen der skal skrives til findes.
                using (StreamWriter writer = new StreamWriter(File.Create(path), enc1252))
                {
                    // Sikrer at datapakker der ikke er helt fulde tilsidst, skrives til filen alligevel.
                    writer.AutoFlush = true;
                    // Skriver data til filen.
                    writer.Write(data);
                }

            }
            // Fanger en evt. Exception.
            catch (IOException ex)
            {
                // Tager den opståede Exception og sender den bagud til den metode der har
                // kaldt denne metode. 
                throw ex;
            }
        }

        public void WriteDataToFile_FileStream(string path, byte[] data)
        {
            try
            {
                using (FileStream writer = File.Create(path))
                {
                    writer.Write(data, 0, data.Length);
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }

        public byte[] ReadDataFromFile_Filestream(string Path)
        {
            List<byte> temp = new List<byte>();
            int c = 0;
            try
            {
                using (FileStream fs = new FileStream(Path, FileMode.Open))
                {
                    while ((c = fs.ReadByte()) != -1)
                    {
                        temp.Add((byte)c);
                    }
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }
            byte[] res = temp.ToArray();
            return res;
        }

        public void AddTextToFile(string path, string text)
        {
            try
            {
                File.AppendAllText(path, text, enc1252);
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }

        public string ReadAllLinesAndReturnOneLine(string path)
        {
            string res = "";

            try
            {
                using (StreamReader reader = new StreamReader(path, enc1252))
                {
                    while (reader.Peek() > -1)
                    {
                        res += reader.ReadLine();
                    }
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }

            return res;
        }

        public List<string> ReadAllLinesAndReturnListString(string path)
        {
            List<string> res = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(path, enc1252))
                {
                    while (reader.Peek() > -1)
                    {
                        res.Add(reader.ReadLine());
                    }
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }

            return res;
        }

        public void WriteArrayToFile(string path, string[] inArray)
        {
            try
            {
                File.WriteAllLines(path, inArray, enc1252);
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }




    }
}
