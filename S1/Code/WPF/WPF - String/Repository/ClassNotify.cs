using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel; // This adds INotifyPropertyChanged and gives me access to PropertyChanged. 

namespace Repository
{
    public class ClassNotify : INotifyPropertyChanged // Remember to add the interface INotifyPropertyChanged. It'll save you a lot of time.
    {
        public event PropertyChangedEventHandler PropertyChanged; // This is the event that will be raised when a property is changed.
        
        public ClassNotify()
        {
            
        }
        
        protected void Notify(string propertyName)
        {
            // https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.propertychangedeventhandler?view=net-8.0 
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and- 
            // Check if a delegate (for example PropertyChangedEventHandler) is non-null and invoke it in a thread-safe way
            if (PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
