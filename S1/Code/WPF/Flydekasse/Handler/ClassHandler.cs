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
        int testCount = 0;

        public ClassHandler()
        {
            //materialThickness = new ClassTextData();
            //materialThickness.strData = "matThickness";

            //materialList = new ClassTextData();
            //materialList.strData = "matList";

            //heightInput = new ClassTextData();
            ////heightInput.strData = "matHeight";
            //heightInput.strData = "10";

            //widthInput = new ClassTextData();
            ////widthInput.strData = "matWidth";
            //widthInput.strData = "10";

            //lengthInput = new ClassTextData();
            ////lengthInput.strData = "matLength";
            //lengthInput.strData = "10";

            //resultVolume = new ClassTextData();
            ////resultVolume.strData = "matVolume";
            //resultVolume.strData = (Convert.ToDouble(heightInput.strData) * Convert.ToDouble(widthInput.strData) * Convert.ToDouble(lengthInput.strData)).ToString();

            //resultBuoyancy = new ClassTextData();
            //resultBuoyancy.strData = "matBuoyancy";

            ClassBox boxData = new ClassBox();

            boxData.boxHeight = 10;
            boxData.boxLength = 10;
            boxData.boxWidth = 10;

            boxData.boxWeight = 1000;
            boxData.boxVolume = 1000;
            boxData.boxBuoyancy = 1000;

            boxData.matDim = 1;

        }

        //public ClassTextData materialThickness { get; set; }
        //public ClassTextData materialList { get; set; }
        //public ClassTextData heightInput { get; set; }
        //public ClassTextData widthInput { get; set; }
        //public ClassTextData lengthInput { get; set; }
        //public ClassTextData resultVolume { get; set; }
        //public ClassTextData resultBuoyancy { get; set; }
        
        public ClassBox BoxData { get; set; }

        public void Test()
        {
            //materialThickness.strData = $"Button has been pressed {testCount} times";
            testCount++;
        }
    }

}
