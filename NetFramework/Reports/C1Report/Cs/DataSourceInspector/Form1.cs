using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace DataSourceInspector
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.C1Report.C1Report _c1r;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label _lblConn;
		private System.Windows.Forms.Label _lblRS;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
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
            this._c1r = new C1.C1Report.C1Report();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this._lblConn = new System.Windows.Forms.Label();
			this._lblRS = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// _c1r
			// 
			this._c1r.ReportDefinition = @"<!--Report *** c1Report1 ***--><Report version=""2.5.20053.188""><Name>c1Report1</Name><DataSource /><Layout /><Font><Name>Arial</Name><Size>9</Size></Font><Groups /><Sections><Section><Name>Detail</Name><Type>0</Type><Visible>0</Visible></Section><Section><Name>Header</Name><Type>1</Type><Visible>0</Visible></Section><Section><Name>Footer</Name><Type>2</Type><Visible>0</Visible></Section><Section><Name>PageHeader</Name><Type>3</Type><Visible>0</Visible></Section><Section><Name>PageFooter</Name><Type>4</Type><Visible>0</Visible></Section></Sections><Fields /></Report>";
			this._c1r.ReportName = "c1Report1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(192, 24);
			this.button1.TabIndex = 0;
			this.button1.Text = "Select Report Definition File";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left);
			this.listBox1.IntegralHeight = false;
			this.listBox1.Location = new System.Drawing.Point(8, 64);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(192, 312);
			this.listBox1.TabIndex = 1;
			this.listBox1.DoubleClick += new System.EventHandler(this.button2_Click);
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(8, 40);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(192, 24);
			this.button2.TabIndex = 0;
			this.button2.Text = "Show Data";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(208, 72);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(616, 304);
			this.dataGrid1.TabIndex = 2;
			// 
			// _lblConn
			// 
			this._lblConn.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._lblConn.Location = new System.Drawing.Point(344, 8);
			this._lblConn.Name = "_lblConn";
			this._lblConn.Size = new System.Drawing.Size(480, 16);
			this._lblConn.TabIndex = 3;
			// 
			// _lblRS
			// 
			this._lblRS.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._lblRS.Location = new System.Drawing.Point(344, 32);
			this._lblRS.Name = "_lblRS";
			this._lblRS.Size = new System.Drawing.Size(480, 32);
			this._lblRS.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(224, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "ConnectionString:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(224, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "RecordSource:";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(832, 381);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label3,
																		  this._lblConn,
																		  this.dataGrid1,
																		  this.listBox1,
																		  this.button1,
																		  this.button2,
																		  this._lblRS,
																		  this.label4});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Report: DataSource Inspector";
			((System.ComponentModel.ISupportInitialize)(this._c1r)).EndInit();
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

		string _fileName = null;

		private void button1_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.FileName = "*.xml";
			if (dlg.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			_fileName = dlg.FileName;
			listBox1.Items.Clear();
			try
			{
				foreach (string reportName in _c1r.GetReportInfo(_fileName))
				{
					listBox1.Items.Add(reportName);
				}
			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message);
			}
		}
		private void button2_Click(object sender, System.EventArgs e)
		{
			string reportName = listBox1.SelectedItem as string;
			if (reportName != null)
			{
				_c1r.Load(_fileName, reportName);
				Cursor = Cursors.WaitCursor;
				ShowData(_c1r.DataSource.ConnectionString, _c1r.DataSource.GetRecordSource(true), _c1r.DataSource.Filter);
				Cursor = null;
			}
		}
		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			button2.Enabled = listBox1.SelectedIndex > -1;		
		}
		private void ShowData(string conn, string sql, string filter)
		{
			// load data
			DataTable dt = null;
			if (sql != null && sql.Length > 0)
			{
				if (dt == null)
					dt = GetDataTable(conn, sql, filter, CommandType.TableDirect);
				if (dt == null)
					dt = GetDataTable(conn, "[" + sql + "]", filter, CommandType.TableDirect);
				if (dt == null)
					dt = GetDataTable(conn, sql, filter, CommandType.Text);
				if (dt == null)
					dt = GetDataTable(conn, sql, filter, CommandType.StoredProcedure);
			}

			// update labels
			if (dt != null)
			{
				_lblConn.Text = conn;
				_lblRS.Text = sql;
			}
			else
			{
				_lblConn.Text = _lblRS.Text = string.Empty;
			}

			// update grid
			dataGrid1.DataSource = dt;
		}
		private DataTable GetDataTable(string conn, string sql, string filter, CommandType cmdType)
		{
			try
			{
				OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
				da.SelectCommand.CommandType = cmdType;
				DataTable dt = new DataTable();
				da.Fill(dt);
				if (filter != null && filter.Length > 0)
					dt.DefaultView.RowFilter = filter;
				return dt;
			}
			catch (Exception x)
			{
				Console.WriteLine(x.Message);
			}
			return null;
		}
	}
}
