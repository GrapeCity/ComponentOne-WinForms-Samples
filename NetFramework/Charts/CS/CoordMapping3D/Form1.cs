using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.C1Chart3D;

namespace CoordMapping
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		int xpixel, ypixel;
		bool bMarker = false;
		Pen pen = new Pen( Color.Red, 2);
		float x=0, y=0, z=0;
		int nlabel = 0;
		int old_row = -1, old_col = -1;
		bool bCapture = true;

		private C1.Win.C1Chart3D.C1Chart3D chart3D1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblMouse;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblDataCoord;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblDataIndex;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton rbSurface;
		private System.Windows.Forms.RadioButton rbScatter;
		private System.Windows.Forms.RadioButton rbBar;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RadioButton rbValues;
		private System.Windows.Forms.RadioButton rbValueLabels;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.NumericUpDown upRotX;
		private System.Windows.Forms.NumericUpDown upRotZ;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.CheckBox cbLabel;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.Button btnSetData;
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

		void updateChartType()
		{
			bMarker = false;
			if( rbBar.Checked)
				chart3D1.ChartGroups[0].ChartType = Chart3DTypeEnum.Bar;
			else if(rbScatter.Checked)
				chart3D1.ChartGroups[0].ChartType = Chart3DTypeEnum.Scatter;
			else
				chart3D1.ChartGroups[0].ChartType = Chart3DTypeEnum.Surface;
		}

		void toggleValueLabels( bool show )
		{
			if( show)
			{
				foreach( C1.Win.C1Chart3D.Chart3DAxis axis in chart3D1.ChartArea.Axes)
				{
					float val;
					if( axis.Equals( chart3D1.ChartArea.AxisX))
						val = x;
					else if( axis.Equals( chart3D1.ChartArea.AxisY))
						val = y;
					else
						val = z;

					if( axis.ValueLabels.Count<nlabel+1)
						axis.ValueLabels.Add( val, val.ToString());
					else
					{
						axis.ValueLabels[nlabel].Value = val;
						axis.ValueLabels[nlabel].Text = val.ToString();
					}
					axis.AnnoMethod = C1.Win.C1Chart3D.AnnotationMethodEnum.ValueLabels;

					axis.MajorGrid.Style.Color = Color.Red;
				}

				this.statusBarPanel1.Text = "Left click to save current axis labels position. Right click to clear all labels";
				bCapture = true;
			}
			else
			{
				foreach( C1.Win.C1Chart3D.Chart3DAxis axis in chart3D1.ChartArea.Axes)
				{
					axis.AnnoMethod = C1.Win.C1Chart3D.AnnotationMethodEnum.Values;
					axis.MajorGrid.Style.Color = Color.Black;
				}
				statusBarPanel1.Text = "Move mouse over chart to see coordinates mapping results on the left panel.Click on chart to toggle mouse capture";
			}
		}

		void updateMarkerPosition()
		{
			bMarker = false;
			if( chart3D1.ChartGroups[0].ChartType != Chart3DTypeEnum.Bar)
			{
				if(chart3D1.ChartGroups[0].ChartData.DataCoordToCoord( x, y, z, ref xpixel, ref ypixel))
				{
					bMarker = true;
				}
			}
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.chart3D1 = new C1.Win.C1Chart3D.C1Chart3D();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSetData = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.rbValueLabels = new System.Windows.Forms.RadioButton();
			this.rbValues = new System.Windows.Forms.RadioButton();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.cbLabel = new System.Windows.Forms.CheckBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.upRotZ = new System.Windows.Forms.NumericUpDown();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.upRotX = new System.Windows.Forms.NumericUpDown();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblDataIndex = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblMouse = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblDataCoord = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.rbSurface = new System.Windows.Forms.RadioButton();
			this.rbScatter = new System.Windows.Forms.RadioButton();
			this.rbBar = new System.Windows.Forms.RadioButton();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.chart3D1)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.upRotZ)).BeginInit();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.upRotX)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			this.SuspendLayout();
			// 
			// chart3D1
			// 
			this.chart3D1.BackColor = System.Drawing.SystemColors.Control;
			this.chart3D1.Location = new System.Drawing.Point(168, 0);
			this.chart3D1.Name = "chart3D1";
			this.chart3D1.PropBag = "<?xml version=\"1.0\"?><Chart3DPropBag Version=\"\"><ChartStyles><Chart3DStyle><Symbo" +
				"lStyle Color=\"Blue\" Shape=\"Diamond\" Size=\"5\" /><LineStyle Color=\"Black\" Thicknes" +
				"s=\"0\" Pattern=\"Solid\" /></Chart3DStyle></ChartStyles><LegendData WV=\"Auto\" Compa" +
				"ss=\"East\" /><ChartGroupsCollection><Chart3DGroup><ChartData><Set type=\"Chart3DDa" +
				"taSetGrid\" RowDelta=\"1\" RowCount=\"11\" ColumnCount=\"11\" ColumnDelta=\"1\" ColumnOri" +
				"gin=\"0\" RowOrigin=\"0\" Hole=\"3.40282347E+38\"><Data>4.5 3.6 2.89999986 2.39999986 " +
				"2.1 1.99999988 2.1 2.39999986 2.89999986 3.6 4.5 8.1 7.2 6.5 6 5.7 5.6 5.7 6 6.5" +
				" 7.2 8.1 10.9 10 9.3 8.8 8.5 8.4 8.5 8.8 9.3 10 10.9 12.9 12 11.3 10.8 10.5 10.4" +
				" 10.5 10.8 11.3 12 12.9 14.1 13.2 12.5 12 11.7 11.6 11.7 12 12.5 13.2 14.1 14.5 " +
				"13.6 12.9 12.4 12.1 12 12.1 12.4 12.9 13.6 14.5 14.1 13.2 12.5 12 11.7 11.6 11.7" +
				" 12 12.5 13.2 14.1 12.9 12 11.3 10.8 10.5 10.4 10.5 10.8 11.3 12 12.9 10.9 10 9." +
				"3 8.8 8.5 8.4 8.5 8.8 9.3 10 10.9 8.1 7.2 6.5 6 5.7 5.6 5.7 6 6.5 7.2 8.1 4.5 3." +
				"6 2.89999986 2.39999986 2.1 1.99999988 2.1 2.39999986 2.89999986 3.6 4.5</Data><" +
				"/Set></ChartData><Elevation ShadedBottomColor=\"Gray\" ShadedTopColor=\"Gainsboro\" " +
				"Transparency=\"190\" /><Bar Origin=\"0\" ColumnWidth=\"60\" RowWidth=\"60\" /></Chart3DG" +
				"roup></ChartGroupsCollection><AxisX GridY=\"True\" GridZ=\"True\" Text=\"X - axis\" />" +
				"<AxisY GridX=\"True\" GridZ=\"True\" Text=\"Y - axis\" /><AxisZ GridY=\"True\" GridX=\"Tr" +
				"ue\" AutoMajor=\"False\" UnitMajor=\"2\" AnnoRotated=\"True\" Text=\"Z - axis\" /><StyleC" +
				"ollection><NamedStyle ParentName=\"Legend.default\" Name=\"Legend\" /><NamedStyle Pa" +
				"rentName=\"Control\" Name=\"Footer\" /><NamedStyle ParentName=\"Area.default\" Name=\"A" +
				"rea\" StyleData=\"Border=Empty,ControlText,1;BackColor=Control;\" /><NamedStyle Par" +
				"entName=\"Control.default\" Name=\"Control\" StyleData=\"Border=Solid,Black,1;BackCol" +
				"or=Control;\" /><NamedStyle ParentName=\"Control\" Name=\"LabelStyleDefault\" StyleDa" +
				"ta=\"ForeColor=ControlText;BackColor=White;\" /><NamedStyle ParentName=\"Control\" N" +
				"ame=\"Legend.default\" StyleData=\"Wrap=False;AlignVert=Top;\" /><NamedStyle ParentN" +
				"ame=\"Control\" Name=\"Header\" /><NamedStyle ParentName=\"\" Name=\"Control.default\" S" +
				"tyleData=\"ForeColor=ControlText;BackColor=Control;\" /><NamedStyle ParentName=\"Co" +
				"ntrol\" Name=\"Area.default\" StyleData=\"AlignVert=Top;\" /></StyleCollection><Foote" +
				"rData Compass=\"South\" /><HeaderData Compass=\"North\" /><View RotationX=\"74\" BackC" +
				"olor=\"OldLace\" AxisTitleFont=\"Microsoft Sans Serif, 10world\" /></Chart3DPropBag>" +
				"";
			this.chart3D1.Size = new System.Drawing.Size(424, 376);
			this.chart3D1.TabIndex = 0;
			this.chart3D1.Load += new System.EventHandler(this.chart3D1_Load);
			this.chart3D1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart3D1_MouseMove);
			this.chart3D1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart3D1_MouseDown);
			this.chart3D1.Paint += new System.Windows.Forms.PaintEventHandler(this.chart3D1_Paint);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																				 this.btnSetData,
																																				 this.groupBox5,
																																				 this.groupBox8,
																																				 this.groupBox7,
																																				 this.groupBox6,
																																				 this.groupBox3,
																																				 this.groupBox1,
																																				 this.groupBox2,
																																				 this.groupBox4});
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(168, 376);
			this.panel1.TabIndex = 2;
			// 
			// btnSetData
			// 
			this.btnSetData.Enabled = false;
			this.btnSetData.Location = new System.Drawing.Point(8, 300);
			this.btnSetData.Name = "btnSetData";
			this.btnSetData.Size = new System.Drawing.Size(88, 20);
			this.btnSetData.TabIndex = 10;
			this.btnSetData.Text = "Set Z-value ...";
			this.btnSetData.Click += new System.EventHandler(this.btnSetData_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.rbValueLabels,
																																						this.rbValues});
			this.groupBox5.Location = new System.Drawing.Point(8, 96);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(78, 80);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Axis anno";
			// 
			// rbValueLabels
			// 
			this.rbValueLabels.Location = new System.Drawing.Point(8, 40);
			this.rbValueLabels.Name = "rbValueLabels";
			this.rbValueLabels.Size = new System.Drawing.Size(64, 32);
			this.rbValueLabels.TabIndex = 1;
			this.rbValueLabels.Text = "Value Labels";
			this.rbValueLabels.CheckedChanged += new System.EventHandler(this.rbValueLabels_CheckedChanged);
			// 
			// rbValues
			// 
			this.rbValues.Location = new System.Drawing.Point(8, 20);
			this.rbValues.Name = "rbValues";
			this.rbValues.Size = new System.Drawing.Size(56, 16);
			this.rbValues.TabIndex = 0;
			this.rbValues.Text = "Values";
			this.rbValues.CheckedChanged += new System.EventHandler(this.rbValues_CheckedChanged);
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.cbLabel});
			this.groupBox8.Location = new System.Drawing.Point(88, 96);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(72, 80);
			this.groupBox8.TabIndex = 9;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Label";
			// 
			// cbLabel
			// 
			this.cbLabel.Location = new System.Drawing.Point(4, 16);
			this.cbLabel.Name = "cbLabel";
			this.cbLabel.Size = new System.Drawing.Size(52, 16);
			this.cbLabel.TabIndex = 0;
			this.cbLabel.Text = "Show";
			this.cbLabel.CheckedChanged += new System.EventHandler(this.cbLabel_CheckedChanged);
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.upRotZ});
			this.groupBox7.Location = new System.Drawing.Point(88, 52);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(72, 44);
			this.groupBox7.TabIndex = 8;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "RotationZ";
			// 
			// upRotZ
			// 
			this.upRotZ.Increment = new System.Decimal(new int[] {
																														 5,
																														 0,
																														 0,
																														 0});
			this.upRotZ.Location = new System.Drawing.Point(12, 16);
			this.upRotZ.Maximum = new System.Decimal(new int[] {
																													 360,
																													 0,
																													 0,
																													 0});
			this.upRotZ.Name = "upRotZ";
			this.upRotZ.Size = new System.Drawing.Size(48, 20);
			this.upRotZ.TabIndex = 7;
			this.upRotZ.ValueChanged += new System.EventHandler(this.upRotZ_ValueChanged);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.upRotX});
			this.groupBox6.Location = new System.Drawing.Point(88, 8);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(72, 44);
			this.groupBox6.TabIndex = 6;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "RotationX";
			// 
			// upRotX
			// 
			this.upRotX.Increment = new System.Decimal(new int[] {
																														 5,
																														 0,
																														 0,
																														 0});
			this.upRotX.Location = new System.Drawing.Point(12, 16);
			this.upRotX.Maximum = new System.Decimal(new int[] {
																													 360,
																													 0,
																													 0,
																													 0});
			this.upRotX.Name = "upRotX";
			this.upRotX.Size = new System.Drawing.Size(48, 20);
			this.upRotX.TabIndex = 0;
			this.upRotX.ValueChanged += new System.EventHandler(this.upRotX_ValueChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.lblDataIndex});
			this.groupBox3.Location = new System.Drawing.Point(8, 256);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(152, 40);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Data index";
			// 
			// lblDataIndex
			// 
			this.lblDataIndex.Location = new System.Drawing.Point(8, 16);
			this.lblDataIndex.Name = "lblDataIndex";
			this.lblDataIndex.Size = new System.Drawing.Size(136, 16);
			this.lblDataIndex.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.lblMouse});
			this.groupBox1.Location = new System.Drawing.Point(8, 176);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(152, 40);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Mouse";
			// 
			// lblMouse
			// 
			this.lblMouse.Location = new System.Drawing.Point(8, 16);
			this.lblMouse.Name = "lblMouse";
			this.lblMouse.Size = new System.Drawing.Size(136, 16);
			this.lblMouse.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.lblDataCoord});
			this.groupBox2.Location = new System.Drawing.Point(8, 216);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(152, 40);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Data coordinates";
			// 
			// lblDataCoord
			// 
			this.lblDataCoord.Location = new System.Drawing.Point(8, 16);
			this.lblDataCoord.Name = "lblDataCoord";
			this.lblDataCoord.Size = new System.Drawing.Size(136, 16);
			this.lblDataCoord.TabIndex = 4;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.rbSurface,
																																						this.rbScatter,
																																						this.rbBar});
			this.groupBox4.Location = new System.Drawing.Point(8, 8);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(78, 88);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Chart Type";
			// 
			// rbSurface
			// 
			this.rbSurface.Location = new System.Drawing.Point(8, 64);
			this.rbSurface.Name = "rbSurface";
			this.rbSurface.Size = new System.Drawing.Size(64, 16);
			this.rbSurface.TabIndex = 5;
			this.rbSurface.Text = "Surface";
			this.rbSurface.CheckedChanged += new System.EventHandler(this.rbChartType_CheckedChanged);
			// 
			// rbScatter
			// 
			this.rbScatter.Location = new System.Drawing.Point(8, 40);
			this.rbScatter.Name = "rbScatter";
			this.rbScatter.Size = new System.Drawing.Size(64, 16);
			this.rbScatter.TabIndex = 4;
			this.rbScatter.Text = "Scatter";
			this.rbScatter.CheckedChanged += new System.EventHandler(this.rbChartType_CheckedChanged);
			// 
			// rbBar
			// 
			this.rbBar.Location = new System.Drawing.Point(8, 16);
			this.rbBar.Name = "rbBar";
			this.rbBar.Size = new System.Drawing.Size(56, 16);
			this.rbBar.TabIndex = 3;
			this.rbBar.Text = "Bar";
			this.rbBar.CheckedChanged += new System.EventHandler(this.rbChartType_CheckedChanged);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 379);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																																									this.statusBarPanel1});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(592, 24);
			this.statusBar1.TabIndex = 3;
			this.statusBar1.Text = "statusBar1";
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanel1.Text = "Move mouse over chart.";
			this.statusBarPanel1.Width = 576;
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
			this.menuHelpAbout.Text = "About";
			this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 403);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.statusBar1,
																																	this.panel1,
																																	this.chart3D1});
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(400, 396);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComponentOne Chart for .NET 3D - CoordMapping Demo";
			((System.ComponentModel.ISupportInitialize)(this.chart3D1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.upRotZ)).EndInit();
			this.groupBox6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.upRotX)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
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

		private void chart3D1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if( !bCapture)
				return;
			
			lblMouse.Text = String.Format( "X={0}; Y={1}", e.X, e.Y);

			float _x=0, _y=0, _z=0;
			if( chart3D1.ChartGroups[0].ChartData.CoordToDataCoord( e.X, e.Y, ref _x, ref _y, ref _z))
			{
				if( _x!=x || _y!=y || _z!=z)
				{
					x = _x; y = _y; z = _z;
					lblDataCoord.Text = String.Format( "X={0}; Y={1}; Z={2}", x, y, z );
					if( rbValueLabels.Checked)
						toggleValueLabels( true);
				}
				else
					return;
			}
			else
			{
				//lblDataCoord.Text = " Not in data range";
			}

			int row = 0, col = 0;
			if( chart3D1.ChartGroups[0].ChartData.CoordToDataIndex( e.X, e.Y, ref col, ref row))
			{
				lblDataIndex.Text = String.Format( "Col={0}; Row={1}", col, row);

				chart3D1.ChartLabels[0].AttachMethodData.Column = col;
				chart3D1.ChartLabels[0].AttachMethodData.Row = row;

				if( chart3D1.ChartGroups[0].ChartType == Chart3DTypeEnum.Bar)
				{
					if( old_col!=-1 && old_row!=-1)
						chart3D1.ChartGroups[0].Bar.SetBarColor( old_col, old_row, Color.White);
					chart3D1.ChartGroups[0].Bar.SetBarColor( col, row, Color.Red);
				}
				old_row = row;
				old_col = col;
				btnSetData.Enabled = true;
			}
			else
			{
				//lblDataIndex.Text = " Not in data range";
			}
		}

		private void chart3D1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			updateMarkerPosition();
			if( bMarker)
				e.Graphics.DrawEllipse( pen, xpixel-5, ypixel-5, 10, 10);
		}

		private void rbChartType_CheckedChanged(object sender, System.EventArgs e)
		{
			updateChartType();
		}

		private void rbValueLabels_CheckedChanged(object sender, System.EventArgs e)
		{
			toggleValueLabels( rbValueLabels.Checked);
		}

		private void rbValues_CheckedChanged(object sender, System.EventArgs e)
		{
			toggleValueLabels( rbValueLabels.Checked);
		}

		private void chart3D1_Load(object sender, System.EventArgs e)
		{
			rbValues.Checked = true;
			rbSurface.Checked = true;
			upRotX.Value = chart3D1.ChartArea.View.RotationX;
			upRotZ.Value = chart3D1.ChartArea.View.RotationZ;

			chart3D1.ChartLabels.AddNewLabel();
			chart3D1.ChartLabels[0].Text = "Selected\nData Point";
			chart3D1.ChartLabels[0].AttachMethod = C1.Win.C1Chart3D.AttachMethodEnum.DataIndex;
			chart3D1.ChartLabels[0].Connected = true;
			chart3D1.ChartLabels[0].Offset = 25;
			chart3D1.ChartLabels[0].LabelCompass = C1.Win.C1Chart3D.LabelCompassEnum.NorthEast;
			chart3D1.ChartLabels[0].Style.BackColor = Color.LightSalmon;
			chart3D1.ChartGroups[0].Bar.SetBarColor( -1, -1, Color.White);

			chart3D1.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom) 	| AnchorStyles.Left) | AnchorStyles.Right);//!!VBPassThru
			panel1.Anchor = ((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left);//!!VBPassThru
		}

		private void chart3D1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if( rbValueLabels.Checked)
			{
				if( e.Button == MouseButtons.Left)
				{
					nlabel++;
				}
				else
				{
					foreach( C1.Win.C1Chart3D.Chart3DAxis axis in chart3D1.ChartArea.Axes)
						axis.ValueLabels.Clear();
					nlabel = 0;
					chart3D1.Invalidate();
				}
				}
			else
        bCapture = !bCapture;
		}

		private void upRotX_ValueChanged(object sender, System.EventArgs e)
		{
			chart3D1.ChartArea.View.RotationX = (int)upRotX.Value;
		}

		private void upRotZ_ValueChanged(object sender, System.EventArgs e)
		{
			chart3D1.ChartArea.View.RotationZ = (int)upRotZ.Value;
		}

		private void cbLabel_CheckedChanged(object sender, System.EventArgs e)
		{
			chart3D1.ChartLabels[0].Visible = cbLabel.Checked;		
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnSetData_Click(object sender, System.EventArgs e)
		{
			if( old_col!=-1 && old_row!=-1)
			{
				InputValueForm frm = new InputValueForm();
				frm.ZValue = chart3D1.ChartGroups[0].ChartData.SetGrid[ old_col, old_row];
				frm.Hole = chart3D1.ChartGroups[0].ChartData.SetGrid.Hole;
				if( frm.ShowDialog( this) == DialogResult.OK)
				{
					chart3D1.ChartGroups[0].ChartData.SetGrid[ old_col, old_row] = frm.ZValue;
					if( z!=frm.Hole)
						z = (float)frm.ZValue;
				}
			}
		}

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);		
		}
	}
}
