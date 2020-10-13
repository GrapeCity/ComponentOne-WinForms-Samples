using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data;

namespace SampleCenter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Splitter splitter2;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.RichTextBox rtfCode;
		private System.Windows.Forms.ImageList ilToolbar;
		private SampleCenter.CustomPictureBox pictureBox1;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton tbCS;
		private System.Windows.Forms.ToolBarButton tbVB;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton tbCopy;
		private System.Windows.Forms.Panel panel4;
		private SampleCenter.CustomTreeView treeView1;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.ImageList ilTree;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.Panel panel5;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
#if DEBUG
			this.treeView1.LabelEdit = true;
			this.treeView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseUp);
			this.treeView1.AfterLabelEdit += new NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);

			this.Text += " - Debug Version.  Double Click C1 Image for instructions.";
			this.pictureBox1.DoubleClick += new EventHandler(ShowInstructions);
#endif
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.treeView1 = new SampleCenter.CustomTreeView();
			this.ilTree = new System.Windows.Forms.ImageList(this.components);
			this.panel4 = new System.Windows.Forms.Panel();
			this.lblInfo = new System.Windows.Forms.Label();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.tbCS = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.tbVB = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.tbCopy = new System.Windows.Forms.ToolBarButton();
			this.ilToolbar = new System.Windows.Forms.ImageList(this.components);
			this.pictureBox1 = new SampleCenter.CustomPictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.rtfCode = new System.Windows.Forms.RichTextBox();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.treeView1,
																				 this.panel4});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(205, 453);
			this.panel1.TabIndex = 1;
			// 
			// treeView1
			// 
			this.treeView1.BackColor = System.Drawing.SystemColors.Control;
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.HideSelection = false;
			this.treeView1.HotTracking = true;
			this.treeView1.ImageList = this.ilTree;
			this.treeView1.ItemHeight = 20;
			this.treeView1.Name = "treeView1";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
																				  new System.Windows.Forms.TreeNode("Basic Chart Types", new System.Windows.Forms.TreeNode[] {
																																												 new System.Windows.Forms.TreeNode("Bar"),
																																												 new System.Windows.Forms.TreeNode("Pie")})});
			this.treeView1.SelectedImageIndex = 1;
			this.treeView1.Size = new System.Drawing.Size(205, 405);
			this.treeView1.TabIndex = 2;
			this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
			this.treeView1.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCollapse);
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
			// 
			// ilTree
			// 
			this.ilTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ilTree.ImageSize = new System.Drawing.Size(19, 16);
			this.ilTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTree.ImageStream")));
			this.ilTree.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// panel4
			// 
			this.panel4.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.lblInfo});
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.DockPadding.All = 2;
			this.panel4.Location = new System.Drawing.Point(0, 405);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(205, 48);
			this.panel4.TabIndex = 1;
			// 
			// lblInfo
			// 
			this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblInfo.Location = new System.Drawing.Point(2, 2);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(201, 44);
			this.lblInfo.TabIndex = 0;
			this.lblInfo.Text = "label1";
			this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(205, 0);
			this.splitter1.MinExtra = 200;
			this.splitter1.MinSize = 200;
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(4, 453);
			this.splitter1.TabIndex = 2;
			this.splitter1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.toolBar1,
																				 this.pictureBox1});
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.DockPadding.Left = 202;
			this.panel2.Location = new System.Drawing.Point(209, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(423, 28);
			this.panel2.TabIndex = 3;
			// 
			// toolBar1
			// 
			this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.tbCS,
																						this.toolBarButton2,
																						this.tbVB,
																						this.toolBarButton1,
																						this.tbCopy});
			this.toolBar1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.toolBar1.ImageList = this.ilToolbar;
			this.toolBar1.Location = new System.Drawing.Point(2, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(200, 25);
			this.toolBar1.TabIndex = 1;
			this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// tbCS
			// 
			this.tbCS.ImageIndex = 0;
			this.tbCS.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.tbCS.Text = "C#";
			this.tbCS.ToolTipText = "C# source code";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbVB
			// 
			this.tbVB.ImageIndex = 1;
			this.tbVB.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.tbVB.Text = "VB.Net";
			this.tbVB.ToolTipText = "VB.Net source code";
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbCopy
			// 
			this.tbCopy.ImageIndex = 2;
			this.tbCopy.Text = "Copy";
			this.tbCopy.ToolTipText = "Copy to clipboard";
			// 
			// ilToolbar
			// 
			this.ilToolbar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ilToolbar.ImageSize = new System.Drawing.Size(16, 16);
			this.ilToolbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilToolbar.ImageStream")));
			this.ilToolbar.TransparentColor = System.Drawing.Color.White;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(202, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(221, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.rtfCode});
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.DockPadding.Top = 4;
			this.panel3.Location = new System.Drawing.Point(209, 28);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(423, 200);
			this.panel3.TabIndex = 4;
			// 
			// rtfCode
			// 
			this.rtfCode.BackColor = System.Drawing.SystemColors.Window;
			this.rtfCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtfCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtfCode.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.rtfCode.Location = new System.Drawing.Point(0, 4);
			this.rtfCode.Name = "rtfCode";
			this.rtfCode.ReadOnly = true;
			this.rtfCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
			this.rtfCode.ShowSelectionMargin = true;
			this.rtfCode.Size = new System.Drawing.Size(423, 196);
			this.rtfCode.TabIndex = 0;
			this.rtfCode.Text = "richTextBox1";
			this.rtfCode.WordWrap = false;
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter2.Location = new System.Drawing.Point(209, 228);
			this.splitter2.MinExtra = 100;
			this.splitter2.MinSize = 100;
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(423, 4);
			this.splitter2.TabIndex = 5;
			this.splitter2.TabStop = false;
			// 
			// c1Chart1
			// 
			this.c1Chart1.BackColor = System.Drawing.SystemColors.Control;
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"Area.default\" ParentName=\"Control\" StyleData=\"Border=None,Black,1;AlignVert=To" +
				"p;\" /><NamedStyle Name=\"Control\" ParentName=\"Control.default\" StyleData=\"Border=" +
				"Solid,Black,1;Rounding=10 10 10 10;\" /><NamedStyle Name=\"AxisY2\" ParentName=\"Are" +
				"a\" StyleData=\"Rotation=Rotate90;AlignHorz=Far;AlignVert=Center;\" /><NamedStyle N" +
				"ame=\"Footer\" ParentName=\"Control\" StyleData=\"Border=None,Black,1;\" /><NamedStyle" +
				" Name=\"Header\" ParentName=\"Control\" StyleData=\"Border=None,Black,1;\" /><NamedSty" +
				"le Name=\"Legend\" ParentName=\"Legend.default\" /><NamedStyle Name=\"Area\" ParentNam" +
				"e=\"Area.default\" /><NamedStyle Name=\"LabelStyleDefault\" ParentName=\"LabelStyleDe" +
				"fault.default\" /><NamedStyle Name=\"LabelStyleDefault.default\" ParentName=\"Contro" +
				"l\" StyleData=\"Border=None,Black,1;BackColor=Transparent;\" /><NamedStyle Name=\"Pl" +
				"otArea\" ParentName=\"Area\" StyleData=\"Border=None,Black,1;\" /><NamedStyle Name=\"C" +
				"ontrol.default\" ParentName=\"\" StyleData=\"ForeColor=ControlText;Border=None,Black" +
				",1;BackColor=Control;\" /><NamedStyle Name=\"Legend.default\" ParentName=\"Control\" " +
				"StyleData=\"Border=None,Black,1;Wrap=False;AlignVert=Top;\" /><NamedStyle Name=\"Ax" +
				"isY\" ParentName=\"Area\" StyleData=\"Rotation=Rotate270;AlignHorz=Near;AlignVert=Ce" +
				"nter;\" /><NamedStyle Name=\"AxisX\" ParentName=\"Area\" StyleData=\"Rotation=Rotate0;" +
				"AlignHorz=Center;AlignVert=Bottom;\" /></StyleCollection><ChartGroupsCollection><" +
				"ChartGroup Name=\"Group1\"><DataSerializer DefaultSet=\"True\"><DataSeriesCollection" +
				"><DataSeriesSerializer><LineStyle Color=\"DarkGoldenrod\" /><SymbolStyle Color=\"Co" +
				"ral\" Shape=\"Box\" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;1" +
				"9;24;25</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>" +
				";;;;</DataFields><FillStyle /><Histogram /></DataSeriesSerializer><DataSeriesSer" +
				"ializer><LineStyle Color=\"DarkGray\" /><SymbolStyle Color=\"CornflowerBlue\" Shape=" +
				"\"Dot\" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><" +
				"DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFi" +
				"elds><FillStyle /><Histogram /></DataSeriesSerializer><DataSeriesSerializer><Lin" +
				"eStyle Color=\"DarkGreen\" /><SymbolStyle Color=\"Cornsilk\" Shape=\"Tri\" /><SeriesLa" +
				"bel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single" +
				";Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle " +
				"/><Histogram /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"Da" +
				"rkKhaki\" /><SymbolStyle Color=\"Crimson\" Shape=\"Diamond\" /><SeriesLabel>series 3<" +
				"/SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><DataTypes>Single;Single;Doubl" +
				"e;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /><Histogram " +
				"/></DataSeriesSerializer></DataSeriesCollection></DataSerializer><Histogram><Nor" +
				"malDisplay><FillStyle Color1=\"Transparent\" /></NormalDisplay></Histogram></Chart" +
				"Group><ChartGroup Name=\"Group2\"><DataSerializer /><Histogram><NormalDisplay><Fil" +
				"lStyle Color1=\"Transparent\" /></NormalDisplay></Histogram></ChartGroup></ChartGr" +
				"oupsCollection><Header Compass=\"North\" Visible=\"False\" /><Footer Compass=\"South\"" +
				" Visible=\"False\" /><Legend Compass=\"East\" Visible=\"False\" /><ChartArea /><Axes><" +
				"Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"T" +
				"rue\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"South\"><GridMajor Visible=\"True\" Spa" +
				"cing=\"1\" /><GridMinor /></Axis><Axis Max=\"25\" Min=\"5\" UnitMajor=\"5\" UnitMinor=\"2" +
				".5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"Wes" +
				"t\"><GridMajor Visible=\"True\" Spacing=\"5\" /><GridMinor /></Axis><Axis Max=\"0\" Min" +
				"=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True" +
				"\" AutoMin=\"True\" Compass=\"East\"><GridMajor /><GridMinor /></Axis></Axes></Chart2" +
				"DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(421, 219);
			this.c1Chart1.TabIndex = 6;
			// 
			// panel5
			// 
			this.panel5.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.c1Chart1});
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.DockPadding.Bottom = 2;
			this.panel5.DockPadding.Right = 2;
			this.panel5.Location = new System.Drawing.Point(209, 232);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(423, 221);
			this.panel5.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel5,
																		  this.splitter2,
																		  this.panel3,
																		  this.panel2,
																		  this.splitter1,
																		  this.panel1});
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "Form1";
			this.Text = "C1Chart Explorer";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			this.panel5.ResumeLayout(false);
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

		bool loaded = false;

		private void LoadNewSamplesFromCollection(CodeSamplesCollection csc)
		{
			csc.LoadIntoTree( treeView1);
			foreach( TreeNode node in treeView1.Nodes)
				node.Expand();
			loaded = true;
			tbCS.Pushed = true;
			treeView1.SelectedNode = treeView1.Nodes[0];
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			Bitmap bm = pictureBox1.Image as Bitmap;
			bm.MakeTransparent( Color.White);

			CodeSamplesCollection csc = null;
			Stream stream = null;
			try
			{
				stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream( "GeneratedCode.Samples.xml");

				// csc = CodeSamplesCollection.LoadFromFile( "..\\..\\GeneratedCode\\Samples.xml");
				csc = CodeSamplesCollection.LoadFromStream( stream);
			}
			catch
			{
				throw new IOException( "Can't load code resource");
			}
			finally
			{
				if( stream!=null)
					stream.Close();
			}

			LoadNewSamplesFromCollection(csc);
		}

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if( !loaded)
				return;

			CodeSample cs = e.Node.Tag as CodeSample;

			if( cs!=null)
			{
				rtfCode.Rtf = "";

				if( tbCS.Pushed)
				{
					rtfCode.Rtf = RtfColor.Format( CodeSample.GetTagContent( cs.CodeCS, "CodeSnippet", @"//"), CodeLanguage.CSharp);
				}
				else if( tbVB.Pushed)
				{
					rtfCode.Rtf = RtfColor.Format( CodeSample.GetTagContent( cs.CodeVB, "CodeSnippet", "'"), CodeLanguage.VB);
				}
				else
					rtfCode.Rtf = "";

				lblInfo.Text = cs.Info;

				if( cs.Sample !=null)
				{
					c1Chart1.BackColor = SystemColors.Control;
					cs.Sample.Load( this.c1Chart1);
					if( c1Chart1.Header.Text.Length==0)
						c1Chart1.Header.Visible = false;

					if( c1Chart1.BackColor == SystemColors.Control)
						c1Chart1.BackColor = Palette.Back;
					c1Chart1.ForeColor = Palette.Fore;

					c1Chart1.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
					c1Chart1.Style.Border.Color = Color.Gray;
					c1Chart1.Style.Border.Thickness = 2;
					c1Chart1.Style.Border.Rounding.All = 10;
				}
#if DEBUG
				else if(e.Node.ImageIndex == 2)
				{
					// must actually be a sample and not a topic.
					// Use reflection to verify the existance of the type.
					IChartSample samp = ChartSamples.Samples[0];
					if(samp.GetType().Name == "NewSample")
						samp.Load(c1Chart1);
				}
#endif
				if( cs.CodeCS.Length == 0 && cs.CodeVB.Length == 0)
				{
					if( e.Node.Nodes.Count > 0)
						treeView1.SelectedNode = e.Node.Nodes[0];
				}
			}
		}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
			//c1Chart1.Visible = false;
			//this.SuspendLayout();
			//panel2.Height = ClientSize.Height / 2;
			//panel3.Width = panel2.Width - panel2.Height * 4 / 3;
			//this.ResumeLayout();
			//c1Chart1.Visible = true;
		}

		private void treeView1_BeforeSelect(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
		{
			if( treeView1.SelectedNode!=null)
			{
				CodeSample prev = treeView1.SelectedNode.Tag as CodeSample;

				if( prev != null && prev.Sample!=null)
					prev.Sample.Unload( c1Chart1);
			}
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			CodeSample cs = treeView1.SelectedNode.Tag as CodeSample;

			if( e.Button == tbCS)
			{
				tbVB.Pushed = false;
				rtfCode.Rtf = RtfColor.Format( CodeSample.GetTagContent( cs.CodeCS, "CodeSnippet", @"//"), CodeLanguage.CSharp);
				//				rtfCode.ReadOnly = false;
				//				rtfCode.Select( 0, 0);
				//				rtfCode.ReadOnly = true;
				tbCS.Pushed = true;
			}
			else if ( e.Button == tbVB)
			{
				tbCS.Pushed = false;
				rtfCode.Rtf = RtfColor.Format( CodeSample.GetTagContent( cs.CodeVB, "CodeSnippet", "'"), CodeLanguage.VB);
				//				rtfCode.ReadOnly = false;
				//				rtfCode.Select( 0, 0);
				//				rtfCode.ReadOnly = true;
				tbVB.Pushed = true;
			}
			else if( e.Button == tbCopy)
			{
				rtfCode.SelectAll();
				rtfCode.Copy();
			}
		}

		private void treeView1_AfterExpand(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if( e.Node.Nodes.Count > 0)
				e.Node.ImageIndex = 1;
		}

		private void treeView1_AfterCollapse(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if( e.Node.Nodes.Count > 0)
				e.Node.ImageIndex = 0;
		}

#if DEBUG

		private string GetSampleTemplate(string tag)
		{
			string SampleTemplateContents = null;

			if(SampleTemplateContents == null)
			{
				string ap = Application.ExecutablePath;
				ap = ap.Substring(0,ap.LastIndexOf("\\"));	// remove file
				ap = ap.Substring(0,ap.LastIndexOf("\\"));	// remove Debug
				ap = ap.Substring(0,ap.LastIndexOf("\\"));	// remove bin
				ap += "\\SampleTemplate.cs";
				if(File.Exists(ap))
				{
					StreamReader sr = File.OpenText(ap);
					if(sr != null)
					{
						SampleTemplateContents = sr.ReadToEnd();
						sr.Close();
					}
				}
			}

			string rv = null;
			if(SampleTemplateContents != null)
			{
				rv = CodeSample.GetTagContent(SampleTemplateContents, tag, "//");
			}

			return rv;
		}

		private void ShowInstructions(object sender, EventArgs e)
		{
			string msg = 
				"The DEBUG version of this program is can be used to insert new samples into the available\n" +
				"list of samples.  The expectation is that C1 developers can use this interface to add new\n" + 
				"charts to the sample.  Although the mechanism is not very robust, it simplifies the\n" +
				"addition of new samples if properly used.\n\n" +

				"\t* Right click the Treeview entries to add new samples or nodes as necessary.\n\n" +
				"\t* Right click on the Root node of the Treeview to save the new tree and data\n" +
				"\t   to NewSamples.cs and NewSamples.xml.\n\n" +

				"When adding new samples, it is necessary to wrap the desired code sample with\n" +
				"<CodeCS> tags, each on a separate line.  Other tags apply as well, including <Info>\n" +
				"and <CodeSnippet> tags as for other samples.\n\n" +

				"When importing new code from a file, the expectation is that the code will be CS and in\n" +
				"either the Form1_Load event or that the NewSample class will be defined.  In the case of\n" +
				"Form1_Load event, the code marked by <CodeCS> tags is wrapped with the NewSample class\n" +
				"structure, and the Form1_Load event modified to be the ChartSample.Load implementation\n\n" +

				"After the CS code is imported, it passes through the cstovb.exe code converter, with the\n" +
				"results used as the VB code snippet, and EditMode is entered on the added Treeview node\n" +
				"to allow name modification.  There is a default chart (as an indicator) if the code does\n" +
				"not properly import.\n\n" +

				"Do you wish to add a Sample Template to the clipboard";

			DialogResult dr = MessageBox.Show(msg,"", MessageBoxButtons.YesNo);

			if(dr == DialogResult.Yes)
			{
				string full = GetSampleTemplate("FullChartSampleTemplate");
				if(full != null) Clipboard.SetDataObject(full,true);
			}
		}

		private ContextMenu RightClickMenu = null;
		private string MenuResult = null;
		private string defaultCodeSample = null;
		private string defaultCodeSampleVB = null;

		private string GetDefaultCodeSample(string lang)
		{
			if(lang == "cs")
			{
				if(defaultCodeSample == null)
					defaultCodeSample = this.GetSampleTemplate("PartialCSSampleTemplate");
				return defaultCodeSample;
			}
			else if(lang == "vb")
			{
				if(defaultCodeSampleVB == null)
					defaultCodeSampleVB = this.GetSampleTemplate("PartialVBSampleTemplate");
				return defaultCodeSampleVB;
			}
			return null;
		}

		private void MenuClickHandler(object sender, EventArgs e)
		{
			MenuItem mi = (MenuItem)sender as MenuItem;
			if(mi != null)
			{
				if(mi.Text.StartsWith("Before") || mi.Text.StartsWith("After") || mi.Text == "As Child")
				{
					MenuItem mp = (MenuItem)mi.Parent as MenuItem;
					MenuResult = mi.Text + "," + mp.Text;
				}
				else if(mi.Text.StartsWith("Load") || mi.Text.StartsWith("Save") || mi.Text == "Remove")
				{
					MenuResult = mi.Text;
				}
				else
					MenuResult = null;
			}
		}

		private void CreateContextMenu(TreeNode tn)
		{
			if(RightClickMenu != null)
			{
				// system seems to cache the menu contents after the initial use
				// so it is necessary to remove and create a new menu each time.
				ContextMenu cm =RightClickMenu;
				RightClickMenu = null;

				DisposeMenuItems(cm.MenuItems);
				cm.Dispose();
				cm = null;
			}

			if(tn.Parent == null && tn.PrevNode == null)
			{
				// if this is the first node of the entire tree
				MenuItem [] rootMenu = new MenuItem[]
				{
					new MenuItem("Save to NewSamples", new EventHandler(MenuClickHandler)),
					new MenuItem("Save to Samples", new EventHandler(MenuClickHandler)),
					new MenuItem("Load from NewSamples.xml", new EventHandler(MenuClickHandler)),
					new MenuItem("Load from Samples.xml", new EventHandler(MenuClickHandler)),
					new MenuItem("Cancel"),
				};

				RightClickMenu = new ContextMenu(rootMenu);
				return;
			}

			//
			// add all possible menu items now, then hide them later based on the context.
			//
			bool topic = tn.ImageIndex <= 1;
			string n = (tn.Text != null && tn.Text.Length > 0) ? (" \"" + tn.Text + "\"") : "";

			MenuItem [] subsample = new MenuItem[]
			{
				new MenuItem("Before" + n, new EventHandler(MenuClickHandler)),
				new MenuItem("After" + n, new EventHandler(MenuClickHandler)),
				new MenuItem("As Child", new EventHandler(MenuClickHandler)),
			};

			MenuItem [] subtopic = new MenuItem[]
			{
				new MenuItem("Before" + n, new EventHandler(MenuClickHandler)),
				new MenuItem("After" + n, new EventHandler(MenuClickHandler)),
				new MenuItem("As Child", new EventHandler(MenuClickHandler)),
			};

			MenuItem [] mis = new MenuItem[]
			{
				new MenuItem("Insert Topic", subtopic),
				new MenuItem("Insert Sample", subsample),
				new MenuItem("Remove", new EventHandler(MenuClickHandler)),
				new MenuItem("Cancel"),
			};

			if(!topic)
			{
				subsample[2].Visible = false;
				mis[0].Visible = false;
			}
			else
			{
				if(tn.Nodes.Count > 0) mis[2].Visible =false;
			}

			RightClickMenu = new ContextMenu(mis);
		}

		private void DisposeMenuItems(System.Windows.Forms.Menu.MenuItemCollection mic)
		{
			foreach(MenuItem mi in mic)
			{
				if(mi != null)
				{
					if(mi.MenuItems != null)
						DisposeMenuItems(mi.MenuItems);
	
					mi.Dispose();
				}
			}
		}

		private string ShowContextMenu(Control control, Point position)
		{
			MenuResult = null;
			if(RightClickMenu != null)
				RightClickMenu.Show(control, position);

			Application.DoEvents();
			return MenuResult;
		}

		private TreeNode getClickedNode(TreeNodeCollection tnc, int x, int y)
		{
			TreeNode tns = null;
			if(tnc != null)
			{			  
				foreach(TreeNode tn in tnc)
				{
					if(tn.IsVisible && tn.Bounds.Contains(x, y))
					{
						tns = tn;
						break;
					}
					else if(tn.Nodes.Count > 0)
					{
						tns = getClickedNode(tn.Nodes, x, y);
						if(tns != null) break;
					}
				}
			}
			return tns;
		}

		private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
		{
			string newName = e.Label;
			string oldName = e.Node.Text;

			// after the node has been renamed, rename all the appropriate items
			// in the CodeSample data structures as well.
			if(newName != null && oldName != null && oldName != newName)
			{
				CodeSample cs = (CodeSample)e.Node.Tag as CodeSample;
				if(cs != null)
				{
					cs.Text = cs.Text.Replace(oldName, newName);
					cs.Name = cs.Name.Replace(oldName, newName);

					string info = cs.Info;
					if(e.Node != null && e.Node.ImageIndex == 2)
					{
						cs.Info = cs.Info.Replace(oldName, newName);

						// This is ugly but should work for now.
						// Make sure that the class gets renamed.
						// Sample must be - "Name: ChartSample", or "Name : ChartSample"
						//
						string classn = ": ChartSample";
						cs.CodeCS = cs.CodeCS.Replace(info, cs.Info).Replace(oldName+classn, newName+classn);
						cs.CodeCS = cs.CodeCS.Replace(info, cs.Info).Replace(oldName + " " + classn, newName + " " + classn);
						cs.CodeCS = cs.CodeCS.Replace("//CS " + oldName, "//CS " + newName);

						classn = "Public Class ";
						cs.CodeVB = cs.CodeVB.Replace(info, cs.Info).Replace(classn+oldName, classn+newName);
						cs.CodeVB = cs.CodeVB.Replace("'VB " + oldName, "'VB " + newName);
						this.treeView1_AfterSelect(treeView1, new TreeViewEventArgs(e.Node, TreeViewAction.Unknown));
					}
				}
			}
		}

		private void processRootMenuClick(string resultString)
		{
			bool newSample = resultString.IndexOf("NewSamples") >= 0;
			bool loadSamples = resultString.StartsWith("Load");
			bool saveSamples = resultString.StartsWith("Save");
			bool xml = resultString.IndexOf(".xml") >= 0;

			const string sdir = @"..\..\GeneratedCode\";
			string sfile = sdir + ((newSample) ? "New" : "") + "Samples";

			if(loadSamples)
			{
				CodeSamplesCollection csc = null;
				sfile += ".xml";

				try
				{
					csc = CodeSamplesCollection.LoadFromFile(sfile);
				}
				catch
				{
					MessageBox.Show("Unable to load samples file: " + sfile);
					return;
				}

				LoadNewSamplesFromCollection(csc);
			}
			else if(saveSamples)
			{
				CodeSamplesCollection csc = new CodeSamplesCollection();
				CodeSamplesCollection.LoadFromTree(treeView1.Nodes, csc);

				if(csc.Count > 0)
				{
					if(!newSample)
					{
						if(File.Exists(sfile + ".cs.old")) File.Delete(sfile + ".cs.old");
						if(File.Exists(sfile + ".cs")) File.Move(sfile + ".cs", sfile + ".cs.old");

						if(File.Exists(sfile + ".xml.old")) File.Delete(sfile + ".xml.old");
						if(File.Exists(sfile + ".xml")) File.Move(sfile + ".xml", sfile + ".xml.old");
					}

					CodeSamplesCollection.SaveToFile(csc, sfile + ".xml");
					csc.GenerateCode(sfile + ".cs", this.GetType().Namespace, this.GetDefaultCodeSample("cs"));

					//if(xml)
					//	CodeSamplesCollection.SaveToFile(csc, sfile);
					//else
					//	csc.GenerateCode(sfile, this.GetType().Namespace, this.GetDefaultCodeSample("cs"));
				}
			}
		}

		private void AdjustCsContentFromDefaultForm(ref string content)
		{
			int floadIndex = content.IndexOf("private void Form1_Load(");
			if(floadIndex < 0) return;

			// Appropriately adjust and wrap the default Form1_Load event.
			// Assumes <CodeCS> appropriately wraps the Form1_Load event
			// and <Info>.  Adds the appropriate class declaration wrapping
			// and changes the Form1_Load event line.

			string codeStart = "public class NewSample: ChartSample\r\n{\r\n";
			string codeEnd = "}\r\n";

			int floadStart = content.Substring(0,floadIndex).LastIndexOf('\n');
			if(floadStart >= 0) floadStart++;

			int floadEnd = content.IndexOf("\r", (floadStart < 0) ? 0 : floadStart);
			if(floadEnd < 0) floadEnd = content.Length;

			string ns = content.Substring(floadEnd).Replace("\n","\n\t");
			if(ns.EndsWith("\t")) ns = ns.Substring(0, ns.Length-1);

			ns = ((floadStart < 0) ? "" : content.Substring(0, floadStart)) +
				codeStart + "\tpublic override void Load(C1.Win.C1Chart.C1Chart c1Chart1)" +
				ns + codeEnd;

			content = ns;
		}

		private string LoadSampleFromCSFile(string fname, ref string codeVB)
		{
			string content = null;
			codeVB = null;

			FileInfo fi = new FileInfo(fname);
			if(fi.Exists)
			{
				StreamReader sr = fi.OpenText();
				content = sr.ReadToEnd();
				sr.Close();

				content = CodeSample.GetTagContent(content, "CodeCS", "//");
				if(content != null && content.Length > 0)
				{
					if(content.IndexOf(": ChartSample") < 0 && content.IndexOf("Form1_Load") >= 0)
						AdjustCsContentFromDefaultForm(ref content);
					
					string name = fi.DirectoryName + "\\codesnippet.cs";
					StreamWriter sw = new StreamWriter(name);
					sw.Write(content);
					sw.Close();
					codeVB = CodeSample.BuildAndCreateVBCodeSnippetFromCSFile(name);
				}
			}

			return content;
		}

		private string LoadSampleFromCSSelectedFile(ref string codeVB)
		{
			string ap = Application.ExecutablePath;
			ap = ap.Substring(0,ap.LastIndexOf("\\"));	// remove file
			ap = ap.Substring(0,ap.LastIndexOf("\\"));	// remove Debug
			ap = ap.Substring(0,ap.LastIndexOf("\\"));	// remove bin

			OpenFileDialog fd = new OpenFileDialog();
			fd.RestoreDirectory = true;
			fd.Multiselect = false;
			fd.CheckPathExists = true;
			fd.CheckFileExists = true;
			fd.ShowReadOnly = false;
			fd.ValidateNames = true;

			fd.DefaultExt = "cs";
			fd.FileName = "*." + fd.DefaultExt;
			fd.Filter = "C Sharp files (*.cs)|*.cs";
			fd.FilterIndex = 0;
			fd.InitialDirectory = ap;
			ap = null;

			if(fd.ShowDialog() == DialogResult.OK)
				ap = LoadSampleFromCSFile(fd.FileName, ref codeVB);

			return ap;
		}

		private void treeView1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				TreeView tv = (TreeView)sender as TreeView;
				if(tv != null)
				{
					TreeNode tnc = getClickedNode(tv.Nodes, e.X, e.Y);
					if(tnc != null)
					{
						CreateContextMenu(tnc);

						string result = ShowContextMenu(tv, tnc.Bounds.Location + tnc.Bounds.Size);
						if(result == null || result.Length == 0) return;

						if(tnc.Parent == null && tnc.PrevNode == null)
						{
							processRootMenuClick(result);
							return;
						}

						if(result.IndexOf("Remove") >= 0)
						{
							if(tnc.ImageIndex == 2 || tnc.Nodes.Count == 0)
							{
								// a sample or an empty topic;
								TreeNodeCollection nods = tnc.Parent.Nodes;
								if(nods == null) nods = tv.Nodes;
								nods.Remove(tnc);

								CodeSample csr = tnc.Tag as CodeSample;
								if(csr != null) csr.Dispose();
							}
							return;
						}

						bool topic = result.IndexOf("Topic") >= 0;
						bool before = result.IndexOf("Before") >= 0;
						bool sample = result.IndexOf("Sample") >= 0;
						bool after = result.IndexOf("After") >=0;
						bool child = result.IndexOf("Child") >= 0;

						TreeNode ntn = null;		// this is the newly added node.

						if(before || after || child)
						{
							string nname = null;
							int imgIndex = 0, selImgIndex = -1;

							CodeSample pcs = (CodeSample)tnc.Tag;
							CodeSample cs = new CodeSample();

							if(topic)
							{
								nname = "New Topic";
								cs.CodeCS = cs.CodeVB = "";
								cs.Text = nname;
									
								ntn = new TreeNode(nname, imgIndex, selImgIndex);
								ntn.Tag = cs;

								if(child)
								{
									if(pcs != null && pcs.Name.Length > 0)
									{
										cs.ParentName = pcs.Name;
										cs.Name = (Int32.Parse(pcs.Name.Substring(0,2))+1).ToString("00") + "." + nname;
									}
									tnc.Nodes.Insert(0, ntn);
									tnc.Expand();
								}
								else
								{
									if(pcs != null)
									{
										cs.ParentName = pcs.ParentName;
										cs.Name = pcs.Name.Substring(0,3) + nname;
									}
									if(tnc.Parent != null)
										tnc.Parent.Nodes.Insert(tnc.Index + ((before) ? 0 : 1), ntn);
									else
										tv.Nodes.Insert(tnc.Index + ((before) ? 0 : 1), ntn);
								}
							}
							else if(sample)
							{
								nname = "NewSample";
								imgIndex = selImgIndex = 2;

								ntn = new TreeNode(nname, imgIndex, selImgIndex);

								string vbCodeFromFile = null;
								string csCodeFromFile = LoadSampleFromCSSelectedFile(ref vbCodeFromFile);

								if(vbCodeFromFile != null)
								{
									cs.CodeCS = csCodeFromFile;
									cs.CodeVB = (vbCodeFromFile != null) ? vbCodeFromFile : "";
								}
								else
								{
									cs.CodeCS = GetDefaultCodeSample("cs");
									cs.CodeVB = GetDefaultCodeSample("vb");
								}
								cs.ParentName = tnc.Parent.Text;
								cs.Text = nname;
								ntn.Tag = cs;

								if(child)
								{
									if(pcs != null && pcs.Name.Length > 0)
									{
										cs.ParentName = pcs.Name;
										cs.Name = (Int32.Parse(pcs.Name.Substring(0,2))+1).ToString("00") + "." + nname;

										string np = "..\\" + tnc.FullPath;
										int ci=1;
										int ind=np.IndexOf('\\');
										while(ind >= 0)
										{
											np = np.Substring(0, ind+1) + ci.ToString("00") + "." + np.Substring(ind+1);
											ind = np.IndexOf('\\', ind + 1+3);
											ci++;
										}

										cs.Name = np + "\\" + cs.Name;
									}
									tnc.Nodes.Insert(0, ntn);
									tnc.Expand();
								}
								else if(tnc.Parent != null)
								{
									if(pcs != null)
									{
										// generate a name that should/will be unique for the entire tree.
										int len=pcs.Name.LastIndexOf("\\")+4;
										cs.Name = pcs.Name.Substring(0,len) + nname;
										cs.ParentName = pcs.ParentName;
									}
									tnc.Parent.Nodes.Insert(tnc.Index + ((before) ? 0 : 1), ntn);									
								}
							}
						}

						if(ntn != null)
						{
							tv.SelectedNode = ntn;
							ntn.BeginEdit();
						}
					}
				}
			}
		}
#endif
	}

	class Palette
	{
		static public Color Fore = Color.FromArgb( 40, 79, 80);
		static public Color Back = Color.FromArgb( 230, 230, 230);
		static public Color Back2 = Color.FromArgb( 96, 173, 174);
		static public Color Back3 = Color.FromArgb( 235, 235, 215);
		static public Color Dark1 = Color.FromArgb( 205, 0, 103);
		static public Color Dark2 = Color.FromArgb( 51, 102, 153);
		static public Color Dark3 = Color.FromArgb( 140, 140, 70);
		static public Color Light1 = Color.FromArgb( 255, 135, 195);
		static public Color Light2 = Color.FromArgb( 165, 195, 225);
		static public Color Light3 = Color.FromArgb( 215, 215, 175);
	}

	public class CustomTreeView : TreeView
	{
		Bitmap bmback = null, bm = null;

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			//e.Graphics.Clear( BackColor);
			//LinearGradientBrush brush = new LinearGradientBrush( e.ClipRectangle,
			//	Color.White, Palette.Back, LinearGradientMode.Horizontal);
			Color[] clrs = { SystemColors.Control,
											 SystemColors.ControlLightLight,
											 SystemColors.Control};
			float[] poss = {0.0f,.50f,1.0f};
			ColorBlend blend = new ColorBlend();
			blend.Colors = clrs;
			blend.Positions = poss;

			LinearGradientBrush brush = new LinearGradientBrush( ClientRectangle,
				SystemColors.Control, SystemColors.ControlLightLight, LinearGradientMode.Horizontal);

			brush.InterpolationColors = blend;
			e.Graphics.FillRectangle( brush, ClientRectangle);
			brush.Dispose();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
		}

		public new void Dispose()
		{
			base.Dispose();
			if( bm!=null)
			{
				bm.Dispose();
				bm = null;
			}
			if( bmback!=null)
			{
				bmback.Dispose();
				bmback = null;
			}
		}

		protected override void WndProc(ref Message m)
		{
			switch(m.Msg)
			{
				case WM_PAINT:
                    {
                        if (bm == null)
                        {
                            bm = new Bitmap(Width, Height);
                            bmback = new Bitmap(Width, Height);
                        }
                        else if (bm.Width != Width || bm.Height != Height)
                        {
                            bm.Dispose();
                            bmback.Dispose();
                            bm = new Bitmap(Width, Height);
                            bmback = new Bitmap(Width, Height);
                        }

                        // Draw tree on bitmap
                        Graphics g = Graphics.FromImage(bm);
                        IntPtr dc = g.GetHdc();
                        Message mPaint = Message.Create(m.HWnd, WM_PAINT, dc, IntPtr.Zero);
                        base.WndProc(ref mPaint);
                        g.ReleaseHdc(dc);
                        g.Dispose();

                        // Set transaprency
                        bm.MakeTransparent(BackColor);

                        g = Graphics.FromImage(bmback);
                        Rectangle cr = new Rectangle(0, 0, Width, Height);
                        PaintEventArgs pe = new PaintEventArgs(g, cr);
                        // render background
                        OnPaintBackground(pe);
                        // render tree
                        g.DrawImageUnscaled(bm, 0, 0);
                        OnPaint(pe);
                        g.Dispose();

                        // do the painting
                        PaintStruct lp = new PaintStruct();
                        BeginPaint(m.HWnd, ref lp);
                        {
                            g = Graphics.FromHdc(lp.hDC);
                            Rectangle r = new Rectangle(lp.rcPaint.Left, lp.rcPaint.Top,
                                lp.rcPaint.Right - lp.rcPaint.Left, lp.rcPaint.Bottom - lp.rcPaint.Top);

                            g.DrawImage(bmback, r, r, GraphicsUnit.Pixel);
                            g.Dispose();
                        }
                        EndPaint(m.HWnd, ref lp);
                        break;
                    }
				// reduce flickering
				case WM_ERASEBACKGROUND:
				{
					m.Result = (IntPtr)1;
					break;
				}
				// Full repaint
				case WM_HSCROLL:
				case WM_VSCROLL:
				case WM_MOUSEWHEEL:
				case WM_SIZE:
				{
					Invalidate();
					base.WndProc( ref m);
					break;
				}

				default:
					base.WndProc( ref m);
					break;
			}
		}

		const int WM_PAINT = 0x000F;
		const int WM_ERASEBACKGROUND = 0x0014; 
		const int WM_HSCROLL = 0x0114; 
		const int WM_VSCROLL = 0x0115; 
		const int WM_MOUSEWHEEL = 0x020A; 
		const int WM_SIZE = 0x0005; 

		[StructLayout(LayoutKind.Sequential)]
		private struct Rect
		{
			public int Left;
			public int Top;
			public int Right;
			public int Bottom;
		}

        [StructLayout(LayoutKind.Sequential)]
        private struct PaintStruct
        {
            public IntPtr hDC;
            public bool fErase;
            public Rect rcPaint;
            public bool fRestore;
            public bool fIncUpdate;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public Byte[] fgbReserved;
        }

		[DllImport("user32.dll")]
		private static extern int BeginPaint(IntPtr hWnd, ref PaintStruct lp);

		[DllImport("user32.dll")]
		private static extern int EndPaint(IntPtr hWnd, ref PaintStruct lp);

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, IntPtr lParam);
	}

	class CustomPictureBox : PictureBox
	{
		protected override void OnPaintBackground( PaintEventArgs e)
		{
			Color[] clrs = { SystemColors.Control,
											 SystemColors.ControlLightLight,
											 SystemColors.Control};
			float[] poss = {0.0f,.50f,1.0f};
			ColorBlend blend = new ColorBlend();
			blend.Colors = clrs;
			blend.Positions = poss;

			LinearGradientBrush brush = new LinearGradientBrush( ClientRectangle,
				SystemColors.Control, SystemColors.ControlLightLight, LinearGradientMode.Horizontal);
			brush.InterpolationColors = blend;
			e.Graphics.FillRectangle( brush, ClientRectangle);
			brush.Dispose();
		}
	}
}
