using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace UXCountryWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            designSubMenu();
        }

        private void designSubMenu()
        {

            panelWorldDataSubMenu.Visible = false;
            panelCountryDataSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {

            if (panelWorldDataSubMenu.Visible == true)
                panelWorldDataSubMenu.Visible = false;
            if (panelCountryDataSubMenu.Visible == true)
                panelCountryDataSubMenu.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openContainers(Form containerForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = containerForm;
            containerForm.TopLevel = false;
            containerForm.FormBorderStyle = FormBorderStyle.None;
            containerForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(containerForm);
            panelContainer.Tag = containerForm;
            containerForm.BringToFront();
            containerForm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void ibtnWorld_Click(object sender, EventArgs e)
        {
            showSubMenu(panelWorldDataSubMenu);
        }

        private void ibtnPopulation_Click(object sender, EventArgs e)
        {
            openContainers(new RegionalData());
            hideSubMenu();
        }

        private void ibtnMap_Click(object sender, EventArgs e)
        {
            openContainers(new Map());
            hideSubMenu();
        }

        private void ibtnCountryData_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCountryDataSubMenu);
        }

        private void ibtnCountryPopulation_Click(object sender, EventArgs e)
        {
            openContainers(new CountryData());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDBWorldCountryDataSet.Earth". При необходимости она может быть перемещена или удалена.
            this.earthTableAdapter.Fill(this.localDBWorldCountryDataSet.Earth);

        }

       

        private void ibtnMap_Click_1(object sender, EventArgs e)
        {
            openContainers(new Map());
            hideSubMenu();
        }

        private void ibtnCountyPC_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openContainers(new CountryPC());
        }
    }
}
