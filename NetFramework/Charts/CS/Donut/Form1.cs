using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1Chart;

namespace Donut
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.TrackBar tbarDepth;
		private System.Windows.Forms.TrackBar tbarElevation;
		private System.Windows.Forms.Button bRotateCounterClockwise;
		private System.Windows.Forms.Button bRotateClockwise;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chkAlpha;
		private System.Windows.Forms.CheckBox chkAntiAlias;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar tbarHoleRadius;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.tbarDepth = new System.Windows.Forms.TrackBar();
			this.tbarElevation = new System.Windows.Forms.TrackBar();
			this.bRotateCounterClockwise = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.bRotateClockwise = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.chkAlpha = new System.Windows.Forms.CheckBox();
			this.chkAntiAlias = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbarHoleRadius = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbarDepth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbarElevation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbarHoleRadius)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.DataSource = null;
			this.c1Chart1.Location = new System.Drawing.Point(176, 0);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"PlotArea\" ParentName=\"Area\" StyleData=\"Border=None,Transparent,1;\" /><NamedSty" +
				"le Name=\"Legend\" ParentName=\"Legend.default\" /><NamedStyle Name=\"Footer\" ParentN" +
				"ame=\"Control\" StyleData=\"Border=None,Transparent,1;\" /><NamedStyle Name=\"Area\" P" +
				"arentName=\"Area.default\" /><NamedStyle Name=\"Control\" ParentName=\"Control.defaul" +
				"t\" /><NamedStyle Name=\"AxisX\" ParentName=\"Area\" StyleData=\"Rotation=Rotate0;Alig" +
				"nHorz=Center;AlignVert=Bottom;\" /><NamedStyle Name=\"AxisY\" ParentName=\"Area\" Sty" +
				"leData=\"Rotation=Rotate270;AlignHorz=Near;AlignVert=Center;\" /><NamedStyle Name=" +
				"\"LabelStyleDefault\" ParentName=\"LabelStyleDefault.default\" /><NamedStyle Name=\"L" +
				"egend.default\" ParentName=\"Control\" StyleData=\"Border=None,Transparent,1;Wrap=Fa" +
				"lse;AlignVert=Top;\" /><NamedStyle Name=\"LabelStyleDefault.default\" ParentName=\"C" +
				"ontrol\" StyleData=\"Border=None,Transparent,1;BackColor=Transparent;\" /><NamedSty" +
				"le Name=\"Header\" ParentName=\"Control\" StyleData=\"Border=None,Transparent,1;\" /><" +
				"NamedStyle Name=\"Control.default\" ParentName=\"\" StyleData=\"ForeColor=ControlText" +
				";Border=None,Transparent,1;BackColor=Control;\" /><NamedStyle Name=\"AxisY2\" Paren" +
				"tName=\"Area\" StyleData=\"Rotation=Rotate90;AlignHorz=Far;AlignVert=Center;\" /><Na" +
				"medStyle Name=\"Area.default\" ParentName=\"Control\" StyleData=\"Border=None,Transpa" +
				"rent,1;AlignVert=Top;\" /></StyleCollection><ChartGroupsCollection><ChartGroup Na" +
				"me=\"Group1\"><DataSerializer DefaultSet=\"True\"><DataSeriesCollection><DataSeriesS" +
				"erializer><LineStyle Color=\"DarkGoldenrod\" /><SymbolStyle Color=\"Coral\" Shape=\"B" +
				"ox\" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><D" +
				"ataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFie" +
				"lds><FillStyle /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"" +
				"DarkGray\" /><SymbolStyle Color=\"CornflowerBlue\" Shape=\"Dot\" /><SeriesLabel>serie" +
				"s 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><DataTypes>Single;Single;Do" +
				"uble;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSe" +
				"riesSerializer><DataSeriesSerializer><LineStyle Color=\"DarkGreen\" /><SymbolStyle" +
				" Color=\"Cornsilk\" Shape=\"Tri\" /><SeriesLabel>series 2</SeriesLabel><X>1;2;3;4;5<" +
				"/X><Y>10;16;17;15;23</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes" +
				"><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSerializer><DataSeriesSer" +
				"ializer><LineStyle Color=\"DarkKhaki\" /><SymbolStyle Color=\"Crimson\" Shape=\"Diamo" +
				"nd\" /><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><D" +
				"ataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFie" +
				"lds><FillStyle /></DataSeriesSerializer></DataSeriesCollection></DataSerializer>" +
				"</ChartGroup><ChartGroup Name=\"Group2\"><DataSerializer /></ChartGroup></ChartGro" +
				"upsCollection><Header Compass=\"North\" /><Footer Compass=\"South\" /><Legend Compas" +
				"s=\"East\" Visible=\"False\" /><ChartArea /><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1" +
				"\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True" +
				"\" Compass=\"South\"><GridMajor /><GridMinor /></Axis><Axis Max=\"26\" Min=\"8\" UnitMa" +
				"jor=\"2\" UnitMinor=\"1\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"" +
				"True\" Compass=\"West\"><GridMajor /><GridMinor /></Axis><Axis Max=\"0\" Min=\"0\" Unit" +
				"Major=\"0\" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin" +
				"=\"True\" Compass=\"East\"><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropBag>" +
				"";
			this.c1Chart1.Size = new System.Drawing.Size(352, 360);
			this.c1Chart1.TabIndex = 0;
			// 
			// tbarDepth
			// 
			this.tbarDepth.Location = new System.Drawing.Point(8, 24);
			this.tbarDepth.Name = "tbarDepth";
			this.tbarDepth.Size = new System.Drawing.Size(152, 42);
			this.tbarDepth.TabIndex = 1;
			this.tbarDepth.Scroll += new System.EventHandler(this.tbarDepth_Scroll);
			// 
			// tbarElevation
			// 
			this.tbarElevation.Location = new System.Drawing.Point(8, 104);
			this.tbarElevation.Name = "tbarElevation";
			this.tbarElevation.Size = new System.Drawing.Size(152, 42);
			this.tbarElevation.TabIndex = 2;
			this.tbarElevation.Scroll += new System.EventHandler(this.tbarElevation_Scroll);
			// 
			// bRotateCounterClockwise
			// 
			this.bRotateCounterClockwise.Image = ((System.Drawing.Bitmap)(resources.GetObject("bRotateCounterClockwise.Image")));
			this.bRotateCounterClockwise.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.bRotateCounterClockwise.ImageIndex = 1;
			this.bRotateCounterClockwise.ImageList = this.imageList1;
			this.bRotateCounterClockwise.Location = new System.Drawing.Point(8, 248);
			this.bRotateCounterClockwise.Name = "bRotateCounterClockwise";
			this.bRotateCounterClockwise.Size = new System.Drawing.Size(72, 72);
			this.bRotateCounterClockwise.TabIndex = 3;
			this.bRotateCounterClockwise.Text = "Counter Clockwise";
			this.bRotateCounterClockwise.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bRotateCounterClockwise.Click += new System.EventHandler(this.bRotateCounterClockwise_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(72, 36);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.White;
			// 
			// bRotateClockwise
			// 
			this.bRotateClockwise.Image = ((System.Drawing.Bitmap)(resources.GetObject("bRotateClockwise.Image")));
			this.bRotateClockwise.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.bRotateClockwise.ImageIndex = 0;
			this.bRotateClockwise.ImageList = this.imageList1;
			this.bRotateClockwise.Location = new System.Drawing.Point(88, 248);
			this.bRotateClockwise.Name = "bRotateClockwise";
			this.bRotateClockwise.Size = new System.Drawing.Size(72, 72);
			this.bRotateClockwise.TabIndex = 4;
			this.bRotateClockwise.Text = "Clockwise";
			this.bRotateClockwise.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bRotateClockwise.Click += new System.EventHandler(this.bRotateClockwise_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Depth Adjustment";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Elevation Adjustment";
			// 
			// chkAlpha
			// 
			this.chkAlpha.Checked = true;
			this.chkAlpha.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAlpha.Location = new System.Drawing.Point(8, 336);
			this.chkAlpha.Name = "chkAlpha";
			this.chkAlpha.Size = new System.Drawing.Size(144, 16);
			this.chkAlpha.TabIndex = 7;
			this.chkAlpha.Text = "Use Alpha Blending";
			this.chkAlpha.CheckedChanged += new System.EventHandler(this.chkAlpha_CheckedChanged);
			// 
			// chkAntiAlias
			// 
			this.chkAntiAlias.Location = new System.Drawing.Point(8, 360);
			this.chkAntiAlias.Name = "chkAntiAlias";
			this.chkAntiAlias.Size = new System.Drawing.Size(144, 24);
			this.chkAntiAlias.TabIndex = 0;
			this.chkAntiAlias.Text = "Use AntiAliasing";
			this.chkAntiAlias.CheckedChanged += new System.EventHandler(this.chkAntiAlias_CheckedChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Donut Hole Radius";
			// 
			// tbarHoleRadius
			// 
			this.tbarHoleRadius.Location = new System.Drawing.Point(8, 184);
			this.tbarHoleRadius.Name = "tbarHoleRadius";
			this.tbarHoleRadius.Size = new System.Drawing.Size(144, 42);
			this.tbarHoleRadius.TabIndex = 9;
			this.tbarHoleRadius.Scroll += new System.EventHandler(this.tbarHoleRadius_Scroll);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tbarHoleRadius,
																		  this.label3,
																		  this.chkAntiAlias,
																		  this.chkAlpha,
																		  this.label2,
																		  this.label1,
																		  this.bRotateClockwise,
																		  this.bRotateCounterClockwise,
																		  this.tbarElevation,
																		  this.tbarDepth,
																		  this.c1Chart1});
			this.Name = "Form1";
			this.Text = "Form1";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbarDepth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbarElevation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbarHoleRadius)).EndInit();
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
			ChartGroup cg = c1Chart1.ChartGroups.Group0;

			// a donut is a Pie chart with a non-zero inner radius.
			cg.ChartType = Chart2DTypeEnum.Pie;

			// the inner radius is specified as a percentage of the pie radius
			cg.Pie.InnerRadius = 30;

			// create a single donut from the existing data.
			ChartDataSeriesCollection cdsc = cg.ChartData.SeriesList;
			foreach(ChartDataSeries cds in cdsc)
			{
				// give the first series an offset
				if(cds.Label == "series 0")
					cds.Offset = 30;

				// reduce each series to a single point for 1 donut.
				if(cds.Length > 1)
					cds.PointData.Length = 1;

				// use alpha blending to show the internals
				cds.FillStyle.Alpha = 100;

				// provide the ToolTip text
				cds.TooltipText = "Slice {#ISERIES}";
			}

			// give the donut some depth and elevation
			View3D v = c1Chart1.ChartArea.PlotArea.View3D;
			v.Depth = 10;
			v.Elevation = 45;

			// turn on the tooltips
			c1Chart1.ToolTip.Enabled = true;

			// turn on highlighting
			cg.ChartData.HighLight.Activation = HighlightActivationEnum.MouseOver;

			// add a legend
			c1Chart1.Legend.Visible = true;

			// add some color and borders
			Style sty = c1Chart1.Style;
			sty.GradientStyle = GradientStyleEnum.HorizontalCenter;
			sty.BackColor = Color.White;
			sty.BackColor2 = Color.LightBlue;
			Border bord = sty.Border;
			bord.BorderStyle = BorderStyleEnum.Solid;
			bord.Rounding.All = 10;
			bord.Thickness = 3;
			bord.Color = Color.Blue;

			// turn off color in legend and chart area so the gradient
			// is not inheritted - it looks odd
			sty = c1Chart1.Legend.Style;
			sty.BackColor = Color.Transparent;
			sty.GradientStyle = GradientStyleEnum.None;

			sty = c1Chart1.ChartArea.Style;
			sty.BackColor = Color.Transparent;
			sty.GradientStyle = GradientStyleEnum.None;

			// force a resize
			Form1_Resize(null, null);


			// initialize the TBars
			tbarDepth.Maximum = 50;
			tbarDepth.Minimum = 0;
			tbarDepth.Value = c1Chart1.ChartArea.PlotArea.View3D.Depth;

			tbarElevation.Maximum = 50;
			tbarElevation.Minimum = 5;
			tbarElevation.Value = c1Chart1.ChartArea.PlotArea.View3D.Elevation;

			tbarHoleRadius.Maximum = 90;
			tbarHoleRadius.Minimum = 0;
			tbarHoleRadius.Value = c1Chart1.ChartGroups.Group0.Pie.InnerRadius;
		}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
			int w = ClientSize.Width - c1Chart1.Left;
			int h = ClientSize.Height;

			if(w < 10) w = 10;
			if(h < 10) h = 10;

			c1Chart1.Size = new Size(w,h);
		}

		private void tbarDepth_Scroll(object sender, System.EventArgs e)
		{
			c1Chart1.ChartArea.PlotArea.View3D.Depth = tbarDepth.Value;
		}

		private void tbarElevation_Scroll(object sender, System.EventArgs e)
		{
			c1Chart1.ChartArea.PlotArea.View3D.Elevation = tbarElevation.Value;
		}

		private void tbarHoleRadius_Scroll(object sender, System.EventArgs e)
		{
			c1Chart1.ChartGroups.Group0.Pie.InnerRadius = tbarHoleRadius.Value;
		}

		private void bRotateCounterClockwise_Click(object sender, System.EventArgs e)
		{
			Pie pie = c1Chart1.ChartGroups.Group0.Pie;
			pie.Start = (pie.Start + 10) % 360;
		}

		private void bRotateClockwise_Click(object sender, System.EventArgs e)
		{
			Pie pie = c1Chart1.ChartGroups.Group0.Pie;
			pie.Start = (pie.Start + 350) % 360;		
		}

		private void chkAlpha_CheckedChanged(object sender, System.EventArgs e)
		{
			bool useAlpha = chkAlpha.Checked;
			ChartDataSeriesCollection cdsc = c1Chart1.ChartGroups[0].ChartData.SeriesList;
			foreach(ChartDataSeries cds in cdsc)
			{
				if(useAlpha && cds.FillStyle.Alpha == 255)
					cds.FillStyle.Alpha = 100;
				else if(cds.FillStyle.Alpha < 255)
					cds.FillStyle.Alpha = 255;
			}
		}

		private void chkAntiAlias_CheckedChanged(object sender, System.EventArgs e)
		{
			c1Chart1.UseAntiAliasedGraphics = chkAntiAlias.Checked;
		}
	}
}
