using System;

namespace Repository
{
    public class ClassCalckRes : ClassNotify
    {
        private string _strCalckNumber;
        private string _strCalckRes;
        private ClassTextRes _textRes;

        public ClassCalckRes()
        {
            TextRes = new ClassTextRes();
            StrCalckRes = "0";
            StrCalckNumber = "0";
        }

        public string StrCalckRes
        {
            get => _strCalckRes;
            set
            {
                _strCalckRes = value;
                Notify("StrCalckRes");
            }
        }

        public string StrCalckNumber
        {
            get => _strCalckNumber;
            set
            {
                if (_strCalckNumber != value)
                {
                    _strCalckNumber = value;
                    CalckNumber(value);
                }
                Notify("StrCalckNumber");
            }
        }

        public ClassTextRes TextRes
        {
            get => _textRes;
            set
            {
                _textRes = value;
                Notify("textRes");
            }
        }

        private void CalckNumber(string inNumber)
        {
            int number = 0;
            if (inNumber != null)
            {
                number = Convert.ToInt32(inNumber) * 1387;
            }
            TextRes.IsNumberEven(number);
            StrCalckRes = number.ToString();
        }
    }
}