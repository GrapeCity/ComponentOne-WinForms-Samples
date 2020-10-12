using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using C1.C1Preview;
using C1.Win.C1Preview;

namespace C1.Win.C1FlexGrid
{
    // This file contains the object model exposed by C1FlexGridPrinter - 
    // public ctor, properties and methods.
    public partial class C1FlexGridPrinter
    {
        #region ctor
        /// <summary>
        /// Initializes a new instance of the C1FlexGridPrinter class.
        /// </summary>
        /// <param name="grid">The C1FlexGrid that is to be printed.</param>
        public C1FlexGridPrinter(C1FlexGrid grid)
        {
            _grid = grid;
            _grid2 = grid as C1FlexGridPrintable2;
            if (_grid2 != null)
                _grid2.Printer = this;
        }
        #endregion

        #region Public properties
        /// <summary>
        /// Gets or sets print info that allows to adjust the way the grid is rendered.
        /// Cannot be <c>null</c>.
        /// </summary>
        public C1FlexGridPrintInfo PrintInfo
        {
            get { return _printInfo; }
            set
            {
                if (value == null)
                    throw new Exception("PrintInfo cannot be null.");
                _printInfo = value;
            }
        }
        #endregion

        #region Public events
        /// <summary>
        /// Fired periodically while the grid is being rendered.
        /// Allows to show progress and cancel the operation.
        /// </summary>
        public event LongOperationEventHandler LongOperation;
        #endregion

        #region Public methods
        /// <summary>
        /// Shows the print preview dialog with a C1PrintDocument
        /// representing the grid.
        /// </summary>
        public void PrintPreview()
        {
            C1PrintPreviewDialog pview = new C1PrintPreviewDialog();
            pview.PreviewPane.ZoomMode = ZoomModeEnum.PageWidth;
            pview.Document = MakeDocument();
            pview.ShowDialog();
        }

        /// <summary>
        /// Creates a <see cref="C1PrintDocument"/> that can be used to print, preview or export
        /// the grid. Page header and footer specified by the grid's PrintParameters are honored.
        /// </summary>
        /// <returns>The C1PrintDocument representing the grid.</returns>
        public C1PrintDocument MakeDocument()
        {
            C1PrintDocument doc = new C1PrintDocument();
            doc.Body.Children.Add(MakeGridTable(doc));
            doc.PageLayout.PageHeader = MakePageHeader(doc);
            doc.PageLayout.PageFooter = MakePageFooter(doc);
            return doc;
        }

        /// <summary>
        /// Creates a render object representing the grid.
        /// </summary>
        /// <param name="doc">The document that is to contain the created render object, or null.
        /// Note that this method does not add the created object to the document -
        /// it is the responsibility of the caller to do that.
        /// </param>
        /// <returns>The render object created.</returns>
        /// <remarks>
        /// The passed C1PrintDocument object, if not null, is used to optimize the way the grid is rendered.
        /// </remarks>
        public RenderTable MakeGridTable(C1PrintDocument doc)
        {
            Reset();
            InitGlyphImages(doc);
            HighLightEnum savedHighlight = _grid.HighLight;
            if (!PrintInfo.PrintHighlight)
                _grid.HighLight = HighLightEnum.Never;
            try
            {
                return MakeGridTableInternal(doc);
            }
            finally
            {
                _grid.HighLight = savedHighlight;
            }
        }

        /// <summary>
        /// Makes a <see cref="RenderText"/> object representing the page header
        /// as specified in the grid's PrintParameters. The returned object
        /// may be assigned to a C1PrintDocument's PageLayout.PageHeader.
        /// </summary>
        /// <param name="doc">The document that is to contain the created render object, or null.</param>
        /// <returns>The page header render object.</returns>
        public RenderObject MakePageHeader(C1PrintDocument doc)
        {
            string tagOpenParen = doc == null ? "[" : doc.TagOpenParen;
            string tagCloseParen = doc == null ? "]" : doc.TagCloseParen;
            return MakePageHeader(false, tagOpenParen, tagCloseParen);
        }

        /// <summary>
        /// Makes a <see cref="RenderText"/> object representing the page footer
        /// as specified in the grid's PrintParameters. The returned object
        /// may be assigned to a C1PrintDocument's PageLayout.PageFooter.
        /// </summary>
        /// <param name="doc">The document that is to contain the created render object, or null.</param>
        /// <returns>The page header footer object.</returns>
        public RenderObject MakePageFooter(C1PrintDocument doc)
        {
            string tagOpenParen = doc == null ? "[" : doc.TagOpenParen;
            string tagCloseParen = doc == null ? "]" : doc.TagCloseParen;
            return MakePageHeader(true, tagOpenParen, tagCloseParen);
        }
        #endregion
    }
}
