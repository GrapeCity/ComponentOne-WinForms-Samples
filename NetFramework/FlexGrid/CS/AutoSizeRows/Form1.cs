using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AutoSizeRows
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
			_flex = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(_flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			_flex.BackColor = System.Drawing.SystemColors.Window;
			_flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
			_flex.Dock = System.Windows.Forms.DockStyle.Fill;
			_flex.Location = new System.Drawing.Point(0, 40);
			_flex.Name = "_flex";
			_flex.Size = new System.Drawing.Size(544, 233);
			_flex.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			_flex.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "AutoSizeRows";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(544, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  _flex});
			this.DockPadding.Top = 40;
			this.Name = "Form1";
			this.Text = "C1FlexGrid: AutoSizeRows with ExtendLastCol";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(_flex)).EndInit();
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
			string conn = GetConnectionString();
			string sql = "select firstname, lastname, notes from employees";
			System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			_flex.AutoResize = false;
			_flex.DataSource = dt;
			_flex.ExtendLastCol = true;
			_flex.Styles.Normal.WordWrap = true;
		}

		void button1_Click(object sender, System.EventArgs e)
		{
			int wid = _flex.ClientSize.Width;
			_flex.AutoSizeRows();

			// if we added scrollbars because of the autosize, redo it
			if (wid != _flex.ClientSize.Width)
				_flex.AutoSizeRows();
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
