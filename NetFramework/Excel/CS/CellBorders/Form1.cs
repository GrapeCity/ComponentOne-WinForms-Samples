using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.FlexGrid;
using C1.Excel;

namespace CellBorders
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.FlexGrid.C1FlexGrid _flex;

        // border info
        private SolidBrush  _bdrBrush;
        private int         _bdrOutside;
        private int         _bdrInside;
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ToolBarButton tbBorderOn;
        private System.Windows.Forms.ToolBarButton tbBorderOff;
        private System.Windows.Forms.ToolBarButton tbSep1;
        private System.Windows.Forms.ToolBarButton tbBorderColor;
        private System.Windows.Forms.ToolBarButton tbIncreaseOut;
        private System.Windows.Forms.ToolBarButton tbDecreaseOut;
        private System.Windows.Forms.ToolBarButton tbIncreaseIn;
        private System.Windows.Forms.ToolBarButton tbDecreaseIn;
        private System.Windows.Forms.ToolBarButton tbSep2;
        private System.Windows.Forms.ImageList imgToolbar;
		private System.Windows.Forms.ToolBarButton tbSep3;
		private System.Windows.Forms.ToolBarButton tbExcel;
		private C1.Excel.C1XLBook _c1xl;
        private System.ComponentModel.IContainer components;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this._flex = new C1.Win.FlexGrid.C1FlexGrid();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.tbBorderOn = new System.Windows.Forms.ToolBarButton();
            this.tbBorderOff = new System.Windows.Forms.ToolBarButton();
            this.tbSep1 = new System.Windows.Forms.ToolBarButton();
            this.tbBorderColor = new System.Windows.Forms.ToolBarButton();
            this.tbSep2 = new System.Windows.Forms.ToolBarButton();
            this.tbIncreaseOut = new System.Windows.Forms.ToolBarButton();
            this.tbDecreaseOut = new System.Windows.Forms.ToolBarButton();
            this.tbIncreaseIn = new System.Windows.Forms.ToolBarButton();
            this.tbDecreaseIn = new System.Windows.Forms.ToolBarButton();
            this.tbSep3 = new System.Windows.Forms.ToolBarButton();
            this.tbExcel = new System.Windows.Forms.ToolBarButton();
            this.imgToolbar = new System.Windows.Forms.ImageList(this.components);
            this._c1xl = new C1.Excel.C1XLBook();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:27;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 28);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 17;
            this._flex.Size = new System.Drawing.Size(569, 335);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            this._flex.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._flex.Tree.NodeImageCollapsed = ((System.Drawing.Image)(resources.GetObject("_flex.Tree.NodeImageCollapsed")));
            this._flex.Tree.NodeImageExpanded = ((System.Drawing.Image)(resources.GetObject("_flex.Tree.NodeImageExpanded")));
            this._flex.OwnerDrawCell += new C1.Win.FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
            // 
            // toolBar1
            // 
            this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbBorderOn,
            this.tbBorderOff,
            this.tbSep1,
            this.tbBorderColor,
            this.tbSep2,
            this.tbIncreaseOut,
            this.tbDecreaseOut,
            this.tbIncreaseIn,
            this.tbDecreaseIn,
            this.tbSep3,
            this.tbExcel});
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imgToolbar;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(569, 28);
            this.toolBar1.TabIndex = 2;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // tbBorderOn
            // 
            this.tbBorderOn.ImageIndex = 0;
            this.tbBorderOn.Name = "tbBorderOn";
            this.tbBorderOn.ToolTipText = "Apply Border";
            // 
            // tbBorderOff
            // 
            this.tbBorderOff.ImageIndex = 1;
            this.tbBorderOff.Name = "tbBorderOff";
            this.tbBorderOff.ToolTipText = "Remove Border";
            // 
            // tbSep1
            // 
            this.tbSep1.Name = "tbSep1";
            this.tbSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbBorderColor
            // 
            this.tbBorderColor.ImageIndex = 2;
            this.tbBorderColor.Name = "tbBorderColor";
            this.tbBorderColor.ToolTipText = "Select Border Color";
            // 
            // tbSep2
            // 
            this.tbSep2.Name = "tbSep2";
            this.tbSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbIncreaseOut
            // 
            this.tbIncreaseOut.ImageIndex = 3;
            this.tbIncreaseOut.Name = "tbIncreaseOut";
            this.tbIncreaseOut.ToolTipText = "Thicker outer border";
            // 
            // tbDecreaseOut
            // 
            this.tbDecreaseOut.ImageIndex = 4;
            this.tbDecreaseOut.Name = "tbDecreaseOut";
            this.tbDecreaseOut.ToolTipText = "Thinner outer border";
            // 
            // tbIncreaseIn
            // 
            this.tbIncreaseIn.ImageIndex = 5;
            this.tbIncreaseIn.Name = "tbIncreaseIn";
            this.tbIncreaseIn.ToolTipText = "Thicker inner border";
            // 
            // tbDecreaseIn
            // 
            this.tbDecreaseIn.ImageIndex = 6;
            this.tbDecreaseIn.Name = "tbDecreaseIn";
            this.tbDecreaseIn.ToolTipText = "Thinner inner border";
            // 
            // tbSep3
            // 
            this.tbSep3.Name = "tbSep3";
            this.tbSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbExcel
            // 
            this.tbExcel.ImageIndex = 7;
            this.tbExcel.Name = "tbExcel";
            this.tbExcel.ToolTipText = "Save Excel File";
            // 
            // imgToolbar
            // 
            this.imgToolbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgToolbar.ImageStream")));
            this.imgToolbar.TransparentColor = System.Drawing.Color.White;
            this.imgToolbar.Images.SetKeyName(0, "");
            this.imgToolbar.Images.SetKeyName(1, "");
            this.imgToolbar.Images.SetKeyName(2, "");
            this.imgToolbar.Images.SetKeyName(3, "");
            this.imgToolbar.Images.SetKeyName(4, "");
            this.imgToolbar.Images.SetKeyName(5, "");
            this.imgToolbar.Images.SetKeyName(6, "");
            this.imgToolbar.Images.SetKeyName(7, "");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(569, 363);
            this.Controls.Add(this._flex);
            this.Controls.Add(this.toolBar1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Excel: Custom cell borders";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        // initialize application
        private void Form1_Load(object sender, System.EventArgs e)
        {
            // create border style
            CellStyle s = _flex.Styles.Add("Border");
            _bdrBrush = new SolidBrush(Color.Red);
            _bdrOutside = 3;
            _bdrInside = 1;

            // enable ownerdraw
            _flex.DrawMode = DrawModeEnum.OwnerDraw;
        }

        // custom drawing for cells with custom borders
        private void _flex_OwnerDrawCell(object sender, C1.Win.FlexGrid.OwnerDrawCellEventArgs e)
        {
            // we only want cells with style set to "Border" 
            CellStyle s = _flex.GetCellStyle(e.Row, e.Col);
            if (s == null || s.Name != "Border")
                return;

            // draw cell content as usual
            e.DrawCell();

            // get custom border widths for this cell
            // (depends on neighbor cells)
            Margins m = GetBorderMargins(e.Row, e.Col);

            // draw custom borders
			Rectangle rc;
			Graphics g = e.Graphics;
			if (m.Top > 0)
            {
                rc = e.Bounds;
                rc.Height = m.Top;
                g.FillRectangle(_bdrBrush, rc);
            }
            if (m.Left > 0)
            {
                rc = e.Bounds;
                rc.Width = m.Left;
                g.FillRectangle(_bdrBrush, rc);
            }
            if (m.Bottom > 0)
            {
                rc = e.Bounds;
                rc.Y = rc.Bottom - m.Bottom;
                rc.Height = m.Bottom;
                g.FillRectangle(_bdrBrush, rc);
            }
            if (m.Right > 0)
            {
                rc = e.Bounds;
                rc.X = rc.Right - m.Right;
                rc.Width = m.Right;
                g.FillRectangle(_bdrBrush, rc);
            }
        }

        // calculate border widths taking neighbor cells into account
        private Margins GetBorderMargins(int row, int col)
        {
            // initialize return value
            Margins m = new Margins(0, 0, 0, 0);

            // check whether this cell has a border
            CellRange rg = _flex.GetCellRange(row, col);
            if (rg.Style == null || rg.Style.Name != "Border")
                return m;

            // check whether this cell is at the top of the range
            m.Top = _bdrOutside;
            if (row > _flex.Rows.Fixed)
            {
                rg.r1 = rg.r2 = row-1;
                if (rg.Style != null && rg.Style.Name == "Border")
                    m.Top = 0;
                rg.r1 = rg.r2 = row;
            }

            // check whether this cell is at the left of the range
            m.Left = _bdrOutside;
            if (col > _flex.Cols.Fixed)
            {
                rg.c1 = rg.c2 = col-1;
                if (rg.Style != null && rg.Style.Name == "Border")
                    m.Left = 0;
                rg.c1 = rg.c2 = col;
            }

            // check whether this cell is at the bottom of the range
            m.Bottom = _bdrOutside;
            if (row < _flex.Rows.Count-1)
            {
                rg.r1 = rg.r2 = row+1;
                if (rg.Style != null && rg.Style.Name == "Border")
                    m.Bottom = _bdrInside;
                rg.r1 = rg.r2 = row;
            }

            // check whether this cell is at the right of the range
            m.Right = _bdrOutside;
            if (col < _flex.Cols.Count-1)
            {
                rg.c1 = rg.c2 = col+1;
                if (rg.Style != null && rg.Style.Name == "Border")
                    m.Right = _bdrInside;
                rg.c1 = rg.c2 = col;
            }

            // done
            return m;
        }

        // handle toolbar
        private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
        {
            // apply border to current selection
            if (e.Button == tbBorderOn)
            {
                // assign border style to selection
                CellRange rg = _flex.Selection;
                rg.Style = _flex.Styles["Border"];
            }

            // remove border from current selection
            if (e.Button == tbBorderOff)
            {
                // remove border style from selection
                CellRange rg = _flex.Selection;
                rg.Style = null;
            }

            // change border color
            if (e.Button == tbBorderColor)
            {
                // show color picker dialog
                ColorDialog dlg = new ColorDialog();
                dlg.Color = _bdrBrush.Color;

                // if the user clicked OK, set new border color
                if (dlg.ShowDialog() == DialogResult.OK)
                    _bdrBrush.Color = dlg.Color;
            }

            // thicker/thinner outer border
            if (e.Button == tbIncreaseOut)
            {
                if (_bdrOutside < 10)
                    _bdrOutside++;
            }
            if (e.Button == tbDecreaseOut)
            {
                if (_bdrOutside > 0)
                    _bdrOutside--;
            }

            // thicker/thinner inner border
            if (e.Button == tbIncreaseIn)
            {
                if (_bdrInside < 10)
                    _bdrInside++;
            }
            if (e.Button == tbDecreaseIn)
            {
                if (_bdrInside > 0)
                    _bdrInside--;
            }

			// save current sheet (with borders) into an Excel file
			if (e.Button == tbExcel)
			{
				_c1xl.Clear();
				_c1xl.DefaultFont = new XLFont(_flex.Font.FontFamily.Name, _flex.Font.Size);

				XLSheet sheet = _c1xl.Sheets[0];
				for (int c = 0; c < _flex.Cols.Count; c++)
				{
					// save column width (twips)
					sheet.Columns[c].Width = (int)(_flex.Cols[c].WidthDisplay / 96f * 1440);

					// save cells on this column
					for (int r = 0; r < _flex.Rows.Count; r++)
					{
						// save cell value
						sheet[r,c].Value = _flex[r,c];

						// we only want cells with style set to "Border" 
						CellStyle s = _flex.GetCellStyle(r, c);
						if (s == null || s.Name != "Border")
							continue;

						// get custom border widths for this cell
						// (depends on neighbor cells)
						Margins m = GetBorderMargins(r, c);

						// create stytle for this cell
						XLStyle xs = new XLStyle(_c1xl);
						if (m.Top > 0)
						{
							xs.BorderTop = GetLineStyle(m.Top);
							xs.BorderColorTop = _bdrBrush.Color;
						}
						if (m.Left > 0)
						{
							xs.BorderLeft = GetLineStyle(m.Left);
							xs.BorderColorLeft = _bdrBrush.Color;
						}
						if (m.Right > 0)
						{
							xs.BorderRight = GetLineStyle(m.Right);
							xs.BorderColorRight = _bdrBrush.Color;
						}
						if (m.Bottom > 0)
						{
							xs.BorderBottom = GetLineStyle(m.Bottom);
							xs.BorderColorBottom = _bdrBrush.Color;
						}
						sheet[r,c].Style = xs;
					}
				}

				// save book
				string fileName = Application.StartupPath + @"\borders.xls";
				_c1xl.Save(fileName);
				System.Diagnostics.Process.Start(fileName);

			}

            // repaint control to show changes
            _flex.Invalidate();
        }

		// map border width into Excel border widths
		private XLLineStyle GetLineStyle(int width)
		{
			switch (width)
			{
				case 0:
					return XLLineStyle.Hair;
				case 1: 
					return XLLineStyle.Thin;
				case 2:
					return XLLineStyle.Medium;
			}
			return XLLineStyle.Thick;
		}
    }
}
