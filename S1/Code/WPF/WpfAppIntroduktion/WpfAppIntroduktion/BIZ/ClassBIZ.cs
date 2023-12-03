using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppIntroduktion
{
    internal class ClassBIZ
    {
        public ClassBIZ()
        {

        }

        public void Delopgave12(ListBox listBox)
        {
            //Du skal nu lave noget kode, der gør det muligt at tilføje tallene fra 4711 til 4736 til den ListBox du har placeret på brugergrænsefladen, det kan løses ved at anvende iteration (loop).
            //Det betyder at du med fordel kan anvende enten for-loop eller while-loop.
            //Når du skal tilføje noget til en ListBox, gøres det på følgende måde:
            //listBox.Items.Add(i.ToString());
            //Når du har skrevet din kode der indsætter talrækken i listBoxRes, skal du lave et kald fra EventHandleren til din metode i ClassBIZ. Det gøres på følgende måde:
            //I EventHandleren der knytter sig til knappen for denne delopgave, skal du skrive følgende:
            //classBIZ.Delopgave12(listBoxRes);
            //•	classBIZ den instans der er lavet af ClassBIZ
            //•	Delopgave12 er navnet på den metode der skal benyttes i classBIZ
            //•	I parentesen angives den parameter der skal sendes med til metoden
            //o	listBoxRes er navnet på den ListBox du har placeret på MainWindow. Når man sender en parameter med til en metode, er det altid som en reference, altså ikke en ny kopi men en afspejling af det oprindelige objekt. Det har den fordel, at når du manipulerer med den modtagne parameter (spejlingen), vil det straks påvirke det oprindelige objektet der ligger til grund for ”spejlingen”, i det her tilfælde ListBoxen med navnet listBoxRes.
            //Test om programmet virker efter hensigten.

            // Clears the list
            listBox.Items.Clear();

            // Variables
            int startNumber = 4711;
            int endNumber = 4736;

            // I went with a for loop
            for (int i = startNumber; i <= endNumber; i++)
            {
                listBox.Items.Add(i.ToString());
            }

        }

        public void Delopgave13(ListBox listBox)
        {
            // Clears the list
            listBox.Items.Clear();

            // The random object
            Random rand = new Random();

            for (int i = 0; i < 25; i++)
            {
                listBox.Items.Add(rand.Next(100000, 1000001));
            }
        }

        public void Delopgave14(ListBox listBox)
        {
            // Clears the list
            listBox.Items.Clear();

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
                listBox.Items.Add(list[i]);
            }
        }

        public void Delopgave15(ListBox listBox)
        {
            // Clears the list
            listBox.Items.Clear();

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


            listBox.Items.Add("Sorted\t | Random\n=============");
            for (int i = 0; i < amount; i++)
            {
                // Adds the sorted and random numbers to the listbox
                listBox.Items.Add($"{listSort[i]}\t | {listRand[i]}");
            }
        }

        public void Delopgave16(ListBox listBox)
        {
            // Clears the list
            listBox.Items.Clear();

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
                listBox.Items.Add($"{tempRandomNumber}");
                listAverage.Add(tempRandomNumber);
            }
                // Spacing
                listBox.Items.Add($"");

                // Adds the average to the list
                listBox.Items.Add($"Gennemsnit: {GetAverageValue(listAverage)}");
        }

        public void Delopgave17(ListBox listBox)
        {
            // Clears the list
            listBox.Items.Clear();

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
                listBox.Items.Add($"{number} - {calculatedAverage} = {number - calculatedAverage}");
            }
        }

        public List<string> Delopgave18()
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

        public void Delopgave19(ListBox listBox)
        {
            // The assignment:
            // Same as before, but back to listboxitems
            // If the number is even, the background is hotpink
            // If the number is odd, the background is aliceblue

            // Clears the list
            ClearList(listBox);

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
                listBox.Items.Add(listBoxItem);
            }
        }

        public void Delopgave110()
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
        }


        // Private methods

        // Returns the average value (Used in Delopgave16)
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

        private void ClearList(ListBox listBox)
        {
            if (listBox.ItemsSource != null)
            {
                listBox.ItemsSource = null;
            }
            listBox.Items.Clear();
        }

        //public void Delopgave15(ListBox listBox)
        //{
        //    // Clears the list
        //    listBox.Items.Clear();

        //    // The random object
        //    Random rand = new Random();

        //    // Variables
        //    List<int> list = new List<int>();
        //    int amount = 25;

        //    for (int i = 0; i < amount; i++)
        //    {
        //        // Adds a random number to the list
        //        list.Add(rand.Next(100000, 1000001));
        //    }

        //    list.Sort();
        //    list.Reverse();

        //    for (int i = 0; i < amount; i++)
        //    {
        //        listBox.Items.Add(list[i]);
        //    }
        //}
    }
}
