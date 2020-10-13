using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.C1Chart;

namespace CustomDraw
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label1;
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
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.DataSource = null;
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Interaction.Enabled = true;
			this.c1Chart1.Location = new System.Drawing.Point(150, 0);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"PlotArea\" ParentName=\"Area\" StyleData=\"GradientStyle=None;Border=Solid,Control" +
				"Text,1;BackColor2=;BackColor=DarkGray;Opaque=True;HatchStyle=None;\" /><NamedStyl" +
				"e Name=\"Legend\" ParentName=\"Legend.default\" /><NamedStyle Name=\"Footer\" ParentNa" +
				"me=\"Control\" StyleData=\"Border=None,Black,1;\" /><NamedStyle Name=\"Area\" ParentNa" +
				"me=\"Area.default\" /><NamedStyle Name=\"Control\" ParentName=\"Control.default\" Styl" +
				"eData=\"Border=Solid,Transparent,1;\" /><NamedStyle Name=\"AxisX\" ParentName=\"Area\"" +
				" StyleData=\"Rotation=Rotate0;AlignHorz=Center;AlignVert=Bottom;\" /><NamedStyle N" +
				"ame=\"AxisY\" ParentName=\"Area\" StyleData=\"Rotation=Rotate270;AlignHorz=Near;Align" +
				"Vert=Center;\" /><NamedStyle Name=\"LabelStyleDefault\" ParentName=\"LabelStyleDefau" +
				"lt.default\" /><NamedStyle Name=\"Legend.default\" ParentName=\"Control\" StyleData=\"" +
				"Border=None,Black,1;Wrap=False;AlignVert=Top;\" /><NamedStyle Name=\"LabelStyleDef" +
				"ault.default\" ParentName=\"Control\" StyleData=\"Border=None,Black,1;BackColor=Tran" +
				"sparent;\" /><NamedStyle Name=\"Header\" ParentName=\"Control\" StyleData=\"Border=Non" +
				"e,Black,1;\" /><NamedStyle Name=\"Control.default\" ParentName=\"\" StyleData=\"ForeCo" +
				"lor=ControlText;Border=None,Black,1;BackColor=Control;\" /><NamedStyle Name=\"Axis" +
				"Y2\" ParentName=\"Area\" StyleData=\"Rotation=Rotate90;AlignHorz=Far;AlignVert=Cente" +
				"r;\" /><NamedStyle Name=\"Area.default\" ParentName=\"Control\" StyleData=\"Border=Non" +
				"e,Black,1;AlignVert=Top;\" /></StyleCollection><ChartGroupsCollection><ChartGroup" +
				" Name=\"Group1\" Use3D=\"False\"><DataSerializer DefaultSet=\"True\"><DataSeriesCollec" +
				"tion><DataSeriesSerializer><LineStyle Color=\"DarkGoldenrod\" /><SymbolStyle Color" +
				"=\"Coral\" Shape=\"Box\" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;" +
				"22;19;24;25</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFie" +
				"lds>;;;;</DataFields><FillStyle /></DataSeriesSerializer><DataSeriesSerializer><" +
				"LineStyle Color=\"DarkGray\" /><SymbolStyle Color=\"CornflowerBlue\" Shape=\"Dot\" /><" +
				"SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><DataTypes" +
				">Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><Fil" +
				"lStyle /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"DarkGree" +
				"n\" /><SymbolStyle Color=\"Cornsilk\" Shape=\"Tri\" /><SeriesLabel>series 2</SeriesLa" +
				"bel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;Single;Double;Double;" +
				"Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSerializ" +
				"er><DataSeriesSerializer><LineStyle Color=\"DarkKhaki\" /><SymbolStyle Color=\"Crim" +
				"son\" Shape=\"Diamond\" /><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;" +
				"19;15;22;18</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFie" +
				"lds>;;;;</DataFields><FillStyle /></DataSeriesSerializer></DataSeriesCollection>" +
				"</DataSerializer></ChartGroup><ChartGroup Name=\"Group2\"><DataSerializer /></Char" +
				"tGroup></ChartGroupsCollection><Header Compass=\"North\" Visible=\"False\" /><Footer" +
				" Compass=\"South\" Visible=\"False\" /><Legend Compass=\"East\" Visible=\"False\" /><Cha" +
				"rtArea /><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"Tr" +
				"ue\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"South\"><GridMajor />" +
				"<GridMinor /></Axis><Axis Max=\"25\" Min=\"8\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMaj" +
				"or=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"West\"><GridMaj" +
				"or /><GridMinor /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoM" +
				"ajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"East\"><GridM" +
				"ajor /><GridMinor /></Axis></Axes></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(482, 453);
			this.c1Chart1.TabIndex = 0;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(8, 40);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(128, 42);
			this.trackBar1.TabIndex = 1;
			this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_ValueChanged);
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 2;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.trackBar1,
																		  this.c1Chart1});
			this.DockPadding.Left = 150;
			this.Name = "Form1";
			this.Text = "ComponentOne Chart.Net 2D - Custom Draw Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
			ChartData cd = c1Chart1.ChartGroups[0].ChartData;
			cd.SeriesList.Clear();

			// Create first data series
			ChartDataSeries ds1 = cd.SeriesList.AddNewSeries();

			int np = 200;
			PointF[] pa = new PointF[np];
			int i=0;
		
			// Generate data values
			for( i=0; i<np; i++)
			{
				pa[i].X = (float)( i * Math.Cos( 0.1*i));
				pa[i].Y = (float)( i * Math.Sin( 0.1*i));
			}
			ds1.PointData.CopyDataIn( pa);

			// Save points array
			ds1.Tag = pa;
			// Attach handler
			ds1.Draw += new DrawSeriesEventHandler( DataSeries_Draw);

			// Create second data series
			ChartDataSeries ds2 = cd.SeriesList.AddNewSeries();
			PointF[] pa2 = new PointF[np];

			// Generate data values
			for( i=np-1; i>=0; i--)
			{
				pa2[i].X = -(float)( i * Math.Cos( 0.1*i));
				pa2[i].Y = -(float)( i * Math.Sin( 0.1*i));
			}
			ds2.PointData.CopyDataIn( pa2);

			// Save points array
			ds2.Tag = pa2;
			// Attach handler
			ds2.Draw += new DrawSeriesEventHandler( DataSeries_Draw);

			// Setup track bar properties
			trackBar1.Minimum = 0;
			trackBar1.Maximum = 100;
			trackBar1.TickFrequency = 5;
			trackBar1.Value = 50;
		}

		private void DataSeries_Draw( object sender, DrawSeriesEventArgs e)
		{
			ChartDataSeries ds = e.Series;
			Graphics g = e.Graphics;
			ChartGroup cg = ds.Group;

			// Get the point array
			PointF[] pa = (PointF[])ds.Tag;
			int np = pa.Length;

			Pen pen = new Pen( Color.Black, 3);

			float x1 = 0, y1 = 0, x2 = 0, y2 = 0;

			// Index at which the color is changed
			int ichange = (int) Math.Round( np * trackBar1.Value * 0.01);

			ds.Group.DataCoordToCoord( pa[0].X, pa[0].Y, ref x1, ref y1);

			for( int i=0; i<np-1; i++)
			{
				// Change the color
				if( i>=ichange)
					pen.Color = Color.White;

				// Calculate cooredinates
				cg.DataCoordToCoord( pa[i+1].X, pa[i+1].Y, ref x2, ref y2);
				
				// Draw line
				g.DrawLine( pen, x1, y1, x2, y2);
				x1 = x2; y1 = y2;
			}

			pen.Dispose();

			// Cancel rendering, it's already done
			e.Cancel = true;
		}

		private void trackBar1_ValueChanged(object sender, System.EventArgs e)
		{
			// Redraw chart and label
			c1Chart1.Invalidate();
			label1.Text = string.Format( "{0} %", trackBar1.Value);
		}
	}
}
