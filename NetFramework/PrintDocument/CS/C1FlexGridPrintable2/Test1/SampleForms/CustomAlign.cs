using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.FlexGrid;

namespace CustomAlign
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGridPrintable2 _flex;
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
            this._flex = new C1.Win.FlexGrid.C1FlexGridPrintable2();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            this._flex.Location = new System.Drawing.Point(0, 0);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 19;
            this._flex.Size = new System.Drawing.Size(552, 340);
            this._flex.TabIndex = 0;
            this._flex.OwnerDrawCell += new C1.Win.FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(552, 340);
            this.Controls.Add(this._flex);
            this.Name = "Form1";
            this.Text = "C1FlexGrid: Custom Align";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Form1_Load(object sender, System.EventArgs e)
		{
			CellStyle left = _flex.Styles.Add("Left");
			left.TextAlign = TextAlignEnum.LeftCenter;
			left.ForeColor = Color.Red;

			CellStyle right = _flex.Styles.Add("Right");
			right.TextAlign = TextAlignEnum.RightCenter;
			right.ForeColor = Color.Blue;

			CellStyle top = _flex.Styles.Add("Top");
			top.TextAlign = TextAlignEnum.CenterTop;
			top.ForeColor = Color.Green;

			CellStyle bottom = _flex.Styles.Add("Bottom");
			bottom.TextAlign = TextAlignEnum.CenterBottom;
			bottom.ForeColor = Color.Goldenrod;

			_flex.Cols[1].DataType = typeof(Point);
			_flex.Cols[2].DataType = typeof(Rectangle);
			_flex.Cols.Count = 3;
			Random rnd = new Random();
			for (int r = 0; r < _flex.Rows.Count; r++)
			{
				_flex[r, 1] = new Point(rnd.Next(100), rnd.Next(100));
				_flex[r, 2] = new Rectangle(rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100));
			}
			_flex.Rows.DefaultSize = 3 * _flex.Rows.DefaultSize;
		}

		private void _flex_OwnerDrawCell(object sender, C1.Win.FlexGrid.OwnerDrawCellEventArgs e)
		{
			object value = _flex[e.Row, e.Col];

			if (value is Point)
			{
				Point pt = (Point)value;
				e.DrawCell(DrawCellFlags.Background | DrawCellFlags.Border);
				_flex.Styles["Left"].Render(e.Graphics, e.Bounds, pt.X.ToString(), null, DrawCellFlags.Content);
				_flex.Styles["Right"].Render(e.Graphics, e.Bounds, pt.Y.ToString(), null, DrawCellFlags.Content);
			}
			if (value is Rectangle)
			{
				Rectangle rc = (Rectangle)value;
				e.DrawCell(DrawCellFlags.Background | DrawCellFlags.Border);
				_flex.Styles["Left"].Render(e.Graphics, e.Bounds, rc.X.ToString(), null, DrawCellFlags.Content);
				_flex.Styles["Right"].Render(e.Graphics, e.Bounds, rc.Y.ToString(), null, DrawCellFlags.Content);
				_flex.Styles["Top"].Render(e.Graphics, e.Bounds, rc.Width.ToString(), null, DrawCellFlags.Content);
				_flex.Styles["Bottom"].Render(e.Graphics, e.Bounds, rc.Height.ToString(), null, DrawCellFlags.Content);
			}
		
		}
	}
}
