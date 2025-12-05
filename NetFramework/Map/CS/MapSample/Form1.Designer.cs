using C1.Framework;
using C1.Win.Themes;

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
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mapDockingTab = new C1.Win.Command.C1DockingTab();
            this.c1DockingTabPage1 = new C1.Win.Command.C1DockingTabPage();
            this.mapDemo1 = new MapSample.Layers.MapDemo();
            this.c1DockingTabPage2 = new C1.Win.Command.C1DockingTabPage();
            this.mapCities1 = new MapSample.Layers.MapCities();
            this.c1DockingTabPage3 = new C1.Win.Command.C1DockingTabPage();
            this.mapFactories1 = new MapSample.Layers.MapFactories();
            this.c1DockingTabPage4 = new C1.Win.Command.C1DockingTabPage();
            this.mapEarthQuakes1 = new MapSample.Layers.MapEarthQuakes();
            this.c1DockingTabPage5 = new C1.Win.Command.C1DockingTabPage();
            this.mapFlightRoutes1 = new MapSample.Layers.MapFlightRoutes();
            this.c1DockingTabPage6 = new C1.Win.Command.C1DockingTabPage();
            this.mapMarks1 = new MapSample.Layers.MapMarks();
            this.c1DockingTabPage7 = new C1.Win.Command.C1DockingTabPage();
            this.mapKml1 = new MapSample.Layers.MapKml();
            this.c1DockingTabPage8 = new C1.Win.Command.C1DockingTabPage();
            this.mapShape1 = new MapSample.Layers.MapShape();
            this.c1DockingTabPage9 = new C1.Win.Command.C1DockingTabPage();
            this.mapGrid1 = new MapSample.Layers.MapGrid();
            this.c1DockingTabPage10 = new C1.Win.Command.C1DockingTabPage();
            this.mapProjections1 = new MapSample.Layers.MapProjections();
            this.c1DockingTabPage11 = new C1.Win.Command.C1DockingTabPage();
            this.mapAirports = new MapSample.Layers.AirportsControl();
            ((System.ComponentModel.ISupportInitialize)(this.mapDockingTab)).BeginInit();
            this.mapDockingTab.SuspendLayout();
            this.c1DockingTabPage1.SuspendLayout();
            this.c1DockingTabPage2.SuspendLayout();
            this.c1DockingTabPage3.SuspendLayout();
            this.c1DockingTabPage4.SuspendLayout();
            this.c1DockingTabPage5.SuspendLayout();
            this.c1DockingTabPage6.SuspendLayout();
            this.c1DockingTabPage7.SuspendLayout();
            this.c1DockingTabPage8.SuspendLayout();
            this.c1DockingTabPage9.SuspendLayout();
            this.c1DockingTabPage10.SuspendLayout();
            this.c1DockingTabPage11.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapDockingTab
            // 
            this.mapDockingTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapDockingTab.Controls.Add(this.c1DockingTabPage1);
            this.mapDockingTab.Controls.Add(this.c1DockingTabPage2);
            this.mapDockingTab.Controls.Add(this.c1DockingTabPage3);
            this.mapDockingTab.Controls.Add(this.c1DockingTabPage4);
            this.mapDockingTab.Controls.Add(this.c1DockingTabPage5);
            this.mapDockingTab.Controls.Add(this.c1DockingTabPage6);
            this.mapDockingTab.Controls.Add(this.c1DockingTabPage7);
            this.mapDockingTab.Controls.Add(this.c1DockingTabPage8);
            this.mapDockingTab.Controls.Add(this.c1DockingTabPage9);
            this.mapDockingTab.Controls.Add(this.c1DockingTabPage10);
            this.mapDockingTab.Controls.Add(this.c1DockingTabPage11);
            this.mapDockingTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapDockingTab.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapDockingTab.Location = new System.Drawing.Point(0, 0);
            this.mapDockingTab.Margin = new System.Windows.Forms.Padding(0);
            this.mapDockingTab.Name = "mapDockingTab";
            this.mapDockingTab.Padding = new System.Drawing.Point(10, 5);
            this.mapDockingTab.Size = new System.Drawing.Size(1109, 702);
            this.mapDockingTab.TabIndex = 1;
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.Controls.Add(this.mapDemo1);
            this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 33);
            this.c1DockingTabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(1107, 668);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "Demo";
            // 
            // mapDemo1
            // 
            this.mapDemo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapDemo1.Location = new System.Drawing.Point(0, 0);
            this.mapDemo1.Margin = new System.Windows.Forms.Padding(0);
            this.mapDemo1.Name = "mapDemo1";
            this.mapDemo1.Size = new System.Drawing.Size(1107, 668);
            this.mapDemo1.TabIndex = 0;
            // 
            // c1DockingTabPage2
            // 
            this.c1DockingTabPage2.Controls.Add(this.mapCities1);
            this.c1DockingTabPage2.Location = new System.Drawing.Point(1, 33);
            this.c1DockingTabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.c1DockingTabPage2.Name = "c1DockingTabPage2";
            this.c1DockingTabPage2.Size = new System.Drawing.Size(1107, 668);
            this.c1DockingTabPage2.TabIndex = 1;
            this.c1DockingTabPage2.Text = "Cities";
            // 
            // mapCities1
            // 
            this.mapCities1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapCities1.Location = new System.Drawing.Point(0, 0);
            this.mapCities1.Name = "mapCities1";
            this.mapCities1.Size = new System.Drawing.Size(1107, 668);
            this.mapCities1.TabIndex = 0;
            // 
            // c1DockingTabPage3
            // 
            this.c1DockingTabPage3.Controls.Add(this.mapFactories1);
            this.c1DockingTabPage3.Location = new System.Drawing.Point(1, 33);
            this.c1DockingTabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.c1DockingTabPage3.Name = "c1DockingTabPage3";
            this.c1DockingTabPage3.Size = new System.Drawing.Size(1107, 668);
            this.c1DockingTabPage3.TabIndex = 2;
            this.c1DockingTabPage3.Text = "Factories";
            // 
            // mapFactories1
            // 
            this.mapFactories1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapFactories1.Location = new System.Drawing.Point(0, 0);
            this.mapFactories1.Name = "mapFactories1";
            this.mapFactories1.Size = new System.Drawing.Size(1107, 668);
            this.mapFactories1.TabIndex = 0;
            // 
            // c1DockingTabPage4
            // 
            this.c1DockingTabPage4.Controls.Add(this.mapEarthQuakes1);
            this.c1DockingTabPage4.Location = new System.Drawing.Point(1, 33);
            this.c1DockingTabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.c1DockingTabPage4.Name = "c1DockingTabPage4";
            this.c1DockingTabPage4.Size = new System.Drawing.Size(1107, 668);
            this.c1DockingTabPage4.TabIndex = 3;
            this.c1DockingTabPage4.Text = "EarthQuakes";
            // 
            // mapEarthQuakes1
            // 
            this.mapEarthQuakes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapEarthQuakes1.Location = new System.Drawing.Point(0, 0);
            this.mapEarthQuakes1.Name = "mapEarthQuakes1";
            this.mapEarthQuakes1.Size = new System.Drawing.Size(1107, 668);
            this.mapEarthQuakes1.TabIndex = 0;
            // 
            // c1DockingTabPage5
            // 
            this.c1DockingTabPage5.Controls.Add(this.mapFlightRoutes1);
            this.c1DockingTabPage5.Location = new System.Drawing.Point(1, 33);
            this.c1DockingTabPage5.Margin = new System.Windows.Forms.Padding(0);
            this.c1DockingTabPage5.Name = "c1DockingTabPage5";
            this.c1DockingTabPage5.Size = new System.Drawing.Size(1107, 668);
            this.c1DockingTabPage5.TabIndex = 4;
            this.c1DockingTabPage5.Text = "FlightRoutes";
            // 
            // mapFlightRoutes1
            // 
            this.mapFlightRoutes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapFlightRoutes1.Location = new System.Drawing.Point(0, 0);
            this.mapFlightRoutes1.Margin = new System.Windows.Forms.Padding(0);
            this.mapFlightRoutes1.Name = "mapFlightRoutes1";
            this.mapFlightRoutes1.Size = new System.Drawing.Size(1107, 668);
            this.mapFlightRoutes1.TabIndex = 0;
            // 
            // c1DockingTabPage6
            // 
            this.c1DockingTabPage6.Controls.Add(this.mapMarks1);
            this.c1DockingTabPage6.Location = new System.Drawing.Point(1, 33);
            this.c1DockingTabPage6.Margin = new System.Windows.Forms.Padding(0);
            this.c1DockingTabPage6.Name = "c1DockingTabPage6";
            this.c1DockingTabPage6.Size = new System.Drawing.Size(1107, 668);
            this.c1DockingTabPage6.TabIndex = 5;
            this.c1DockingTabPage6.Text = "Marks";
            // 
            // mapMarks1
            // 
            this.mapMarks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapMarks1.Location = new System.Drawing.Point(0, 0);
            this.mapMarks1.Name = "mapMarks1";
            this.mapMarks1.Size = new System.Drawing.Size(1107, 668);
            this.mapMarks1.TabIndex = 0;
            // 
            // c1DockingTabPage7
            // 
            this.c1DockingTabPage7.Controls.Add(this.mapKml1);
            this.c1DockingTabPage7.Location = new System.Drawing.Point(1, 33);
            this.c1DockingTabPage7.Margin = new System.Windows.Forms.Padding(0);
            this.c1DockingTabPage7.Name = "c1DockingTabPage7";
            this.c1DockingTabPage7.Size = new System.Drawing.Size(1107, 668);
            this.c1DockingTabPage7.TabIndex = 6;
            this.c1DockingTabPage7.Text = "KML";
            // 
            // mapKml1
            // 
            this.mapKml1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapKml1.Location = new System.Drawing.Point(0, 0);
            this.mapKml1.Name = "mapKml1";
            this.mapKml1.Size = new System.Drawing.Size(1107, 668);
            this.mapKml1.TabIndex = 0;
            // 
            // c1DockingTabPage8
            // 
            this.c1DockingTabPage8.Controls.Add(this.mapShape1);
            this.c1DockingTabPage8.Location = new System.Drawing.Point(1, 33);
            this.c1DockingTabPage8.Margin = new System.Windows.Forms.Padding(0);
            this.c1DockingTabPage8.Name = "c1DockingTabPage8";
            this.c1DockingTabPage8.Size = new System.Drawing.Size(1107, 668);
            this.c1DockingTabPage8.TabIndex = 7;
            this.c1DockingTabPage8.Text = "ShapeFile";
            // 
            // mapShape1
            // 
            this.mapShape1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapShape1.Location = new System.Drawing.Point(0, 0);
            this.mapShape1.Name = "mapShape1";
            this.mapShape1.Size = new System.Drawing.Size(1107, 668);
            this.mapShape1.TabIndex = 0;
            // 
            // c1DockingTabPage9
            // 
            this.c1DockingTabPage9.Controls.Add(this.mapGrid1);
            this.c1DockingTabPage9.Location = new System.Drawing.Point(1, 33);
            this.c1DockingTabPage9.Name = "c1DockingTabPage9";
            this.c1DockingTabPage9.Size = new System.Drawing.Size(1107, 668);
            this.c1DockingTabPage9.TabIndex = 8;
            this.c1DockingTabPage9.Text = "Grid";
            // 
            // mapGrid1
            // 
            this.mapGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapGrid1.Location = new System.Drawing.Point(0, 0);
            this.mapGrid1.Name = "mapGrid1";
            this.mapGrid1.Size = new System.Drawing.Size(1107, 668);
            this.mapGrid1.TabIndex = 0;
            // 
            // c1DockingTabPage10
            // 
            this.c1DockingTabPage10.Controls.Add(this.mapProjections1);
            this.c1DockingTabPage10.Location = new System.Drawing.Point(1, 33);
            this.c1DockingTabPage10.Margin = new System.Windows.Forms.Padding(0);
            this.c1DockingTabPage10.Name = "c1DockingTabPage10";
            this.c1DockingTabPage10.Size = new System.Drawing.Size(1107, 668);
            this.c1DockingTabPage10.TabIndex = 9;
            this.c1DockingTabPage10.Text = "Projection";
            // 
            // mapProjections1
            // 
            this.mapProjections1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapProjections1.Location = new System.Drawing.Point(0, 0);
            this.mapProjections1.Name = "mapProjections1";
            this.mapProjections1.Size = new System.Drawing.Size(1107, 668);
            this.mapProjections1.TabIndex = 0;
            // 
            // c1DockingTabPage11
            // 
            this.c1DockingTabPage11.Controls.Add(this.mapAirports);
            this.c1DockingTabPage11.Location = new System.Drawing.Point(1, 33);
            this.c1DockingTabPage11.Margin = new System.Windows.Forms.Padding(0);
            this.c1DockingTabPage11.Name = "c1DockingTabPage11";
            this.c1DockingTabPage11.Size = new System.Drawing.Size(1107, 668);
            this.c1DockingTabPage11.TabIndex = 10;
            this.c1DockingTabPage11.Text = "Airports";
            // 
            // mapAirports
            // 
            this.mapAirports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapAirports.Location = new System.Drawing.Point(0, 0);
            this.mapAirports.Name = "mapAirports";
            this.mapAirports.Size = new System.Drawing.Size(1107, 668);
            this.mapAirports.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 702);
            this.Controls.Add(this.mapDockingTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Maps for WinForms";
            ((System.ComponentModel.ISupportInitialize)(this.mapDockingTab)).EndInit();
            this.mapDockingTab.ResumeLayout(false);
            this.c1DockingTabPage1.ResumeLayout(false);
            this.c1DockingTabPage2.ResumeLayout(false);
            this.c1DockingTabPage3.ResumeLayout(false);
            this.c1DockingTabPage4.ResumeLayout(false);
            this.c1DockingTabPage5.ResumeLayout(false);
            this.c1DockingTabPage6.ResumeLayout(false);
            this.c1DockingTabPage7.ResumeLayout(false);
            this.c1DockingTabPage8.ResumeLayout(false);
            this.c1DockingTabPage9.ResumeLayout(false);
            this.c1DockingTabPage10.ResumeLayout(false);
            this.c1DockingTabPage11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Layers.MapDemo mapDemo1;
        private Layers.MapCities mapCities1;
        private Layers.MapFactories mapFactories1;
        private Layers.MapMarks mapMarks1;
        private Layers.MapKml mapKml1;
        private Layers.MapShape mapShape1;
        private Layers.MapGrid mapGrid1;
        private Layers.MapEarthQuakes mapEarthQuakes1;
        private Layers.MapFlightRoutes mapFlightRoutes1;
        private Layers.MapProjections mapProjections1;
        private Layers.AirportsControl mapAirports;
        private System.Windows.Forms.ToolTip toolTip1;
        private C1.Win.Command.C1DockingTab mapDockingTab;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage1;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage2;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage3;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage4;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage5;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage6;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage7;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage8;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage9;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage10;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage11;
    }
}

