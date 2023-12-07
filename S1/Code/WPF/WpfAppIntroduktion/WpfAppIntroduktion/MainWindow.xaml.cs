using BIZ;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppIntroduktion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ BIZ;
        public MainWindow()
        {
            InitializeComponent();
            BIZ = new ClassBIZ();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button myButton = (Button)sender;
            //MessageBox.Show(myButton.Content.ToString() + " - " + myButton.Tag.ToString());
            Menu(int.Parse(myButton.Tag.ToString()));
        }

        private void Menu(int inKey)
        {
            // Clear the listbox
            ClearListBox();

            // TODO: fix all of this... Later...
            switch (inKey)
            {
                case 1:
                    BIZ.Opgave1(listBoxRes);
                    break;
                case 2:
                    BIZ.Opgave2(listBoxRes);
                    break;
                case 3:
                    BIZ.Opgave3(listBoxRes);
                    break;
                case 4:
                    BIZ.Opgave4(listBoxRes);
                    break;
                case 5:
                    BIZ.Opgave5(listBoxRes);
                    break;
                case 6:
                    BIZ.Opgave6(listBoxRes);
                    break;
                case 7:
                    BIZ.Opgave7(listBoxRes);
                    break;
                case 8:
                    listBoxRes.ItemsSource = BIZ.Opgave8();
                    break;
                case 9:
                    BIZ.Opgave9(listBoxRes);
                    break;
                default:
                    MessageBox.Show("No such key");
                    break;
            }
        }

        private void ClearListBox()
        {
            if (listBoxRes.ItemsSource != null)
            {
                listBoxRes.ItemsSource = null;
            }

            listBoxRes.Items.Clear();
        }

        private void buttonOpg12_Click(object sender, RoutedEventArgs e)
        {
            //classBIZ.Delopgave12(listBoxRes);
        }

        private void buttonOpg13_Click(object sender, RoutedEventArgs e)
        {
            //classBIZ.Delopgave13(listBoxRes);
        }

        private void buttonOpg14_Click(object sender, RoutedEventArgs e)
        {
            //classBIZ.Delopgave14(listBoxRes);
        }

        private void buttonOpg15_Click(object sender, RoutedEventArgs e)
        {
            //classBIZ.Delopgave15(listBoxRes);
        }

        private void buttonOpg16_Click(object sender, RoutedEventArgs e)
        {
            //classBIZ.Delopgave16(listBoxRes);
        }

        private void buttonOpg17_Click(object sender, RoutedEventArgs e)
        {
            //classBIZ.Delopgave17(listBoxRes);
        }

        private void buttonOpg18_Click(object sender, RoutedEventArgs e)
        {
            // Crashes if you use any of the other buttons first, and then press this one.
            // Or if you press this one first and then press any other button.
            // It might be because of the way the data is being added to the listbox.
            // (This method returns a list of strings)
            // ¯\_(ツ)_/¯

            //
            //listBoxRes.ItemsSource = classBIZ.Delopgave18();
        }

        private void buttonOpg19_Click(object sender, RoutedEventArgs e)
        {
            //classBIZ.Delopgave19(listBoxRes);
        }

        private void buttonOpg110_Click(object sender, RoutedEventArgs e)
        {
            //classBIZ.Delopgave110();
        }
    }
}
