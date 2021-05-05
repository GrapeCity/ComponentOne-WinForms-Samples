using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;

namespace CustomPrint
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        #region C1FlexGridPrinter
        // this code is taken as-is from _btnPrint_Click, but without showing the standard PrintPreviewDialog:
        void _flex_PrintStarting(object sender, EventArgs e)
        {
            // get rows/cols per page
            int rpp = 10;
            int cpp = 3;
            try
            {
                rpp = int.Parse(_rpp.Text);
                cpp = int.Parse(_cpp.Text);
            }
            catch { }

            // mark grid with row/column breaks
            for (int r = _flex.Rows.Fixed; r < _flex.Rows.Count; r++)
            {
                _flex.Rows[r].UserData = (r % rpp == 0)
                    ? "*"
                    : null;
            }
            for (int c = _flex.Cols.Fixed; c < _flex.Cols.Count; c++)
            {
                _flex.Cols[c].UserData = (c % cpp == 0)
                    ? "*"
                    : null;
            }
        }

        public void _flex_PrintCell(object sender, C1FlexGridPrintable2.PrintCellEventArgs e)
        {
            C1FlexGridPrintable2 flex = (C1FlexGridPrintable2)sender;
            // check if this is a row break
            if (flex.Rows[e.Row].UserData != null && flex.Rows[e.Row].UserData.ToString() == "*")
            {
                C1.C1Preview.RenderTable rtbl = e.TableCell.Table;
                int tblRow = e.TableCell.Row;
                // the marks are on LAST rows on page while PageBreakBehavior determines break BEFORE row, hence "+1":
                rtbl.Rows[tblRow + 1].PageBreakBehavior = C1.C1Preview.PageBreakBehaviorEnum.MustBreak;
            }


            // check if this is a column break
            if (flex.Cols[e.Col].UserData != null && flex.Cols[e.Col].UserData.ToString() == "*")
            {
                C1.C1Preview.RenderTable rtbl = e.TableCell.Table;
                int tblCol = e.TableCell.Col;
                // see comment above re "+1":
                rtbl.Cols[tblCol + 1].PageBreakBehavior = C1.C1Preview.PageBreakBehaviorEnum.MustBreak;
            }
        }
        #endregion

        private C1.Win.C1FlexGrid.C1FlexGridPrintable2 _flex;
        private System.Windows.Forms.Button _btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _rpp;
        private System.Windows.Forms.TextBox _cpp;
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
            #region C1FlexGridPrinter
            _flex.PrintStarting += new EventHandler(_flex_PrintStarting);
            _flex.PrintCell += new C1FlexGridPrintable2.PrintCellEventHandler(_flex_PrintCell);
            #endregion
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
            this._flex = new C1.Win.C1FlexGrid.C1FlexGridPrintable2();
            this._btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._rpp = new System.Windows.Forms.TextBox();
            this._cpp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 40);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 19;
            this._flex.Size = new System.Drawing.Size(576, 356);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            // 
            // _btnPrint
            // 
            this._btnPrint.Location = new System.Drawing.Point(307, 7);
            this._btnPrint.Name = "_btnPrint";
            this._btnPrint.Size = new System.Drawing.Size(73, 21);
            this._btnPrint.TabIndex = 1;
            this._btnPrint.Text = "Print";
            this._btnPrint.Click += new System.EventHandler(this._btnPrint_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rows/page:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(147, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cols/page:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _rpp
            // 
            this._rpp.Location = new System.Drawing.Point(73, 7);
            this._rpp.Name = "_rpp";
            this._rpp.Size = new System.Drawing.Size(34, 20);
            this._rpp.TabIndex = 3;
            this._rpp.Text = "20";
            // 
            // _cpp
            // 
            this._cpp.Location = new System.Drawing.Point(207, 7);
            this._cpp.Name = "_cpp";
            this._cpp.Size = new System.Drawing.Size(33, 20);
            this._cpp.TabIndex = 3;
            this._cpp.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 396);
            this.Controls.Add(this._rpp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnPrint);
            this.Controls.Add(this._flex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cpp);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Custom Printing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		#endregion

        void Form1_Load(object sender, System.EventArgs e)
        {
            // create data source
            string conn = GetConnectionString();
            string sql = "select * from customers";
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            // bind grid
            _flex.DataSource = dt;
            _flex.Cols[0].Width = _flex.Rows[0].HeightDisplay;
            _flex.ShowCursor = true;
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
            for (int r = _flex.Rows.Fixed; r < _flex.Rows.Count; r++)
            {
                _flex.Rows[r].UserData = (r % rpp == 0)
                    ? "*"
                    : null;
            }
            for (int c = _flex.Cols.Fixed; c < _flex.Cols.Count; c++)
            {
                _flex.Cols[c].UserData = (c % cpp == 0)
                    ? "*"
                    : null;
            }

            // print the grid using the specified page/column breaks
#if not_needed_for_C1FlexGridPrinter
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = new FlexPrintDocument(_flex);
            dlg.ShowDialog();
#else
            C1.Win.C1Preview.C1PrintPreviewDialog pview = new C1.Win.C1Preview.C1PrintPreviewDialog();
            pview.Document = new C1FlexGridPrinter(_flex).MakeDocument();
            pview.ShowDialog();
#endif
        }
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
        
#if not_needed_for_C1FlexGridPrinter
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

            // ** ctor
            public FlexPrintDocument(C1FlexGrid flex)
            {                  
                // initialize document name
                DocumentName = flex.Name;
                 
                // initialize zoom factor
                _zoom = 1;

                // create page images
                _images = new ArrayList();

                // initialize
                int r1, c1, r2, c2;

                // loop through columns looking for breaks
                c1 = c2 = flex.Cols.Fixed;
                for (int c = flex.Cols.Fixed; c < flex.Cols.Count; c++)
                {
                    // check if this is a column break
                    if (c == flex.Cols.Count-1 ||
                        (flex.Cols[c].UserData != null && flex.Cols[c].UserData.ToString() == "*"))
                    {
                        // found break, column range is c1-c
                        c2 = c;

                        // loop through rows looking for breaks
                        r1 = r2 = flex.Rows.Fixed;
                        for (int r = flex.Rows.Fixed; r < flex.Rows.Count; r++)
                        {
                            // look for next row break
                            if (r == flex.Rows.Count-1 ||
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
#endif // not_needed_for_C1FlexGridPrinter
	}
}
