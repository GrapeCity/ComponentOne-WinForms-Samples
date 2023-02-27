using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiGridPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // get northwind data from the cloud
            var uri = new Uri("http://services.odata.org/Northwind/Northwind.svc/");
            var ctx = new MultiGridPage.ServiceReference1.NorthwindEntities(uri);

            // bind Categories grid
            this.flexCategories.DataSource = ctx.Categories.ToList();
            this.flexCategories.AutoSizeCols();

            // bind Employees grid
            this.flexEmployees.DataSource = ctx.Employees.ToList();
            this.flexEmployees.AutoSizeCols();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create PrintDocument
            var doc = new PrintDocument();
            var ps = doc.DefaultPageSettings;
            ps.Landscape = true;
            doc.DefaultPageSettings = ps;
            doc.PrintPage += doc_PrintPage;

            // show PrintDocument
            using (var dlg = new PrintPreviewDialog())
            {
                dlg.Document = doc;
                dlg.ShowDialog();
            }
        }
        void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Categories caption
            var pt = e.MarginBounds.Location;
            e.Graphics.DrawString("Categories", Font, Brushes.Black, pt);
            pt.Y += (int)(Font.SizeInPoints / 72 * 96) + 10;

            // Categories data
            var img = flexCategories.CreateImage();
            var rc = new Rectangle(pt, img.Size);
            e.Graphics.DrawImage(img, rc);

            // Employees caption
            pt.Y = rc.Bottom + 20;
            e.Graphics.DrawString("Employees", Font, Brushes.Black, pt);
            pt.Y += (int)(Font.SizeInPoints / 72 * 96) + 10;

            // Employees data
            img = flexEmployees.CreateImage();
            rc = new Rectangle(pt, img.Size);
            e.Graphics.DrawImage(img, rc);
        }
    }
}
