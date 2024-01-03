using System;

namespace Repository
{
    public class ClassTextRes : ClassNotify
    {
        public ClassTextRes()
        {
            StrTextRes = "Indtast et heltal - og du får et resultat!";
        }

        private string _strTextRes;

        public string StrTextRes
        {
            get => _strTextRes;
            private set
            {
                _strTextRes = value;
                Notify("StrTextRes");
            }
        }

        public void IsNumberEven(int intNumber)
        {
            StrTextRes = intNumber % 2 == 0 ? "Tallet er lige" : "Tallet er ulige";
        }
    }
}