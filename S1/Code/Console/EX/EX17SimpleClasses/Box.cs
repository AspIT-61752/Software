using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX17SimpleClasses
{
    internal class Box
    {
        public Box()
        {

        }

        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public int Volume { get; private set; }
        public int Surface { get; private set; }

        public void PrintInfo()
        {
            Console.WriteLine($"\nKassen har følgende mål:" +
                              $"\nHøjde: {Height} cm" +
                              $"\nLængde: {Length} cm" +
                              $"\nBredde: {Width} cm" +
                              $"\nRumfang: {Volume} m3" +
                              $"\nOverfladeareal: {Surface} m2\n");
        }

        // 17.3
        public void CalculateVolume()
        {
            Volume = Convert.ToInt32(Width * Length * Height);
        }

        // 17.4
        public void CalculateSurface()
        {
            // SA = 2lw + 2lh + 2wh
            Surface = Convert.ToInt32(2 * ((Length * Width) + (Length * Height) + (Width * Height)));
        }

    }
}
