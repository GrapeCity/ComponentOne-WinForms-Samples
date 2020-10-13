using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.C1FlexGrid;

namespace MergeStyles
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox _btnBorders;
		private System.Windows.Forms.CheckBox _btnStyles;
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
			this.panel1 = new System.Windows.Forms.Panel();
			this._btnBorders = new System.Windows.Forms.CheckBox();
			this._btnStyles = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both;
			this._flex.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly;
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = @"10,1,0,0,0,75,Columns:0{Width:23;}	1{Width:121;TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}	2{Width:40;TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}	3{Width:40;TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}	4{Width:40;TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}	5{Width:40;TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}	6{Width:40;TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}	7{Width:40;TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}	8{Width:40;TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}	9{Width:40;TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}	";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Rows.Count = 20;
			this._flex.Rows.Fixed = 2;
			this._flex.ShowCursor = true;
			this._flex.Size = new System.Drawing.Size(488, 317);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this._btnBorders,
																				 this._btnStyles});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 317);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(488, 40);
			this.panel1.TabIndex = 2;
			// 
			// _btnBorders
			// 
			this._btnBorders.Appearance = System.Windows.Forms.Appearance.Button;
			this._btnBorders.Location = new System.Drawing.Point(168, 8);
			this._btnBorders.Name = "_btnBorders";
			this._btnBorders.Size = new System.Drawing.Size(128, 24);
			this._btnBorders.TabIndex = 1;
			this._btnBorders.Text = "Draw Borders";
			this._btnBorders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._btnBorders.CheckedChanged += new System.EventHandler(this._btnBorders_CheckedChanged);
			// 
			// _btnStyles
			// 
			this._btnStyles.Appearance = System.Windows.Forms.Appearance.Button;
			this._btnStyles.Location = new System.Drawing.Point(16, 8);
			this._btnStyles.Name = "_btnStyles";
			this._btnStyles.Size = new System.Drawing.Size(128, 24);
			this._btnStyles.TabIndex = 1;
			this._btnStyles.Text = "Apply Styles";
			this._btnStyles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._btnStyles.CheckedChanged += new System.EventHandler(this._btnStyles_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(488, 357);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex,
																		  this.panel1});
			this.Name = "Form1";
			this.Text = "C1FlexGrid: Merged Styles and Borders";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
			this.panel1.ResumeLayout(false);
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
			// set up to merge headers
			_flex.Cols[0].AllowMerging = _flex.Cols[1].AllowMerging = true;
			_flex.Rows[0].AllowMerging = _flex.Rows[1].AllowMerging = true;

			// set header info
			_flex[0,0] = _flex[1,0] = " ";
			_flex[0,1] = _flex[1,1] = "Company";
			_flex[0,2] = _flex[0,3] = _flex[0,4] = _flex[0,5] = "Sales";
			_flex[0,6] = _flex[0,7] = _flex[0,8] = _flex[0,9] = "Purchases";
			_flex[1,2] = _flex[1,6] = "Q1";
			_flex[1,3] = _flex[1,7] = "Q2";
			_flex[1,4] = _flex[1,8] = "Q3";
			_flex[1,5] = _flex[1,9] = "Q4";

			// fill grid with data
			for (int r = _flex.Rows.Fixed; r < _flex.Rows.Count; r++)
				for (int c = _flex.Cols.Fixed; c < _flex.Cols.Count; c++)
					_flex[r,c] = string.Format("[{0},{1}]", r, c);

			// create custom styles
			CellStyle s = _flex.Styles.Add("RightAlign");
			s.TextAlign = TextAlignEnum.RightCenter;
			s = _flex.Styles.Add("WordWrap");
			s.WordWrap = true;
			s = _flex.Styles.Add("Red");
			s.BackColor = Color.Red;
			s = _flex.Styles.Add("Green");
			s.BackColor = Color.Green;
		}

		private void _btnStyles_CheckedChanged(object sender, System.EventArgs e)
		{
			// apply/remove custom styles to columns and rows
			if (_btnStyles.Checked)
			{
				_flex.Cols[1].Style = _flex.Styles["RightAlign"];
				_flex.Cols[2].Style = _flex.Styles["WordWrap"];
				_flex.Rows[2].Style = _flex.Styles["Red"];
				_flex.Rows[3].Style = _flex.Styles["Green"];
			}
			else
			{
				_flex.Cols[1].Style = null;
				_flex.Cols[2].Style = null;
				_flex.Rows[2].Style = null;
				_flex.Rows[3].Style = null;
			}
		}
		private void _btnBorders_CheckedChanged(object sender, System.EventArgs e)
		{
			_flex.DrawMode = (_btnBorders.Checked)
				? DrawModeEnum.OwnerDraw
				: DrawModeEnum.Normal;
		}

		private void _flex_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
		{
			if (e.Row <= 1)
			{
				// select border color and thickness
				Brush br = Brushes.Green;
				int thick = 2;

				// default painting
				e.DrawCell();

				// draw line below cell
				if ((e.Row == 1 && e.Col > 0) || (e.Row == 0 && e.Col == 1))
				{
					Rectangle rc = e.Bounds;
					rc.Y = rc.Bottom - thick;
					rc.Height = thick;
					e.Graphics.FillRectangle(br, rc);
				}
				
				// draw line to the right of the cell
				if ((e.Row == 0 && e.Col == 0) || (e.Row == 0 && e.Col == 1) ||
					(e.Row == 0 && e.Col == 2) || (e.Row == 1 && e.Col == 5))
				{
					Rectangle rc = e.Bounds;
					rc.X = rc.Right - thick;
					rc.Width = thick;
					e.Graphics.FillRectangle(br, rc);
				}
			}
		}
	}
}
