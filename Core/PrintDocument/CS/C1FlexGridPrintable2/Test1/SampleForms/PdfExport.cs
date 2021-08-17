using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.FlexGrid;
using System.Diagnostics;
using System.IO;

// NOTE: look for "#if not_C1FlexGridPrinter" to see changes made to use C1FlexGridPrinter.

namespace PdfExport
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.FlexGrid.C1FlexGridPrintable2 _flex;
        private System.Windows.Forms.Button _btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _rpp;
        private System.Windows.Forms.TextBox _cpp;
#if not_C1FlexGridPrinter
		private C1.C1Pdf.C1PdfDocument _pdf;
#endif
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
            this._flex = new C1.Win.FlexGrid.C1FlexGridPrintable2();
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
            this._flex.Location = new System.Drawing.Point(0, 45);
            this._flex.Name = "_flex";
            this._flex.Size = new System.Drawing.Size(528, 333);
            this._flex.TabIndex = 0;
            // 
            // _btnPrint
            // 
            this._btnPrint.Location = new System.Drawing.Point(292, 6);
            this._btnPrint.Name = "_btnPrint";
            this._btnPrint.Size = new System.Drawing.Size(103, 23);
            this._btnPrint.TabIndex = 1;
            this._btnPrint.Text = "Export to Pdf";
            this._btnPrint.Click += new System.EventHandler(this._btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rows/page:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cols/page:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _rpp
            // 
            this._rpp.Location = new System.Drawing.Point(80, 8);
            this._rpp.Name = "_rpp";
            this._rpp.Size = new System.Drawing.Size(37, 20);
            this._rpp.TabIndex = 3;
            this._rpp.Text = "20";
            // 
            // _cpp
            // 
            this._cpp.Location = new System.Drawing.Point(227, 8);
            this._cpp.Name = "_cpp";
            this._cpp.Size = new System.Drawing.Size(36, 20);
            this._cpp.TabIndex = 3;
            this._cpp.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(528, 378);
            this.Controls.Add(this._rpp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnPrint);
            this.Controls.Add(this._flex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cpp);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Pdf Export";
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
            FlexPdfCreator pdfCreator = new FlexPdfCreator(_flex);

            string tempDirectoryPath = Path.GetTempPath();
			//string fileName = @"c:\temp\flex.pdf";
			string fileName = Path.Combine(tempDirectoryPath, "flex.pdf");
            pdfCreator.Save(fileName);
            //System.Diagnostics.Process.Start(fileName);
            Process.Start(new ProcessStartInfo { FileName = fileName, UseShellExecute = true });
        }

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        /// <summary>
        /// FlexPdfCreator
        /// 
        /// Renders a C1FlexGrid using specified row and column breaks into a pdf file.
        /// 
        /// The row and column breaks are specified by setting the Row.UserData
        /// (or Column.UserData) to an asterisk.
        /// 
        /// </summary>
        public class FlexPdfCreator
        {
            // ** fields
#if not_C1FlexGridPrinter
            private ArrayList   _images;
            private float       _zoom;
#else
            C1FlexGridPrinter _printer = null;
#endif

            // ** ctor
#if not_C1FlexGridPrinter // original version
            public FlexPdfCreator(C1FlexGrid flex)
            {                  
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
#else
            public FlexPdfCreator(C1FlexGridPrintable2 flex)
            {
                flex.PrintCell += new C1FlexGridPrintable2.PrintCellEventHandler(flex_PrintCell);
                _printer = new C1FlexGridPrinter(flex);
            }

            void flex_PrintCell(object sender, C1FlexGridPrintable2.PrintCellEventArgs e)
            {
                C1FlexGridPrintable2 flex = (C1FlexGridPrintable2)sender;
                // test for column break:
                if (flex.Cols[e.Col].UserData != null && flex.Cols[e.Col].UserData.ToString() == "*")
                    e.TableCell.Table.Cols[e.TableCell.Col].PageBreakBehavior = C1.C1Preview.PageBreakBehaviorEnum.MustBreak;
                // test for row break:
                if (flex.Rows[e.Row].UserData != null && flex.Rows[e.Row].UserData.ToString() == "*")
                    e.TableCell.Table.Rows[e.TableCell.Row].PageBreakBehavior = C1.C1Preview.PageBreakBehaviorEnum.MustBreak;
                // that's it.
            }
#endif

            // ** event handlers
			public void Save(string fileName)
			{
#if not_C1FlexGridPrinter
				// create new pdf document
				C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

				// add pages to document
				for (int page = 0; page < _images.Count; page++)
				{
					DrawPageImage(pdf, page);
				}

				// done
				pdf.Save(fileName);
#else
                // adjust printout for better export:
                _printer.PrintInfo.AutoColWidths = true;
                _printer.PrintInfo.RepeatFixedCols = false;
                C1.C1Preview.C1PrintDocument doc = _printer.MakeDocument();
                doc.Export(fileName);
#endif
			}

#if not_C1FlexGridPrinter
            private void DrawPageImage(C1.C1Pdf.C1PdfDocument pdf, int index)
            {
				// get image bounds
				RectangleF rcBounds = pdf.PageRectangle;
				rcBounds.Inflate(-72, -72);
				
				// calculate zoom factor
                if (index == 0)
                {
                    // get size of largest image
                    SizeF szMax = Size.Empty;
                    foreach (Image page in _images)
                    {
                        szMax.Height = Math.Max(szMax.Height, page.Height);
                        szMax.Width  = Math.Max(szMax.Width,  page.Width);
                    }

                    // get size of page bounds
                    SizeF szPage = rcBounds.Size;

                    // calculate zoom so largest image doesn't overflow the page
                    _zoom = 1;
                    float zh = szPage.Width/szMax.Width;
                    float zv = szPage.Height/szMax.Height;
                    if (zh < 1 || zv < 1)
                        _zoom = Math.Min(zh, zv);
                }

                // draw grid image
                RectangleF rc = rcBounds;
                Image img     = _images[index] as Image;
                rc.Width      = (int)(img.Width  * _zoom);
                rc.Height     = (int)(img.Height * _zoom);
				if (index > 0) pdf.NewPage();
                pdf.DrawImage(img, rc);
            }
#endif
        }
	}
}
