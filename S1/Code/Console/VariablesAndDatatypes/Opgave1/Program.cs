using System;

namespace Opgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Info about user (Me)
            string fullName = "Tobias Hansen";
            string address = "Not Writing All That";
            string emailAddress = "61752@edu.campusvejle.dk";
            string directoryLocation = "C:\\Software\\S1\\Code\\Console\\VariablesAndDatatypes\\";

            int age = 21;

            DateTime birthday = new DateTime(2002, 02, 28, 00, 30, 00);

            // Temperature
            int temperatureInF = 44;
            int temperatureInC = 7;

            // Percentages
            float perThousand = 0.03f;
            long hundredPercent = 1;
            double oneTwentyfivePercent = 1.25d;
            decimal twentyfivePercent = 0.25m;

            // For a decimal it's 28-29 digits
            decimal smallestPossibleValueGreaterThan = 0.0000000000000000000000000001m;



            Console.WriteLine($"dirLocation: {directoryLocation}\n\nfullName: {fullName}\naddress: {address}\nemailAddress: {emailAddress}\nage: {age}\nbirthdate: {birthday.ToString()}\n\ntemperature(℉): {temperatureInF}\ntemperature(℃): {temperatureInC}\n\nperThousand: {perThousand}\nhundredPercent: {hundredPercent}\noneTwentyfivePercent: {oneTwentyfivePercent}\ntwentyfivePercent: {twentyfivePercent}\nsmallestPossibleValueGreaterThan: {smallestPossibleValueGreaterThan} (28-29 digits)\n");

            Console.ReadKey();

        }
    }
}
