using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial21
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.List.C1Combo c1Combo1;
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
			this.c1Combo1 = new C1.Win.List.C1Combo();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Combo1
			// 
			this.c1Combo1.AddItemCols = 0;
			this.c1Combo1.AddItemSeparator = ';';
			this.c1Combo1.AllowColMove = true;
			this.c1Combo1.AllowSort = true;
			this.c1Combo1.AlternatingRows = false;
			this.c1Combo1.Caption = "";
			this.c1Combo1.CaptionHeight = 17;
			this.c1Combo1.CellTips = C1.Win.List.CellTipEnum.NoCellTips;
			this.c1Combo1.CellTipsWidth = 0;
			this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo1.ColumnCaptionHeight = 17;
			this.c1Combo1.ColumnFooterHeight = 17;
			this.c1Combo1.ColumnWidth = -1;
			this.c1Combo1.ContentHeight = 17;
			this.c1Combo1.DataMode = C1.Win.List.DataModeEnum.AddItem;
			this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo1.DefColWidth = 0;
			this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo1.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo1.EditorHeight = 17;
			this.c1Combo1.GapHeight = 2;
			this.c1Combo1.IntegralHeight = false;
			this.c1Combo1.ItemHeight = 15;
			this.c1Combo1.Location = new System.Drawing.Point(40, 48);
			this.c1Combo1.MatchEntryTimeout = ((long)(100));
			this.c1Combo1.MaxDropDownItems = ((short)(5));
			this.c1Combo1.MaxLength = 32767;
			this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo1.Name = "c1Combo1";
			this.c1Combo1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"Name\" DataF" +
				"ield=\"Name\"><ValueItems /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"Contac" +
				"ted\" DataField=\"Contacted\"><ValueItems Translate=\"True\"><internalValues><ValueIt" +
				"em type=\"C1.Win.List.ValueItem\" Value=\"0\" dispVal=\"No\" /><ValueItem type=\"C1.W" +
				"in.C1List.ValueItem\" Value=\"1\" dispVal=\"Yes\" /></internalValues></ValueItems></C" +
				"1DataColumn></DataCols><Styles type=\"C1.Win.List.Design.ContextWrapper\"><Data>" +
				"Caption{AlignHorz:Center;}Normal{BackColor:Window;}Selected{ForeColor:HighlightT" +
				"ext;BackColor:Highlight;}Style18{AlignHorz:Near;}Style19{AlignHorz:Near;}Style14" +
				"{}Style15{AlignHorz:Near;}Style16{AlignHorz:Near;}Style17{}Style10{}Style11{}Odd" +
				"Row{}Style13{AlignHorz:Near;}Style12{AlignHorz:Near;}HighlightRow{ForeColor:High" +
				"lightText;BackColor:Highlight;}RecordSelector{AlignImage:Center;}Footer{}Style23" +
				"{}Style22{AlignHorz:Near;}Style21{AlignHorz:Near;}Style20{}Inactive{ForeColor:In" +
				"activeCaptionText;BackColor:InactiveCaption;}EvenRow{BackColor:Aqua;}Heading{Wra" +
				"p:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVe" +
				"rt:Center;}Style4{}Style9{AlignHorz:Near;}Style8{}Style5{}Group{AlignVert:Center" +
				";Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style7{}Style6{}Style1{}Style3{}" +
				"Style2{}</Data></Styles><Splits><C1.Win.List.ListBoxView AllowColSelect=\"False" +
				"\" Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFooterHeight=\"17\" Ve" +
				"rticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0, 118, 158</Clie" +
				"ntRect><internalCols><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style18\"" +
				" /><Style parent=\"Normal\" me=\"Style19\" /><FooterStyle parent=\"Style3\" me=\"Style2" +
				"0\" /><ColumnDivider><Color>DarkGray</Color><Style>Single</Style></ColumnDivider>" +
				"<Width>200</Width><Height>15</Height><DCIdx>0</DCIdx></C1DisplayColumn><C1Displa" +
				"yColumn><HeadingStyle parent=\"Style2\" me=\"Style21\" /><Style parent=\"Normal\" me=\"" +
				"Style22\" /><FooterStyle parent=\"Style3\" me=\"Style23\" /><ColumnDivider><Color>Dar" +
				"kGray</Color><Style>Single</Style></ColumnDivider><Height>15</Height><DCIdx>1</D" +
				"CIdx></C1DisplayColumn></internalCols><VScrollBar><Width>17</Width></VScrollBar>" +
				"<HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"St" +
				"yle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer" +
				"\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"" +
				"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><I" +
				"nactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"St" +
				"yle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSty" +
				"le parent=\"Selected\" me=\"Style5\" /><Style parent=\"\" me=\"Normal\" /></C1.Win.Lis" +
				"t.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent" +
				"=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"He" +
				"ading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Nor" +
				"mal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"N" +
				"ormal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Headin" +
				"g\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><ver" +
				"tSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Defaul" +
				"tRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.c1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo1.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo1.ScrollTips = false;
			this.c1Combo1.SelectionStart = 0;
			this.c1Combo1.Size = new System.Drawing.Size(352, 21);
			this.c1Combo1.TabIndex = 0;
			this.c1Combo1.Text = "c1Combo1";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(464, 272);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1Combo1});
			this.Name = "Form1";
			this.Text = "C1List .Net Tutorial21";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
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
			this.c1Combo1.HoldFields();
			this.c1Combo1.AddItem("Greg Daryll;0");
			this.c1Combo1.AddItem("Jane Lambert;1");
			this.c1Combo1.AddItem("Allen Clark;1");
			this.c1Combo1.AddItem("David Elkins;1");
			this.c1Combo1.AddItem("Carl Ziegler;0");
			this.c1Combo1.AddItem("William Yahner;1");
		}
	}
}
