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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap g = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> d = new Dictionary<string, double>();

            d["CZ"] = 1000;
            d["KZ"] = 100;
            d["FR"] = 50;
            d["RU"] = 80;
            d["UZ"] = 60;
            d["JP"] = 60;
            d["DE"] = 60;
            d["AE"] = 60;
            d["US"] = 50;
            d["CA"] = 30;
            d["NZ"] = 26;
            d["IN"] = 50;
            d["CN"] = 50;
            d["GL"] = 50;


            g.HeatMap = d;
            g.Source = $"{Application.StartupPath}\\map.xml";
            this.Controls.Add(g);
            g.Dock = DockStyle.Fill;
        }
    }
}
