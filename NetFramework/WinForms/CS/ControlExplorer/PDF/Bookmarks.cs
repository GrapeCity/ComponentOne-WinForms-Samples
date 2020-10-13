using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace ControlExplorer.PDF
{
    public partial class Bookmarks : C1DemoForm
    {
        public Bookmarks()
        {
            InitializeComponent();
        }

        //create fonts, StringFormat objects
        private Font _fontBody = new Font("Tahoma", 10);
        private Font _fontTitle = new Font("Tahoma", 15, FontStyle.Bold);
        private Font _fontHeader = new Font("Tahoma", 11, FontStyle.Bold);
        private StringFormat _sfRight;
        private StringFormat _sfRightCenter;

        private void Bookmarks_Load(object sender, EventArgs e)
        {
			//create StringFormat for right-aligned fields
			_sfRight = new StringFormat();
			_sfRight.Alignment = StringAlignment.Far;
			_sfRightCenter = new StringFormat();
			_sfRightCenter.Alignment = StringAlignment.Far;
			_sfRightCenter.LineAlignment = StringAlignment.Center;

			//initialize pdf generator
			_c1pdf.Clear();

			//get page rectangle, discount margins
			RectangleF rcPage = _c1pdf.PageRectangle;
			rcPage.Inflate(-72, -92);

			//loop through selected categories
			int page = 0;
			DataTable dt = GetCategories();
			foreach (DataRow dr in dt.Rows)
			{
				//add page break, update page counter
				if (page > 0) _c1pdf.NewPage();
				page++;

				//get current category name
				string catName = (string)dr["CategoryName"];

				//add title to page
				_c1pdf.DrawString(catName, _fontTitle, Brushes.Blue, rcPage);

				//add outline entry
				_c1pdf.AddBookmark(catName, 0, 0);

				//build row template
				RectangleF[] rcRows = new RectangleF[6];
				for (int i = 0; i < rcRows.Length; i++)
				{
					rcRows[i] = RectangleF.Empty;
					rcRows[i].Location = new PointF(rcPage.X, rcPage.Y + _fontHeader.SizeInPoints + 10);
					rcRows[i].Size = new SizeF(0, _fontBody.SizeInPoints + 3);
				}
				rcRows[0].Width = 110;		// Product Name
				rcRows[1].Width = 60;		// Unit Price
				rcRows[2].Width = 80;		// Qty/Unit
				rcRows[3].Width = 60;		// Stock Units
				rcRows[4].Width = 60;		// Stock Value
				rcRows[5].Width = 60;		// Reorder
				for (int i = 1; i < rcRows.Length; i++)
					rcRows[i].X = rcRows[i-1].X + rcRows[i-1].Width + 8;

				//add column headers
				_c1pdf.FillRectangle(Brushes.DarkGray, RectangleF.Union(rcRows[0], rcRows[5]));
				_c1pdf.DrawString("Product Name", _fontHeader, Brushes.White, rcRows[0]);
				_c1pdf.DrawString("Unit Price",   _fontHeader, Brushes.White, rcRows[1], _sfRight);
				_c1pdf.DrawString("Qty/Unit",	  _fontHeader, Brushes.White, rcRows[2]);
				_c1pdf.DrawString("Stock Units",  _fontHeader, Brushes.White, rcRows[3], _sfRight);
				_c1pdf.DrawString("Stock Value",  _fontHeader, Brushes.White, rcRows[4], _sfRight);
				_c1pdf.DrawString("Reorder",	  _fontHeader, Brushes.White, rcRows[5]);

				//loop through products in this category
				DataRow[] products = dr.GetChildRows("Categories_Products");

				foreach (DataRow product in products)
				{
					//move on to next row
					for (int i = 0; i < rcRows.Length; i++)
						rcRows[i].Y += rcRows[i].Height;

					//add row with some data
					try
					{
						_c1pdf.DrawString(product["ProductName"].ToString(),				_fontBody, Brushes.Black, rcRows[0]);
						_c1pdf.DrawString(string.Format("{0:c}", product["UnitPrice"]),		_fontBody, Brushes.Black, rcRows[1], _sfRight);
						_c1pdf.DrawString(string.Format("{0}", product["QuantityPerUnit"]), _fontBody, Brushes.Black, rcRows[2]);
						_c1pdf.DrawString(string.Format("{0}", product["UnitsInStock"]),	_fontBody, Brushes.Black, rcRows[3], _sfRight);
						_c1pdf.DrawString(string.Format("{0:c}", product["ValueInStock"]),	_fontBody, Brushes.Black, rcRows[4], _sfRight);
						if ((bool)product["OrderNow"])
							_c1pdf.DrawString("<<<", _fontBody, Brushes.Red, rcRows[5]);
					}
					catch
					{
						Debug.Assert(false);
					}
				}
				if (products.Length == 0)
				{
					rcRows[0].Y += rcRows[0].Height;
					_c1pdf.DrawString("No products in this category.", _fontBody, Brushes.Black,
									  RectangleF.Union(rcRows[0], rcRows[5]));
				}
			}

			//add page headers
			AddPageHeaders(rcPage);

            //save pdf file
            string filename = GetTempFileName(".pdf");
            _c1pdf.Save(filename);

            //display it
            webBrowser1.Navigate(filename);
        }

		private void AddPageHeaders(RectangleF rcPage)
		{
			RectangleF rcHdr = rcPage;
			rcHdr.Y = 10;
			rcHdr.Height = rcPage.Top - 10;
			for (int page = 0; page < _c1pdf.Pages.Count; page++)
			{
				//reopen each page
				_c1pdf.CurrentPage = page;

				//draw letterhead
				string s = string.Format("Page {0} of {1}", page+1, _c1pdf.Pages.Count);
				_c1pdf.DrawString(s, _fontBody, Brushes.LightGray, rcHdr, _sfRightCenter);
				rcHdr.Inflate(0, -30);
				_c1pdf.DrawRectangle(Pens.LightGray, rcHdr);
				rcHdr.Inflate(0, +30);
			}
		}

		private DataTable GetCategories()
		{
            string conn = this.DemoConnectionString;

            //load data into tables
			DataTable dtCategories = new DataTable("Categories");
			DataTable dtProducts   = new DataTable("Products");
			OleDbDataAdapter daCat = new OleDbDataAdapter("select * from Categories", conn);
			OleDbDataAdapter daPrd = new OleDbDataAdapter("select * from Products", conn);
			daCat.Fill(dtCategories);
			daPrd.Fill(dtProducts);

			//add calculated columns
			DataColumn col = dtProducts.Columns.Add("ValueInStock", typeof(decimal), "UnitPrice * UnitsInStock");
			col.Caption = "Value In Stock";
			col = dtProducts.Columns.Add("OrderNow", typeof(bool), "UnitsInStock <= ReorderLevel");
			col.Caption = "Order Now";

			//build data set with relation between categories and products
			DataSet ds = new DataSet();
			ds.Tables.Add(dtCategories);
			ds.Tables.Add(dtProducts);
			ds.Relations.Add("Categories_Products", dtCategories.Columns["CategoryID"], dtProducts.Columns["CategoryID"]);

			//return Categories table
			return dtCategories;
		}
    }
}

