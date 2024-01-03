using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassNotify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ClassNotify()
        {
            
        }

        /// <summary>
        /// Method to notify the GUI that a property has changed
        /// </summary>
        /// <param name="strPropertyName">Name of the property</param>
        protected void Notify(string strPropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(strPropertyName));
        }

    }
}
