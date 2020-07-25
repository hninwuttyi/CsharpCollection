using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarySnippet
{
    class Program
    {
        static void Main(string[] args)
        {
            Country norway = new Country("Norway", "NOR", "Europe", 5282223);
            Country finland = new Country("Finland", "FIN", "Europe", 5511303);

            var countries = new Dictionary<string, Country>();
            countries.Add(norway.Code, norway);
            countries.Add(finland.Code, finland);

            //Console.WriteLine(countries["MUS"].Name);
            bool exists = countries.TryGetValue("MUS", out Country country);
            if (exists)
                Console.WriteLine(country.Name);
            else
                Console.WriteLine("There is no country with the code MUS.");

        }
    }
}
