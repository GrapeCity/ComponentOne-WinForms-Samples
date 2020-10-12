using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace GridTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private System.ComponentModel.Container components = null;
    
		private DataTable _dt;
		private int _ID = 1;

		public Form1()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
					components.Dispose();
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
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this._flex.AllowEditing = false;
			this._flex.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
			this._flex.BackColor = System.Drawing.SystemColors.Control;
			this._flex.ColumnInfo = "0,0,0,0,0,85,Columns:";
			this._flex.Dock = System.Windows.Forms.DockStyle.Top;
			this._flex.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid;
			this._flex.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
			this._flex.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveDown;
			this._flex.Name = "_flex";
			this._flex.Rows.Count = 1;
			this._flex.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
			this._flex.Size = new System.Drawing.Size(376, 216);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{BackColor:Control;Border:Flat,1,Gray,Both;}	Alternate{BackColor:PaleTurquoise;}	Fixed{Font:Microsoft Sans Serif, 8.25pt, style=Bold;ForeColor:ControlText;WordWrap:True;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Red;ForeColor:HighlightText;}	Focus{BackColor:Red;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 224);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 24);
			this.button1.TabIndex = 1;
			this.button1.Text = "Add New Row";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(376, 253);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this._flex});
			this.Name = "Form1";
			this.Text = "C1FlexGrid: Select added row (with sort)";
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
			// create data table
			_dt = new DataTable("TestTable");
			_dt.Columns.Add(new DataColumn("ID", typeof(int)));
			_dt.Columns.Add(new DataColumn("Name", typeof(string)));
			_dt.DefaultView.Sort = "Name";

			// add a couple of rows
			AddRow("Fred");
			AddRow("Wilma");
			AddRow("Barney");

			// bind to grid
			_flex.DataSource = _dt;
			_flex.Cols[0].Width = 100;
			_flex.ExtendLastCol = true;
			_flex.Row = _flex.Rows.Count-1;
			_flex.Focus();
		}
		private DataRow AddRow(string name)
		{
			DataRow dr = _dt.NewRow();
			dr["ID"] = _ID++;
			dr["Name"] = name;
			_dt.Rows.Add(dr);
			return dr;
		}
		private void button1_Click(object sender, System.EventArgs e)
		{
			// add a new row
			DataRow dr = AddRow("Added Row");

			// get currency manager to select the new row
			CurrencyManager bm = _flex.BindingContext[_flex.DataSource, _flex.DataMember] as CurrencyManager;

			// assume it will be added to the bottom of the table/grid
			int index = bm.Count - 1;

			// if the view is sorted, look up the new row
			IBindingList bl = bm.List as IBindingList;
			if (bl != null && bl.IsSorted)
			{
				// find using sort key (fast)
				index = bl.Find(bl.SortProperty, dr[bl.SortProperty.Name]);
				if (index > -1)
				{
					// in case there are multiple rows with same sort value
					if (bl is DataView)
					{
						for (; index < bl.Count; index++)
						{
							DataRowView drv = bl[index] as DataRowView;
							if (drv.Row == dr) break;
						}
					}
				}
			}

			// set new position and focus back on the grid
			bm.Position = index;
			_flex.Focus();
		}
	}
}
