using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using C1.C1Preview;
using C1.Win.C1Preview;

namespace C1.Win.C1FlexGrid
{
    /// <summary>
    /// Represents a class that may be used to insert a C1FlexGrid into a C1PrintDocument.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This class may be used to insert a <see cref="C1FlexGrid"/> into a <see cref="C1PrintDocument"/>
    /// for printing, exporting or previewing. Several grids may be combined into a single document,
    /// or grids may be combined with other elements to produce complex reports.
    /// </para>
    /// <para>
    /// To use this class, follow these steps:
    /// <list type="number">
    ///     <item>Create a new <see cref="C1PrintDocument"/> object;</item>
    ///     <item>Create an instance of C1FlexGridPrinter object, passing the C1FlexGrid that you want to print as the constructor parameter;</item>
    ///     <item>Adjust the <see cref="C1FlexGridPrinter.PrintInfo"/> properties as needed;</item>
    ///     <item>Call <see cref="C1FlexGridPrinter.MakeGridTable(C1PrintDocument)"/> method to create the <see cref="RenderTable"/> representing the grid;</item>
    ///     <item>Insert that render table into the document.</item>
    /// </list>
    /// </para>
    /// </remarks>
    /// <example>
    /// The following code fragment shows the use of <see cref="C1FlexGridPrinter"/>
    /// to export two flex grids into a single PDF file:
    /// <code>
    /// C1PrintDocument doc = new C1PrintDocument();
    /// doc.Body.Children.Add(new RenderText("Grid 1"));
    /// C1FlexGridPrinter fp1 = new C1FlexGridPrinter(flxGrid1);
    /// doc.Body.Children.Add(fp1.MakeGridTable(doc));
    /// doc.Body.Children.Add(new RenderText("Grid 2"));
    /// C1FlexGridPrinter fp2 = new C1FlexGridPrinter(flxGrid2);
    /// doc.Body.Children.Add(fp2.MakeGridTable(doc));
    /// doc.Export("myGrids.pdf");
    /// </code>
    /// </example>
    public partial class C1FlexGridPrinter
    {
        #region Private data
        // this must always be non-null:
        private C1FlexGrid _grid = null;
        // this is non-null if _grid is a C1FlexGridPrintable2:
        private C1FlexGridPrintable2 _grid2 = null;
        // print info allows to fine-tune grid rendering:
        private C1FlexGridPrintInfo _printInfo = new C1FlexGridPrintInfo();
        // keys are produced by BuildCellStyleKey():
        private Dictionary<string, Style> _styles = null;
        // styles set on cells' RenderObject (handle flex grid cells' Margins):
        private Dictionary<string, Style> _cellRoStyles = null;
        // the tree glyphs style:
        private Style _styleTreeGlyph = null;
        // names of glyph images in the document dictionary:
        private Dictionary<GlyphEnum, string> _glyphImageNames = null;
        #endregion

        #region nested types
        /// <summary>
        /// Identifies the four edges of a rectangle.
        /// </summary>
        [Flags]
        private enum EdgeEnum
        {
            None = 0,
            Left = 1,
            Top = 2,
            Right = 4,
            Bottom = 8,
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Resets data cached during creation of the grid's representation as a render object.
        /// </summary>
        private void Reset()
        {
            _styles = new Dictionary<string, Style>();
            _cellRoStyles = new Dictionary<string, Style>();
            _styleTreeGlyph = null;
            _glyphImageNames = null;
        }

        /// <summary>
        /// Fires the <see cref="LongOperation"/> event.
        /// </summary>
        /// <param name="e">The event arguments.</param>
        private void OnLongOperation(LongOperationEventArgs e)
        {
            if (LongOperation != null)
                LongOperation(this, e);
        }

        /// <summary>
        /// Makes a render text object representing page header or footer,
        /// based on grid's PrintParameters.
        /// </summary>
        /// <param name="footer">True to create footer, false to create header.</param>
        /// <param name="tagOpenParen">Document's tag opening parentheses.</param>
        /// <param name="tagCloseParen">Document's tag closing parentheses.</param>
        /// <returns>The RenderText representing the header or footer.</returns>
        private RenderObject MakePageHeader(bool footer, string tagOpenParen, string tagCloseParen)
        {
            string str = (footer ? _grid.PrintParameters.Footer : _grid.PrintParameters.Header);
            if (string.IsNullOrEmpty(str))
                return null;
            string exp = string.Format(CultureInfo.InvariantCulture, "{0}string.Format(\"{1}\",PageNo,PageCount){2}", tagOpenParen, str, tagCloseParen);
            RenderText ro = new RenderText(exp);
            // in flex grid, \t are used to align page headers/footers, so we do the same:
            ro.TabPositions.Add("50%", TabAlignmentEnum.Center);
            ro.TabPositions.Add("100%", TabAlignmentEnum.Right);
            // use font if specified:
            System.Drawing.Font font = footer ? _grid.PrintParameters.FooterFont : _grid.PrintParameters.HeaderFont;
            if (font != null)
                ro.Style.Font = font;
            // add some spacing:
            if (footer)
                ro.Style.Spacing.Top = "5mm";
            else
                ro.Style.Spacing.Bottom = "5mm";
            return ro;
        }

        /// <summary>
        /// Initializes glyph images.
        /// If a non-null doc is specified, images are stored in the document's dicitionary
        /// which improves performance.
        /// </summary>
        /// <param name="doc">The document that will contain the rendered grid. May be null.</param>
        private void InitGlyphImages(C1PrintDocument doc)
        {
            Array glyphs = Enum.GetValues(typeof(GlyphEnum));
            if (doc != null)
            {
                _glyphImageNames = new Dictionary<GlyphEnum, string>(glyphs.Length);
                foreach (GlyphEnum ge in glyphs)
                {
                    string imageName = Utility.MakeUniqueDictName(doc, ge.ToString() + "{0}");
                    doc.Dictionary.Add(new DictionaryImage(imageName, _grid.Glyphs[ge]));
                    _glyphImageNames[ge] = imageName;
                }
            }
        }

        /// <summary>
        /// Creates a render image for the specified glyph.
        /// </summary>
        /// <param name="glyph">The flex grid glyph.</param>
        /// <returns>The RenderImage representing the glyph.</returns>
        private RenderImage MakeGlyphRO(GlyphEnum glyph)
        {
            if (_glyphImageNames != null)
                return new RenderImage(_glyphImageNames[glyph]);
            else
                return new RenderImage(_grid.Glyphs[glyph]);
        }

        /// <summary>
        /// Initializes common static styles.
        /// </summary>
        /// <param name="parent">The render object that will contain the styles.</param>
        private void InitCommonStyles(RenderObject parent)
        {
            // expanded/collapsed glyph style:
            _styleTreeGlyph = parent.Style.Children.Add();
            _styleTreeGlyph.Parent = null;
            _styleTreeGlyph.Padding.All = "1mm";
        }

        /// <summary>
        /// Calculates which outer table edges the specified cell range borders on.
        /// </summary>
        /// <param name="cr">The cell range to test.</param>
        /// <param name="gridRowFirst">The index of the first printed grid row.</param>
        /// <param name="gridColFirst">The index of the first printed grid column.</param>
        /// <param name="gridRowLast">The index of the last printed grid row.</param>
        /// <param name="gridColLast">The index of the last printed grid column.</param>
        /// <returns>A combination of EdgeEnum flags indicating which edges the range borders on.</returns>
        private EdgeEnum CalcEdges(CellRange cr, int gridRowFirst, int gridColFirst, int gridRowLast, int gridColLast)
        {
            EdgeEnum ret = EdgeEnum.None;
            // avoid extra work if we're not printing borders anyway:
            if (!PrintInfo.PrintBorders)
                return ret;
            if (cr.r1 == gridRowFirst)
                ret |= EdgeEnum.Top;
            if (cr.r2 == gridRowLast)
                ret |= EdgeEnum.Bottom;
            if (cr.c1 == gridColFirst)
                ret |= EdgeEnum.Left;
            if (cr.c2 == gridColLast)
                ret |= EdgeEnum.Right;
            return ret;
        }

        /// <summary>
        /// Creates a RenderTable representing the flex grid.
        /// </summary>
        /// <param name="doc">The target document. May be null.</param>
        /// <returns>The created RenderTable.</returns>
        private RenderTable MakeGridTableInternal(C1PrintDocument doc)
        {
            // Fire PrintStarting event:
            if (_grid2 != null)
                _grid2.OnPrintStarting(EventArgs.Empty);

            RenderTable rt = new RenderTable();
            InitCommonStyles(rt);

            // PrintInfo:
            if (PrintInfo.RepeatFixedRows && PrintInfo.PrintFixedRows && _grid.Rows.Fixed > 0)
                rt.RowGroups[0, _grid.Rows.Fixed].Header = TableHeaderEnum.All;
            if (PrintInfo.RepeatFixedCols && PrintInfo.PrintFixedCols && _grid.Cols.Fixed > 0)
                rt.ColGroups[0, _grid.Cols.Fixed].Header = TableHeaderEnum.All;

            int gridRowFirst, gridColFirst, gridRowLast, gridColLast;

            // find indices of first/last printed row and column:
            for (gridRowFirst = PrintInfo.PrintFixedRows ? 0 : _grid.Rows.Fixed;
                gridRowFirst < _grid.Rows.Count && !PrintGridRow(gridRowFirst);
                ++gridRowFirst)
                ;
            for (gridColFirst = PrintInfo.PrintFixedCols ? 0 : _grid.Cols.Fixed;
                gridColFirst < _grid.Cols.Count && !PrintGridCol(gridColFirst);
                ++gridColFirst)
                ;
            for (gridRowLast = _grid.Rows.Count - 1;
                gridRowLast >= 0 && !PrintGridRow(gridRowLast);
                --gridRowLast)
                ;
            for (gridColLast = _grid.Cols.Count - 1;
                gridColLast >= 0 && !PrintGridCol(gridColLast);
                --gridColLast)
                ;

            // adjust global table properties:
            AdjustTable(rt, gridColFirst, gridColLast);

            // this is used to keep bottom borders of cells above the current row
            // (indexed by RenderTable column index) for setting up cells' top borders
            // (flex grid's styles specify right and bottom border of a cell):
            List<LineDef> bordersTop = new List<LineDef>(gridColLast + 1);
            for (int i = 0; i <= gridColLast; ++i)
                bordersTop.Add(null);

            // the big loop over grid rows and columns:
            int tblRow = 0; // RenderTable row
            for (int gridRow = gridRowFirst; gridRow <= gridRowLast; ++gridRow)
            {
                if (!PrintGridRow(gridRow))
                    continue;

                // fire long operation event:
                LongOperationEventArgs e = new LongOperationEventArgs((double)gridRow / (double)gridRowLast, true);
                OnLongOperation(e);
                if (e.Cancel)
                    break;

                if (!PrintInfo.AutoRowHeights ||
                    (!PrintInfo.AutosizeFixedRows && gridRow < _grid.Rows.Fixed))
                    rt.Rows[tblRow].Height = PixelsToUnit(_grid.Rows[gridRow].HeightDisplay);

                int tblCol = 0; // RenderTable col
                for (int gridCol = gridColFirst; gridCol <= gridColLast; ++gridCol)
                {
                    if (!PrintGridCol(gridCol))
                        continue;

                    CellRange cr = _grid.GetMergedRange(gridRow, gridCol);
                    cr.Normalize(); // todo: clarify whether this call is needed after GetMergedRange
                    if (cr.r1 == gridRow && cr.c1 == gridCol)
                    {
                        TableCell tc = rt.Cells[tblRow, tblCol];
                        tc.SpanCols = cr.c2 - cr.c1 + 1;
                        tc.SpanRows = cr.r2 - cr.r1 + 1;

                        CellStyle cellStyle = _grid.GetCellStyleDisplay(gridRow, gridCol);
                        string cellText;
                        // note: style may be changed by owner-draw cell event invoked from MakeCellRO:
                        RenderObject cellContent = MakeCellRO(gridRow, gridCol, ref cellStyle, out cellText);
                        Style style = StyleFromGridStyle(cellStyle, rt.Style.Children, cellStyle.DataType, cellText,
                            CalcEdges(cr, gridRowFirst, gridColFirst, gridRowLast, gridColLast),
                            GetLeftBorder(gridRow, gridCol), bordersTop[tblCol]);
                        tc.Style.Parents = style;

                        if (PrintInfo.PrintBorders)
                        {
                            // update top borders for next row (left border for next cell is calculated):
                            for (int i = 0; i < tc.SpanCols && tblCol + i < bordersTop.Count; ++i)
                                bordersTop[tblCol + i] = style.Borders.Bottom;
                        }

                        // For tree cells, cellContent is inserted into a RenderArea that additionally
                        // contains tree glyphs (plus/minus etc) and offsets; otherwise, just use cellContent:
                        if (gridCol == _grid.Tree.Column && _grid.Rows[gridRow].Node != null)
                            tc.RenderObject = MakeTreeRO(cellContent, gridRow);
                        else // not a tree cell:
                            tc.RenderObject = cellContent;

                        // print current row indicator (DBCursor):
                        if (gridRow == _grid.Row && PrintInfo.PrintDBCursor && gridCol == 0 && gridCol < _grid.Cols.Fixed)
                            PrintDBCursor(tc);

                        // account for CellStyle.Margins (added as Spacing between cell's RO and cell):
                        if (tc.RenderObject != null)
                            tc.RenderObject.Style.Parent = CellRoStyleFromGridStyle(cellStyle, rt.Style.Children);

                        // fire C1FlexGridPrintable2.PrintCell event:
                        if (_grid2 != null)
                            _grid2.OnPrintCell(new C1FlexGridPrintable2.PrintCellEventArgs(tc, doc, gridRow, gridCol));
                    }
                    ++tblCol;
                }
                ++tblRow;
            }

            // show sort glyphs:
            // if (PrintInfo.PrintFixedRows && _grid.ShowSort && _grid.SortColumn != null && _grid.Rows.Fixed > 0 && PrintGridRow(0))
            if (PrintInfo.PrintFixedRows && (_grid.ShowSortPosition != ShowSortPositionEnum.None) && _grid.SortColumn != null && _grid.Rows.Fixed > 0 && PrintGridRow(0))
                PrintSortGlyph(rt, gridColFirst, gridColLast);

            // Fire PrintEnded event:
            if (_grid2 != null)
                _grid2.OnPrintEnded(EventArgs.Empty);

            return rt;
        }

        /// <summary>
        /// Adjusts the global properties of the RenderTable representing the grid
        /// (such as column and row sizing modes etc.) according to PrintInfo.
        /// </summary>
        /// <param name="rt">The RenderTable to adjust.</param>
        /// <param name="gridColFirst">Index of the first grid column that will be printed.</param>
        /// <param name="gridColLast">Index of the last grid column that will be printed.</param>
        private void AdjustTable(RenderTable rt, int gridColFirst, int gridColLast)
        {
            // adjust global table properties:
            rt.BordersSplitHorzMode = BordersSplitMode.Square;
            rt.BordersSplitVertMode = BordersSplitMode.Square;
            if (PrintInfo.AllowHorzSplit)
            {
                rt.SplitHorzBehavior = SplitBehaviorEnum.SplitIfLarge;
                rt.Width = Unit.Auto;
                if (PrintInfo.AutoColWidths)
                {
                    rt.ColumnSizingMode = TableSizingModeEnum.Auto;
                    if (!PrintInfo.AutosizeFixedCols)
                    {
                        int tblCol = 0;
                        for (int gridCol = 0; gridCol < _grid.Cols.Fixed; ++gridCol)
                        {
                            if (!PrintGridCol(gridCol))
                                continue;
                            int width = Math.Min(_grid.Cols[gridCol].WidthDisplay, PrintInfo.MaxColWidth);
                            rt.Cols[tblCol].SizingMode = TableSizingModeEnum.Fixed;
                            rt.Cols[tblCol++].Width = PixelsToUnit(width);
                        }
                    }
                }
                else
                {
                    rt.ColumnSizingMode = TableSizingModeEnum.Fixed;
                    int tblCol = 0;
                    // we must still limit column width:
                    for (int gridCol = gridColFirst; gridCol <= gridColLast; ++gridCol)
                    {
                        if (!PrintGridCol(gridCol))
                            continue;
                        int width = Math.Min(_grid.Cols[gridCol].WidthDisplay, PrintInfo.MaxColWidth);
                        rt.Cols[tblCol++].Width = PixelsToUnit(width);
                    }
                }
            }
            else
            {
                rt.SplitHorzBehavior = SplitBehaviorEnum.Never;
            }
            if (_grid.ExtendLastCol)
                rt.StretchColumns = StretchTableEnum.LastVectorOnPage;
        }

        /// <summary>
        /// Adds the DBCursor glyph to the passed table cell.
        /// </summary>
        /// <param name="tc">The table cell to add the glyph to.</param>
        private void PrintDBCursor(TableCell tc)
        {
            Debug.Assert(PrintInfo.PrintDBCursor && _grid.Cols.Fixed > 0);
            RenderObject ro = tc.RenderObject;
            tc.RenderObject = null;
            RenderArea ra = new RenderArea();
            ra.Stacking = StackingRulesEnum.BlockLeftToRight;
            ra.Style.FlowAlignChildren = FlowAlignEnum.Center;
            ra.Children.Add(MakeGlyphRO(GlyphEnum.DBCursor));
            if (ro != null)
                ra.Children.Add(ro);
            tc.RenderObject = ra;
        }

        /// <summary>
        /// Adds an appropriate sort glyph to the sort column.
        /// </summary>
        /// <param name="rt">The render table representing the grid.</param>
        /// <param name="gridColFirst">Index of the first printed grid column.</param>
        /// <param name="gridColLast">Index of the last printed grid column.</param>
        private void PrintSortGlyph(RenderTable rt, int gridColFirst, int gridColLast)
        {
            Debug.Assert(PrintInfo.PrintFixedRows && (_grid.ShowSortPosition != ShowSortPositionEnum.None) && _grid.SortColumn != null && _grid.Rows.Fixed > 0 && PrintGridRow(0));
            int tblCol = 0;
            // the loop is to exactly mimic the logic used to build the table:
            for (int gridCol = gridColFirst; gridCol <= gridColLast; ++gridCol)
            {
                if (!PrintGridCol(gridCol))
                    continue;
                if (_grid.SortColumn.Index == tblCol)
                {
                    RenderImage sortGlyph;
                    if ((_grid.SortColumn.Sort & SortFlags.Ascending) != 0)
                        sortGlyph = MakeGlyphRO(GlyphEnum.Ascending);
                    else if ((_grid.SortColumn.Sort & SortFlags.Descending) != 0)
                        sortGlyph = MakeGlyphRO(GlyphEnum.Descending);
                    else
                        sortGlyph = null;
                    if (sortGlyph != null)
                    {
                        if (rt.Cells[0, tblCol].RenderObject == null)
                            rt.Cells[0, tblCol].RenderObject = new RenderArea();
                        sortGlyph.X = "50%parent.width - 50%width";
                        rt.Cells[0, tblCol].RenderObject.Children.Add(sortGlyph);
                    }
                    break;
                }
                ++tblCol;
            }
        }

        /// <summary>
        /// Gets the left border for the specified grid cell (which is the right border
        /// of the cell on the left).
        /// </summary>
        /// <param name="row">C1FlexGrid row index.</param>
        /// <param name="col">C1FlexGrid column index.</param>
        /// <returns>LineDef representing the cell's left border.</returns>
        private LineDef GetLeftBorder(int row, int col)
        {
            if (!PrintInfo.PrintBorders)
                return null;
            while (col > 0 && !PrintGridCol(--col))
                ;
            if (col <= 0)
                return null;
            CellRange cr = _grid.GetMergedRange(row, col);
            cr.Normalize();
            CellStyle cs = _grid.GetCellStyleDisplay(cr.r1, cr.c1);
            return BorderToLineDef(cs, false);
        }

        /// <summary>
        /// Tests whether the specified grid column should be printed.
        /// </summary>
        /// <param name="col">The grid column index.</param>
        /// <returns>True if the column should be printed, false otherwise.</returns>
        private bool PrintGridCol(int col)
        {
            return _grid.Cols[col].IsVisible;
        }

        /// <summary>
        /// Tests whether the cpecified grid row should be printed.
        /// </summary>
        /// <param name="row">The grid row index.</param>
        /// <returns>True if the row should be printed, false otherwise.</returns>
        private bool PrintGridRow(int row)
        {
            return _grid.Rows[row].IsVisible && !_grid.Rows[row].IsNew;
        }

        /// <summary>
        /// Creates a RenderArea representing a tree node in a grid.
        /// The tree node includes the passed cell content, plus tree-related stuff
        /// such as offset, expand/collapse glyphs etc.
        /// </summary>
        /// <param name="cellContent">The cell's content (text, image or both).</param>
        /// <param name="gridRow">The grid row index.</param>
        /// <returns>The RenderArea representing the tree node.</returns>
        private RenderArea MakeTreeRO(RenderObject cellContent, int gridRow)
        {
            // TODO: add tree lines.

            int indent = _grid.Tree.Indent;
            RenderArea ra = new RenderArea();
            ra.Stacking = StackingRulesEnum.BlockLeftToRight;
            ra.Style.FlowAlignChildren = FlowAlignEnum.Center;

            Node node = _grid.Rows[gridRow].Node;
            bool collapsed = node != null ? node.Collapsed : false;
            RenderEmpty re = new RenderEmpty(PixelsToUnit(indent * node.Level), Unit.Empty);
            ra.Children.Add(re);
            RenderImage plusminus = MakeGlyphRO(collapsed ? GlyphEnum.Collapsed : GlyphEnum.Expanded);
            if (!_grid.Rows[gridRow].IsNode || _grid.Rows[gridRow].Node.Children == 0)
                plusminus.Visibility = VisibilityEnum.Hidden; // just a spacer
            plusminus.Style.Parent = _styleTreeGlyph;
            ra.Children.Add(plusminus);
            if (cellContent != null)
                ra.Children.Add(cellContent);
            return ra;
        }

        /// <summary>
        /// Converts "general" horizontal text alignment to a left or right alignment,
        /// depending on the data type and value. Mimics the logic used by flex grid.
        /// </summary>
        /// <param name="cellStyle">The cell style.</param>
        /// <param name="dataType">The cell data type.</param>
        /// <param name="value">The cell value.</param>
        /// <returns>The actual text alignment.</returns>
        private TextAlignEnum GetTextAlign(CellStyle cellStyle, Type dataType, string value)
        {
            switch (cellStyle.TextAlign)
            {
                case TextAlignEnum.GeneralTop:
                    return Utility.IsNumeric(dataType) || Utility.IsNumeric(value) ? TextAlignEnum.RightTop : TextAlignEnum.LeftTop;
                case TextAlignEnum.GeneralCenter:
                    return Utility.IsNumeric(dataType) || Utility.IsNumeric(value) ? TextAlignEnum.RightCenter : TextAlignEnum.LeftCenter;
                case TextAlignEnum.GeneralBottom:
                    return Utility.IsNumeric(dataType) || Utility.IsNumeric(value) ? TextAlignEnum.RightBottom : TextAlignEnum.LeftBottom;
                default:
                    return cellStyle.TextAlign;
            }
        }

        /// <summary>
        /// Builds a unique key for a grid cell style. For each of those keys, a separate C1PrintDocument
        /// style is built that is used as Parent for the corresponding RenderTable cell's style.
        /// </summary>
        /// <param name="cs">The grid cell style.</param>
        /// <param name="dataType">The grid cell data type (used to disambiguate "general" text alignment).</param>
        /// <param name="value">The grid cell text (used to disambiguate "general" text alignment).</param>
        /// <param name="edges">Outer edges of the table on which the cell borders.</param>
        /// <param name="borderLeft">The left border of the cell (which is the right border of the cell on the left).</param>
        /// <param name="borderTop">The top border of the cell (which is the bottom border of the cell on the top).</param>
        /// <returns>A unique key identifying the cell style.</returns>
        private string BuildCellStyleKey(CellStyle cs, Type dataType, string value, EdgeEnum edges, LineDef borderLeft, LineDef borderTop)
        {
            // note: using CellStyle.BuildString is VERY slow if background images are included, hence this.
            string str = string.Format(CultureInfo.InvariantCulture,
                "{0:X}{1:X}{2:X}{3:X}{4:X}{5:X}{6:X}{7:X}{8:X}{9:X}{10:X}",
                cs.Display.GetHashCode(),
                cs.Font.GetHashCode(),
                cs.BackColor.GetHashCode(),
                cs.ForeColor.GetHashCode(),
                cs.TextAlign.GetHashCode(),
                cs.TextDirection.GetHashCode(),
                cs.ImageAlign.GetHashCode(),
                cs.WordWrap.GetHashCode(),
                cs.Border.GetHashCode(), // ??
                cs.BackgroundImage != null && cs.BackgroundImageLayout != ImageAlignEnum.Hide ? cs.BackgroundImage.GetHashCode() : 0,
                cs.BackgroundImageLayout.GetHashCode());

            // Style attributes NOT included:
            // StyleElementFlags.Format
            // StyleElementFlags.EditMask
            // StyleElementFlags.ComboList
            // StyleElementFlags.DataType
            // StyleElementFlags.Margins
            // StyleElementFlags.TextEffect
            // StyleElementFlags.ImageSpacing
            // StyleElementFlags.Trimming

            return str;
        }

        /// <summary>
        /// Creates a key identifying a style with particular Margins.
        /// </summary>
        /// <param name="cs">The grid cell style.</param>
        /// <returns>A unique key identifying the style with certain margins.</returns>
        private string BuildCellRoStyleKey(CellStyle cs)
        {
            return cs.Margins.ToString();
        }

        /// <summary>
        /// Gets the C1PrintDocument style corresponding to the specified C1FlexGrid cell style.
        /// If the required style has not been created yet, it is created and added to the _styles
        /// hashtable for reuse.
        /// </summary>
        /// <param name="cellStyle">The grid cell style.</param>
        /// <param name="styles">The C1PrintDocument styles collection to which a new style may be added.</param>
        /// <param name="dataType">The grid cell data type (used to disambiguate general text alignment).</param>
        /// <param name="value">The grid cell text (used to disambiguate general text alignment).</param>
        /// <param name="edges">Outer edges of the table on which the cell borders.</param>
        /// <param name="borderLeft">The left border of the cell (which is the right border of the cell on the left).</param>
        /// <param name="borderTop">The top border of the cell (which is the bottom border of the cell on the top).</param>
        /// <returns>The style to apply to the RenderTable cell.</returns>
        private Style StyleFromGridStyle(CellStyle cellStyle, StyleCollection styles, Type dataType, string value,
            EdgeEnum edges, LineDef borderLeft, LineDef borderTop)
        {
            string key = BuildCellStyleKey(cellStyle, dataType, value, edges, borderLeft, borderTop);
            // if a matching style already exists just use it:
            if (_styles.ContainsKey(key))
                return _styles[key];

            Style s = styles.Add();
            // we do not want to inherit any non-ambient properties from the "styles" owner -
            // all that is needed will be explicitly set by CopyCellStyle:
            s.Parent = null;
            // build the style based on cell style and other data:
            CopyCellStyle(s, cellStyle, dataType, value, edges, borderLeft, borderTop);
            // add the style to the hashtable for reuse, and return:
            _styles[key] = s;
            return s;
        }

        /// <summary>
        /// Gets the style used to add spacing between RenderTable cells and their content
        /// (corresponds to flex grid CellStyle.Margins; TableCell.Style cannot be used for that).
        /// (Other style props can be added here as needed.)
        /// </summary>
        /// <param name="cellStyle">The grid cell style.</param>
        /// <param name="styles">The C1PrintDocument styles collection to which a new style may be added.</param>
        /// <returns>The style to set as Parent for TableCell.RenderObject.Style.</returns>
        /// <remarks>
        /// An example of non-ambient attribute that IS supported by table cells is Borders -
        /// hence it is handled by TableCell.Style.
        /// </remarks>
        private Style CellRoStyleFromGridStyle(CellStyle cellStyle, StyleCollection styles)
        {
            string key = BuildCellRoStyleKey(cellStyle);
            if (_cellRoStyles.ContainsKey(key))
                return _cellRoStyles[key];

            Style s = styles.Add();
            // Convert flex Margins to Spacing between cell's RO and cell's borders:
            const int addWidth = 0;// 2;
            s.Spacing.Left = PixelsToUnit(cellStyle.Margins.Left + addWidth);
            s.Spacing.Top = PixelsToUnit(cellStyle.Margins.Top);
            s.Spacing.Right = PixelsToUnit(cellStyle.Margins.Right + addWidth);
            s.Spacing.Bottom = PixelsToUnit(cellStyle.Margins.Bottom);
            _cellRoStyles[key] = s;
            return s;
        }

        /// <summary>
        /// Adjusts the passed style to mach the appearance of the specified C1FlexGrid cell style.
        /// Also takes into account cell data (affects "general" text alignment), and whether the
        /// cell is at the edge of the containing table (affects borders).
        /// </summary>
        /// <param name="target">The target style to modify.</param>
        /// <param name="source">The source cell style.</param>
        /// <param name="dataType">The grid cell data type (used to disambiguate general text alignment).</param>
        /// <param name="value">The grid cell text (used to disambiguate general text alignment).</param>
        /// <param name="edges">Outer edges of the table on which the cell borders.</param>
        /// <param name="borderLeft">The left border of the cell (which is the right border of the cell on the left).</param>
        /// <param name="borderTop">The top border of the cell (which is the bottom border of the cell on the top).</param>
        private void CopyCellStyle(Style target, CellStyle source, Type dataType, string value, EdgeEnum edges, LineDef borderLeft, LineDef borderTop)
        {
            target.Font = source.Font;
            target.BackColor = source.BackColor;
            target.TextColor = source.ForeColor;

            if (source.TextDirection == TextDirectionEnum.Up)
                target.TextAngle = 90;
            else if (source.TextDirection == TextDirectionEnum.Down)
                target.TextAngle = 270;

            // source.Trimming

            target.WordWrap = source.WordWrap;
            TextAlignInfo ta = s_TextAlignToTA[GetTextAlign(source, dataType, value)];
            target.TextAlignHorz = ta.Horz;
            target.TextAlignVert = ta.Vert;

            ImageAlignInfo ia = s_ImageAlignToIA[source.ImageAlign];
            target.ImageAlign.AlignHorz = ia.Horz;
            target.ImageAlign.AlignVert = ia.Vert;
            if (source.ImageAlign == ImageAlignEnum.Scale)
            {
                target.ImageAlign.BestFit = true;
                target.ImageAlign.StretchVert = true;
                target.ImageAlign.StretchHorz = true;
                target.ImageAlign.KeepAspectRatio = true;
            }
            else if (source.ImageAlign == ImageAlignEnum.Stretch)
            {
                target.ImageAlign.StretchVert = true;
                target.ImageAlign.StretchHorz = true;
                target.ImageAlign.KeepAspectRatio = false;
            }
            else
            {
                target.ImageAlign.StretchVert = false;
                target.ImageAlign.StretchHorz = false;
                target.ImageAlign.KeepAspectRatio = true;
            }
            // todo: handle Tile/TileStretch

            // borders:
            if (PrintInfo.PrintBorders)
            {
                // note: outer borders are defined by EmptyArea style.
                // left:
                if ((edges & EdgeEnum.Left) != 0)
                    target.Borders.Left = BorderToLineDef(_grid.Styles.EmptyArea, false);
                else
                    target.Borders.Left = borderLeft;
                // top:
                if ((edges & EdgeEnum.Top) != 0)
                    target.Borders.Top = BorderToLineDef(_grid.Styles.EmptyArea, true);
                else
                    target.Borders.Top = borderTop;
                // right:
                if ((edges & EdgeEnum.Right) != 0)
                    target.Borders.Right = BorderToLineDef(_grid.Styles.EmptyArea, false);
                else
                    target.Borders.Right = BorderToLineDef(source, false);
                // bottom:
                if ((edges & EdgeEnum.Bottom) != 0)
                    target.Borders.Bottom = BorderToLineDef(_grid.Styles.EmptyArea, true);
                else
                    target.Borders.Bottom = BorderToLineDef(source, true);
            }

            CopyBackgroundImage(target, source);

            // style attributes that are ignored (todo):
            // source.TextEffect

            // style attributes that are accounted for elsewhere and/or irrelevant for print:
            // source.Padding
            // source.Display
            // source.Format
            // source.DataType
            // source.ImageAlign
            // source.ImageSpacing
            // source.EditMask
            // source.ComboList
        }

        private void CopyBackgroundImage(Style target, CellStyle source)
        {
            if (source.BackgroundImage == null || source.BackgroundImageLayout == ImageAlignEnum.Hide)
                return;

            ImageAlignInfo iai = s_ImageAlignToIA[source.BackgroundImageLayout];
            bool stretch, keepaspect, tile;

            switch (source.BackgroundImageLayout)
            {
                case ImageAlignEnum.Scale:
                    stretch = true;
                    keepaspect = true;
                    tile = false;
                    break;
                case ImageAlignEnum.Stretch:
                    stretch = true;
                    keepaspect = false;
                    tile = false;
                    break;
                case ImageAlignEnum.Tile:
                    stretch = false;
                    keepaspect = true;
                    tile = true;
                    break;
                case ImageAlignEnum.TileStretch:
                    // todo: this is a bad workaround:
                    stretch = true;
                    keepaspect = false;
                    tile = false;
                    break;
                default:
                    stretch = false;
                    keepaspect = true;
                    tile = false;
                    break;
            }
            target.BackgroundImageAlign = new ImageAlign(iai.Horz, iai.Vert, stretch, stretch, keepaspect, tile, tile);
            if (source.BackgroundImageLayout != ImageAlignEnum.TileStretch)
                target.BackgroundImage = source.BackgroundImage;
            else
                target.BackgroundImage = MakeTileStretchImage(source.BackgroundImage);
        }

        /// <summary>
        /// This method is a not very good workaround for the TileStretch background image
        /// drawing method of flex grid. It just cuts off the corners of the original image,
        /// as this yields better results than using the stretched original.
        /// </summary>
        /// <param name="img">The original image.</param>
        /// <returns>Image cut out from the middle 1/3 of the original image.</returns>
        private Image MakeTileStretchImage(Image img)
        {
            // NOTE: for some reason C1PrintDocument's background images are strangely stretched/washed out
            // on the right/bottom edge. must clarify with Alexander.
            Size sz = new Size(img.Width / 3, img.Height / 3);
            Bitmap bmp = new Bitmap(sz.Width, sz.Height);
            Rectangle src = new Rectangle(sz.Width, sz.Height, img.Width - 2 * sz.Width, img.Height - 2 * sz.Height);
            using (Graphics g = Graphics.FromImage(bmp))
                g.DrawImage(img, new Rectangle(Point.Empty, sz), new Rectangle(new Point(sz), sz), GraphicsUnit.Pixel);
            return bmp;
        }
        #endregion
    }
}
