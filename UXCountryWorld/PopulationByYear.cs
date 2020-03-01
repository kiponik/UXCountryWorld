using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UXCountryWorld
{
    public static class PopulationByYear
    {
        public static void GetCSV(string Name)
        {


            var reader = new StreamReader(File.OpenRead(@"country"+Name+".csv"));

            var read = new List<PopulationOfCountry>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    var values = line.Split(',');

                    read.Add(new PopulationOfCountry
                    {
                        Year = values[0],
                        CountryPopulation = double.Parse(values[1], CultureInfo.InvariantCulture),
                    });
                }
            }

            Countries = read.ToArray();
        }

        public static PopulationOfCountry[] Countries { get; private set; }
    }
}
