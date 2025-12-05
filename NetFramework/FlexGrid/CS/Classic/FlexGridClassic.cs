//-----------------------------------------------------------------------------------------
// C1\FlexGrid\Classic\FlexGridClassic.cs
//
// C1FlexGridClassic is a class that extends the C1FlexGrid and provides an object model 
// that is compatible with the VSFlex ActiveX control.
//
// This class is provided to aid in migrating existing projects based on the ActiveX 
// VSFlexGrid control to the new .NET C1FlexGrid control.
//
// Copyright (C) 2001-2005 ComponentOne LLC
//-----------------------------------------------------------------------------------------
// Status	Date		By			Comments
//-----------------------------------------------------------------------------------------
// Created	May 2001	Bernardo	-
//-----------------------------------------------------------------------------------------
using System;
using System.Xml;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Design;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace C1.Win.FlexGrid.Classic
{
    //----------------------------------------------------------
    #region ** enumerations

    public enum AutoSizeSettings 
    {
        flexAutoSizeColWidth,
        flexAutoSizeRowHeight
    }
    public enum EllipsisSettings 
    {
        flexNoEllipsis,
        flexEllipsisEnd,
        flexEllipsisPath
    }
    public enum EditableSettings
    {
        flexEDNone,
        flexEDKbd,
        flexEDKbdMouse
    }
    public enum SelModeSettings 
    {
        flexSelectionFree,
        flexSelectionByRow,
        flexSelectionByColumn,
        flexSelectionListBox
    }
    public enum AllowUserResizeSettings 
    {
        flexResizeNone,
        flexResizeColumns,
        flexResizeRows,
        flexResizeBoth,
        flexResizeBothUniform,
        flexResizeRowsUniform
    }
    public enum RedrawSettings 
    {
        flexRDNone,
        flexRDDirect,
        flexRDBuffered
    }
    public enum TabBehaviorSettings 
    {
        flexTabControls,
        flexTabCells
    }
    public enum TextStyleSettings 
    { 
        flexTextFlat,
        flexTextRaised,
        flexTextInset,
        flexTextRaisedLight,
        flexTextInsetLight
    }
    public enum GridStyleSettings
    {
        flexGridNone,
        flexGridFlat,
        flexGridInset,
        flexGridRaised,
        flexGridFlatHorz,
        flexGridInsetHorz,
        flexGridRaisedHorz,
        flexGridSkipHorz,
        flexGridFlatVert,
        flexGridInsetVert,
        flexGridRaisedVert,
        flexGridSkipVert,
        flexGridExplorer,
        flexGridExcel
    }
    public enum ClearWhatSettings 
    {
        flexClearEverything,
        flexClearText,
        flexClearFormatting,
        flexClearData
    }
    public enum ClearWhereSettings 
    {
        flexClearEverywhere,
        flexClearScrollable,
        flexClearSelection
    }
    public enum SortSettings 
    {
        flexSortNone,
        flexSortGenericAscending,
        flexSortGenericDescending,
        flexSortNumericAscending,
        flexSortNumericDescending,
        flexSortStringNoCaseAscending,
        flexSortStringNoCaseDescending,
        flexSortStringAscending,
        flexSortStringDescending,
        flexSortCustom,
        flexSortUseColSort
    }
#if !WHIDBEY
    [Flags] 
#endif
    public enum ExplorerBarSettings 
    {
        flexExNone            = 0,
        flexExSort            = 1,
        flexExMove            = 2,
        flexExSortAndMove     = 3,
        flexExSortShow        = 5,
        flexExSortShowAndMove = 7,
        flexExMoveRows        = 8,
    }
    public enum MergeSettings 
    {
        flexMergeNever,
        flexMergeFree,
        flexMergeRestrictRows,
        flexMergeRestrictColumns,
        flexMergeRestrictAll,
        flexMergeFixedOnly,
        flexMergeSpill,
        flexMergeOutline
    }
    public enum AlignmentSettings 
    {
        flexAlignLeftTop,
        flexAlignLeftCenter,
        flexAlignLeftBottom,
        flexAlignCenterTop,
        flexAlignCenterCenter,
        flexAlignCenterBottom,
        flexAlignRightTop,
        flexAlignRightCenter,
        flexAlignRightBottom,
        flexAlignGeneral
    }
    public enum PictureAlignmentSettings 
    {
        flexPicAlignLeftTop,
        flexPicAlignLeftCenter,
        flexPicAlignLeftBottom,
        flexPicAlignCenterTop,
        flexPicAlignCenterCenter,
        flexPicAlignCenterBottom,
        flexPicAlignRightTop,
        flexPicAlignRightCenter,
        flexPicAlignRightBottom,
        flexPicAlignStretch,
        flexPicAlignTile
    }
    public enum FillStyleSettings 
    {
        flexFillSingle,
        flexFillRepeat
    }
    public enum CellCheckedSettings 
    {
        flexNoCheckbox,
        flexChecked,
        flexUnchecked,
        flexTSChecked,
        flexTSUnchecked,
        flexTSGrayed
    }
    public enum OutlineBarSettings 
    {
        flexOutlineBarNone,
        flexOutlineBarComplete,
        flexOutlineBarSimple,
        flexOutlineBarSymbols,
        flexOutlineBarCompleteLeaf,
        flexOutlineBarSimpleLeaf,
        flexOutlineBarSymbolsLeaf,
    }
	public enum CellPropertySettings
	{
		flexcpText,
		flexcpTextStyle,
		flexcpAlignment,
		flexcpPicture,
		flexcpPictureAlignment,
		flexcpChecked,
		flexcpBackColor,
		flexcpForeColor,
		flexcpFloodPercent,
		flexcpFloodColor,
		flexcpFont,
		flexcpFontName,
		flexcpFontSize,
		flexcpFontBold,
		flexcpFontItalic,
		flexcpFontUnderline,
		flexcpFontStrikethru,
		flexcpFontWidth,
		flexcpValue,
		flexcpTextDisplay,
		flexcpData,
		flexcpCustomFormat,
		flexcpLeft,
		flexcpTop,
		flexcpWidth,
		flexcpHeight,
		flexcpVariantValue,
		flexcpRefresh,
		flexcpSort
    }
    #endregion

    /// <summary>
	/// Summary description for FlexGridClassic.
	/// </summary>
	[
	LicenseProvider(typeof(LicenseProvider)),
    ToolboxBitmap(typeof(C1FlexGridClassic), "C1FlexGridClassic.png")
	]
	public class C1FlexGridClassic :
		C1.Win.FlexGrid.C1FlexGrid
	{
        //----------------------------------------------------------
        #region ** member variables

		private AutoSizeSettings		_autoSizeMode	 = AutoSizeSettings.flexAutoSizeColWidth;
		private GridStyleSettings		_gridLines		 = GridStyleSettings.flexGridFlat;
		private GridStyleSettings		_gridLinesFixed	 = GridStyleSettings.flexGridInset;
		private FillStyleSettings		_fillStyle		 = FillStyleSettings.flexFillSingle;

        #endregion

        //----------------------------------------------------------
        #region ** constructor

		public C1FlexGridClassic()
		{
			// initialize default values
			base.KeyActionEnter = KeyActionEnum.None;
			base.AllowEditing   = false;
		}

        #endregion

        //----------------------------------------------------------
        #region ** hide new/renamed properties

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		new public Image BackgroundImage
		{
			get { return base.BackgroundImage; }
			set { base.BackgroundImage = value; }
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		new public AllowResizingEnum AllowResizing
		{
			get { return base.AllowResizing; }
			set { base.AllowResizing = value; }
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		new public bool AllowEditing
		{
			get { return base.AllowEditing; }
			set { base.AllowEditing = value; }
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		new public AllowDraggingEnum AllowDragging
		{
			get { return base.AllowDragging; }
			set { base.AllowDragging = value; }
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		new public AllowMergingEnum AllowMerging
		{
			get { return base.AllowMerging; }
			set { base.AllowMerging = value; }
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		new public AllowSortingEnum AllowSorting
		{
			get { return base.AllowSorting; }
			set { base.AllowSorting = value; }
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		new public KeyActionEnum KeyActionEnter
		{
			get { return base.KeyActionEnter; }
			set { base.KeyActionEnter = value; }
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		new public KeyActionEnum KeyActionTab
		{
			get { return base.KeyActionTab; }
			set { base.KeyActionTab = value; }
		}
		[Browsable(false)]//, DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		new public CellStyleCollection Styles
		{
			get { return base.Styles; }
			set { base.Styles = value; }
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		new public Image CellButtonImage
		{
			get { return base.CellButtonImage; }
			set { base.CellButtonImage = value; }
		}

        #endregion

        //----------------------------------------------------------
        #region ** expose base col collection (so designer can persist the collection)

        [Browsable(false)]
        public ColumnCollection ColumnCollection
        {
            get { return base.Cols; }
            set { base.Cols = value; }
        }

        #endregion

        //----------------------------------------------------------
        #region ** font properties

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool FontBold
		{
			get { return Font.Bold; }
			set { Font = ChangeFont(Font, FontStyle.Bold, value); }
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool FontItalic
		{
			get { return Font.Italic; }
			set { Font = ChangeFont(Font, FontStyle.Italic, value); }
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool FontUnderline
		{
			get { return Font.Underline; }
			set { Font = ChangeFont(Font, FontStyle.Underline, value); }
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool FontStrikethru
		{
			get { return base.Selection.StyleDisplay.Font.Strikeout; }
			set { Font = ChangeFont(Font, FontStyle.Strikeout, value); }
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string FontName
		{
			get { return base.Selection.StyleDisplay.Font.Name; }
			set { Font = ChangeFont(Font, value); }
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public float FontSize
		{
			get { return base.Selection.StyleDisplay.Font.Size; }
			set { Font = ChangeFont(Font, value); }
		}

        #endregion

        //----------------------------------------------------------
        #region ** row/col-type properties

		[DefaultValue(50)]
		new public int Rows
		{
			get { return base.Rows.Count; }
			set { base.Rows.Count = value; }
		}
		[DefaultValue(10)]
		new public int Cols
		{
			get { return base.Cols.Count; }
			set { base.Cols.Count = value; }
		}
		[DefaultValue(1)]
		public int FixedRows
		{
			get { return base.Rows.Fixed; }
			set { base.Rows.Fixed = value; }
		}
		[DefaultValue(1)]
		public int FixedCols
		{
			get { return base.Cols.Fixed; }
			set { base.Cols.Fixed = value; }
		}
		[DefaultValue(0)]
		public int FrozenRows
		{
			get { return base.Rows.Frozen; }
			set { base.Rows.Frozen = value; }
		}
		[DefaultValue(0)]
		public int FrozenCols
		{
			get { return base.Cols.Frozen; }
			set { base.Cols.Frozen = value; }
		}
		[Browsable(false)]
		public int SelectedRows
		{
			get { return base.Rows.Selected.Count; }
		}
		[Browsable(false)]
		public int SelectedRow(int index)
		{
			return base.Rows.Selected[index].Index;
		}
		public void GetSelection(out int row1, out int col1, out int row2, out int col2)
		{
			CellRange rg = base.Selection;
			row1 = rg.r1;
			col1 = rg.c1;
			row2 = rg.r2;
			col2 = rg.c2;
		}

        #endregion

        //----------------------------------------------------------
        #region ** get/set/clear/find data

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		override public string Text
		{
			get 
			{
				return (DesignMode)
					? ""
					: get_TextMatrix(Row, Col);
			}
			set
			{
				if (!DesignMode)
					set_TextMatrix(Row, Col, value);
			}
		}
		[Browsable(false)]
		public double Value
		{
			get { return get_ValueMatrix(Row, Col); }
		}
		public int FindRow(object item)
		{
			for (int row = 0; row < base.Rows.Count; row++)
			{
				object o = base.Rows[row].UserData;
				if (item.Equals(o)) return row;
			}
			return -1;
		}
		public int FindRow(string str, int row, int col, bool caseSensitive, bool fullMatch)
		{
			if (str == null || str.Length == 0) return -1;
			return FindRow(str, row, col, caseSensitive, fullMatch, false);
		}
		public int FindRow(string str, int row, int col)
		{
			return FindRow(str, row, col, true, true, false);
		}
		public void Clear(ClearWhereSettings where, ClearWhatSettings what)
		{
			// translate 'where' parameter
			CellRange rg = base.GetCellRange(0, 0, Rows-1, Cols-1);
			switch (where)
			{
				case ClearWhereSettings.flexClearScrollable:
					rg = base.GetCellRange(FixedRows, FixedCols, Rows-1, Cols-1);
					break;
				case ClearWhereSettings.flexClearSelection:
					rg = base.GetCellRange(Row, Col, RowSel, ColSel);
					break;
			}

			// translate 'what' parameter
			ClearFlags flags = ClearFlags.All;
			switch (what)
			{
				case ClearWhatSettings.flexClearText:
					flags = ClearFlags.Content;
					break;
				case ClearWhatSettings.flexClearFormatting:
					flags = ClearFlags.Style;
					break;
				case ClearWhatSettings.flexClearData:
					flags = ClearFlags.UserData;
					break;
			}

			// clear
			base.Clear(flags, rg);
		}
		public void Clear(ClearWhereSettings where)
		{
			Clear(where, ClearWhatSettings.flexClearEverything);
		}
		new public void Clear()
		{
			Clear(ClearWhereSettings.flexClearEverywhere, ClearWhatSettings.flexClearEverything);
		}
		public string get_TextMatrix(int r, int c)
		{
			if (r < 0 || c < 0) return "";
			object o = GetData(r, c);
			return (o == null)? "": o.ToString();
		}
		public void set_TextMatrix(int r, int c, string s)
		{
			if (r < 0 || c < 0) return;
			base.SetData(r, c, s);
		}
		public double get_ValueMatrix(int r, int c)
		{
			string s = get_TextMatrix(r, c);
			try
			{
				return double.Parse(s, NumberStyles.Any);
			} 
			catch {}
			return 0;
		}

        #endregion

        //----------------------------------------------------------
        #region ** sorting/explorer bar

#if WHIDBEY
		[DefaultValue(ExplorerBarSettings.flexExSortShowAndMove)]
#else
		[DefaultValue(ExplorerBarSettings.flexExNone)]
#endif
		public ExplorerBarSettings ExplorerBar
		{
			get
			{
				ExplorerBarSettings eb = ExplorerBarSettings.flexExNone;
				if (base.AllowSorting != AllowSortingEnum.None)
					eb |= ExplorerBarSettings.flexExSortShow;
				switch (base.AllowDragging)
				{
					case AllowDraggingEnum.Rows:
						eb |= ExplorerBarSettings.flexExMoveRows;
						break;
					case AllowDraggingEnum.Columns:
						eb |= ExplorerBarSettings.flexExMove;
						break;
					case AllowDraggingEnum.Both:
						eb |= ExplorerBarSettings.flexExMoveRows;
						eb |= ExplorerBarSettings.flexExMove;
						break;
				}
				return eb;
			}
			set
			{
				ExplorerBarSettings eb = value;
				base.AllowSorting = ((eb & ExplorerBarSettings.flexExSort) != 0)
					? AllowSortingEnum.SingleColumn
					: AllowSortingEnum.None;

				if ((eb & ExplorerBarSettings.flexExMove) != 0)
					base.AllowDragging = ((eb & ExplorerBarSettings.flexExMoveRows) != 0)
						? AllowDraggingEnum.Both
						: AllowDraggingEnum.Columns;
				else
					base.AllowDragging = ((eb & ExplorerBarSettings.flexExMoveRows) != 0)
						? AllowDraggingEnum.Rows
						: AllowDraggingEnum.None;
			}
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		new public SortSettings Sort
		{
			set
			{
				// build sort flags
				SortFlags sf = GetSortFlags(value);

				// build sort range
				CellRange rg = base.Selection;
				if (rg.r1 == rg.r2)
				{
					rg.r1 = base.Rows.Fixed;
					rg.r2 = base.Rows.Count - 1;
				}

				// sort
				base.Sort(sf, rg);
			}
		}
		protected SortFlags GetSortFlags(SortSettings ss)
		{
			SortFlags sf = SortFlags.None;
			switch (ss)
			{
				case SortSettings.flexSortGenericAscending:
					sf = SortFlags.Ascending;
					break;
				case SortSettings.flexSortGenericDescending:
					sf = SortFlags.Descending;
					break;
				case SortSettings.flexSortNumericAscending:
					sf = SortFlags.Ascending;
					break;
				case SortSettings.flexSortNumericDescending:
					sf = SortFlags.Descending;
					break;
				case SortSettings.flexSortStringNoCaseAscending:
					sf = SortFlags.Ascending | SortFlags.AsDisplayed | SortFlags.IgnoreCase;
					break;
				case SortSettings.flexSortStringNoCaseDescending:
					sf = SortFlags.Descending | SortFlags.AsDisplayed | SortFlags.IgnoreCase;
					break;
				case SortSettings.flexSortStringAscending:
					sf = SortFlags.Ascending | SortFlags.AsDisplayed;
					break;
				case SortSettings.flexSortStringDescending:
					sf = SortFlags.Descending | SortFlags.AsDisplayed;
					break;
				case SortSettings.flexSortUseColSort:
					sf = SortFlags.None; // use ColSort
					break;
			}
			return sf;
		}
		protected SortSettings GetSortSettings(SortFlags sf)
		{
			// get flags
			bool nocase   = (sf & SortFlags.IgnoreCase) != 0;
			bool asstring = (sf & SortFlags.AsDisplayed) != 0;

			// ascending
			if ((sf & SortFlags.Ascending) != 0)
			{
				if (asstring)
					return (nocase)
						? SortSettings.flexSortStringNoCaseAscending
						: SortSettings.flexSortStringAscending;
				else
					return SortSettings.flexSortGenericAscending;
			}

			// descending
			if ((sf & SortFlags.Ascending) != 0)
			{
				if (asstring)
					return (nocase)
						? SortSettings.flexSortStringNoCaseDescending
						: SortSettings.flexSortStringDescending;
				else
					return SortSettings.flexSortGenericDescending;
			}

			// not found, must be none
			return SortSettings.flexSortNone;
		}

        #endregion

        //----------------------------------------------------------
        #region ** style-related properties

		[DefaultValue(typeof(Color), "Control")]
		public Color BackColorFixed
		{
			get { return Styles[CellStyleEnum.Fixed].BackColor; }
			set { Styles[CellStyleEnum.Fixed].BackColor = value; }
		}
		[DefaultValue(typeof(Color), "ControlText")]
		public Color ForeColorFixed
		{
			get { return Styles[CellStyleEnum.Fixed].ForeColor; }
			set { Styles[CellStyleEnum.Fixed].ForeColor = value; }
		}
		[DefaultValue(typeof(Color), "Highlight")]
		public Color BackColorSel
		{
			get { return Styles[CellStyleEnum.Highlight].BackColor; }
			set { Styles[CellStyleEnum.Highlight].BackColor = value; }
		}
		[DefaultValue(typeof(Color), "HighlightText")]
		public Color ForeColorSel
		{
			get { return Styles[CellStyleEnum.Highlight].ForeColor; }
			set { Styles[CellStyleEnum.Highlight].ForeColor = value; }
		}
		[DefaultValue(typeof(Color), "Window")]
		public Color BackColorAlternate
		{
			get { return Styles[CellStyleEnum.Alternate].BackColor; }
			set { Styles[CellStyleEnum.Alternate].BackColor = value; }
		}
		[DefaultValue(typeof(Color), "AppWorkspace")]
		public Color BackColorBkg
		{
			get { return Styles[CellStyleEnum.EmptyArea].BackColor; }
			set { Styles[CellStyleEnum.EmptyArea].BackColor = value; }
		}
		[DefaultValue(typeof(Color), "ControlDarkDark")]
		public Color SheetBorder
		{
			//get { return Styles[CellStyleEnum.EmptyArea].ForeColor; }  <<B150>>
			//set { Styles[CellStyleEnum.EmptyArea].ForeColor = value; } <<B150>>
			get { return Styles[CellStyleEnum.EmptyArea].Border.Color; }
			set { Styles[CellStyleEnum.EmptyArea].Border.Color = value; }
		}
		[DefaultValue(typeof(Color), "Control")]
		public Color GridColor
		{
			get { return Styles[CellStyleEnum.Normal].Border.Color; }
			set { Styles[CellStyleEnum.Normal].Border.Color = value; }
		}
		[DefaultValue(typeof(Color), "ControlDarkDark")]
		public Color GridColorFixed
		{
			get { return Styles[CellStyleEnum.Fixed].Border.Color; }
			set { Styles[CellStyleEnum.Fixed].Border.Color = value; }
		}
		[DefaultValue(1)]
		public int GridLineWidth
		{
			get { return Styles[CellStyleEnum.Normal].Border.Width; }
			set
            {
                if (value < 0) // <B315>>
                {
                    throw new ArgumentOutOfRangeException("GridLineWidth must be >= 0.");
                }
                Styles[CellStyleEnum.Normal].Border.Width = value; 
            }
		}
		[DefaultValue(false)]
		public bool WordWrap
		{
			get { return Styles[CellStyleEnum.Normal].WordWrap; }
			set { Styles[CellStyleEnum.Normal].WordWrap = value; }
		}
		[DefaultValue(EllipsisSettings.flexNoEllipsis)]
		public EllipsisSettings Ellipsis
		{
			get
			{
				StringTrimming st = Styles[CellStyleEnum.Normal].Trimming;
				switch (st)
				{
					case StringTrimming.EllipsisPath:
						return EllipsisSettings.flexEllipsisPath;
					case StringTrimming.EllipsisWord:
						return EllipsisSettings.flexEllipsisEnd;
					case StringTrimming.EllipsisCharacter:
						return EllipsisSettings.flexEllipsisEnd;
				}
				return EllipsisSettings.flexNoEllipsis;
			}
			set
			{
				StringTrimming st = StringTrimming.None;
				switch (value)
				{
					case EllipsisSettings.flexEllipsisEnd:
						st = StringTrimming.EllipsisCharacter;
						break;
					case EllipsisSettings.flexEllipsisPath:
						st = StringTrimming.EllipsisPath;
						break;
				}
				Styles[CellStyleEnum.Normal].Trimming = st;
			}
		}
		[DefaultValue(TextStyleSettings.flexTextFlat)]
		public TextStyleSettings TextStyle
		{
			get { return GetTextStyle(Styles[CellStyleEnum.Normal]); }
			set { SetTextStyle(Styles[CellStyleEnum.Normal], value); }
		}
		[DefaultValue(TextStyleSettings.flexTextFlat)]
		public TextStyleSettings TextStyleFixed
		{
			get { return GetTextStyle(Styles[CellStyleEnum.Fixed]); }
			set { SetTextStyle(Styles[CellStyleEnum.Fixed], value); }
		}
		private TextStyleSettings GetTextStyle(CellStyle cs)
		{ 
			switch (cs.TextEffect)
			{
				case TextEffectEnum.Raised: return TextStyleSettings.flexTextRaisedLight;
				case TextEffectEnum.Inset:  return TextStyleSettings.flexTextInsetLight;
			}
			return TextStyleSettings.flexTextFlat;
		}
		private void SetTextStyle(CellStyle cs, TextStyleSettings ts)
		{ 
			TextEffectEnum te = TextEffectEnum.Flat;
			switch (ts)
			{
				case TextStyleSettings.flexTextInset:
					goto case TextStyleSettings.flexTextInsetLight;
				case TextStyleSettings.flexTextInsetLight:
					te = TextEffectEnum.Inset;
					break;
				case TextStyleSettings.flexTextRaised:
					goto case TextStyleSettings.flexTextRaisedLight;
				case TextStyleSettings.flexTextRaisedLight:
					te = TextEffectEnum.Raised;
					break;
			}
			cs.TextEffect = te;
		}
		[DefaultValue(GridStyleSettings.flexGridFlat)]
		public GridStyleSettings GridLines
		{
			get { return _gridLines; }
			set
			{
				_gridLines = value;
				SetGridLines(CellStyleEnum.Normal, value);
			}
		}
		[DefaultValue(GridStyleSettings.flexGridInset)]
		public GridStyleSettings GridLinesFixed
		{
			get { return _gridLinesFixed; }
			set
			{
				_gridLinesFixed = value;
				SetGridLines(CellStyleEnum.Fixed, value);
			}
		}
		private void SetGridLines(CellStyleEnum cs, GridStyleSettings gs)
		{
			CellBorder b = Styles[cs].Border;

			switch (gs)
			{
				case GridStyleSettings.flexGridNone:
					b.Style = BorderStyleEnum.None;
					break;
				case GridStyleSettings.flexGridFlat:
					b.Direction = BorderDirEnum.Both;
					b.Style = BorderStyleEnum.Flat;
					break;
				case GridStyleSettings.flexGridInset:
					b.Direction = BorderDirEnum.Both;
					b.Style = BorderStyleEnum.Raised;
					break;
				case GridStyleSettings.flexGridRaised:
					b.Direction = BorderDirEnum.Both;
					b.Style = BorderStyleEnum.Inset;
					break;
				case GridStyleSettings.flexGridFlatHorz:
					b.Direction = BorderDirEnum.Horizontal;
					b.Style = BorderStyleEnum.Flat;
					break;
				case GridStyleSettings.flexGridInsetHorz:
					b.Direction = BorderDirEnum.Horizontal;
					b.Style = BorderStyleEnum.Raised;
					break;
				case GridStyleSettings.flexGridRaisedHorz:
					b.Direction = BorderDirEnum.Horizontal;
					b.Style = BorderStyleEnum.Inset;
					break;
				case GridStyleSettings.flexGridFlatVert:
					b.Direction = BorderDirEnum.Vertical;
					b.Style = BorderStyleEnum.Flat;
					break;
				case GridStyleSettings.flexGridInsetVert:
					b.Direction = BorderDirEnum.Vertical;
					b.Style = BorderStyleEnum.Raised;
					break;
				case GridStyleSettings.flexGridRaisedVert:
					b.Direction = BorderDirEnum.Vertical;
					b.Style = BorderStyleEnum.Inset;
					break;
				
					// map these to closest
				case GridStyleSettings.flexGridExplorer:
					goto case GridStyleSettings.flexGridInset;
				case GridStyleSettings.flexGridExcel:
					goto case GridStyleSettings.flexGridInset;
				case GridStyleSettings.flexGridSkipVert:
					goto case GridStyleSettings.flexGridInsetVert;
				case GridStyleSettings.flexGridSkipHorz:
					goto case GridStyleSettings.flexGridInsetHorz;
			}
		}

        #endregion

        //----------------------------------------------------------
        #region ** grid geometry/layout

		[Browsable(false)]
		public int CellLeft
		{
			get { return GetCellRect(Row, Col, true).X; }
		}
		[Browsable(false)]
		public int CellTop
		{
			get { return GetCellRect(Row, Col, true).Y; }
		}
		[Browsable(false)]
		public int CellWidth
		{
			get { return GetCellRect(Row, Col, true).Width; }
		}
		[Browsable(false)]
		public int CellHeight
		{
			get { return GetCellRect(Row, Col, true).Height; }
		}
		[DefaultValue(0)]
		public int RowHeightMin
		{
			get { return base.Rows.MinSize; }
			set { base.Rows.MinSize = value; }
		}
		[DefaultValue(0)]
		public int RowHeightMax
		{
			get { return base.Rows.MaxSize; }
			set { base.Rows.MaxSize = value; }
		}
		[DefaultValue(0)]
		public int ColWidthMin
		{
			get { return base.Cols.MinSize; }
			set { base.Cols.MinSize = value; }
		}
		[DefaultValue(0)]
		public int ColWidthMax
		{
			get { return base.Cols.MaxSize; }
			set { base.Cols.MaxSize = value; }
		}
		[DefaultValue(AutoSizeSettings.flexAutoSizeColWidth)]
		public AutoSizeSettings	AutoSizeMode
		{
			get { return _autoSizeMode; }
			set { _autoSizeMode = value; }
		}
#if WHIDBEY
		new public void AutoSize(int col)
#else
		public void AutoSize(int col)
#endif
		{
			AutoSize(col, col);
		}
#if WHIDBEY
		new public void AutoSize(int col1, int col2)
#else
		public void AutoSize(int col1, int col2)
#endif
		{
			AutoSize(col1, col2, false, 0);
		}
#if WHIDBEY
		new public void AutoSize(int col1, int col2, bool equal, int extra)
#else
		public void AutoSize(int col1, int col2, bool equal, int extra)
#endif
		{
			AutoSizeFlags asf = AutoSizeFlags.IgnoreHidden;
			if (equal) asf |= AutoSizeFlags.SameSize;

			if (_autoSizeMode == AutoSizeSettings.flexAutoSizeColWidth)
				AutoSizeCols(col1, col2, 0, base.Rows.Count-1, extra, asf);
			else
				AutoSizeRows(0, col1, base.Rows.Count-1, col2, extra, asf); // <<B275>>
				//AutoSizeRows(0, base.Rows.Count-1, col1, col2, extra, asf);
		}
#if WHIDBEY
		[DefaultValue(AllowUserResizeSettings.flexResizeColumns)]
#else
		[DefaultValue(AllowUserResizeSettings.flexResizeNone)]
#endif
		public AllowUserResizeSettings AllowUserResizing
		{
			get 
			{
				switch (base.AllowResizing)
				{
					case AllowResizingEnum.Both:
						return AllowUserResizeSettings.flexResizeBoth;
					case AllowResizingEnum.BothUniform:
						return AllowUserResizeSettings.flexResizeBothUniform;
					case AllowResizingEnum.Columns:
						return AllowUserResizeSettings.flexResizeColumns;
					case AllowResizingEnum.Rows:
						return AllowUserResizeSettings.flexResizeRows;
					case AllowResizingEnum.RowsUniform:
						return AllowUserResizeSettings.flexResizeRowsUniform;
				}
				return AllowUserResizeSettings.flexResizeNone;
			}
			set
			{
				switch (value)
				{
					case AllowUserResizeSettings.flexResizeBoth:
						base.AllowResizing = AllowResizingEnum.Both;
						return;
					case AllowUserResizeSettings.flexResizeBothUniform:
						base.AllowResizing = AllowResizingEnum.BothUniform;
						return;
					case AllowUserResizeSettings.flexResizeColumns:
						base.AllowResizing = AllowResizingEnum.Columns;
						return;
					case AllowUserResizeSettings.flexResizeRows:
						base.AllowResizing = AllowResizingEnum.Rows;
						return;
					case AllowUserResizeSettings.flexResizeRowsUniform:
						base.AllowResizing = AllowResizingEnum.RowsUniform;
						return;
				}
				base.AllowResizing = AllowResizingEnum.None;
				return;
			}
		}

        #endregion

        //----------------------------------------------------------
        #region ** cell merging

		[DefaultValue(MergeSettings.flexMergeNever)]
		public MergeSettings MergeCells
		{
			get 
			{
				switch (base.AllowMerging)
				{
					case AllowMergingEnum.FixedOnly:	return MergeSettings.flexMergeFixedOnly;
					case AllowMergingEnum.Free:			return MergeSettings.flexMergeFree;
					case AllowMergingEnum.RestrictAll:	return MergeSettings.flexMergeRestrictAll;
					case AllowMergingEnum.RestrictRows:	return MergeSettings.flexMergeRestrictRows;
					case AllowMergingEnum.RestrictCols:	return MergeSettings.flexMergeRestrictColumns;
					case AllowMergingEnum.Spill:		return MergeSettings.flexMergeSpill;
					case AllowMergingEnum.Nodes:		return MergeSettings.flexMergeOutline;
				}
				return MergeSettings.flexMergeNever;
			}
			set
			{
				AllowMergingEnum am = AllowMergingEnum.None;
				switch (value)
				{
					case MergeSettings.flexMergeFixedOnly:			am = AllowMergingEnum.FixedOnly;	break;
					case MergeSettings.flexMergeFree:				am = AllowMergingEnum.Free;			break;
					case MergeSettings.flexMergeRestrictAll:		am = AllowMergingEnum.RestrictAll;	break;
					case MergeSettings.flexMergeRestrictRows:		am = AllowMergingEnum.RestrictRows;	break;
					case MergeSettings.flexMergeRestrictColumns:	am = AllowMergingEnum.RestrictCols;	break;
					case MergeSettings.flexMergeSpill:				am = AllowMergingEnum.Spill;		break;
					case MergeSettings.flexMergeOutline:			am = AllowMergingEnum.Nodes;		break;
				}
				base.AllowMerging = am;
			}
		}
		public void GetMergedRange(int row, int col, out int r1, out int c1, out int r2, out int c2)
		{
			CellRange rg = GetMergedRange(row, col);
			r1 = rg.r1;
			c1 = rg.c1;
			r2 = rg.r2;
			c2 = rg.c2;
		}

        #endregion

        //----------------------------------------------------------
        #region ** editing/navigating

		[DefaultValue(FillStyleSettings.flexFillSingle)]
		public FillStyleSettings FillStyle
		{
			get { return _fillStyle; }
			set { _fillStyle = value; }
		}
		[DefaultValue(EditableSettings.flexEDNone)]
		public EditableSettings Editable
		{
			get 
			{
				return base.AllowEditing
					? EditableSettings.flexEDKbdMouse
					: EditableSettings.flexEDNone; 
			}
			set 
			{
				base.AllowEditing = (value != EditableSettings.flexEDNone);
			}
		}
		[DefaultValue(TabBehaviorSettings.flexTabControls)]
		public TabBehaviorSettings TabBehavior
		{
			get 
			{
				return (base.KeyActionTab == KeyActionEnum.None)
					? TabBehaviorSettings.flexTabControls
					: TabBehaviorSettings.flexTabCells;
			}
			set
			{
				base.KeyActionTab = (value == TabBehaviorSettings.flexTabControls)
					? KeyActionEnum.None
					: KeyActionEnum.MoveAcross;
			}
		}
		[DefaultValue(null)]
		public Image CellButtonPicture
		{
			get { return base.CellButtonImage; }
			set { base.CellButtonImage = value; }
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IntPtr EditWindow
        {
            get 
            { 
                Control ctl = base.Editor;
                return (ctl != null)? ctl.Handle: (IntPtr)0;
            }
        }
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string EditText
        {
            get
            {
                Control ctl = base.Editor;
                return (ctl != null)? ctl.Text: null;
            }
            set
            {
                Control ctl = base.Editor;
                if (ctl != null) ctl.Text = value;
            }
        }
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string EditSelText
        {
            get
            {
                Control ctl = base.Editor;
                if (ctl is TextBox)  return ((TextBox)ctl).SelectedText;
                if (ctl is ComboBox) return ((ComboBox)ctl).SelectedText;
                return null;
            }
            set
            {
                Control ctl = base.Editor;
                if (ctl is TextBox)  ((TextBox)ctl).SelectedText = value;
                if (ctl is ComboBox) ((ComboBox)ctl).SelectedText = value;
            }
        }
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int EditSelStart
        {
            get
            {
                Control ctl = base.Editor;
                if (ctl is TextBox)  return ((TextBox)ctl).SelectionStart;
                if (ctl is ComboBox) return ((ComboBox)ctl).SelectionStart;
                return 0;
            }
            set
            {
                Control ctl = base.Editor;
                if (ctl is TextBox)  ((TextBox)ctl).SelectionStart = value;
                if (ctl is ComboBox) ((ComboBox)ctl).SelectionStart = value;
            }
        }
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int EditSelLength
        {
            get
            {
                Control ctl = base.Editor;
                if (ctl is TextBox)  return ((TextBox)ctl).SelectionLength;
                if (ctl is ComboBox) return ((ComboBox)ctl).SelectionLength;
                return 0;
            }
            set
            {
                Control ctl = base.Editor;
                if (ctl is TextBox)  ((TextBox)ctl).SelectionLength = value;
                if (ctl is ComboBox) ((ComboBox)ctl).SelectionLength = value;
            }
        }
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ComboCount
        {
            get
            {
                Control ctl = base.Editor;
                return (ctl is ComboBox)? ((ComboBox)ctl).Items.Count: 0;
            }
        }
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ComboIndex
        {
            get
            {
                Control ctl = base.Editor;
                return (ctl is ComboBox)? ((ComboBox)ctl).SelectedIndex: -1;
            }
            set
            {
                Control ctl = base.Editor;
                if (ctl is ComboBox) ((ComboBox)ctl).SelectedIndex = value;
            }
        }
        public string ComboItem(int index)
        {
            Control ctl = base.Editor;
            return (ctl is ComboBox)? ((ComboBox)ctl).Items[index].ToString(): null;
        }
		public void EditCell()
		{
			base.StartEditing();
		}

        #endregion

        //----------------------------------------------------------
        #region ** selection/painting

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		new public RedrawSettings Redraw
		{
			get { return base.Redraw? RedrawSettings.flexRDBuffered: RedrawSettings.flexRDNone; }
			set { base.Redraw = ((int)value != 0); }
		}
		[DefaultValue(true)]
		public bool AllowSelection
		{
			get { return base.SelectionMode != SelectionModeEnum.Cell; }
			set 
			{
				if (value == false)
				{
					base.SelectionMode = SelectionModeEnum.Cell; 
					return;
				}
				if (base.SelectionMode == SelectionModeEnum.Cell) 
				{
					base.SelectionMode = (AllowBigSelection)
						? SelectionModeEnum.Default
						: SelectionModeEnum.CellRange;
				}
			}
		}
		[DefaultValue(true)]
		public bool AllowBigSelection
		{
			get 
			{
				return base.SelectionMode != SelectionModeEnum.Cell &&
					base.SelectionMode != SelectionModeEnum.CellRange; 
			}
			set 
			{
				if (value  && base.SelectionMode == SelectionModeEnum.CellRange)
					base.SelectionMode = SelectionModeEnum.Default;
				if (!value && base.SelectionMode == SelectionModeEnum.Default)
					base.SelectionMode = SelectionModeEnum.CellRange;
			}
		}
		[DefaultValue(SelModeSettings.flexSelectionFree)]
		new public SelModeSettings SelectionMode
		{
			get
			{
				switch (base.SelectionMode)
				{
					case SelectionModeEnum.Row:
						return SelModeSettings.flexSelectionByRow;
					case SelectionModeEnum.RowRange:
						return SelModeSettings.flexSelectionByRow;
					case SelectionModeEnum.Column:
						return SelModeSettings.flexSelectionByColumn;
					case SelectionModeEnum.ColumnRange:
						return SelModeSettings.flexSelectionByColumn;
					case SelectionModeEnum.ListBox:
						return SelModeSettings.flexSelectionListBox;
				}
				return SelModeSettings.flexSelectionFree;
			}
			set
			{
				switch (value)
				{
					case SelModeSettings.flexSelectionByRow:
						base.SelectionMode = (AllowSelection)
							? SelectionModeEnum.RowRange
							: SelectionModeEnum.Row;
						return;
					case SelModeSettings.flexSelectionByColumn:
						base.SelectionMode = (AllowSelection)
							? SelectionModeEnum.ColumnRange
							: SelectionModeEnum.Column;
						return;
					case SelModeSettings.flexSelectionListBox:
						base.SelectionMode = SelectionModeEnum.ListBox;
						return;
				}
				base.SelectionMode = (AllowSelection)
					? (AllowBigSelection)? SelectionModeEnum.Default: SelectionModeEnum.CellRange
					: SelectionModeEnum.Cell;
			}
		}

		// <<B150>> DefaultValue(null) is needed. without this, the property grid 
		// won't allow you to clear the image (strange but true)
		[DefaultValue(null)] 
		public Image WallPaper
		{
			get { return base.BackgroundImage; }
			set
			{
				base.BackgroundImage = value;
				if (value != null && BackColor != Color.Transparent)
					BackColor = Color.Transparent;
				if (value == null && BackColor == Color.Transparent)
					BackColor = SystemColors.Window;
			}
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Image Picture
		{
			get { return base.CreateImage(); }
		}

        #endregion

        //----------------------------------------------------------
        #region ** row properties

		public bool get_IsSelected(int row)
		{
			return base.Rows[row].Selected;
		}
		public void set_IsSelected(int row, bool newVal)
		{
			int r1 = (row < 0)? 0: row;
			int r2 = (row < 0)? base.Rows.Count-1: row;
			for (row = r1; row <= r2; row++)
				base.Rows[row].Selected = newVal;
		}
		public object get_RowData(int row)
		{
			return base.Rows[row].UserData;
		}
		public void set_RowData(int row, object newVal)
		{
			int r1 = (row < 0)? 0: row;
			int r2 = (row < 0)? base.Rows.Count-1: row;
			for (row = r1; row <= r2; row++)
				base.Rows[row].UserData = newVal;
		}
		public int get_RowHeight(int row)
		{
			return base.Rows[row].HeightDisplay;
		}
		public void set_RowHeight(int row, int newVal)
		{
			int r1 = (row < 0)? 0: row;
			int r2 = (row < 0)? base.Rows.Count-1: row;
			for (row = r1; row <= r2; row++)
				base.Rows[row].HeightDisplay = newVal;
		}
		public bool get_RowHidden(int row)
		{
			return !base.Rows[row].Visible;
		}
		public void set_RowHidden(int row, bool newVal)
		{
			int r1 = (row < 0)? 0: row;
			int r2 = (row < 0)? base.Rows.Count-1: row;
			for (row = r1; row <= r2; row++)
				base.Rows[row].Visible = !newVal;
		}
		public bool get_RowIsVisible(int row)
		{
			if (row < base.Rows.Fixed) return true;
			if (row < TopRow || row > BottomRow) return false;
			return true;
		}
		public int get_RowPos(int row)
		{
			return GetCellRect(row, 0, false).Y;
		}
		public void set_RowPosition(int row, int newPosition)
		{
			base.Rows.Move(row, newPosition);
		}
		public bool get_MergeRow(int row)
		{
			return base.Rows[row].AllowMerging;
		}
		public void set_MergeRow(int row, bool newVal)
		{
			int r1 = (row < 0)? 0: row;
			int r2 = (row < 0)? base.Rows.Count-1: row;
			for (row = r1; row <= r2; row++)
				base.Rows[row].AllowMerging = newVal;
		}

        #endregion

        //----------------------------------------------------------
        #region ** column properties

		public object get_ColData(int col)
		{
			return base.Cols[col].UserData;
		}
		public void set_ColData(int col, object newVal)
		{
			int c1 = (col < 0)? 0: col;
			int c2 = (col < 0)? base.Cols.Count-1: col;
			for (col = c1; col <= c2; col++)
				base.Cols[col].UserData = newVal;
		}
		public int get_ColWidth(int col)
		{
			return base.Cols[col].WidthDisplay;
		}
		public void set_ColWidth(int col, int newVal)
		{
			int c1 = (col < 0)? 0: col;
			int c2 = (col < 0)? base.Cols.Count-1: col;
			for (col = c1; col <= c2; col++)
				base.Cols[col].WidthDisplay = newVal;
		}
		public bool get_ColHidden(int col)
		{
			return !base.Cols[col].Visible;
		}
		public void set_ColHidden(int col, bool newVal)
		{
			int c1 = (col < 0)? 0: col;
			int c2 = (col < 0)? base.Cols.Count-1: col;
			for (col = c1; col <= c2; col++)
				base.Cols[col].Visible = !newVal;
		}
		public bool get_ColIsVisible(int col)
		{
			if (col < base.Cols.Fixed) return true;
			if (col < LeftCol || col > RightCol) return false;
			return true;
		}
		public int get_ColPos(int col)
		{
			return GetCellRect(0, col, false).X;
		}
		public void set_ColPosition(int col, int newPosition)
		{
			base.Cols.Move(col, newPosition);
		}
		public string get_ColComboList(int col)
		{
			return base.Cols[col].ComboList;
		}
		public void set_ColComboList(int col, string newVal)
		{
			int c1 = (col < 0)? 0: col;
			int c2 = (col < 0)? base.Cols.Count-1: col;
			for (col = c1; col <= c2; col++)
				base.Cols[col].ComboList = newVal;
		}
		public string get_ColFormat(int col)
		{
			return base.Cols[col].Format;
		}
		public void set_ColFormat(int col, string newVal)
		{
			int c1 = (col < 0)? 0: col;
			int c2 = (col < 0)? base.Cols.Count-1: col;
			for (col = c1; col <= c2; col++)
				base.Cols[col].Format = newVal;
		}
		public string get_ColEditMask(int col)
		{
			return base.Cols[col].EditMask;
		}
		public void set_ColEditMask(int col, string newVal)
		{
			int c1 = (col < 0)? 0: col;
			int c2 = (col < 0)? base.Cols.Count-1: col;
			for (col = c1; col <= c2; col++)
				base.Cols[col].EditMask = newVal;
		}
		public Type get_ColDataType(int col)
		{
			return base.Cols[col].DataType;
		}
		public void set_ColDataType(int col, Type newVal)
		{
			int c1 = (col < 0)? 0: col;
			int c2 = (col < 0)? base.Cols.Count-1: col;
			for (col = c1; col <= c2; col++)
				base.Cols[col].DataType = newVal;
		}
		public void set_ColImageList(int col, ImageList newVal)
		{
			Hashtable imgMap = new Hashtable();
			for (int i = 0; i < newVal.Images.Count; i++)
				imgMap.Add(i, newVal.Images[i]);
			int c1 = (col < 0)? 0: col;
			int c2 = (col < 0)? base.Cols.Count-1: col;
			for (col = c1; col <= c2; col++)
				base.Cols[col].ImageMap = imgMap;
		}
		public SortSettings get_ColSort(int col)
		{
			return GetSortSettings(base.Cols[col].Sort);
		}
		public void set_ColSort(int col, SortSettings newVal)
		{
			int c1 = (col < 0)? 0: col;
			int c2 = (col < 0)? base.Cols.Count-1: col;
			for (col = c1; col <= c2; col++)
				base.Cols[col].Sort = GetSortFlags(newVal);
		}
		public string get_ColKey(int col)
		{
			return base.Cols[col].Name;
		}
		public void set_ColKey(int col, string newVal)
		{
			int c1 = (col < 0)? 0: col;
			int c2 = (col < 0)? base.Cols.Count-1: col;
			for (col = c1; col <= c2; col++)
				base.Cols[col].Name = newVal;
		}
		public int get_ColIndex(string colKey)
		{
			Column col = base.Cols[colKey];
			return (col == null)? -1: col.Index;
		}
		public bool get_MergeCol(int col)
		{
			return base.Cols[col].AllowMerging;
		}
		public void set_MergeCol(int col, bool newVal)
		{
			int c1 = (col < 0)? 0: col;
			int c2 = (col < 0)? base.Cols.Count-1: col;
			for (col = c1; col <= c2; col++)
				base.Cols[col].AllowMerging = newVal;
		}
		public AlignmentSettings get_ColAlignment(int col)
		{
			return MapTextAlign(base.Cols[col].TextAlign);
		}
		public void set_ColAlignment(int col, AlignmentSettings newVal)
		{
			int c1 = (col < 0)? 0: col;
			int c2 = (col < 0)? base.Cols.Count-1: col;
			for (col = c1; col <= c2; col++)
				base.Cols[col].TextAlign = MapTextAlign(newVal);
		}
		public AlignmentSettings get_FixedAlignment(int col)
		{
			return MapTextAlign(base.Cols[col].TextAlignFixed);
		}
		public void set_FixedAlignment(int col, AlignmentSettings newVal)
		{
			int c1 = (col < 0)? 0: col;
			int c2 = (col < 0)? base.Cols.Count-1: col;
			for (col = c1; col <= c2; col++)
				base.Cols[col].TextAlignFixed = MapTextAlign(newVal);
		}
		public int get_ColIndent(int col)
		{
			CellStyle s = base.Cols[col].Style;
			if (s == null) s = Styles[CellStyleEnum.Normal];
			return s.Margins.Left;
		}
		public void set_ColIndent(int col, int newVal)
		{
			int c1 = (col < 0)? 0: col;
			int c2 = (col < 0)? base.Cols.Count-1: col;
			for (col = c1; col <= c2; col++)
			{
				CellStyle s = base.Cols[col].StyleNew;
				s.Margins.Left = s.Margins.Right = newVal;
			}
		}

        #endregion

        //----------------------------------------------------------
        #region ** cell properties

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public AlignmentSettings CellAlignment
		{
			get
			{
				CellStyle s = base.Selection.StyleDisplay;
				return MapTextAlign(s.TextAlign);
			}
			set
			{
				CellStyle s = GetCellStyleNew();
				s.TextAlign = MapTextAlign(value);
			}
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Color CellBackColor
		{
			get
			{
				CellStyle s = base.Selection.StyleDisplay;
				return s.BackColor;
			}
			set
			{
				CellStyle s = GetCellStyleNew();
				s.BackColor = value;
			}
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Color CellForeColor
		{
			get
			{
				CellStyle s = base.Selection.StyleDisplay;
				return s.ForeColor;
			}
			set
			{
				CellStyle s = GetCellStyleNew();
				s.ForeColor = value;
			}
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public TextStyleSettings CellTextStyle
		{
			get
			{
				CellStyle s = base.Selection.StyleDisplay;
				return GetTextStyle(s);
			}
			set
			{
				CellStyle s = GetCellStyleNew();
				SetTextStyle(s, value);
			}
		}
		[DefaultValue(false)] // <<B186>>
		public bool PicturesOver
		{
			get
			{
				return base.Styles.Normal.Display == C1.Win.FlexGrid.DisplayEnum.Overlay;
			}
			set 
			{
				base.Styles.Normal.Display = (value)
					? C1.Win.FlexGrid.DisplayEnum.Overlay
					: C1.Win.FlexGrid.DisplayEnum.Stack;
			}
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public PictureAlignmentSettings CellPictureAlignment
		{
			get
			{
				CellStyle s = base.Selection.StyleDisplay;
				return MapPictureAlign(s.ImageAlign);
			}
			set
			{
				CellStyle s = GetCellStyleNew();
				s.ImageAlign = MapPictureAlign(value);
			}
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Image CellPicture
		{
			get { return base.Selection.Image; }
			set
			{
				CellRange rg = (_fillStyle == FillStyleSettings.flexFillSingle)? base.CursorCell: base.Selection;
				rg.Image = value;
			}
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public CellCheckedSettings CellChecked
		{
			get { return (CellCheckedSettings)base.Selection.Checkbox; }
			set
			{
				CellRange rg = (_fillStyle == FillStyleSettings.flexFillSingle)? base.CursorCell: base.Selection;
				rg.Checkbox = (CheckEnum)value;
			}
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool CellFontBold
		{
			get { return base.Selection.StyleDisplay.Font.Bold; }
			set
			{
				CellStyle s = GetCellStyleNew();
				s.Font = ChangeFont(s.Font, FontStyle.Bold, value);
			}
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool CellFontItalic
		{
			get { return base.Selection.StyleDisplay.Font.Italic; }
			set
			{
				CellStyle s = GetCellStyleNew();
				s.Font = ChangeFont(s.Font, FontStyle.Italic, value);
			}
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool CellFontUnderline
		{
			get { return base.Selection.StyleDisplay.Font.Underline; }
			set
			{
				CellStyle s = GetCellStyleNew();
				s.Font = ChangeFont(s.Font, FontStyle.Underline, value);
			}
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool CellFontStrikethru
		{
			get { return base.Selection.StyleDisplay.Font.Strikeout; }
			set
			{
				CellStyle s = GetCellStyleNew();
				s.Font = ChangeFont(s.Font, FontStyle.Strikeout, value);
			}
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string CellFontName
		{
			get { return base.Selection.StyleDisplay.Font.Name; }
			set
			{
				CellStyle s = GetCellStyleNew();
				s.Font = ChangeFont(s.Font, value);
			}
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public float CellFontSize
		{
			get { return base.Selection.StyleDisplay.Font.Size; }
			set
			{
				CellStyle s = GetCellStyleNew();
				s.Font = ChangeFont(s.Font, value);
			}
		}
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Font CellFont
		{
			get { return base.Selection.StyleDisplay.Font; }
			set
			{
				CellStyle s = GetCellStyleNew();
				s.Font = value;
			}
		}

        #endregion

        //----------------------------------------------------------
        #region ** Cell property

		// Return a new Cell object with indexers that allow you to write:
		// [C#]	fg.Cell[CellPropertySettings.flexcpBackColor, 1, 1] = Color.Red;
		// [VB]	fg.Cell(CellPropertySettings.flexcpBackColor, 1, 1) = Color.Red
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Cell Cell
		{
			get { return new Cell(this); }
		}

		// get/set cell properties
		// (these can be called directly as well)
		public void set_Cell(CellPropertySettings setting, int row1, int col1, int row2, int col2, object newVal)
		{
			Font f;
			CellRange rg = GetCellRange(row1, col1, row2, col2);
			switch (setting)
			{
				case CellPropertySettings.flexcpText:

		            // paste as clip if (dest is multi-cell) and (there are separators);
				    // repeat text otherwise
					if (newVal is string && !rg.IsSingleCell)
					{
						char[] sepChars = { ClipSeparators[0], ClipSeparators[1] };
						if (((string)newVal).IndexOfAny(sepChars) > -1)
						{
							rg.Clip = (string)newVal;
							return;
						}
					}
					rg.Data = newVal;
					break;
				case CellPropertySettings.flexcpTextStyle:
					SetTextStyle(rg.StyleNew, (TextStyleSettings)newVal);
					break;
				case CellPropertySettings.flexcpAlignment:
					rg.StyleNew.TextAlign = MapTextAlign((AlignmentSettings)newVal);
					break;
				case CellPropertySettings.flexcpPicture:
					rg.Image = (Image)newVal;
					break;
				case CellPropertySettings.flexcpPictureAlignment:
					rg.StyleNew.ImageAlign = MapPictureAlign((PictureAlignmentSettings)newVal);
					break;
				case CellPropertySettings.flexcpChecked:
					rg.Checkbox = (CheckEnum)newVal;
					break;
				case CellPropertySettings.flexcpBackColor:
					rg.StyleNew.BackColor = (Color)newVal;
					break;
				case CellPropertySettings.flexcpForeColor:
					rg.StyleNew.ForeColor = (Color)newVal;
					break;
				case CellPropertySettings.flexcpFloodPercent:
					// ** deprecated
					break;
				case CellPropertySettings.flexcpFloodColor:
					// ** deprecated
					break;
				case CellPropertySettings.flexcpFont:
					rg.StyleNew.Font = (Font)newVal;
					break;
				case CellPropertySettings.flexcpFontName:
					f = rg.StyleDisplay.Font;
					if (f.Name == newVal.ToString()) return;
					rg.StyleNew.Font = ChangeFont(f, newVal.ToString());
					break;
				case CellPropertySettings.flexcpFontSize:
					f = rg.StyleDisplay.Font;
					if (f.Size == (float)newVal) return;
					rg.StyleNew.Font = ChangeFont(f, (float)newVal);
					break;
				case CellPropertySettings.flexcpFontBold:
					f = rg.StyleDisplay.Font;
					if (f.Bold == (bool)newVal) return;
					rg.StyleNew.Font = ChangeFont(f, FontStyle.Bold, (bool)newVal);
					break;
				case CellPropertySettings.flexcpFontItalic:
					f = rg.StyleDisplay.Font;
					if (f.Italic == (bool)newVal) return;
					rg.StyleNew.Font = ChangeFont(f, FontStyle.Italic, (bool)newVal);
					break;
				case CellPropertySettings.flexcpFontUnderline:
					f = rg.StyleDisplay.Font;
					if (f.Underline == (bool)newVal) return;
					rg.StyleNew.Font = ChangeFont(f, FontStyle.Underline, (bool)newVal);
					break;
				case CellPropertySettings.flexcpFontStrikethru:
					f = rg.StyleDisplay.Font;
					if (f.Strikeout == (bool)newVal) return;
					rg.StyleNew.Font = ChangeFont(f, FontStyle.Strikeout, (bool)newVal);
					break;
				case CellPropertySettings.flexcpFontWidth:
					// ** deprecated
					break;
				case CellPropertySettings.flexcpValue:
					SetData(row1, col1, newVal);
					break;
				case CellPropertySettings.flexcpData:
					rg.UserData = newVal;
					break;
				case CellPropertySettings.flexcpCustomFormat:
					if ((newVal == null) ||
						(newVal is bool && (bool)newVal == false) ||
						(newVal is int  && (int)newVal == 0))
						rg.Style = null;
					break;
				case CellPropertySettings.flexcpVariantValue:
					SetData(row1, col1, newVal);
					break;
				case CellPropertySettings.flexcpRefresh:
					Invalidate(rg);
					Update();
					break;
				case CellPropertySettings.flexcpSort:
					base.Sort(GetSortFlags((SortSettings)newVal), rg);
					break;
				case CellPropertySettings.flexcpWidth: // <<B167>>
					for (int c = col1; c <= col2; c++)
						base.Cols[c].Width = (int)(double)newVal;
					break;
				default:
					throw new ArgumentException(string.Format("Invalid 'setting' parameter in call to set_Cell: {0}", setting));
			}
		}
		public object get_Cell(CellPropertySettings setting, int row1, int col1, int row2, int col2)
		{
			CellRange rg = GetCellRange(row1, col1, row2, col2);
			switch (setting)
			{
				case CellPropertySettings.flexcpText:				return rg.Clip;
				case CellPropertySettings.flexcpTextStyle:			return GetTextStyle(rg.StyleDisplay);
				case CellPropertySettings.flexcpAlignment:			return MapTextAlign(rg.StyleDisplay.TextAlign);
				case CellPropertySettings.flexcpPicture:			return rg.Image;
				case CellPropertySettings.flexcpPictureAlignment:	return MapPictureAlign(rg.StyleDisplay.ImageAlign);
				case CellPropertySettings.flexcpChecked:			return (CellCheckedSettings)rg.Checkbox;
				case CellPropertySettings.flexcpBackColor:			return rg.StyleDisplay.BackColor;
				case CellPropertySettings.flexcpForeColor:			return rg.StyleDisplay.ForeColor;
				case CellPropertySettings.flexcpFloodPercent:		return 0; // ** deprecated
				case CellPropertySettings.flexcpFloodColor:			return 0; // ** deprecated
				case CellPropertySettings.flexcpFont:				return rg.StyleDisplay.Font;
				case CellPropertySettings.flexcpFontName:			return rg.StyleDisplay.Font.Name;
				case CellPropertySettings.flexcpFontSize:			return rg.StyleDisplay.Font.Size;
				case CellPropertySettings.flexcpFontBold:			return rg.StyleDisplay.Font.Bold;
				case CellPropertySettings.flexcpFontItalic:			return rg.StyleDisplay.Font.Italic;
				case CellPropertySettings.flexcpFontUnderline:		return rg.StyleDisplay.Font.Underline;
				case CellPropertySettings.flexcpFontStrikethru:		return rg.StyleDisplay.Font.Strikeout;
				case CellPropertySettings.flexcpFontWidth:			return 0; // ** deprecated
				case CellPropertySettings.flexcpValue:				return GetData(row1, col1);
				case CellPropertySettings.flexcpTextDisplay:		return GetDataDisplay(row1, col1);
				case CellPropertySettings.flexcpData:				return rg.UserData;
				case CellPropertySettings.flexcpCustomFormat:		return rg.Style != null;
				case CellPropertySettings.flexcpLeft:				return GetCellRect(row1, col1, false).Left;
				case CellPropertySettings.flexcpTop:				return GetCellRect(row1, col1, false).Top;
				case CellPropertySettings.flexcpWidth:				return GetCellRect(row1, col1, false).Width;
				case CellPropertySettings.flexcpHeight:				return GetCellRect(row1, col1, false).Height;
				case CellPropertySettings.flexcpVariantValue:		return GetData(row1, col1);
			}
			throw new ArgumentException("Invalid 'setting' parameter in call to get_Cell");
		}
		public void set_Cell(CellPropertySettings setting, int row, int col, object newVal)
		{
			set_Cell(setting, row, col, row, col, newVal);
		}
		public object get_Cell(CellPropertySettings setting, int row, int col)
		{
			return get_Cell(setting, row, col, row, col);
        }

        #endregion

        //----------------------------------------------------------
        #region ** tree/outlining

        [DefaultValue(OutlineBarSettings.flexOutlineBarSimple)]
        public OutlineBarSettings OutlineBar
        {
            get { return MapOutlineBar(base.Tree.Style); }
            set { base.Tree.Style = MapOutlineBar(value); }
        }
        public int OutlineCol
        {
            get { return base.Tree.Column; }
            set { base.Tree.Column = value; }
        }
        public Color TreeColor
        {
            get { return base.Tree.LineColor; }
            set { base.Tree.LineColor = value; }
        }
        public Image NodeClosedPicture
        {
            get { return base.Tree.NodeImageCollapsed; }
            set { base.Tree.NodeImageCollapsed = value; }
        }
        public Image NodeOpenPicture
        {
            get { return base.Tree.NodeImageExpanded; }
            set { base.Tree.NodeImageExpanded = value; }
        }
        public void Outline(int level)
        {
            base.Tree.Show(level);
        }
        public Node GetNode(int row)
        {
            return base.Rows[row].Node;
        }
        public Node GetNode()
        {
            return base.Rows[base.Row].Node;
        }
        public int GetNodeRow(int row, NodeTypeEnum which)
        {
            Node nd = base.Rows[row].Node;
            if (nd == null) return -1;
            nd = nd.GetNode(which);
            if (nd == null) return -1;
            return nd.Row.Index;
        }
        public bool get_IsSubtotal(int row)
        {
            return base.Rows[row].IsNode; // <<B208>>
        }
        public void set_IsSubtotal(int row, bool newVal)
        {
            base.Rows[row].IsNode = newVal;
        }
        public bool get_IsCollapsed(int row)
        {
            Node nd = base.Rows[row].Node;
            return (nd == null)? false: nd.Collapsed;
        }
        public void set_IsCollapsed(int row, bool newVal)
        {
            Node nd = base.Rows[row].Node;
            if (nd == null)
                throw new ArgumentException("Can't find node to collapse/expand.");
            nd.Collapsed = newVal;
        }
        public int get_RowOutlineLevel(int row)
        {
            Node nd = base.Rows[row].Node;
            return (nd == null)? -1: nd.Level;
        }
        public void set_RowOutlineLevel(int row, int newVal)
        {
            Node nd = base.Rows[row].Node;
            if (nd == null)
                throw new ArgumentException("Can't find node to set level.");
            nd.Level = newVal;
        }

        #endregion

        //----------------------------------------------------------
        #region ** printing

        public void PrintGrid(string docName, bool showDialog, int orientation, int marginLR, int marginTB)
        {
            // build flags to show dialog
            PrintGridFlags flags = PrintGridFlags.ActualSize;
            if (showDialog)
                flags |= PrintGridFlags.ShowPrintDialog;

            // adjust page settings
            PageSettings ps = base.PrintParameters.PrintDocument.DefaultPageSettings;

            // set orientation
            switch (orientation)
            {
                case 1:
                    ps.Landscape = false;
                    break;
                case 2:
                    ps.Landscape = true;
                    break;
            }

            // set margins (parameters are given in twips)
            marginLR = marginLR * ps.PrinterResolution.X / 1440;
            marginTB = marginTB * ps.PrinterResolution.Y / 1440;
            ps.Margins.Left = ps.Margins.Right  = marginLR;
            ps.Margins.Top  = ps.Margins.Bottom = marginTB;

            // build footer string
            string footer = docName + "\t\t{0}";

            // print the grid
            base.PrintGrid(docName, flags, "", footer);
        }
        public void PrintGrid(string docName, bool showDialog)
        {
            PrintGrid(docName, showDialog, 0, 1440, 1440);
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////
        //
        // utilities
        //
        ///////////////////////////////////////////////////////////////////////////////////////

        //----------------------------------------------------------
        #region ** get style for cursor or selection (depending on the FillStyle)

		protected CellStyle GetCellStyleNew()
		{
			return (FillStyle == FillStyleSettings.flexFillSingle)
				? base.CursorCell.StyleNew
				: base.Selection.StyleNew;
        }

        #endregion

        //----------------------------------------------------------
        #region ** map C1FlexGridClassic to and from C1FlexGrid enums

        protected AlignmentSettings MapTextAlign(TextAlignEnum ta)
		{
			return (ta >= TextAlignEnum.GeneralTop)
				? AlignmentSettings.flexAlignGeneral
				: (AlignmentSettings)ta;
		}
		protected TextAlignEnum MapTextAlign(AlignmentSettings al)
		{
			return (TextAlignEnum)al;
		}
		protected ImageAlignEnum MapPictureAlign(PictureAlignmentSettings pa)
		{
			switch (pa)
			{
				case PictureAlignmentSettings.flexPicAlignLeftTop:			return ImageAlignEnum.LeftTop;
				case PictureAlignmentSettings.flexPicAlignLeftCenter:		return ImageAlignEnum.LeftCenter;
				case PictureAlignmentSettings.flexPicAlignLeftBottom:		return ImageAlignEnum.LeftBottom;
				case PictureAlignmentSettings.flexPicAlignCenterTop:		return ImageAlignEnum.CenterTop;
				case PictureAlignmentSettings.flexPicAlignCenterCenter:		return ImageAlignEnum.CenterCenter;
				case PictureAlignmentSettings.flexPicAlignCenterBottom:		return ImageAlignEnum.CenterBottom;
				case PictureAlignmentSettings.flexPicAlignRightTop:			return ImageAlignEnum.RightTop;
				case PictureAlignmentSettings.flexPicAlignRightCenter:		return ImageAlignEnum.RightCenter;
				case PictureAlignmentSettings.flexPicAlignRightBottom:		return ImageAlignEnum.RightBottom;
				case PictureAlignmentSettings.flexPicAlignStretch:			return ImageAlignEnum.Stretch;
				case PictureAlignmentSettings.flexPicAlignTile:				return ImageAlignEnum.Tile;
			}
			return ImageAlignEnum.CenterCenter;
		}
		protected PictureAlignmentSettings MapPictureAlign(ImageAlignEnum ia)
		{
			switch (ia)
			{
				case ImageAlignEnum.LeftTop:		return PictureAlignmentSettings.flexPicAlignLeftTop;
				case ImageAlignEnum.LeftCenter:		return PictureAlignmentSettings.flexPicAlignLeftCenter;
				case ImageAlignEnum.LeftBottom:		return PictureAlignmentSettings.flexPicAlignLeftBottom;
				case ImageAlignEnum.CenterTop:		return PictureAlignmentSettings.flexPicAlignCenterTop;
				case ImageAlignEnum.CenterCenter:	return PictureAlignmentSettings.flexPicAlignCenterCenter;
				case ImageAlignEnum.CenterBottom:	return PictureAlignmentSettings.flexPicAlignCenterBottom;
				case ImageAlignEnum.RightTop:		return PictureAlignmentSettings.flexPicAlignRightTop;
				case ImageAlignEnum.RightCenter:	return PictureAlignmentSettings.flexPicAlignRightCenter;
				case ImageAlignEnum.RightBottom:	return PictureAlignmentSettings.flexPicAlignRightBottom;
				case ImageAlignEnum.Stretch:		return PictureAlignmentSettings.flexPicAlignStretch;
				case ImageAlignEnum.Tile:			return PictureAlignmentSettings.flexPicAlignTile;
			}
			return PictureAlignmentSettings.flexPicAlignCenterCenter;
		}
        protected OutlineBarSettings MapOutlineBar(TreeStyleFlags tsf)
        {
            switch (tsf)
            {
				case TreeStyleFlags.None:			return OutlineBarSettings.flexOutlineBarNone;
				case TreeStyleFlags.Complete:		return OutlineBarSettings.flexOutlineBarComplete;
				case TreeStyleFlags.Simple:			return OutlineBarSettings.flexOutlineBarSimple;
				case TreeStyleFlags.Symbols:		return OutlineBarSettings.flexOutlineBarSymbols;
				case TreeStyleFlags.CompleteLeaf:	return OutlineBarSettings.flexOutlineBarCompleteLeaf;
				case TreeStyleFlags.SimpleLeaf:		return OutlineBarSettings.flexOutlineBarSimpleLeaf;
            }
            return OutlineBarSettings.flexOutlineBarSimple;
        }
        protected TreeStyleFlags MapOutlineBar(OutlineBarSettings obs)
        {
            switch (obs)
            {
				case OutlineBarSettings.flexOutlineBarNone:				return TreeStyleFlags.None;
				case OutlineBarSettings.flexOutlineBarComplete:			return TreeStyleFlags.Complete;
				case OutlineBarSettings.flexOutlineBarSimple:			return TreeStyleFlags.Simple;
				case OutlineBarSettings.flexOutlineBarSymbols:			return TreeStyleFlags.Symbols;
				case OutlineBarSettings.flexOutlineBarCompleteLeaf:		return TreeStyleFlags.CompleteLeaf;
				case OutlineBarSettings.flexOutlineBarSimpleLeaf:		return TreeStyleFlags.SimpleLeaf;
				case OutlineBarSettings.flexOutlineBarSymbolsLeaf:		return TreeStyleFlags.Symbols;
            }
            return TreeStyleFlags.Simple;
        }

        #endregion

        //----------------------------------------------------------
        #region ** change font attributes

        protected static Font ChangeFont(Font f, string newVal)
		{
			return new Font(newVal, f.Size, f.Style);
		}
		protected static Font ChangeFont(Font f, float newVal)
		{
			return new Font(f.Name, newVal, f.Style);
		}
		protected static Font ChangeFont(Font f, FontStyle s, bool newVal)
		{
			return new Font(f, (newVal)? (f.Style | s): (f.Style & ~s));
		}
		protected static Font ChangeFont(Font f, FontStyle s)
		{
			return ChangeFont(f, s, true);
        }

        #endregion

        //----------------------------------------------------------
        #region ** override these to support Xml serialization <<B315>>

        override public void WriteXml(XmlTextWriter w)
        {
            C1FlexGrid g = new C1FlexGrid();
            g.DataSource = this;
            g.WriteXml(w);
        }
        override public void ReadXml(XmlDocument doc)
        {
            C1FlexGrid g = new C1FlexGrid();
            g.ReadXml(doc);
            this.DataSource = g;
        }
        override public void ReadXml(XmlNode node)
        {
            C1FlexGrid g = new C1FlexGrid();
            g.ReadXml(node);
            this.DataSource = g;
        }

        #endregion
    }

	/// <summary>
	/// Cell is a helper class that exposes indexers to implement
	/// the original Cell property.
	/// This allows you to write:
	/// [C#]	fg.Cell[CellPropertySettings.flexcpBackColor, 1, 1] = Color.Red;
	/// [VB]	fg.Cell(CellPropertySettings.flexcpBackColor, 1, 1) = Color.Red
	/// </summary>
	public class Cell
	{
		private C1FlexGridClassic m_fg;
		internal Cell(C1FlexGridClassic fg)
		{
			m_fg = fg;
		}

		// ** use Cell indexers to implement Cell property

		public object this [CellPropertySettings setting, int row1, int col1, int row2, int col2]
		{
			get { return m_fg.get_Cell(setting, row1, col1, row2, col2); }
			set { m_fg.set_Cell(setting, row1, col1, row2, col2, value); }
		}
		public object this [CellPropertySettings setting, int row, int col]
		{
			get { return m_fg.get_Cell(setting, row, col); }
			set { m_fg.set_Cell(setting, row, col, value); }
		}
	}
}