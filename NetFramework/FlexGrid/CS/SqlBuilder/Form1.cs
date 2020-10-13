using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace SqlBuilder
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.Button _btnDataSource;
		private System.Windows.Forms.Button _btnViewSql;
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
            this._btnDataSource = new System.Windows.Forms.Button();
            this._btnViewSql = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:24;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 45);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 19;
            this._flex.Size = new System.Drawing.Size(504, 281);
            this._flex.TabIndex = 0;
            // 
            // _btnDataSource
            // 
            this._btnDataSource.Location = new System.Drawing.Point(10, 9);
            this._btnDataSource.Name = "_btnDataSource";
            this._btnDataSource.Size = new System.Drawing.Size(163, 28);
            this._btnDataSource.TabIndex = 1;
            this._btnDataSource.Text = "Select Data Source...";
            this._btnDataSource.Click += new System.EventHandler(this._btnDataSource_Click);
            // 
            // _btnViewSql
            // 
            this._btnViewSql.Location = new System.Drawing.Point(192, 9);
            this._btnViewSql.Name = "_btnViewSql";
            this._btnViewSql.Size = new System.Drawing.Size(163, 28);
            this._btnViewSql.TabIndex = 1;
            this._btnViewSql.Text = "View Sql Statement...";
            this._btnViewSql.Click += new System.EventHandler(this._btnViewSql_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(504, 326);
            this.Controls.Add(this._btnDataSource);
            this.Controls.Add(this._flex);
            this.Controls.Add(this._btnViewSql);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Sql Builder";
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

		string _conn = GetConnectionString();
		string _sql = string.Empty;

		void _btnDataSource_Click(object sender, System.EventArgs e)
		{
			// declare SqlBuilderDialog
			using (SqlBuilderDialog dlg = new SqlBuilderDialog())
			{
				// initialize SqlBuilderDialog
				dlg.ConnectionString = _conn;

				// show the dialog
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					// update form
					try
					{
						// retrieve the data
						OleDbDataAdapter da = new OleDbDataAdapter(dlg.Sql, dlg.ConnectionString);
						DataTable dt = new DataTable();
						da.Fill(dt);

						// bind grid to data
						_flex.DataSource = dt;

						// it all worked, store new values
						_conn = dlg.ConnectionString;
						_sql = dlg.Sql;

					}
					catch (Exception x)
					{
						MessageBox.Show("Error retrieving data:\r\n" + x.Message, "Error");
					}
				}
			}
		}
		void _btnViewSql_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(_sql, "Sql Statement");
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
