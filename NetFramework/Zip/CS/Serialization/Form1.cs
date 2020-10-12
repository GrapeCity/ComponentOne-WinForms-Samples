using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using C1.C1Zip;

namespace Serialization
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private const string FN_REGULAR = @"\DataTable.regular";
		private const string FN_COMPRESSED = @"\DataTable.compressed";

		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnLoadCompressed;
		private System.Windows.Forms.StatusBar statusBar1;

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
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnLoadCompressed = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(16, 8);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(184, 40);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "Create Data Table";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(16, 56);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(184, 40);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save Data Table";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Enabled = false;
			this.btnLoad.Location = new System.Drawing.Point(16, 176);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(184, 40);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "Load Data Table";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnLoadCompressed
			// 
			this.btnLoadCompressed.Enabled = false;
			this.btnLoadCompressed.Location = new System.Drawing.Point(16, 224);
			this.btnLoadCompressed.Name = "btnLoadCompressed";
			this.btnLoadCompressed.Size = new System.Drawing.Size(184, 40);
			this.btnLoadCompressed.TabIndex = 0;
			this.btnLoadCompressed.Text = "Load Compressed Data Table";
			this.btnLoadCompressed.Click += new System.EventHandler(this.btnLoadCompressed_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(216, 8);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(392, 256);
			this.dataGrid1.TabIndex = 1;
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 273);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(624, 22);
			this.statusBar1.TabIndex = 2;
			this.statusBar1.Text = "Ready";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(624, 295);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.statusBar1,
																		  this.dataGrid1,
																		  this.btnCreate,
																		  this.btnSave,
																		  this.btnLoad,
																		  this.btnLoadCompressed});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Zip: Compressed Serialization";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
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

		// create DataTable object and populate it from NorthWind database
		void btnCreate_Click(object sender, System.EventArgs e)
		{
			// open table
			string conn = GetConnectionString();
			string rs = "select * from customers";
            
			// show status
			Cursor = Cursors.WaitCursor;
			statusBar1.Text = "Loading data from mdb file...";

			// load data
			OleDbDataAdapter da = new OleDbDataAdapter(rs, conn);
			DataSet ds = new DataSet();
			da.Fill(ds);

			// show status
			Cursor = Cursors.Default;
			statusBar1.Text = "Loaded " + ds.Tables[0].Rows.Count + " records from mdb file.";

			// bind to grid
			dataGrid1.DataSource = ds.Tables[0];

			// enable save button
			btnSave.Enabled = true;
		}

		// save DataTable object into two files: regular and compressed versions.
		void btnSave_Click(object sender, System.EventArgs e)
		{
			// get data table from grid
			DataTable dt = dataGrid1.DataSource as DataTable;
			Debug.Assert(dt != null);

			// show status
			Cursor = Cursors.WaitCursor;
			statusBar1.Text = "Serializing data to regular file...";

			// serialize the data set to a regular file
			string fn = Application.StartupPath + FN_REGULAR;
			FileStream fs = new FileStream(fn, FileMode.Create);
			BinaryFormatter bf = new BinaryFormatter();
			bf.Serialize(fs, dt);
			long lenRegular = fs.Length;
			fs.Close();

			// show status
			Cursor = Cursors.WaitCursor;
			statusBar1.Text = "Serializing data to compressed file...";

			// serialize the data set to a compressed file
			fn = Application.StartupPath + FN_COMPRESSED;
			fs = new FileStream(fn, FileMode.Create);
			C1ZStreamWriter compressor = new C1ZStreamWriter(fs);            
			bf = new BinaryFormatter();
			bf.Serialize(compressor, dt);
			long lenCompressed = fs.Length;
			fs.Close();

			// show status
			Cursor = Cursors.Default;
			statusBar1.Text = string.Format(
				"Saved to regular file ({0:#,###} bytes) and " +
				"compressed file ({1:#,###} bytes)",
				lenRegular, lenCompressed);

			// enable load buttons
			btnLoad.Enabled = true;
			btnLoadCompressed.Enabled = true;
		}

		void btnLoad_Click(object sender, System.EventArgs e)
		{
			// clear grid, show status
			Cursor = Cursors.WaitCursor;
			dataGrid1.DataSource = null;
			statusBar1.Text = "Loading DataTable from regular file...";

			// deserialize from regular file
			string fn = Application.StartupPath + FN_REGULAR;
			FileStream fs = new FileStream(fn, FileMode.Open);
			BinaryFormatter bf = new BinaryFormatter();
			long ticks = DateTime.Now.Ticks;
			DataTable dt = (DataTable)bf.Deserialize(fs);
			long ms = (DateTime.Now.Ticks - ticks)/TimeSpan.TicksPerMillisecond;
			fs.Close();

			// show result
			Cursor = Cursors.Default;
			dataGrid1.DataSource = dt;
			statusBar1.Text = "Loaded data from regular file in " + ms.ToString() + " ms.";
		}

		void btnLoadCompressed_Click(object sender, System.EventArgs e)
		{
			// clear grid, show status
			Cursor = Cursors.WaitCursor;
			dataGrid1.DataSource = null;
			statusBar1.Text = "Loading DataTable from compressed file...";

			// deserialize from regular file
			string fn = Application.StartupPath + FN_COMPRESSED;
			FileStream fs = new FileStream(fn, FileMode.Open);
			C1ZStreamReader decompressor = new C1ZStreamReader(fs);
			BinaryFormatter bf = new BinaryFormatter();
			long ticks = DateTime.Now.Ticks;
			DataTable dt = (DataTable)bf.Deserialize(decompressor);
			long ms = (DateTime.Now.Ticks - ticks)/TimeSpan.TicksPerMillisecond;
			fs.Close();

			// show result
			Cursor = Cursors.Default;
			dataGrid1.DataSource = dt;
			statusBar1.Text = "Loaded data from compressed file in " + ms.ToString() + " ms.";
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
