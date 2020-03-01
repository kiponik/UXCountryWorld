using CsvHelper;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Separator = LiveCharts.Wpf.Separator;

namespace UXCountryWorld
{
    public partial class CountryData : Form
    {
        static CartesianMapper<PopulationOfCountry> mapper;

        public CountryData()
        {
            InitializeComponent();
            fillComboBox();


            mapper = Mappers.Xy<PopulationOfCountry>()
                .X((population, index) => index)
                .Y(population => population.CountryPopulation);
            PopulationByYear.GetCSV("CZ");

            var records = PopulationByYear.Countries.ToArray();

            Results = records.AsChartValues();
            Labels = records.Select(x => x.Year).ToList();

            cartesianChartCountryPopulation.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Configuration = mapper,
                    Values = Results
                }
            };

            cartesianChartCountryPopulation.AxisY.Add(new Axis
            {
                LabelFormatter = value => (value / 1000000).ToString("N") + "M"
            });
            cartesianChartCountryPopulation.AxisX.Add(new Axis
            {
                Labels = Labels,
                DisableAnimations = true,
                LabelsRotation = 20
            });


        }




        public ChartValues<PopulationOfCountry> Results { get; set; }
        public List<string> Labels { get; set; }

        public void fillComboBox()
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Айдын\source\repos\UXCountryWorld\UXCountryWorld\LocalDBWorldCountry.mdf;Integrated Security=True";

            cnn = new SqlConnection(connectionString);

            string sql = "select * from Country;";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader myreader;

            try
            {
                cnn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string code = myreader.GetString(2);
                    codeComboBox.Items.Add(code);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void codeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Айдын\source\repos\UXCountryWorld\UXCountryWorld\LocalDBWorldCountry.mdf;Integrated Security=True";

            cnn = new SqlConnection(connectionString);


            string sql = "select * from Country where Code = '" + codeComboBox.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader myreader;

            try
            {
                cnn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {

                    string name = myreader.GetString(1);
                    string capital = myreader.GetString(3);
                    string population = myreader.GetInt64(4).ToString();
                    string regionID = myreader.GetInt32(5).ToString();
                    string code = myreader.GetString(2);
                    nameTextBox.Text = name;
                    capitalTextBox.Text = capital;
                    populationTextBox.Text = population;
                    PopulationByYear.GetCSV(code);
                    var records = PopulationByYear.Countries.ToArray();
                    Results = records.AsChartValues();
                    Labels = records.Select(x => x.Year).ToList();

                    cartesianChartCountryPopulation.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Configuration = mapper,
                    Values = Results
                }
            };
                    cartesianChartCountryPopulation.AxisY = new AxesCollection();
                    cartesianChartCountryPopulation.AxisX = new AxesCollection();
                    cartesianChartCountryPopulation.AxisY.Add(new Axis
                    {
                        LabelFormatter = value => (value / 1000000).ToString("N") + "M"
                    });
                    cartesianChartCountryPopulation.AxisX.Add(new Axis
                    {
                        Labels = Labels,
                        DisableAnimations = true,
                        LabelsRotation = 20
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }

}
