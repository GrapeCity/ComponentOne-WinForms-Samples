using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.C1Chart;

namespace RtfTitle
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.Button btnHeader;
		private System.Windows.Forms.Button btnFooter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbHeaderAlign;
		private System.Windows.Forms.ComboBox cbFooterAlign;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Button btnPrintPreview;
		private System.Windows.Forms.Panel panel3;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cbFooterAlign = new System.Windows.Forms.ComboBox();
			this.cbHeaderAlign = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnFooter = new System.Windows.Forms.Button();
			this.btnHeader = new System.Windows.Forms.Button();
			this.btnPrintPreview = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.panel3,
																				 this.cbFooterAlign,
																				 this.cbHeaderAlign,
																				 this.label2,
																				 this.label1,
																				 this.btnFooter,
																				 this.btnHeader,
																				 this.btnPrintPreview});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(168, 437);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel3.Location = new System.Drawing.Point(8, 152);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(152, 4);
			this.panel3.TabIndex = 6;
			// 
			// cbFooterAlign
			// 
			this.cbFooterAlign.BackColor = System.Drawing.SystemColors.Control;
			this.cbFooterAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFooterAlign.Items.AddRange(new object[] {
															   "North",
															   "South",
															   "West",
															   "East"});
			this.cbFooterAlign.Location = new System.Drawing.Point(8, 112);
			this.cbFooterAlign.Name = "cbFooterAlign";
			this.cbFooterAlign.Size = new System.Drawing.Size(72, 21);
			this.cbFooterAlign.TabIndex = 5;
			this.cbFooterAlign.SelectedIndexChanged += new System.EventHandler(this.cbFooterAlign_SelectedIndexChanged);
			// 
			// cbHeaderAlign
			// 
			this.cbHeaderAlign.BackColor = System.Drawing.SystemColors.Control;
			this.cbHeaderAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHeaderAlign.Items.AddRange(new object[] {
															   "North",
															   "South",
															   "West",
															   "East"});
			this.cbHeaderAlign.Location = new System.Drawing.Point(8, 40);
			this.cbHeaderAlign.Name = "cbHeaderAlign";
			this.cbHeaderAlign.Size = new System.Drawing.Size(72, 21);
			this.cbHeaderAlign.TabIndex = 4;
			this.cbHeaderAlign.SelectedIndexChanged += new System.EventHandler(this.cbHeaderAlign_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label2.Location = new System.Drawing.Point(8, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Footer";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Header";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnFooter
			// 
			this.btnFooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFooter.Location = new System.Drawing.Point(88, 112);
			this.btnFooter.Name = "btnFooter";
			this.btnFooter.Size = new System.Drawing.Size(72, 21);
			this.btnFooter.TabIndex = 1;
			this.btnFooter.Text = "Edit rtf ...";
			this.btnFooter.Click += new System.EventHandler(this.btnFooter_Click);
			// 
			// btnHeader
			// 
			this.btnHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHeader.Location = new System.Drawing.Point(88, 40);
			this.btnHeader.Name = "btnHeader";
			this.btnHeader.Size = new System.Drawing.Size(72, 21);
			this.btnHeader.TabIndex = 0;
			this.btnHeader.Text = "Edit rtf ...";
			this.btnHeader.Click += new System.EventHandler(this.btnHeader_Click);
			// 
			// btnPrintPreview
			// 
			this.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrintPreview.Location = new System.Drawing.Point(40, 176);
			this.btnPrintPreview.Name = "btnPrintPreview";
			this.btnPrintPreview.Size = new System.Drawing.Size(96, 23);
			this.btnPrintPreview.TabIndex = 1;
			this.btnPrintPreview.Text = "Print preview";
			this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.c1Chart1});
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(168, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(480, 437);
			this.panel2.TabIndex = 1;
			// 
			// c1Chart1
			// 
			this.c1Chart1.DataSource = null;
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"PlotArea\" ParentName=\"Area\" StyleData=\"Border=None,Black,1;\" /><NamedStyle Nam" +
				"e=\"Legend\" ParentName=\"Legend.default\" /><NamedStyle Name=\"Footer\" ParentName=\"C" +
				"ontrol\" StyleData=\"Font=Microsoft Sans Serif, 8.25pt;GradientStyle=None;ForeColo" +
				"r=ControlText;Border=None,Black,1;HatchStyle=None;Opaque=True;BackColor2=;BackCo" +
				"lor=White;\" /><NamedStyle Name=\"Area\" ParentName=\"Area.default\" /><NamedStyle Na" +
				"me=\"Control\" ParentName=\"Control.default\" StyleData=\"BackColor=White;\" /><NamedS" +
				"tyle Name=\"AxisX\" ParentName=\"Area\" StyleData=\"Rotation=Rotate0;AlignHorz=Center" +
				";AlignVert=Bottom;\" /><NamedStyle Name=\"AxisY\" ParentName=\"Area\" StyleData=\"Rota" +
				"tion=Rotate270;AlignHorz=Near;AlignVert=Center;\" /><NamedStyle Name=\"LabelStyleD" +
				"efault\" ParentName=\"LabelStyleDefault.default\" /><NamedStyle Name=\"Legend.defaul" +
				"t\" ParentName=\"Control\" StyleData=\"Border=None,Black,1;Wrap=False;AlignVert=Top;" +
				"\" /><NamedStyle Name=\"LabelStyleDefault.default\" ParentName=\"Control\" StyleData=" +
				"\"Border=None,Black,1;BackColor=Transparent;\" /><NamedStyle Name=\"Header\" ParentN" +
				"ame=\"Control\" StyleData=\"Font=Microsoft Sans Serif, 8.25pt;GradientStyle=Diagona" +
				"lCenter;ForeColor=ControlText;Border=None,Black,1;HatchStyle=None;Opaque=True;Ba" +
				"ckColor2=Black;BackColor=White;\" /><NamedStyle Name=\"Control.default\" ParentName" +
				"=\"\" StyleData=\"ForeColor=ControlText;Border=None,Black,1;BackColor=Control;\" /><" +
				"NamedStyle Name=\"AxisY2\" ParentName=\"Area\" StyleData=\"Rotation=Rotate90;AlignHor" +
				"z=Far;AlignVert=Center;\" /><NamedStyle Name=\"Area.default\" ParentName=\"Control\" " +
				"StyleData=\"Border=None,Black,1;AlignVert=Top;\" /></StyleCollection><ChartGroupsC" +
				"ollection><ChartGroup Name=\"Group1\" Use3D=\"False\"><DataSerializer DefaultSet=\"Tr" +
				"ue\"><DataSeriesCollection><DataSeriesSerializer><LineStyle Color=\"DarkGoldenrod\"" +
				" /><SymbolStyle Color=\"Coral\" Shape=\"Box\" /><SeriesLabel>series 0</SeriesLabel><" +
				"X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><DataTypes>Single;Single;Double;Double;Doubl" +
				"e</DataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSerializer><D" +
				"ataSeriesSerializer><LineStyle Color=\"DarkGray\" /><SymbolStyle Color=\"Cornflower" +
				"Blue\" Shape=\"Dot\" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;1" +
				"0;12;15</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>" +
				";;;;</DataFields><FillStyle /></DataSeriesSerializer><DataSeriesSerializer><Line" +
				"Style Color=\"DarkGreen\" /><SymbolStyle Color=\"Cornsilk\" Shape=\"Tri\" /><SeriesLab" +
				"el>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;" +
				"Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /" +
				"></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"DarkKhaki\" /><Sy" +
				"mbolStyle Color=\"Crimson\" Shape=\"Diamond\" /><SeriesLabel>series 3</SeriesLabel><" +
				"X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><DataTypes>Single;Single;Double;Double;Doubl" +
				"e</DataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSerializer></" +
				"DataSeriesCollection></DataSerializer></ChartGroup><ChartGroup Name=\"Group2\"><Da" +
				"taSerializer /></ChartGroup></ChartGroupsCollection><Header Compass=\"North\" /><F" +
				"ooter Compass=\"South\" /><Legend Compass=\"East\" Visible=\"False\" /><ChartArea /><A" +
				"xes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMin" +
				"or=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"South\"><GridMajor /><GridMinor " +
				"/></Axis><Axis Max=\"26\" Min=\"8\" UnitMajor=\"2\" UnitMinor=\"1\" AutoMajor=\"True\" Aut" +
				"oMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"West\"><GridMajor /><GridMin" +
				"or /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"True\" A" +
				"utoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"East\"><GridMajor /><GridM" +
				"inor /></Axis></Axes></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(476, 433);
			this.c1Chart1.TabIndex = 0;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(148, 17);
			this.printPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Opacity = 1;
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(648, 437);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel2,
																		  this.panel1});
			this.Name = "Form1";
			this.Text = "ComponentOne Chart.Net 2D - Rtf Title Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
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

		private void btnHeader_Click(object sender, System.EventArgs e)
		{
			RtfForm frm = new RtfForm();
			frm.Rtf = c1Chart1.Header.Rtf;

			if( frm.ShowDialog() == DialogResult.OK)
			{
				c1Chart1.Header.Rtf = frm.Rtf;
			}
		}

		private void btnFooter_Click(object sender, System.EventArgs e)
		{
			RtfForm frm = new RtfForm();
			frm.Rtf = c1Chart1.Footer.Rtf;

			if( frm.ShowDialog() == DialogResult.OK)
			{
				c1Chart1.Footer.Rtf = frm.Rtf;
			}
		}

		private void cbHeaderAlign_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			c1Chart1.Header.Compass = (CompassEnum)Enum.Parse( typeof(CompassEnum),
				cbHeaderAlign.SelectedItem.ToString());
		}

		private void cbFooterAlign_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			c1Chart1.Footer.Compass = (CompassEnum)Enum.Parse( typeof(CompassEnum),
				cbFooterAlign.SelectedItem.ToString());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// Create sample rtf header using RichTextBox cotrol
			RichTextBox rtb = new RichTextBox();
			rtb.SelectionAlignment = HorizontalAlignment.Center;
			rtb.SelectedText = "Multi-color header:\n";
			FontStyle fs = FontStyle.Underline | FontStyle.Bold; //!!VBPassThru
			rtb.SelectionFont = new Font( "Lucida Console", 20, fs);
			rtb.SelectionColor = Color.Red;
			rtb.SelectedText = "R";
			rtb.SelectionColor = Color.Orange;
			rtb.SelectedText = "A";
			rtb.SelectionColor = Color.Yellow;
			rtb.SelectedText = "I";
			rtb.SelectionColor = Color.Green;
			rtb.SelectedText = "N";
			rtb.SelectionColor = Color.SkyBlue;
			rtb.SelectedText = "B";
			rtb.SelectionColor = Color.Blue;
			rtb.SelectedText = "O";
			rtb.SelectionColor = Color.Violet;
			rtb.SelectedText = "W";
			c1Chart1.Header.Rtf = rtb.Rtf;

			// Create sample rtf footer using RichTextBox cotrol
			rtb.ResetText();
			rtb.SelectionAlignment = HorizontalAlignment.Center;
			rtb.SelectedText = "Different text styles:\n";
			rtb.SelectionFont = new Font( "Times New Roman", 12);// , FontStyle.Underline | FontStyle.Bold);
			rtb.SelectionColor = Color.Black;
			rtb.SelectedText = "Normal ";
			rtb.SelectionFont = new Font( "Times New Roman", 12, FontStyle.Bold);
			rtb.SelectedText = "Bold ";
			rtb.SelectionFont = new Font( "Times New Roman", 12, FontStyle.Underline);
			rtb.SelectedText = "Underline";
			rtb.SelectionFont = new Font( "Times New Roman", 12);
			rtb.SelectedText = " ";
			rtb.SelectionFont = new Font( "Times New Roman", 12, FontStyle.Strikeout);
			rtb.SelectedText = "Strikeout";
			c1Chart1.Footer.Rtf = rtb.Rtf;

			// Set initial alignment
			cbHeaderAlign.SelectedItem = "North";
			cbFooterAlign.SelectedItem = "South";
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			c1Chart1.Draw( e.Graphics, e.MarginBounds);
		}

		private void btnPrintPreview_Click(object sender, System.EventArgs e)
		{
			printPreviewDialog1.ShowDialog();
		}
	}
}
