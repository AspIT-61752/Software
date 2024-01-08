using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassText : ClassNotify
    {
		private string _fishText;

        public ClassText()
        {
            fishText = "Fiskemund";
        }

		public string fishText
		{
			get { return _fishText; }
			set
			{
				if (_fishText != value)
				{
					_fishText = value;
				}
				Notify("fishText");
			}
		}

        public override string ToString()
        {
            return fishText;
        }

	}
}
