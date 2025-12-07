using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.FlexGrid;

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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
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
            this.imgToolbar = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:27;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 25);
            this._flex.Name = "_flex";
            this._flex.Size = new System.Drawing.Size(624, 359);
            this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
            this._flex.TabIndex = 0;
            this._flex.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
            this._flex.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("_flex.Tree.NodeImageCollapsed")));
            this._flex.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("_flex.Tree.NodeImageExpanded")));
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
                                                                                        this.tbDecreaseIn});
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imgToolbar;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(624, 25);
            this.toolBar1.TabIndex = 2;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // tbBorderOn
            // 
            this.tbBorderOn.ImageIndex = 0;
            this.tbBorderOn.ToolTipText = "Apply Border";
            // 
            // tbBorderOff
            // 
            this.tbBorderOff.ImageIndex = 1;
            this.tbBorderOff.ToolTipText = "Remove Border";
            // 
            // tbSep1
            // 
            this.tbSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbBorderColor
            // 
            this.tbBorderColor.ImageIndex = 2;
            this.tbBorderColor.ToolTipText = "Select Border Color";
            // 
            // tbSep2
            // 
            this.tbSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbIncreaseOut
            // 
            this.tbIncreaseOut.ImageIndex = 3;
            this.tbIncreaseOut.ToolTipText = "Thicker outer border";
            // 
            // tbDecreaseOut
            // 
            this.tbDecreaseOut.ImageIndex = 4;
            this.tbDecreaseOut.ToolTipText = "Thinner outer border";
            // 
            // tbIncreaseIn
            // 
            this.tbIncreaseIn.ImageIndex = 5;
            this.tbIncreaseIn.ToolTipText = "Thicker inner border";
            // 
            // tbDecreaseIn
            // 
            this.tbDecreaseIn.ImageIndex = 6;
            this.tbDecreaseIn.ToolTipText = "Thinner inner border";
            // 
            // imgToolbar
            // 
            this.imgToolbar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgToolbar.ImageSize = new System.Drawing.Size(16, 16);
            this.imgToolbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgToolbar.ImageStream")));
            this.imgToolbar.TransparentColor = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(624, 384);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this._flex,
                                                                          this.toolBar1});
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Custom cell borders";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

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
        Margins _m = new Margins(0,0,0,0);
        private Margins GetBorderMargins(int row, int col)
        {
            // initialize return value
            _m.Left = _m.Right = _m.Top = _m.Bottom = 0;

            // check whether this cell has a border
            CellRange rg = _flex.GetCellRange(row, col);
            if (rg.Style == null || rg.Style.Name != "Border")
                return _m;

            // check whether this cell is at the top of the range
            _m.Top = _bdrOutside;
            if (row > _flex.Rows.Fixed)
            {
                rg.r1 = rg.r2 = row-1;
                if (rg.Style != null && rg.Style.Name == "Border")
                    _m.Top = 0;
                rg.r1 = rg.r2 = row;
            }

            // check whether this cell is at the left of the range
            _m.Left = _bdrOutside;
            if (col > _flex.Cols.Fixed)
            {
                rg.c1 = rg.c2 = col-1;
                if (rg.Style != null && rg.Style.Name == "Border")
                    _m.Left = 0;
                rg.c1 = rg.c2 = col;
            }

            // check whether this cell is at the bottom of the range
            _m.Bottom = _bdrOutside;
            if (row < _flex.Rows.Count-1)
            {
                rg.r1 = rg.r2 = row+1;
                if (rg.Style != null && rg.Style.Name == "Border")
                    _m.Bottom = _bdrInside;
                rg.r1 = rg.r2 = row;
            }

            // check whether this cell is at the right of the range
            _m.Right = _bdrOutside;
            if (col < _flex.Cols.Count-1)
            {
                rg.c1 = rg.c2 = col+1;
                if (rg.Style != null && rg.Style.Name == "Border")
                    _m.Right = _bdrInside;
                rg.c1 = rg.c2 = col;
            }

            // done
            return _m;
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

            // repaint control to show changes
            _flex.Invalidate();
        }
    }
}
