using C1.Win.FlexGrid;
using System.Globalization;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace LegacyDates
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
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
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.AllowAddNew = true;
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:24;}\t";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Rows.DefaultSize = 17;
			this._flex.ShowCursor = true;
			this._flex.Size = new System.Drawing.Size(296, 301);
			this._flex.TabIndex = 0;
			this._flex.GetUnboundValue += new C1.Win.FlexGrid.UnboundValueEventHandler(this._flex_GetUnboundValue);
			this._flex.SetUnboundValue += new C1.Win.FlexGrid.UnboundValueEventHandler(this._flex_SetUnboundValue);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 301);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Legacy Dates";
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
			// create data table with date stored as string (yyyyMMdd)
			DataTable dt = new DataTable();
			dt.Columns.Add("ID", typeof(int));
			dt.Columns.Add("LegacyDate", typeof(string));

			// populate table with some random data
			Random rnd = new Random();
			for (int i = 0; i < 100; i++)
			{
				DataRow dr = dt.NewRow();
				dr["ID"] = i;
				dr["LegacyDate"] = string.Format("{0:0000}{1:00}{2:00}", 
					rnd.Next(2000,2005), rnd.Next(1,12), rnd.Next(1,28));
				dt.Rows.Add(dr);
			}

			// bind grid
			_flex.DataSource = dt;

			// hide legacy column
			_flex.Cols["LegacyDate"].Visible = false;

			// add unbound column to act as filter for LegacyDate
			Column col = _flex.Cols.Add();
			col.DataType = typeof(DateTime);
			col.Caption = "Date";
			col.Name = "Date";
		}

        // convert strings into dates when getting date column
        private void _flex_GetUnboundValue(object sender, C1.Win.FlexGrid.UnboundValueEventArgs e)
        {
            if (_flex.Cols[e.Col].Name == "Date" && (_flex[e.Row, "LegacyDate"]).GetType() != typeof(DBNull))
            {
                // get legacy date
                string str = (string)_flex[e.Row, "LegacyDate"];

                // parse value into DateTime
                e.Value = DateTime.ParseExact(str, "yyyyMMdd", CultureInfo.InvariantCulture);
            }
        }

		// convert dates into strings when setting date column
		private void _flex_SetUnboundValue(object sender, C1.Win.FlexGrid.UnboundValueEventArgs e)
		{
			if (_flex.Cols[e.Col].Name == "Date")
			{
				// get date
				DateTime date = (DateTime)e.Value;

				// store as formatted string
				_flex[e.Row, "LegacyDate"] = string.Format("{0:0000}{1:00}{2:00}", date.Year, date.Month, date.Day);
			}
		}
	}
}
