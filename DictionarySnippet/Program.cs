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
        }
    }
}
