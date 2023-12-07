using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace BIZ
{
    public class ClassBIZ
    {
        public ClassBIZ()
        {

        }

        public void Opgave1(ListBox inListBox)
        {

            Random rand = new Random();

            for (int i = 4711; i < 4737; i++)
            {
                inListBox.Items.Add(i.ToString() + " - " + rand.Next(1, 100).ToString());
            }

            inListBox.Items.Add("Opgave 1");
        }

        public void Opgave2(ListBox inListBox)
        {
            // The random object
            Random rand = new Random();

            for (int i = 0; i < 25; i++)
            {
                inListBox.Items.Add(rand.Next(100000, 1000001));
            }
        }

        public void Opgave3(ListBox inListBox)
        {
            // The random object
            Random rand = new Random();

            for (int i = 0; i < 25; i++)
            {
                inListBox.Items.Add(rand.Next(100000, 1000001));
            }
        }

        public void Opgave4(ListBox inListBox)
        {
            // The random object
            Random rand = new Random();

            // Variables
            List<int> list = new List<int>();
            int amount = 25;

            for (int i = 0; i < amount; i++)
            {
                // Adds a random number to the list
                list.Add(rand.Next(100000, 1000001));
            }

            list.Sort();

            for (int i = 0; i < amount; i++)
            {
                inListBox.Items.Add(list[i]);
            }
        }

        public void Opgave5(ListBox inListBox)
        {
            // The random object
            Random rand = new Random();

            // Variables
            List<int> listRand = new List<int>();
            List<int> listSort = new List<int>();
            int amount = 25;

            // Adds random numbers to the lists
            for (int i = 0; i < amount; i++)
            {
                // Adds a random number to the list
                int tempRandomNumber = rand.Next(100000, 1000001);
                listRand.Add(tempRandomNumber);
                listSort.Add(tempRandomNumber);
            }

            // Sorts the list
            listSort.Sort();


            inListBox.Items.Add("Sorted\t | Random\n=============");
            for (int i = 0; i < amount; i++)
            {
                // Adds the sorted and random numbers to the listbox
                inListBox.Items.Add($"{listSort[i]}\t | {listRand[i]}");
            }
        }

        public void Opgave6(ListBox inListBox)
        {
            // The random object
            Random rand = new Random();

            // Variables
            List<int> listAverage = new List<int>();
            int amount = 25;


            for (int i = 0; i < amount; i++)
            {
                // Gets a random number and calculates the average
                int tempRandomNumber = rand.Next(100000, 1000001);

                // Adds a random number to the list
                inListBox.Items.Add($"{tempRandomNumber}");
                listAverage.Add(tempRandomNumber);
            }
            // Spacing
            inListBox.Items.Add($"");

            // Adds the average to the list
            inListBox.Items.Add($"Gennemsnit: {GetAverageValue(listAverage)}");

        }

        public void Opgave7(ListBox inListBox)
        {
            // The random object
            Random rand = new Random();

            // Variables
            int amount = 25;
            int calculatedAverage = 0;

            List<int> listAverage = new List<int>();

            for (int i = 0; i < amount; i++)
            {
                // Gets a random number and adds it to the list
                int tempRandomNumber = rand.Next(100000, 1000001);
                listAverage.Add(tempRandomNumber);
            }

            calculatedAverage = GetAverageValue(listAverage);
            listAverage.Sort();

            foreach (int number in listAverage)
            {
                inListBox.Items.Add($"{number} - {calculatedAverage} = {number - calculatedAverage}");
            }
        }

        public List<string> Opgave8()
        {
            // The random object
            Random rand = new Random();

            // Variables
            int amount = 25;
            int calculatedAverage = 0;

            List<string> listResult = new List<string>();
            List<int> listNumbers = new List<int>();

            for (int i = 0; i < amount; i++)
            {
                int tempRandomNumber = rand.Next(100000, 1000001);
                listNumbers.Add(tempRandomNumber);
            }

            calculatedAverage = GetAverageValue(listNumbers);
            listNumbers.Sort();

            foreach (var number in listNumbers)
            {
                listResult.Add($"{number} - {calculatedAverage} = {number - calculatedAverage}");
            }

            return listResult;
        }

        public void Opgave9(ListBox inListBox)
        {
            // The random object
            Random rand = new Random();

            // Variables
            int amount = 25;
            int calculatedAverage = 0;

            List<int> listNumbers = new List<int>();

            for (int i = 0; i < amount; i++)
            {
                int tempRandomNumber = rand.Next(100000, 1000001);
                listNumbers.Add(tempRandomNumber);
            }

            calculatedAverage = GetAverageValue(listNumbers);
            listNumbers.Sort();

            foreach (var number in listNumbers)
            {
                // Creates a new listbox item
                ListBoxItem listBoxItem = new ListBoxItem();

                // Checks if the number is even or odd
                if ((number % 2) != 0)
                {
                    listBoxItem.Background = System.Windows.Media.Brushes.AliceBlue;
                }
                else
                {
                    listBoxItem.Background = System.Windows.Media.Brushes.HotPink;
                }

                // Sets the content of the listbox item
                listBoxItem.Content = $"{number} - {calculatedAverage} = {number - calculatedAverage}";

                // Adds the item to the listbox
                inListBox.Items.Add(listBoxItem);
            }
        }

        /*public void Opgave10(ListBox inListBox)
        {
            // https://www.blackwasp.co.uk/WPFItemsSource.aspx 
            //MainWindow.listBoxRes.ItemsSource = "A";

            MainWindow mainWindow = new MainWindow();
            //mainWindow.listBoxRes.ItemsSource 

            // Clears the list
            mainWindow.listBoxRes.Items.Clear();

            // The random object
            Random rand = new Random();

            // Variables
            int amount = 25;
            int calculatedAverage = 0;

            List<ListBoxItem> listItems = new List<ListBoxItem>();
            List<int> listNumbers = new List<int>();

            for (int i = 0; i < amount; i++)
            {
                int tempRandomNumber = rand.Next(100000, 1000001);
                listNumbers.Add(tempRandomNumber);
            }

            calculatedAverage = GetAverageValue(listNumbers);
            listNumbers.Sort();

            foreach (var number in listNumbers)
            {
                // Creates a new listbox item
                ListBoxItem listBoxItem = new ListBoxItem();

                // Checks if the number is even or odd
                if ((number % 2) != 0)
                {
                    listBoxItem.Background = System.Windows.Media.Brushes.AliceBlue;
                }
                else
                {
                    listBoxItem.Background = System.Windows.Media.Brushes.HotPink;
                }

                // Sets the content of the listbox item
                listBoxItem.Content = $"{number} - {calculatedAverage} = {number - calculatedAverage}";

                // Adds the item to the listbox
                listItems.Add(listBoxItem);

            }

            mainWindow.listBoxRes.ItemsSource = listItems;
        }*/

        private int GetAverageValue(List<int> listInt)
        {
            int result = 0;
            int count = 0;

            foreach (var number in listInt)
            {
                result += number;
                count++;
            }

            return result /= count;
        }

    }
}
