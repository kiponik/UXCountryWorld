namespace UXCountryWorld
{
    partial class CountryData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label capitalLabel;
            System.Windows.Forms.Label populationLabel;
            System.Windows.Forms.Label regionIDLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label capitalLabel1;
            System.Windows.Forms.Label populationLabel1;
            System.Windows.Forms.Label codeLabel2;
            this.localDBWorldCountryDataSet = new UXCountryWorld.LocalDBWorldCountryDataSet();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new UXCountryWorld.LocalDBWorldCountryDataSetTableAdapters.CountryTableAdapter();
            this.tableAdapterManager = new UXCountryWorld.LocalDBWorldCountryDataSetTableAdapters.TableAdapterManager();
            this.populationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartesianChartCountryPopulation = new LiveCharts.WinForms.CartesianChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.codeComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.capitalTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            capitalLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            regionIDLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            capitalLabel1 = new System.Windows.Forms.Label();
            populationLabel1 = new System.Windows.Forms.Label();
            codeLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.localDBWorldCountryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(220, 47);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(220, 75);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(220, 103);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(45, 17);
            codeLabel.TabIndex = 5;
            codeLabel.Text = "Code:";
            // 
            // capitalLabel
            // 
            capitalLabel.AutoSize = true;
            capitalLabel.Location = new System.Drawing.Point(220, 131);
            capitalLabel.Name = "capitalLabel";
            capitalLabel.Size = new System.Drawing.Size(55, 17);
            capitalLabel.TabIndex = 7;
            capitalLabel.Text = "Capital:";
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Location = new System.Drawing.Point(220, 159);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(79, 17);
            populationLabel.TabIndex = 9;
            populationLabel.Text = "Population:";
            // 
            // regionIDLabel
            // 
            regionIDLabel.AutoSize = true;
            regionIDLabel.Location = new System.Drawing.Point(220, 187);
            regionIDLabel.Name = "regionIDLabel";
            regionIDLabel.Size = new System.Drawing.Size(74, 17);
            regionIDLabel.TabIndex = 11;
            regionIDLabel.Text = "Region ID:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(61, 103);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(49, 17);
            nameLabel1.TabIndex = 2;
            nameLabel1.Text = "Name:";
            // 
            // capitalLabel1
            // 
            capitalLabel1.AutoSize = true;
            capitalLabel1.Location = new System.Drawing.Point(61, 131);
            capitalLabel1.Name = "capitalLabel1";
            capitalLabel1.Size = new System.Drawing.Size(55, 17);
            capitalLabel1.TabIndex = 6;
            capitalLabel1.Text = "Capital:";
            // 
            // populationLabel1
            // 
            populationLabel1.AutoSize = true;
            populationLabel1.Location = new System.Drawing.Point(61, 159);
            populationLabel1.Name = "populationLabel1";
            populationLabel1.Size = new System.Drawing.Size(79, 17);
            populationLabel1.TabIndex = 8;
            populationLabel1.Text = "Population:";
            // 
            // codeLabel2
            // 
            codeLabel2.AutoSize = true;
            codeLabel2.Location = new System.Drawing.Point(61, 68);
            codeLabel2.Name = "codeLabel2";
            codeLabel2.Size = new System.Drawing.Size(45, 17);
            codeLabel2.TabIndex = 11;
            codeLabel2.Text = "Code:";
            // 
            // localDBWorldCountryDataSet
            // 
            this.localDBWorldCountryDataSet.DataSetName = "LocalDBWorldCountryDataSet";
            this.localDBWorldCountryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.localDBWorldCountryDataSet;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CountryTableAdapter = this.countryTableAdapter;
            this.tableAdapterManager.EarthTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UXCountryWorld.LocalDBWorldCountryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cartesianChartCountryPopulation
            // 
            this.cartesianChartCountryPopulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChartCountryPopulation.Location = new System.Drawing.Point(0, 0);
            this.cartesianChartCountryPopulation.Name = "cartesianChartCountryPopulation";
            this.cartesianChartCountryPopulation.Size = new System.Drawing.Size(947, 428);
            this.cartesianChartCountryPopulation.TabIndex = 17;
            this.cartesianChartCountryPopulation.Text = "cartesianChart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(codeLabel2);
            this.panel1.Controls.Add(this.codeComboBox);
            this.panel1.Controls.Add(nameLabel1);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(capitalLabel1);
            this.panel1.Controls.Add(this.capitalTextBox);
            this.panel1.Controls.Add(populationLabel1);
            this.panel1.Controls.Add(this.populationTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 528);
            this.panel1.TabIndex = 19;
            // 
            // codeComboBox
            // 
            this.codeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "Code", true));
            this.codeComboBox.FormattingEnabled = true;
            this.codeComboBox.Location = new System.Drawing.Point(178, 65);
            this.codeComboBox.Name = "codeComboBox";
            this.codeComboBox.Size = new System.Drawing.Size(121, 24);
            this.codeComboBox.TabIndex = 12;
            this.codeComboBox.SelectedIndexChanged += new System.EventHandler(this.codeComboBox_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(185, 100);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // capitalTextBox
            // 
            this.capitalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "Capital", true));
            this.capitalTextBox.Location = new System.Drawing.Point(185, 128);
            this.capitalTextBox.Name = "capitalTextBox";
            this.capitalTextBox.Size = new System.Drawing.Size(100, 22);
            this.capitalTextBox.TabIndex = 7;
            // 
            // populationTextBox
            // 
            this.populationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "Population", true));
            this.populationTextBox.Location = new System.Drawing.Point(185, 156);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(100, 22);
            this.populationTextBox.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(346, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 100);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cartesianChartCountryPopulation);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(346, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(947, 428);
            this.panel3.TabIndex = 21;
            // 
            // CountryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 528);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(regionIDLabel);
            this.Controls.Add(populationLabel);
            this.Controls.Add(idLabel);
            this.Controls.Add(capitalLabel);
            this.Controls.Add(codeLabel);
            this.Controls.Add(nameLabel);
            this.Name = "CountryData";
            this.Text = "CountryData";
            ((System.ComponentModel.ISupportInitialize)(this.localDBWorldCountryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LocalDBWorldCountryDataSet localDBWorldCountryDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private LocalDBWorldCountryDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private LocalDBWorldCountryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource populationBindingSource;
        private LiveCharts.WinForms.CartesianChart cartesianChartCountryPopulation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox codeComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox capitalTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
    }
}