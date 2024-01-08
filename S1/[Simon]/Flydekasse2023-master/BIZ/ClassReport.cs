using IO;
using Repository;

namespace BIZ
{
    internal class ClassReport
    {
        private ClassBIZ _biz;
        private ClassFileHandler _io;
        private ClassBox box;

        public ClassReport(ClassBIZ inBIZ)
        {
            box = inBIZ.box;
            _biz = inBIZ;
            _io = new ClassFileHandler();
        }

        public void GenerateReport()
        {

            ClassFileHandler fileHandler = new ClassFileHandler();

            string text = "BOX REPORT\n\n";

            text += "Box Material: " + box.boxMaterial.materialName + "\n";
            text += "Box Material Dimensions: " + box.materialDim.ToString().PadLeft(5) + "mm.\n\n";

            text += "Box Height: " + box.boxHeight.ToString().PadLeft(8) + "cm.\n";
            text += "Box Width: " + box.boxWide.ToString().PadLeft(8) + "cm.\n";
            text += "Box Depth: " + box.boxDepth.ToString().PadLeft(8) + "cm.\n\n";

            text += "Box Volume: " + box.boxVolume.ToString().PadLeft(15) + "m3.\n";
            text += "Box Buoyancy: " + box.boxBuoyancy.ToString().PadLeft(15) + "kg.\n";
            text += "Box Weight: " + box.boxWeight.ToString().PadLeft(15) + "kg.\n";
            text += "Box Inner Volume: " + box.boxInnerVolumen.ToString().PadLeft(10) + "m3.\n\n";

            fileHandler.WriteTextToServerFile_StreamWriter(text);

        }
    }
}
