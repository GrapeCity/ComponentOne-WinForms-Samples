using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

using C1.Excel;
using C1.Win.FlexGrid;

namespace FlexGrid
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button _btnLoad;
		private System.Windows.Forms.Button _btnSave;
		private C1XLBook _book;
		private System.Windows.Forms.Button _btnBatch;
		private System.Windows.Forms.TabControl _tab;
		private System.Windows.Forms.TabPage tabPage1;
		private C1FlexGrid _flex;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            _btnLoad = new Button();
            _btnSave = new Button();
            _btnBatch = new Button();
            _tab = new TabControl();
            tabPage1 = new TabPage();
            _flex = new C1FlexGrid();
            _tab.SuspendLayout();
            tabPage1.SuspendLayout();
            ((ISupportInitialize)_flex).BeginInit();
            SuspendLayout();
            // 
            // _btnLoad
            // 
            _btnLoad.Location = new Point(9, 10);
            _btnLoad.Name = "_btnLoad";
            _btnLoad.Size = new Size(116, 29);
            _btnLoad.TabIndex = 2;
            _btnLoad.Text = "&Load File...";
            _btnLoad.Click += _btnLoad_Click;
            // 
            // _btnSave
            // 
            _btnSave.Location = new Point(135, 10);
            _btnSave.Name = "_btnSave";
            _btnSave.Size = new Size(114, 29);
            _btnSave.TabIndex = 2;
            _btnSave.Text = "&Save File...";
            _btnSave.Click += _btnSave_Click;
            // 
            // _btnBatch
            // 
            _btnBatch.Location = new Point(356, 10);
            _btnBatch.Name = "_btnBatch";
            _btnBatch.Size = new Size(192, 29);
            _btnBatch.TabIndex = 3;
            _btnBatch.Text = "Load/Save Batch...";
            _btnBatch.Click += _btnBatch_Click;
            // 
            // _tab
            // 
            _tab.Alignment = TabAlignment.Bottom;
            _tab.Controls.Add(tabPage1);
            _tab.Dock = DockStyle.Fill;
            _tab.Location = new Point(0, 40);
            _tab.Multiline = true;
            _tab.Name = "_tab";
            _tab.Padding = new Point(0, 0);
            _tab.SelectedIndex = 0;
            _tab.Size = new Size(829, 627);
            _tab.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(_flex);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(821, 599);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sheet 1";
            // 
            // _flex
            // 
            _flex.AllowMerging = AllowMergingEnum.Spill;
            _flex.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            _flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
            _flex.Dock = DockStyle.Fill;
            _flex.Font = new Font("Microsoft Sans Serif", 8.25F);
            _flex.Location = new Point(0, 0);
            _flex.Name = "_flex";
            _flex.Rows.DefaultSize = 17;
            _flex.Size = new Size(821, 599);
            _flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            _flex.TabIndex = 0;
            _flex.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(829, 667);
            Controls.Add(_tab);
            Controls.Add(_btnBatch);
            Controls.Add(_btnLoad);
            Controls.Add(_btnSave);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Padding = new Padding(0, 40, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C1Excel: load and save XLS files";
            _tab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((ISupportInitialize)_flex).EndInit();
            ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		internal static string GetFilter(bool csv = false)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("Open XML MS Excel file (*.xlsx)|*.xlsx|");
			sb.Append("Binary MS Excel file (*.xls)|*.xls");
			if (csv)
				sb.Append("|Comma Separate Value file (*.csv)|*.csv");
			return sb.ToString();
		}

		// load a book
		private void _btnLoad_Click(object sender, System.EventArgs e)
		{
			// choose file
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = GetFilter(true);
			dlg.Title = "Save As MS Excel File";
			dlg.RestoreDirectory = true;
			dlg.DefaultExt = "xlsx";
			if (dlg.ShowDialog() != DialogResult.OK)
				return;

			// clear everything
			_book.Clear();
			_tab.TabPages.Clear();

			// load book
			if (Path.GetExtension(dlg.FileName) == "*.csv")
				_book.Sheets[0].LoadCsv(dlg.FileName);
			else
				_book.Load(dlg.FileName);

			// create one grid per sheet and add them to listbox
			foreach (XLSheet sheet in _book.Sheets)
			{
				// create a new grid for this sheet
				C1FlexGrid flex = new C1FlexGrid();
				flex.BorderStyle = _flex.BorderStyle;
				flex.AllowMerging = _flex.AllowMerging;
				flex.Dock = _flex.Dock;

				// load sheet into new grid
				LoadSheet(flex, sheet, true);

				// add new grid to the list
				TabPage pg = new TabPage();
				pg.Text = sheet.Name;
				flex.Name = sheet.Name;
				pg.Controls.Add(flex);
				_tab.TabPages.Add(pg);
			}

			// select current sheet
			_tab.SelectedIndex = (_book.Sheets.SelectedIndexes.Count > 0) ? _book.Sheets.SelectedIndexes[0] : 0;
		}

		// save a book
		private void _btnSave_Click(object sender, System.EventArgs e)
		{
			// choose file
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = GetFilter(true);
			dlg.Title = "Open MS Excel File";
			dlg.RestoreDirectory = true;
			dlg.DefaultExt = "xlsx";
			if (dlg.ShowDialog() != DialogResult.OK)
				return;

			// clear book
			_book.Clear();
			_book.Sheets.Clear();

			// copy grids to book sheets
			foreach (TabPage pg in _tab.TabPages)
			{
				C1FlexGrid grid = pg.Controls[0] as C1FlexGrid;
				XLSheet sheet = _book.Sheets.Add(grid.Name);
				SaveSheet(grid, sheet, false);
			}

			// save selected sheet index
			var indexes = (IList<int>)_book.Sheets.SelectedIndexes;
			indexes.Clear();
			indexes.Add(_tab.SelectedIndex);

			// save the book
			if (Path.GetExtension(dlg.FileName) == "*.csv")
				_book.Sheets[0].SaveCsv(dlg.FileName);
			else
				_book.Save(dlg.FileName);

			// preview saved book
			Process.Start(new ProcessStartInfo { FileName = dlg.FileName, UseShellExecute = true });
		}

		// load and save all books in a dir (good for testing)
		private void _btnBatch_Click(object sender, System.EventArgs e)
		{
			// choose file
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = GetFilter();
			dlg.Title = "Save As MS Excel File";
			dlg.RestoreDirectory = true;
			dlg.DefaultExt = "xlsx";
			if (dlg.ShowDialog() != DialogResult.OK)
				return;

			// load and save all Excel files in the selected directory
			string[] files = Directory.GetFiles(Path.GetDirectoryName(dlg.FileName), "*.xls");
			foreach (string file in files)
			{
				// load book
				_book.Load(file);

				// save book
				_book.Save(file + "_c1xl.xls");
			}
		}

		//===========================================================================================
		#region ** Load an XLSheet into a C1FlexGrid
		
		Hashtable _styles;

		// load sheet into grid
		private void LoadSheet(C1FlexGrid flex, XLSheet sheet, bool fixedCells)
		{
			// account for fixed cells
			int frows = flex.Rows.Fixed;
			int fcols = flex.Cols.Fixed;

			// copy dimensions
			flex.Rows.Count = sheet.Rows.Count    + frows;
			flex.Cols.Count = sheet.Columns.Count + fcols;

			// initialize fixed cells
			if (fixedCells && frows > 0 && fcols > 0)
			{
				flex.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
				for (int r = 1; r < flex.Rows.Count; r++)
				{
					flex[r, 0] = r;
				}
				for (int c = 1; c < flex.Cols.Count; c++)
				{
					string hdr = string.Format("{0}", (char)('A' + c - 1));
					flex[0, c] = hdr;
				}
			}

			// set default properties
			var font = sheet.Book.DefaultFont;
			var fs = FontStyle.Regular;
			if (font.Bold) fs |= FontStyle.Bold;
			if (font.Italic) fs |= FontStyle.Italic;
			if (font.Strikeout) fs |= FontStyle.Strikeout;
			if (font.Underline != XLUnderlineStyle.None) fs |= FontStyle.Underline;
			flex.Font = new Font(font.FontName, font.FontSize, fs);
            flex.Rows.DefaultSize = C1XLBook.TwipsToPixels(sheet.DefaultRowHeight);
            flex.Cols.DefaultSize = C1XLBook.TwipsToPixels(sheet.DefaultColumnWidth);

			// prepare to convert styles
			_styles = new Hashtable();

			// set row/column properties
			for (int r = 0; r < sheet.Rows.Count; r++)
			{
				// size/visibility
				Row   fr = flex.Rows[r + frows];
				XLRow xr = sheet.Rows[r];
				if (xr.Height >= 0)
                    fr.Height = C1XLBook.TwipsToPixels(xr.Height);
				fr.Visible = xr.Visible;

				// style
				CellStyle cs = StyleFromExcel(flex, xr.Style);
				if (cs != null)
				{
					//cs.DefinedElements &= ~StyleElementFlags.TextAlign; // << need to fix the grid
					fr.Style = cs;
				}
			}
			for (int c = 0; c < sheet.Columns.Count; c++)
			{
				// size/visibility
				Column   fc = flex.Cols[c + fcols];
				XLColumn xc = sheet.Columns[c];
				if (xc.Width >= 0)
					fc.Width = C1XLBook.TwipsToPixels(xc.Width);
				fc.Visible = xc.Visible;

				// style
				CellStyle cs = StyleFromExcel(flex, xc.Style);
				if (cs != null)
				{
					//cs.DefinedElements &= ~StyleElementFlags.TextAlign; // << need to fix the grid
					fc.Style = cs;
				}
			}

			// load cells
			for (int r = 0; r < sheet.Rows.Count; r++)
			{
				for (int c = 0; c < sheet.Columns.Count; c++)
				{
					// get cell
					XLCell cell = sheet.GetCell(r, c);
					if (cell == null) continue;

					// apply content
					flex[r + frows, c + fcols] = cell.Value;

					// apply style
					CellStyle cs = StyleFromExcel(flex, cell.Style);
					if (cs != null)
						flex.SetCellStyle(r + frows, c + fcols, cs);
				}
			}
		}

		// convert Excel style into FlexGrid style
		private CellStyle StyleFromExcel(C1FlexGrid flex, XLStyle style)
		{
			// sanity
			if (style == null)
				return null;

			// look it up on list
			if (_styles.Contains(style))
				return _styles[style] as CellStyle;

			// create new flex style
			CellStyle cs = flex.Styles.Add(_styles.Count.ToString());

			// set up new style
			var font = style.Font;
			var fs = FontStyle.Regular;
			if (font.Bold) fs |= FontStyle.Bold;
			if (font.Italic) fs |= FontStyle.Italic;
			if (font.Strikeout) fs |= FontStyle.Strikeout;
			if (font.Underline != XLUnderlineStyle.None) fs |= FontStyle.Underline;
			if (style.Font != null)						cs.Font = new Font(font.FontName, font.FontSize, fs);
			if (style.ForeColor != Color.Transparent)	cs.ForeColor = style.ForeColor;
			if (style.BackColor != Color.Transparent)	cs.BackColor = style.BackColor;
			if (style.Rotation == 90)					cs.TextDirection = TextDirectionEnum.Up;
			if (style.Rotation == 180)					cs.TextDirection = TextDirectionEnum.Down;
			if (style.Format != null && style.Format.Length > 0)
				cs.Format = XLStyle.FormatXLToDotNet(style.Format);
			switch (style.AlignHorz)
			{
				case XLAlignHorz.Center:
					cs.WordWrap = style.WordWrap;
					switch (style.AlignVert)
					{
						case XLAlignVert.Top:
							cs.TextAlign = TextAlignEnum.CenterTop;
							break;
						case XLAlignVert.Center:
							cs.TextAlign = TextAlignEnum.CenterCenter;
							break;
						default:
							cs.TextAlign = TextAlignEnum.CenterBottom;
							break;
					}
					break;
				case XLAlignHorz.Right:
					cs.WordWrap = style.WordWrap;
					switch (style.AlignVert)
					{
						case XLAlignVert.Top:
							cs.TextAlign = TextAlignEnum.RightTop;
							break;
						case XLAlignVert.Center:
							cs.TextAlign = TextAlignEnum.RightCenter;
							break;
						default:
							cs.TextAlign = TextAlignEnum.RightBottom;
							break;
					}
					break;
				case XLAlignHorz.Left:
					cs.WordWrap = style.WordWrap;
					switch (style.AlignVert)
					{
						case XLAlignVert.Top:
							cs.TextAlign = TextAlignEnum.LeftTop;
							break;
						case XLAlignVert.Center:
							cs.TextAlign = TextAlignEnum.LeftCenter;
							break;
						default:
							cs.TextAlign = TextAlignEnum.LeftBottom;
							break;
					}
					break;
				default:
					cs.WordWrap = style.WordWrap;
					switch (style.AlignVert)
					{
						case XLAlignVert.Top:
							cs.TextAlign = TextAlignEnum.GeneralTop;
							break;
						case XLAlignVert.Center:
							cs.TextAlign = TextAlignEnum.GeneralCenter;
							break;
						default:
							cs.TextAlign = TextAlignEnum.GeneralBottom;
							break;
					}
					break;
			}
		
			// save it
			_styles.Add(style, cs);

			// return it
			return cs;
		}
		#endregion

		//===========================================================================================
		#region ** Save a C1FlexGrid into an XLSheet
		private void SaveSheet(C1FlexGrid flex, XLSheet sheet, bool fixedCells)
		{
			// account for fixed cells
			int frows = flex.Rows.Fixed;
			int fcols = flex.Cols.Fixed;
			if (fixedCells) frows = fcols = 0;

			// copy dimensions
			int lastRow = flex.Rows.Count - frows - 1;
			int lastCol = flex.Cols.Count - fcols - 1;
			if (lastRow < 0 || lastCol < 0) return;
			XLCell cell = sheet[lastRow, lastCol];

			// set default properties
			var f = flex.Font;
			var fs = XLFontScript.None;
			var us = XLUnderlineStyle.None;
			if (f.Underline) us = XLUnderlineStyle.Single;
			sheet.Book.DefaultFont   = new XLFont(f.Name, f.Size, f.Bold, f.Italic, f.Strikeout, fs, us, Color.Black);
			sheet.DefaultRowHeight   = C1XLBook.PixelsToTwips(flex.Rows.DefaultSize);
			sheet.DefaultColumnWidth = C1XLBook.PixelsToTwips(flex.Cols.DefaultSize);

			// prepare to convert styles
			_styles = new Hashtable();

			// set row/column properties
			for (int r = frows; r < flex.Rows.Count; r++)
			{
				// size/visibility
				Row   fr = flex.Rows[r];
				XLRow xr = sheet.Rows[r - frows];
				if (fr.Height >= 0)
					xr.Height = C1XLBook.PixelsToTwips(fr.Height);
				xr.Visible = fr.Visible;

				// style
				XLStyle xs = StyleFromFlex(fr.Style);
				if (xs != null)
					xr.Style = xs;
			}
			for (int c = fcols; c < flex.Cols.Count; c++)
			{
				// size/visibility
				Column   fc = flex.Cols[c];
				XLColumn xc = sheet.Columns[c - fcols];
				if (fc.Width >= 0)
					xc.Width = C1XLBook.PixelsToTwips(fc.Width);
				xc.Visible = fc.Visible;

				// style
				XLStyle xs = StyleFromFlex(fc.Style);
				if (xs != null)
					xc.Style = xs;
			}

			// load cells
			for (int r = frows; r < flex.Rows.Count; r++)
			{
				for (int c = fcols; c < flex.Cols.Count; c++)
				{
					// get cell
					cell = sheet[r - frows, c - fcols];

					// apply content
					cell.Value = flex[r, c];

					// apply style
					XLStyle xs = StyleFromFlex(flex.GetCellStyle(r, c));
					if (xs != null)
						cell.Style = xs;
				}
			}
		}

		// convert FlexGrid style into Excel style
		private XLStyle StyleFromFlex(CellStyle style)
		{
			// sanity
			if (style == null)
				return null;

			// look it up on list
			if (_styles.Contains(style))
				return _styles[style] as XLStyle;

			// create new Excel style
			XLStyle xs = new XLStyle(_book);

			// set up new style
			var f = style.Font;
			var fs = XLFontScript.None;
			var us = XLUnderlineStyle.None;
			if (f.Underline) us = XLUnderlineStyle.Single;
			xs.Font = new XLFont(f.Name, f.Size, f.Bold, f.Italic, f.Strikeout, fs, us, xs.ForeColor);
			if (style.BackColor.ToArgb() != SystemColors.Window.ToArgb())
			{
				xs.BackColor = style.BackColor;
			}
			xs.WordWrap = style.WordWrap;
			xs.Format = XLStyle.FormatDotNetToXL(style.Format);
			switch (style.TextDirection)
			{
				case TextDirectionEnum.Up:
					xs.Rotation = 90;
					break;
				case TextDirectionEnum.Down:
					xs.Rotation = 180;
					break;
			}
			switch (style.TextAlign)
			{
				case TextAlignEnum.CenterBottom:
					xs.AlignHorz = XLAlignHorz.Center;
					xs.AlignVert = XLAlignVert.Bottom;
					break;
				case TextAlignEnum.CenterCenter:
					xs.AlignHorz = XLAlignHorz.Center;
					xs.AlignVert = XLAlignVert.Center;
					break;
				case TextAlignEnum.CenterTop:
					xs.AlignHorz = XLAlignHorz.Center;
					xs.AlignVert = XLAlignVert.Top;
					break;
				case TextAlignEnum.GeneralBottom:
					xs.AlignHorz = XLAlignHorz.General;
					xs.AlignVert = XLAlignVert.Bottom;
					break;
				case TextAlignEnum.GeneralCenter:
					xs.AlignHorz = XLAlignHorz.General;
					xs.AlignVert = XLAlignVert.Center;
					break;
				case TextAlignEnum.GeneralTop:
					xs.AlignHorz = XLAlignHorz.General;
					xs.AlignVert = XLAlignVert.Top;
					break;
				case TextAlignEnum.LeftBottom:
					xs.AlignHorz = XLAlignHorz.Left;
					xs.AlignVert = XLAlignVert.Bottom;
					break;
				case TextAlignEnum.LeftCenter:
					xs.AlignHorz = XLAlignHorz.Left;
					xs.AlignVert = XLAlignVert.Center;
					break;
				case TextAlignEnum.LeftTop:
					xs.AlignHorz = XLAlignHorz.Left;
					xs.AlignVert = XLAlignVert.Top;
					break;
				case TextAlignEnum.RightBottom:
					xs.AlignHorz = XLAlignHorz.Right;
					xs.AlignVert = XLAlignVert.Bottom;
					break;
				case TextAlignEnum.RightCenter:
					xs.AlignHorz = XLAlignHorz.Right;
					xs.AlignVert = XLAlignVert.Center;
					break;
				case TextAlignEnum.RightTop:
					xs.AlignHorz = XLAlignHorz.Right;
					xs.AlignVert = XLAlignVert.Top;
					break;
				default:
					Debug.Assert(false);
					break;
			}

			// save it
			_styles.Add(style, xs);

			// return it
			return xs;
		}
		#endregion
	}
}
