namespace MapSample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tcMaps = new System.Windows.Forms.TabControl();
            this.tabDemo = new System.Windows.Forms.TabPage();
            this.mapDemo1 = new MapSample.Layers.MapDemo();
            this.tabCities = new System.Windows.Forms.TabPage();
            this.mapCities1 = new MapSample.Layers.MapCities();
            this.tabFactories = new System.Windows.Forms.TabPage();
            this.mapFactories1 = new MapSample.Layers.MapFactories();
            this.tabEarthQuakes = new System.Windows.Forms.TabPage();
            this.mapEarthQuakes1 = new MapSample.Layers.MapEarthQuakes();
            this.tabFlightRoutes = new System.Windows.Forms.TabPage();
            this.mapFlightRoutes1 = new MapSample.Layers.MapFlightRoutes();
            this.tabMarks = new System.Windows.Forms.TabPage();
            this.mapMarks1 = new MapSample.Layers.MapMarks();
            this.tabKml = new System.Windows.Forms.TabPage();
            this.mapKml1 = new MapSample.Layers.MapKml();
            this.tabShape = new System.Windows.Forms.TabPage();
            this.mapShape1 = new MapSample.Layers.MapShape();
            this.tabGrid = new System.Windows.Forms.TabPage();
            this.mapGrid1 = new MapSample.Layers.MapGrid();
            this.tabProjection = new System.Windows.Forms.TabPage();
            this.mapProjections1 = new MapSample.Layers.MapProjections();
            this.tabAirports = new System.Windows.Forms.TabPage();
            this.mapAirports = new Layers.AirportsControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcMaps.SuspendLayout();
            this.tabDemo.SuspendLayout();
            this.tabCities.SuspendLayout();
            this.tabFactories.SuspendLayout();
            this.tabEarthQuakes.SuspendLayout();
            this.tabFlightRoutes.SuspendLayout();
            this.tabMarks.SuspendLayout();
            this.tabKml.SuspendLayout();
            this.tabShape.SuspendLayout();
            this.tabGrid.SuspendLayout();
            this.tabProjection.SuspendLayout();
            this.tabAirports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMaps
            // 
            this.tcMaps.Controls.Add(this.tabDemo);
            this.tcMaps.Controls.Add(this.tabCities);
            this.tcMaps.Controls.Add(this.tabFactories);
            this.tcMaps.Controls.Add(this.tabEarthQuakes);
            this.tcMaps.Controls.Add(this.tabFlightRoutes);
            this.tcMaps.Controls.Add(this.tabMarks);
            this.tcMaps.Controls.Add(this.tabKml);
            this.tcMaps.Controls.Add(this.tabShape);
            this.tcMaps.Controls.Add(this.tabGrid);
            this.tcMaps.Controls.Add(this.tabProjection);
            this.tcMaps.Controls.Add(this.tabAirports);
            this.tcMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMaps.Location = new System.Drawing.Point(0, 0);
            this.tcMaps.Name = "tcMaps";
            this.tcMaps.SelectedIndex = 0;
            this.tcMaps.Size = new System.Drawing.Size(784, 561);
            this.tcMaps.TabIndex = 0;
            // 
            // tabDemo
            // 
            this.tabDemo.Controls.Add(this.mapDemo1);
            this.tabDemo.Location = new System.Drawing.Point(4, 22);
            this.tabDemo.Name = "tabDemo";
            this.tabDemo.Padding = new System.Windows.Forms.Padding(3);
            this.tabDemo.Size = new System.Drawing.Size(776, 535);
            this.tabDemo.TabIndex = 0;
            this.tabDemo.Text = "Demo";
            this.tabDemo.UseVisualStyleBackColor = true;
            // 
            // mapDemo1
            // 
            this.mapDemo1.BackColor = System.Drawing.Color.Transparent;
            this.mapDemo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapDemo1.Location = new System.Drawing.Point(3, 3);
            this.mapDemo1.Name = "mapDemo1";
            this.mapDemo1.Size = new System.Drawing.Size(770, 529);
            this.mapDemo1.TabIndex = 0;
            // 
            // tabCities
            // 
            this.tabCities.Controls.Add(this.mapCities1);
            this.tabCities.Location = new System.Drawing.Point(4, 22);
            this.tabCities.Name = "tabCities";
            this.tabCities.Padding = new System.Windows.Forms.Padding(3);
            this.tabCities.Size = new System.Drawing.Size(776, 178);
            this.tabCities.TabIndex = 1;
            this.tabCities.Text = "Cities";
            this.tabCities.UseVisualStyleBackColor = true;
            // 
            // mapCities1
            // 
            this.mapCities1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapCities1.Location = new System.Drawing.Point(3, 3);
            this.mapCities1.Name = "mapCities1";
            this.mapCities1.Size = new System.Drawing.Size(770, 172);
            this.mapCities1.TabIndex = 0;
            // 
            // tabFactories
            // 
            this.tabFactories.Controls.Add(this.mapFactories1);
            this.tabFactories.Location = new System.Drawing.Point(4, 22);
            this.tabFactories.Name = "tabFactories";
            this.tabFactories.Padding = new System.Windows.Forms.Padding(3);
            this.tabFactories.Size = new System.Drawing.Size(776, 178);
            this.tabFactories.TabIndex = 2;
            this.tabFactories.Text = "Factories";
            this.tabFactories.UseVisualStyleBackColor = true;
            // 
            // mapFactories1
            // 
            this.mapFactories1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapFactories1.Location = new System.Drawing.Point(3, 3);
            this.mapFactories1.Name = "mapFactories1";
            this.mapFactories1.Size = new System.Drawing.Size(770, 172);
            this.mapFactories1.TabIndex = 0;
            // 
            // tabEarthQuakes
            // 
            this.tabEarthQuakes.Controls.Add(this.mapEarthQuakes1);
            this.tabEarthQuakes.Location = new System.Drawing.Point(4, 22);
            this.tabEarthQuakes.Name = "tabEarthQuakes";
            this.tabEarthQuakes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEarthQuakes.Size = new System.Drawing.Size(776, 178);
            this.tabEarthQuakes.TabIndex = 8;
            this.tabEarthQuakes.Text = "EarthQuakes";
            this.tabEarthQuakes.UseVisualStyleBackColor = true;
            // 
            // mapEarthQuakes1
            // 
            this.mapEarthQuakes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapEarthQuakes1.Location = new System.Drawing.Point(3, 3);
            this.mapEarthQuakes1.Name = "mapEarthQuakes1";
            this.mapEarthQuakes1.Size = new System.Drawing.Size(770, 172);
            this.mapEarthQuakes1.TabIndex = 0;
            // 
            // tabFlightRoutes
            // 
            this.tabFlightRoutes.Controls.Add(this.mapFlightRoutes1);
            this.tabFlightRoutes.Location = new System.Drawing.Point(4, 22);
            this.tabFlightRoutes.Name = "tabFlightRoutes";
            this.tabFlightRoutes.Size = new System.Drawing.Size(776, 178);
            this.tabFlightRoutes.TabIndex = 9;
            this.tabFlightRoutes.Text = "FlightRoutes";
            this.tabFlightRoutes.UseVisualStyleBackColor = true;
            // 
            // mapFlightRoutes1
            // 
            this.mapFlightRoutes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapFlightRoutes1.Location = new System.Drawing.Point(0, 0);
            this.mapFlightRoutes1.Name = "mapFlightRoutes1";
            this.mapFlightRoutes1.Size = new System.Drawing.Size(776, 178);
            this.mapFlightRoutes1.TabIndex = 0;
            // 
            // tabMarks
            // 
            this.tabMarks.Controls.Add(this.mapMarks1);
            this.tabMarks.Location = new System.Drawing.Point(4, 22);
            this.tabMarks.Name = "tabMarks";
            this.tabMarks.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarks.Size = new System.Drawing.Size(776, 178);
            this.tabMarks.TabIndex = 3;
            this.tabMarks.Text = "Marks";
            this.tabMarks.UseVisualStyleBackColor = true;
            // 
            // mapMarks1
            // 
            this.mapMarks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapMarks1.Location = new System.Drawing.Point(3, 3);
            this.mapMarks1.Name = "mapMarks1";
            this.mapMarks1.Size = new System.Drawing.Size(770, 172);
            this.mapMarks1.TabIndex = 0;
            // 
            // tabKml
            // 
            this.tabKml.Controls.Add(this.mapKml1);
            this.tabKml.Location = new System.Drawing.Point(4, 22);
            this.tabKml.Name = "tabKml";
            this.tabKml.Padding = new System.Windows.Forms.Padding(3);
            this.tabKml.Size = new System.Drawing.Size(776, 178);
            this.tabKml.TabIndex = 4;
            this.tabKml.Text = "KML";
            this.tabKml.UseVisualStyleBackColor = true;
            // 
            // mapKml1
            // 
            this.mapKml1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapKml1.Location = new System.Drawing.Point(3, 3);
            this.mapKml1.Name = "mapKml1";
            this.mapKml1.Size = new System.Drawing.Size(770, 172);
            this.mapKml1.TabIndex = 0;
            // 
            // tabShape
            // 
            this.tabShape.Controls.Add(this.mapShape1);
            this.tabShape.Location = new System.Drawing.Point(4, 22);
            this.tabShape.Name = "tabShape";
            this.tabShape.Padding = new System.Windows.Forms.Padding(3);
            this.tabShape.Size = new System.Drawing.Size(776, 178);
            this.tabShape.TabIndex = 7;
            this.tabShape.Text = "ShapeFile";
            this.tabShape.UseVisualStyleBackColor = true;
            // 
            // mapShape1
            // 
            this.mapShape1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapShape1.Location = new System.Drawing.Point(3, 3);
            this.mapShape1.Name = "mapShape1";
            this.mapShape1.Size = new System.Drawing.Size(770, 172);
            this.mapShape1.TabIndex = 0;
            // 
            // tabGrid
            // 
            this.tabGrid.Controls.Add(this.mapGrid1);
            this.tabGrid.Location = new System.Drawing.Point(4, 22);
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrid.Size = new System.Drawing.Size(776, 178);
            this.tabGrid.TabIndex = 6;
            this.tabGrid.Text = "Grid";
            this.tabGrid.UseVisualStyleBackColor = true;
            // 
            // mapGrid1
            // 
            this.mapGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapGrid1.Location = new System.Drawing.Point(3, 3);
            this.mapGrid1.Name = "mapGrid1";
            this.mapGrid1.Size = new System.Drawing.Size(770, 172);
            this.mapGrid1.TabIndex = 0;
            // 
            // tabProjection
            // 
            this.tabProjection.Controls.Add(this.mapProjections1);
            this.tabProjection.Location = new System.Drawing.Point(4, 22);
            this.tabProjection.Name = "tabProjection";
            this.tabProjection.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjection.Size = new System.Drawing.Size(776, 178);
            this.tabProjection.TabIndex = 10;
            this.tabProjection.Text = "Projection";
            this.tabProjection.UseVisualStyleBackColor = true;
            // 
            // mapProjections1
            // 
            this.mapProjections1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapProjections1.Location = new System.Drawing.Point(3, 3);
            this.mapProjections1.Name = "mapProjections1";
            this.mapProjections1.Size = new System.Drawing.Size(770, 172);
            this.mapProjections1.TabIndex = 0;
            // 
            // tabAirports
            // 
            this.tabAirports.Controls.Add(this.mapAirports);
            this.tabAirports.Location = new System.Drawing.Point(4, 22);
            this.tabAirports.Name = "tabAirports";
            this.tabAirports.Padding = new System.Windows.Forms.Padding(3);
            this.tabAirports.Size = new System.Drawing.Size(776, 178);
            this.tabAirports.TabIndex = 11;
            this.tabAirports.Text = "Airports";
            this.tabAirports.UseVisualStyleBackColor = true;
            // 
            // mapAirports
            // 
            this.mapAirports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapAirports.Location = new System.Drawing.Point(3, 3);
            this.mapAirports.Name = "mapAirports";
            this.mapAirports.Size = new System.Drawing.Size(770, 172);
            this.mapAirports.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(256, 67);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(620, 526);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 76);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tcMaps);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Maps for WinForms";
            this.tcMaps.ResumeLayout(false);
            this.tabDemo.ResumeLayout(false);
            this.tabCities.ResumeLayout(false);
            this.tabFactories.ResumeLayout(false);
            this.tabEarthQuakes.ResumeLayout(false);
            this.tabFlightRoutes.ResumeLayout(false);
            this.tabMarks.ResumeLayout(false);
            this.tabKml.ResumeLayout(false);
            this.tabShape.ResumeLayout(false);
            this.tabGrid.ResumeLayout(false);
            this.tabProjection.ResumeLayout(false);
            this.tabAirports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMaps;
        private System.Windows.Forms.TabPage tabDemo;
        private System.Windows.Forms.TabPage tabCities;
        private System.Windows.Forms.TabPage tabFactories;
        private System.Windows.Forms.TabPage tabMarks;
        private System.Windows.Forms.TabPage tabKml;
        private System.Windows.Forms.TabPage tabGrid;
        private System.Windows.Forms.TabPage tabShape;
        private Layers.MapDemo mapDemo1;
        private Layers.MapCities mapCities1;
        private Layers.MapFactories mapFactories1;
        private Layers.MapMarks mapMarks1;
        private Layers.MapKml mapKml1;
        private Layers.MapShape mapShape1;
        private Layers.MapGrid mapGrid1;
        private System.Windows.Forms.TabPage tabEarthQuakes;
        private Layers.MapEarthQuakes mapEarthQuakes1;
        private System.Windows.Forms.TabPage tabFlightRoutes;
        private Layers.MapFlightRoutes mapFlightRoutes1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabProjection;
        private Layers.MapProjections mapProjections1;
        private System.Windows.Forms.TabPage tabAirports;
        private Layers.AirportsControl mapAirports;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

