using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;

using C1.Win.C1ChartBase;
using C1.Win.C1Chart;
using C1.Win.C1Chart3D;

namespace ChartLoader
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuOptions;
		private System.Windows.Forms.MenuItem menuPixelData;
		private System.Windows.Forms.MenuItem menuSaveAs;
		private System.Windows.Forms.MenuItem menuPrintToFit;
		private System.Windows.Forms.MenuItem menuExit;
		private System.Windows.Forms.MenuItem menuFixedAspect;
		private System.Windows.Forms.MenuItem menuHeaderVersion;
		private System.Windows.Forms.MenuItem menuFooterVersion;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private C1.Win.C1Chart3D.C1Chart3D c1Chart3D1;
		private System.Windows.Forms.MenuItem menuLoad;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;

		private ChartHandler chart = null;
		private System.Windows.Forms.MenuItem menuPropGrid;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuLoadVer;
		private System.Windows.Forms.MenuItem menuResetChart;
		private System.Windows.Forms.MenuItem menuChartSelect;
		private System.Windows.Forms.MenuItem menuFileSep1;
		private System.Windows.Forms.MenuItem menuChartProps;
		private System.Windows.Forms.MenuItem menuChartWizard;
		private System.Windows.Forms.MenuItem menuClientSize;
		private System.Windows.Forms.MenuItem menuSave;
		private System.Windows.Forms.MenuItem menuLoadFromUrl;
		private System.Windows.Forms.MenuItem menuLoadFromUrlVersion;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuLoadFromClipboard;
		private System.Windows.Forms.MenuItem menuLoadFromClipboardVersion;
		private System.Windows.Forms.MenuItem menuSaveToClipboard;
		private System.Windows.Forms.MenuItem menuNewWindow;
		private System.Windows.Forms.MenuItem menuChartPropsLatest;
		private System.Windows.Forms.MenuItem menuChartPropsPrevious;
		private System.Windows.Forms.MenuItem menuChartWizardLatest;
		private System.Windows.Forms.MenuItem menuChartWizardPrevious;

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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuNewWindow = new System.Windows.Forms.MenuItem();
			this.menuChartSelect = new System.Windows.Forms.MenuItem();
			this.menuFileSep1 = new System.Windows.Forms.MenuItem();
			this.menuLoad = new System.Windows.Forms.MenuItem();
			this.menuLoadVer = new System.Windows.Forms.MenuItem();
			this.menuLoadFromUrl = new System.Windows.Forms.MenuItem();
			this.menuLoadFromUrlVersion = new System.Windows.Forms.MenuItem();
			this.menuLoadFromClipboard = new System.Windows.Forms.MenuItem();
			this.menuLoadFromClipboardVersion = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuSave = new System.Windows.Forms.MenuItem();
			this.menuSaveAs = new System.Windows.Forms.MenuItem();
			this.menuSaveToClipboard = new System.Windows.Forms.MenuItem();
			this.menuPrintToFit = new System.Windows.Forms.MenuItem();
			this.menuResetChart = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuExit = new System.Windows.Forms.MenuItem();
			this.menuOptions = new System.Windows.Forms.MenuItem();
			this.menuFixedAspect = new System.Windows.Forms.MenuItem();
			this.menuClientSize = new System.Windows.Forms.MenuItem();
			this.menuPropGrid = new System.Windows.Forms.MenuItem();
			this.menuChartProps = new System.Windows.Forms.MenuItem();
			this.menuChartPropsLatest = new System.Windows.Forms.MenuItem();
			this.menuChartPropsPrevious = new System.Windows.Forms.MenuItem();
			this.menuChartWizard = new System.Windows.Forms.MenuItem();
			this.menuChartWizardLatest = new System.Windows.Forms.MenuItem();
			this.menuChartWizardPrevious = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuHeaderVersion = new System.Windows.Forms.MenuItem();
			this.menuFooterVersion = new System.Windows.Forms.MenuItem();
			this.menuPixelData = new System.Windows.Forms.MenuItem();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.c1Chart3D1 = new C1.Win.C1Chart3D.C1Chart3D();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuFile,
																					  this.menuOptions,
																					  this.menuPixelData});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuNewWindow,
																					 this.menuChartSelect,
																					 this.menuFileSep1,
																					 this.menuLoad,
																					 this.menuLoadVer,
																					 this.menuLoadFromUrl,
																					 this.menuLoadFromUrlVersion,
																					 this.menuLoadFromClipboard,
																					 this.menuLoadFromClipboardVersion,
																					 this.menuItem4,
																					 this.menuSave,
																					 this.menuSaveAs,
																					 this.menuSaveToClipboard,
																					 this.menuPrintToFit,
																					 this.menuResetChart,
																					 this.menuItem1,
																					 this.menuExit});
			this.menuFile.Text = "File";
			// 
			// menuNewWindow
			// 
			this.menuNewWindow.Index = 0;
			this.menuNewWindow.Text = "New Window";
			this.menuNewWindow.Click += new System.EventHandler(this.menuNewWindow_Click);
			// 
			// menuChartSelect
			// 
			this.menuChartSelect.Index = 1;
			this.menuChartSelect.Text = "Switch to 3D Chart";
			this.menuChartSelect.Click += new System.EventHandler(this.menuChartSelect_Click);
			// 
			// menuFileSep1
			// 
			this.menuFileSep1.Index = 2;
			this.menuFileSep1.Text = "-";
			// 
			// menuLoad
			// 
			this.menuLoad.Index = 3;
			this.menuLoad.Text = "Load...";
			this.menuLoad.Click += new System.EventHandler(this.menuLoad_Click);
			// 
			// menuLoadVer
			// 
			this.menuLoadVer.Index = 4;
			this.menuLoadVer.Text = "Load with Version Check...";
			this.menuLoadVer.Click += new System.EventHandler(this.menuLoadVer_Click);
			// 
			// menuLoadFromUrl
			// 
			this.menuLoadFromUrl.Index = 5;
			this.menuLoadFromUrl.Text = "Load From URL...";
			this.menuLoadFromUrl.Click += new System.EventHandler(this.menuLoadFromUrl_Click);
			// 
			// menuLoadFromUrlVersion
			// 
			this.menuLoadFromUrlVersion.Index = 6;
			this.menuLoadFromUrlVersion.Text = "Load From URL with Version Check...";
			this.menuLoadFromUrlVersion.Click += new System.EventHandler(this.menuLoadFromUrlVersion_Click);
			// 
			// menuLoadFromClipboard
			// 
			this.menuLoadFromClipboard.Index = 7;
			this.menuLoadFromClipboard.Text = "Load From Clipboard";
			this.menuLoadFromClipboard.Click += new System.EventHandler(this.menuLoadFromClipboard_Click);
			// 
			// menuLoadFromClipboardVersion
			// 
			this.menuLoadFromClipboardVersion.Index = 8;
			this.menuLoadFromClipboardVersion.Text = "Load From Clipboard with Version Check...";
			this.menuLoadFromClipboardVersion.Click += new System.EventHandler(this.menuLoadFromClipboardVersion_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 9;
			this.menuItem4.Text = "-";
			// 
			// menuSave
			// 
			this.menuSave.Index = 10;
			this.menuSave.Text = "Save";
			this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
			// 
			// menuSaveAs
			// 
			this.menuSaveAs.Index = 11;
			this.menuSaveAs.Text = "Save As...";
			this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
			// 
			// menuSaveToClipboard
			// 
			this.menuSaveToClipboard.Index = 12;
			this.menuSaveToClipboard.Text = "Save To Clipboard";
			this.menuSaveToClipboard.Click += new System.EventHandler(this.menuSaveToClipboard_Click);
			// 
			// menuPrintToFit
			// 
			this.menuPrintToFit.Index = 13;
			this.menuPrintToFit.Text = "Print to fit...";
			this.menuPrintToFit.Click += new System.EventHandler(this.menuPrintToFit_Click);
			// 
			// menuResetChart
			// 
			this.menuResetChart.Index = 14;
			this.menuResetChart.Text = "Reset Chart...";
			this.menuResetChart.Click += new System.EventHandler(this.menuResetChart_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 15;
			this.menuItem1.Text = "-";
			// 
			// menuExit
			// 
			this.menuExit.Index = 16;
			this.menuExit.Text = "Exit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// menuOptions
			// 
			this.menuOptions.Index = 1;
			this.menuOptions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.menuFixedAspect,
																						this.menuClientSize,
																						this.menuPropGrid,
																						this.menuChartProps,
																						this.menuChartWizard,
																						this.menuItem2,
																						this.menuHeaderVersion,
																						this.menuFooterVersion});
			this.menuOptions.Text = "Options";
			// 
			// menuFixedAspect
			// 
			this.menuFixedAspect.Index = 0;
			this.menuFixedAspect.Text = "Fixed Aspect Ratio";
			this.menuFixedAspect.Click += new System.EventHandler(this.menuFixedAspect_Click);
			// 
			// menuClientSize
			// 
			this.menuClientSize.Index = 1;
			this.menuClientSize.Text = "ClientSize...";
			this.menuClientSize.Click += new System.EventHandler(this.menuClientSize_Click);
			// 
			// menuPropGrid
			// 
			this.menuPropGrid.Index = 2;
			this.menuPropGrid.Text = "Property Grid ...";
			this.menuPropGrid.Click += new System.EventHandler(this.menuPropGrid_Click);
			// 
			// menuChartProps
			// 
			this.menuChartProps.Index = 3;
			this.menuChartProps.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.menuChartPropsLatest,
																						   this.menuChartPropsPrevious});
			this.menuChartProps.Text = "Chart Properties";
			// 
			// menuChartPropsLatest
			// 
			this.menuChartPropsLatest.Index = 0;
			this.menuChartPropsLatest.Text = "Latest Version...";
			this.menuChartPropsLatest.Click += new System.EventHandler(this.menuChartPropsLatest_Click);
			// 
			// menuChartPropsPrevious
			// 
			this.menuChartPropsPrevious.Index = 1;
			this.menuChartPropsPrevious.Text = "Previous Version...";
			this.menuChartPropsPrevious.Click += new System.EventHandler(this.menuChartPropsPrevious_Click);
			// 
			// menuChartWizard
			// 
			this.menuChartWizard.Index = 4;
			this.menuChartWizard.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.menuChartWizardLatest,
																							this.menuChartWizardPrevious});
			this.menuChartWizard.Text = "Chart Wizard";
			// 
			// menuChartWizardLatest
			// 
			this.menuChartWizardLatest.Index = 0;
			this.menuChartWizardLatest.Text = "Latest Version...";
			this.menuChartWizardLatest.Click += new System.EventHandler(this.menuChartWizardLatest_Click);
			// 
			// menuChartWizardPrevious
			// 
			this.menuChartWizardPrevious.Index = 1;
			this.menuChartWizardPrevious.Text = "Previous Version...";
			this.menuChartWizardPrevious.Click += new System.EventHandler(this.menuChartWizardPrevious_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 5;
			this.menuItem2.Text = "-";
			// 
			// menuHeaderVersion
			// 
			this.menuHeaderVersion.Index = 6;
			this.menuHeaderVersion.Text = "Header Version";
			this.menuHeaderVersion.Click += new System.EventHandler(this.menuHeaderVersion_Click);
			// 
			// menuFooterVersion
			// 
			this.menuFooterVersion.Index = 7;
			this.menuFooterVersion.Text = "Footer Version";
			this.menuFooterVersion.Click += new System.EventHandler(this.menuFooterVersion_Click);
			// 
			// menuPixelData
			// 
			this.menuPixelData.Index = 2;
			this.menuPixelData.Text = "     Aspect=0  0 x 0";
			// 
			// c1Chart1
			// 
			this.c1Chart1.DataSource = null;
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"PlotArea\" ParentName=\"Area\" StyleData=\"Border=None,Black,1;\" /><NamedStyle Nam" +
				"e=\"Legend\" ParentName=\"Legend.default\" /><NamedStyle Name=\"Footer\" ParentName=\"C" +
				"ontrol\" StyleData=\"Border=None,Black,1;\" /><NamedStyle Name=\"Area\" ParentName=\"A" +
				"rea.default\" /><NamedStyle Name=\"Control\" ParentName=\"Control.default\" /><NamedS" +
				"tyle Name=\"AxisX\" ParentName=\"Area\" StyleData=\"Rotation=Rotate0;AlignHorz=Center" +
				";AlignVert=Bottom;\" /><NamedStyle Name=\"AxisY\" ParentName=\"Area\" StyleData=\"Rota" +
				"tion=Rotate270;AlignHorz=Near;AlignVert=Center;\" /><NamedStyle Name=\"LabelStyleD" +
				"efault\" ParentName=\"LabelStyleDefault.default\" /><NamedStyle Name=\"Legend.defaul" +
				"t\" ParentName=\"Control\" StyleData=\"Border=None,Black,1;Wrap=False;AlignVert=Top;" +
				"\" /><NamedStyle Name=\"LabelStyleDefault.default\" ParentName=\"Control\" StyleData=" +
				"\"Border=None,Black,1;BackColor=Transparent;\" /><NamedStyle Name=\"Header\" ParentN" +
				"ame=\"Control\" StyleData=\"Border=None,Black,1;\" /><NamedStyle Name=\"Control.defau" +
				"lt\" ParentName=\"\" StyleData=\"ForeColor=ControlText;Border=None,Black,1;BackColor" +
				"=Control;\" /><NamedStyle Name=\"AxisY2\" ParentName=\"Area\" StyleData=\"Rotation=Rot" +
				"ate90;AlignHorz=Far;AlignVert=Center;\" /><NamedStyle Name=\"Area.default\" ParentN" +
				"ame=\"Control\" StyleData=\"Border=None,Black,1;AlignVert=Top;\" /></StyleCollection" +
				"><ChartGroupsCollection><ChartGroup Name=\"Group1\"><DataSerializer DefaultSet=\"Tr" +
				"ue\"><DataSeriesCollection><DataSeriesSerializer><LineStyle Color=\"DarkGoldenrod\"" +
				" /><SymbolStyle Color=\"Coral\" Shape=\"Box\" /><SeriesLabel>series 0</SeriesLabel><" +
				"X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><DataTypes>Single;Single;Double;Double;Doubl" +
				"e</DataTypes><DataFields>;;;;</DataFields></DataSeriesSerializer><DataSeriesSeri" +
				"alizer><LineStyle Color=\"DarkGray\" /><SymbolStyle Color=\"CornflowerBlue\" Shape=\"" +
				"Dot\" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><D" +
				"ataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFie" +
				"lds></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"DarkGreen\" />" +
				"<SymbolStyle Color=\"Cornsilk\" Shape=\"Tri\" /><SeriesLabel>series 2</SeriesLabel><" +
				"X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;Single;Double;Double;Doubl" +
				"e</DataTypes><DataFields>;;;;</DataFields></DataSeriesSerializer><DataSeriesSeri" +
				"alizer><LineStyle Color=\"DarkKhaki\" /><SymbolStyle Color=\"Crimson\" Shape=\"Diamon" +
				"d\" /><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><Da" +
				"taTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFiel" +
				"ds></DataSeriesSerializer></DataSeriesCollection></DataSerializer></ChartGroup><" +
				"ChartGroup Name=\"Group2\"><DataSerializer /></ChartGroup></ChartGroupsCollection>" +
				"<Header Compass=\"North\" /><Footer Compass=\"South\" /><Legend Compass=\"East\" Visib" +
				"le=\"False\" /><ChartArea /><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=\"0" +
				".5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"Sou" +
				"th\"><GridMajor /><GridMinor /></Axis><Axis Max=\"25\" Min=\"5\" UnitMajor=\"5\" UnitMi" +
				"nor=\"2.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compas" +
				"s=\"West\"><GridMajor /><GridMinor /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" Un" +
				"itMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Comp" +
				"ass=\"East\"><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(352, 240);
			this.c1Chart1.TabIndex = 0;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "doc1";
			// 
			// c1Chart3D1
			// 
			this.c1Chart3D1.Location = new System.Drawing.Point(176, 168);
			this.c1Chart3D1.Name = "c1Chart3D1";
			this.c1Chart3D1.PropBag = "<?xml version=\"1.0\"?><Chart3DPropBag Version=\"\"><View /><ChartGroupsCollection><C" +
				"hart3DGroup><ChartData><Set type=\"Chart3DDataSetGrid\" RowCount=\"11\" ColumnCount=" +
				"\"11\" RowDelta=\"1\" ColumnDelta=\"1\" RowOrigin=\"0\" ColumnOrigin=\"0\" Hole=\"3.4028234" +
				"663852886E+38\"><Data>4.499999888241291 3.599999874830246 2.8999998643994331 2.39" +
				"99998569488525 2.0999998524785042 1.9999998509883881 2.0999998524785042 2.399999" +
				"8569488525 2.8999998643994331 3.599999874830246 4.499999888241291 8.099999941885" +
				"4713 7.1999999284744263 6.4999999180436134 5.9999999105930328 5.6999999061226845" +
				" 5.5999999046325684 5.6999999061226845 5.9999999105930328 6.4999999180436134 7.1" +
				"999999284744263 8.0999999418854713 10.899999983608723 9.9999999701976776 9.29999" +
				"99597668648 8.7999999523162842 8.4999999478459358 8.39999994635582 8.49999994784" +
				"59358 8.7999999523162842 9.2999999597668648 9.9999999701976776 10.89999998360872" +
				"3 12.900000013411045 12 11.299999989569187 10.799999982118607 10.499999977648258" +
				" 10.399999976158142 10.499999977648258 10.799999982118607 11.299999989569187 12 " +
				"12.900000013411045 14.100000031292439 13.200000017881393 12.500000007450581 12 1" +
				"1.699999995529652 11.599999994039536 11.699999995529652 12 12.500000007450581 13" +
				".200000017881393 14.100000031292439 14.500000037252903 13.600000023841858 12.900" +
				"000013411045 12.400000005960465 12.100000001490116 12 12.100000001490116 12.4000" +
				"00005960465 12.900000013411045 13.600000023841858 14.500000037252903 14.10000003" +
				"1292439 13.200000017881393 12.500000007450581 12 11.699999995529652 11.599999994" +
				"039536 11.699999995529652 12 12.500000007450581 13.200000017881393 14.1000000312" +
				"92439 12.900000013411045 12 11.299999989569187 10.799999982118607 10.49999997764" +
				"8258 10.399999976158142 10.499999977648258 10.799999982118607 11.299999989569187" +
				" 12 12.900000013411045 10.899999983608723 9.9999999701976776 9.2999999597668648 " +
				"8.7999999523162842 8.4999999478459358 8.39999994635582 8.4999999478459358 8.7999" +
				"999523162842 9.2999999597668648 9.9999999701976776 10.899999983608723 8.09999994" +
				"18854713 7.1999999284744263 6.4999999180436134 5.9999999105930328 5.699999906122" +
				"6845 5.5999999046325684 5.6999999061226845 5.9999999105930328 6.4999999180436134" +
				" 7.1999999284744263 8.0999999418854713 4.499999888241291 3.599999874830246 2.899" +
				"9998643994331 2.3999998569488525 2.0999998524785042 1.9999998509883881 2.0999998" +
				"524785042 2.3999998569488525 2.8999998643994331 3.599999874830246 4.499999888241" +
				"291</Data></Set></ChartData></Chart3DGroup></ChartGroupsCollection><StyleCollect" +
				"ion><NamedStyle Name=\"Legend\" ParentName=\"Legend.default\" /><NamedStyle Name=\"Fo" +
				"oter\" ParentName=\"Control\" /><NamedStyle Name=\"Area\" ParentName=\"Area.default\" /" +
				"><NamedStyle Name=\"Control\" ParentName=\"Control.default\" /><NamedStyle Name=\"Lab" +
				"elStyleDefault\" ParentName=\"Control\" StyleData=\"BackColor=Transparent;\" /><Named" +
				"Style Name=\"Legend.default\" ParentName=\"Control\" StyleData=\"Wrap=False;AlignVert" +
				"=Top;\" /><NamedStyle Name=\"Header\" ParentName=\"Control\" /><NamedStyle Name=\"Cont" +
				"rol.default\" ParentName=\"\" StyleData=\"ForeColor=ControlText;Border=None,Black,1;" +
				"BackColor=Control;\" /><NamedStyle Name=\"Area.default\" ParentName=\"Control\" Style" +
				"Data=\"AlignVert=Top;\" /></StyleCollection><LegendData Compass=\"East\" /><FooterDa" +
				"ta Visible=\"True\" Compass=\"South\" /><HeaderData Visible=\"True\" Compass=\"North\" /" +
				"></Chart3DPropBag>";
			this.c1Chart3D1.Size = new System.Drawing.Size(280, 176);
			this.c1Chart3D1.TabIndex = 1;
			this.c1Chart3D1.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(488, 361);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1Chart3D1,
																		  this.c1Chart1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Show Chart 2D/3D Xml";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).EndInit();
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

		private void SetChartSelect(object sender, EventArgs e)
		{
			if(chart.use2d)
			{
				menuChartSelect.Text = "Switch to 3D chart";
				menuChartPropsPrevious.Enabled = true;
				menuChartWizardPrevious.Enabled = true;
			}
			else
			{
				menuChartSelect.Text = "Switch to 2D chart";
				menuChartPropsPrevious.Enabled = false;
				menuChartWizardPrevious.Enabled = false;
			}

			this.Text = chart.LastLoadedFile;
		}

		private void LoadChartInfo(string filename, bool versionCheck)
		{
			bool aspChecked = this.menuFixedAspect.Checked;
			this.menuFixedAspect.Checked = false;
			this.menuHeaderVersion.Checked = false;
			this.menuFooterVersion.Checked = false;
			chart.LoadChartFromFile(filename, versionCheck);
			this.Form1_Resize(null, null);
			this.menuFixedAspect.Checked = aspChecked;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			ClientSize = new Size(600,400);
			c1Chart1.Location = new Point(0);
			c1Chart1.BackColor = Color.White;
			c1Chart3D1.Location = new Point(0);
			c1Chart3D1.BackColor = Color.White;

			chart = new ChartHandler(c1Chart1, c1Chart3D1);
			chart.ChartTypeChanged += new EventHandler(SetChartSelect);

			chart.Size = this.ClientSize;

			string [] commandArgs = System.Environment.GetCommandLineArgs();
			if(commandArgs.Length > 1)
			{
				this.LoadChartInfo(commandArgs[1], false);
				if(commandArgs.Length > 2)
				{
					// spin off each extra argument as a separate process.
					for(int ia=2; ia < commandArgs.Length; ia++)
					{
						System.Diagnostics.Process.Start(commandArgs[0], commandArgs[ia]);
					}
				}
			}
			Form1_Resize(sender, e);
		}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
			if(chart == null) return;
			int minbounds = 10;

			int cw = chart.Width;
			int ch = chart.Height;
			double aspect = (double)ch / (double)cw;

			if(menuFixedAspect.Checked)
			{

				int fw = this.ClientSize.Width;
				int fh = this.ClientSize.Height;

				ch = (int)(fw * aspect);
				cw = (int)(fh / aspect);

				if(ch > fh)
					ch = fh;
				else
					cw = fw;
			}
			else
			{
				cw = this.ClientSize.Width;
				ch = this.ClientSize.Height;	
			}

			if(cw < minbounds)
				cw = minbounds;

			if(ch < minbounds)
				ch = minbounds;

			aspect = (double)ch / (double)cw;
			this.menuPixelData.Text = "     Aspect=" + aspect.ToString() +
				"   " + cw.ToString() + " x " + ch.ToString();

			chart.Size = new Size(cw, ch);
		}

		private string getVersionString()
		{
			return chart.AssemblyFileVersionString;;
		}

		private void menuFixedAspect_Click(object sender, System.EventArgs e)
		{
			menuFixedAspect.Checked = !menuFixedAspect.Checked;
			if(!menuFixedAspect.Checked)
				this.Form1_Resize(null,null);
		}
		
		private void menuHeaderVersion_Click(object sender, System.EventArgs e)
		{
			menuHeaderVersion.Checked = !menuHeaderVersion.Checked;
			if(menuHeaderVersion.Checked)
				chart.HeaderText = getVersionString();
			else
				chart.HeaderText = null;
		}

		private void menuFooterVersion_Click(object sender, System.EventArgs e)
		{
			menuFooterVersion.Checked = !menuFooterVersion.Checked;
			if(menuFooterVersion.Checked)
				chart.FooterText = getVersionString();
			else
				chart.FooterText = null;
		}

		private void menuExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void LoadChartWithVersion(bool versionCheck)
		{
			OpenFileDialog ofd = openFileDialog1;
			ofd.DefaultExt = chart.defExtension;
			if(chart.use2d)
				ofd.FilterIndex = 1;
			else
				ofd.FilterIndex = 2;
			ofd.Filter =	"Chart2DXml files (*.chart2dxml)|*.chart2dxml" +
				"|Chart3DXml files (*.chart3dxml)|*.chart3dxml" +
				"|All files (*.*)|*.*";

			DialogResult dr = ofd.ShowDialog(this);
			if(dr == DialogResult.OK)
			{
				this.LoadChartInfo(ofd.FileName, versionCheck);
				this.Text = chart.LastLoadedFile;
			}
		}

		private void menuLoad_Click(object sender, System.EventArgs e)
		{
			LoadChartWithVersion(false);
		}


		private void menuLoadVer_Click(object sender, System.EventArgs e)
		{
			LoadChartWithVersion(true);
		}


		private void menuSave_Click(object sender, System.EventArgs e)
		{
			chart.SaveChartToFile(chart.LastLoadedFile);
		}

		private void menuSaveAs_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog sfd = saveFileDialog1;
			sfd.DefaultExt = chart.defExtension;
			sfd.Filter = chart.FilterString +
				"|JPEG File Interchange Format (*.jpg)|*.jpg" +
				"|Portable Network Graphics (*.png)|*.png" +
				"|Graphics Interchange Format (*.gif)|*.gif" +
				"|Bitmap Image (*.bmp)|*.bmp" +
				"|Enhanced MetaFile (*.emf)|*.emf" +
				"|Windows MetaFile (*.wmf)|*.wmf";

			string defExtension = "." + chart.defExtension;
			string fstr = chart.LastLoadedFile;
			if(fstr.EndsWith(defExtension))
				fstr = fstr.Substring(0, fstr.Length - defExtension.Length);
			sfd.FileName = fstr;

			DialogResult dr = sfd.ShowDialog(this);
			if(dr == DialogResult.OK)
			{
				string newfile = sfd.FileName;
				string extension = newfile.Substring(newfile.LastIndexOf('.'));
				ImageFormat imgfmt = ImageFormat.Icon;

				switch(extension.ToLower())
				{
					case ".bmp":
						imgfmt = ImageFormat.Bmp;
						break;

					case ".jpeg":
					case ".jpg":
						imgfmt = ImageFormat.Jpeg;
						break;

					case ".gif":
						imgfmt = ImageFormat.Gif;
						break;

					case ".png":
						imgfmt = ImageFormat.Png;
						break;

					case ".emf":
					case ".wmf":
						imgfmt = ImageFormat.Emf;
						break;

					case ".chart2dxml":
					case ".chart3dxml":
						chart.SaveChartToFile(sfd.FileName);
						this.Text = chart.LastLoadedFile;
						break;
				}

				if(!imgfmt.Equals(ImageFormat.Icon))
				{
					chart.SaveImage(sfd.FileName, imgfmt);
				}
			}
		}

		private void menuPrintToFit_Click(object sender, System.EventArgs e)
		{
			chart.PrintChart();
		}

		private void menuPropGrid_Click(object sender, System.EventArgs e)
		{
			frmPropGrid fpg = new frmPropGrid();
			if(chart.use2d)
				fpg.ChartObject = c1Chart1;
			else
				fpg.ChartObject = c1Chart3D1;
			fpg.Show();
		}

		private void menuResetChart_Click(object sender, System.EventArgs e)
		{
			DialogResult dr = MessageBox.Show("The Chart is about to be Reset.  All data \n" +
				"and settings will be lost.   Continue?", "Reset Chart...", MessageBoxButtons.YesNo);
			if(dr == DialogResult.Yes)
				chart.ResetChart();		
		}

		private void menuChartSelect_Click(object sender, System.EventArgs e)
		{
			chart.use2d = !chart.use2d;
		}

		private void menuClientSize_Click(object sender, System.EventArgs e)
		{
			frmClientSize frm = new frmClientSize();
			frm.SetClientForm(this);
			frm.Show();
		}

		private string urlForLoad = "http://";

		private void LoadChartUrlVersion(bool versionCheck)
		{
			frmLoadURL frm = new frmLoadURL();

			frm.URL = urlForLoad;
			DialogResult dr = frm.ShowDialog();
			urlForLoad = frm.URL;

			if(dr == DialogResult.OK)
			{
				bool invalid = false;
				if(urlForLoad != null && urlForLoad != "")
					invalid = chart.LoadChartFromUrl(urlForLoad, versionCheck);

				if(urlForLoad == null || urlForLoad == "")
					MessageBox.Show("URL is invalid");
			}
		}

		private void menuLoadFromUrl_Click(object sender, System.EventArgs e)
		{
			LoadChartUrlVersion(false);
		}

		private void menuLoadFromUrlVersion_Click(object sender, System.EventArgs e)
		{
			LoadChartUrlVersion(true);
		}

		private void menuNewWindow_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("\"" + System.Environment.GetCommandLineArgs()[0] + "\"");		
		}

		private void menuLoadFromClipboard_Click(object sender, System.EventArgs e)
		{
			chart.LoadChartFromClipboard(false);
		}

		private void menuLoadFromClipboardVersion_Click(object sender, System.EventArgs e)
		{
			chart.LoadChartFromClipboard(true);
		}

		private void menuSaveToClipboard_Click(object sender, System.EventArgs e)
		{
			chart.SaveChartToClipboard();
		}

		private void menuChartPropsLatest_Click(object sender, System.EventArgs e)
		{
			chart.ShowProperties();
		}

		private void menuChartPropsPrevious_Click(object sender, System.EventArgs e)
		{
			chart.ShowPropertiesPrevious();
		}

		private void menuChartWizardLatest_Click(object sender, System.EventArgs e)
		{
			chart.ShowWizard();
		}

		private void menuChartWizardPrevious_Click(object sender, System.EventArgs e)
		{
			chart.ShowWizardPrevious();
		}
	}

	/// <summary>
	///   ChartHandler manages the 2D or 3D chart from a single object
	///   based on the last loaded type of chart xml.
	/// </summary>
	public class ChartHandler
	{
		private C1.Win.C1Chart.C1Chart chart2d = null;
		private C1.Win.C1Chart3D.C1Chart3D chart3d = null;
		private string Chart2dDefault = null;
		private string Chart3dDefault = null;

		private string lastLoaded2dFile = "chart2d.chart2dxml";
		private string lastLoaded3dFile = "chart3d.chart3dxml";

		private bool use2DChart = true;

		public ChartHandler(C1Chart c2d, C1Chart3D c3d)
		{
			chart2d = c2d;
			Chart2dDefault = c2d.SaveChartToString();

			chart3d = c3d;
			Chart3dDefault = c3d.SaveChartToString();
		}

		public event EventHandler ChartTypeChanged = null;
		public void OnChartTypeChanged(object sender, EventArgs e)
		{
			if(ChartTypeChanged != null)	//!!VBComment   
				ChartTypeChanged(sender, e);//!!VBSubst RaiseEvent ChartTypeChanged(sender, e)
		}

		public bool use2d
		{
			get { return use2DChart; }
			set
			{
				if(use2DChart == value)
					return;

				use2DChart = value;
				
				if(use2DChart)
				{
					chart2d.Size = chart3d.Size;
					chart2d.Visible = true;
					chart3d.Visible = false;
				}
				else
				{
					chart3d.Size = chart2d.Size;
					chart3d.Visible = true;
					chart2d.Visible = false;
				}

				OnChartTypeChanged(this, new EventArgs());
			}
		}

		public Color BackColor
		{
			get
			{
				if(use2d)
					return chart2d.BackColor;
				else
					return chart3d.BackColor;
			}
			set
			{
				if(use2d)
					chart2d.BackColor = value;
				else
					chart3d.BackColor = value;
			}
		}

		public Point Location
		{
			get
			{
				if(use2d)
					return chart2d.Location;
				else
					return chart3d.Location;
			}
			set
			{
				if(use2d)
					chart2d.Location = value;
				else
					chart3d.Location = value;
			}
		}

		public Size Size
		{	
			get
			{
				if(use2d)

					return chart2d.Size;
				else
					return chart3d.Size;
			}
			set
			{
				if(use2d)
					chart2d.Size = value;
				else
					chart3d.Size = value;
			}
		}

		public int Width
		{
			get
			{
				if(use2d)
					return chart2d.Width;
				else
					return chart3d.Width;
			}
		}

		public int Height
		{
			get
			{
				if(use2d)
					return chart2d.Height;
				else
					return chart3d.Height;
			}
		}

		public string HeaderText
		{
			get
			{
				if(use2d)
					return chart2d.Header.Text;
				else
					return chart3d.Header.Text;
			}
			set
			{
				if(use2d)
				{
					chart2d.Header.Text = value;
					chart2d.Header.Visible = true;
				}
				else
				{
					chart3d.Header.Text = value;
					chart3d.Header.Visible = true;
				}
			}
		}

		public string FooterText
		{
			get
			{
				if(use2d)
					return chart2d.Footer.Text;
				else
					return chart3d.Footer.Text;
			}
			set
			{
				if(use2d)
					chart2d.Footer.Text = value;
				else
					chart3d.Footer.Text = value;
			}
		}

		public string AssemblyFileVersionString
		{
			get
			{
				if(use2d)
					return chart2d.AssemblyFileVersionString;
				else
					return chart3d.AssemblyFileVersionString;
			}
		}

		public string defExtension
		{
			get
			{
				if(use2d)
					return "chart2dxml";
				else
					return "chart3dxml";
			}
		}

		public string LastLoadedFile
		{
			get
			{
				if(use2d)
					return lastLoaded2dFile;
				else
					return lastLoaded3dFile;
			}
		}

		public string FilterString
		{
			get
			{
				if(use2d)
					return "Chart2DXml files (*.chart2dxml)|*.chart2dxml";
				else
					return "Chart3DXml files (*.chart3dxml)|*.chart3dxml" ;
			}
		}

		private bool checkVersion(string bagstr, string contents, bool versionCheck)
		{
			bool rc = true;
			if(versionCheck)
			{
				int verIndex = contents.IndexOf(bagstr) + bagstr.Length + 1;
				string verstr = contents.Substring(verIndex, contents.IndexOf('"', verIndex) - verIndex);
				DialogResult dr = MessageBox.Show("Chart version in XML file is: " + verstr +
					".   Do you wish to continue loading?", "", MessageBoxButtons.YesNo);
				rc = (dr == DialogResult.Yes);
			}
			return rc;
		}

		private bool LoadChartFromStringContents(string contents, bool versionCheck)
		{
			string bag2d = "Chart2DPropBag Version=";
			string bag3d = "Chart3DPropBag Version=";
			if(contents.IndexOf(bag2d) >= 0)
			{
				use2d = true;
				if(!checkVersion(bag2d, contents, versionCheck))
					return false;
			}
			else if(contents.IndexOf(bag3d) >= 0)
			{
				use2d = false;
				if(!checkVersion(bag3d, contents, versionCheck))
					return false;
			}
			else
			{
				MessageBox.Show("File must be a C1Chart XML or C1Chart3D XML file.");
				return false;
			}

			if(use2d)
				chart2d.LoadChartFromString(contents);
			else
				chart3d.LoadChartFromString(contents);

			return true;
		}

		public bool LoadChartFromClipboard(bool versionCheck)
		{
			string contents = "";
			IDataObject ido = Clipboard.GetDataObject();
			if(ido.GetDataPresent(typeof(string)))
				contents = (string)ido.GetData(typeof(string));
			return LoadChartFromStringContents(contents, versionCheck);
		}

		public bool LoadChartFromUrl(string url, bool versionCheck)
		{
			WebClient wc = new WebClient();
			byte [] byteData = null;
			bool success = true;
			try
			{
				byteData = wc.DownloadData(url);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				success = false;
			}
			wc.Dispose();

			if(success)
			{
				string contents = Encoding.ASCII.GetString(byteData);
				success = LoadChartFromStringContents(contents, versionCheck);
			}

			return success;
		}

		public void LoadChartFromFile(string fname, bool versionCheck)
		{
			StreamReader sr = null;
			string contents = null;

			try
			{
				sr = File.OpenText(fname);
			}
			catch
			{
				return;
			}

			try
			{
				contents = sr.ReadToEnd();
			}
			catch
			{
				sr.Close();
				return;
			}

			sr.Close();

			if(LoadChartFromStringContents(contents, versionCheck))
			{
				if(use2d)
					this.lastLoaded2dFile = fname;
				else
					this.lastLoaded3dFile = fname;
			}
		}

		public void SaveChartToFile(string fname)
		{
			if(use2d)
			{
				chart2d.SaveChartToFile(fname);
				this.lastLoaded2dFile = fname;
			}
			else
			{
				chart3d.SaveChartToFile(fname);
				this.lastLoaded3dFile = fname;
			}
		}

		public void SaveChartToClipboard()
		{
			string chstr = null;
			if(use2d)
				chstr = chart2d.SaveChartToString();
			else
				chstr = chart3d.SaveChartToString();
			Clipboard.SetDataObject(chstr, true);
		}

		public void SaveImage(string fname, ImageFormat imgfmt)
		{
			if(use2d)
				chart2d.SaveImage(fname, imgfmt);
			else
				chart3d.SaveImage(fname, imgfmt);
		}

		public void PrintChart()
		{
			if(use2d)
				chart2d.PrintChart();
			else
				chart3d.PrintChart();
		}

		public void ResetChart()
		{
			if(use2d)
				chart2d.LoadChartFromString(this.Chart2dDefault);
			else
				chart3d.LoadChartFromString(this.Chart3dDefault);
		}

		public void ShowProperties()
		{
			if(use2d)
				chart2d.ShowProperties();
			else
				chart3d.ShowProperties();
		}

		public void ShowWizard()
		{
			if(use2d)
				chart2d.ShowWizard();
			else
				chart3d.ShowWizard();
		}

		public void ShowPropertiesPrevious()
		{
			if(use2d)
				chart2d.ShowProperties(DesignerDialogEnum.V1);
			else
				chart3d.ShowProperties();
		}

		public void ShowWizardPrevious()
		{
			if(use2d)
				chart2d.ShowWizard(DesignerDialogEnum.V2);
			else
				chart3d.ShowWizard();
		}
	}
}
