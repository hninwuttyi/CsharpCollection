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

            List<Country> Countries = reader.ReadAllCountries();
            Country liliput = new Country("Liliput","LIL","somewhere",2000000);
            int liliputIndex = Countries.FindIndex(x => x.Population < 2000000);
            Countries.Insert(liliputIndex, liliput);
            Countries.RemoveAt(liliputIndex);

            foreach (Country country in Countries.Where(x => !x.Name.Contains(',')).Take(20))
            {
                Console.WriteLine($"{country.Population}: {country.Name}");
            }
            
            for(int i=12; i<=14; i++)
            {
                Console.WriteLine(Countries[i].Name);
            }
        }
    }
}
