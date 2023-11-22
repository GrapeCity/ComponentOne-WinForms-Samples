using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Interview
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.CheckBox chbFilled;
		private System.Windows.Forms.CheckBox chbThick;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox chbAntiAlias;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			InitChart();
			SetupChartData();

			chbFilled.Checked = c1Chart1.ChartGroups[0].Radar.Filled;
			chbThick.Checked = c1Chart1.ChartGroups[0].ChartData.SeriesList[0].LineStyle.Thickness > 1;
			chbAntiAlias.Checked = c1Chart1.UseAntiAliasedGraphics;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )//!!VBReplace-Overrides-Overloads Overrides-
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbAntiAlias = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chbThick = new System.Windows.Forms.CheckBox();
            this.chbFilled = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chbAntiAlias);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.chbThick);
            this.panel1.Controls.Add(this.chbFilled);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 64);
            this.panel1.TabIndex = 0;
            // 
            // chbAntiAlias
            // 
            this.chbAntiAlias.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chbAntiAlias.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.chbAntiAlias.Location = new System.Drawing.Point(270, 23);
            this.chbAntiAlias.Name = "chbAntiAlias";
            this.chbAntiAlias.Size = new System.Drawing.Size(72, 24);
            this.chbAntiAlias.TabIndex = 3;
            this.chbAntiAlias.Text = "Anti Alias";
            this.chbAntiAlias.CheckedChanged += new System.EventHandler(this.chbAntiAlias_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // chbThick
            // 
            this.chbThick.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chbThick.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.chbThick.Location = new System.Drawing.Point(358, 23);
            this.chbThick.Name = "chbThick";
            this.chbThick.Size = new System.Drawing.Size(72, 24);
            this.chbThick.TabIndex = 1;
            this.chbThick.Text = "Thicker";
            this.chbThick.CheckedChanged += new System.EventHandler(this.chbThick_CheckedChanged);
            // 
            // chbFilled
            // 
            this.chbFilled.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chbFilled.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.chbFilled.Location = new System.Drawing.Point(438, 23);
            this.chbFilled.Name = "chbFilled";
            this.chbFilled.Size = new System.Drawing.Size(64, 24);
            this.chbFilled.TabIndex = 0;
            this.chbFilled.Text = "Filled";
            this.chbFilled.CheckedChanged += new System.EventHandler(this.chbFilled_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(525, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Visit Web Site";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // c1Chart1
            // 
            this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Chart1.Location = new System.Drawing.Point(0, 64);
            this.c1Chart1.Name = "c1Chart1";
            this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
            this.c1Chart1.Size = new System.Drawing.Size(656, 382);
            this.c1Chart1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(656, 446);
            this.Controls.Add(this.c1Chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ComponentOne Chart for .NET Demo - Interview";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		/// <summary>
		/// Initialize the chart style
		/// </summary>
		private void InitChart()
		{
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;//!!VBPassThru

			c1Chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Radar; 

			c1Chart1.BackColor = Color.White;
 
			// Setup the header and footer
			c1Chart1.Header.Style.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
			c1Chart1.Header.Text = "Employment Candidate Review";
			c1Chart1.Footer.Visible = false;

			// Setup the legend
			c1Chart1.Legend.Compass = C1.Win.C1Chart.CompassEnum.South;
			c1Chart1.Legend.Orientation = C1.Win.C1Chart.LegendOrientationEnum.Horizontal;
			c1Chart1.Legend.Visible = true;

			// Setup the Axis X
			C1.Win.C1Chart.Axis ax = c1Chart1.ChartArea.AxisX;
			ax.Font = new Font("Arial", 8);
			ax.Thickness = 2;
			ax.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.ValueLabels; 
			ax.GridMajor.Color = Color.DarkGray;
			ax.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
			ax.GridMajor.Thickness = 2;
			ax.GridMajor.Visible = true;

			// Setup the value labels
			C1.Win.C1Chart.ValueLabel vlbl = ax.ValueLabels.AddNewLabel();
			vlbl.NumericValue = 1;
			vlbl.Text = "Experience";

			vlbl = ax.ValueLabels.AddNewLabel();
			vlbl.NumericValue = 2;
			vlbl.Text = "Education";

			vlbl = ax.ValueLabels.AddNewLabel();
			vlbl.NumericValue = 3;
			vlbl.Text = "Communication";

			vlbl = ax.ValueLabels.AddNewLabel();
			vlbl.NumericValue = 4;
			vlbl.Text = "Friendliness";

			vlbl = ax.ValueLabels.AddNewLabel();
			vlbl.NumericValue = 5;
			vlbl.Text = "Presentation";

			vlbl = ax.ValueLabels.AddNewLabel();
			vlbl.NumericValue = 6;
			vlbl.Text = "Expression"; 

			// Setup the Axis Y
			C1.Win.C1Chart.Axis ay = c1Chart1.ChartArea.AxisY;
			ay.Min = 0;
			ay.Max = 5;
			ay.UnitMinor = 0;
			ay.UnitMajor = 1;
			ay.Compass = C1.Win.C1Chart.CompassEnum.North;

			c1Chart1.UseAntiAliasedGraphics = true;
		}


		/// <summary>
		/// Setup the chart data
		/// </summary>
		private void SetupChartData()
		{
			c1Chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Radar; 
			C1.Win.C1Chart.ChartDataSeriesCollection series = c1Chart1.ChartGroups[0].ChartData.SeriesList;
			series.RemoveAll();

			// Fill the X array
			int[] x = (int[])Array.CreateInstance( typeof(int), 6);
			for(int i = 0; i < x.Length; i++)
			{
				x[i] = i + 1;
			}

			// Add one series
			C1.Win.C1Chart.ChartDataSeries s = series.AddNewSeries();
			s.LineStyle.Color = Color.SeaGreen;
			s.LineStyle.Thickness = 2;
			s.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
			s.SymbolStyle.Color = Color.FromArgb(90, Color.Lime);
			s.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Tri;
			s.SymbolStyle.Size = 8;
			s.Label = "Michael Johnson";
			s.Display = C1.Win.C1Chart.SeriesDisplayEnum.Show;

			int[] y = new int[]{5, 3, 4, 5, 4, 2};
			s.X.CopyDataIn(x); 
			s.Y.CopyDataIn(y); 

			// Add one series
			s = series.AddNewSeries();
			s.LineStyle.Color = Color.Navy;
			s.LineStyle.Thickness = 2;
			s.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
			s.SymbolStyle.Color = Color.FromArgb(90, Color.CornflowerBlue);
			s.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
			s.SymbolStyle.Size = 8;
			s.Label = "Jim Hubbard";
			s.Display = C1.Win.C1Chart.SeriesDisplayEnum.Show;

			y = new int[]{3, 5, 3, 4, 3, 4};
			s.X.CopyDataIn(x); 
			s.Y.CopyDataIn(y); 

			// Add one series
			s = series.AddNewSeries();
			s.LineStyle.Color = Color.Chocolate;
			s.LineStyle.Thickness = 2;
			s.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.Dot;
			s.SymbolStyle.Color = Color.FromArgb(90, Color.Orange);
			s.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Diamond;
			s.SymbolStyle.Size = 8;
			s.Label = "Larry Richardson";
			s.Display = C1.Win.C1Chart.SeriesDisplayEnum.Show;

			y = new int[]{5, 3, 2, 3, 4, 4};
			s.X.CopyDataIn(x); 
			s.Y.CopyDataIn(y); 
		}

		private void chbFilled_CheckedChanged(object sender, System.EventArgs e)
		{
			c1Chart1.ChartGroups[0].Radar.Filled = chbFilled.Checked;

			foreach( C1.Win.C1Chart.ChartDataSeries s in c1Chart1.ChartGroups[0].ChartData.SeriesList)
			{
				if(chbFilled.Checked)
					s.LineStyle.Color = Color.FromArgb( 90, s.LineStyle.Color);
				else
					s.LineStyle.Color = Color.FromArgb( 255, s.LineStyle.Color);
			}
		}

		private void chbThick_CheckedChanged(object sender, System.EventArgs e)
		{
			foreach( C1.Win.C1Chart.ChartDataSeries s in c1Chart1.ChartGroups[0].ChartData.SeriesList)
			{
				if( chbThick.Checked)
				{
					s.LineStyle.Thickness = 2;
					s.SymbolStyle.Size = 8;
				}
				else
				{
					s.LineStyle.Thickness = 1;
					s.SymbolStyle.Size = 5;
				}
			}
		}

		private void chbAntiAlias_CheckedChanged(object sender, System.EventArgs e)
		{
			c1Chart1.UseAntiAliasedGraphics = chbAntiAlias.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("https://developer.mescius.com");
		}
	}
}
