using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;

namespace RowStateDisplay
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.Button button1;
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
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.AllowAddNew = true;
			this._flex.AllowDelete = true;
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:24;}\t";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
			this._flex.Location = new System.Drawing.Point(0, 40);
			this._flex.Name = "_flex";
			this._flex.Rows.Count = 51;
			this._flex.ShowCursor = true;
			this._flex.Size = new System.Drawing.Size(416, 253);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 24);
			this.button1.TabIndex = 1;
			this.button1.Text = "Accept Changes";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(416, 293);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this._flex});
			this.DockPadding.Top = 40;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Show RowStates";
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

		DataTable _dt;
		private void Form1_Load(object sender, System.EventArgs e)
		{
			// create data source
			_dt = new DataTable();
			_dt.Columns.Add("ID", typeof(int));
			_dt.Columns.Add("Name", typeof(string));
			_dt.Columns.Add("Address", typeof(string));
			_dt.Columns.Add("Phone", typeof(string));
			
			Random r = new Random();
			string[] names   = "Martin|Joe|Paul|Sue|Ringo|Dana|Chris|Simone".Split('|');
			string[] address = "123 Main St.|321 Broadway|32 Crescent Dr.|432 Oakhurst Ave.".Split('|');
			string[] phones  = "555-1212|123-1231|800-boat|321-4433|432-1233".Split('|');
			object[] data = new object[4];
			for (int i = 0; i < 6; i++)
			{
				data[0] = i;
				data[1] = names[r.Next(names.Length-1)];
				data[2] = address[r.Next(address.Length-1)];
				data[3] = phones[r.Next(phones.Length-1)];
				_dt.Rows.Add(data);
			}
			_dt.AcceptChanges();
			_dt.RowChanged += new DataRowChangeEventHandler(_drChanged);

			// create custom grid styles
			// (could also do this at design time)
			CellStyle cs = _flex.Styles.Add("Added");
			cs.BackColor = SystemColors.Info;
			cs.Font = new Font(_flex.Font, FontStyle.Bold);

			cs = _flex.Styles.Add("Detached");
			cs.BackColor = SystemColors.Info;
			cs.ForeColor = Color.DarkGray;

			cs = _flex.Styles.Add("Modified");
			cs.BackColor = Color.Gold;
			cs.Font = new Font(_flex.Font, FontStyle.Italic);

			// bind grid
			_flex.DataSource = _dt;
		}

		// invalidate grid after adding new rows
		// (so the Added style is visible right away)
		private void _drChanged(object sender, DataRowChangeEventArgs e)
		{
			if (e.Action == DataRowAction.Add)
				_flex.Invalidate();
		}

		// select style based on row state
		private void _flex_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
		{
			// only apply styles to scrollable cells
			if (e.Row < _flex.Rows.Fixed || e.Col < _flex.Cols.Fixed)
				return;

			// get underlying DataRow
			int index = _flex.Rows[e.Row].DataIndex;
			if (index < 0) return;
			CurrencyManager cm = (CurrencyManager)BindingContext[_flex.DataSource, _flex.DataMember];
			DataRowView drv = cm.List[index] as DataRowView;

			// select style based on row state
			switch (drv.Row.RowState)
			{
				case DataRowState.Added:
					e.Style = _flex.Styles["Added"];
					break;
				case DataRowState.Modified:
					e.Style = _flex.Styles["Modified"];
					break;
				case DataRowState.Detached:
					e.Style = _flex.Styles["Detached"];
					break;
				case DataRowState.Unchanged:
					break;
				default:
					break;
			}
		}

		// accept changes (resets all RowState to unchanged)
		private void button1_Click(object sender, System.EventArgs e)
		{
			_dt.AcceptChanges();		
		}
	}
}
