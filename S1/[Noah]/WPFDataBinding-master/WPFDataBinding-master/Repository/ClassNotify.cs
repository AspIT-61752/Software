using System.ComponentModel; // INotifyPropertyChanged

namespace Repository
{
    public class ClassNotify
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ClassNotify()
        {
        }

        protected void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}