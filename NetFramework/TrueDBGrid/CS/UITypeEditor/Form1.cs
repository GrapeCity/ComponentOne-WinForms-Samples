using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CustomEditors
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1TrueDBGrid1
			// 
			this.c1TrueDBGrid1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.c1TrueDBGrid1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images"))));
			this.c1TrueDBGrid1.Location = new System.Drawing.Point(24, 16);
			this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
			this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
			this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
			this.c1TrueDBGrid1.Size = new System.Drawing.Size(560, 248);
			this.c1TrueDBGrid1.TabIndex = 0;
			this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1TrueDBGrid.Design.ContextWrappe" +
				"r\"><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" +
				"ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" +
				"ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" +
				"CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" +
				"er;}Style14{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle9{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" +
				"nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" +
				"Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" +
				"es><Splits><C1.Win.C1TrueDBGrid.MergeView Name=\"\" CaptionHeight=\"17\" ColumnCapti" +
				"onHeight=\"17\" ColumnFooterHeight=\"17\" MarqueeStyle=\"DottedCellBorder\" RecordSele" +
				"ctorWidth=\"17\" DefRecSelWidth=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup" +
				"=\"1\"><Height>244</Height><CaptionStyle parent=\"Style2\" me=\"Style10\" /><EditorSty" +
				"le parent=\"Editor\" me=\"Style5\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style8\" /><F" +
				"ilterBarStyle parent=\"FilterBar\" me=\"Style13\" /><FooterStyle parent=\"Footer\" me=" +
				"\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style12\" /><HeadingStyle parent=\"Headi" +
				"ng\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style7\" /><Inacti" +
				"veStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style9\"" +
				" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style11\" /><SelectedStyle pa" +
				"rent=\"Selected\" me=\"Style6\" /><Style parent=\"Normal\" me=\"Style1\" /><ClientRect>0" +
				", 0, 556, 244</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" +
				"tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent=\"\" me=\"" +
				"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Foot" +
				"er\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactiv" +
				"e\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Editor\" /" +
				"><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" " +
				"/><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"RecordSelecto" +
				"r\" /><Style parent=\"Normal\" me=\"FilterBar\" /><Style parent=\"Caption\" me=\"Group\" " +
				"/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" +
				"</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 556, 244</" +
				"ClientArea><PrintPageHeaderStyle parent=\"\" me=\"Style14\" /><PrintPageFooterStyle " +
				"parent=\"\" me=\"Style15\" /></Blob>";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(608, 294);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1TrueDBGrid1});
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
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

		// create an unbound grid
		private void bindGrid()
		{
			this.c1TrueDBGrid1.Columns.Add(new C1.Win.C1TrueDBGrid.C1DataColumn("Color",typeof(System.Drawing.Color)));
			this.c1TrueDBGrid1.Columns.Add(new C1.Win.C1TrueDBGrid.C1DataColumn("FileName",typeof(string)));
			this.c1TrueDBGrid1.Columns.Add(new C1.Win.C1TrueDBGrid.C1DataColumn("Font",typeof(System.Drawing.Font)));
			this.c1TrueDBGrid1.Columns.Add(new C1.Win.C1TrueDBGrid.C1DataColumn("DockStyle",typeof(System.Windows.Forms.DockStyle)));
			this.c1TrueDBGrid1.Columns.Add(new C1.Win.C1TrueDBGrid.C1DataColumn("AnchorStyle",typeof(System.Windows.Forms.AnchorStyles)));

			this.c1TrueDBGrid1.SetDataBinding();

			this.c1TrueDBGrid1.AddRows(5);
			// now populate the table with some fake data
			for(int i = 0; i < 5; i++)
			{
				this.c1TrueDBGrid1[i, "Color"]=Color.White;
				this.c1TrueDBGrid1[i, "FileName"]="c:\\windows";
				this.c1TrueDBGrid1[i, "Font"]=this.c1TrueDBGrid1.Font;
				this.c1TrueDBGrid1[i, "DockStyle"]=this.c1TrueDBGrid1.Dock;
				this.c1TrueDBGrid1[i, "AnchorStyle"]=this.c1TrueDBGrid1.Anchor;
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			bindGrid();

			// now attach the editors for the columns
			this.c1TrueDBGrid1.Columns["Color"].Editor = new ColorPicker();
			this.c1TrueDBGrid1.Columns["Font"].Editor = new FontPicker();
			this.c1TrueDBGrid1.Columns["FileName"].Editor = new FileNamePicker();
			this.c1TrueDBGrid1.Columns["DockStyle"].Editor = new DockPicker();
			this.c1TrueDBGrid1.Columns["AnchorStyle"].Editor = new AnchorPicker();
		}
	}
}
