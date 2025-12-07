using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.C1Chart;

namespace AutoArrangement
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnArrange;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnCreateLine;
		private System.Windows.Forms.Button btnArrangeLine;
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnArrange = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnArrangeLine = new System.Windows.Forms.Button();
			this.btnCreateLine = new System.Windows.Forms.Button();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																							this.tabPage1,
																																							this.tabPage2});
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(120, 453);
			this.tabControl1.TabIndex = 1;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																					 this.btnArrange,
																																					 this.btnCreate});
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(112, 424);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Scatter";
			// 
			// btnArrange
			// 
			this.btnArrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnArrange.Location = new System.Drawing.Point(16, 56);
			this.btnArrange.Name = "btnArrange";
			this.btnArrange.TabIndex = 1;
			this.btnArrange.Text = "Arrange";
			this.btnArrange.Click += new System.EventHandler(this.btnArrange_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreate.Location = new System.Drawing.Point(16, 16);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "Create";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																																					 this.btnArrangeLine,
																																					 this.btnCreateLine});
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(112, 424);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Line";
			// 
			// btnArrangeLine
			// 
			this.btnArrangeLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnArrangeLine.Location = new System.Drawing.Point(16, 56);
			this.btnArrangeLine.Name = "btnArrangeLine";
			this.btnArrangeLine.TabIndex = 2;
			this.btnArrangeLine.Text = "Arrange";
			this.btnArrangeLine.Click += new System.EventHandler(this.btnArrangeLine_Click);
			// 
			// btnCreateLine
			// 
			this.btnCreateLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreateLine.Location = new System.Drawing.Point(16, 16);
			this.btnCreateLine.Name = "btnCreateLine";
			this.btnCreateLine.TabIndex = 0;
			this.btnCreateLine.Text = "Create";
			this.btnCreateLine.Click += new System.EventHandler(this.btnCreateLine_Click);
			// 
			// c1Chart1
			// 
			this.c1Chart1.BackColor = System.Drawing.SystemColors.Control;
			this.c1Chart1.DataSource = null;
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Location = new System.Drawing.Point(120, 0);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"PlotArea\" ParentName=\"Area\" StyleData=\"Border=Solid,ControlText,1;BackColor=Wh" +
				"iteSmoke;\" /><NamedStyle Name=\"Legend\" ParentName=\"Legend.default\" /><NamedStyle" +
				" Name=\"Footer\" ParentName=\"Control\" StyleData=\"Border=None,Transparent,1;\" /><Na" +
				"medStyle Name=\"Area\" ParentName=\"Area.default\" /><NamedStyle Name=\"Control\" Pare" +
				"ntName=\"Control.default\" StyleData=\"Border=Solid,Black,1;Rounding=10 10 10 10;\" " +
				"/><NamedStyle Name=\"AxisX\" ParentName=\"Area\" StyleData=\"Rotation=Rotate0;AlignHo" +
				"rz=Center;AlignVert=Bottom;\" /><NamedStyle Name=\"AxisY\" ParentName=\"Area\" StyleD" +
				"ata=\"Rotation=Rotate270;AlignHorz=Near;AlignVert=Center;\" /><NamedStyle Name=\"La" +
				"belStyleDefault\" ParentName=\"LabelStyleDefault.default\" /><NamedStyle Name=\"Lege" +
				"nd.default\" ParentName=\"Control\" StyleData=\"Border=None,Transparent,1;Wrap=False" +
				";AlignVert=Top;\" /><NamedStyle Name=\"LabelStyleDefault.default\" ParentName=\"Cont" +
				"rol\" StyleData=\"Border=None,Transparent,1;BackColor=Transparent;\" /><NamedStyle " +
				"Name=\"Header\" ParentName=\"Control\" StyleData=\"Border=None,Transparent,1;\" /><Nam" +
				"edStyle Name=\"Control.default\" ParentName=\"\" StyleData=\"ForeColor=ControlText;Bo" +
				"rder=None,Transparent,1;BackColor=Control;\" /><NamedStyle Name=\"AxisY2\" ParentNa" +
				"me=\"Area\" StyleData=\"Rotation=Rotate90;AlignHorz=Far;AlignVert=Center;\" /><Named" +
				"Style Name=\"Area.default\" ParentName=\"Control\" StyleData=\"Border=None,Transparen" +
				"t,1;AlignVert=Top;\" /></StyleCollection><ChartGroupsCollection><ChartGroup Name=" +
				"\"Group1\" Use3D=\"False\"><DataSerializer DefaultSet=\"True\"><DataSeriesCollection><" +
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
				"ss=\"South\" /><Legend Compass=\"East\" Visible=\"False\" /><ChartArea><Margin Top=\"0\"" +
				" Left=\"0\" Bottom=\"0\" Right=\"0\" /></ChartArea><Axes><Axis Max=\"5\" Min=\"1\" UnitMaj" +
				"or=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=" +
				"\"True\" Compass=\"South\"><SB Appearance=\"Flat\" Min=\"1\" Max=\"5\" /><GridMajor /><Gri" +
				"dMinor /></Axis><Axis Max=\"25\" Min=\"8\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"" +
				"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"West\"><GridMajor /" +
				"><GridMinor /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor" +
				"=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"East\"><GridMajor" +
				" /><GridMinor /></Axis></Axes></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(512, 453);
			this.c1Chart1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.c1Chart1,
																																	this.tabControl1});
			this.Name = "Form1";
			this.Text = "ComponentOne Chart.Net 2D - Auto Label Arrangement Chart Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
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

		private void btnCreate_Click(object sender, System.EventArgs e)
		{
			Size sz = c1Chart1.ChartArea.PlotArea.Size;
			int nseries = 35;

			if(sz.Width != -1)
				nseries = (sz.Width * sz.Height) / 5000;
			
			CreateScatterChart(nseries);
			btnArrange.Enabled = true;
		}

		Random _rnd = new Random();

		Color GetGradientColor( Color clr1, Color clr2, float rat)
		{
			int r = (int)clr1.R + (int)(((int)clr2.R - (int)clr1.R) * rat);
			int g = (int)clr1.G + (int)(((int)clr2.G - (int)clr1.G) * rat);
			int b = (int)clr1.B + (int)(((int)clr2.B - (int)clr1.B) * rat);

			return Color.FromArgb( r, g, b);
		}

		void CreateScatterChart( int nseries)
		{
			ChartData cd = c1Chart1.ChartGroups[0].ChartData;
			cd.SeriesList.Clear();

			ChartLabels lbls = c1Chart1.ChartLabels;
			lbls.LabelsCollection.Clear();

			for( int i=0; i<nseries; i++)
			{
				ChartDataSeries ds = cd.SeriesList.AddNewSeries();

				ds.X.Add( _rnd.Next( 100));
				ds.Y.Add( _rnd.Next( 100));

				ds.SymbolStyle.Color = GetGradientColor( Color.Red, Color.Blue, i / (nseries - 1.0f));
				ds.SymbolStyle.Shape = SymbolShapeEnum.Dot;

				C1.Win.C1Chart.Label lbl = lbls.LabelsCollection.AddNewLabel();
				lbl.Text = ds.Label;

				lbl.AttachMethod = AttachMethodEnum.DataIndex;
				lbl.AttachMethodData.GroupIndex = 0;
				lbl.AttachMethodData.SeriesIndex = i;
				lbl.AttachMethodData.PointIndex = 0;
				lbl.Offset = 1;
				lbl.Connected = true;
				lbl.Style.ForeColor = ds.SymbolStyle.Color;
				lbl.Style.BackColor = Color.White;
				lbl.Style.Border.BorderStyle = BorderStyleEnum.Solid;
				lbl.Visible = true;
			}

			c1Chart1.ChartArea.AxisX.ScrollBar.Visible = false;
			c1Chart1.ChartArea.AxisX.AutoMin = true;
			c1Chart1.ChartArea.AxisX.AutoMax = true;
		}

		private void btnArrange_Click(object sender, System.EventArgs e)
		{
			c1Chart1.ChartLabels.AutoArrangement.Options = AutoLabelArrangementOptions.Default;
			c1Chart1.ChartLabels.AutoArrangement.Method = AutoLabelArrangementMethodEnum.FindingOptimum;

			ChartLabels lbls = c1Chart1.ChartLabels;

			foreach( C1.Win.C1Chart.Label lbl in lbls.LabelsCollection)
				lbl.Compass = LabelCompassEnum.Auto;

			btnArrange.Enabled = false;
		}

		private void btnCreateLine_Click(object sender, System.EventArgs e)
		{
			CreateLineChart( 500);
		}

		void CreateLineChart( int npoints)
		{
			ChartData cd = c1Chart1.ChartGroups[0].ChartData;
			cd.SeriesList.Clear();

			ChartLabels lbls = c1Chart1.ChartLabels;
			lbls.LabelsCollection.Clear();

			int[] x = new int[npoints];
			int[] y = new int[npoints];

			ChartDataSeries ds = cd.SeriesList.AddNewSeries();
			ds.SymbolStyle.Shape = SymbolShapeEnum.None;
			ds.LineStyle.Color = Color.Blue;

			for( int i=0; i<npoints; i++)
			{
				x[i] = i;

				if( i==0)
					y[i] = _rnd.Next(1000);
				else
					y[i] = y[i-1] + ( _rnd.Next(1000) - 500) / 3;

				if( i % 5 == 0)
				{
					C1.Win.C1Chart.Label lbl = lbls.LabelsCollection.AddNewLabel();
					lbl.Text = y[i].ToString();

					lbl.AttachMethod = AttachMethodEnum.DataIndex;
					lbl.AttachMethodData.GroupIndex = 0;
					lbl.AttachMethodData.SeriesIndex = 0;
					lbl.AttachMethodData.PointIndex = i;
					lbl.Offset = 1;
					lbl.Connected = true;
					lbl.Style.ForeColor = Color.Red;
					lbl.Style.BackColor = Color.White;
					lbl.Style.Border.BorderStyle = BorderStyleEnum.Solid;
					lbl.Visible = true;
				}
			}

			ds.X.CopyDataIn( x);
			ds.Y.CopyDataIn( y);

			c1Chart1.ChartArea.AxisX.ScrollBar.Min = 0;
			c1Chart1.ChartArea.AxisX.ScrollBar.Max = 499;
			c1Chart1.ChartArea.AxisX.ScrollBar.Visible = true;

			btnArrangeLine.Enabled = true;
		}

		private void btnArrangeLine_Click(object sender, System.EventArgs e)
		{
			c1Chart1.ChartLabels.AutoArrangement.Method = C1.Win.C1Chart.AutoLabelArrangementMethodEnum.Decimation;
			c1Chart1.ChartLabels.AutoArrangement.Options =  
					AutoLabelArrangementOptions.Top | AutoLabelArrangementOptions.TopLeft | 
					AutoLabelArrangementOptions.TopRight;

			ChartLabels lbls = c1Chart1.ChartLabels;

			foreach( C1.Win.C1Chart.Label lbl in lbls.LabelsCollection)
				lbl.Compass = LabelCompassEnum.Auto;

			btnArrangeLine.Enabled = false;
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if( tabControl1.SelectedIndex == 0)
				btnCreate_Click( null, EventArgs.Empty);
			else if( tabControl1.SelectedIndex == 1)
				btnCreateLine_Click( null, EventArgs.Empty);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			btnCreate_Click( null, EventArgs.Empty);
		}
	}
}
