using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using Microsoft.Win32;

using C1.Chart;
using C1.Win.Chart;
using System.Windows.Forms;

namespace C1.Chart.Printing
{
    public partial class ChartPrinter
    {
        public enum PrintScale {
            /// <summary>
            /// Specifies that the control will be drawn using the same size as the displayed control.
            /// </summary>
            None,
            /// <summary>
            /// Specifies that the control will drawn to fill the print rectangle specified.  This setting
            /// changes the aspect ratio of the control, but not the shapes or text.
            /// </summary>
            Fit,
            /// <summary>
            /// Specifies that the control will be drawn to fill the print rectangle specified by scaling
            /// the horizontal and vertical directions as necessary for the fit.  This setting does not
            /// preserve aspect ratio of graphics or text.
            /// </summary>
            Stretch,
            /// <summary>
            /// Specifies that the control will be drawn to fill the print rectangle specified by scaling
            /// the horizontal and vertical directions as necessary for the fit while maintaining the aspect
            /// ratio of the graphics and text.
            /// </summary>
            Zoom
        };

        Control _ctrl = null;
        PrintScale _scaling = PrintScale.Stretch;
        PageSettings _pageSettings = null;
        PrinterSettings _printSettings = null;

        bool _usePrintDialog = false;

        private delegate void DrawFunction(Graphics e, Rectangle r, bool resizeControl);
        private DrawFunction _drawFunc = null;

        private void init(Control ctrl, bool printDialog)
        {
            _ctrl = ctrl;
            _usePrintDialog = printDialog;
            _drawFunc = printRenderFunction;
#if BITMAPONLY
            _drawFunc = printDrawFunction;
#endif
        }

        /// <summary>
        /// Creates an instance of ChartPrinter specifying print dialog usage.
        /// </summary>
        /// <param name="ctrl">Specifies an instance of a FlexChart control to be drawn to a printer device.</param>
        /// <param name="printDialog">A boolean specifying whether a PrintSettings dialog should be displayed.</param>
        public ChartPrinter(Control ctrl, bool printDialog)
        {
            init(ctrl, printDialog);
        }

        /// <summary>
        /// Creates an instance of ChartPrinter specifying default scaling and print dialog usage.
        /// </summary>
        /// <param name="ctrl">Specifies an instance of a FlexChart control to be drawn to a printer device.</param>
        /// <param name="scaling">Specifies the scaling to be used to fit the control to the drawing area.</param>
        /// <param name="printDialog">A boolean specifying whether a PrintSettings dialog should be displayed.</param>
        public ChartPrinter(Control ctrl, PrintScale scaling, bool printDialog)
        {
            init(ctrl, printDialog);
            _usePrintDialog = printDialog;
        }

        /// <summary>
        /// Creates an instance of ChartPrinter specifying default scaling, default print settings and
        /// print dialog usage.
        /// </summary>
        /// <param name="ctrl">Specifies an instance of a FlexChart control to be drawn to a printer device.</param>
        /// <param name="scaling">Specifies the scaling to be used to fit the control to the drawing area.</param>
        /// <param name="ps">Specifies a reference to PrinterSettings to be used.</param>
        /// <param name="printDialog">A boolean specifying whether a PrintSettings dialog should be displayed.</param>
        public ChartPrinter(Control ctrl, PrintScale scaling, ref PrinterSettings ps, bool printDialog)
        {
            init(ctrl, printDialog);
            _usePrintDialog = printDialog;
            _printSettings = ps == null ? new PrinterSettings() : ps;
        }

        /// <summary>
        /// Show a PrintPreviewDialog for the specified PrintDocument.
        /// </summary>
        /// <param name="pdoc">Specifies the PrintDocument to be previewed.</param>
        /// <param name="showPrintDialog">Specifies whether to show the PrintSettings dialog.</param>
        static public void ChartPreviewDialogEx(PrintDocument pdoc, bool showPrintDialog)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pdoc;

            ToolStripButton b = null;
            if (showPrintDialog)
            {
                // Replace the existing Print button with one that issues a print dialog
                // prior to printing.  This allows a printer other than default.
                ToolStripButton bb = (ToolStripButton)((ToolStrip)(ppd.Controls[1])).Items[0];
                b = new ToolStripButton();
                b.Image = bb.Image;
                b.DisplayStyle = ToolStripItemDisplayStyle.Image;
                bb.Dispose();
                bb = null;

                ((ToolStrip)(ppd.Controls[1])).Items.RemoveAt(0);
                ((ToolStrip)(ppd.Controls[1])).Items.Insert(0, b);

                b.Click += (o, e) =>
                {
                    using (PrintDialog pdlg = new PrintDialog())
                    {
                        pdlg.Document = ppd.Document;
                        if (pdlg.ShowDialog(ppd) == DialogResult.OK)
                        {
                            pdlg.Document.PrinterSettings = pdlg.PrinterSettings;
                            pdlg.Document.Print();
                        }
                    }
                };
            }
            Size screenSize = Screen.FromControl(ppd).WorkingArea.Size;
            ppd.ClientSize = new Size(screenSize.Width * 3 / 4, screenSize.Height * 3 / 4);
            ppd.ShowDialog();
            ppd.Dispose();

            if (b != null) b.Dispose();
        }

        private PrinterSettings printSettings
        {
            get
            {
                if (_printSettings == null)
                    _printSettings = new PrinterSettings();
                return _printSettings;
            }
        }

        private PageSettings pageSettings
        {
            get
            {
                if (_pageSettings == null)
                    _pageSettings = new PageSettings();
                return _pageSettings;
            }
        }

        private void printRenderFunction(Graphics g, Rectangle r, bool resizeControl)
        {
            // Save the original control size and resize to suit the printer
            Size originalSize = _ctrl.Size;
            if (resizeControl) _ctrl.Size = r.Size;

            _ctrl.Invalidate();
            ((FlexChartBase)_ctrl).DrawChart(g, r.Size);

            // if necessary restore the original control size and mark as invalidate needed.
            if (resizeControl) _ctrl.Size = originalSize;
        }
#if BITMAPONLY
        public void printDrawFunction(Graphics g, Rectangle r, bool resizeControl)
        {
            // Save the original control size and resize to suit the printer
            Size originalSize = _ctrl.Size;
            if(resizeControl) _ctrl.Size = r.Size;

            FlexChart fc = _ctrl as FlexChart;
            RenderMode originalRenderMode = (fc != null) ? fc.RenderMode : RenderMode.Default;

            if (fc != null && fc.RenderMode != RenderMode.Default)
                fc.RenderMode = RenderMode.Default;

            Bitmap bmp = new Bitmap(r.Width, r.Height);
            _ctrl.DrawToBitmap(bmp, r);

            if (fc != null && fc.RenderMode != originalRenderMode)
                fc.RenderMode = originalRenderMode;

            if (_ia_grayscale == null)
                g.DrawImage(bmp, r.Location);
            else
                g.DrawImage(bmp, r, 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, _ia_grayscale);

            // if necessary restore the original control size and mark as invalidate needed.
            if(resizeControl) _ctrl.Size = originalSize;
        }
#endif
        private ImageAttributes _ia_grayscale = null;
        private void SetupGrayscaleAttributes()
        {
            if (_ia_grayscale == null)
            {
                _ia_grayscale = new ImageAttributes();

                float[][] grayMatrix = new float[][]
				{
					new float[]{0.3f,0.3f,0.3f,0,0},
					new float[]{0.59f,0.59f,0.59f,0,0},
					new float[]{0.11f,0.11f,0.11f,0,0},
					new float[]{0,0,0,1,0,0},
					new float[]{0,0,0,0,1,0},
					new float[]{0,0,0,0,0,1}
				};
                ColorMatrix cm = new ColorMatrix(grayMatrix);

                _ia_grayscale.SetColorMatrix(cm);
            }
        }

		private class ctrlPrinter
		{
			private Control _ctrl = null;
            private PrintScale _printScale = PrintScale.None;
			private RectangleF _printRect = RectangleF.Empty;
			private SizeF _ctrlSize = SizeF.Empty;
			private ChartPrinter _printHandler = null;
			private bool _bitmap = false;
            private bool _resizeControl = false;

			public ctrlPrinter(ChartPrinter printHandler, Control ctrl)
			{
				_printHandler = printHandler;
				_ctrl = ctrl;

				Graphics g = ctrl.CreateGraphics();
				_ctrlSize = new SizeF(_ctrl.Size.Width, _ctrl.Size.Height);

				// the control size needs to be adjusted to normalize the DPI of the console.
				// for the printer units.
				_ctrlSize.Width *= 100f / g.DpiX;	// _drawFactor.Width;
				_ctrlSize.Height *= 100f / g.DpiY;	// _drawFactor.Height;
				g.Dispose();
			}

            public RectangleF printRect
            {
                get { return _printRect; }
                set { _printRect = value; }
            }

            public PrintScale printScale
            {
                get { return _printScale; }
                set { _printScale = value; }
            }

			public virtual void OnPrintCtrl(object sender, PrintPageEventArgs e)
			{
				if(_ctrl == null || _printHandler._drawFunc == null) return;

				RectangleF rf = _printRect;

                // if the print rectangle is empty, adjust it to margin limit
                if(rf.Width == 0) rf.Width = e.MarginBounds.Width;
                if(rf.Height == 0) rf.Height = e.MarginBounds.Height;

				float wRatio = 1f, hRatio = 1f;

				Matrix m = new Matrix();
                rf.Offset(e.MarginBounds.Location);
                m.Translate(rf.X, rf.Y);	// always translate, as ctrl is zero upper left

				switch(_printScale)
				{
					case PrintScale.None:
						// None means print/draw ctrl in specified space
						rf.Size = _ctrlSize;
						break;

                    case PrintScale.Fit:
                        // Fit means draw the chart assuming it should fill the specified space.
                        // No sizing transforms are used.  Does not preserve aspect ratio.
                        _resizeControl = true;
                        break;

					case PrintScale.Stretch:
						// Stretch means draw the ctrl so it contains
						// the same view, but shrink or stretch so it fills
						// the specified region.  This does not maintain aspect ratio.
						wRatio = rf.Width / _ctrlSize.Width;
						hRatio = rf.Height / _ctrlSize.Height;
						break;

					default:    // aka Zoom
						// Zoom means draw the ctrl, preserving the
						// aspect ratio, but scale it so that printed image fits
						// entirely in the specified region.  Either the Width
						// or the Height will be filled.
						wRatio = rf.Width / _ctrlSize.Width;
						hRatio = rf.Height / _ctrlSize.Height;
						if(wRatio < hRatio)
							hRatio = wRatio;
						else
							wRatio = hRatio;
						break;
				}

				if(wRatio != 1f || hRatio != 1f)
					m.Scale(wRatio, hRatio);

                Rectangle r = new Rectangle(Point.Empty, Size.Round(_resizeControl ? rf.Size : _ctrlSize));

				Graphics g = e.Graphics;
				GraphicsState gsave = g.Save();
				g.MultiplyTransform(m, MatrixOrder.Append);

				Graphics gbits = null;
				Bitmap bitMapBuffer = null;
				if(_bitmap)
				{
					gbits = g;
					bitMapBuffer = new Bitmap(r.Width, r.Height);
					g = Graphics.FromImage(bitMapBuffer);
				}

                bool inPreview = sender is PrintDocument && ((PrintDocument)sender).PrintController.IsPreview;
				if (_printHandler._ia_grayscale != null && (e.PageSettings.Color || inPreview))
				{
					Graphics gc = _ctrl.CreateGraphics();
					IntPtr hdc = gc.GetHdc();
					Metafile mf = new Metafile(hdc, r, MetafileFrameUnit.Pixel, EmfType.EmfPlusDual);
					if (mf != null)
					{
						Graphics gmf = Graphics.FromImage(mf);
						if (gmf != null)
						{
							_printHandler._drawFunc(gmf, r, _resizeControl);
							gmf.Dispose();
						}
						g.DrawImage(mf, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel,
							_printHandler._ia_grayscale);

						mf.Dispose();
						mf = null;
					}
					if(gc != null) gc.Dispose();
				}
				else
				{
					_printHandler._drawFunc(g, r, _resizeControl);
				}
                
                if (_bitmap)
				{
					g.Flush();
					g.Dispose();

					g = gbits;
					g.DrawImage(bitMapBuffer, r);
					bitMapBuffer.Dispose();
					bitMapBuffer = null;
                }
                m.Dispose();
				g.Restore(gsave);

				e.HasMorePages = false;

				// Since values may have been recalculated in the ctrl
				// during the draw, but based on the printer graphics
				// object, repaint the ctrl on the screen so the internal
				// variables are recalculated for the screen.
				// this will need to be address more completely.
				_ctrl.Invalidate();
			}

			public void PrintCtrl(PrintScale scaling, Rectangle r)
			{
				PrintCtrl( scaling, r, null);
			}

			public void PrintCtrl(PrintScale scaling, Rectangle r, PageSettings ps)
			{
				PrintCtrl(scaling, r, ps, false);
			}

            public void PrintCtrl(PrintScale scaling, Rectangle r, PageSettings ps, bool bitmap)
            {
                PrintCtrl(scaling, r, ps, bitmap, false);
            }

			public void PrintCtrl(PrintScale scaling, Rectangle r, PageSettings ps, bool bitmap, bool preview)
			{
				_printScale = scaling;
				_bitmap = bitmap;
				_printRect = new RectangleF(r.X, r.Y, r.Width, r.Height);

				try
				{
					PrintDocument pd = new PrintDocument();
					pd.PrintPage += new PrintPageEventHandler(this.OnPrintCtrl);

					if( ps!=null)
					{
						pd.DefaultPageSettings = ps;
                        pd.PrinterSettings = (_printHandler._printSettings == null)
                            ? ps.PrinterSettings : _printHandler.printSettings;
					}
					else
					{
						pd.DefaultPageSettings = _printHandler.pageSettings;
                        pd.PrinterSettings = (_printHandler._printSettings == null)
                            ? ps.PrinterSettings : _printHandler.printSettings;
                    }

					DialogResult dr = DialogResult.OK;

                    if (preview)
                    {
                        ChartPrinter.ChartPreviewDialogEx(pd, _printHandler._usePrintDialog);
                        _printHandler._printSettings = pd.PrinterSettings;
                    }
                    else
                    {
                        if (_printHandler._usePrintDialog)
                        {
                            PrintDialog px = new PrintDialog();
                            px.Document = pd;
                            dr = px.ShowDialog();
                            px.Dispose();
                        }

                        if (dr == DialogResult.OK)
                            pd.Print();
                    }
					pd.Dispose();
				}
				catch(Exception) {}
			}
		}

        /// <summary>
        /// Prints the control to the Graphics object defined by the PrintPageEventArgs parameter to
        /// the specified rectangle on the page using the specied scaling and grayscale specified.
        /// </summary>
        /// <param name="printDoc">Specifies the PrintDocument to which the control is drawn.</param>
        /// <param name="ppea">PrintPageEventArgs as generated through a call to PrintDocument.Print()</param>
        /// <param name="scaling">Specifies the scaling use to fit the control draw to the specified rectangle.</param>
        /// <param name="printRect">Specifes the rectangle to draw and fit the control relative to the top, left
        ///    of the MarginBounds as specified in PrintPageEventArgs.  Rectangle.Empty indicates that rectangle
        ///    specified the by the MarginBounds is assumed.  If either of the Width or Height of the rectangle is zero,
        ///    then the entire page betwteen the appropriate margins is assumed.
        /// </param>
        /// <param name="useGrayScale">If true, the control is drawn to size as a bitmap using grayscale.</param>
        public virtual void PrinterCtrlToPage(PrintDocument printDoc, PrintPageEventArgs ppea, PrintScale scaling, Rectangle printRect,
            bool useGrayScale)
        {
            // Preserve the PrintPageEventArgs
            GraphicsState gsave = ppea.Graphics.Save();
            bool hasMorePages = ppea.HasMorePages;

            UseGrayScale = useGrayScale;

            ctrlPrinter cp = new ctrlPrinter(this, this._ctrl);
            cp.printScale = scaling;
            cp.printRect = printRect;
            cp.OnPrintCtrl(printDoc, ppea);

            // Restore the PrintPageEventArgs
            ppea.HasMorePages = hasMorePages;
            ppea.Graphics.Restore(gsave);
        }

        /// <summary>
        /// Prints the control to the specified rectangle on the page using the specied scaling and grayscale.
        /// </summary>
        /// <param name="scaling">Specifies the scaling use to fit the control draw to the specified rectangle.</param>
        /// <param name="r">Specifes the rectangle to draw and fit the control relative to the top, left
        ///    of the page margins.  Rectangle.Empty indicates that rectangle specified the by the page margins is
        ///    assumed.  If either of the Width or Height of the rectangle is zero, then the entire length betwteen
        ///    the appropriate margins is assumed.
        /// </param>
        /// <param name="ps">Specifies predefined a PageSettings object.</param>
        /// <param name="bitmap">If true, specifies that the control is drawn as a bitmap.</param>
        /// <param name="preview">If true, a PrintPreview dialog is shown instead of drawing to a printer.</param>
        public virtual void PrintCtrl(PrintScale scaling, Rectangle r, PageSettings ps, bool bitmap, bool preview)
        {
            ctrlPrinter cp = new ctrlPrinter(this, this._ctrl);
            cp.PrintCtrl(scaling, r, ps, bitmap, preview);
        }

        /// <summary>
        /// Prints the control to the specified rectangle on the page using the specied scaling and grayscale.
        /// </summary>
        /// <param name="scaling">Specifies the scaling use to fit the control draw to the specified rectangle.</param>
        /// <param name="r">Specifes the rectangle to draw and fit the control relative to the top, left
        ///    of the page margins.  Rectangle.Empty indicates that rectangle specified the by the page margins is
        ///    assumed.  If either of the Width or Height of the rectangle is zero, then the entire length betwteen
        ///    the appropriate margins is assumed.
        /// </param>
        /// <param name="ps">Specifies predefined a PageSettings object.</param>
        /// <param name="bitmap">If true, specifies that the control is drawn as a bitmap.</param>
        public virtual void PrintCtrl(PrintScale scaling, Rectangle r, PageSettings ps, bool bitmap)
		{
			ctrlPrinter cp = new ctrlPrinter(this, this._ctrl);
			cp.PrintCtrl(scaling, r, ps, bitmap);
		}

        /// <summary>
        /// Prints the control to the specified rectangle on the page using the specied scaling and grayscale.
        /// </summary>
        /// <param name="scaling">Specifies the scaling use to fit the control draw to the specified rectangle.</param>
        /// <param name="r">Specifes the rectangle to draw and fit the control relative to the top, left
        ///    of the page margins.  Rectangle.Empty indicates that rectangle specified the by the page margins is
        ///    assumed.  If either of the Width or Height of the rectangle is zero, then the entire length betwteen
        ///    the appropriate margins is assumed.
        /// </param>
        /// <param name="ps">Specifies predefined a PageSettings object.</param>
        public virtual void PrintCtrl(PrintScale scaling, Rectangle r, PageSettings ps)
		{
			ctrlPrinter cp = new ctrlPrinter(this, this._ctrl);
			cp.PrintCtrl(scaling, r, ps);
		}

        /// <summary>
        /// Prints the control to the specified rectangle on the page using the specied scaling.
        /// </summary>
        /// <param name="scaling">Specifies the scaling use to fit the control draw to the specified rectangle.</param>
        /// <param name="r">Specifes the rectangle to draw and fit the control relative to the top, left
        ///    of the page margins.  Rectangle.Empty indicates that rectangle specified the by the page margins is
        ///    assumed.  If either of the Width or Height of the rectangle is zero, then the entire length betwteen
        ///    the appropriate margins is assumed.
        /// </param>
        public virtual void PrintCtrl(PrintScale scaling, Rectangle r)
		{
			ctrlPrinter cp = new ctrlPrinter(this, this._ctrl);
			cp.PrintCtrl(scaling, r);
		}

        /// <summary>
        /// Prints the control to the page using the specied scaling.  The entire page is used as the print rectangle
        /// for the control scaling.
        /// </summary>
        /// <param name="scaling">Specifies the scaling use to fit the control draw to the specified rectangle.</param>
        public virtual void PrintCtrl(PrintScale scaling)
		{
			PrintCtrl(scaling, Rectangle.Empty);
		}

        /// <summary>
        /// Prints the control using Zoom scaling within the margins of the printer page.
        /// </summary>
        public virtual void PrintCtrl()
		{
			PrintCtrl(PrintScale.Zoom, Rectangle.Empty);
		}

        /// <summary>
        /// Gets or sets whether a print dialog is used when printing.
        /// </summary>
        public virtual bool PrintDialogUsage
		{
			get {return _usePrintDialog; }
			set {_usePrintDialog = value; }
		}

        /// <summary>
        /// Raises the PageSetup dialog to manage the page settings.
        /// </summary>
        public virtual void PageSetup()
		{
			PageSetupDialog psd = new PageSetupDialog();

			bool isMetric = false;
			try
			{
				RegistryKey key = Registry.CurrentUser;
				key = key.OpenSubKey("Control Panel\\International");
				string s = (string)key.GetValue( "iMeasure");
				if( s.Equals("0"))
					isMetric = true;
			}
			catch
			{
				isMetric = System.Globalization.RegionInfo.CurrentRegion.IsMetric;
			}
			if( isMetric)
			{
				pageSettings.Margins.Left = (int)(Math.Round( pageSettings.Margins.Left * 2.54));
				pageSettings.Margins.Right = (int)(Math.Round( pageSettings.Margins.Right * 2.54));
				pageSettings.Margins.Bottom = (int)(Math.Round( pageSettings.Margins.Bottom * 2.54));
				pageSettings.Margins.Top = (int)(Math.Round( pageSettings.Margins.Top * 2.54));
			}
			//

			psd.PageSettings = pageSettings;
			psd.ShowDialog();

			psd.Dispose();
		}

        /// <summary>
        /// Raises the PrintSetup dialog to manage the printer settings
        /// </summary>
        public virtual void PrintSetup()
		{
			PrintDialog pd = new PrintDialog();
			pd.PrinterSettings = printSettings;
			pd.ShowDialog();
			pd.Dispose();
		}

        /// <summary>
        /// Resets the default PageSettings.
        /// </summary>
        public void PageSettingsReset()
		{
			_pageSettings = null;
		}

        /// <summary>
        /// Resets the default PrintSettings.
        /// </summary>
        public void PrintSettingsReset()
		{
			_printSettings = null;
		}

        /// <summary>
        /// Gets or sets the default PageSettings.
        /// </summary>
        public PageSettings PageSettingsProp
		{
			get { return _pageSettings; }
			set { _pageSettings = value; }
		}

        /// <summary>
        /// Gets or sets the default PrintSettings.
        /// </summary>
        public PrinterSettings PrintSettingsProp
		{
			get { return _printSettings; }
			set { _printSettings = value; }
		}

        /// <summary>
        /// Gets or sets whether the printed chart is rendered using grayscale.
        /// </summary>
        public bool UseGrayScale
        {
            get { return _ia_grayscale != null; }
            set
            {
                if (value)
                    SetupGrayscaleAttributes();
                else
                    _ia_grayscale = null;
            }
        }
	}
}
