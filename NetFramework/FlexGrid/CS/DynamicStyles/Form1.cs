using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.FlexGrid;


namespace DynamicStyles
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex1;
		private C1.Win.FlexGrid.C1FlexGrid _flex2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this._flex1 = new C1.Win.FlexGrid.C1FlexGrid();
			this._flex2 = new C1.Win.FlexGrid.C1FlexGrid();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this._flex1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._flex2)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex1
			// 
			this._flex1.ColumnInfo = "3,1,0,0,0,75,Columns:0{Width:24;}\t1{Name:\"Length\";DataType:System.Int64;Format:\"#,###.00\";Caption:\"Len" +
				"gth (ft)\";}\t2{Name:\"UserDef\";DataType:System.Boolean;ImageAlign:CenterCenter;Cap" +
				"tion:\"User-Defined\";}";
			this._flex1.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
			this._flex1.Location = new System.Drawing.Point(16, 24);
			this._flex1.Name = "_flex1";
			this._flex1.Size = new System.Drawing.Size(296, 144);
			this._flex1.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex1.TabIndex = 0;
			this._flex1.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this._flex1.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("_flex1.Tree.NodeImageCollapsed")));
			this._flex1.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("_flex1.Tree.NodeImageExpanded")));
			this._flex1.CellChanged += new C1.Win.FlexGrid.RowColEventHandler(this._flex1_CellChanged);
			this._flex1.OwnerDrawCell += new C1.Win.FlexGrid.OwnerDrawCellEventHandler(this._flex1_OwnerDrawCell);
			// 
			// _flex2
			// 
			this._flex2.ColumnInfo = "3,1,0,0,0,75,Columns:0{Width:24;}\t1{Name:\"Length\";DataType:System.Int64;Format:\"#,###.00\";Caption:\"Len" +
				"gth (ft)\";}\t2{Name:\"UserDef\";DataType:System.Boolean;ImageAlign:CenterCenter;Cap" +
				"tion:\"User-Defined\";}";
			this._flex2.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
			this._flex2.Location = new System.Drawing.Point(16, 208);
			this._flex2.Name = "_flex2";
			this._flex2.Size = new System.Drawing.Size(296, 144);
			this._flex2.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex2.TabIndex = 0;
			this._flex2.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this._flex2.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("_flex2.Tree.NodeImageCollapsed")));
			this._flex2.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("_flex2.Tree.NodeImageExpanded")));
			this._flex2.CellChanged += new C1.Win.FlexGrid.RowColEventHandler(this._flex2_CellChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Method 1: OwnerDraw";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 192);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(240, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Method 2: Styles";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(336, 367);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this._flex1,
																		  this._flex2,
																		  this.label2});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "C1FlexGrid: Dynamic cell formatting";
			((System.ComponentModel.ISupportInitialize)(this._flex1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._flex2)).EndInit();
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

		// method 1: use OwnerDraw cells to paint one column yellow when another is checked
		private void _flex1_OwnerDrawCell(object sender, C1.Win.FlexGrid.OwnerDrawCellEventArgs e)
		{
			// paint a yellow background depending on the value of another column
			if (_flex1.Cols[e.Col].Name == "Length" && _flex1[e.Row, "UserDef"] is bool)
			{
				if ((bool)_flex1[e.Row, "UserDef"])
				{
					e.Graphics.FillRectangle(Brushes.Yellow, e.Bounds);
					e.DrawCell(DrawCellFlags.Border | DrawCellFlags.Content);
				}
			}
		}
		private void _flex1_CellChanged(object sender, C1.Win.FlexGrid.RowColEventArgs e)
		{
			// invalidate row to force repaint
			if (_flex1.Cols[e.Col].Name == "UserDef")
				_flex1.Invalidate(e.Row, -1);
		}

		// method 2: use styles to accomplish the same thing
		private void _flex2_CellChanged(object sender, C1.Win.FlexGrid.RowColEventArgs e)
		{
			if (_flex2.Cols[e.Col].Name == "UserDef" && _flex2[e.Row, "UserDef"] is bool)
			{
				// create style if we have to
				CellStyle s = _flex2.Styles["Yellow"];
				if (s == null)
				{
					s = _flex2.Styles.Add("Yellow");
					s.BackColor = Color.Yellow;
				}

				// apply style based on cell value
				CellRange rg = _flex2.GetCellRange(e.Row, _flex2.Cols["Length"].Index);
				rg.Style = ((bool)_flex2[e.Row, "UserDef"])? s: null;
			}
		}
	}
}
