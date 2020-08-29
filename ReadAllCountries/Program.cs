using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAllCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\SolidCad\Learning\PluralSight_Courses\Beginning C# Collections\csharp-collections-beginning\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

           Dictionary<string,List<Country>> Countries = reader.ReadAllCountries();

            foreach (string region in Countries.Keys)
                Console.WriteLine(region);

            Console.Write("Which of the above region do you want? ");
            string chosenregion = Console.ReadLine();

            if(Countries.ContainsKey(chosenregion))
            {
                foreach (Country country in Countries[chosenregion].Take(10))
                    Console.WriteLine($"{country.Population}:{country.Name}");
            }
            else
            {
                Console.WriteLine("That is not a valid region.");
            }
        }
    }
}
