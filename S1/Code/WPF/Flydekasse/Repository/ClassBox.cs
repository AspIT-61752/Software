using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassBox : ClassNotify
    {
        private double _boxHeight;
		private double _boxLength;
		private double _boxWidth;
		private double _boxVolume;
        private double _boxBuoyancy;
        private double _boxWeight;
		private int _matDim;

        public ClassBox()
        {
            _boxHeight = 0;
			_boxLength = 0;
			_boxWidth = 0;
			_boxVolume = 0;
            _boxBuoyancy = 0;
            _boxWeight = 0;
			_matDim = 0;
        }
		
		public int matDim
		{
			get { return _matDim; }
			set
			{
				if (_matDim != value)
				{
					_matDim = value;
                    if (double.TryParse(value.ToString(), out double x))
                    {
                        CalculateAll();
                    }
                }
				Notify("matDim");
			}
		}

		public double boxWeight
		{
			get { return _boxWeight; }
			set
			{
				if (_boxWeight != value)
				{
					_boxWeight = value;
                    if (double.TryParse(value.ToString(), out double x))
                    {
                        CalculateAll();
                    }
				}
				Notify("boxWeight");
			}
		}

		public double boxBuoyancy
		{
			get { return _boxBuoyancy; }
			set
			{
				if (_boxBuoyancy != value)
				{
					_boxBuoyancy = value;
                }
				Notify("boxBuoyancy");
			}
		}

		public double boxVolume
		{
			get { return _boxVolume; }
			set
			{
				if (_boxVolume != value)
				{
					_boxVolume = value;
                }
				Notify("boxVolume");
			}
		}

		public double boxWidth
		{
			get { return _boxWidth; }
			set
			{
				if (_boxWidth != value)
				{
					_boxWidth = value;
                    if (double.TryParse(value.ToString(), out double x))
                    {
                        CalculateAll();
                    }
                }
				Notify("boxWidth");
			}
		}

		public double boxLength
		{
			get { return _boxLength; }
			set
			{
				if (_boxLength != value)
				{
					_boxLength = value;
                    if (double.TryParse(value.ToString(), out double x))
                    {
                        CalculateAll();
                    }
                }
				Notify("boxLength");
			}
		}

		public double boxHeight
		{
			get { return _boxHeight; }
			set
			{
				if (_boxHeight != value)
				{
					_boxHeight = value;
                    if (double.TryParse(value.ToString(), out double x))
                    {
                        CalculateAll();
                    }
                }
				Notify("boxHeight");
			}
		}

        private void CalculateAll()
        {
			// TODO: Add calculation logic here.
            //boxVolume = boxHeight * boxLength * boxWidth;
            //boxBuoyancy = boxVolume * 0.000578;
            //boxWeight = boxVolume * matDim;
        }

	}
}
