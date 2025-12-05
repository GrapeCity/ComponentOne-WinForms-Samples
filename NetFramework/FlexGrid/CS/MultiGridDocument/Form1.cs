using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.FlexGrid;

namespace MultiGridDocument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // populate grids
            var conn = GetConnectionString();
            var da = new OleDbDataAdapter("select * from Categories", conn);
            var dt = new DataTable("Categories");
            da.Fill(dt);
            _flexCategories.DataSource = dt;
            da = new OleDbDataAdapter("select * from Products", conn);
            dt = new DataTable("Products");
            da.Fill(dt);
            _flexProducts.DataSource = dt;
        }

        // print the first grid using the traditional "PrintGrid" method
        private void printGridMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _flexProducts.PrintGrid("Traditional",
                PrintGridFlags.ActualSize |
                PrintGridFlags.ExtendLastCol |
                PrintGridFlags.ShowPrintDialog | 
                PrintGridFlags.ShowPreviewDialog);
        }

        // print the first grid using the grid's built-in PrintDocument
        // (can customize by attaching handlers to the document's events)
        private void printDocumentObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new PrintPreviewDialog())
            {
                dlg.Document = _flexProducts.PrintParameters.PrintDocument;
                dlg.ShowDialog(this);
            }
        }

        // print the first grid using the grid's built-in PrintDocument
        // and a CoolPreviewDialog
        private void coolPrintPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new CoolPrintPreview.CoolPrintPreviewDialog())
            {
                dlg.Document = _flexProducts.PrintParameters.PrintDocument;
                dlg.ShowDialog(this);
            }
        }

        // print both grids into an existing PrintDocument
        private void traditionalPrintPreviewDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new PrintPreviewDialog())
            {
                dlg.Document = _printDoc;
                dlg.ShowDialog(this);
            }
        }

        // print both grids into an existing PrintDocument using a CoolPrintPreviewDialog
        private void coolPrintPreviewDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new CoolPrintPreview.CoolPrintPreviewDialog())
            {
                dlg.Document = _printDoc;
                dlg.ShowDialog(this);
            }
        }

        // event handlers for the "PrintDocument" object on the form
        PrintDocumentGridRenderer _g1, _g2;
        void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // create and configure grid renderer for the first grid
            _g1 = new PrintDocumentGridRenderer(_flexCategories);
            _g1.Options = PrintGridFlags.FitToPageWidth | PrintGridFlags.ExtendLastCol;

            // create and configure grid renderer for the second grid
            _g2 = new PrintDocumentGridRenderer(_flexProducts);
            _g2.Options = PrintGridFlags.FitToPageWidth | PrintGridFlags.ExtendLastCol;
        }
        void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // render first grid
            if (_g1.CurrentPage < _g1.PageCount)
            {
                _g1.PrintPage(e);
                e.HasMorePages = true;
            }

            // render second grid
            else if (_g2.CurrentPage < _g2.PageCount)
            {
                _g2.PrintPage(e);
                e.HasMorePages = _g2.CurrentPage < _g2.PageCount;
            }
        }

        // data helper
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
