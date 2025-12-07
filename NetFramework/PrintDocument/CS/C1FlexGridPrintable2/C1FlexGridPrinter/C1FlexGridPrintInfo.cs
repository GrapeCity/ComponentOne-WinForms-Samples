using System;
using System.ComponentModel;

namespace C1.Win.FlexGrid
{
    /// <summary>
    /// Provides properties that can adjust how a C1FlexGrid
    /// is rendered in a C1PrintDocument.
    /// </summary>
    public class C1FlexGridPrintInfo
    {
        /// <summary>
        /// Initializes a new instance of <c>C1FlexGridPrintInfo</c>.
        /// </summary>
        public C1FlexGridPrintInfo()
        {
            AllowHorzSplit = true;
            PrintFixedRows = true;
            PrintFixedCols = true;
            RepeatFixedRows = true;
            RepeatFixedCols = true;
            AutoRowHeights = true;
            AutoColWidths = false;
            MaxColWidth = 500; // in 96dpi pixels
            PrintHighlight = false;
            PrintDBCursor = false;
            PrintBorders = true;
            AutosizeFixedCols = false;
            AutosizeFixedRows = false;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the grid may be split across multiple pages
        /// if it is too wide to fit on a single page.
        /// <para>The default value is true.</para>
        /// </summary>
        [Description("Indicates whether the grid may be split across multiple pages if it is too wide to fit on a single page.")]
        [DefaultValue(true)]
        public bool AllowHorzSplit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to print fixed rows.
        /// <para>The default value is true.</para>
        /// </summary>
        [Description("Indicates whether to print fixed rows.")]
        [DefaultValue(true)]
        public bool PrintFixedRows { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to print fixed columns.
        /// <para>The default value is true.</para>
        /// </summary>
        [Description("Indicates whether to print fixed columns.")]
        [DefaultValue(true)]
        public bool PrintFixedCols { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to print fixed rows on all pages.
        /// This property is ignored if <see cref="PrintFixedRows"/> is false.
        /// <para>The default value is true.</para>
        /// </summary>
        [Description("Indicates whether to print fixed rows on all pages.")]
        [DefaultValue(true)]
        public bool RepeatFixedRows { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to repeat fixed columns on all pages
        /// if the grid is too wide to fit on one page.
        /// This property is ignored if <see cref="PrintFixedCols"/> is false.
        /// <para>The default value is true.</para>
        /// </summary>
        [Description("Indicates whether to print fixed columns on all pages if the grid is too wide to fit on one page.")]
        [DefaultValue(true)]
        public bool RepeatFixedCols { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether row heights are resized automatically
        /// to accommodate all data. If this property is false, row heights are the same
        /// as in the grid.
        /// <para>The default value is true.</para>
        /// </summary>
        [Description("Indicates indicating whether row heights are resized automatically to accommodate all data.")]
        [DefaultValue(true)]
        public bool AutoRowHeights { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether column widths are resized automatically
        /// to accommodate all data. If this property is false, column widths are the same
        /// as in the grid.
        /// <para>The default value is false.</para>
        /// </summary>
        /// <remarks>
        /// Note that if the grid contains cells with very long texts that are wider
        /// than a printed page, setting this property to true would result in data
        /// clipping.
        /// </remarks>
        [Description("Indicates indicating whether column widths are resized automatically to accommodate all data.")]
        [DefaultValue(false)]
        public bool AutoColWidths { get; set; }

        /// <summary>
        /// Gets or sets the maximum column width in the printed grid,
        /// in screen (96 dpi) pixels.
        /// This is especially useful if the grid contains columns that are
        /// too wide to fit on a printed page.
        /// <para>The default value is 500.</para>
        /// </summary>
        [Description("Specifies the maximum column width in the printed grid, in screen (96 dpi) pixels.")]
        [DefaultValue(500)]
        public int MaxColWidth { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether highlighted cells are printed as such.
        /// <para>The default value is false.</para>
        /// </summary>
        [Description("Indicates whether highlighted cells are printed as such.")]
        [DefaultValue(false)]
        public bool PrintHighlight { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the current record indicator should be printed.
        /// <para>The default value is false.</para>
        /// </summary>
        [Description("Indicates whether the current record indicator should be printed.")]
        [DefaultValue(false)]
        public bool PrintDBCursor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether borders specified by the grid styles are printed.
        /// Set this property to false if you want to use C1PrintDocument's Style.Borders and/or Style.GridLines
        /// to specify how borders are printed instead.
        /// <para>The default value is true.</para>
        /// </summary>
        [Description("Indicates whether borders specified by the grid styles are printed.")]
        [DefaultValue(true)]
        public bool PrintBorders { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the widths of fixed columns are automatically
        /// adjusted to fit their content.
        /// This property is ignored if <see cref="AutoColWidths"/> is <c>false</c>.
        /// The default value is <c>false</c>.
        /// </summary>
        [Description("Indicates whether the widths of fixed columns are automatically adjusted to fit their content.")]
        [DefaultValue(false)]
        public bool AutosizeFixedCols { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the heights of fixed rows are automatically
        /// adjusted to fit their content.
        /// This property is ignored if <see cref="AutoRowHeights"/> is <c>false</c>.
        /// The default value is <c>false</c>.
        /// </summary>
        [Description("Indicates whether the heights of fixed rows are automatically adjusted to fit their content.")]
        [DefaultValue(false)]
        public bool AutosizeFixedRows { get; set; }
    }
}
