using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.C1FlexGrid;

namespace HyperlinkSample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
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
			this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = @"10,1,0,0,0,75,Columns:0{Width:33;}";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(424, 317);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this._flex.MouseMove += new System.Windows.Forms.MouseEventHandler(this._flex_MouseMove);
			this._flex.MouseDown += new System.Windows.Forms.MouseEventHandler(this._flex_MouseDown);
			this._flex.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(424, 317);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Hyperlinks";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
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
			// create custom style for links
			CellStyle cs = _flex.Styles.Add("NewLink");
			cs.Font = new Font(_flex.Font , FontStyle.Underline);
			cs.ForeColor = Color.Blue;
			cs = _flex.Styles.Add("OldLink");
			cs.Font = new Font(_flex.Font , FontStyle.Underline);
			cs.ForeColor = Color.Purple;

			// create data source
			DataTable dt = new DataTable();
			dt.Columns.Add("Name", typeof(string));
			dt.Columns.Add("Description", typeof(string));
			dt.Columns.Add("Link", typeof(Hyperlink));
			dt.Columns["Link"].ReadOnly = true;

			string name, desc, url;

			name = "Google.com";
			desc = "Google: search engine";
			url  = "http://www.google.com";
			dt.Rows.Add(new object[] { name, desc, new Hyperlink(name, url) });

			name = "MSN.com";
			desc = "Microsoft Network: news etc";
			url  = "http://www.microsoft.com/isapi/redir.dll?prd=ie&pver=6&ar=IStart";
			dt.Rows.Add(new object[] { name, desc, new Hyperlink(name, url) });

			name = "Radio";
			desc = "Radio Station Guide";
			url  = "http://www.microsoft.com/isapi/redir.dll?prd=windows&sbp=mediaplayer&plcid=&pver=6.1&os=&over=&olcid=&clcid=&ar=Media&sba=RadioBar&o1=&o2=&o3=";
			dt.Rows.Add(new object[] { name, desc, new Hyperlink(name, url) });

			name = "Travel";
			desc = "Expedia: travel agency";
			url  = "http://www.expedia.com";
			dt.Rows.Add(new object[] { name, desc, new Hyperlink(name, url) });

			name = "PayPal";
			desc = "PayPal: buy and sell on-line";
			url  = "http://www.paypal.com";
			dt.Rows.Add(new object[] { name, desc, new Hyperlink(name, url) });

			name = "Guitar";
			desc = "Guitar: music and instruments";
			url  = "http://www.guitar.com";
			dt.Rows.Add(new object[] { name, desc, new Hyperlink(name, url) });

			_flex.DataSource = dt;
		}

		// show hyperlink cursor
		private void _flex_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			HitTestInfo ht = _flex.HitTest(e.X, e.Y);
			bool hand = false;
			if (ht.Type == HitTestTypeEnum.Cell)
			{
				Hyperlink link = _flex[ht.Row, ht.Column] as Hyperlink;
				if (link != null)
				{
					using (Graphics g = _flex.CreateGraphics())
					{
						Rectangle rc = _flex.GetCellRect(ht.Row, ht.Column, false);
						int width = (int)g.MeasureString(link.ToString(), _flex.Font).Width;
						if (e.X - rc.Left <= width)
							hand = true;
					}
				}
			}
			Cursor = (hand)? Cursors.Hand: Cursors.Default;
		}

		// activate hyperlink
		private void _flex_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (Cursor == Cursors.Hand)
			{
				HitTestInfo ht = _flex.HitTest(e.X, e.Y);
				if (ht.Type == HitTestTypeEnum.Cell)
				{
					Hyperlink link = _flex[ht.Row, ht.Column] as Hyperlink;
					if (link != null)
						link.Activate();
				}
			}
		}

		// use custom style for hyperlinks
		private void _flex_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
		{
			if (e.Style.BackColor == _flex.Styles.Normal.BackColor)
			{
				Hyperlink link = _flex[e.Row, e.Col] as Hyperlink;
				if (link != null)
					e.Style = _flex.Styles[link.Visited? "OldLink": "NewLink"];
			}
		}
	}
}
