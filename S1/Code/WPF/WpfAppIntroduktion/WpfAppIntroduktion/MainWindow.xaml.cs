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

namespace WpfAppIntroduktion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ classBIZ = new ClassBIZ();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonOpg12_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave12(listBoxRes);
        }

        private void buttonOpg13_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave13(listBoxRes);
        }

        private void buttonOpg14_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave14(listBoxRes);
        }

        private void buttonOpg15_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave15(listBoxRes);
        }

        private void buttonOpg16_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave16(listBoxRes);
        }

        private void buttonOpg17_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave17(listBoxRes);
        }

        private void buttonOpg18_Click(object sender, RoutedEventArgs e)
        {
            listBoxRes.ItemsSource = classBIZ.Delopgave18();
            //listBoxRes.DisplayMemberPath = "";
        }

        private void buttonOpg19_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave19(listBoxRes);
        }

        private void buttonOpg110_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave110();
        }
    }
}
