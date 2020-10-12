using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Management;
using C1.Win.C1Chart;

namespace CpuUsage
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel		panel1;
		private System.Windows.Forms.GroupBox	groupBox1;
		private C1.Win.C1Chart.C1Chart			chartCpuHistory;
		private C1.Win.C1Chart.ChartDataArray	arrHistory;
		private System.Timers.Timer				timer1;
		private int								hits = 200;
		private bool							left2right = false;
		private System.Diagnostics.PerformanceCounter performanceCounter1;
		private System.Windows.Forms.GroupBox	groupBox2;
		private C1.Win.C1Chart.C1Chart			chartCpuUsage;
		private System.Windows.Forms.PictureBox pictureBox1;
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
            timer1.Enabled = true;
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartCpuHistory = new C1.Win.C1Chart.C1Chart();
            this.timer1 = new System.Timers.Timer();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartCpuUsage = new C1.Win.C1Chart.C1Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCpuHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCpuUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 56);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(491, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Visit Web Site";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chartCpuHistory);
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(144, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 248);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU Usage History";
            // 
            // chartCpuHistory
            // 
            this.chartCpuHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCpuHistory.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chartCpuHistory.Location = new System.Drawing.Point(3, 16);
            this.chartCpuHistory.Name = "chartCpuHistory";
            this.chartCpuHistory.PropBag = resources.GetString("chartCpuHistory.PropBag");
            this.chartCpuHistory.Size = new System.Drawing.Size(450, 229);
            this.chartCpuHistory.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.chartCpuUsage);
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(16, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 248);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPU Usage";
            // 
            // chartCpuUsage
            // 
            this.chartCpuUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartCpuUsage.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chartCpuUsage.Location = new System.Drawing.Point(16, 32);
            this.chartCpuUsage.Name = "chartCpuUsage";
            this.chartCpuUsage.PropBag = resources.GetString("chartCpuUsage.PropBag");
            this.chartCpuUsage.Size = new System.Drawing.Size(80, 200);
            this.chartCpuUsage.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(616, 334);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ComponentOne Chart for .NET Demo- CPU Usage";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCpuHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCpuUsage)).EndInit();
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
		/// Set the CPU Usage
		/// </summary>
		/// <param name="lvalue"></param>
		private void SetCpuUsage(float lvalue)
		{
			if (lvalue < 1) lvalue = 1;
			chartCpuUsage.ChartArea.PlotArea.AlarmZones[0].UpperExtent = (int)lvalue; 
			chartCpuUsage.Footer.Text = ((int)lvalue).ToString() + "%";
		}

		/// <summary>
		/// Initialize the Chart in code
		/// </summary>
		private void InitChart()
		{
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;//!!VBPassThru
			groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;//!!VBPassThru
			chartCpuUsage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;//!!VBPassThru
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;//!!VBPassThru

			//--Initalize the Cpu Usage Chart-----------------------------
			chartCpuUsage.BackColor = Color.Black;

			C1.Win.C1Chart.PlotArea pa = chartCpuUsage.ChartArea.PlotArea;
			pa.BackColor = Color.Black;
			pa.BackColor2 = Color.Green;
			pa.HatchStyle = C1.Win.C1Chart.HatchStyleEnum.DarkHorizontal; 

			// Set up the X/Y axis
			C1.Win.C1Chart.Axis xa = chartCpuUsage.ChartArea.AxisX;
			xa.AutoMax = false;
			xa.AutoMin = false;
			xa.AutoMajor = false;
			xa.AutoMinor = false;
			xa.Min = 0;
			xa.Max = 100;
			xa.TickLabels = C1.Win.C1Chart.TickLabelsEnum.None;
			xa.Thickness = 1;
			xa.ForeColor = Color.Black;

			C1.Win.C1Chart.Axis ya = chartCpuUsage.ChartArea.AxisY;
			ya.AutoMax = false;
			ya.AutoMin = false;
			ya.AutoMajor = false;
			ya.AutoMinor = false;
			ya.Min = 0;
			ya.Max = 100;
			ya.TickLabels = C1.Win.C1Chart.TickLabelsEnum.None;
			ya.TickMajor = C1.Win.C1Chart.TickMarksEnum.None;
			ya.TickMinor = C1.Win.C1Chart.TickMarksEnum.None;
			ya.Thickness = 1;
			ya.ForeColor = Color.Black;
			ya.Compass = C1.Win.C1Chart.CompassEnum.East; 

			// Add a alarm zone
			C1.Win.C1Chart.AlarmZone almZone = chartCpuUsage.ChartArea.PlotArea.AlarmZones.AddNewZone(); 
			almZone.BackColor = Color.Transparent;
			almZone.ForeColor = Color.Lime;
			almZone.PatternStyle = System.Drawing.Drawing2D.HatchStyle.DarkHorizontal;
			almZone.PatternVisible = true;
			almZone.LowerExtent = 0;
			almZone.FarExtent = 100;
			almZone.NearExtent = -100;
			almZone.UpperExtent = 0;
			almZone.Visible = true;
 
			// Hide the header and legend
			chartCpuUsage.Header.Visible = false;
			chartCpuUsage.Legend.Visible = false;

			// Set up the footer
			chartCpuUsage.Footer.Style.ForeColor = Color.Lime;
			chartCpuUsage.Footer.Text = "25%";
			chartCpuUsage.Footer.Visible = true;

			// Set up the dummy data
			chartCpuUsage.ChartGroups[0].ChartData.SeriesList.RemoveAll();
			C1.Win.C1Chart.ChartDataSeries series = chartCpuUsage.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
			series.PointData.Length = 1; 
			series.PointData[0] = new PointF(-1, -1);

			//--Initalize the Cpu History Chart-----------------------------
			chartCpuHistory.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;
			C1.Win.C1Chart.Style caStyle = chartCpuHistory.ChartArea.Style;
			caStyle.BackColor = Color.BurlyWood;
			caStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			caStyle.Border.Color = SystemColors.AppWorkspace;
			caStyle.Border.Thickness = 2;

			C1.Win.C1Chart.PlotArea plArea = chartCpuHistory.ChartArea.PlotArea;
			plArea.BackColor = Color.Black;
			plArea.ForeColor = Color.Green;
			plArea.Boxed = true;

			// Set up the X Axis
			xa = chartCpuHistory.ChartArea.AxisX;
			xa.ForeColor = Color.Green;
			xa.Min = 0;
			xa.Max = hits;
			xa.TickMajor = C1.Win.C1Chart.TickMarksEnum.None; 
			xa.TickMinor = C1.Win.C1Chart.TickMarksEnum.None; 
			xa.TickLabels = C1.Win.C1Chart.TickLabelsEnum.None;
			xa.Compass = C1.Win.C1Chart.CompassEnum.North; 
			xa.AutoMax = false;
			xa.AutoMin = false;
			xa.AutoMajor = false;
			xa.AutoMinor = false;
			xa.UnitMinor = 5;
			xa.UnitMajor = 10;
			xa.Thickness = 1;
			xa.GridMajor.AutoSpace = true;
			xa.GridMajor.Color = Color.Green; 
			xa.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
			xa.GridMajor.Visible = true;
			xa.GridMinor.AutoSpace = true;
			xa.GridMinor.Color = Color.Green; 
			xa.GridMinor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
			xa.GridMinor.Visible = true;
			xa.Reversed = !left2right;


			// Set up the Y Axis
			ya = chartCpuHistory.ChartArea.AxisY;
			ya.ForeColor = Color.Green;
			ya.Min = 0;
			ya.Max = 1;
			ya.TickMajor = C1.Win.C1Chart.TickMarksEnum.None; 
			ya.TickMinor = C1.Win.C1Chart.TickMarksEnum.None; 
			ya.AutoMax = false;
			xa.AutoMin = false;
			xa.AutoMajor = false;
			xa.AutoMinor = false;
			ya.UnitMinor = 0.05;
			ya.UnitMajor = 0.1;
			ya.Thickness = 1;
			ya.AnnoFormat = C1.Win.C1Chart.FormatEnum.NumericManual;
			ya.AnnoFormatString = "#0%";
			ya.GridMajor.AutoSpace = true;
			ya.GridMajor.Color = Color.Green; 
			ya.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
			ya.GridMajor.Visible = true;
			ya.GridMinor.AutoSpace = true;
			ya.GridMinor.Color = Color.Green; 
			ya.GridMinor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
			ya.GridMinor.Visible = true;

			// Hide Header and Footer
			chartCpuHistory.Header.Visible = false;
			chartCpuHistory.Footer.Visible = false;

			// Initialize the series
			chartCpuHistory.ChartGroups[0].ChartData.SeriesList.RemoveAll();
			series = chartCpuHistory.ChartGroups[0].ChartData.SeriesList.AddNewSeries(); 
			series.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.None;
			series.LineStyle.Color = Color.LawnGreen;
			arrHistory = series.PointData;
		}

		/// <summary>
		/// Shift the PointData inorder to simulate a right to left plot drawing
		/// </summary>
		/// <param name="arr"></param>
		private void ShiftRight(ChartDataArray arr)
		{
			for(int i = arr.Length - 2; i >= 0; i--)
			{
				PointF p = (PointF)arr[i];
				p.X++;
				arr[i + 1] = p;
			}
		}

		private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			// Stop the timer to prevent re-entrancy
			timer1.Stop();
 
			float lValue = (float)performanceCounter1.NextValue();

			// Set data to the Cpu Usage Chart
			SetCpuUsage(lValue);

			// Set data to the Cpu History Chart
			if (left2right)
			{
				arrHistory.Length++;

				// Reach the max
				if (arrHistory.Length >= hits + 1)
				{
					arrHistory.Length = 0;
					arrHistory.Length++;
				}

				arrHistory[arrHistory.Length - 1] = new PointF(arrHistory.Length - 1, lValue/100);
			}
			else
			{
				if (arrHistory.Length <= hits + 1)
					arrHistory.Length++;

				ShiftRight(arrHistory);
				arrHistory[0] = new PointF(0, lValue/100);
			}

			// Start the timer
			timer1.Start(); 
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.grapecity.com");
		}
	}
}

