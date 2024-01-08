using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handler
{
    public class ClassDummyText
    {
        private List<string> key;
        private Random rnd;
        private Encoding win1252 = Encoding.GetEncoding("Windows-1252");

        public ClassDummyText(List<string> list)
        {

        }

        public string MakeDummyString()
        {
            return "Dummy text";
        }

        private string MakeDummyChar()
        {
            return "Dummy";
        }

    }
}
