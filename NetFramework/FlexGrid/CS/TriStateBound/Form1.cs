using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TriStateBound
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.CheckBox _chkAllowNulls;
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
			this._chkAllowNulls = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:23;}\t";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.ShowCursor = true;
			this._flex.Size = new System.Drawing.Size(416, 234);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.ValidateEdit += new C1.Win.C1FlexGrid.ValidateEditEventHandler(this._flex_ValidateEdit);
			// 
			// _chkAllowNulls
			// 
			this._chkAllowNulls.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this._chkAllowNulls.Checked = true;
			this._chkAllowNulls.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkAllowNulls.Location = new System.Drawing.Point(8, 245);
			this._chkAllowNulls.Name = "_chkAllowNulls";
			this._chkAllowNulls.Size = new System.Drawing.Size(216, 16);
			this._chkAllowNulls.TabIndex = 1;
			this._chkAllowNulls.Text = "&Allow Nulls";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(416, 269);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._chkAllowNulls,
																		  this._flex});
			this.DockPadding.Bottom = 35;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Tri-state bound booleans";
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
			DataTable dt = new DataTable();
			dt.Columns.Add("Bool", typeof(bool));
			dt.Columns["Bool"].AllowDBNull = true;
			for (int i = 0; i < 10; i++)
			{
				dt.Rows.Add(new object[] { true });
				dt.Rows.Add(new object[] { false });
				dt.Rows.Add(new object[] { DBNull.Value });
			}
			_flex.AutoResize = false;
			_flex.DataSource = dt;
		}

		// by default, the grid will show DBNulls as grayed checkboxes, but
		// once you change them it will toggle between true and false (like a good bool!)
		//
		// if you want to allow null values in the table, use a routine like this
		// one and assign the underlying value directly:
		//
		private void _flex_ValidateEdit(object sender, C1.Win.C1FlexGrid.ValidateEditEventArgs e)
		{
			if (!_chkAllowNulls.Checked)
				return;

			if (_flex.Cols[e.Col].DataType == typeof(bool))
			{
				e.Cancel = true;
				if (_flex[e.Row, e.Col].Equals(false))
				{
					_flex[e.Row, e.Col] = true;
				}
				else if (_flex[e.Row, e.Col].Equals(true))
				{
					_flex[e.Row, e.Col] = DBNull.Value;
				}
				else if (_flex[e.Row, e.Col].Equals(DBNull.Value))
				{
					_flex[e.Row, e.Col] = false;
				}
			}
		}
	}
}
