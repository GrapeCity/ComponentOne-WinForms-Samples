using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Management;
using C1.Win.C1Chart;

namespace DiskSpace
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{

		// Structure that holds the disk information
		private class DiskInfo
		{
			public	Int64 Size;
			public	Int64 FreeSpace;
			public	string DeviceID;
			public  string VolumnName;
			public  string FileSystem;
		}

		// Size format enumeration
		private enum SizeFormat
		{
			By = 0,
			KB,
			MB,
			GB
		}


		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.Panel panel1;

		private int	diskCount			= 0;
		private const int maxDisk		= 24;
		private DiskInfo[] arrDiskInfo	= (DiskInfo[])Array.CreateInstance( typeof(DiskInfo), maxDisk);
		private int	prePointIndex		= -1;

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.CheckBox chbShowSize;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.NumericUpDown udElev;
		private System.Windows.Forms.Label lblElev;
		private System.Windows.Forms.CheckBox check3D;
		private System.Windows.Forms.NumericUpDown udDepth;
		private System.Windows.Forms.Label lblDepth;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			udDepth.Minimum = 5;
			udDepth.Maximum = 100;
			udDepth.Increment = 5;

			udElev.Minimum = 5;
			udElev.Maximum = 85;
			udElev.Increment = 5;

			InitChart();
			GetDiskInfo();
			FillChartData();
//			PositionDiskLabels();

			c1Chart1.ChartLabels.DefaultLabelStyle.BackColor = SystemColors.Info;
			c1Chart1.ChartLabels.DefaultLabelStyle.Border.BorderStyle = BorderStyleEnum.Solid;

			c1Chart1.ChartLabels.LabelsCollection.Clear();  
			SetDiskLabels();
			SetSizeLabels(true);

			udDepth.Value = c1Chart1.ChartArea.PlotArea.View3D.Depth;
			udElev.Value = c1Chart1.ChartArea.PlotArea.View3D.Elevation;
			check3D.Checked = (udDepth.Value > 0);
			udDepth.Enabled = check3D.Checked;
			udElev.Enabled = check3D.Checked;
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
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.chbShowSize = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.udElev = new System.Windows.Forms.NumericUpDown();
			this.lblElev = new System.Windows.Forms.Label();
			this.check3D = new System.Windows.Forms.CheckBox();
			this.udDepth = new System.Windows.Forms.NumericUpDown();
			this.lblDepth = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udElev)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udDepth)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Location = new System.Drawing.Point(0, 96);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><Axes><Axis Compass=\"South\" Min=\"" +
				"1\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True" +
				"\" AutoMin=\"True\" _onTop=\"0\" Max=\"5\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Pa" +
				"ttern=\"Dash\" Color=\"LightGray\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Patte" +
				"rn=\"Dash\" Color=\"LightGray\" /><Text /></Axis><Axis Compass=\"West\" Min=\"8\" UnitMa" +
				"jor=\"2\" UnitMinor=\"1\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"" +
				"True\" _onTop=\"0\" Max=\"26\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Pattern=\"Das" +
				"h\" Color=\"LightGray\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Pattern=\"Dash\" " +
				"Color=\"LightGray\" /><Text /></Axis><Axis Compass=\"East\" Min=\"0\" UnitMajor=\"0\" Un" +
				"itMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onT" +
				"op=\"0\" Max=\"0\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Pattern=\"Dash\" Color=\"L" +
				"ightGray\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Pattern=\"Dash\" Color=\"Ligh" +
				"tGray\" /><Text /></Axis></Axes><Header Compass=\"North\"><Text /></Header><ChartGr" +
				"oupsCollection><ChartGroup><Stacked>False</Stacked><HiLoData>FillFalling=True,Fi" +
				"llTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Name>" +
				"Group1</Name><ChartType>XYPlot</ChartType><Bar>ClusterOverlap=0,ClusterWidth=50<" +
				"/Bar><DataSerializer Hole=\"3.4028234663852886E+38\" DefaultSet=\"True\"><DataSeries" +
				"Collection><DataSeriesSerializer><LineStyle Thickness=\"1\" Pattern=\"Solid\" Color=" +
				"\"DarkGoldenrod\" /><Y3 /><SeriesLabel>series 0</SeriesLabel><DataTypes>Single;Sin" +
				"gle;Double;Double;Double</DataTypes><Y>20;22;19;24;25</Y><SymbolStyle Color=\"Cor" +
				"al\" Shape=\"Box\" /><Y1 /><X>1;2;3;4;5</X><Y2 /></DataSeriesSerializer><DataSeries" +
				"Serializer><LineStyle Thickness=\"1\" Pattern=\"Solid\" Color=\"DarkGray\" /><Y3 /><Se" +
				"riesLabel>series 1</SeriesLabel><DataTypes>Single;Single;Double;Double;Double</D" +
				"ataTypes><Y>8;12;10;12;15</Y><SymbolStyle Color=\"CornflowerBlue\" Shape=\"Dot\" /><" +
				"Y1 /><X>1;2;3;4;5</X><Y2 /></DataSeriesSerializer><DataSeriesSerializer><LineSty" +
				"le Thickness=\"1\" Pattern=\"Solid\" Color=\"DarkGreen\" /><Y3 /><SeriesLabel>series 2" +
				"</SeriesLabel><DataTypes>Single;Single;Double;Double;Double</DataTypes><Y>10;16;" +
				"17;15;23</Y><SymbolStyle Color=\"Cornsilk\" Shape=\"Tri\" /><Y1 /><X>1;2;3;4;5</X><Y" +
				"2 /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Thickness=\"1\" Patter" +
				"n=\"Solid\" Color=\"DarkKhaki\" /><Y3 /><SeriesLabel>series 3</SeriesLabel><DataType" +
				"s>Single;Single;Double;Double;Double</DataTypes><Y>16;19;15;22;18</Y><SymbolStyl" +
				"e Color=\"Crimson\" Shape=\"Diamond\" /><Y1 /><X>1;2;3;4;5</X><Y2 /></DataSeriesSeri" +
				"alizer></DataSeriesCollection></DataSerializer><Bubble>EncodingMethod=Diameter,M" +
				"aximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True," +
				"Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><ShowOutline>True" +
				"</ShowOutline><Pie>OtherOffset=0,Start=0</Pie></ChartGroup><ChartGroup><Stacked>" +
				"False</Stacked><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,S" +
				"howClose=True,ShowOpen=True</HiLoData><Name>Group2</Name><ChartType>XYPlot</Char" +
				"tType><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><DataSerializer Hole=\"3.4028234" +
				"663852886E+38\" /><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</B" +
				"ubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=" +
				"True,Filled=False,Start=0</Radar><ShowOutline>True</ShowOutline><Pie>OtherOffset" +
				"=0,Start=0</Pie></ChartGroup></ChartGroupsCollection><Footer Compass=\"South\"><Te" +
				"xt /></Footer><StyleCollection><NamedStyle><StyleData>Border=None,Control,1;</St" +
				"yleData><Name>PlotArea</Name><ParentName>Area</ParentName></NamedStyle><NamedSty" +
				"le><StyleData /><Name>Legend</Name><ParentName>Legend.default</ParentName></Name" +
				"dStyle><NamedStyle><StyleData>Border=None,Control,1;</StyleData><Name>Footer</Na" +
				"me><ParentName>Control</ParentName></NamedStyle><NamedStyle><StyleData /><Name>A" +
				"rea</Name><ParentName>Area.default</ParentName></NamedStyle><NamedStyle><StyleDa" +
				"ta /><Name>Control</Name><ParentName>Control.default</ParentName></NamedStyle><N" +
				"amedStyle><StyleData>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;Bac" +
				"kColor=Transparent;Opaque=False;AlignVert=Bottom;</StyleData><Name>AxisX</Name><" +
				"ParentName>Area</ParentName></NamedStyle><NamedStyle><StyleData>Rotation=Rotate2" +
				"70;Border=None,Control,1;AlignHorz=Near;BackColor=Transparent;Opaque=False;Align" +
				"Vert=Center;</StyleData><Name>AxisY</Name><ParentName>Area</ParentName></NamedSt" +
				"yle><NamedStyle><StyleData /><Name>LabelStyleDefault</Name><ParentName>LabelStyl" +
				"eDefault.default</ParentName></NamedStyle><NamedStyle><StyleData>Border=None,Bla" +
				"ck,1;Wrap=False;AlignVert=Top;</StyleData><Name>Legend.default</Name><ParentName" +
				">Control</ParentName></NamedStyle><NamedStyle><StyleData>Border=None,Control,1;B" +
				"ackColor=Transparent;</StyleData><Name>LabelStyleDefault.default</Name><ParentNa" +
				"me>Control</ParentName></NamedStyle><NamedStyle><StyleData>Border=None,Control,1" +
				";</StyleData><Name>Header</Name><ParentName>Control</ParentName></NamedStyle><Na" +
				"medStyle><StyleData>ForeColor=ControlText;Border=None,Control,1;BackColor=Contro" +
				"l;</StyleData><Name>Control.default</Name><ParentName /></NamedStyle><NamedStyle" +
				"><StyleData>Rotation=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColor=" +
				"Transparent;AlignVert=Center;</StyleData><Name>AxisY2</Name><ParentName>Area</Pa" +
				"rentName></NamedStyle><NamedStyle><StyleData>Border=None,Control,1;AlignVert=Top" +
				";</StyleData><Name>Area.default</Name><ParentName>Control</ParentName></NamedSty" +
				"le></StyleCollection><Legend Compass=\"East\" Visible=\"False\"><Text /></Legend><Ch" +
				"artArea /></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(680, 390);
			this.c1Chart1.TabIndex = 0;
			this.c1Chart1.SizeChanged += new System.EventHandler(this.c1Chart1_SizeChanged);
			this.c1Chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseMove);
			this.c1Chart1.Paint += new System.Windows.Forms.PaintEventHandler(this.c1Chart1_Paint);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.groupBox1,
																				 this.groupBox2,
																				 this.button1});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(680, 96);
			this.panel1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.radioButton4,
																					this.radioButton1,
																					this.radioButton2,
																					this.radioButton3,
																					this.chbShowSize});
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(224, 72);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Size Format";
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(160, 48);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(48, 16);
			this.radioButton4.TabIndex = 4;
			this.radioButton4.Text = "GB";
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(88, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(64, 16);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.Text = "Byte";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(160, 24);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(48, 16);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.Text = "KB";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.Checked = true;
			this.radioButton3.Location = new System.Drawing.Point(88, 48);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(48, 16);
			this.radioButton3.TabIndex = 3;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "MB";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// chbShowSize
			// 
			this.chbShowSize.Checked = true;
			this.chbShowSize.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbShowSize.Location = new System.Drawing.Point(8, 32);
			this.chbShowSize.Name = "chbShowSize";
			this.chbShowSize.Size = new System.Drawing.Size(56, 16);
			this.chbShowSize.TabIndex = 1;
			this.chbShowSize.Text = "Show";
			this.chbShowSize.CheckedChanged += new System.EventHandler(this.chbShowSize_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.udElev,
																					this.lblElev,
																					this.check3D,
																					this.udDepth,
																					this.lblDepth});
			this.groupBox2.Location = new System.Drawing.Point(256, 16);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(208, 72);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "3D";
			// 
			// udElev
			// 
			this.udElev.Enabled = false;
			this.udElev.Location = new System.Drawing.Point(104, 40);
			this.udElev.Name = "udElev";
			this.udElev.Size = new System.Drawing.Size(56, 20);
			this.udElev.TabIndex = 9;
			this.udElev.ValueChanged += new System.EventHandler(this.udElev_ValueChanged);
			// 
			// lblElev
			// 
			this.lblElev.Location = new System.Drawing.Point(64, 40);
			this.lblElev.Name = "lblElev";
			this.lblElev.Size = new System.Drawing.Size(32, 16);
			this.lblElev.TabIndex = 8;
			this.lblElev.Text = "Elev.";
			// 
			// check3D
			// 
			this.check3D.Location = new System.Drawing.Point(8, 16);
			this.check3D.Name = "check3D";
			this.check3D.Size = new System.Drawing.Size(40, 40);
			this.check3D.TabIndex = 7;
			this.check3D.Text = "On";
			this.check3D.CheckedChanged += new System.EventHandler(this.check3D_CheckedChanged);
			// 
			// udDepth
			// 
			this.udDepth.Enabled = false;
			this.udDepth.Location = new System.Drawing.Point(104, 16);
			this.udDepth.Name = "udDepth";
			this.udDepth.Size = new System.Drawing.Size(56, 20);
			this.udDepth.TabIndex = 7;
			this.udDepth.ValueChanged += new System.EventHandler(this.udDepth_ValueChanged);
			// 
			// lblDepth
			// 
			this.lblDepth.Location = new System.Drawing.Point(64, 16);
			this.lblDepth.Name = "lblDepth";
			this.lblDepth.Size = new System.Drawing.Size(40, 16);
			this.lblDepth.TabIndex = 7;
			this.lblDepth.Text = "Depth";
			// 
			// button1
			// 
			this.button1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.button1.ForeColor = System.Drawing.Color.Lime;
			this.button1.Location = new System.Drawing.Point(552, 64);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "Visit Web Site";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(680, 486);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1Chart1,
																		  this.panel1});
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "ComponentOne Chart for .NET Demo - Disk Space";
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udElev)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udDepth)).EndInit();
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
		/// Get the bottom point of a pie
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		private Point GetDiskLabelPosition( int i )
		{
			Rectangle r = c1Chart1.ChartGroups[0].DataIndexToRect(0, i);

			Point pt = r.Location;
			while (true)
			{
				int s = 0;
				int p = 0;
				int d = 0;
				c1Chart1.ChartGroups[0].CoordToDataIndex(pt.X, pt.Y, C1.Win.C1Chart.CoordinateFocusEnum.YCoord, ref s, ref p, ref d);

				if (d == 0)
					pt.Offset(0, 10); 
				else
				{
					pt.Offset(0, -d); 
					break;
				}
			}

			pt.Offset(0, 5); 
			return pt;
		}


		/// <summary>
		/// Get the disk information of all logic disks
		/// </summary>
		private void GetDiskInfo()
		{
			char diskID				= 'c';
			ManagementObject disk	= null;
			int i;

			for (i = 0; i < maxDisk; i++)
			{
				try
				{
					disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + diskID +":\"");
					disk.Get();

					DiskInfo info	= new DiskInfo();
					info.Size		= Int64.Parse(disk["Size"].ToString());
					info.FreeSpace	= Int64.Parse(disk["FreeSpace"].ToString());
					info.DeviceID	= diskID.ToString();
					info.VolumnName = (string)disk["VolumeName"];
					info.FileSystem	= (string)disk["FileSystem"]; 
					arrDiskInfo[i]	= info;
					diskID++;//!!VBSubst diskID = Chr(Asc(diskID) + 1)
				}
				catch
				{
					break;
				}
			}

			diskCount = diskID - 'c';//!!VBSubst diskCount = Asc(diskID) - Asc("c")
			if (diskCount <= 0)
				throw new Exception("Error happend while read the disk information.");

			// The last one is used to store the total size information
			DiskInfo allInfo	= new DiskInfo();
			allInfo.Size = 0;
			allInfo.FreeSpace = 0;
			for(i = 0; i < diskCount; i++ )
			{
				allInfo.Size		+= arrDiskInfo[i].Size;
				allInfo.FreeSpace	+= arrDiskInfo[i].FreeSpace;
			}

			arrDiskInfo[diskCount]	= allInfo;
		}

		/// <summary>
		/// Initialize the chart
		/// </summary>
		private void InitChart()
		{
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;//!!VBPassThru

			c1Chart1.BackColor = SystemColors.ControlLightLight;

			// Set up the header
			c1Chart1.Header.Text = "Disk Space Information";
			c1Chart1.Header.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Fillet;
			c1Chart1.Header.Style.Border.Thickness = 2;
			c1Chart1.Header.Style.Font = new Font( "Arial", 14, FontStyle.Bold);
			c1Chart1.Header.Style.ForeColor = Color.MediumBlue;

			// Set up the footer
			c1Chart1.Footer.Text = "Please move your mouse on each pie to see information in detail.";
			c1Chart1.Footer.Style.Border.Color = Color.Blue;
			c1Chart1.Footer.Style.Font = new Font( "Arial", 10);

			// Setup the legend.
			Legend lgd = c1Chart1.Legend;
			lgd.Compass = CompassEnum.North;
			lgd.Location = new Point(8, 20);
			lgd.Style.Border.BorderStyle = BorderStyleEnum.Raised;
			lgd.Style.Border.Thickness = 2;
			lgd.Style.Font = new Font("Arial Narrow", 10);
			lgd.Style.HorizontalAlignment = AlignHorzEnum.Center;
			lgd.Style.BackColor = Color.LightSeaGreen;
			lgd.Style.BackColor2 = Color.LightCyan;
			lgd.Style.GradientStyle = C1.Win.C1Chart.GradientStyleEnum.Horizontal;
			lgd.Visible = true;

			c1Chart1.ChartArea.PlotArea.View3D.Depth = 10;
			c1Chart1.ChartArea.PlotArea.View3D.Elevation = 30;

			// We use Pie Chart in this demo
			c1Chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Pie;
			c1Chart1.ChartGroups[0].Pie.OtherOffset = 20;
		}


		/// <summary>
		/// Fill the chart data with the disk info
		/// </summary>
		private void FillChartData()
		{
			int pieCount = diskCount + 1;
			Int64[] arrDiskSize		= (Int64[])Array.CreateInstance( typeof(Int64), pieCount);
			Int64[] arrFreeSpace	= (Int64[])Array.CreateInstance( typeof(Int64), pieCount);
			Int64[] arrUsedSpace	= (Int64[])Array.CreateInstance( typeof(Int64), pieCount);
			int i;

			for(i = 0; i < pieCount; i++)
			{
				arrDiskSize[i]	= arrDiskInfo[i].Size;
				arrFreeSpace[i] = arrDiskInfo[i].FreeSpace;
				arrUsedSpace[i] = arrDiskInfo[i].Size - arrDiskInfo[i].FreeSpace;
			}

			// Clear the existing data
			ChartGroup grp = c1Chart1.ChartGroups[0];
			grp.ChartData.SeriesList.Clear(); 

			// Set up the X series array
			int[] arrXSeries = (int[])Array.CreateInstance( typeof(int), pieCount);
			for (i = 0; i < pieCount; i++)
				arrXSeries[i] = i;

			// Fill the Used Space
			ChartDataSeries series	= grp.ChartData.SeriesList.AddNewSeries();
			series.LineStyle.Color	= Color.Blue;
			series.Label			= "Used Space";
			series.X.CopyDataIn(arrXSeries);
			series.Y.CopyDataIn(arrUsedSpace); 

			// Fill the Used Space
			series = grp.ChartData.SeriesList.AddNewSeries();
			series.LineStyle.Color	= Color.OrangeRed;
			series.Label			= "Free Space";
			series.X.CopyDataIn(arrXSeries);
			series.Y.CopyDataIn(arrFreeSpace);

			c1Chart1.Legend.Text = "Total Capacity: \n" + this.GetSizeString(arrDiskInfo[diskCount].Size, this.Format);
		}

		/// <summary>
		/// Gets the size string according to the size format
		/// </summary>
		/// <param name="size">Size in byte.</param>
		/// <param name="format">Size formate</param>
		/// <returns></returns>
		private string GetSizeString(Int64 size, SizeFormat format)
		{
			double dblSize = size;
			switch(format)
			{
				case SizeFormat.By:
					return string.Format("{0} Bytes", size); 

				case SizeFormat.KB:
					return string.Format("{0:N} KB", size/1024); 

				case SizeFormat.MB:
					dblSize = ((double)size)/1024/1024;
					return string.Format("{0:N} MB", dblSize); 

				case SizeFormat.GB:
					dblSize = ((double)size)/1024/1024/1024;
					return string.Format("{0:N} GB", dblSize); 
			}

			return null;
		}

		/// <summary>
		/// Gets the selected size format.
		/// </summary>
		private SizeFormat Format
		{
			get 
			{
				if (this.radioButton1.Checked)
					return SizeFormat.By;

				if (this.radioButton2.Checked)
					return SizeFormat.KB;

				if (this.radioButton3.Checked)
					return SizeFormat.MB;

				return SizeFormat.GB;
			}
		}

		/// <summary>
		/// Sets the labels for each slice.
		/// </summary>
		private void SetDiskLabels()
		{
			C1.Win.C1Chart.Label lbl = null;
			for(int i = 0; i < diskCount; i++)
			{
				// Add a chart label for each disk
				lbl = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
				lbl.AttachMethod = AttachMethodEnum.Coordinate;
				lbl.Compass = C1.Win.C1Chart.LabelCompassEnum.South;
				lbl.Style.BackColor = Color.Transparent;
				lbl.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None;
				lbl.Text = "Drive " + arrDiskInfo[i].DeviceID.ToUpper();
				lbl.Offset = 0;
				lbl.Visible = true;
			}

			// Add a chart label for the summary pie
			lbl = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
			lbl.AttachMethod = AttachMethodEnum.Coordinate;
			lbl.Compass = C1.Win.C1Chart.LabelCompassEnum.South;
			lbl.Style.BackColor = Color.Transparent;
			lbl.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None;
			lbl.Text = "Total";
			lbl.Offset = 0;
			lbl.Visible = true;
		}

		/// <summary>
		/// Position the disk labels
		/// </summary>
		private void PositionDiskLabels()
		{
			if (first)
				return;

			for(int i = 0; i < diskCount + 1; i++)
			{
				Point p = this.GetDiskLabelPosition(i);

				C1.Win.C1Chart.Label lbl = c1Chart1.ChartLabels.LabelsCollection[i];
				lbl.AttachMethodData.X = p.X;
				lbl.AttachMethodData.Y = p.Y;
			}
		}

		/// <summary>
		/// Sets the labels for each slice.
		/// </summary>
		private void SetSizeLabels(bool create)
		{
			if (create)
			{
				// Set labels for Used Space
				for(int i = 0; i < diskCount + 1; i++)
				{
					for(int j = 0; j < 2; j++)
					{
						ChartDataSeries series	= c1Chart1.ChartGroups[0].ChartData.SeriesList[j];
						// Add a chart label for each slice
						C1.Win.C1Chart.Label lbl = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
						lbl.AttachMethod = AttachMethodEnum.DataIndex;
						lbl.Text = GetSizeString((Int64)series.Y[i], this.Format);
						if (j == 0)
							lbl.Compass = LabelCompassEnum.North;
						else
							lbl.Compass = LabelCompassEnum.South;
						lbl.Offset = 0;
						lbl.Visible = true;

						AttachMethodData amd = lbl.AttachMethodData;
						amd.GroupIndex = 0;
						amd.SeriesIndex = j;
						amd.PointIndex = i;
					}
				}
			}
			else
			{
				for(int i = 0; i < diskCount + 1; i++)
				{
					for(int j = 0; j < 2; j++)
					{
						ChartDataSeries series	= c1Chart1.ChartGroups[0].ChartData.SeriesList[j];
						// Add a chart label for each slice
						C1.Win.C1Chart.Label lbl = c1Chart1.ChartLabels.LabelsCollection[diskCount + 1 + i * 2 + j];
						lbl.Text = GetSizeString((Int64)series.Y[i], this.Format);
					}
				}
			}
		}

		/// <summary>
		/// The mouse move event handler.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void c1Chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button.Equals(MouseButtons.None))
			{
				int s = -1, p = -1, d = -1;
				ChartGroup grp = c1Chart1.ChartGroups[0];
				if(grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.XandYCoord, ref s, ref p, ref d))
				{
					if ( p >= 0 && d == 0)
					{
						if (prePointIndex == -1 && prePointIndex != p)
						{
							string ftr;
							DiskInfo info = arrDiskInfo[p];
							if (p < diskCount)
								ftr = string.Format("Total Capacity: {0} | VolumnName: {1} | File System: {2}", this.GetSizeString(info.Size, this.Format), info.VolumnName, info.FileSystem); 
							else
								ftr = string.Format("Total Capacity: {0}", this.GetSizeString(info.Size, this.Format));

							c1Chart1.Footer.Text = ftr;
							prePointIndex = p;
						}

					}else
					{
						c1Chart1.Footer.Text = "Please move the mouse on each pie to see information in details.";
						prePointIndex = -1;
					}
				}
			}
		}

		private void chbShowSize_CheckedChanged(object sender, System.EventArgs e)
		{
			bool show = this.chbShowSize.Checked;
			for (int i = diskCount + 1; i < c1Chart1.ChartLabels.LabelsCollection.Count ; i++)
				c1Chart1.ChartLabels.LabelsCollection[i].Visible = show;
		}

		private void radioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			if( c1Chart1.ChartGroups[0].ChartData.SeriesList.Count>0)
			{
				this.SetSizeLabels(false);

				c1Chart1.Legend.Text = "Total Capacity: \n" + this.GetSizeString(arrDiskInfo[diskCount].Size, this.Format);
			}
		}

		private void check3D_CheckedChanged(object sender, System.EventArgs e)
		{
			if( check3D.Checked)
			{
				c1Chart1.ChartArea.PlotArea.View3D.Depth = (int)udDepth.Value;
				c1Chart1.ChartArea.PlotArea.View3D.Elevation = (int)udElev.Value;

				udDepth.Enabled = true;
				udElev.Enabled = true;
			}
			else
			{
				c1Chart1.ChartArea.PlotArea.View3D.Depth = 0;

				udDepth.Enabled = false;
				udElev.Enabled = false;
			}

			recalc = true;
		}

		private void udDepth_ValueChanged(object sender, System.EventArgs e)
		{
			if( check3D.Checked)
			{
				c1Chart1.ChartArea.PlotArea.View3D.Depth = (int)udDepth.Value;
				recalc = true;
			}
		}

		private void udElev_ValueChanged(object sender, System.EventArgs e)
		{
			if( check3D.Checked)
			{
				c1Chart1.ChartArea.PlotArea.View3D.Elevation = (int)udElev.Value;
				recalc = true;
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("https://developer.mescius.com");
		}

		private void c1Chart1_SizeChanged(object sender, System.EventArgs e)
		{
			recalc = true;
		}

		bool first = true;
		bool recalc = false;
		private void c1Chart1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if (first)
			{
				first = false;
				PositionDiskLabels();
			}

			if( recalc)
			{
				recalc = false;
				PositionDiskLabels();
			}
		}
	}
}
