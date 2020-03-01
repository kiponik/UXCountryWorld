using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace UXCountryWorld
{
    class PopulationCountryData
    {
        static PopulationCountryData()
        {
            
            var reader = new StreamReader(File.OpenRead(@"countries.csv"));

            var read = new List<Population>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    var values = line.Split(',');

                    read.Add(new Population
                    {
                        Name = values[0],
                        CountryPopulation = double.Parse(values[1], CultureInfo.InvariantCulture),
                    });
                }
            }

            Countries = read.ToArray();
        }

        public static Population[] Countries { get; private set; }
    }
}
