using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    /// <summary>
    /// Check if a calculation is even or odd
    /// </summary>
    public class ClassTextRes : ClassNotify
    {
        // Private properties for ClassTextRes
        private string _strTextRes;

        /// <summary>
        /// Default constructor for ClassTextRes
        /// </summary>
        public ClassTextRes()
        {
            strTextRes = "0";
        }

        /// <summary>
        /// Property for strTextRes. When strTextRes is changed, it calls the Notify method to updates the GUI
        /// </summary>
        
        ///<summary>
        /// get: Just returns the value of _strTextRes
        /// set: Is private and can only be accessed via local public method
        /// Shall only be set from within the class
        /// This is to ensure that the property can only be set from within the class and only from a method
        /// that validates 
        /// IF value doesn't exist, we assign it and notify. Otherwise we just notify.
        /// </summary>
        public string strTextRes
        {
            get { return _strTextRes; }
            private set
            {
                if (_strTextRes != value)
                {
                    _strTextRes = value;
                }
                Notify("strTextRes");
            }
        }

        /// <summary>
        /// Calculate if the number is even or not and set the result in strTextRes.
        /// If the number is 0, strTextRes is set to a default text msg
        /// </summary>
        /// <param name="inNumber">int - The number being checked if it is even or not</param>
        public void IsNumberEven(int inNumber)
        {
            if (inNumber == 0)
            {
                strTextRes = "Indtast et tal - og du får et resultat!";
            }
            else
            {
                if (inNumber % 2 == 0)
                {
                    strTextRes = $"Tallet {inNumber} er et LIGE tal";
                }
                else
                {
                    strTextRes = $"Tallet {inNumber} er et U-LIGE tal";
                }
            }
        }

    }
}
