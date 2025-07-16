using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace CellLabelDelay
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.Timer _timer;
		private System.ComponentModel.IContainer components;

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
			this.components = new System.ComponentModel.Container();
			this._flex = new C1.Win.FlexGrid.C1FlexGrid();
			this._timer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.ColumnInfo = "4,1,0,0,0,85,Columns:0{Width:25;}\t";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(424, 286);
			this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Normal{Font:Microsoft Sans Serif, 8.25pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.MouseHoverCell += new System.EventHandler(this._flex_MouseHoverCell);
			// 
			// _timer
			// 
			this._timer.Tick += new System.EventHandler(this._timer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(424, 286);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Delayed Cell Labels";
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

		void Form1_Load(object sender, System.EventArgs e)
		{
			string sql = "select * from products";
			string conn = GetConnectionString();
			OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			_flex.DataSource = dt;
		}

		DateTime _startHover = DateTime.MinValue;
		void _flex_MouseHoverCell(object sender, System.EventArgs e)
		{
			TimeSpan ts = DateTime.Now - _startHover;
			if (ts.TotalSeconds > 0.1)
			{
				// turn labels off
				_flex.ShowCellLabels = false;

				// start ticking
				_startHover = DateTime.Now;
				_timer.Enabled = true;
				_timer.Interval = 100;

			}
		}
		void _timer_Tick(object sender, System.EventArgs e)
		{
			// turn labels on
			if (_flex.ShowCellLabels == false)
			{
				TimeSpan ts = DateTime.Now - _startHover;
				if (ts.TotalSeconds > 1.5)
				{
					_startHover = DateTime.Now;
					_flex.ShowCellLabels = true;
					_timer.Enabled = false;
					return;
				}
			}
		}
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
