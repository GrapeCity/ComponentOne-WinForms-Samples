using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Chart4D
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1Chart3D.C1Chart3D c1Chart3D1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.RadioButton rbSphere;
		private System.Windows.Forms.RadioButton rbWave;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbConNone;
		private System.Windows.Forms.RadioButton rbConSphere;
		private System.Windows.Forms.RadioButton rbConWaves;
		private System.Windows.Forms.RadioButton rbConRandom;
		private System.Windows.Forms.PropertyGrid pgConStyle;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rbBar;
		private System.Windows.Forms.RadioButton rbSurface;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();
		}

		C1.Win.C1Chart3D.Chart3DDataSetGrid sphere_set = null;
		C1.Win.C1Chart3D.Chart3DDataSetGrid wave_set = null;
		int npoints = 21;
		double[,] sdata = null;
		double[,] wdata = null;
		double[,] rdata = null;
		Random rnd= new Random();

		void initData()
		{
			int nx = npoints;
			int ny = npoints;
			float x0 = -5;
			float y0 = -5;
			float dx = 10.0f / (npoints-1);
			float dy = 10.0f / (npoints-1);
			sdata = (double[,]) Array.CreateInstance( typeof(double), nx, ny);
			wdata = (double[,]) Array.CreateInstance( typeof(double), nx, ny);
			rdata = (double[,]) Array.CreateInstance( typeof(double), nx, ny);
			for( int i=0; i<nx; i++)
				for( int j=0; j<ny; j++)
				{
					float x = x0 + dx*i;
					float y = y0 + dy*j;
					sdata[i,j] = Math.Sqrt( 50 - x*x - y*y);
					wdata[i,j] = ( Math.Sin( x) + Math.Cos(y));
					rdata[i,j] = rnd.NextDouble();
				}

			sphere_set = new C1.Win.C1Chart3D.Chart3DDataSetGrid( x0, y0, 1, 1, sdata);
			wave_set = new C1.Win.C1Chart3D.Chart3DDataSetGrid( x0, y0, 1, 1, wdata);
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
			this.c1Chart3D1 = new C1.Win.C1Chart3D.C1Chart3D();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbSurface = new System.Windows.Forms.RadioButton();
			this.rbBar = new System.Windows.Forms.RadioButton();
			this.pgConStyle = new System.Windows.Forms.PropertyGrid();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbConRandom = new System.Windows.Forms.RadioButton();
			this.rbConWaves = new System.Windows.Forms.RadioButton();
			this.rbConSphere = new System.Windows.Forms.RadioButton();
			this.rbConNone = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbWave = new System.Windows.Forms.RadioButton();
			this.rbSphere = new System.Windows.Forms.RadioButton();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// c1Chart3D1
			// 
			this.c1Chart3D1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.c1Chart3D1.Location = new System.Drawing.Point(204, 0);
			this.c1Chart3D1.Name = "c1Chart3D1";
			this.c1Chart3D1.PropBag = "<?xml version=\"1.0\"?><Chart3DPropBag Version=\"\"><AxisX /><AxisY /><AxisZ /><Chart" +
				"GroupsCollection><Chart3DGroup ChartType=\"Surface\"><Elevation><SurfaceTopColor>W" +
				"hite</SurfaceTopColor><SurfaceBottomColor>DarkGray</SurfaceBottomColor></Elevati" +
				"on><ChartData><Set type=\"Chart3DDataSetGrid\" RowOrigin=\"0\" RowDelta=\"1\" RowCount" +
				"=\"11\" ColumnCount=\"11\" ColumnDelta=\"1\" ColumnOrigin=\"0\" Hole=\"3.40282347E+38\"><D" +
				"ata>4.5 3.6 2.89999986 2.39999986 2.1 1.99999988 2.1 2.39999986 2.89999986 3.6 4" +
				".5 8.1 7.2 6.5 6 5.7 5.6 5.7 6 6.5 7.2 8.1 10.9 10 9.3 8.8 8.5 8.4 8.5 8.8 9.3 1" +
				"0 10.9 12.9 12 11.3 10.8 10.5 10.4 10.5 10.8 11.3 12 12.9 14.1 13.2 12.5 12 11.7" +
				" 11.6 11.7 12 12.5 13.2 14.1 14.5 13.6 12.9 12.4 12.1 12 12.1 12.4 12.9 13.6 14." +
				"5 14.1 13.2 12.5 12 11.7 11.6 11.7 12 12.5 13.2 14.1 12.9 12 11.3 10.8 10.5 10.4" +
				" 10.5 10.8 11.3 12 12.9 10.9 10 9.3 8.8 8.5 8.4 8.5 8.8 9.3 10 10.9 8.1 7.2 6.5 " +
				"6 5.7 5.6 5.7 6 6.5 7.2 8.1 4.5 3.6 2.89999986 2.39999986 2.1 1.99999988 2.1 2.3" +
				"9999986 2.89999986 3.6 4.5 </Data></Set></ChartData><Bar /><Surface /><Contour I" +
				"sZoned=\"True\" NumLevels=\"25\" /></Chart3DGroup></ChartGroupsCollection><ChartStyl" +
				"es><Chart3DStyle><LineStyle Color=\"Black\" Pattern=\"Solid\" Thickness=\"0\" /><Symbo" +
				"lStyle Color=\"Coral\" Shape=\"Box\" Size=\"5\" /></Chart3DStyle></ChartStyles><Contou" +
				"rStyles ColorSet=\"RevRainbow\" /><LegendData Compass=\"East\" /><StyleCollection><N" +
				"amedStyle Name=\"Legend\" ParentName=\"Legend.default\" StyleData=\"\" /><NamedStyle N" +
				"ame=\"Footer\" ParentName=\"Control\" StyleData=\"\" /><NamedStyle Name=\"Area\" ParentN" +
				"ame=\"Area.default\" StyleData=\"Border=Empty,Black,1;\" /><NamedStyle Name=\"Control" +
				"\" ParentName=\"Control.default\" StyleData=\"Border=Solid,Black,1;\" /><NamedStyle N" +
				"ame=\"LabelStyleDefault\" ParentName=\"Control\" StyleData=\"BackColor=Transparent;\" " +
				"/><NamedStyle Name=\"Legend.default\" ParentName=\"Control\" StyleData=\"Wrap=False;A" +
				"lignVert=Top;\" /><NamedStyle Name=\"Header\" ParentName=\"Control\" StyleData=\"\" /><" +
				"NamedStyle Name=\"Control.default\" ParentName=\"\" StyleData=\"ForeColor=ControlText" +
				";BackColor=Control;\" /><NamedStyle Name=\"Area.default\" ParentName=\"Control\" Styl" +
				"eData=\"AlignVert=Top;\" /></StyleCollection><FooterData Compass=\"South\" /><View I" +
				"sInteractive=\"True\" AxisTitleFont=\"Microsoft Sans Serif, 12world\" AxisFont=\"Micr" +
				"osoft Sans Serif, 10world\"><Ceiling /><Floor /></View><HeaderData Compass=\"North" +
				"\" /></Chart3DPropBag>";
			this.c1Chart3D1.Size = new System.Drawing.Size(388, 403);
			this.c1Chart3D1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																				 this.groupBox3,
																																				 this.pgConStyle,
																																				 this.groupBox2,
																																				 this.groupBox1});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 403);
			this.panel1.TabIndex = 1;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.rbSurface,
																																						this.rbBar});
			this.groupBox3.Location = new System.Drawing.Point(8, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(184, 48);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Chart Type";
			// 
			// rbSurface
			// 
			this.rbSurface.Location = new System.Drawing.Point(104, 16);
			this.rbSurface.Name = "rbSurface";
			this.rbSurface.Size = new System.Drawing.Size(72, 24);
			this.rbSurface.TabIndex = 1;
			this.rbSurface.Text = "Surface";
			this.rbSurface.CheckedChanged += new System.EventHandler(this.rbSurface_CheckedChanged);
			// 
			// rbBar
			// 
			this.rbBar.Location = new System.Drawing.Point(8, 16);
			this.rbBar.Name = "rbBar";
			this.rbBar.Size = new System.Drawing.Size(40, 24);
			this.rbBar.TabIndex = 0;
			this.rbBar.Text = "Bar";
			this.rbBar.CheckedChanged += new System.EventHandler(this.rbBar_CheckedChanged);
			// 
			// pgConStyle
			// 
			this.pgConStyle.CommandsVisibleIfAvailable = true;
			this.pgConStyle.HelpVisible = false;
			this.pgConStyle.LargeButtons = false;
			this.pgConStyle.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pgConStyle.Location = new System.Drawing.Point(8, 184);
			this.pgConStyle.Name = "pgConStyle";
			this.pgConStyle.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.pgConStyle.Size = new System.Drawing.Size(184, 56);
			this.pgConStyle.TabIndex = 3;
			this.pgConStyle.Text = "propertyGrid1";
			this.pgConStyle.ToolbarVisible = false;
			this.pgConStyle.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pgConStyle.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.rbConRandom,
																																						this.rbConWaves,
																																						this.rbConSphere,
																																						this.rbConNone});
			this.groupBox2.Location = new System.Drawing.Point(104, 56);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(88, 120);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Contour Data";
			// 
			// rbConRandom
			// 
			this.rbConRandom.Location = new System.Drawing.Point(8, 88);
			this.rbConRandom.Name = "rbConRandom";
			this.rbConRandom.Size = new System.Drawing.Size(68, 24);
			this.rbConRandom.TabIndex = 3;
			this.rbConRandom.Text = "Random";
			this.rbConRandom.CheckedChanged += new System.EventHandler(this.rbConRandom_CheckedChanged);
			// 
			// rbConWaves
			// 
			this.rbConWaves.Location = new System.Drawing.Point(8, 64);
			this.rbConWaves.Name = "rbConWaves";
			this.rbConWaves.Size = new System.Drawing.Size(64, 24);
			this.rbConWaves.TabIndex = 2;
			this.rbConWaves.Text = "Waves";
			this.rbConWaves.CheckedChanged += new System.EventHandler(this.rbConWaves_CheckedChanged);
			// 
			// rbConSphere
			// 
			this.rbConSphere.Location = new System.Drawing.Point(8, 40);
			this.rbConSphere.Name = "rbConSphere";
			this.rbConSphere.Size = new System.Drawing.Size(64, 24);
			this.rbConSphere.TabIndex = 1;
			this.rbConSphere.Text = "Sphere";
			this.rbConSphere.CheckedChanged += new System.EventHandler(this.rbConSphere_CheckedChanged);
			// 
			// rbConNone
			// 
			this.rbConNone.Location = new System.Drawing.Point(8, 16);
			this.rbConNone.Name = "rbConNone";
			this.rbConNone.Size = new System.Drawing.Size(56, 24);
			this.rbConNone.TabIndex = 0;
			this.rbConNone.Text = "None";
			this.rbConNone.CheckedChanged += new System.EventHandler(this.rbConNone_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.rbWave,
																																						this.rbSphere});
			this.groupBox1.Location = new System.Drawing.Point(8, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(96, 72);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Elevation Data";
			// 
			// rbWave
			// 
			this.rbWave.Location = new System.Drawing.Point(8, 40);
			this.rbWave.Name = "rbWave";
			this.rbWave.Size = new System.Drawing.Size(64, 24);
			this.rbWave.TabIndex = 1;
			this.rbWave.Text = "Waves";
			// 
			// rbSphere
			// 
			this.rbSphere.Location = new System.Drawing.Point(8, 16);
			this.rbSphere.Name = "rbSphere";
			this.rbSphere.Size = new System.Drawing.Size(64, 24);
			this.rbSphere.TabIndex = 0;
			this.rbSphere.Text = "Sphere";
			this.rbSphere.CheckedChanged += new System.EventHandler(this.rbSphere_CheckedChanged);
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
			this.MinimumSize = new System.Drawing.Size(300, 308);
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComponentOne Chart for .NET 3D - 4D Chart Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
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

		private void btnGen4_Click(object sender, System.EventArgs e)
		{
			Random rnd= new Random();
			int nx =c1Chart3D1.ChartGroups.Group0.ChartData.SetGrid.ColumnCount;
			int ny = c1Chart3D1.ChartGroups.Group0.ChartData.SetGrid.RowCount;
			double[,] data = (double[,]) Array.CreateInstance( typeof(double), nx, ny);
			for( int i=0; i<nx; i++)
				for( int j=0; j<ny; j++)
					data[i,j] = rnd.NextDouble();
			c1Chart3D1.ChartGroups.Group0.ChartData.ContourData = data;
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			initData();
			pgConStyle.SelectedObject = new ContourProperties( c1Chart3D1);
			rbSphere.Checked = true;
			rbSurface.Checked = true;
		}

		private void rbSphere_CheckedChanged(object sender, System.EventArgs e)
		{
			if( rbSphere.Checked)
				c1Chart3D1.ChartGroups[0].ChartData.SetGrid = sphere_set;
			else
				c1Chart3D1.ChartGroups[0].ChartData.SetGrid = wave_set;
		}

		private void rbConNone_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rbConNone.Checked)
				c1Chart3D1.ChartGroups.Group0.ChartData.ContourData = null;
		}

		private void rbConSphere_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rbConSphere.Checked)
				c1Chart3D1.ChartGroups.Group0.ChartData.ContourData = sdata;
		}

		private void rbConWaves_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rbConWaves.Checked)
				c1Chart3D1.ChartGroups.Group0.ChartData.ContourData = wdata;
		}

		private void rbConRandom_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rbConRandom.Checked)
				c1Chart3D1.ChartGroups.Group0.ChartData.ContourData = rdata;
		}

		private void rbBar_CheckedChanged(object sender, System.EventArgs e)
		{
			if( rbBar.Checked)
				c1Chart3D1.ChartGroups.Group0.ChartType = C1.Win.C1Chart3D.Chart3DTypeEnum.Bar;
		}

		private void rbSurface_CheckedChanged(object sender, System.EventArgs e)
		{
			if( rbSurface.Checked)
				c1Chart3D1.ChartGroups.Group0.ChartType = C1.Win.C1Chart3D.Chart3DTypeEnum.Surface;
		}

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

	class ContourProperties
	{
		C1.Win.C1Chart3D.C1Chart3D _chart;

		public ContourProperties( C1.Win.C1Chart3D.C1Chart3D chart)
		{
			_chart = chart;
		}

		public C1.Win.C1Chart3D.Chart3DColorsCollection Colors
		{
			get{ return _chart.ChartGroups.ContourStyles.Colors;}
		}

		public C1.Win.C1Chart3D.ColorSetEnum ColorSet
		{
			get{ return _chart.ChartGroups.ContourStyles.ColorSet;}
			set{ _chart.ChartGroups.ContourStyles.ColorSet = value;}
		}

		public C1.Win.C1Chart3D.Chart3DContourStylesCollection Styles
		{
			get{ return _chart.ChartGroups.ContourStyles.Styles;}
		}
	}
}
