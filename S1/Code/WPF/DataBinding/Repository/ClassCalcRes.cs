using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class ClassCalcRes : ClassNotify
    {
        // Properties for ClassCalcRes
        private string _strValue;
        private string _strCalcRes;
        private ClassTextRes _textRes;

        /// <summary>
        /// Constructor for ClassCalcRes
        /// </summary>
        public ClassCalcRes()
        {
            // Initialize the properties
            textRes = new ClassTextRes();
            strCalcRes = "";
            strValue = "0";
        }

        /// <summary>
        /// Property for ClassTextRes. When textRes is changed, it calls Notify method to update the GUI
        /// </summary>
        public ClassTextRes textRes
        {
            get { return _textRes; }
            set
            {
                if (_textRes != value)
                {
                    _textRes = value;
                }
                Notify("textRes");
            }
        }

        /// <summary>
        /// Property for strCalcRes. When strCalcRes is changed, it calls Notify method to update the GUI
        /// </summary>
        public string strCalcRes
        {
            get { return _strCalcRes; }
            private set
            {
                if (_strCalcRes != value)
                {
                    _strCalcRes = value;
                }
                Notify("strCalcRes");
            }
        }

        /// <summary>
        /// Property for strValue. When strValue is changed, it calls CalculateThisNumber method
        /// </summary>
        public string strValue
        {
            // get: Just returns the value of _strValue
            get { return _strValue; }

            // set: If the value is different from the current value, we assign it and notify. Otherwise we just notify.
            set
            {
                if (_strValue != value)
                {
                    // If the value is empty, we assign it to 0
                    if (value.Trim() == "")
                    {
                        value = "0";
                    }

                    // Try to parse the value to an int. If it succeeds, we assign it to _strValue and call CalculateThisNumber method
                    if (int.TryParse(value, out int X))
                    {

                        // Checks if the value is too big or too small
                        if ((Convert.ToInt32(value) * 1387) >= (int.MaxValue) || (Convert.ToInt32(value) * 1387) < 0)
                        {
                            value = (int.MaxValue / 1387).ToString();
                        }
                        _strValue = value;
                        CalculateThisNumber(X);
                    }
                }
                Notify("strValue");
            }
        }

        /// <summary>
        /// This method calculates the number and sets the result in strCalcRes
        /// </summary>
        /// <param name="inNumber">number to be calculated</param>
        private void CalculateThisNumber(int inNumber)
        {
            int temp = inNumber * 1387;
            strCalcRes = temp.ToString();
            textRes.IsNumberEven(temp);
        }
    }
}
