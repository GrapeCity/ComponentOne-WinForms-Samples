using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace ThreadedUpdate
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
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
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(304, 325);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Microsoft Sans Serif, 8.25pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(304, 325);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Flexgrid: Threaded Updates";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
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

		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		DataTable	_dt;
		DataView	_dv;
		Thread		_t;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// create data table
			_dt = new DataTable();
			_dt.Columns.Add("numbers", typeof(int));
			for (int i = 0; i < 50; i++)
				_dt.Rows.Add(new object[] { i });

			// bind to grid
			_dv = new DataView(_dt);
			_dv.RowFilter = "numbers > 80";
			_flex.DataSource = _dv;

			// start some table update threads
			for (int i = 0; i < 5; i++)
			{
				_t = new Thread(new ThreadStart(UpdateTable));
				_t.Start();
			}
		}

		// delegate used for setting DataTable values
		public delegate void ValueSetter(int index, int value);
		private void SetValue(int index, int value)
		{
			_dt.Rows[index][0] = value;
		}

		// thread routine that invokes the delegate
		private void UpdateTable()
		{
            // note:
            // execute only if ThreadState == Running. 
            // when the form is closed, the thread state changes to AbortRequested,
            // and the thread remains alive for a while even after the form has been
            // disposed and can no longer handle Invoke calls.
			while (_t != null && _t.ThreadState == ThreadState.Running)
			{
				Random r = new Random();
				int cnt = _dt.Rows.Count;
				int index = r.Next(cnt-1);
				int value = r.Next(100);
				this.Invoke(new ValueSetter(SetValue), new object[] {index,value});
				Thread.Sleep(10);
			}
		}

		// kill update thread when form closes
		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			_t.Abort();
            _t = null;
		}
	}
}
