using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handler
{
    public class ClassHandler
    {
        // Resources:
        // https://wpf-tutorial.com/data-binding/the-stringformat-property/ 

        public ClassHandler()
        {
            ClassBox boxData = new ClassBox();

            boxData.boxHeight = 10;
            boxData.boxLength = 10;
            boxData.boxWidth = 10;

            boxData.boxWeight = 1000;
            boxData.boxVolume = 1000;
            boxData.boxBuoyancy = 1000;

            boxData.matDim = 1;

        }
        
        public ClassBox BoxData { get; set; }
    }

}
