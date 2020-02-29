using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UXCountryWorld
{
    public partial class CountryPC : Form
    {
        public CountryPC()
        {
            InitializeComponent();

            var mapper = Mappers.Xy<Population>()
                .X((population, index) => index)
                .Y(population => population.CountryPopulation);

            var records = PopulationCountryData.Countries.OrderByDescending(x => x.CountryPopulation).Take(5).ToArray();

            Results = records.AsChartValues();
            Labels = records.Select(x => x.Year).ToList();

            cartesianChartCP.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Configuration = mapper,
                    Values = Results
                }
            };

            cartesianChartCP.AxisY.Add(new Axis
            {
                LabelFormatter = value => (value / 1000000).ToString("N") + "M"
            });
            cartesianChartCP.AxisX.Add(new Axis
            {
                Labels = Labels,
                DisableAnimations = true,
                LabelsRotation = 20,
                Separator = new Separator
                {
                    Step = 1
                }
            });
        }

        public ChartValues<Population> Results { get; set; }
        public List<string> Labels { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var a = ((TextBox)sender).Text ?? string.Empty;
            a = a.ToUpper();

            var records = PopulationCountryData.Countries
                .Where(x => x.Year.ToUpper().Contains(a))
                .OrderByDescending(x => x.CountryPopulation)
                .Take(15)
                .ToArray();

            Results.Clear();
            Results.AddRange(records);

            Labels.Clear();
            foreach (var record in records) Labels.Add(record.Year);
        }
    }
}
