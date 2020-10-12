using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1Chart;

namespace StepChart
{
	/// <summary>
	/// Summary description for StepChart.
	/// </summary>
	public class StepChart : System.Windows.Forms.Form
	{
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.CheckBox chkShow3D;
		private System.Windows.Forms.NumericUpDown updnDepth;
		private System.Windows.Forms.Label labDepth;
		private System.Windows.Forms.Label labCoordInfo;
		private System.Windows.Forms.CheckBox chkAlpha;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public StepChart()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.chkShow3D = new System.Windows.Forms.CheckBox();
			this.updnDepth = new System.Windows.Forms.NumericUpDown();
			this.labDepth = new System.Windows.Forms.Label();
			this.labCoordInfo = new System.Windows.Forms.Label();
			this.chkAlpha = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.updnDepth)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.DataSource = null;
			this.c1Chart1.Location = new System.Drawing.Point(168, 48);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"PlotArea\" ParentName=\"Area\" StyleData=\"Border=None,Transparent,1;\" /><NamedSty" +
				"le Name=\"Legend\" ParentName=\"Legend.default\" StyleData=\"AlignHorz=Center;AlignVe" +
				"rt=Top;\" /><NamedStyle Name=\"Footer\" ParentName=\"Control\" StyleData=\"Border=None" +
				",Transparent,1;\" /><NamedStyle Name=\"Area\" ParentName=\"Area.default\" /><NamedSty" +
				"le Name=\"Control\" ParentName=\"Control.default\" /><NamedStyle Name=\"AxisX\" Parent" +
				"Name=\"Area\" StyleData=\"Rotation=Rotate0;AlignHorz=Center;AlignVert=Bottom;\" /><N" +
				"amedStyle Name=\"AxisY\" ParentName=\"Area\" StyleData=\"Rotation=Rotate270;AlignHorz" +
				"=Near;AlignVert=Center;\" /><NamedStyle Name=\"LabelStyleDefault\" ParentName=\"Labe" +
				"lStyleDefault.default\" /><NamedStyle Name=\"Legend.default\" ParentName=\"Control\" " +
				"StyleData=\"Border=None,Transparent,1;Wrap=False;AlignVert=Top;\" /><NamedStyle Na" +
				"me=\"LabelStyleDefault.default\" ParentName=\"Control\" StyleData=\"Border=None,Trans" +
				"parent,1;BackColor=Transparent;\" /><NamedStyle Name=\"Header\" ParentName=\"Control" +
				"\" StyleData=\"Border=None,Transparent,1;\" /><NamedStyle Name=\"Control.default\" Pa" +
				"rentName=\"\" StyleData=\"ForeColor=ControlText;Border=None,Transparent,1;BackColor" +
				"=Control;\" /><NamedStyle Name=\"AxisY2\" ParentName=\"Area\" StyleData=\"Rotation=Rot" +
				"ate90;AlignHorz=Far;AlignVert=Center;\" /><NamedStyle Name=\"Area.default\" ParentN" +
				"ame=\"Control\" StyleData=\"Border=None,Transparent,1;AlignVert=Top;\" /></StyleColl" +
				"ection><ChartGroupsCollection><ChartGroup Name=\"Group1\"><DataSerializer DefaultS" +
				"et=\"True\"><DataSeriesCollection><DataSeriesSerializer><LineStyle Color=\"DarkGold" +
				"enrod\" /><SymbolStyle Color=\"Coral\" Shape=\"Box\" /><SeriesLabel>series 0</SeriesL" +
				"abel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><DataTypes>Single;Single;Double;Double" +
				";Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSeriali" +
				"zer><DataSeriesSerializer><LineStyle Color=\"DarkGray\" /><SymbolStyle Color=\"Corn" +
				"flowerBlue\" Shape=\"Dot\" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>" +
				"8;12;10;12;15</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataF" +
				"ields>;;;;</DataFields><FillStyle /></DataSeriesSerializer><DataSeriesSerializer" +
				"><LineStyle Color=\"DarkGreen\" /><SymbolStyle Color=\"Cornsilk\" Shape=\"Tri\" /><Ser" +
				"iesLabel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>S" +
				"ingle;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillS" +
				"tyle /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"DarkKhaki\"" +
				" /><SymbolStyle Color=\"Crimson\" Shape=\"Diamond\" /><SeriesLabel>series 3</SeriesL" +
				"abel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><DataTypes>Single;Single;Double;Double" +
				";Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSeriali" +
				"zer></DataSeriesCollection></DataSerializer></ChartGroup><ChartGroup Name=\"Group" +
				"2\"><DataSerializer /></ChartGroup></ChartGroupsCollection><Header Compass=\"North" +
				"\" /><Footer Compass=\"South\" /><Legend Compass=\"East\" Visible=\"True\"><TooltipText" +
				">Legend</TooltipText></Legend><ChartArea /><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor" +
				"=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"T" +
				"rue\" Compass=\"South\"><GridMajor /><GridMinor /></Axis><Axis Max=\"26\" Min=\"8\" Uni" +
				"tMajor=\"2\" UnitMinor=\"1\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMi" +
				"n=\"True\" Compass=\"West\"><GridMajor /><GridMinor /></Axis><Axis Max=\"0\" Min=\"0\" U" +
				"nitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" Auto" +
				"Min=\"True\" Compass=\"East\"><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropB" +
				"ag>";
			this.c1Chart1.Size = new System.Drawing.Size(448, 400);
			this.c1Chart1.TabIndex = 0;
			this.c1Chart1.ToolTip.Enabled = true;
			this.c1Chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseMove);
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(168, 24);
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(448, 16);
			this.hScrollBar1.TabIndex = 1;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Location = new System.Drawing.Point(144, 40);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(16, 408);
			this.vScrollBar1.TabIndex = 2;
			this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
			// 
			// chkShow3D
			// 
			this.chkShow3D.Location = new System.Drawing.Point(8, 64);
			this.chkShow3D.Name = "chkShow3D";
			this.chkShow3D.Size = new System.Drawing.Size(112, 16);
			this.chkShow3D.TabIndex = 3;
			this.chkShow3D.Text = "Show 3D Effects";
			this.chkShow3D.CheckedChanged += new System.EventHandler(this.chkShow3D_CheckedChanged);
			// 
			// updnDepth
			// 
			this.updnDepth.Location = new System.Drawing.Point(80, 96);
			this.updnDepth.Maximum = new System.Decimal(new int[] {
																	  40,
																	  0,
																	  0,
																	  0});
			this.updnDepth.Minimum = new System.Decimal(new int[] {
																	  5,
																	  0,
																	  0,
																	  0});
			this.updnDepth.Name = "updnDepth";
			this.updnDepth.Size = new System.Drawing.Size(48, 20);
			this.updnDepth.TabIndex = 4;
			this.updnDepth.Value = new System.Decimal(new int[] {
																	5,
																	0,
																	0,
																	0});
			this.updnDepth.ValueChanged += new System.EventHandler(this.updnDepth_ValueChanged);
			// 
			// labDepth
			// 
			this.labDepth.Location = new System.Drawing.Point(8, 96);
			this.labDepth.Name = "labDepth";
			this.labDepth.Size = new System.Drawing.Size(56, 16);
			this.labDepth.TabIndex = 5;
			this.labDepth.Text = "3D Depth";
			// 
			// labCoordInfo
			// 
			this.labCoordInfo.Location = new System.Drawing.Point(16, 144);
			this.labCoordInfo.Name = "labCoordInfo";
			this.labCoordInfo.Size = new System.Drawing.Size(112, 120);
			this.labCoordInfo.TabIndex = 6;
			this.labCoordInfo.Text = "labCoordInfo";
			// 
			// chkAlpha
			// 
			this.chkAlpha.Location = new System.Drawing.Point(8, 32);
			this.chkAlpha.Name = "chkAlpha";
			this.chkAlpha.Size = new System.Drawing.Size(112, 16);
			this.chkAlpha.TabIndex = 7;
			this.chkAlpha.Text = "Use Alpha Color";
			this.chkAlpha.CheckedChanged += new System.EventHandler(this.chkAlpha_CheckedChanged);
			// 
			// StepChart
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.chkAlpha,
																		  this.labCoordInfo,
																		  this.labDepth,
																		  this.updnDepth,
																		  this.chkShow3D,
																		  this.vScrollBar1,
																		  this.hScrollBar1,
																		  this.c1Chart1});
			this.Name = "StepChart";
			this.Text = "StepChart";
			this.Resize += new System.EventHandler(this.StepChart_Resize);
			this.Load += new System.EventHandler(this.StepChart_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.updnDepth)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new StepChart());
		}

		private PointF[] GetData()
		{
			double [] xa = new double[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14};
			double [] ya = new double[] {0,1,2,double.NegativeInfinity  ,4,5,6,7,6,5, 4, double.NaN , 2, 1, 0};
			PointF[] pda = (PointF[])Array.CreateInstance(typeof(PointF),xa.Length);
			pda.Initialize();

			for(int i=0; i < xa.Length; i++)
			{
				pda[i] = new PointF((float)xa[i],(float)ya[i]);
			}

			return pda;
		}

		private PointF[] AdjustYValues(PointF[] pfa, float factor, float offset)
		{
			PointF[] pfa2 = (PointF[])Array.CreateInstance(typeof(PointF),pfa.Length);
			for(int i=0; i < pfa.Length; i++)
				pfa2[i] = new PointF(pfa[i].X, pfa[i].Y * factor + offset);

			return pfa2;
		}

		private void StepChart_Load(object sender, System.EventArgs e)
		{
			// position the controls
			hScrollBar1.Location = new Point(c1Chart1.Left, 0);
			vScrollBar1.Location = new Point(c1Chart1.Left - vScrollBar1.Width, hScrollBar1.Height);
			c1Chart1.Location = new Point(hScrollBar1.Left, vScrollBar1.Top);

			// set 3D effects scrollbars visibility
			bool is3d = chkShow3D.Checked;
			vScrollBar1.Visible = is3d;
			hScrollBar1.Visible = is3d;

			// set up the charts
			ChartGroup cg = c1Chart1.ChartGroups.Group0; 
			cg.Use3D = is3d;

			// ChartType is a Step chart.
			cg.ChartType = Chart2DTypeEnum.Step;

			ChartData cd = cg.ChartData;
			ChartDataSeriesCollection cdsc = cd.SeriesList;
			cdsc.Clear();		// remove existing data.

			// create some data using this application GetData() routine
			PointF[] pfa = GetData();

			// add the data to the chart
			ChartDataSeries cds = cdsc.AddNewSeries();
			cds.PointData.CopyDataIn(pfa);
			cds.LineStyle.Thickness = 3;
			cds.TooltipText = "Step0";
			cds.TooltipTextLegend = "Step0 Legend";
			cds.SymbolStyle.Size = 15;

			// add a second series using the application AdjustYValues
			// routine.  This data is similar to show behavior when
			// excluding the data holes found in the first data.
			cds = cdsc.AddNewSeries();
			cds.PointData.CopyDataIn(AdjustYValues(pfa, 1f, 2f));
			cds.LineStyle.Thickness = 3;
			cds.SymbolStyle.Size = 15;
			cds.TooltipText = "Step1";
			cds.TooltipTextLegend = "Step1 Legend";
			cds.Display = SeriesDisplayEnum.ExcludeHoles;
			
			// set up the 3D view object and scrollbars.  When
			// the 3D view is shown, the scrollbars can adjust
			// the angles.
			const int initialAngles = 30;
			View3D v3d = c1Chart1.ChartArea.PlotArea.View3D;
			v3d.Depth = initialAngles;
			v3d.Elevation =initialAngles;
			v3d.Rotation = initialAngles;

			hScrollBar1.Maximum = 45;
			hScrollBar1.Minimum = -45;
			hScrollBar1.Value = -initialAngles;

			vScrollBar1.Maximum = 45;
			vScrollBar1.Minimum = -45;
			vScrollBar1.Value = initialAngles;

			updnDepth.Value = initialAngles;
			labDepth.Visible = is3d;
			updnDepth.Visible = is3d;

			// in chart labels to label the scroll bars.
			C1.Win.C1Chart.LabelsCollection labs = c1Chart1.ChartLabels.LabelsCollection;
			C1.Win.C1Chart.Label lab = labs.AddNewLabel();
			lab.AttachMethod = AttachMethodEnum.Coordinate;
			lab.AttachMethodData.X = 1;
			lab.AttachMethodData.Y = 1;
			lab.Compass = LabelCompassEnum.SouthEast;
			lab.SizeDefault = new Size(c1Chart1.Size.Width, 12);
			lab.Style.HorizontalAlignment = AlignHorzEnum.Center;
			lab.Name = "hbar";
			lab.Text = "3D Rotation";
			lab.Visible = is3d;

			lab = labs.AddNewLabel();
			lab.AttachMethod = AttachMethodEnum.Coordinate;
			lab.AttachMethodData.X = 1;
			lab.AttachMethodData.Y = 1;
			lab.Compass = LabelCompassEnum.SouthEast;
			lab.SizeDefault = new Size(12, c1Chart1.Size.Height);
			lab.Style.Rotation = RotationEnum.Rotate270;
			lab.Style.HorizontalAlignment = AlignHorzEnum.Center;
			lab.Name = "vbar";
			lab.Text = "3D Elevation";
			lab.Visible = is3d;

			// set up the Chart header
			Title header = c1Chart1.Header;
			header.Style.Font = new Font("Arial Black", 16);
			header.Style.Border.BorderStyle = BorderStyleEnum.Solid;
			if(is3d)
				header.Text = "3D Step Chart";
			else
				header.Text = "2D Step Chart";

			// clear the position CoordInfo label
			labCoordInfo.Text = "";
			labCoordInfo.Visible = false;

			// force a resize to allow everything reposition.
			StepChart_Resize(null, null);
		}

		private void c1Chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ChartGroup cg = c1Chart1.ChartGroups[0];
			double xd = 0, yd = 0;
			int si=-1, pi=-1, dist=-1;
			
			bool res1 = cg.CoordToDataCoord(e.X,e.Y, ref xd, ref yd);
			if(!res1)
				return;

			cg.CoordToDataIndex(e.X,e.Y, CoordinateFocusEnum.XandYCoord, ref si, ref pi, ref dist);

			labCoordInfo.Text = "X,Y = " + xd.ToString("0.00") + " , " + yd.ToString("0.00") +
				"\r\n\r\nSeries = " + si.ToString() + "\r\n\r\nPoint = " + pi.ToString() +
				"\r\n\r\nDistance = " + dist.ToString();

			if(!labCoordInfo.Visible)
				labCoordInfo.Visible = true;
		}

		private void StepChart_Resize(object sender, System.EventArgs e)
		{
			int cw = ClientSize.Width - hScrollBar1.Left - 1;
			int ch = ClientSize.Height - vScrollBar1.Top - 1 ;

			if(cw < 10) cw = 10;
			if(ch < 10) ch = 10;

			hScrollBar1.Width = cw;
			vScrollBar1.Height = ch;

			c1Chart1.Size = new Size(cw,ch);

			LabelsCollection labs = c1Chart1.ChartLabels.LabelsCollection;
			if(labs.Count > 1)
			{
				if(chkShow3D.Checked)
				{
					labs["hbar"].Size = new Size(cw, 12);
					labs["vbar"].Size = new Size(12, ch);
				}
				
			}
		}

		private void vScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			c1Chart1.ChartArea.PlotArea.View3D.Elevation = e.NewValue;
		}

		private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			c1Chart1.ChartArea.PlotArea.View3D.Rotation = -e.NewValue;		
		}

		private void chkShow3D_CheckedChanged(object sender, System.EventArgs e)
		{
			bool is3d = chkShow3D.Checked;
			c1Chart1.ChartGroups[0].Use3D = is3d;
			hScrollBar1.Visible = is3d;
			vScrollBar1.Visible = is3d;
			labDepth.Visible = is3d;
			updnDepth.Visible = is3d;

			LabelsCollection labs = c1Chart1.ChartLabels.LabelsCollection;
			if(labs.Count > 0)
			{
				labs["hbar"].Visible = is3d;
				labs["vbar"].Visible = is3d;
			}

			// add and remove chart margins so there is room for chart labels
			Area area = c1Chart1.ChartArea;
			if(is3d)
			{
				area.Margins.Left = 10;
				area.Margins.Right = 10;
				c1Chart1.Header.Text = "3D Step Chart";
			}
			else
			{
				area.Margins.Left = 0;
				area.Margins.Right = 0;
				c1Chart1.Header.Text = "2D Step Chart";
			}
		}

		private void updnDepth_ValueChanged(object sender, System.EventArgs e)
		{
			c1Chart1.ChartArea.PlotArea.View3D.Depth = Convert.ToInt32(updnDepth.Value);
		}

		private void chkAlpha_CheckedChanged(object sender, System.EventArgs e)
		{
			int alpha;

			if(chkAlpha.Checked)
				alpha = 100;
			else
				alpha = 255;

			ChartDataSeriesCollection cdsc = c1Chart1.ChartGroups[0].ChartData.SeriesList;
			cdsc[0].LineStyle.Color = Color.FromArgb(alpha, cdsc[0].LineStyle.Color);
			cdsc[1].LineStyle.Color = Color.FromArgb(alpha, cdsc[1].LineStyle.Color);
		}
	}
}
