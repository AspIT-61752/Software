using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class ClassBIZ
    {
        /// <summary>
        /// Constructor for ClassBIZ
        /// </summary>
        public ClassBIZ()
        {
            // Sets the property calcRes to a new instance of ClassCalcRes
            calcRes = new ClassCalcRes();
        }

        /// <summary>
        /// Property for ClassCalcRes
        /// </summary>
        public ClassCalcRes calcRes { get; set; }
    }

}
