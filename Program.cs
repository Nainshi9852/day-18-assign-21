using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace day_18_assign_21
{
    internal class Program
    {
        static List<string> Fruits = new List<string>()
            {
                "Mango","Banana","Grapes","WaterMelon","Melon","Kiwi","Guava","Cherry","Strawberry","Berry"
            };
        static List<string> Days = new List<string>()
            {
                "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"
            };
        static List<string> Months = new List<string>()
            {
                "Jan","Feb","Mar","Apr","May","June","July","Aug","Sept","Oct","Nov","Dec"
            };
        static Dictionary<string, string> WordsMeaning = new Dictionary<string, string>()
            {
                {"Aesthetic", "Concerned with beauty and the appreciation of beauty." },
                {"Resilient","Able to withstand or recover from difficult conditions" },
                {"Amiable","Friendly and pleasant in manner " },
                {"Innovative","Introducing new ideas or methods."},
                {"Ubiquitous"," Found Everywhere." }
            };
        static void DisplayDays()
        {
            foreach (string day in Days)
            {
                Console.WriteLine(day);
                Thread.Sleep(14000); // Wait for 14 seconds
            }
        }

        static void DisplayMonths()
        {
            Thread.Sleep(5000); // Wait for 5 seconds before starting
            foreach (string month in Months)
            {
                Console.WriteLine(month);
                Thread.Sleep(2000); // Wait for 2 seconds before displaying the next month
            }
        }

        static void DisplayFruits()
        {
            foreach (string fruit in Fruits)
            {
                Console.WriteLine(fruit);
            }
        }

        static void DisplayWordsAndMeanings()
        {
            foreach (var pair in WordsMeaning)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Learning-\n");

            // threads for each function
            Thread daysThread = new Thread(DisplayDays);
            Thread monthsThread = new Thread(DisplayMonths);
            Thread fruitsThread = new Thread(DisplayFruits);
            Thread wordsThread = new Thread(DisplayWordsAndMeanings);

            // Start the threads
            daysThread.Start();
            monthsThread.Start();

            // Join the days and months threads
            daysThread.Join();
            monthsThread.Join();

            // Start the fruits and words threads
            fruitsThread.Start();
            wordsThread.Start();

            // Join the fruits and words threads 
            fruitsThread.Join();
            wordsThread.Join();
            Console.ReadKey();
        }
    }
}
