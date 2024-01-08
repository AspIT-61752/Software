using BIZ;
using System.Windows;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ BIZ = new ClassBIZ();
        public MainWindow()
        {
            InitializeComponent();
            BIZ = new ClassBIZ();
            MainGrid.DataContext = BIZ;
        }

        private void ButtonPrintBoxReport_Click(object sender, RoutedEventArgs e)
        {
            //BIZ.GenerateReport();
        }
    }
}
