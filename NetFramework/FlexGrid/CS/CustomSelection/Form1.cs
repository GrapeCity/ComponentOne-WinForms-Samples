using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;

namespace CustomSelection
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.C1FlexGrid.C1FlexGrid _flex;
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
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.BackColor = System.Drawing.SystemColors.Window;
            this._flex.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Name = "_flex";
            this._flex.Size = new System.Drawing.Size(600, 392);
            this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
            this._flex.TabIndex = 0;
            this._flex.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
            this._flex.AfterSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this._flex_AfterSelChange);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(600, 392);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this._flex});
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Custom Selection";
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

        private void Form1_Load(object sender, System.EventArgs e)
        {
            _flex.HighLight = HighLightEnum.Never;
            _flex.DrawMode = DrawModeEnum.OwnerDraw;
        }

        private void _flex_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
        {
            if (IsCellSelected(e.Row, e.Col))
                e.Style = _flex.Styles.Highlight;
        }

        private void _flex_AfterSelChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
        {
            // invalidate whole rows between old and new ranges
            // (more efficient than simply calling Invalidate())
            int r1 = Math.Min(e.OldRange.TopRow, e.NewRange.TopRow);
            int r2 = Math.Max(e.OldRange.BottomRow, e.NewRange.BottomRow);
            int c1 = _flex.Cols.Fixed;
            int c2 = _flex.Cols.Count-1;
            _flex.Invalidate(r1, c1, r2, c2);
        }

        private bool IsCellSelected(int row, int col)
        {
            // skip fixed cells
            if (col < _flex.Cols.Fixed || row < _flex.Rows.Fixed) return false;

            // skip focus cell
            if (row == _flex.Row && col == _flex.Col) return false;

            // calculate sequential index for selection and current cell
            int cols = _flex.Cols.Count;
            int n    = row * cols + col;
            int n1   = _flex.Row * cols + _flex.Col;
            int n2   = _flex.RowSel * cols + _flex.ColSel;

            // cell is selected if it is within selection
            return n >= Math.Min(n1, n2) && n <= Math.Max(n1, n2);
        }
    }
}
