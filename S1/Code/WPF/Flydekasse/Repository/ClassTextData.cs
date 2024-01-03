using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassTextData : ClassNotify
    {
		private string _strData;

        public ClassTextData()
        {
            _strData = "testStr Data";
        }

        public string strData
		{
			get { return _strData; }
			set
			{
				if (_strData != value)
				{
					_strData = value;
				}
				Notify("strData");
			}
		}

	}
}
