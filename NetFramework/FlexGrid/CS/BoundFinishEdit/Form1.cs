using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BoundFinishEdit
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.Button button1;
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
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Location = new System.Drawing.Point(0, 39);
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(512, 234);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(512, 39);
			this.toolBar1.TabIndex = 1;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Text = "Save";
			this.toolBarButton1.ToolTipText = "Save";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(80, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(176, 32);
			this.button1.TabIndex = 2;
			this.button1.Text = "Save (this one gets the focus!)";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex,
																		  this.button1,
																		  this.toolBar1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: LostFocus and DataRowState";
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

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			// the toolbar doesn't get the focus when clicked, so 
			// the grid could still be in edit mode...
			_flex.FinishEditing();

			// the grid still has the focus and the cursor hasn't moved to a new row,
			// so the data source still doesn't see the row as changed.
			// so we use the currency manager to end the edits.
			CurrencyManager cm = (CurrencyManager)BindingContext[_flex.DataSource, _flex.DataMember];
			cm.EndCurrentEdit();

			// proceed as usual
			button1_Click(sender, EventArgs.Empty);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Console.WriteLine("*** Checking for changes...");

			// check which rows have been modified
			int cnt = 0;
			foreach (DataRow dr in _dt.Rows)
				if (dr.RowState == DataRowState.Modified)
					cnt++;
			Console.WriteLine("\t{0} changed row(s).", cnt);

			// another way
			DataTable dtChanges = _dt.GetChanges(DataRowState.Modified);
			Console.WriteLine("\t{0} changed row(s).", (dtChanges != null)? dtChanges.Rows.Count: 0);

			// commit changes
			_dt.AcceptChanges();
		}

		DataTable _dt;
		private void Form1_Load(object sender, System.EventArgs e)
		{
			_dt = new DataTable("test");
			
			_dt.Columns.Add("Name", typeof(string));
			_dt.Columns.Add("Age", typeof(int));
			
			object[] data = new object[2];
			string[] names = "Sue|Ann|Mary|Bob|Joe".Split('|');
			Random rnd = new Random();
			for (int i = 0; i < 30; i++)
			{
				data[0] = names[rnd.Next(names.Length-1)];
				data[1] = rnd.Next(6,102);
				_dt.Rows.Add(data);
			}
			_dt.AcceptChanges(); // << added->unchanged

			_flex.DataSource = _dt;
		}
	}
}
