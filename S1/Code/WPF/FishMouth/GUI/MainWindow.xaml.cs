using Handler;
using System.Windows;
using System.Windows.Controls;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ClassHandler handler;

        public MainWindow()
        {
            InitializeComponent();
            handler = new ClassHandler();
            MainGrid.DataContext = handler;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Menu(btn.Tag.ToString());
        }

        private void Menu(string value)
        {
            switch (value)
            {
                case "Encrypt":
                    handler.MakeEncryptedText();
                    break;
                case "Decrypt":
                    handler.MakeDecryptedText();
                    break;
                case "LoadClearText":
                    handler.ReadClearTextFromFile();
                    break;
                case "SaveClearText":
                    handler.WriteClearTextToFile();
                    break;
                case "LoadEncryptedText":
                    handler.ReadEncryptedTextFromFile();
                    break;
                case "SaveEncryptedText":
                    handler.WriteEncryptedTextToFile();
                    break;
                default:
                    break;
            }
        }
    }
}
