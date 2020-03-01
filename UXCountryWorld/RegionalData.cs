using LiveCharts;
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

    public partial class RegionalData : Form
    {
        public RegionalData()
        {
            InitializeComponent();
            using (LocalDBWorldCountryEntities db = new LocalDBWorldCountryEntities())
            {
                var data = db.RegionPopulation();
                ColumnSeries col = new ColumnSeries() { Title = "Population", DataLabels = true, Values = new ChartValues<long>(), LabelPoint = point => point.Y.ToString() };
                Axis ax = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
                ax.Labels = new List<string>();
                foreach (var x in data)
                {
                    col.Values.Add(x.Population.Value);
                    ax.Labels.Add(x.Name.ToString());
                }

                cartesianChart.Series.Add(col);
                cartesianChart.AxisX.Add(ax);
                cartesianChart.AxisY.Add(new Axis
                {
                    LabelFormatter = value => value.ToString(),
                    Separator = new Separator()
                });
            }

            
            using (LocalDBWorldCountryEntities db = new LocalDBWorldCountryEntities())
            {
                
                var data = db.RegionPopulation();
            
                Axis ax = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
                ax.Labels = new List<string>();
                SeriesCollection series = new SeriesCollection();
                foreach (var x in data)
                {
                    PieSeries t = new PieSeries
                    {
                        Title = x.Name.ToString(),
                        Values = new ChartValues<long> { long.Parse(x.Population.ToString()) },
                        DataLabels = true
                    };

                    series.Add(t);
                                                         
                }


                pieChart1.Series = series;

                pieChart1.AxisY.Add(new Axis
                {
                    LabelFormatter = value => value.ToString(),
                    Separator = new Separator()
                });
                pieChart1.LegendLocation = LegendLocation.Bottom;
            }
        }

    }
}
