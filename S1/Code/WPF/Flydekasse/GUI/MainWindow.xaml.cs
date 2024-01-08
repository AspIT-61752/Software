using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Handler;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ClassHandler _Handler;
        public MainWindow()
        {
            InitializeComponent();
            _Handler = new ClassHandler();
            MainGrid.DataContext = _Handler;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Menu(btn.Tag.ToString());
        }

        private void Menu(string value)
        {
            switch (value)
            {
                // case "test" is a placeholder for testing purposes
                case "test":
                    // Test method goes here
                    break;
                default:
                    break;
            }
        }
    }
}
