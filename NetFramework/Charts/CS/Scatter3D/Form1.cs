using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.C1Chart3D;

namespace Scatter3D
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1Chart3D.C1Chart3D c1Chart3D1;
		int step =0;
		int npoints = 30;
		bool loaded = false;

		Chart3DDataSetPoint pset = new Chart3DDataSetPoint();
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox cbLegend;
		private System.Windows.Forms.CheckBox cbMotion;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.CheckBox cbLabels;
		private System.Windows.Forms.CheckBox cbPaths;
		private System.Windows.Forms.CheckBox cbAxes;
		private System.Windows.Forms.CheckBox cbLines;
		private System.Windows.Forms.CheckBox cbDepth;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			InitializeComponent();
		}

		void initData()
		{
			Chart3DPoint[] pts = (Chart3DPoint[]) Array.CreateInstance( typeof(Chart3DPoint), 1);
			pset.AddSeries( pts);
			pset.AddSeries( pts);
			pset.AddSeries( pts);

			Chart3DPoint[] pts0 = (Chart3DPoint[]) Array.CreateInstance( typeof(Chart3DPoint), npoints);
			Chart3DPoint[] pts1 = (Chart3DPoint[]) Array.CreateInstance( typeof(Chart3DPoint), npoints);
			Chart3DPoint[] pts2 = (Chart3DPoint[]) Array.CreateInstance( typeof(Chart3DPoint), npoints);

			for( int i=0; i<npoints-1; i++)
			{
				float c = (float)(10 * Math.Cos( i * 2 * Math.PI / npoints-1));
				float s = (float)(10 * Math.Sin( i * 2 * Math.PI / npoints-1));
				
				pts0[i].X = c;
				pts0[i].Y = 0;
				pts0[i].Z = s;

				pts1[i].X = c;
				pts1[i].Y = s;
				pts1[i].Z = 0;

				pts2[i].X = 0;
				pts2[i].Y = s;
				pts2[i].Z = c;
			}

			pts0[npoints-1] = pts0[0];
			pts1[npoints-1] = pts1[0];
			pts2[npoints-1] = pts2[0];

			pset.AddSeries( pts0);
			pset.AddSeries( pts1);
			pset.AddSeries( pts2);

			pset.SeriesCollection[3].Connected = true;
			pset.SeriesCollection[4].Connected = true;
			pset.SeriesCollection[5].Connected = true;

			c1Chart3D1.ChartGroups[0].ChartData.Set = pset;
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
			this.c1Chart3D1 = new C1.Win.C1Chart3D.C1Chart3D();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbLabels = new System.Windows.Forms.CheckBox();
			this.cbMotion = new System.Windows.Forms.CheckBox();
			this.cbLegend = new System.Windows.Forms.CheckBox();
			this.cbPaths = new System.Windows.Forms.CheckBox();
			this.cbAxes = new System.Windows.Forms.CheckBox();
			this.cbLines = new System.Windows.Forms.CheckBox();
			this.cbDepth = new System.Windows.Forms.CheckBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// c1Chart3D1
			// 
			this.c1Chart3D1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.c1Chart3D1.Location = new System.Drawing.Point(120, 0);
			this.c1Chart3D1.Name = "c1Chart3D1";
			this.c1Chart3D1.PropBag = "<?xml version=\"1.0\"?><Chart3DPropBag Version=\"\"><LabelsCollection><Chart3DLabel C" +
				"onnected=\"True\" AttachMethod=\"DataIndex\" LabelCompass=\"NorthEast\" StyleName=\"Sty" +
				"le1\" Offset=\"20\" Compass=\"North\" Text=\"1\"><AttachMethodData PointIndex=\"0\" Serie" +
				"sIndex=\"0\" /></Chart3DLabel><Chart3DLabel Connected=\"True\" AttachMethod=\"DataInd" +
				"ex\" LabelCompass=\"NorthEast\" StyleName=\"Style2\" Offset=\"20\" Compass=\"North\" Text" +
				"=\"2\"><AttachMethodData PointIndex=\"0\" SeriesIndex=\"1\" /></Chart3DLabel><Chart3DL" +
				"abel Connected=\"True\" AttachMethod=\"DataIndex\" LabelCompass=\"NorthEast\" StyleNam" +
				"e=\"Style3\" Offset=\"20\" Compass=\"North\" Text=\"3\"><AttachMethodData PointIndex=\"0\"" +
				" SeriesIndex=\"2\" /></Chart3DLabel></LabelsCollection><View BackColor=\"DarkGray\" " +
				"PreviewMethod=\"PreviewFull\" IsInteractive=\"True\" /><ChartGroupsCollection><Chart" +
				"3DGroup ChartType=\"Scatter\"><ChartData><Set type=\"Chart3DDataSetGrid\" RowOrigin=" +
				"\"0\" RowDelta=\"1\" RowCount=\"11\" ColumnCount=\"11\" ColumnDelta=\"1\" ColumnOrigin=\"0\"" +
				" Hole=\"3.40282347E+38\"><Data>4.5 3.6 2.89999986 2.39999986 2.1 1.99999988 2.1 2." +
				"39999986 2.89999986 3.6 4.5 8.1 7.2 6.5 6 5.7 5.6 5.7 6 6.5 7.2 8.1 10.9 10 9.3 " +
				"8.8 8.5 8.4 8.5 8.8 9.3 10 10.9 12.9 12 11.3 10.8 10.5 10.4 10.5 10.8 11.3 12 12" +
				".9 14.1 13.2 12.5 12 11.7 11.6 11.7 12 12.5 13.2 14.1 14.5 13.6 12.9 12.4 12.1 1" +
				"2 12.1 12.4 12.9 13.6 14.5 14.1 13.2 12.5 12 11.7 11.6 11.7 12 12.5 13.2 14.1 12" +
				".9 12 11.3 10.8 10.5 10.4 10.5 10.8 11.3 12 12.9 10.9 10 9.3 8.8 8.5 8.4 8.5 8.8" +
				" 9.3 10 10.9 8.1 7.2 6.5 6 5.7 5.6 5.7 6 6.5 7.2 8.1 4.5 3.6 2.89999986 2.399999" +
				"86 2.1 1.99999988 2.1 2.39999986 2.89999986 3.6 4.5</Data></Set></ChartData></Ch" +
				"art3DGroup></ChartGroupsCollection><StyleCollection><NamedStyle Name=\"Legend\" Pa" +
				"rentName=\"Legend.default\" StyleData=\"Border=Solid,Black,1;BackColor=Silver;\" /><" +
				"NamedStyle Name=\"Footer\" ParentName=\"Control\" /><NamedStyle Name=\"Area\" ParentNa" +
				"me=\"Area.default\" /><NamedStyle Name=\"Control\" ParentName=\"Control.default\" /><N" +
				"amedStyle Name=\"Style1\" ParentName=\"LabelStyleDefault\" /><NamedStyle Name=\"Style" +
				"3\" ParentName=\"LabelStyleDefault\" /><NamedStyle Name=\"Style2\" ParentName=\"LabelS" +
				"tyleDefault\" /><NamedStyle Name=\"LabelStyleDefault\" ParentName=\"Control\" StyleDa" +
				"ta=\"BackColor=Transparent;\" /><NamedStyle Name=\"Legend.default\" ParentName=\"Cont" +
				"rol\" StyleData=\"Wrap=False;AlignVert=Top;\" /><NamedStyle Name=\"Header\" ParentNam" +
				"e=\"Control\" /><NamedStyle Name=\"Control.default\" ParentName=\"\" StyleData=\"ForeCo" +
				"lor=ControlText;BackColor=Control;\" /><NamedStyle Name=\"Area.default\" ParentName" +
				"=\"Control\" StyleData=\"AlignVert=Top;\" /></StyleCollection><ChartStyles><Chart3DS" +
				"tyle><LineStyle Pattern=\"Solid\" Color=\"LightCoral\" Thickness=\"0\" /><SymbolStyle " +
				"Size=\"3\" Color=\"LightCoral\" Shape=\"Dot\" /></Chart3DStyle><Chart3DStyle><LineStyl" +
				"e Pattern=\"Solid\" Color=\"LightYellow\" Thickness=\"0\" /><SymbolStyle Size=\"3\" Colo" +
				"r=\"LightYellow\" Shape=\"Dot\" /></Chart3DStyle><Chart3DStyle><LineStyle Pattern=\"S" +
				"olid\" Color=\"LightGreen\" Thickness=\"0\" /><SymbolStyle Size=\"3\" Color=\"LightGreen" +
				"\" Shape=\"Dot\" /></Chart3DStyle><Chart3DStyle><LineStyle Pattern=\"Solid\" Color=\"L" +
				"ightCoral\" Thickness=\"0\" /><SymbolStyle Size=\"12\" Color=\"Red\" Shape=\"Star\" /></C" +
				"hart3DStyle><Chart3DStyle><LineStyle Pattern=\"Solid\" Color=\"LightGreen\" Thicknes" +
				"s=\"0\" /><SymbolStyle Size=\"12\" Color=\"LawnGreen\" Shape=\"Star\" /></Chart3DStyle><" +
				"Chart3DStyle><LineStyle Pattern=\"Solid\" Color=\"LightYellow\" Thickness=\"0\" /><Sym" +
				"bolStyle Size=\"12\" Color=\"Yellow\" Shape=\"Star\" /></Chart3DStyle></ChartStyles><F" +
				"ooterData Compass=\"South\" /><HeaderData Compass=\"North\" /><LegendData Compass=\"E" +
				"ast\" /></Chart3DPropBag>";
			this.c1Chart3D1.Size = new System.Drawing.Size(472, 403);
			this.c1Chart3D1.TabIndex = 0;
			// 
			// timer1
			// 
			this.timer1.Interval = 200;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																				 this.cbLabels,
																																				 this.cbMotion,
																																				 this.cbLegend,
																																				 this.cbPaths,
																																				 this.cbAxes,
																																				 this.cbLines,
																																				 this.cbDepth});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(112, 403);
			this.panel1.TabIndex = 1;
			// 
			// cbLabels
			// 
			this.cbLabels.Location = new System.Drawing.Point(16, 112);
			this.cbLabels.Name = "cbLabels";
			this.cbLabels.TabIndex = 2;
			this.cbLabels.Text = "Labels";
			this.cbLabels.CheckedChanged += new System.EventHandler(this.cbLabels_CheckedChanged);
			// 
			// cbMotion
			// 
			this.cbMotion.Location = new System.Drawing.Point(16, 16);
			this.cbMotion.Name = "cbMotion";
			this.cbMotion.TabIndex = 1;
			this.cbMotion.Text = "Motion";
			this.cbMotion.CheckedChanged += new System.EventHandler(this.cbMotion_CheckedChanged);
			// 
			// cbLegend
			// 
			this.cbLegend.Location = new System.Drawing.Point(16, 80);
			this.cbLegend.Name = "cbLegend";
			this.cbLegend.TabIndex = 0;
			this.cbLegend.Text = "Legend";
			this.cbLegend.CheckedChanged += new System.EventHandler(this.cbLegend_CheckedChanged);
			// 
			// cbPaths
			// 
			this.cbPaths.Checked = true;
			this.cbPaths.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbPaths.Location = new System.Drawing.Point(16, 144);
			this.cbPaths.Name = "cbPaths";
			this.cbPaths.Size = new System.Drawing.Size(72, 24);
			this.cbPaths.TabIndex = 2;
			this.cbPaths.Text = "Paths";
			this.cbPaths.CheckedChanged += new System.EventHandler(this.cbPaths_CheckedChanged);
			// 
			// cbAxes
			// 
			this.cbAxes.Checked = true;
			this.cbAxes.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbAxes.Location = new System.Drawing.Point(16, 48);
			this.cbAxes.Name = "cbAxes";
			this.cbAxes.Size = new System.Drawing.Size(72, 24);
			this.cbAxes.TabIndex = 2;
			this.cbAxes.Text = "Axes";
			this.cbAxes.CheckedChanged += new System.EventHandler(this.cbAxes_CheckedChanged);
			// 
			// cbLines
			// 
			this.cbLines.Location = new System.Drawing.Point(16, 176);
			this.cbLines.Name = "cbLines";
			this.cbLines.Size = new System.Drawing.Size(80, 24);
			this.cbLines.TabIndex = 2;
			this.cbLines.Text = "Drop lines";
			this.cbLines.CheckedChanged += new System.EventHandler(this.cbLines_CheckedChanged);
			// 
			// cbDepth
			// 
			this.cbDepth.Location = new System.Drawing.Point(16, 208);
			this.cbDepth.Name = "cbDepth";
			this.cbDepth.Size = new System.Drawing.Size(80, 24);
			this.cbDepth.TabIndex = 2;
			this.cbDepth.Text = "Depth Cue";
			this.cbDepth.CheckedChanged += new System.EventHandler(this.cbDepth_CheckedChanged);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem1,
																																							this.menuItem3});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuFileExit});
			this.menuItem1.Text = "&File";
			// 
			// menuFileExit
			// 
			this.menuFileExit.Index = 0;
			this.menuFileExit.Text = "E&xit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuHelpAbout});
			this.menuItem3.Text = "&Help";
			// 
			// menuHelpAbout
			// 
			this.menuHelpAbout.Index = 0;
			this.menuHelpAbout.Text = "&About";
			this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 403);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.panel1,
																																	this.c1Chart3D1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComponentOne Chart for .NET 3D - Scatter Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).EndInit();
			this.panel1.ResumeLayout(false);
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
			c1Chart3D1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom	| AnchorStyles.Left| AnchorStyles.Right;//!!VBPassThru
			initData();
			loaded = true;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if( step>=npoints)
				step = 0;

			pset[0,0] = pset[3,step];
			pset[1,0] = pset[4,step];
			pset[2,0] = pset[5,step];

			step++;
		}

		private void cbLegend_CheckedChanged(object sender, System.EventArgs e)
		{
			c1Chart3D1.Legend.Visible = cbLegend.Checked;
		}

		private void cbMotion_CheckedChanged(object sender, System.EventArgs e)
		{
			timer1.Enabled = cbMotion.Checked;
		}

		private void cbLabels_CheckedChanged(object sender, System.EventArgs e)
		{
			c1Chart3D1.ChartLabels[0].Visible = cbLabels.Checked;
			c1Chart3D1.ChartLabels[1].Visible = cbLabels.Checked;
			c1Chart3D1.ChartLabels[2].Visible = cbLabels.Checked;
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void cbPaths_CheckedChanged(object sender, System.EventArgs e)
		{
			if(!loaded)
				return;
			c1Chart3D1.ChartGroups.Group0.ChartData.SetPoint.SeriesCollection[3].Visible = cbPaths.Checked;
			c1Chart3D1.ChartGroups.Group0.ChartData.SetPoint.SeriesCollection[4].Visible = cbPaths.Checked;
			c1Chart3D1.ChartGroups.Group0.ChartData.SetPoint.SeriesCollection[5].Visible = cbPaths.Checked;
		}

		private void cbAxes_CheckedChanged(object sender, System.EventArgs e)
		{
			c1Chart3D1.ChartArea.AxisX.Visible = cbAxes.Checked;
			c1Chart3D1.ChartArea.AxisY.Visible = cbAxes.Checked;
			c1Chart3D1.ChartArea.AxisZ.Visible = cbAxes.Checked;
			if( cbAxes.Checked)
				c1Chart3D1.ChartArea.View.BackColor = Color.Silver;
			else
				c1Chart3D1.ChartArea.View.BackColor = Color.Transparent;
		}

		private void cbLines_CheckedChanged(object sender, System.EventArgs e)
		{
			c1Chart3D1.ChartGroups.Group0.Elevation.DropLines = cbLines.Checked;
		}

		private void cbDepth_CheckedChanged(object sender, System.EventArgs e)
		{
			c1Chart3D1.ChartGroups.Group0.Elevation.DepthCue = cbDepth.Checked;
		}

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);		
		}
	}
}
