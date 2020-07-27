using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAllCountries_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\SolidCad\Learning\PluralSight_Courses\Beginning C# Collections\csharp-collections-beginning\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Country> Countries = reader.ReadAllCountries();
            Console.Write("Enter no. of countries to display> ");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userinput);
            if (!inputIsInt || userinput <= 0)
            {
                Console.WriteLine("You must type in a +ve integer. exiting");
                return;
            }

            int maxToDisplay = userinput;
            //foreach (Country country in Countries)
            for (int i=0; i< Countries.Count; i++)
            {
                if(i>0 && (i%maxToDisplay == 0))
                {
                    Console.WriteLine("Hit return to continue, anything else to quick > ");
                    if (Console.ReadLine() != "")
                        break;
                }

                Country country = Countries[i];
                Console.WriteLine($"{i + 1}    {country.Population}: {country.Name}");
            }
            Console.WriteLine($"{Countries.Count} countries");
        }
    }  
}
