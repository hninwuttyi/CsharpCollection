using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            string monday = "Monday";

            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine("Which day do you want to display?");
            Console.Write("(Monday=1, etc. ) >");
            int iday = int.Parse(Console.ReadLine());
            string chosenDay = daysOfWeek[iday];
            Console.WriteLine($"That day is {chosenDay}");
        }
    }
}
