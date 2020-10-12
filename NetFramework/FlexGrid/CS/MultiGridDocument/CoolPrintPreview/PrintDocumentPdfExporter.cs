using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace CoolPrintPreview
{
    using C1.C1Pdf;

    /// <summary>
    /// Represents a class that exports a <see cref="PrintDocument"/> to a
    /// PDF file.
    /// </summary>
    internal class PrintDocumentPdfExporter
    {
        //-----------------------------------------------------------
        #region ** fields

        PrintDocument _doc;
        C1PdfDocument _pdf;
        PreviewPrintController _previewController;
        int _pageCount;
        bool _cancel;

        #endregion

        //-----------------------------------------------------------
        #region ** ctor

        public PrintDocumentPdfExporter(C1PdfDocument pdf)
        {
            // save reference to pdf component
            _pdf = pdf;
        }

        #endregion

        //-----------------------------------------------------------
        #region ** object model

        public bool RenderDocument(PrintDocument doc, bool showProgressDialog)
        {
            // save reference to document
            _doc = doc;

            // initialize pdf document
            _pdf.Clear();
            _pdf.Landscape = false;

            // prepare to render
            var savePC = _doc.PrintController;
            _previewController = new PreviewPrintController();
            _doc.PrintController = showProgressDialog
                ? new PrintControllerWithStatusDialog(_previewController)
                : (PrintController)_previewController;
            _pageCount = 0;
            _cancel = false;

            // render
            try
            {
                _doc.PrintPage += _doc_PrintPage;
                _doc.EndPrint += _doc_EndPrint;
                _doc.Print();
            }
            finally
            {
                _doc.PrintPage -= _doc_PrintPage;
                _doc.EndPrint -= _doc_EndPrint;
                _doc.PrintController = savePC;
            }

            // done
            return !_cancel;
        }

        #endregion

        //-----------------------------------------------------------
        #region ** PrintDocument event handlers

        void _doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            var pages = _previewController.GetPreviewPageInfo();
            while (_pageCount < pages.Length - 1)
            {
                DrawPage(pages, _pageCount++);
            }
            if (e.Cancel)
            {
                _cancel = true;
            }
        }
        void _doc_EndPrint(object sender, PrintEventArgs e)
        {
            var pages = _previewController.GetPreviewPageInfo();
            DrawPage(pages, _pageCount);
            if (e.Cancel)
            {
                _cancel = true;
            }
        }
        void DrawPage(PreviewPageInfo[] pages, int index)
        {
            // skip to next page
            if (index > 0)
            {
                _pdf.NewPage();
            }

            // get preview page info
            var pi = pages[index];

            // adjust page size
            var ps = pi.PhysicalSize;
            _pdf.PageSize = new SizeF(ps.Width / 100f * 72, ps.Height / 100f * 72);

            // draw image
            var img = pi.Image;
            _pdf.DrawImage(img, _pdf.PageRectangle);
        }

        #endregion
    }
}
