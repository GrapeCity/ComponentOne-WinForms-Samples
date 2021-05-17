using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DataTableSample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView dataGrid1;
		private System.Windows.Forms.Splitter splitter1;
		private C1.Win.FlexGrid.C1FlexGrid flex;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.flex = new C1.Win.FlexGrid.C1FlexGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flex)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 40);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Record";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 24);
            this.button2.TabIndex = 0;
            this.button2.Text = "Delete Record";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(0, 172);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(599, 162);
            this.dataGrid1.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 168);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(599, 4);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // flex
            // 
            this.flex.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.flex.Dock = System.Windows.Forms.DockStyle.Top;
            this.flex.Location = new System.Drawing.Point(0, 0);
            this.flex.Name = "flex";
            this.flex.Size = new System.Drawing.Size(599, 168);
            this.flex.StyleInfo = resources.GetString("flex.StyleInfo");
            this.flex.TabIndex = 5;
            this.flex.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            //this.flex.Tree.NodeImageCollapsed = ((System.Drawing.Image)(resources.GetObject("flex.Tree.NodeImageCollapsed")));
            //this.flex.Tree.NodeImageExpanded = ((System.Drawing.Image)(resources.GetObject("flex.Tree.NodeImageExpanded")));
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(599, 374);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flex);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flex)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		public enum MaritalStatus
		{
			Single,
			Married,
			Separated,
			Widow,
			Deceased,
			Unknown
		}
		public enum Gender
		{
			Male,
			Female,
			Unknown
		}

		private System.Data.DataTable _dt;
		private void Form1_Load(object sender, System.EventArgs e)
		{
			// create a new table
			_dt = new System.Data.DataTable("MyDataTable");
			_dt.Columns.Add("Name",		typeof(string));
			_dt.Columns.Add("Age",		typeof(int));
			_dt.Columns.Add("Gender",	typeof(Gender));
			_dt.Columns.Add("Status",	typeof(MaritalStatus));
		
			// populate it
			_dt.Rows.Add(new object[] { "Joe",	12, Gender.Male,	 MaritalStatus.Single });
			_dt.Rows.Add(new object[] { "Bob",	14, Gender.Male,	 MaritalStatus.Single });
			_dt.Rows.Add(new object[] { "Sue",	13, Gender.Female,	 MaritalStatus.Single });
			_dt.Rows.Add(new object[] { "Chris", 26, Gender.Unknown, MaritalStatus.Unknown });

			// bind the grid to it
			flex.Cols[0].Width = flex.Cols.DefaultSize/3;
			flex.DataSource = _dt;
			dataGrid1.DataSource = _dt;
		}

		// add a record
		private void button1_Click(object sender, System.EventArgs e)
		{
			_dt.Rows.Add(new object[] { "New", 0, Gender.Unknown, MaritalStatus.Unknown });
		}

		// delete a record
		private void button2_Click(object sender, System.EventArgs e)
		{
            if (flex.Row >= 0)
            {
                int r = flex.Rows[flex.Row].DataIndex;
                if (r >= 0)
                    _dt.Rows.RemoveAt(r);
            }
		}
	}
}
