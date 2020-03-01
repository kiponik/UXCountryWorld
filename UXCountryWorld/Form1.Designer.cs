namespace UXCountryWorld
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label populationLabel;
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelCountryDataSubMenu = new System.Windows.Forms.Panel();
            this.panelWorldDataSubMenu = new System.Windows.Forms.Panel();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelForButtons = new System.Windows.Forms.Panel();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.earthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localDBWorldCountryDataSet = new UXCountryWorld.LocalDBWorldCountryDataSet();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.earthTableAdapter = new UXCountryWorld.LocalDBWorldCountryDataSetTableAdapters.EarthTableAdapter();
            this.tableAdapterManager = new UXCountryWorld.LocalDBWorldCountryDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibtnInfoData = new FontAwesome.Sharp.IconButton();
            this.ibtnCountryPopulation = new FontAwesome.Sharp.IconButton();
            this.ibtnCountryData = new FontAwesome.Sharp.IconButton();
            this.ibtnCountyPC = new FontAwesome.Sharp.IconButton();
            this.ibtnMap = new FontAwesome.Sharp.IconButton();
            this.ibtnPopulation = new FontAwesome.Sharp.IconButton();
            this.ibtnWorld = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelCountryDataSubMenu.SuspendLayout();
            this.panelWorldDataSubMenu.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.panelForButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.earthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBWorldCountryDataSet)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(58, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Location = new System.Drawing.Point(176, 15);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(92, 20);
            populationLabel.TabIndex = 2;
            populationLabel.Text = "Population:";
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panelCountryDataSubMenu);
            this.panelMenu.Controls.Add(this.ibtnCountryData);
            this.panelMenu.Controls.Add(this.panelWorldDataSubMenu);
            this.panelMenu.Controls.Add(this.ibtnWorld);
            this.panelMenu.Controls.Add(this.panelTopLeft);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 556);
            this.panelMenu.TabIndex = 0;
            // 
            // panelCountryDataSubMenu
            // 
            this.panelCountryDataSubMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCountryDataSubMenu.Controls.Add(this.ibtnCountryPopulation);
            this.panelCountryDataSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCountryDataSubMenu.Location = new System.Drawing.Point(0, 311);
            this.panelCountryDataSubMenu.Name = "panelCountryDataSubMenu";
            this.panelCountryDataSubMenu.Size = new System.Drawing.Size(250, 45);
            this.panelCountryDataSubMenu.TabIndex = 9;
            // 
            // panelWorldDataSubMenu
            // 
            this.panelWorldDataSubMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelWorldDataSubMenu.Controls.Add(this.ibtnCountyPC);
            this.panelWorldDataSubMenu.Controls.Add(this.ibtnMap);
            this.panelWorldDataSubMenu.Controls.Add(this.ibtnPopulation);
            this.panelWorldDataSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWorldDataSubMenu.Location = new System.Drawing.Point(0, 133);
            this.panelWorldDataSubMenu.Name = "panelWorldDataSubMenu";
            this.panelWorldDataSubMenu.Size = new System.Drawing.Size(250, 128);
            this.panelWorldDataSubMenu.TabIndex = 7;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.pictureBox2);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(250, 83);
            this.panelTopLeft.TabIndex = 1;
            // 
            // countryBindingSource
            // 
            // 
            // localDBWorldCountryDataSet1
            // 
            // panelForButtons
            // 
            this.panelForButtons.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelForButtons.Controls.Add(populationLabel);
            this.panelForButtons.Controls.Add(this.populationTextBox);
            this.panelForButtons.Controls.Add(nameLabel);
            this.panelForButtons.Controls.Add(this.nameTextBox);
            this.panelForButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelForButtons.Location = new System.Drawing.Point(250, 502);
            this.panelForButtons.Name = "panelForButtons";
            this.panelForButtons.Size = new System.Drawing.Size(903, 54);
            this.panelForButtons.TabIndex = 1;
            // 
            // populationTextBox
            // 
            this.populationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.earthBindingSource, "Population", true));
            this.populationTextBox.Location = new System.Drawing.Point(274, 12);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(100, 26);
            this.populationTextBox.TabIndex = 3;
            // 
            // earthBindingSource
            // 
            this.earthBindingSource.DataMember = "Earth";
            this.earthBindingSource.DataSource = this.localDBWorldCountryDataSet;
            // 
            // localDBWorldCountryDataSet
            // 
            this.localDBWorldCountryDataSet.DataSetName = "LocalDBWorldCountryDataSet";
            this.localDBWorldCountryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.earthBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(70, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 1;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(250, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(903, 502);
            this.panelContainer.TabIndex = 2;
            // 
            // countryTableAdapter
            // 
            // 
            // earthTableAdapter
            // 
            this.earthTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.EarthTableAdapter = this.earthTableAdapter;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UXCountryWorld.LocalDBWorldCountryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ibtnInfoData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 502);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 54);
            this.panel1.TabIndex = 11;
            // 
            // ibtnInfoData
            // 
            this.ibtnInfoData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibtnInfoData.FlatAppearance.BorderSize = 0;
            this.ibtnInfoData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnInfoData.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnInfoData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnInfoData.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ibtnInfoData.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibtnInfoData.IconSize = 30;
            this.ibtnInfoData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnInfoData.Location = new System.Drawing.Point(0, 0);
            this.ibtnInfoData.Name = "ibtnInfoData";
            this.ibtnInfoData.Rotation = 0D;
            this.ibtnInfoData.Size = new System.Drawing.Size(250, 54);
            this.ibtnInfoData.TabIndex = 10;
            this.ibtnInfoData.Text = "Info";
            this.ibtnInfoData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnInfoData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnInfoData.UseVisualStyleBackColor = true;
            // 
            // ibtnCountryPopulation
            // 
            this.ibtnCountryPopulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnCountryPopulation.FlatAppearance.BorderSize = 0;
            this.ibtnCountryPopulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCountryPopulation.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnCountryPopulation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnCountryPopulation.IconChar = FontAwesome.Sharp.IconChar.GlobeAfrica;
            this.ibtnCountryPopulation.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibtnCountryPopulation.IconSize = 32;
            this.ibtnCountryPopulation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCountryPopulation.Location = new System.Drawing.Point(0, 0);
            this.ibtnCountryPopulation.Name = "ibtnCountryPopulation";
            this.ibtnCountryPopulation.Rotation = 0D;
            this.ibtnCountryPopulation.Size = new System.Drawing.Size(250, 41);
            this.ibtnCountryPopulation.TabIndex = 1;
            this.ibtnCountryPopulation.Text = "Population Data";
            this.ibtnCountryPopulation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCountryPopulation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCountryPopulation.UseVisualStyleBackColor = true;
            this.ibtnCountryPopulation.Click += new System.EventHandler(this.ibtnCountryPopulation_Click);
            // 
            // ibtnCountryData
            // 
            this.ibtnCountryData.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnCountryData.FlatAppearance.BorderSize = 0;
            this.ibtnCountryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCountryData.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnCountryData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnCountryData.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ibtnCountryData.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibtnCountryData.IconSize = 30;
            this.ibtnCountryData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCountryData.Location = new System.Drawing.Point(0, 261);
            this.ibtnCountryData.Name = "ibtnCountryData";
            this.ibtnCountryData.Rotation = 0D;
            this.ibtnCountryData.Size = new System.Drawing.Size(250, 50);
            this.ibtnCountryData.TabIndex = 8;
            this.ibtnCountryData.Text = "Country Data";
            this.ibtnCountryData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCountryData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCountryData.UseVisualStyleBackColor = true;
            this.ibtnCountryData.Click += new System.EventHandler(this.ibtnCountryData_Click);
            // 
            // ibtnCountyPC
            // 
            this.ibtnCountyPC.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnCountyPC.FlatAppearance.BorderSize = 0;
            this.ibtnCountyPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCountyPC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnCountyPC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnCountyPC.IconChar = FontAwesome.Sharp.IconChar.Cloud;
            this.ibtnCountyPC.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibtnCountyPC.IconSize = 32;
            this.ibtnCountyPC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCountyPC.Location = new System.Drawing.Point(0, 82);
            this.ibtnCountyPC.Name = "ibtnCountyPC";
            this.ibtnCountyPC.Rotation = 0D;
            this.ibtnCountyPC.Size = new System.Drawing.Size(250, 30);
            this.ibtnCountyPC.TabIndex = 3;
            this.ibtnCountyPC.Text = "Country Population Chart";
            this.ibtnCountyPC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCountyPC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCountyPC.UseVisualStyleBackColor = true;
            this.ibtnCountyPC.Click += new System.EventHandler(this.ibtnCountyPC_Click);
            // 
            // ibtnMap
            // 
            this.ibtnMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnMap.FlatAppearance.BorderSize = 0;
            this.ibtnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMap.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnMap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnMap.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.ibtnMap.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibtnMap.IconSize = 32;
            this.ibtnMap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMap.Location = new System.Drawing.Point(0, 41);
            this.ibtnMap.Name = "ibtnMap";
            this.ibtnMap.Rotation = 0D;
            this.ibtnMap.Size = new System.Drawing.Size(250, 41);
            this.ibtnMap.TabIndex = 2;
            this.ibtnMap.Text = "Map of Population";
            this.ibtnMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnMap.UseVisualStyleBackColor = true;
            this.ibtnMap.Click += new System.EventHandler(this.ibtnMap_Click_1);
            // 
            // ibtnPopulation
            // 
            this.ibtnPopulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnPopulation.FlatAppearance.BorderSize = 0;
            this.ibtnPopulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnPopulation.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnPopulation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnPopulation.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.ibtnPopulation.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibtnPopulation.IconSize = 32;
            this.ibtnPopulation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnPopulation.Location = new System.Drawing.Point(0, 0);
            this.ibtnPopulation.Name = "ibtnPopulation";
            this.ibtnPopulation.Rotation = 0D;
            this.ibtnPopulation.Size = new System.Drawing.Size(250, 41);
            this.ibtnPopulation.TabIndex = 1;
            this.ibtnPopulation.Text = "Population Data";
            this.ibtnPopulation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnPopulation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnPopulation.UseVisualStyleBackColor = true;
            this.ibtnPopulation.Click += new System.EventHandler(this.ibtnPopulation_Click);
            // 
            // ibtnWorld
            // 
            this.ibtnWorld.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnWorld.FlatAppearance.BorderSize = 0;
            this.ibtnWorld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnWorld.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnWorld.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnWorld.IconChar = FontAwesome.Sharp.IconChar.GlobeEurope;
            this.ibtnWorld.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibtnWorld.IconSize = 30;
            this.ibtnWorld.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnWorld.Location = new System.Drawing.Point(0, 83);
            this.ibtnWorld.Name = "ibtnWorld";
            this.ibtnWorld.Rotation = 0D;
            this.ibtnWorld.Size = new System.Drawing.Size(250, 50);
            this.ibtnWorld.TabIndex = 6;
            this.ibtnWorld.Text = "World Data";
            this.ibtnWorld.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnWorld.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnWorld.UseVisualStyleBackColor = true;
            this.ibtnWorld.Click += new System.EventHandler(this.ibtnWorld_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UXCountryWorld.Properties.Resources.czu_cz_cerna_transparentni_900x600x300dpi;
            this.pictureBox2.Location = new System.Drawing.Point(44, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select any button to represent data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 556);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelForButtons);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelCountryDataSubMenu.ResumeLayout(false);
            this.panelWorldDataSubMenu.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.panelForButtons.ResumeLayout(false);
            this.panelForButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.earthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBWorldCountryDataSet)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.Panel panelForButtons;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelWorldDataSubMenu;
        private FontAwesome.Sharp.IconButton ibtnCountyPC;
        private FontAwesome.Sharp.IconButton ibtnMap;
        private FontAwesome.Sharp.IconButton ibtnPopulation;
        private FontAwesome.Sharp.IconButton ibtnWorld;
        private FontAwesome.Sharp.IconButton ibtnInfoData;
        private System.Windows.Forms.Panel panelCountryDataSubMenu;
        private FontAwesome.Sharp.IconButton ibtnCountryPopulation;
        private FontAwesome.Sharp.IconButton ibtnCountryData;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private LocalDBWorldCountryDataSet localDBWorldCountryDataSet;
        private System.Windows.Forms.BindingSource earthBindingSource;
        private LocalDBWorldCountryDataSetTableAdapters.EarthTableAdapter earthTableAdapter;
        private LocalDBWorldCountryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

