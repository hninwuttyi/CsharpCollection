﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTenPos
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\SolidCad\Learning\PluralSight_Courses\Beginning C# Collections\csharp-collections-beginning\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            Country[] Countries = reader.ReadFirstNCountries(10);
            
            foreach(Country country in Countries)
            {
                Console.WriteLine($"{country.Population}: {country.Name}");
            }

        }
    }
}
