using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win;
using C1.Win.C1FlexGrid;

namespace MultiGridDocument
{
    public partial class Form1 : Form, C1FlexGridPrinterTest.IFlexSample
    {
        #region C1FlexGridPrinter
        public C1.C1Preview.C1PrintDocument MakeDoc(C1FlexGridPrintInfo printInfo, LongOperationEventHandler longOperation)
        {
            C1.C1Preview.C1PrintDocument doc = new C1.C1Preview.C1PrintDocument();
            C1FlexGridPrinter prnCategories = new C1FlexGridPrinter(_flexCategories);
            prnCategories.LongOperation += longOperation;
            prnCategories.PrintInfo = printInfo;
            C1FlexGridPrinter prnProducts = new C1FlexGridPrinter(_flexProducts);
            prnProducts.LongOperation += longOperation;
            prnProducts.PrintInfo = printInfo;
            // make render tables representing the grids:
            C1.C1Preview.RenderTable tblCategories = prnCategories.MakeGridTable(doc);
            C1.C1Preview.RenderTable tblProducts = prnProducts.MakeGridTable(doc);
            // add a page break before the 2nd grid:
            tblProducts.BreakBefore = C1.C1Preview.BreakEnum.Page;
            // add grids to document:
            doc.Body.Children.Add(tblCategories);
            doc.Body.Children.Add(tblProducts);
            // done:
            return doc;
        }
        #endregion

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
#if NotForC1FlexGridPrinter
            using (var dlg = new PrintPreviewDialog())
            {
                dlg.Document = _flexProducts.PrintParameters.PrintDocument;
                dlg.ShowDialog(this);
            }
#endif
        }

        // print the first grid using the grid's built-in PrintDocument
        // and a CoolPreviewDialog
        private void coolPrintPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if NotForC1FlexGridPrinter
            using (var dlg = new CoolPrintPreview.CoolPrintPreviewDialog())
            {
                dlg.Document = _flexProducts.PrintParameters.PrintDocument;
                dlg.ShowDialog(this);
            }
#endif
        }

        // print both grids into an existing PrintDocument
        private void traditionalPrintPreviewDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if NotForC1FlexGridPrinter
            using (var dlg = new PrintPreviewDialog())
            {
                dlg.Document = _printDoc;
                dlg.ShowDialog(this);
            }
#endif
        }

        // print both grids into an existing PrintDocument using a CoolPrintPreviewDialog
        private void coolPrintPreviewDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if NotForC1FlexGridPrinter
            using (var dlg = new CoolPrintPreview.CoolPrintPreviewDialog())
            {
                dlg.Document = _printDoc;
                dlg.ShowDialog(this);
            }
#endif
        }

        // event handlers for the "PrintDocument" object on the form
#if NotForC1FlexGridPrinter
        PrintDocumentGridRenderer _g1, _g2;
#endif
        void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
#if NotForC1FlexGridPrinter
            // create and configure grid renderer for the first grid
            _g1 = new PrintDocumentGridRenderer(_flexCategories);
            _g1.Options = PrintGridFlags.FitToPageWidth | PrintGridFlags.ExtendLastCol;

            // create and configure grid renderer for the second grid
            _g2 = new PrintDocumentGridRenderer(_flexProducts);
            _g2.Options = PrintGridFlags.FitToPageWidth | PrintGridFlags.ExtendLastCol;
#endif
        }
        void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
#if NotForC1FlexGridPrinter
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
#endif
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
