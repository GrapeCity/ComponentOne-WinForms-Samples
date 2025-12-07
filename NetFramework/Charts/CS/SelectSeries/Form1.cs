using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.C1Chart;

namespace SelectSeries
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label2,
																				 this.label1});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(160, 453);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(8, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "Use mouse to select series";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Selection: none";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.c1Chart1});
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(160, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(472, 453);
			this.panel2.TabIndex = 1;
			// 
			// c1Chart1
			// 
			this.c1Chart1.DataSource = null;
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"PlotArea\" ParentName=\"Area\" StyleData=\"Border=Solid,ControlText,1;BackColor=Wh" +
				"iteSmoke;\" /><NamedStyle Name=\"Legend\" ParentName=\"Legend.default\" StyleData=\"Bo" +
				"rder=Solid,Black,1;AlignHorz=Center;BackColor=WhiteSmoke;AlignVert=Top;Rounding=" +
				"10 0 10 0;\" /><NamedStyle Name=\"Footer\" ParentName=\"Control\" StyleData=\"Border=N" +
				"one,Black,1;\" /><NamedStyle Name=\"Area\" ParentName=\"Area.default\" /><NamedStyle " +
				"Name=\"Control\" ParentName=\"Control.default\" /><NamedStyle Name=\"AxisX\" ParentNam" +
				"e=\"Area\" StyleData=\"Rotation=Rotate0;AlignHorz=Center;AlignVert=Bottom;\" /><Name" +
				"dStyle Name=\"AxisY\" ParentName=\"Area\" StyleData=\"Rotation=Rotate270;AlignHorz=Ne" +
				"ar;AlignVert=Center;\" /><NamedStyle Name=\"LabelStyleDefault\" ParentName=\"LabelSt" +
				"yleDefault.default\" /><NamedStyle Name=\"Legend.default\" ParentName=\"Control\" Sty" +
				"leData=\"Border=None,Black,1;Wrap=False;AlignVert=Top;\" /><NamedStyle Name=\"Label" +
				"StyleDefault.default\" ParentName=\"Control\" StyleData=\"Border=None,Black,1;BackCo" +
				"lor=Transparent;\" /><NamedStyle Name=\"Header\" ParentName=\"Control\" StyleData=\"Bo" +
				"rder=None,Black,1;\" /><NamedStyle Name=\"Control.default\" ParentName=\"\" StyleData" +
				"=\"ForeColor=ControlText;Border=None,Black,1;BackColor=Control;\" /><NamedStyle Na" +
				"me=\"AxisY2\" ParentName=\"Area\" StyleData=\"Rotation=Rotate90;AlignHorz=Far;AlignVe" +
				"rt=Center;\" /><NamedStyle Name=\"Area.default\" ParentName=\"Control\" StyleData=\"Bo" +
				"rder=None,Black,1;AlignVert=Top;\" /></StyleCollection><ChartGroupsCollection><Ch" +
				"artGroup Name=\"Group1\"><DataSerializer DefaultSet=\"True\"><DataSeriesCollection><" +
				"DataSeriesSerializer><LineStyle Color=\"DarkGoldenrod\" /><SymbolStyle Color=\"Cora" +
				"l\" Shape=\"Box\" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;" +
				"24;25</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;" +
				";;</DataFields><FillStyle /></DataSeriesSerializer><DataSeriesSerializer><LineSt" +
				"yle Color=\"DarkGray\" /><SymbolStyle Color=\"CornflowerBlue\" Shape=\"Dot\" /><Series" +
				"Label>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><DataTypes>Singl" +
				"e;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle" +
				" /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"DarkGreen\" /><" +
				"SymbolStyle Color=\"Cornsilk\" Shape=\"Tri\" /><SeriesLabel>series 2</SeriesLabel><X" +
				">1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;Single;Double;Double;Double" +
				"</DataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSerializer><Da" +
				"taSeriesSerializer><LineStyle Color=\"DarkKhaki\" /><SymbolStyle Color=\"Crimson\" S" +
				"hape=\"Diamond\" /><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;" +
				"22;18</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;" +
				";;</DataFields><FillStyle /></DataSeriesSerializer></DataSeriesCollection></Data" +
				"Serializer></ChartGroup><ChartGroup Name=\"Group2\"><DataSerializer /></ChartGroup" +
				"></ChartGroupsCollection><Header Compass=\"North\" Visible=\"False\" /><Footer Compa" +
				"ss=\"South\" Visible=\"False\" /><Legend Compass=\"East\" Visible=\"True\" /><ChartArea " +
				"/><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" Aut" +
				"oMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"South\"><GridMajor /><GridMi" +
				"nor /></Axis><Axis Max=\"25\" Min=\"8\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"Tru" +
				"e\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"West\"><GridMajor Visi" +
				"ble=\"True\" Spacing=\"1\" /><GridMinor /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\"" +
				" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" C" +
				"ompass=\"East\"><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(470, 451);
			this.c1Chart1.TabIndex = 0;
			this.c1Chart1.Click += new System.EventHandler(this.c1Chart1_Click);
			this.c1Chart1.Load += new System.EventHandler(this.c1Chart1_Load);
			this.c1Chart1.DrawLegendEntry += new C1.Win.C1Chart.DrawLegendEntryEventHandler(this.c1Chart1_DrawLegendEntry);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel2,
																		  this.panel1});
			this.Name = "Form1";
			this.Text = "ComponentOne Chart.Net 2D - Select Series Demo";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
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

		Color selectionColor = Color.Red;

		// Series colors
		Color[] clrs = { Color.Blue, Color.DarkGreen, Color.Brown, Color.BlueViolet};
		Random rnd = new Random();
		int selectedIndex = -1;

		private ChartDataSeries CreateSeries( ChartData cd, double scale, Color clr)
		{
			int np = 150;
			double[] x = new double[np];
			double[] y = new double[np];

			ChartDataSeries ds = cd.SeriesList.AddNewSeries();

			// Create some data
			for( int i=0; i<np; i++)
			{
				double r = rnd.NextDouble();
				x[i] = scale*( 1 + r * Math.Sin( 0.1*i ) * Math.Sin( 0.6*rnd.NextDouble()*i));
				y[i] = i;
			}

			// Copy data values
			ds.X.CopyDataIn( x);
			ds.Y.CopyDataIn( y);

			// No symbols
			ds.SymbolStyle.Shape = SymbolShapeEnum.None;
			ds.LineStyle.Color = clr;

			return ds;
		}

		private void c1Chart1_Load(object sender, System.EventArgs e)
		{
			ChartData cd = c1Chart1.ChartGroups[0].ChartData;
			cd.SeriesList.Clear();

			// Create sample data
			CreateSeries( cd, 5, clrs[0]);
			CreateSeries( cd, 10, clrs[1]);
			CreateSeries( cd, 15, clrs[2]);
			CreateSeries( cd, 20, clrs[3]);

			// Setup scroll bar
			c1Chart1.ChartArea.AxisY.ScrollBar.Min = cd.MinY;
			c1Chart1.ChartArea.AxisY.ScrollBar.Max = cd.MaxY;
			c1Chart1.ChartArea.AxisY.ScrollBar.Appearance = ScrollBarAppearanceEnum.Flat;
			c1Chart1.ChartArea.AxisY.ScrollBar.Visible = true;
			c1Chart1.ChartArea.AxisY.ScrollBar.Scale = 0.5;
		}

		private void c1Chart1_Click(object sender, System.EventArgs e)
		{
			Point p = Control.MousePosition;

			// Convert to client coordinates
			p = c1Chart1.PointToClient( p);

			int si = -1; int d = -1;

			// Find the distance
			if( c1Chart1.ChartGroups[0].CoordToSeriesIndex( p.X, p.Y, PlotElementEnum.Series, ref si, ref d))
			{
				if( d <= 3) // if close enough
				{
					if( si != selectedIndex) // Another index
					{
						if( selectedIndex != -1)
						{
							// Change series color and width to the default
							ChartDataSeries ds = c1Chart1.ChartGroups[0].ChartData[selectedIndex];
							ds.LineStyle.Color = clrs[selectedIndex];
							ds.LineStyle.Thickness = 1;
						}

						selectedIndex = si;
						if( selectedIndex != -1)
						{
							// Change series color and width to indicate selection
							ChartDataSeries ds = c1Chart1.ChartGroups[0].ChartData[selectedIndex];
							ds.LineStyle.Color = selectionColor;
							ds.LineStyle.Thickness = 2;
						}

						// Show status label
						if( selectedIndex < 0)
							label1.Text = "Selection: none";
						else
							label1.Text = "Selection: " + c1Chart1.ChartGroups[0].ChartData[selectedIndex].Label;
					}
				}
			}
		}

		private void c1Chart1_DrawLegendEntry(object sender, C1.Win.C1Chart.DrawLegendEntryEventArgs e)
		{
			ChartDataSeries ds = (ChartDataSeries)e.Entry;

			// Draw legend text using selection color
			if( ds!=null && ds.Group.ChartData.SeriesList.IndexOf(ds) == selectedIndex)
				e.TextColor = selectionColor;
		}
	}
}
