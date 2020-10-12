using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PrintIt
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.MenuItem menuItemFileOpen;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItemPageSetup;
		private System.Windows.Forms.MenuItem menuItemPrint;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.MenuItem menuItemSaveAs;
		private System.Windows.Forms.MenuItem menuItemSaveImageAs;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.RadioButton rbClip;
		private System.Windows.Forms.RadioButton rbFile;
		private System.Windows.Forms.RadioButton rbPrinter;
		private System.Windows.Forms.RadioButton rbImage;
		private System.Windows.Forms.TextBox tbWidth;
		private System.Windows.Forms.TextBox tbHeigth;
		private System.Windows.Forms.RadioButton rbBmp;
		private System.Windows.Forms.RadioButton rbEMF;
		private System.Windows.Forms.RadioButton rbNone;
		private System.Windows.Forms.RadioButton rbMax;
		private System.Windows.Forms.RadioButton rbHeight;
		private System.Windows.Forms.RadioButton rbWidth;
		private System.Windows.Forms.RadioButton rbFit;
		private System.Windows.Forms.TextBox tbTop;
		private System.Windows.Forms.TextBox tbLeft;
		private System.Windows.Forms.GroupBox gbPrnFmt;
		private System.Windows.Forms.GroupBox gbScale;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		private C1.Win.C1Chart3D.C1Chart3D c1Chart3D1;
		private System.Windows.Forms.MenuItem menuFileOpenChart;
		private System.Windows.Forms.MenuItem menuFileOpenChart3D;
		private System.ComponentModel.IContainer components=null;

		public Form1()
		{
			InitializeComponent();
		}

		Size getSize()
		{
			Size sz = Size.Empty;
			try
			{
				sz.Width = int.Parse( tbWidth.Text);
				sz.Height = int.Parse( tbHeigth.Text);
			}
			catch
			{
				sz = Size.Empty;
			}
			return sz;
		}

		Rectangle getRect()
		{
			Rectangle rect = Rectangle.Empty;

			try
			{
				rect.X = int.Parse( tbLeft.Text);
				rect.Y = int.Parse( tbTop.Text);
				rect.Width = int.Parse( tbWidth.Text);
				rect.Height = int.Parse( tbHeigth.Text);
			}
			catch
			{
				rect.X = 0;
				rect.Y = 0;
				if( c1Chart1.Visible)
				{
					rect.Width = c1Chart1.Width;
					rect.Height = c1Chart1.Height;
				}
				else
				{
					rect.Width = c1Chart3D1.Width;
					rect.Height = c1Chart3D1.Height;
				}
			}

			return rect;
		}

		System.Drawing.Imaging.ImageFormat getFormat()
		{
			if( rbBmp.Checked)
				return System.Drawing.Imaging.ImageFormat.Bmp;
			else
				return System.Drawing.Imaging.ImageFormat.Emf;
		}

		private System.Drawing.Imaging.ImageFormat getImageFormatFromDlg( int index)
		{
			switch(index)
			{
				case 1: return System.Drawing.Imaging.ImageFormat.Bmp;
				case 2: return System.Drawing.Imaging.ImageFormat.Emf;
				case 3: return System.Drawing.Imaging.ImageFormat.Gif;
				case 4: return System.Drawing.Imaging.ImageFormat.Jpeg;
				case 5: return System.Drawing.Imaging.ImageFormat.Png;
				default: return System.Drawing.Imaging.ImageFormat.Bmp;
			}
		}

		C1.Win.C1Chart.PrintScaleEnum getScale()
		{
			if( rbNone.Checked)
				return C1.Win.C1Chart.PrintScaleEnum.ScaleNone;
			else if( rbFit.Checked)
				return C1.Win.C1Chart.PrintScaleEnum.ScaleToFit;
			else if( rbMax.Checked)
				return C1.Win.C1Chart.PrintScaleEnum.ScaleToMax;
			else if( rbHeight.Checked)
				return C1.Win.C1Chart.PrintScaleEnum.ScaleToHeight;
			else
				return C1.Win.C1Chart.PrintScaleEnum.ScaleToWidth;
		}

		void saveImageAs()
		{
			SaveFileDialog sfd = new SaveFileDialog();

			sfd.Filter = "Bitmap (*.bmp)|*.bmp|"
				+ "EMF Enhanced Metafile Format (*.emf)|*.emf|"
				+ "Graphics Interchange Format (*.gif)|*.gif|"
				+ "Joint Photographic Experts Group (*.jpg)|*.jpg|"
				+ "W3C Portable Network Graphics (*.png)|*.png";
			sfd.DefaultExt = "bmp";
			sfd.FileName = "image1";
			sfd.OverwritePrompt = true;
			sfd.CheckPathExists = true;
			sfd.RestoreDirectory = false;
			sfd.ValidateNames = true;

			if( sfd.ShowDialog(this) == DialogResult.OK)
			{
				if( c1Chart1.Visible)
					c1Chart1.SaveImage( sfd.FileName, getImageFormatFromDlg(sfd.FilterIndex), getSize());
				else
					c1Chart3D1.SaveImage( sfd.FileName, getImageFormatFromDlg(sfd.FilterIndex), getSize());
			}
		}

		void print()
		{
			if(rbImage.Checked)
			{
				// create form and put image in it
				Size sz = getSize();
				System.Drawing.Imaging.ImageFormat fmt = getFormat();

				frmCanvas canvas = new frmCanvas();
				if( c1Chart1.Visible)
					canvas.pictureBox1.Image = c1Chart1.GetImage( fmt, sz);
				else
					canvas.pictureBox1.Image = c1Chart3D1.GetImage( fmt, sz);

				canvas.Text = string.Format( "Image format:{0}, width:{1}, height:{2}", fmt.ToString(), sz.Width, sz.Height);
				canvas.ShowDialog( this);
			}
			else if (rbClip.Checked)
			{
				// put to the clipboard
				if( c1Chart1.Visible)
					c1Chart1.SaveImage( getFormat(), getSize());
				else
					c1Chart3D1.SaveImage( getFormat(), getSize());
			}
			else if (rbFile.Checked)
			{
				// save as file
				saveImageAs();
			}
			else
			{
				// print chart
				if( c1Chart1.Visible)
					c1Chart1.PrintChart( getScale(), getRect());
				else
					c1Chart3D1.PrintChart( (C1.Win.C1Chart3D.PrintScaleEnum)getScale(), getRect());
			}
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
			this.menuItemFile = new System.Windows.Forms.MenuItem();
			this.menuItemFileOpen = new System.Windows.Forms.MenuItem();
			this.menuFileOpenChart = new System.Windows.Forms.MenuItem();
			this.menuFileOpenChart3D = new System.Windows.Forms.MenuItem();
			this.menuItemSaveAs = new System.Windows.Forms.MenuItem();
			this.menuItemSaveImageAs = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItemPageSetup = new System.Windows.Forms.MenuItem();
			this.menuItemPrint = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItemExit = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnPrint = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbHeigth = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbWidth = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbLeft = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbTop = new System.Windows.Forms.TextBox();
			this.gbScale = new System.Windows.Forms.GroupBox();
			this.rbFit = new System.Windows.Forms.RadioButton();
			this.rbWidth = new System.Windows.Forms.RadioButton();
			this.rbHeight = new System.Windows.Forms.RadioButton();
			this.rbMax = new System.Windows.Forms.RadioButton();
			this.rbNone = new System.Windows.Forms.RadioButton();
			this.gbPrnFmt = new System.Windows.Forms.GroupBox();
			this.rbEMF = new System.Windows.Forms.RadioButton();
			this.rbBmp = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbPrinter = new System.Windows.Forms.RadioButton();
			this.rbFile = new System.Windows.Forms.RadioButton();
			this.rbClip = new System.Windows.Forms.RadioButton();
			this.rbImage = new System.Windows.Forms.RadioButton();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.c1Chart3D1 = new C1.Win.C1Chart3D.C1Chart3D();
			this.panel1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.gbScale.SuspendLayout();
			this.gbPrnFmt.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItemFile,
																																							this.menuItem1});
			// 
			// menuItemFile
			// 
			this.menuItemFile.Index = 0;
			this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																								 this.menuItemFileOpen,
																																								 this.menuItemSaveAs,
																																								 this.menuItemSaveImageAs,
																																								 this.menuItem4,
																																								 this.menuItemPageSetup,
																																								 this.menuItemPrint,
																																								 this.menuItem7,
																																								 this.menuItemExit});
			this.menuItemFile.Text = "&File";
			// 
			// menuItemFileOpen
			// 
			this.menuItemFileOpen.Index = 0;
			this.menuItemFileOpen.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																										 this.menuFileOpenChart,
																																										 this.menuFileOpenChart3D});
			this.menuItemFileOpen.Text = "&Open";
			// 
			// menuFileOpenChart
			// 
			this.menuFileOpenChart.Index = 0;
			this.menuFileOpenChart.Text = "Chart ...";
			this.menuFileOpenChart.Click += new System.EventHandler(this.menuFileOpenChart_Click);
			// 
			// menuFileOpenChart3D
			// 
			this.menuFileOpenChart3D.Index = 1;
			this.menuFileOpenChart3D.Text = "Chart 3D ...";
			this.menuFileOpenChart3D.Click += new System.EventHandler(this.menuFileOpenChart3D_Click);
			// 
			// menuItemSaveAs
			// 
			this.menuItemSaveAs.Index = 1;
			this.menuItemSaveAs.Text = "Save &As...";
			this.menuItemSaveAs.Click += new System.EventHandler(this.menuItemSaveAs_Click);
			// 
			// menuItemSaveImageAs
			// 
			this.menuItemSaveImageAs.Index = 2;
			this.menuItemSaveImageAs.Text = "Save &Image As...";
			this.menuItemSaveImageAs.Click += new System.EventHandler(this.menuItemSaveImageAs_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 3;
			this.menuItem4.Text = "-";
			// 
			// menuItemPageSetup
			// 
			this.menuItemPageSetup.Index = 4;
			this.menuItemPageSetup.Text = "Page Set&up...";
			this.menuItemPageSetup.Click += new System.EventHandler(this.menuItemPageSetup_Click);
			// 
			// menuItemPrint
			// 
			this.menuItemPrint.Index = 5;
			this.menuItemPrint.Text = "&Print";
			this.menuItemPrint.Click += new System.EventHandler(this.menuItemPrint_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 6;
			this.menuItem7.Text = "-";
			// 
			// menuItemExit
			// 
			this.menuItemExit.Index = 7;
			this.menuItemExit.Text = "&Exit";
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuHelpAbout});
			this.menuItem1.Text = "&Help";
			// 
			// menuHelpAbout
			// 
			this.menuHelpAbout.Index = 0;
			this.menuHelpAbout.Text = "&About";
			this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.FileName = "chart2D1";
			this.saveFileDialog.Filter = "Chart2D XML files (*.chart2dxml)|*.chart2dxml";
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "Chart2D XML files (*.chart2dxml)|*.chart2dxml";
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																				 this.btnPrint,
																																				 this.groupBox4,
																																				 this.gbScale,
																																				 this.gbPrnFmt,
																																				 this.groupBox1});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(216, 403);
			this.panel1.TabIndex = 2;
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(112, 272);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(96, 23);
			this.btnPrint.TabIndex = 4;
			this.btnPrint.Text = "Print";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.label4,
																																						this.tbHeigth,
																																						this.label3,
																																						this.tbWidth,
																																						this.label2,
																																						this.tbLeft,
																																						this.label1,
																																						this.tbTop});
			this.groupBox4.Location = new System.Drawing.Point(112, 120);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(96, 144);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Size/Location";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "Height";
			// 
			// tbHeigth
			// 
			this.tbHeigth.Location = new System.Drawing.Point(56, 112);
			this.tbHeigth.Name = "tbHeigth";
			this.tbHeigth.Size = new System.Drawing.Size(32, 20);
			this.tbHeigth.TabIndex = 10;
			this.tbHeigth.Text = "0";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 16);
			this.label3.TabIndex = 9;
			this.label3.Text = "Width";
			// 
			// tbWidth
			// 
			this.tbWidth.Location = new System.Drawing.Point(56, 80);
			this.tbWidth.Name = "tbWidth";
			this.tbWidth.Size = new System.Drawing.Size(32, 20);
			this.tbWidth.TabIndex = 8;
			this.tbWidth.Text = "0";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Left";
			// 
			// tbLeft
			// 
			this.tbLeft.Enabled = false;
			this.tbLeft.Location = new System.Drawing.Point(56, 48);
			this.tbLeft.Name = "tbLeft";
			this.tbLeft.Size = new System.Drawing.Size(32, 20);
			this.tbLeft.TabIndex = 6;
			this.tbLeft.Text = "0";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Top";
			// 
			// tbTop
			// 
			this.tbTop.Enabled = false;
			this.tbTop.Location = new System.Drawing.Point(56, 16);
			this.tbTop.Name = "tbTop";
			this.tbTop.Size = new System.Drawing.Size(32, 20);
			this.tbTop.TabIndex = 4;
			this.tbTop.Text = "0";
			// 
			// gbScale
			// 
			this.gbScale.Controls.AddRange(new System.Windows.Forms.Control[] {
																																					this.rbFit,
																																					this.rbWidth,
																																					this.rbHeight,
																																					this.rbMax,
																																					this.rbNone});
			this.gbScale.Enabled = false;
			this.gbScale.Location = new System.Drawing.Point(8, 120);
			this.gbScale.Name = "gbScale";
			this.gbScale.Size = new System.Drawing.Size(96, 144);
			this.gbScale.TabIndex = 2;
			this.gbScale.TabStop = false;
			this.gbScale.Text = "Scale Method";
			// 
			// rbFit
			// 
			this.rbFit.Location = new System.Drawing.Point(8, 40);
			this.rbFit.Name = "rbFit";
			this.rbFit.Size = new System.Drawing.Size(72, 24);
			this.rbFit.TabIndex = 7;
			this.rbFit.Text = "To Fit";
			// 
			// rbWidth
			// 
			this.rbWidth.Location = new System.Drawing.Point(8, 112);
			this.rbWidth.Name = "rbWidth";
			this.rbWidth.Size = new System.Drawing.Size(72, 24);
			this.rbWidth.TabIndex = 6;
			this.rbWidth.Text = "To Width";
			// 
			// rbHeight
			// 
			this.rbHeight.Location = new System.Drawing.Point(8, 88);
			this.rbHeight.Name = "rbHeight";
			this.rbHeight.Size = new System.Drawing.Size(72, 24);
			this.rbHeight.TabIndex = 5;
			this.rbHeight.Text = "To Height";
			// 
			// rbMax
			// 
			this.rbMax.Location = new System.Drawing.Point(8, 64);
			this.rbMax.Name = "rbMax";
			this.rbMax.Size = new System.Drawing.Size(72, 24);
			this.rbMax.TabIndex = 4;
			this.rbMax.Text = "To Max";
			// 
			// rbNone
			// 
			this.rbNone.Checked = true;
			this.rbNone.Location = new System.Drawing.Point(8, 16);
			this.rbNone.Name = "rbNone";
			this.rbNone.Size = new System.Drawing.Size(72, 24);
			this.rbNone.TabIndex = 3;
			this.rbNone.TabStop = true;
			this.rbNone.Text = "None";
			// 
			// gbPrnFmt
			// 
			this.gbPrnFmt.Controls.AddRange(new System.Windows.Forms.Control[] {
																																					 this.rbEMF,
																																					 this.rbBmp});
			this.gbPrnFmt.Location = new System.Drawing.Point(112, 8);
			this.gbPrnFmt.Name = "gbPrnFmt";
			this.gbPrnFmt.Size = new System.Drawing.Size(96, 112);
			this.gbPrnFmt.TabIndex = 1;
			this.gbPrnFmt.TabStop = false;
			this.gbPrnFmt.Text = "Print Format";
			// 
			// rbEMF
			// 
			this.rbEMF.Location = new System.Drawing.Point(8, 40);
			this.rbEMF.Name = "rbEMF";
			this.rbEMF.Size = new System.Drawing.Size(80, 24);
			this.rbEMF.TabIndex = 3;
			this.rbEMF.Text = "EMF";
			// 
			// rbBmp
			// 
			this.rbBmp.Checked = true;
			this.rbBmp.Location = new System.Drawing.Point(8, 16);
			this.rbBmp.Name = "rbBmp";
			this.rbBmp.Size = new System.Drawing.Size(80, 24);
			this.rbBmp.TabIndex = 2;
			this.rbBmp.TabStop = true;
			this.rbBmp.Text = "Bitmap";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.rbPrinter,
																																						this.rbFile,
																																						this.rbClip,
																																						this.rbImage});
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(96, 112);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Print Location";
			// 
			// rbPrinter
			// 
			this.rbPrinter.Location = new System.Drawing.Point(8, 88);
			this.rbPrinter.Name = "rbPrinter";
			this.rbPrinter.Size = new System.Drawing.Size(56, 16);
			this.rbPrinter.TabIndex = 4;
			this.rbPrinter.Text = "Printer";
			this.rbPrinter.CheckedChanged += new System.EventHandler(this.rbPrnLoc_CheckedChanged);
			// 
			// rbFile
			// 
			this.rbFile.Location = new System.Drawing.Point(8, 64);
			this.rbFile.Name = "rbFile";
			this.rbFile.Size = new System.Drawing.Size(56, 16);
			this.rbFile.TabIndex = 3;
			this.rbFile.Text = "File";
			this.rbFile.CheckedChanged += new System.EventHandler(this.rbPrnLoc_CheckedChanged);
			// 
			// rbClip
			// 
			this.rbClip.Location = new System.Drawing.Point(8, 40);
			this.rbClip.Name = "rbClip";
			this.rbClip.Size = new System.Drawing.Size(72, 16);
			this.rbClip.TabIndex = 2;
			this.rbClip.Text = "Clipboard";
			this.rbClip.CheckedChanged += new System.EventHandler(this.rbPrnLoc_CheckedChanged);
			// 
			// rbImage
			// 
			this.rbImage.Checked = true;
			this.rbImage.Location = new System.Drawing.Point(8, 16);
			this.rbImage.Name = "rbImage";
			this.rbImage.Size = new System.Drawing.Size(72, 16);
			this.rbImage.TabIndex = 1;
			this.rbImage.TabStop = true;
			this.rbImage.Text = "Image";
			this.rbImage.CheckedChanged += new System.EventHandler(this.rbPrnLoc_CheckedChanged);
			// 
			// splitter1
			// 
			this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitter1.Location = new System.Drawing.Point(216, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(4, 403);
			this.splitter1.TabIndex = 4;
			this.splitter1.TabStop = false;
			// 
			// c1Chart1
			// 
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Location = new System.Drawing.Point(220, 0);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><ChartGroupsCollection><ChartGrou" +
				"p><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Pol" +
				"ar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Fille" +
				"d=False,Start=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group1</Name><Chart" +
				"Type>XYPlot</ChartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,M" +
				"aximumSize=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=T" +
				"rue,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer Defau" +
				"ltSet=\"True\"><DataSeriesCollection><DataSeriesSerializer><Y2 /><Y3 /><Y>20;22;19" +
				";24;25</Y><LineStyle Thickness=\"1\" Color=\"DarkGoldenrod\" Pattern=\"Solid\" /><Symb" +
				"olStyle Shape=\"Box\" Color=\"Coral\" /><Y1 /><SeriesLabel>series 0</SeriesLabel><Da" +
				"taTypes>Single;Single;Single;Single;Single</DataTypes><X>1;2;3;4;5</X></DataSeri" +
				"esSerializer><DataSeriesSerializer><Y2 /><Y3 /><Y>8;12;10;12;15</Y><LineStyle Th" +
				"ickness=\"1\" Color=\"DarkGray\" Pattern=\"Solid\" /><SymbolStyle Shape=\"Dot\" Color=\"C" +
				"ornflowerBlue\" /><Y1 /><SeriesLabel>series 1</SeriesLabel><DataTypes>Single;Sing" +
				"le;Single;Single;Single</DataTypes><X>1;2;3;4;5</X></DataSeriesSerializer><DataS" +
				"eriesSerializer><Y2 /><Y3 /><Y>10;16;17;15;23</Y><LineStyle Thickness=\"1\" Color=" +
				"\"DarkGreen\" Pattern=\"Solid\" /><SymbolStyle Shape=\"Tri\" Color=\"Cornsilk\" /><Y1 />" +
				"<SeriesLabel>series 2</SeriesLabel><DataTypes>Single;Single;Single;Single;Single" +
				"</DataTypes><X>1;2;3;4;5</X></DataSeriesSerializer><DataSeriesSerializer><Y2 /><" +
				"Y3 /><Y>16;19;15;22;18</Y><LineStyle Thickness=\"1\" Color=\"DarkKhaki\" Pattern=\"So" +
				"lid\" /><SymbolStyle Shape=\"Diamond\" Color=\"Crimson\" /><Y1 /><SeriesLabel>series " +
				"3</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><X>1;2;3" +
				";4;5</X></DataSeriesSerializer></DataSeriesCollection></DataSerializer></ChartGr" +
				"oup><ChartGroup><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</Sh" +
				"owOutline><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degr" +
				"ees=True,Filled=False,Start=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group" +
				"2</Name><ChartType>XYPlot</ChartType><Stacked>False</Stacked><Bubble>EncodingMet" +
				"hod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,Fil" +
				"lTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><DataSe" +
				"rializer /></ChartGroup></ChartGroupsCollection><StyleCollection><NamedStyle><Pa" +
				"rentName>Area</ParentName><StyleData>Border=None,Control,1;</StyleData><Name>Plo" +
				"tArea</Name></NamedStyle><NamedStyle><ParentName>Legend.default</ParentName><Sty" +
				"leData /><Name>Legend</Name></NamedStyle><NamedStyle><ParentName>Control</Parent" +
				"Name><StyleData>Border=None,Control,1;</StyleData><Name>Footer</Name></NamedStyl" +
				"e><NamedStyle><ParentName>Area.default</ParentName><StyleData /><Name>Area</Name" +
				"></NamedStyle><NamedStyle><ParentName>Control.default</ParentName><StyleData /><" +
				"Name>Control</Name></NamedStyle><NamedStyle><ParentName>Area</ParentName><StyleD" +
				"ata>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor=Transparen" +
				"t;AlignVert=Bottom;</StyleData><Name>AxisX</Name></NamedStyle><NamedStyle><Paren" +
				"tName>Area</ParentName><StyleData>Rotation=Rotate270;Border=None,Control,1;Align" +
				"Horz=Near;BackColor=Transparent;AlignVert=Center;</StyleData><Name>AxisY</Name><" +
				"/NamedStyle><NamedStyle><ParentName>LabelStyleDefault.default</ParentName><Style" +
				"Data /><Name>LabelStyleDefault</Name></NamedStyle><NamedStyle><ParentName>Contro" +
				"l</ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleDat" +
				"a><Name>Legend.default</Name></NamedStyle><NamedStyle><ParentName>Control</Paren" +
				"tName><StyleData>Border=None,Control,1;BackColor=Transparent;</StyleData><Name>L" +
				"abelStyleDefault.default</Name></NamedStyle><NamedStyle><ParentName>Control</Par" +
				"entName><StyleData>Border=None,Control,1;</StyleData><Name>Header</Name></NamedS" +
				"tyle><NamedStyle><ParentName /><StyleData>ForeColor=ControlText;Border=None,Cont" +
				"rol,1;BackColor=Control;</StyleData><Name>Control.default</Name></NamedStyle><Na" +
				"medStyle><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;Border=None,T" +
				"ransparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData><N" +
				"ame>AxisY2</Name></NamedStyle><NamedStyle><ParentName>Control</ParentName><Style" +
				"Data>Border=None,Control,1;AlignVert=Top;</StyleData><Name>Area.default</Name></" +
				"NamedStyle></StyleCollection><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor" +
				"=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0" +
				"\" Compass=\"South\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pa" +
				"ttern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Patte" +
				"rn=\"Dash\" /><Text /></Axis><Axis Max=\"25\" Min=\"8\" UnitMajor=\"2\" UnitMinor=\"1\" Au" +
				"toMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass" +
				"=\"West\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Das" +
				"h\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" " +
				"/><Text /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"Tr" +
				"ue\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"East\"><Gr" +
				"idMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridM" +
				"inor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><Text /><" +
				"/Axis></Axes><Header Compass=\"North\" Visible=\"False\"><Text /></Header><Footer Co" +
				"mpass=\"South\" Visible=\"False\"><Text /></Footer><Legend Compass=\"East\" Visible=\"F" +
				"alse\"><Text /></Legend><ChartArea /></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(372, 403);
			this.c1Chart1.TabIndex = 6;
			// 
			// c1Chart3D1
			// 
			this.c1Chart3D1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart3D1.Location = new System.Drawing.Point(220, 0);
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
				"9999986 2.89999986 3.6 4.5 </Data></Set></ChartData><Bar /><Surface /><Contour /" +
				"></Chart3DGroup></ChartGroupsCollection><ContourStyles ColorSet=\"Custom\"><Colors" +
				"><Color>Black</Color><Color>Red</Color></Colors></ContourStyles><LegendData Comp" +
				"ass=\"East\" /><StyleCollection><NamedStyle Name=\"Legend\" ParentName=\"Legend.defau" +
				"lt\" StyleData=\"\" /><NamedStyle Name=\"Footer\" ParentName=\"Control\" StyleData=\"\" /" +
				"><NamedStyle Name=\"Area\" ParentName=\"Area.default\" StyleData=\"\" /><NamedStyle Na" +
				"me=\"Control\" ParentName=\"Control.default\" StyleData=\"\" /><NamedStyle Name=\"Label" +
				"StyleDefault\" ParentName=\"Control\" StyleData=\"BackColor=Transparent;\" /><NamedSt" +
				"yle Name=\"Legend.default\" ParentName=\"Control\" StyleData=\"Wrap=False;AlignVert=T" +
				"op;\" /><NamedStyle Name=\"Header\" ParentName=\"Control\" StyleData=\"\" /><NamedStyle" +
				" Name=\"Control.default\" ParentName=\"\" StyleData=\"ForeColor=ControlText;BackColor" +
				"=Control;\" /><NamedStyle Name=\"Area.default\" ParentName=\"Control\" StyleData=\"Ali" +
				"gnVert=Top;\" /></StyleCollection><FooterData Visible=\"True\" Compass=\"South\" /><V" +
				"iew AxisTitleFont=\"Microsoft Sans Serif, 12world\" AxisFont=\"Microsoft Sans Serif" +
				", 10world\"><Ceiling /><Floor /></View><HeaderData Visible=\"True\" Compass=\"North\"" +
				" /></Chart3DPropBag>";
			this.c1Chart3D1.Size = new System.Drawing.Size(372, 403);
			this.c1Chart3D1.TabIndex = 7;
			this.c1Chart3D1.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 403);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.c1Chart1,
																																	this.c1Chart3D1,
																																	this.splitter1,
																																	this.panel1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComponentOne Chart for .NET - PrintIt Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.gbScale.ResumeLayout(false);
			this.gbPrnFmt.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		
		private string filename = string.Empty; //default

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void menuItemPageSetup_Click(object sender, System.EventArgs e)
		{
			c1Chart1.PageSetup();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			tbWidth.Text = c1Chart1.Width.ToString();
			tbHeigth.Text = c1Chart1.Height.ToString();
		}

		private void menuItemSaveImageAs_Click(object sender, System.EventArgs e)
		{
			saveImageAs();
		}

		private void menuItemExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			print();
		}

		private void rbPrnLoc_CheckedChanged(object sender, System.EventArgs e)
		{
			gbPrnFmt.Enabled = rbImage.Checked || rbClip.Checked;
			gbScale.Enabled = rbPrinter.Checked;

			tbTop.Enabled = rbPrinter.Checked;
			tbLeft.Enabled = rbPrinter.Checked;
		}

		private void menuItemPrint_Click(object sender, System.EventArgs e)
		{
			print();
		}

		private void menuItemSaveAs_Click(object sender, System.EventArgs e)
		{
			if( !filename.Equals( string.Empty))
				saveFileDialog.FileName = filename;

			if( c1Chart1.Visible)
				saveFileDialog.Filter = "Chart2D XML files (*.chart2dxml)|*.chart2dxml";
			else
				saveFileDialog.Filter = "Chart3D XML files (*.chart3dxml)|*.chart3dxml";

			if(	saveFileDialog.ShowDialog(this)==DialogResult.OK)
			{
				filename = saveFileDialog.FileName;
				if( c1Chart1.Visible)
					c1Chart1.SaveChartToFile(filename);
				else
					c1Chart3D1.SaveChartToFile(filename);
			}
		}

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void menuFileOpenChart_Click(object sender, System.EventArgs e)
		{
			openFileDialog.Filter = "Chart2D XML files (*.chart2dxml)|*.chart2dxml";
			if(	openFileDialog.ShowDialog(this)==DialogResult.OK)
			{
				filename = openFileDialog.FileName;
				c1Chart1.LoadChartFromFile(filename);
				c1Chart1.Visible = true;
				c1Chart3D1.Visible = false;
			}
		}

		private void menuFileOpenChart3D_Click(object sender, System.EventArgs e)
		{
			openFileDialog.Filter = "Chart3D XML files (*.chart3dxml)|*.chart3dxml";
			if(	openFileDialog.ShowDialog(this)==DialogResult.OK)
			{
				filename = openFileDialog.FileName;
				c1Chart3D1.LoadChartFromFile(filename);
				c1Chart3D1.Visible = true;
				c1Chart1.Visible = false;
			}
		}
	}
}
