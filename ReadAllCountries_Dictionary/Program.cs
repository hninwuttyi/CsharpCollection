using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAllCountries_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\SolidCad\Learning\PluralSight_Courses\Beginning C# Collections\csharp-collections-beginning\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            Dictionary<string,Country> Countries = reader.ReadAllCountries();
            Console.WriteLine("Which country do you want look up?");
            string userInput = Console.ReadLine();

            bool gotCountry = Countries.TryGetValue(userInput, out Country country);
            if (!gotCountry)
                Console.WriteLine($"Sorry, there is no country with the code, {userInput}");
            else
                Console.WriteLine($"{country.Name} has population {country.Population}.");
        }
    }
}
