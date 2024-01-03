using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class ClassIO
    {
        private string _path;

        public ClassIO()
        {
            _path = "";
        }

        public ClassIO(string inPath)
        {
            _path = inPath;
        }

        public string ReadAllTextFromFile()
        {
            string res = "";

            try
            {
                using (FileStream fileStream = new FileStream(_path, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        res = reader.ReadToEnd();
                    }
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }

            return res;
        }
    }
}
