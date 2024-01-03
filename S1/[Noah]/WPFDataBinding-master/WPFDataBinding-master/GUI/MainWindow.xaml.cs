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
using BIZ;

namespace WPFDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBiz _biz;

        public MainWindow()
        {
            InitializeComponent();
            _biz = new ClassBiz();
            MainGrid.DataContext = _biz;
        }

        private void textBoxNewNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Ensure _biz and _biz.CalckRes are not null
            if (_biz?.CalckRes != null)
            {
                // Check if the TextBox has a valid integer
                if (int.TryParse(textBoxNewNumber.Text, out int number))
                {
                    // Update the StrCalckNumber property of CalckRes in ClassBiz
                    _biz.CalckRes.StrCalckNumber = number.ToString();
                }
                else
                {
                    // Handle invalid input, such as clearing the calculation result
                    _biz.CalckRes.StrCalckNumber = "0"; // Resetting to default if invalid input
                }
            }
        }
    }
}
