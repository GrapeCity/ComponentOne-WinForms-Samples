using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1Chart;

namespace DataStyl
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grpChartTypes;
		private System.Windows.Forms.RadioButton radioPlot;
		private System.Windows.Forms.RadioButton radioBar;
		private System.Windows.Forms.RadioButton radioPie;
		private System.Windows.Forms.RadioButton radioHiLoOpCl;
		private System.Windows.Forms.RadioButton radioCandle;
		private System.Windows.Forms.RadioButton radioPolar;
		private System.Windows.Forms.RadioButton radioRadar;
		private System.Windows.Forms.RadioButton radioBubble;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		private System.Windows.Forms.RadioButton radioArea;
		private System.Windows.Forms.GroupBox grpStacking;
		private System.Windows.Forms.CheckBox checkStacked;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();
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
			this.grpChartTypes = new System.Windows.Forms.GroupBox();
			this.radioPlot = new System.Windows.Forms.RadioButton();
			this.radioBar = new System.Windows.Forms.RadioButton();
			this.radioPie = new System.Windows.Forms.RadioButton();
			this.radioArea = new System.Windows.Forms.RadioButton();
			this.radioHiLoOpCl = new System.Windows.Forms.RadioButton();
			this.radioCandle = new System.Windows.Forms.RadioButton();
			this.radioPolar = new System.Windows.Forms.RadioButton();
			this.radioRadar = new System.Windows.Forms.RadioButton();
			this.radioBubble = new System.Windows.Forms.RadioButton();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.grpStacking = new System.Windows.Forms.GroupBox();
			this.checkStacked = new System.Windows.Forms.CheckBox();
			this.grpChartTypes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.grpStacking.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpChartTypes
			// 
			this.grpChartTypes.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.radioPlot,
																						this.radioBar,
																						this.radioPie,
																						this.radioArea,
																						this.radioHiLoOpCl,
																						this.radioCandle,
																						this.radioPolar,
																						this.radioRadar,
																						this.radioBubble});
			this.grpChartTypes.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grpChartTypes.Name = "grpChartTypes";
			this.grpChartTypes.Size = new System.Drawing.Size(592, 40);
			this.grpChartTypes.TabIndex = 0;
			this.grpChartTypes.TabStop = false;
			this.grpChartTypes.Text = "Chart Types:";
			// 
			// radioPlot
			// 
			this.radioPlot.Checked = true;
			this.radioPlot.Location = new System.Drawing.Point(8, 16);
			this.radioPlot.Name = "radioPlot";
			this.radioPlot.Size = new System.Drawing.Size(48, 16);
			this.radioPlot.TabIndex = 0;
			this.radioPlot.TabStop = true;
			this.radioPlot.Text = "Plot";
			this.radioPlot.CheckedChanged += new System.EventHandler(this.radioChartTypeChanged);
			// 
			// radioBar
			// 
			this.radioBar.Location = new System.Drawing.Point(56, 16);
			this.radioBar.Name = "radioBar";
			this.radioBar.Size = new System.Drawing.Size(48, 16);
			this.radioBar.TabIndex = 1;
			this.radioBar.Text = "Bar";
			this.radioBar.CheckedChanged += new System.EventHandler(this.radioChartTypeChanged);
			// 
			// radioPie
			// 
			this.radioPie.Location = new System.Drawing.Point(104, 16);
			this.radioPie.Name = "radioPie";
			this.radioPie.Size = new System.Drawing.Size(40, 16);
			this.radioPie.TabIndex = 2;
			this.radioPie.Text = "Pie";
			this.radioPie.CheckedChanged += new System.EventHandler(this.radioChartTypeChanged);
			// 
			// radioArea
			// 
			this.radioArea.Location = new System.Drawing.Point(152, 16);
			this.radioArea.Name = "radioArea";
			this.radioArea.Size = new System.Drawing.Size(48, 16);
			this.radioArea.TabIndex = 3;
			this.radioArea.Text = "Area";
			this.radioArea.CheckedChanged += new System.EventHandler(this.radioChartTypeChanged);
			// 
			// radioHiLoOpCl
			// 
			this.radioHiLoOpCl.Location = new System.Drawing.Point(200, 16);
			this.radioHiLoOpCl.Name = "radioHiLoOpCl";
			this.radioHiLoOpCl.Size = new System.Drawing.Size(136, 16);
			this.radioHiLoOpCl.TabIndex = 4;
			this.radioHiLoOpCl.Text = "High-Low-Open-Close";
			this.radioHiLoOpCl.CheckedChanged += new System.EventHandler(this.radioChartTypeChanged);
			// 
			// radioCandle
			// 
			this.radioCandle.Location = new System.Drawing.Point(336, 16);
			this.radioCandle.Name = "radioCandle";
			this.radioCandle.Size = new System.Drawing.Size(64, 16);
			this.radioCandle.TabIndex = 5;
			this.radioCandle.Text = "Candle";
			this.radioCandle.CheckedChanged += new System.EventHandler(this.radioChartTypeChanged);
			// 
			// radioPolar
			// 
			this.radioPolar.Location = new System.Drawing.Point(400, 16);
			this.radioPolar.Name = "radioPolar";
			this.radioPolar.Size = new System.Drawing.Size(56, 16);
			this.radioPolar.TabIndex = 6;
			this.radioPolar.Text = "Polar";
			this.radioPolar.CheckedChanged += new System.EventHandler(this.radioChartTypeChanged);
			// 
			// radioRadar
			// 
			this.radioRadar.Location = new System.Drawing.Point(456, 16);
			this.radioRadar.Name = "radioRadar";
			this.radioRadar.Size = new System.Drawing.Size(64, 16);
			this.radioRadar.TabIndex = 7;
			this.radioRadar.Text = "Radar";
			this.radioRadar.CheckedChanged += new System.EventHandler(this.radioChartTypeChanged);
			// 
			// radioBubble
			// 
			this.radioBubble.Location = new System.Drawing.Point(520, 16);
			this.radioBubble.Name = "radioBubble";
			this.radioBubble.Size = new System.Drawing.Size(64, 16);
			this.radioBubble.TabIndex = 8;
			this.radioBubble.Text = "Bubble";
			this.radioBubble.CheckedChanged += new System.EventHandler(this.radioChartTypeChanged);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem2});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuFileExit});
			this.menuItem1.Text = "File";
			// 
			// menuFileExit
			// 
			this.menuFileExit.Index = 0;
			this.menuFileExit.Text = "Exit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuHelpAbout});
			this.menuItem2.Text = "Help";
			// 
			// menuHelpAbout
			// 
			this.menuHelpAbout.Index = 0;
			this.menuHelpAbout.Text = "About";
			this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
			// 
			// c1Chart1
			// 
			this.c1Chart1.BackColor = System.Drawing.Color.LightSalmon;
			this.c1Chart1.Location = new System.Drawing.Point(16, 56);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><Axes><Axis Max=\"5\" Min=\"1\" UnitM" +
				"ajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMi" +
				"n=\"True\" _onTop=\"0\" Compass=\"South\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Co" +
				"lor=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color" +
				"=\"LightGray\" Pattern=\"Dash\" /><Text /></Axis><Axis Max=\"25\" Min=\"8\" UnitMajor=\"5" +
				"\" UnitMinor=\"2.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True" +
				"\" _onTop=\"0\" Compass=\"West\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"Lig" +
				"htGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightG" +
				"ray\" Pattern=\"Dash\" /><Text /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMin" +
				"or=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0" +
				"\" Compass=\"East\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pat" +
				"tern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Patter" +
				"n=\"Dash\" /><Text /></Axis></Axes><Header Compass=\"North\"><Text>header text</Text" +
				"></Header><ChartGroupsCollection><ChartGroup><Polar>Degrees=False,PiRatioAnnotat" +
				"ions=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Stacke" +
				"d>False</Stacked><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False" +
				",ShowClose=True,ShowOpen=True</HiLoData><ChartType>XYPlot</ChartType><Bubble>Enc" +
				"odingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Name>Group1</Name><Da" +
				"taSerializer DefaultSet=\"True\"><DataSeriesCollection><DataSeriesSerializer><Y>20" +
				";22;19;24;25</Y><LineStyle Thickness=\"1\" Color=\"DarkGoldenrod\" Pattern=\"Solid\" /" +
				"><SymbolStyle Shape=\"Box\" Size=\"8\" Color=\"Coral\" /><SeriesLabel>0</SeriesLabel><" +
				"DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1>8;12;10;12;15</Y1><X" +
				">1;2;3;4;5</X><Y3>16;19;15;22;18</Y3><Y2>10;16;17;15;23</Y2></DataSeriesSerializ" +
				"er><DataSeriesSerializer><Y>8;12;10;12;15</Y><LineStyle Thickness=\"1\" Color=\"Dar" +
				"kGray\" Pattern=\"Solid\" /><SymbolStyle Shape=\"Dot\" Size=\"8\" Color=\"CornflowerBlue" +
				"\" /><SeriesLabel>1</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</D" +
				"ataTypes><Y1>10;16;17;15;23</Y1><X>1;2;3;4;5</X><Y3 /><Y2 /></DataSeriesSerializ" +
				"er><DataSeriesSerializer><Y>10;16;17;15;23</Y><LineStyle Thickness=\"1\" Color=\"Da" +
				"rkGreen\" Pattern=\"Solid\" /><SymbolStyle Shape=\"Tri\" Size=\"8\" Color=\"DarkOliveGre" +
				"en\" /><SeriesLabel>2</SeriesLabel><DataTypes>Single;Single;Single;Single;Single<" +
				"/DataTypes><Y1 /><X>1;2;3;4;5</X><Y3 /><Y2 /></DataSeriesSerializer><DataSeriesS" +
				"erializer><Y>16;19;15;22;18</Y><LineStyle Thickness=\"1\" Color=\"DarkKhaki\" Patter" +
				"n=\"Solid\" /><SymbolStyle Shape=\"Diamond\" Size=\"8\" Color=\"Crimson\" /><SeriesLabel" +
				">3</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><" +
				"X>1;2;3;4;5</X><Y3 /><Y2 /></DataSeriesSerializer></DataSeriesCollection></DataS" +
				"erializer><ShowOutline>True</ShowOutline><Bar>ClusterOverlap=0,ClusterWidth=50</" +
				"Bar><Pie>OtherOffset=0,Start=0</Pie></ChartGroup><ChartGroup><Polar>Degrees=True" +
				",PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0" +
				"</Radar><Stacked>False</Stacked><HiLoData>FillFalling=True,FillTransparent=True," +
				"FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><ChartType>XYPlot</ChartT" +
				"ype><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Name>G" +
				"roup2</Name><DataSerializer /><ShowOutline>True</ShowOutline><Bar>ClusterOverlap" +
				"=0,ClusterWidth=50</Bar><Pie>OtherOffset=0,Start=0</Pie></ChartGroup></ChartGrou" +
				"psCollection><StyleCollection><NamedStyle><Name>PlotArea</Name><ParentName>Area<" +
				"/ParentName><StyleData>Border=Solid,ControlText,1;BackColor=Cornsilk;</StyleData" +
				"></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default</ParentN" +
				"ame><StyleData>Border=InsetBevel,Cornsilk,3;AlignHorz=Center;BackColor=Cornsilk;" +
				"Font=Microsoft Sans Serif, 10pt, style=Bold;</StyleData></NamedStyle><NamedStyle" +
				"><Name>Footer</Name><ParentName>Control</ParentName><StyleData>Border=InsetBevel" +
				",Control,3;BackColor=Gainsboro;Font=Microsoft Sans Serif, 10pt, style=Bold;</Sty" +
				"leData></NamedStyle><NamedStyle><Name>Area</Name><ParentName>Area.default</Paren" +
				"tName><StyleData /></NamedStyle><NamedStyle><Name>Control</Name><ParentName>Cont" +
				"rol.default</ParentName><StyleData>BackColor=LightSalmon;</StyleData></NamedStyl" +
				"e><NamedStyle><Name>AxisX</Name><ParentName>Area</ParentName><StyleData>Rotation" +
				"=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor=Transparent;AlignVert=" +
				"Bottom;</StyleData></NamedStyle><NamedStyle><Name>AxisY</Name><ParentName>Area</" +
				"ParentName><StyleData>Rotation=Rotate270;Border=None,Control,1;AlignHorz=Near;Ba" +
				"ckColor=Transparent;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name>" +
				"LabelStyleDefault</Name><ParentName>LabelStyleDefault.default</ParentName><Style" +
				"Data /></NamedStyle><NamedStyle><Name>Legend.default</Name><ParentName>Control</" +
				"ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData><" +
				"/NamedStyle><NamedStyle><Name>LabelStyleDefault.default</Name><ParentName>Contro" +
				"l</ParentName><StyleData>Border=None,Control,1;BackColor=Transparent;</StyleData" +
				"></NamedStyle><NamedStyle><Name>Header</Name><ParentName>Control</ParentName><St" +
				"yleData>Border=Inset,Gainsboro,1;AlignHorz=Center;BackColor=Gainsboro;Font=Micro" +
				"soft Sans Serif, 10pt, style=Bold;</StyleData></NamedStyle><NamedStyle><Name>Con" +
				"trol.default</Name><ParentName /><StyleData>ForeColor=ControlText;Border=None,Co" +
				"ntrol,1;BackColor=Control;</StyleData></NamedStyle><NamedStyle><Name>AxisY2</Nam" +
				"e><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;Border=None,Transpar" +
				"ent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData></NamedSt" +
				"yle><NamedStyle><Name>Area.default</Name><ParentName>Control</ParentName><StyleD" +
				"ata>Border=None,Control,1;AlignVert=Top;</StyleData></NamedStyle></StyleCollecti" +
				"on><Footer Compass=\"South\"><Text>Nowhere</Text></Footer><Legend Compass=\"East\" V" +
				"isible=\"True\"><Text>Series</Text></Legend><ChartArea /></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(656, 280);
			this.c1Chart1.TabIndex = 2;
			this.c1Chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseUp);
			this.c1Chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseMove);
			// 
			// grpStacking
			// 
			this.grpStacking.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.checkStacked});
			this.grpStacking.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grpStacking.Location = new System.Drawing.Point(600, 0);
			this.grpStacking.Name = "grpStacking";
			this.grpStacking.Size = new System.Drawing.Size(80, 40);
			this.grpStacking.TabIndex = 1;
			this.grpStacking.TabStop = false;
			this.grpStacking.Text = "Stacking";
			// 
			// checkStacked
			// 
			this.checkStacked.Location = new System.Drawing.Point(8, 16);
			this.checkStacked.Name = "checkStacked";
			this.checkStacked.Size = new System.Drawing.Size(64, 16);
			this.checkStacked.TabIndex = 0;
			this.checkStacked.Text = "Stacked";
			this.checkStacked.CheckedChanged += new System.EventHandler(this.checkStacked_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(688, 361);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.grpStacking,
																		  this.c1Chart1,
																		  this.grpChartTypes});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "ComponentOne Chart.Net 2D - DataStyle Chart Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.grpChartTypes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			this.grpStacking.ResumeLayout(false);
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// center the form
			this.CenterToParent();

			// manage the chart position.
			c1Chart1.Top = grpChartTypes.Bottom + 1;
			c1Chart1.Left = 0;
			c1Chart1.Width = this.ClientSize.Width;
			c1Chart1.Height = this.ClientSize.Height - grpChartTypes.Height;
			c1Chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;//!!VBPassThru

			// add the multiline header text.
			c1Chart1.Header.Text = "  Left click on the legend to change the symbols for its related series.  \n" +
				"  Right click on the legend to restore the original series symbol and color.  \n" +
				"  Middle click on the legend to toggle the series display.  \n" +
				"  Hover the cursor over a data point for its series and point indices.  ";

			// set the tag of each radio label to the type of chart desired.
			radioPlot.Tag = Chart2DTypeEnum.XYPlot;
			radioBar.Tag = Chart2DTypeEnum.Bar;
			radioPie.Tag = Chart2DTypeEnum.Pie;
			radioArea.Tag = Chart2DTypeEnum.Area;
			radioHiLoOpCl.Tag = Chart2DTypeEnum.HiLoOpenClose;
			radioCandle.Tag = Chart2DTypeEnum.Candle;
			radioPolar.Tag = Chart2DTypeEnum.Polar;
			radioRadar.Tag = Chart2DTypeEnum.Radar;
			radioBubble.Tag = Chart2DTypeEnum.Bubble;
		}

		private void radioChartTypeChanged(object sender, System.EventArgs e)
		{
			RadioButton rb = (RadioButton)sender;
			if(rb.Checked)
			{
				Chart2DTypeEnum ct = (Chart2DTypeEnum)rb.Tag;
				c1Chart1.ChartGroups[0].ChartType = ct;

				int maxSeries = 10;
				bool stackable = true;

				// special cases that limit the number of series shown.
				// this allows the demo to use the same data for all charts.
				switch(ct)
				{
					case Chart2DTypeEnum.Pie:
						stackable = false;
						break;

					case Chart2DTypeEnum.HiLo:
					case Chart2DTypeEnum.Bubble:
						stackable = false;
						maxSeries = 2;
						break;

					case Chart2DTypeEnum.HiLoOpenClose:
					case Chart2DTypeEnum.Candle:
						stackable = false;
						maxSeries = 1;
						break;
				}

				checkStacked.Enabled = stackable;

				ChartGroup grp = c1Chart1.ChartGroups[0];
				ChartDataSeriesCollection sl = grp.ChartData.SeriesList;
				int slim = sl.Count;
				for(int s=0; s < slim; s++)
				{
					if(s < maxSeries)
						sl[s].Display = SeriesDisplayEnum.Show;
					else
						sl[s].Display = SeriesDisplayEnum.Exclude;
				}
			}
		}

		// SeriesStuff is a private class to the form used to
		// manage the rotating line and symbol data when clicking
		// legend entries

		private class SeriesStuff
		{
			private bool wasSet = false;
			private Color lineColor = Color.Empty;
			private Color symbolColor = Color.Empty;
			private SymbolShapeEnum symbolShape = SymbolShapeEnum.None;

			public SeriesStuff() {}

			public static SeriesStuff [] Create(int len)
			{
				SeriesStuff [] ss = (SeriesStuff[])Array.CreateInstance(typeof(SeriesStuff), len);
				for(int s=0; s < len; s++)
					ss[s] = new SeriesStuff();
				return ss;
			}

			public void SetStuff(ChartDataSeries ser)
			{
				if(!wasSet)
				{
					lineColor = ser.LineStyle.Color;
					symbolColor = ser.SymbolStyle.Color;
					symbolShape = ser.SymbolStyle.Shape;
					wasSet = true;
				}
			}

			public void GetStuff(ChartDataSeries ser)
			{
				if(wasSet)
				{
					ser.LineStyle.Color = lineColor;
					ser.SymbolStyle.Color = symbolColor;
					ser.SymbolStyle.Shape = symbolShape;
				}
			}

			private Color NextColor(Color c)
			{
				int c1 = c.ToArgb();
				Random r = new Random(c1);
				c1 = r.Next(int.MaxValue);
				if(c1 > 0)
					c1 = -c1;
				c1 /= 256;
				c = Color.FromArgb(c1);
				return c;
			}

			private SymbolShapeEnum NextShape(SymbolShapeEnum ss)
			{
				Type t = typeof(SymbolShapeEnum);
				int iss = (int)ss + 1;
				if(!Enum.IsDefined(t, iss))
					iss = 0;
				return (SymbolShapeEnum)iss;
			}

			public void NextStuff(ChartDataSeries ser)
			{
				if(!wasSet)
					SetStuff(ser);

				ser.LineStyle.Color = NextColor(ser.LineStyle.Color);
				ser.SymbolStyle.Color = NextColor(ser.SymbolStyle.Color);
				ser.SymbolStyle.Shape = NextShape(ser.SymbolStyle.Shape);
			}
		}

		private SeriesStuff [] initialSeriesStuff = null;

		private void CycleSeries(int s)
		{
			if(initialSeriesStuff == null)
				initialSeriesStuff = SeriesStuff.Create(4);

			ChartDataSeries ser = c1Chart1.ChartGroups[0].ChartData[s];
			initialSeriesStuff[s].NextStuff(ser);
		}

		private void ResetSeries(int s)
		{
			if(initialSeriesStuff == null)
				return;

			ChartDataSeries ser = c1Chart1.ChartGroups[0].ChartData[s];
			initialSeriesStuff[s].GetStuff(ser);
		}

		private void ToggleSeriesDisplay(int s)
		{
			ChartDataSeries ser = c1Chart1.ChartGroups[0].ChartData[s];
			if(ser.Display.Equals(SeriesDisplayEnum.Show))
				ser.Display = SeriesDisplayEnum.Hide;
			else
				ser.Display = SeriesDisplayEnum.Show;
		}

		private void c1Chart1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			C1Chart chart = (C1Chart)sender;
			int g = 0, s = -1;

			ChartRegionEnum region = chart.ChartRegionFromCoord(e.X,e.Y);
			if(region.Equals(ChartRegionEnum.Legend))
			{
				Legend leg = chart.Legend;
				if(leg.SeriesFromCoord(e.X, e.Y, ref g, ref s))
				{
					if(s >= 0)
					{
						if(e.Button.Equals(MouseButtons.Left))
							CycleSeries(s);
						else if(e.Button.Equals(MouseButtons.Right))
							ResetSeries(s);
						else if(e.Button.Equals(MouseButtons.Middle))
							ToggleSeriesDisplay(s);
					}
				}
			}
		}

		private void c1Chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			C1Chart chart = (C1Chart)sender;
			int g = 0, s = -1, p = -1, d = -1;
			ChartGroup grp = chart.ChartGroups[g];

			ChartRegionEnum region = chart.ChartRegionFromCoord(e.X,e.Y);

			string footerText = "Nowhere";

			if(region.Equals(ChartRegionEnum.Legend))
			{
				// if in the legend, check for the series and update
				// the footerText as appropriate
				Legend leg = chart.Legend;
				if(leg.SeriesFromCoord(e.X, e.Y, ref g, ref s))
				{
					if(s >= 0)
						footerText = string.Format("Series {0}", s);
				}
			}
			else
			{
				// if it's close enough check for the series and update
				// the footerText as appropriate
				CoordinateFocusEnum focus = CoordinateFocusEnum.XandYCoord;
				bool stacked = grp.Stacked;
				int minDist = 5;

				if(radioBar.Checked && !stacked)
				{
					// special case where X focus is more appropriate
					focus = CoordinateFocusEnum.XCoord;
					minDist = 0;
				}
				else if(radioPie.Checked || (radioBar.Checked && stacked))
				{
					// special case where minimum distance of 0 is more
					// appropriate.
					minDist = 0;
				}

				if(grp.CoordToDataIndex(e.X, e.Y, focus, ref s, ref p, ref d))
				{
					if(s >=0 && p >= 0 && d <= minDist)
						footerText = string.Format("Index({0},{1})",s,p);
				}
			}

			chart.Footer.Text = footerText;
		}

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void checkStacked_CheckedChanged(object sender, System.EventArgs e)
		{
			CheckBox cb = (CheckBox)sender;
			c1Chart1.ChartGroups[0].Stacked = cb.Checked;;
		}
	}
}
