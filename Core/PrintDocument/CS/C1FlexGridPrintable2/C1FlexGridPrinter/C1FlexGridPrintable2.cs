using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using C1.C1Preview;

namespace C1.Win.FlexGrid
{
    /// <summary>
    /// Represents a <see cref="C1.Win.FlexGrid.C1FlexGrid"/> that can be inserted
    /// into a <see cref="C1.C1Preview.C1PrintDocument"/> for printing, preview or export.
    /// </summary>
    /// <remarks>
    /// In many cases, you can print a regular <see cref="C1FlexGrid"/> without changing its type
    /// to <c>C1FlexGridPrintable2</c>, using <see cref="C1FlexGridPrinter"/>.
    /// You will need to use this class in the following cases:
    /// <list type="bullet">
    /// <item>If your grid contains owner drawn cells.</item>
    /// <item>If you want to customize the way grid's cells are printed using <see cref="C1PrintDocument"/> object model.</item>
    /// </list>
    /// In those cases, simply change the type of your grid and the constructor call from <see cref="C1FlexGrid"/> to
    /// <c>C1FlexGridPrintable2</c>.
    /// To customize how individual cells are printed use the <see cref="C1FlexGridPrintable2.PrintCell"/> event.
    /// </remarks>
    /// <seealso cref="C1FlexGridPrinter"/>
    public class C1FlexGridPrintable2 : C1FlexGrid
    {
        #region Private data
        private C1.Win.FlexGrid.C1FlexGridPrinter _printer;
        private bool _isPrinting = false;
        private event PrintCellEventHandler _printCellEventHandler = null;
        private event EventHandler _printStartingEventHandler = null;
        private event EventHandler _printEndedEventHandler = null;
        private event LongOperationEventHandler _longOperationEventHandler = null;
        #endregion

        #region Public nested classes
        /// <summary>
        /// Represents arguments for the <see cref="C1FlexGridPrintable2.PrintCell"/> event.
        /// </summary>
        public class PrintCellEventArgs : RowColEventArgs
        {
            private TableCell _tableCell = null;
            private C1PrintDocument _document = null;
            /// <summary>
            /// Initializes a new instance of <see cref="PrintCellEventArgs"/> class.
            /// </summary>
            /// <param name="tableCell">The cell of the <see cref="RenderTable"/> object.</param>
            /// <param name="document">The document that will contain the grid.</param>
            /// <param name="gridRow">The <see cref="C1FlexGrid"/> row index.</param>
            /// <param name="gridCol">The <see cref="C1FlexGrid"/> column index.</param>
            public PrintCellEventArgs(C1.C1Preview.TableCell tableCell, C1PrintDocument document, int gridRow, int gridCol)
                : base(gridRow, gridCol)
            {
                _tableCell = tableCell;
                _document = document;
            }
            /// <summary>
            /// Gets the current table cell.
            /// </summary>
            public TableCell TableCell { get { return _tableCell; } }
            /// <summary>
            /// Gets the document which will contain the grid.
            /// Note that this value may be <c>null</c> if the <see cref="C1FlexGridPrinter.MakeGridTable(C1PrintDocument)"/>
            /// method call was not passed a valid document instance.
            /// </summary>
            public C1PrintDocument Document { get { return _document; } }
        }

        /// <summary>
        /// Describes a <see cref="C1FlexGridPrintable2.PrintCell"/> event handler.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        public delegate void PrintCellEventHandler(object sender, PrintCellEventArgs e);
        #endregion

        #region Public object model
        /// <summary>
        /// Initializes a new instance of <see cref="C1FlexGridPrintable2"/> class.
        /// </summary>
        public C1FlexGridPrintable2()
            : base()
        {
            _printer = null;
        }

        /// <summary>
        /// Gets a value indicating whether the grid is currently printing.
        /// This property may be used in OwnerDrawCell event handler to change
        /// owner drawing when printing.
        /// </summary>
        public bool IsPrinting
        {
            get { return _isPrinting; }
            private set { _isPrinting = value; }
        }

        /// <summary>
        /// Gets the <see cref="C1FlexGridPrinter"/> that is being used to print the current <see cref="C1FlexGridPrintable2"/>.
        /// </summary>
        public C1FlexGridPrinter Printer
        {
            get { return _printer; }
            internal set
            {
                if (_printer != null)
                    _printer.LongOperation -= new LongOperationEventHandler(_printer_LongOperation);
                _printer = value;
                if (_printer != null)
                    _printer.LongOperation += new LongOperationEventHandler(_printer_LongOperation);
            }
        }

        /// <summary>
        /// Fired immediately after a render object representing the cell has been added to the
        /// render table representing the grid. Use this event to adjust printed cell attributes.
        /// </summary>
        public event PrintCellEventHandler PrintCell
        {
            add
            {
                _printCellEventHandler = (PrintCellEventHandler)Delegate.Combine(_printCellEventHandler, value);
            }
            remove
            {
                _printCellEventHandler = (PrintCellEventHandler)Delegate.Remove(_printCellEventHandler, value);
            }
        }

        /// <summary>
        /// Fired before the render object representing the grid is created by <see cref="C1FlexGridPrinter"/>.
        /// This event may be used to adjust the properties of the grid prior to printing.
        /// </summary>
        public event EventHandler PrintStarting
        {
            add
            {
                _printStartingEventHandler = (EventHandler)Delegate.Combine(_printStartingEventHandler, value);
            }
            remove
            {
                _printStartingEventHandler = (EventHandler)Delegate.Remove(_printStartingEventHandler, value);
            }
        }

        /// <summary>
        /// Fired after the render object representing the grid has been created by <see cref="C1FlexGridPrinter"/>.
        /// If the grid's properties were adjusted for printing in the <see cref="PrintStarting"/> handler,
        /// this event may be used to revert those changes.
        /// </summary>
        public event EventHandler PrintEnded
        {
            add
            {
                _printEndedEventHandler = (EventHandler)Delegate.Combine(_printEndedEventHandler, value);
            }
            remove
            {
                _printEndedEventHandler = (EventHandler)Delegate.Remove(_printEndedEventHandler, value);
            }
        }

        /// <summary>
        /// Fired periodically while the grid is being rendered.
        /// Allows to show progress and cancel the operation.
        /// </summary>
        public event LongOperationEventHandler LongOperation
        {
            add
            {
                _longOperationEventHandler = (LongOperationEventHandler)Delegate.Combine(_longOperationEventHandler, value);
            }
            remove
            {
                _longOperationEventHandler = (LongOperationEventHandler)Delegate.Remove(_longOperationEventHandler, value);
            }
        }
        #endregion

        #region Protected
        /// <summary>
        /// Raises the <see cref="C1FlexGridPrintable2.PrintCell"/> event.
        /// </summary>
        /// <param name="e">Event arguments.</param>
        protected internal virtual void OnPrintCell(PrintCellEventArgs e)
        {
            if (_printCellEventHandler != null)
                _printCellEventHandler(this, e);
        }

        /// <summary>
        /// Raises the <see cref="C1FlexGridPrintable2.PrintStarting"/> event.
        /// </summary>
        /// <param name="e">Event arguments.</param>
        protected internal virtual void OnPrintStarting(EventArgs e)
        {
            if (_printStartingEventHandler != null)
                _printStartingEventHandler(this, e);
        }

        /// <summary>
        /// Raises the <see cref="C1FlexGridPrintable2.PrintEnded"/> event.
        /// </summary>
        /// <param name="e">Event arguments.</param>
        protected internal virtual void OnPrintEnded(EventArgs e)
        {
            if (_printEndedEventHandler != null)
                _printEndedEventHandler(this, e);
        }

        /// <summary>
        /// Raises the <see cref="C1FlexGridPrintable2.LongOperation"/> event.
        /// </summary>
        /// <param name="e">Event arguments.</param>
        protected internal virtual void OnLongOperation(LongOperationEventArgs e)
        {
            if (_longOperationEventHandler != null)
                _longOperationEventHandler(this, e);
        }
        #endregion

        #region Internal stuff
        internal RenderObject MakeOwnerDrawCellRO(int row, int col, ref CellStyle cellStyle, ref string text, ref Image image)
        {
            bool handled = false;
            // draw rectangle:
            Rectangle rc = Rectangle.Empty;
            rc.Width = Cols[col].WidthDisplay;
            rc.Height = Rows[row].HeightDisplay;

            Metafile meta;
            using (Graphics gRef = Graphics.FromHwnd(IntPtr.Zero))
            {
                IntPtr hdcRef = gRef.GetHdc();
                meta = new Metafile(hdcRef, rc, MetafileFrameUnit.Pixel, EmfType.EmfPlusDual);
                using (Graphics g = Graphics.FromImage(meta))
                {
                    // owner-drawing cell borders is not supported:
                    CellBorder cbSave = cellStyle.Border;
                    BorderStyleEnum bsSave = cbSave.Style;
                    IsPrinting = true;
                    OwnerDrawCellEventArgs e = new OwnerDrawCellEventArgs(
                        this, g, row, col, cellStyle, rc, text, image);
                    try
                    {
                        OnOwnerDrawCell(e);
                    }
                    finally
                    {
                        IsPrinting = false;
                        cbSave.Style = bsSave;
                    }
                    handled = e.Handled;
                    if (!handled)
                    {
                        cellStyle = e.Style;
                        text = e.Text;
                        image = e.Image;
                    }
                }
                gRef.ReleaseHdc(hdcRef);
            }
            if (handled)
                return new RenderImage(meta);
            // release unwanted resources asap:
            meta.Dispose();
            return null;
        }
#if qq // alternative way to owner-draw, does not work as well...
            RenderGraphics rg = new RenderGraphics();
            OwnerDrawCellEventArgs e = new OwnerDrawCellEventArgs(
                this, rg.Graphics, row, col, cellStyle, rc, text, image);
            base.OnOwnerDrawCell(e);
            return rg;
#endif
        #endregion

        #region private methods
        /// <summary>
        /// Handles the long operation event fired by the printer.
        /// </summary>
        /// <param name="sender">The printer that fired the operation.</param>
        /// <param name="e">Event args.</param>
        private void _printer_LongOperation(object sender, LongOperationEventArgs e)
        {
            OnLongOperation(e);
        }
        #endregion
    }
}
