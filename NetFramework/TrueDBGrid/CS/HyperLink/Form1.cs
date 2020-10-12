using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace HyperLinkSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(480, 294);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.c1TrueDBGrid1_MouseDown);
            this.c1TrueDBGrid1.FetchCellStyle += new C1.Win.C1TrueDBGrid.FetchCellStyleEventHandler(this.c1TrueDBGrid1_FetchCellStyle);
            this.c1TrueDBGrid1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1TrueDBGrid1_MouseMove);
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(480, 294);
            this.Controls.Add(this.c1TrueDBGrid1);
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
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

			this.c1TrueDBGrid1.SetDataBinding(dt,"");
			// size the description column
			this.c1TrueDBGrid1.Splits[0].DisplayColumns["Description"].AutoSize();

			// no dead area in the grid
			this.c1TrueDBGrid1.EmptyRows = true;
			this.c1TrueDBGrid1.ExtendRightColumn = true;

			// raise an event so we color code the link column
			this.c1TrueDBGrid1.Splits[0].DisplayColumns["Link"].FetchStyle = true;
		}

		// color the link properly
		private void c1TrueDBGrid1_FetchCellStyle(object sender, C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs e)
		{
			Hyperlink link = this.c1TrueDBGrid1[e.Row,"Link"] as Hyperlink;
			if( link != null )
			{
				e.CellStyle.Font = new Font(this.c1TrueDBGrid1.Font, FontStyle.Underline);
				if( link.Visited )
					e.CellStyle.ForeColor = Color.Purple;
				else
					e.CellStyle.ForeColor = Color.Blue;
			}
		}

		// change the cursor over a link
		private void c1TrueDBGrid1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Cursor cursor = Cursors.Default;

			int row, col;
			if( this.c1TrueDBGrid1.CellContaining(e.X, e.Y, out row, out col) )
			{
                C1.Win.C1TrueDBGrid.C1DisplayColumn dispcol = this.c1TrueDBGrid1.FocusedSplit.DisplayColumns[col];
				Hyperlink link = this.c1TrueDBGrid1[row, dispcol.DataColumn.DataField] as Hyperlink;
				if( link != null )
				{
					using (Graphics g = this.c1TrueDBGrid1.CreateGraphics())
					{
						Rectangle r = this.c1TrueDBGrid1.Splits[0].GetCellBounds(row, col);
						int width = (int)g.MeasureString(link.ToString(), this.c1TrueDBGrid1.Font).Width;
						if( e.X - r.Left <= width )
							cursor = Cursors.Hand;
					}
				}
			}
			this.c1TrueDBGrid1.Cursor = cursor;
		}

		// go to the link
		private void c1TrueDBGrid1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if( this.c1TrueDBGrid1.Cursor == Cursors.Hand )
			{
				int row, col;
				if( this.c1TrueDBGrid1.CellContaining(e.X, e.Y, out row, out col) )
				{
                    C1.Win.C1TrueDBGrid.C1DisplayColumn dispcol = this.c1TrueDBGrid1.FocusedSplit.DisplayColumns[col];
                    Hyperlink link = this.c1TrueDBGrid1[row, dispcol.DataColumn.DataField] as Hyperlink;
					if( link != null )
						link.Activate();
				}
			}
		}
	}
}
