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

        public CountryData()
        {
            InitializeComponent();
            fillComboBox();


            var mapper = Mappers.Xy<PopulationOfCountry>()
                .X((population, index) => index)
                .Y(population => population.CountryPopulation);

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






        private void btnWrite_Click(object sender, EventArgs e)
        {
                
                    /*using (var sw = new StreamWriter(sfd.FileName))
                    {
                        var writer = new CsvWriter(sw, System.Globalization.CultureInfo.InvariantCulture);
                        writer.WriteHeader(typeof(Population));
                        foreach (Population s in populationBindingSource.DataSource as List<Population>)
                        {
                            writer.WriteRecord(s);
                        }
                    }
                    MessageBox.Show("Your data saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                

            try
            {
                string readFile = File.ReadAllText(@"C:\Users\Айдын\Desktop\test.csv");
                string[] line = readFile.Split('\n');
                int count = 0;
                foreach (string str in line[0].Split(','))
                {
                    count++;
                }
                /*DGVData.ColumnCount = count;
                foreach (string s1 in readFile.Split('\n'))
                {
                    if (s1 != "")
                        DGVData.Rows.Add(s1.Split(','));
                }*/

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

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
                    nameTextBox.Text = name;
                    capitalTextBox.Text = capital;
                    populationTextBox.Text = population;
                    regionIDTextBox.Text = regionID;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void codeLabel2_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel1_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void capitalLabel1_Click(object sender, EventArgs e)
        {

        }

        private void capitalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void populationLabel1_Click(object sender, EventArgs e)
        {

        }

        private void populationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void regionIDLabel1_Click(object sender, EventArgs e)
        {

        }

        private void regionIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
