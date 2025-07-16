using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Collections.Specialized;
using C1.Win.FlexGrid;

namespace Sorting
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.CheckBox _chkSortLists;
		private System.Windows.Forms.Button _btnCustomSort;
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
			this._flex = new C1.Win.FlexGrid.C1FlexGrid();
			this._chkSortLists = new System.Windows.Forms.CheckBox();
			this._btnCustomSort = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._flex.Location = new System.Drawing.Point(8, 8);
			this._flex.Name = "_flex";
			this._flex.Rows.Count = 5;
			this._flex.Size = new System.Drawing.Size(368, 240);
			this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.BeforeSort += new C1.Win.FlexGrid.SortColEventHandler(this._flex_BeforeSort);
			this._flex.SetupEditor += new C1.Win.FlexGrid.RowColEventHandler(this._flex_SetupEditor);
			// 
			// _chkSortLists
			// 
			this._chkSortLists.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this._chkSortLists.Location = new System.Drawing.Point(8, 256);
			this._chkSortLists.Name = "_chkSortLists";
			this._chkSortLists.Size = new System.Drawing.Size(128, 24);
			this._chkSortLists.TabIndex = 1;
			this._chkSortLists.Text = "Sort Combo Items";
			// 
			// _btnCustomSort
			// 
			this._btnCustomSort.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this._btnCustomSort.Location = new System.Drawing.Point(152, 256);
			this._btnCustomSort.Name = "_btnCustomSort";
			this._btnCustomSort.Size = new System.Drawing.Size(136, 24);
			this._btnCustomSort.TabIndex = 2;
			this._btnCustomSort.Text = "Apply Custom Sort";
			this._btnCustomSort.Click += new System.EventHandler(this._btnCustomSort_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(384, 285);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._btnCustomSort,
																		  this._chkSortLists,
																		  this._flex});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Sorting";
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
			// SortedList sorts values in the list by key
			SortedList sl = new SortedList();
			sl.Add("0", "Zero");
			sl.Add("1", "One");
			sl.Add("2", "Two");
			sl.Add("3", "Three");

			// ListDictionary keeps Add order
			ListDictionary ld = new ListDictionary();
			ld.Add(0, "Zero");
			ld.Add(1, "One");
			ld.Add(2, "Two");
			ld.Add(3, "Three");

			// Hashtable stores items in arbitrary order
			Hashtable ht = new Hashtable();
			ht.Add(0, "Zero");
			ht.Add(1, "One");
			ht.Add(2, "Two");
			ht.Add(3, "Three");

			// apply data maps
			_flex.Cols[1].DataMap = sl; _flex.Cols[1].Caption = "SortedList";
			_flex.Cols[2].DataMap = ld; _flex.Cols[2].Caption = "ListDictionary";
			_flex.Cols[3].DataMap = ht; _flex.Cols[3].Caption = "HashTable";

		}

		// sort list items if that was requested
		private void _flex_SetupEditor(object sender, RowColEventArgs e)
		{
			if (_flex.Editor is ComboBox)
				((ComboBox)_flex.Editor).Sorted = _chkSortLists.Checked;
		}

		// with mouse sort, use display values (these are data maps)
		private void _flex_BeforeSort(object sender, SortColEventArgs e)
		{
			// note OR operator (|) used to combine the AsDisplayed flag with
			// the sort direction set by the grid (Ascending or Descending)
			e.Order |= SortFlags.AsDisplayed;
		}

		// apply custom sort
		private void _btnCustomSort_Click(object sender, System.EventArgs e)
		{
			_flex.Sort(new MyComparer(_flex));
		}
	}

	/// <summary>
	/// MyComparer
	/// compares two grid rows using all columns
	/// </summary>
	public class MyComparer : IComparer
	{
		C1FlexGrid _flex;
		public MyComparer(C1FlexGrid flex)
		{
			_flex = flex;
		}
		int IComparer.Compare(object x, object y)
		{
			// get row indices
			int r1 = ((Row)x).Index;
			int r2 = ((Row)y).Index;

			// scan all columns looking for differences
			for (int c = 0; c < _flex.Cols.Count; c++)
			{
				// get display values
				string s1 = _flex.GetDataDisplay(r1, c);
				string s2 = _flex.GetDataDisplay(r2, c);

				// compare, done when a difference is found
				int cmp = string.Compare(s1, s2);
				if (cmp != 0) return cmp;
			}

			// all values are the same, use row indices
			// to keep sort stable
			return r1 - r2;
		}
	}
}