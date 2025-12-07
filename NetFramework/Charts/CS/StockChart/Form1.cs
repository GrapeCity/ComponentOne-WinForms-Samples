using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

namespace Financial_Chart
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.RichTextBox rtData;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private C1.Win.C1Chart.ChartDataSeries series0 = null;
		private C1.Win.C1Chart.ChartDataSeries series1 = null;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.rtData = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.pictureBox1,
																				 this.rtData,
																				 this.button1});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(720, 56);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(225, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// rtData
			// 
			this.rtData.Location = new System.Drawing.Point(344, 0);
			this.rtData.Name = "rtData";
			this.rtData.Size = new System.Drawing.Size(64, 56);
			this.rtData.TabIndex = 0;
			this.rtData.Text = "1801.4 1801.6 1750.0 1752.6 -2.99 6901204 844034:1750.8 1762.1 1718.8 1724.0 -1.6" +
				"3 6674749 814130:1725.8 1740.9 1715.0 1720.6 -0.20 5996402 714792:1722.6 1726.7 " +
				"1695.5 1704.5 -0.93 5420442 664286:1706.7 1725.9 1706.7 1724.5 1.17 4240450 5311" +
				"43:1727.4 1736.2 1722.7 1725.4 0.05 4295444 538189:1725.6 1758.5 1719.8 1758.5 1" +
				".92 6252500 788788:1761.7 1777.9 1754.8 1777.8 1.10 8022075 1018936:1785.8 1830." +
				"9 1783.3 1824.7 2.64 12098580 1528680:1834.4 1836.9 1811.5 1832.0 0.40 10716970 " +
				"1257275:1835.5 1861.4 1831.8 1855.4 1.28 12945020 1627705:1866.5 1880.7 1860.7 1" +
				"880.7 1.36 14519880 1834988:1885.7 1890.6 1860.9 1879.6 -0.06 14806500 1830609:1" +
				"885.5 1900.6 1882.7 1898.7 1.02 15136910 1885531:1875.4 1894.5 1869.3 1894.5 0.9" +
				"1 13546340 1624459:1900.5 1906.8 1890.0 1903.4 0.47 13107330 1542696:1906.1 1916" +
				".2 1897.7 1916.2 0.67 15672360 1750029:1921.9 1930.3 1889.8 1899.0 -0.90 1989578" +
				"0 2149344:1898.5 1925.5 1891.6 1925.5 1.39 13867430 1620457:1934.3 1940.2 1921.3" +
				" 1935.0 0.49 13294190 1584244:1926.1 1929.9 1896.0 1900.7 -1.27 12760600 1443610" +
				":1904.3 1915.5 1876.7 1889.3 -1.27 9160600 1443610:1887.4 1887.4 1854.9 1860.4 -" +
				"1.27 7760600 1443610:1866.7 1866.7 1801.5 1806.7 -1.27 5060600 1443610:1808.9 18" +
				"12.6 1798.8 1799.3 -1.27 5760600 1443610:1801.4 1809.6 1792.4 1808.7 -1.27 70606" +
				"00 1443610:1809.6 1822.1 1804.3 1818.7 -1.27 9760600 1443610:1809.6 1822.1 1804." +
				"3 1811.7 -1.27 11760600 1443610:1810.5 1828.3 1810.5 1819.8 -1.27 12760600 14436" +
				"10:1820.3 1843.6 1817.2 1843.6 -1.27 13760600 1443610:1840.1 1898.9 1838.7 1888." +
				"8 -1.27 13960600 1443610";
			this.rtData.Visible = false;
			// 
			// button1
			// 
			this.button1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.button1.ForeColor = System.Drawing.Color.Lime;
			this.button1.Location = new System.Drawing.Point(576, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "Visit Web Site";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// c1Chart1
			// 
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Location = new System.Drawing.Point(0, 56);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><Header Compass=\"North\"><Text /><" +
				"/Header><StyleCollection><NamedStyle><Name>PlotArea</Name><ParentName>Area</Pare" +
				"ntName><StyleData>Border=None,Control,1;</StyleData></NamedStyle><NamedStyle><Na" +
				"me>Legend</Name><ParentName>Legend.default</ParentName><StyleData /></NamedStyle" +
				"><NamedStyle><Name>Footer</Name><ParentName>Control</ParentName><StyleData>Borde" +
				"r=None,Control,1;</StyleData></NamedStyle><NamedStyle><Name>Area</Name><ParentNa" +
				"me>Area.default</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Control<" +
				"/Name><ParentName>Control.default</ParentName><StyleData /></NamedStyle><NamedSt" +
				"yle><Name>AxisX</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate0;B" +
				"order=None,Control,1;AlignHorz=Center;BackColor=Transparent;Opaque=False;AlignVe" +
				"rt=Bottom;</StyleData></NamedStyle><NamedStyle><Name>AxisY</Name><ParentName>Are" +
				"a</ParentName><StyleData>Rotation=Rotate270;Border=None,Control,1;AlignHorz=Near" +
				";BackColor=Transparent;Opaque=False;AlignVert=Center;</StyleData></NamedStyle><N" +
				"amedStyle><Name>LabelStyleDefault</Name><ParentName>LabelStyleDefault.default</P" +
				"arentName><StyleData /></NamedStyle><NamedStyle><Name>Legend.default</Name><Pare" +
				"ntName>Control</ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=T" +
				"op;</StyleData></NamedStyle><NamedStyle><Name>LabelStyleDefault.default</Name><P" +
				"arentName>Control</ParentName><StyleData>Border=None,Control,1;BackColor=Transpa" +
				"rent;</StyleData></NamedStyle><NamedStyle><Name>Header</Name><ParentName>Control" +
				"</ParentName><StyleData>Border=None,Control,1;</StyleData></NamedStyle><NamedSty" +
				"le><Name>Control.default</Name><ParentName /><StyleData>ForeColor=ControlText;Bo" +
				"rder=None,Control,1;BackColor=Control;</StyleData></NamedStyle><NamedStyle><Name" +
				">AxisY2</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;Border=N" +
				"one,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleDa" +
				"ta></NamedStyle><NamedStyle><Name>Area.default</Name><ParentName>Control</Parent" +
				"Name><StyleData>Border=None,Control,1;AlignVert=Top;</StyleData></NamedStyle></S" +
				"tyleCollection><Axes><Axis _onTop=\"0\" Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=\"0" +
				".5\" AutoMajor=\"True\" AutoMinor=\"True\" Compass=\"South\" AutoMax=\"True\" AutoMin=\"Tr" +
				"ue\"><GridMajor AutoSpace=\"True\" Pattern=\"Dash\" Color=\"LightGray\" Thickness=\"1\" /" +
				"><GridMinor AutoSpace=\"True\" Pattern=\"Dash\" Color=\"LightGray\" Thickness=\"1\" /><T" +
				"ext /></Axis><Axis _onTop=\"0\" Max=\"26\" Min=\"8\" UnitMajor=\"2\" UnitMinor=\"1\" AutoM" +
				"ajor=\"True\" AutoMinor=\"True\" Compass=\"West\" AutoMax=\"True\" AutoMin=\"True\"><GridM" +
				"ajor AutoSpace=\"True\" Pattern=\"Dash\" Color=\"LightGray\" Thickness=\"1\" /><GridMino" +
				"r AutoSpace=\"True\" Pattern=\"Dash\" Color=\"LightGray\" Thickness=\"1\" /><Text /></Ax" +
				"is><Axis _onTop=\"0\" Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"True\"" +
				" AutoMinor=\"True\" Compass=\"East\" AutoMax=\"True\" AutoMin=\"True\"><GridMajor AutoSp" +
				"ace=\"True\" Pattern=\"Dash\" Color=\"LightGray\" Thickness=\"1\" /><GridMinor AutoSpace" +
				"=\"True\" Pattern=\"Dash\" Color=\"LightGray\" Thickness=\"1\" /><Text /></Axis></Axes><" +
				"Footer Compass=\"South\"><Text /></Footer><Legend Orientation=\"Auto\" Visible=\"Fals" +
				"e\" Compass=\"East\"><Text /></Legend><ChartArea /><ChartGroupsCollection><ChartGro" +
				"up><DataSerializer DefaultSet=\"True\" Hole=\"3.4028234663852886E+38\"><DataSeriesCo" +
				"llection><DataSeriesSerializer><Y1 /><X>1;2;3;4;5</X><Y2 /><Y3 /><SymbolStyle Co" +
				"lor=\"Coral\" Shape=\"Box\" /><LineStyle Pattern=\"Solid\" Color=\"DarkGoldenrod\" Thick" +
				"ness=\"1\" /><Y>20;22;19;24;25</Y><SeriesLabel>series 0</SeriesLabel><DataTypes>Si" +
				"ngle;Single;Double;Double;Double</DataTypes></DataSeriesSerializer><DataSeriesSe" +
				"rializer><Y1 /><X>1;2;3;4;5</X><Y2 /><Y3 /><SymbolStyle Color=\"CornflowerBlue\" S" +
				"hape=\"Dot\" /><LineStyle Pattern=\"Solid\" Color=\"DarkGray\" Thickness=\"1\" /><Y>8;12" +
				";10;12;15</Y><SeriesLabel>series 1</SeriesLabel><DataTypes>Single;Single;Double;" +
				"Double;Double</DataTypes></DataSeriesSerializer><DataSeriesSerializer><Y1 /><X>1" +
				";2;3;4;5</X><Y2 /><Y3 /><SymbolStyle Color=\"Cornsilk\" Shape=\"Tri\" /><LineStyle P" +
				"attern=\"Solid\" Color=\"DarkGreen\" Thickness=\"1\" /><Y>10;16;17;15;23</Y><SeriesLab" +
				"el>series 2</SeriesLabel><DataTypes>Single;Single;Double;Double;Double</DataType" +
				"s></DataSeriesSerializer><DataSeriesSerializer><Y1 /><X>1;2;3;4;5</X><Y2 /><Y3 /" +
				"><SymbolStyle Color=\"Crimson\" Shape=\"Diamond\" /><LineStyle Pattern=\"Solid\" Color" +
				"=\"DarkKhaki\" Thickness=\"1\" /><Y>16;19;15;22;18</Y><SeriesLabel>series 3</SeriesL" +
				"abel><DataTypes>Single;Single;Double;Double;Double</DataTypes></DataSeriesSerial" +
				"izer></DataSeriesCollection></DataSerializer><Polar>Degrees=True,PiRatioAnnotati" +
				"ons=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Name>Gr" +
				"oup1</Name><Pie>OtherOffset=0,Start=0</Pie><ShowOutline>True</ShowOutline><HiLoD" +
				"ata>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpe" +
				"n=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</B" +
				"ubble><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Bar>ClusterOverlap=0" +
				",ClusterWidth=50</Bar></ChartGroup><ChartGroup><DataSerializer Hole=\"3.402823466" +
				"3852886E+38\" /><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar" +
				">Degrees=True,Filled=False,Start=0</Radar><Name>Group2</Name><Pie>OtherOffset=0," +
				"Start=0</Pie><ShowOutline>True</ShowOutline><HiLoData>FillFalling=True,FillTrans" +
				"parent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>Encod" +
				"ingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Stacked>False</Stacked>" +
				"<ChartType>XYPlot</ChartType><Bar>ClusterOverlap=0,ClusterWidth=50</Bar></ChartG" +
				"roup></ChartGroupsCollection></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(720, 374);
			this.c1Chart1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(720, 430);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1Chart1,
																		  this.panel1});
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "ComponentOne Chart for .NET Demo - Stock Chart";
			this.panel1.ResumeLayout(false);
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

		private void InitChart()
		{
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;//!!VBPassThru
			// --Setup Chart1--------------------------
			c1Chart1.BackColor = Color.White;

			// Setup the header
			C1.Win.C1Chart.Title header = c1Chart1.Header;
			header.Text = "Stock Chart ";
			header.Style.Font = new Font("Century", 16, FontStyle.Bold);
			header.Style.ForeColor = Color.DodgerBlue;
			header.Style.BackColor = Color.LightCyan;
			header.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			header.Style.Border.Color = Color.Gold; 
			header.Style.Border.Thickness = 3;

			// Hide the footer
			c1Chart1.Footer.Visible = false;

			// Setup the Axis X
			C1.Win.C1Chart.Axis ax = c1Chart1.ChartArea.AxisX;
			ax.Thickness = 1;
			ax.AnnoFormat = C1.Win.C1Chart.FormatEnum.DateManual;
			ax.AnnoFormatString = "d";
			ax.GridMajor.Color = Color.DarkGray;
			ax.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Dash;
			ax.GridMajor.Visible = true;
			ax.Compass = C1.Win.C1Chart.CompassEnum.North;

			// Setup the Axis Y
			C1.Win.C1Chart.Axis ay = c1Chart1.ChartArea.AxisY;
			ay.Thickness = 1;
			ay.Min = 1600;
			ay.Max = 1960;
			ay.AnnoFormat = C1.Win.C1Chart.FormatEnum.NumericManual;
			ay.AnnoFormatString = "F";
			ay.GridMajor.Color = Color.DarkGray;
			ay.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
			ay.GridMajor.Visible = true;
			ay.Text = "Price ($)";

			// Setup the Axis Y2
			C1.Win.C1Chart.Axis ay2 = c1Chart1.ChartArea.AxisY2;
			ay2.Thickness = 1;
			ay2.Min = 0;
			ay2.Max = 30000000;
			ay2.Text = "Volume";
			ay2.Visible = true;

			c1Chart1.ChartArea.PlotArea.Boxed = true;

			// Setup the group 0
			c1Chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Candle;

			c1Chart1.ChartGroups[0].ChartData.SeriesList.RemoveAll(); 
			series0 = c1Chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
			series0.LineStyle.Color = Color.Blue;

			// Setup the group 1
			c1Chart1.ChartGroups[1].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar;

			c1Chart1.ChartGroups[1].ChartData.SeriesList.RemoveAll(); 
			series1 = c1Chart1.ChartGroups[1].ChartData.SeriesList.AddNewSeries();
			series1.LineStyle.Color = Color.FromArgb(40, Color.Blue);
		}

		private void SetupChartData()
		{
			if (series0 == null)
				return;

			ArrayList arrHi		= new ArrayList();
			ArrayList arrLo		= new ArrayList();
			ArrayList arrOpen	= new ArrayList();
			ArrayList arrClose	= new ArrayList();
			ArrayList arrVolumn	= new ArrayList();

			// change the : to newlines
			rtData.Text = rtData.Text.Replace(':', '\n');

			foreach(string line in rtData.Lines)
			{
				string[] cols = line.Split(' ');
				arrOpen.Add(double.Parse(cols[0], CultureInfo.InvariantCulture));
				arrHi.Add(double.Parse(cols[1], CultureInfo.InvariantCulture));
				arrLo.Add(double.Parse(cols[2], CultureInfo.InvariantCulture));
				arrClose.Add(double.Parse(cols[3], CultureInfo.InvariantCulture));
				arrVolumn.Add(double.Parse(cols[5], CultureInfo.InvariantCulture));
			}

			DateTime date = DateTime.Parse("2003/02/22");

			series0.X.Length = arrHi.Count;
			series1.X.Length = arrHi.Count;
			for(int i = 0; i < series0.X.Length; i++)
			{
				series0.X[i] = date.AddDays(i);
				series1.X[i] = date.AddDays(i);
			}

			series0.Y.CopyDataIn((double[])arrHi.ToArray(typeof(double)));
			series0.Y1.CopyDataIn((double[])arrLo.ToArray(typeof(double))); 
			series0.Y2.CopyDataIn((double[])arrOpen.ToArray(typeof(double)));
			series0.Y3.CopyDataIn((double[])arrClose.ToArray(typeof(double)));

			series1.Y.CopyDataIn((double[])arrVolumn.ToArray(typeof(double)));
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("https://developer.mescius.com");
		}
	}
}
