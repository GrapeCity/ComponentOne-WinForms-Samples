using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.FlexGrid;

namespace CustomPrintMultiGrid
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.FlexGrid.C1FlexGrid _flex;
        private System.Windows.Forms.Button _btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _rpp;
        private System.Windows.Forms.TextBox _cpp;
        private C1FlexGrid _flex2;
        private SplitContainer splitContainer1;
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
            this._flex = new C1.Win.FlexGrid.C1FlexGrid();
            this._btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._rpp = new System.Windows.Forms.TextBox();
            this._cpp = new System.Windows.Forms.TextBox();
            this._flex2 = new C1.Win.FlexGrid.C1FlexGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._flex2)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:22;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 0);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 17;
            this._flex.Size = new System.Drawing.Size(237, 352);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            // 
            // _btnPrint
            // 
            this._btnPrint.Location = new System.Drawing.Point(291, 6);
            this._btnPrint.Name = "_btnPrint";
            this._btnPrint.Size = new System.Drawing.Size(102, 26);
            this._btnPrint.TabIndex = 1;
            this._btnPrint.Text = "Print";
            this._btnPrint.Click += new System.EventHandler(this._btnPrint_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rows/page:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(145, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cols/page:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _rpp
            // 
            this._rpp.Location = new System.Drawing.Point(89, 8);
            this._rpp.Name = "_rpp";
            this._rpp.Size = new System.Drawing.Size(41, 22);
            this._rpp.TabIndex = 3;
            this._rpp.Text = "60";
            // 
            // _cpp
            // 
            this._cpp.Location = new System.Drawing.Point(223, 8);
            this._cpp.Name = "_cpp";
            this._cpp.Size = new System.Drawing.Size(39, 22);
            this._cpp.TabIndex = 3;
            this._cpp.Text = "6";
            // 
            // _flex2
            // 
            this._flex2.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:26;}\t";
            this._flex2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex2.Location = new System.Drawing.Point(0, 0);
            this._flex2.Name = "_flex2";
            this._flex2.Rows.DefaultSize = 17;
            this._flex2.Size = new System.Drawing.Size(319, 352);
            this._flex2.StyleInfo = resources.GetString("_flex2.StyleInfo");
            this._flex2.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._flex);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._flex2);
            this.splitContainer1.Size = new System.Drawing.Size(560, 352);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(560, 392);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this._rpp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cpp);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Print Multiple Grids in a Single Document";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._flex2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

        void Form1_Load(object sender, System.EventArgs e)
        {
            // create data source
            string sql = "select * from customers";
            string conn = GetConnectionString();
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            // bind grid
            _flex.DataSource = dt;
            _flex.ShowCursor = true;

            // bind the other grid
            sql = "select * from employees";
            da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            _flex2.AutoResize = false;
            _flex2.DataSource = dt;
            _flex2.ShowCursor = true;
        }
        void _btnPrint_Click(object sender, System.EventArgs e)
        {
            // get rows/cols per page
            int rpp = 10;
            int cpp = 3;
            try
            {
                rpp = int.Parse(_rpp.Text);
                cpp = int.Parse(_cpp.Text);
            }
            catch {}

            // mark grid with row/column breaks
            C1FlexGrid[] flexArray = { _flex, _flex2 };
            foreach (C1FlexGrid flex in flexArray)
            {
                for (int r = flex.Rows.Fixed; r < flex.Rows.Count; r++)
                    flex.Rows[r].UserData = (r % rpp == 0) ? "*" : null;

                for (int c = flex.Cols.Fixed; c < flex.Cols.Count; c++)
                    flex.Cols[c].UserData = (c % cpp == 0) ? "*" : null;
            }

            // print the grid using the specified page/column breaks
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = new FlexPrintDocument("Two Grids", flexArray);
            dlg.Document.DefaultPageSettings.Landscape = true;
            dlg.ShowDialog();
        }

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
        
        /// <summary>
        /// FlexPrintDocument
        /// 
        /// Inherits from PrintDocument and renders a C1FlexGrid using specified
        /// row and column breaks.
        /// 
        /// The row and column breaks are specified by setting the Row.UserData
        /// (or Column.UserData) to an asterisk.
        /// 
        /// </summary>
        public class FlexPrintDocument : PrintDocument
        {
            // ** fields
            private ArrayList   _images;
            private int         _currentPage;
            private float       _zoom;

            // ** ctors
            public FlexPrintDocument(string documentName, ICollection flexCollection)
            {
                // initialize
                _zoom = 1;
                _images = new ArrayList();
                DocumentName = documentName;

                // render each grid
                foreach (C1FlexGrid flex in flexCollection)
                {
                    // loop through columns looking for breaks
                    int c1 = flex.Cols.Fixed;
                    int c2 = c1;
                    for (int c = flex.Cols.Fixed; c < flex.Cols.Count; c++)
                    {
                        // check if this is a column break
                        if (c == flex.Cols.Count - 1 ||
                            (flex.Cols[c].UserData != null && flex.Cols[c].UserData.ToString() == "*"))
                        {
                            // found break, column range is c1-c
                            c2 = c;

                            // loop through rows looking for breaks
                            int r1 = flex.Rows.Fixed;
                            int r2 = r1;
                            for (int r = flex.Rows.Fixed; r < flex.Rows.Count; r++)
                            {
                                // look for next row break
                                if (r == flex.Rows.Count - 1 ||
                                    (flex.Rows[r].UserData != null && flex.Rows[r].UserData.ToString() == "*"))
                                {
                                    // found break, row range is r1-r
                                    r2 = r;

                                    // create image
                                    _images.Add(flex.CreateImage(r1, c1, r2, c2));

                                    // update row range
                                    r1 = r + 1;
                                }
                            }

                            // update column range
                            c1 = c + 1;
                        }
                    }
                }
            }
            public FlexPrintDocument(C1FlexGrid flex) : this(flex.Name, new C1FlexGrid[] { flex })
            {
            }


            // ** event handlers
            override protected void OnBeginPrint(PrintEventArgs e)
            {
                _currentPage = 0;
                base.OnBeginPrint(e);
            }
            override protected void OnPrintPage(PrintPageEventArgs e)
            {
                // sanity on empty documents
                if (_currentPage >= _images.Count)
                {
                    e.HasMorePages = false;
                    e.Cancel = true;
                    return;
                }

                // calculate zoom factor
                if (_currentPage == 0)
                {
                    // get size of largest image
                    SizeF szMax = Size.Empty;
                    foreach (Image page in _images)
                    {
                        szMax.Height = Math.Max(szMax.Height, page.Height);
                        szMax.Width  = Math.Max(szMax.Width,  page.Width);
                    }

                    // get size of page bounds
                    SizeF szPage = e.MarginBounds.Size;

                    // calculate zoom so largest image doesn't overflow the page
                    _zoom = 1;
                    float zh = szPage.Width/szMax.Width;
                    float zv = szPage.Height/szMax.Height;
                    if (zh < 1 || zv < 1)
                        _zoom = Math.Min(zh, zv);
                }

                // prepare to draw on the page
                Graphics g = e.Graphics;

                // draw page header and footer
                //int y = (e.PageBounds.Top + e.MarginBounds.Top)/2;
                //DrawHeaderFooter(g, _hdr, _fontHdr, e.MarginBounds, y);
                //y = (e.PageBounds.Bottom + e.MarginBounds.Bottom)/2;
                //DrawHeaderFooter(g, _ftr, _fontFtr, e.MarginBounds, y);

                // draw grid image
                Rectangle rc = e.MarginBounds;
                Image img    = _images[_currentPage] as Image;
                rc.Width     = (int)(img.Width  * _zoom);
                rc.Height    = (int)(img.Height * _zoom);
                g.DrawImage(img, rc);

                // get ready for next
                _currentPage++;
                e.HasMorePages = _currentPage < _images.Count;

                // call base class
                base.OnPrintPage(e);
            }
        }
	}
}
