using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Barcode
{
    public partial class PrintBarCodes : C1DemoForm
    {
        DataTable _dt;
        int _item;

        public PrintBarCodes()
        {
            InitializeComponent();
        }

        private void PrintBarCodes_Load(object sender, EventArgs e)
        {
            _dt = DemoDataSource("Products");

            // create PrintDocument
            PrintDocument doc = new PrintDocument();
            doc.BeginPrint += new PrintEventHandler(_beginPrint);
            doc.PrintPage += new PrintPageEventHandler(_printPage);

            c1PrintPreviewControl1.Document = doc;
        }
  
        private void _beginPrint(object sender, PrintEventArgs e)
        {
            _item = 0;
        }

        private void _printPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.White, e.PageBounds);            

            Font font = new Font("Tahoma", 12);
            Rectangle rcPage = e.MarginBounds;
            Rectangle rc1 = rcPage;
            rc1.Height = 30;
            rc1.Width = 100;

            Rectangle rc2 = rc1;
            rc2.Offset(rc1.Width, 0);
            rc2.Width = 300;
            
            Rectangle rc3 = rc2;
            rc3.Offset(rc2.Width, 0);
            rc3.Width = 100;
            
            // show header at the top of the page
            g.DrawString("Product ID", new Font(font, FontStyle.Bold), Brushes.Black, rc1);
            g.DrawString("Name", new Font(font, FontStyle.Bold), Brushes.Black, rc2);
            g.DrawString("Unit Price", new Font(font, FontStyle.Bold), Brushes.Black, rc3);
            rc1.Y += rc1.Height + 10;
            rc2.Y += rc2.Height + 10;
            rc3.Y += rc3.Height + 10;

            // loop through rows until done (or until out of room)
            while (rc1.Bottom <= rcPage.Bottom && _item < _dt.Rows.Count)
            {
                DataRow dr = _dt.Rows[_item];
                string id = string.Format("{0:0000}", dr["ProductID"]);
                string name = (string)dr["ProductName"];
                g.DrawString(id, font, Brushes.Black, rc1);
                g.DrawString(name, font, Brushes.Black, rc2);

                c1BarCode1.Text = ((decimal)dr["UnitPrice"]).ToString(System.Globalization.CultureInfo.InvariantCulture);
                g.DrawImage(c1BarCode1.Image, rc3);

                rc1.Y += rc1.Height + 10;
                rc2.Y += rc2.Height + 10;
                rc3.Y += rc3.Height + 10;
                _item++;
            }

            // continue if necessary
            e.HasMorePages = (_item < _dt.Rows.Count - 1);
        }

    }
}
