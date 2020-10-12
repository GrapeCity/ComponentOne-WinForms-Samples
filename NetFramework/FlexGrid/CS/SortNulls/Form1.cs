using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;

namespace SortNulls
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
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:23;}\t";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(368, 294);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Microsoft Sans Serif, 8.25pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.BeforeSort += new C1.Win.C1FlexGrid.SortColEventHandler(this._flex_BeforeSort);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(368, 294);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.Name = "Form1";
			this.Text = "C1FlexGrid: Custom Comparer";
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
			// populate grid
			_flex.Cols.Count = 3;

			Column c = _flex.Cols[1];
			c.Caption = "First";
			c.DataType = typeof(string);
			
			c = _flex.Cols[2];
			c.Caption = "Last";
			c.DataType = typeof(string);

			Random rnd = new Random();
			string[] first = "Joe|Paul|Tom|Dick|Harry".Split('|');
			string[] last  = "Jones|Paulsen|Tomlinson|Dickens|Harris".Split('|');
			for (int r = 1; r < 12; r++)
			{
				_flex[r,1] = first[rnd.Next(first.Length-1)];
				_flex[r,2] = last [rnd.Next(last.Length-1)];
			}
		}

		private void _flex_BeforeSort(object sender, C1.Win.C1FlexGrid.SortColEventArgs e)
		{
			// cancel built-in sorting
			e.Cancel = true;

			// sort using custom comparer
			IComparer comp = new NullComparer(sender as C1FlexGrid, e);
			_flex.Sort(comp);

			// update display and current sort order
			_flex.ShowSortAt(e.Order, e.Col); 
		}
	}

	/// <summary>
	/// Custom comparer that always sorts nulls last.
	/// </summary>
	public class NullComparer : IComparer
	{
		// ** fields
		C1FlexGrid _flex;
		SortFlags _order;
		int _col;

		// ** ctor
		public NullComparer(C1.Win.C1FlexGrid.C1FlexGrid flex, C1.Win.C1FlexGrid.SortColEventArgs e)
		{
			_flex = flex;
			_order = e.Order;
			_col = e.Col;
		}

		// ** IComparer
		int IComparer.Compare(object o1, object o2)
		{
			Row r1 = o1 as Row;
			Row r2 = o2 as Row;

			string s1 = r1[_col] as string;
			string s2 = r2[_col] as string;
			if (s1 == s2) return 0;
			if (s1 == null) return +1;
			if (s2 == null) return -1;

			int cmp = string.Compare(s1, s2);
			if ((_order & SortFlags.Descending) != 0)
				cmp = -cmp;

			return cmp;
		}
	}
}
