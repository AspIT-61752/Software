using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Menu(btn.Tag.ToString());
        }

        private void Menu(string value)
        {
            switch (value)
            {
                case "1":
                    rightTextBox.Text = $"The TextBox on the left has {_Handler.CountAllLines(leftTextBox).ToString()} lines.";
                    break;
                case "2":
                    rightTextBox.Text = $"The TextBox on the left has {_Handler.CountAllChars(leftTextBox).ToString()} characters.";
                    break;
                case "3":
                    rightTextBox.Text = $"The TextBox on the left has {_Handler.CountAllVowels(leftTextBox).ToString()} vowels.";
                    break;
                case "4":
                    _Handler.RemoveAllVowels(leftTextBox);
                    break;
                case "5":
                    _Handler.SearchForWord(leftTextBox, filterTextBox.Text.ToString());
                    break;
                case "6":
                    _Handler.CountLengthOfWords(leftTextBox);
                    break;
                case "7":
                    _Handler.WordFrequencyCounter(leftTextBox, filterTextBox.Text.ToString());
                    break;
                case "8":
                    _Handler.RemoveLastLetterIfWordIsLongerThanThreeCharacters(leftTextBox);
                    break;
                case "test":
                    _Handler.test();
                    break;
                default:                    
                    break;
            }
        }







        /*
*
   1. Understanding the Concept: Data binding is essentially the connection between a UI element (like a textbox, label, or list) and an underlying data source (like a variable, a database record, or an object). The binding ensures that changes in the data source are automatically reflected in the UI element and vice versa.

   2. Types of Data Binding:
  One-Way Binding: The UI element gets updated when the data source changes, but not the other way around.
  Two-Way Binding: Any change in the UI element updates the data source, and any change in the data source updates the UI element.
  One-Way-To-Source: Changes in the UI element update the data source, but the UI element does not automatically update if the data source changes.
  One-Time: The data from the source is loaded once and does not update if the data source changes.

   3. Setting Up Data Binding in C#:
  Define Data Source: This could be a simple variable, a complex object, a collection, or a database connection.
  Bind to UI Element: Use properties like BindingSource, DataContext, or specific binding properties on UI controls to bind the data source to the UI element. In XAML-based applications (like WPF), this is often done declaratively in XAML. In Windows Forms, it's usually done in code.
  Specify Binding Mode: Choose between one-way, two-way, etc., depending on the desired behavior.

   4. Implementing INotifyPropertyChanged (for Two-Way Binding): If you want changes in your data model to automatically update the UI and vice versa, implement the INotifyPropertyChanged interface in your data model. This interface has an event called PropertyChanged that you raise whenever a property's value changes.

   5. Data Context: This is the object that your UI binds to. In XAML-based applications, setting the DataContext property to your data model allows all binding operations within that context to interact with your data model.

   6. Converters (Optional): Sometimes, you need to convert data from one format to another for display (e.g., a boolean to a visibility state). Converters can be written and applied in the binding to handle such cases.

   7. Binding Expressions: These are the expressions set on UI elements that define the property to bind to, the source of the binding, the path to the property in the data source, and other options like converters and binding mode.

   8. Validation (Optional): You can implement validation logic to validate data before it's committed to the data source. This can be done by implementing data annotations or custom validation rules.

   9. Event Handling: In more complex scenarios, you might need to handle events for changes in the data source or UI to perform additional logic.

   NOTE: This framework facilitates the creation of responsive and interactive applications where the UI automatically updates to reflect changes in the underlying data, and user inputs can be directly reflected in the application's data model.
*/
    }
}
