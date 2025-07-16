using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace C1FlexGroupSample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1FlexGroup.C1FlexGroup _flexGroup;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox _chkFilterRow;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
        private Button button4;
        private C1.Win.FlexGrid.C1FlexGrid _licensing;

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
            this._chkFilterRow = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this._flexGroup = new C1FlexGroup.C1FlexGroup();
            this._licensing = new C1.Win.FlexGrid.C1FlexGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._flexGroup.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._licensing)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this._chkFilterRow);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 60);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Country";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _chkFilterRow
            // 
            this._chkFilterRow.Checked = true;
            this._chkFilterRow.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkFilterRow.Location = new System.Drawing.Point(629, 19);
            this._chkFilterRow.Name = "_chkFilterRow";
            this._chkFilterRow.Size = new System.Drawing.Size(141, 24);
            this._chkFilterRow.TabIndex = 0;
            this._chkFilterRow.Text = "Filter Row";
            this._chkFilterRow.CheckedChanged += new System.EventHandler(this._chkFilterRow_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Country/Region";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(435, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 34);
            this.button4.TabIndex = 1;
            this.button4.Text = "(none)";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(294, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 34);
            this.button3.TabIndex = 1;
            this.button3.Text = "Title";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // _flexGroup
            // 
            this._flexGroup.BackColor = System.Drawing.SystemColors.ControlDark;
            this._flexGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._flexGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexGroup.FilterRow = true;
            this._flexGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this._flexGroup.Grid.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.Nodes;
            this._flexGroup.Grid.AllowSorting = C1.Win.FlexGrid.AllowSortingEnum.None;
            this._flexGroup.Grid.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this._flexGroup.Grid.ColumnInfo = "10,1,0,0,0,115,Columns:0{Width:18;}\t";
            this._flexGroup.Grid.Cursor = System.Windows.Forms.Cursors.Default;
            this._flexGroup.Grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._flexGroup.Grid.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            this._flexGroup.Grid.Location = new System.Drawing.Point(0, 39);
            this._flexGroup.Grid.Name = "";
            this._flexGroup.Grid.Rows.DefaultSize = 23;
            this._flexGroup.Grid.Rows.Fixed = 2;
            this._flexGroup.Grid.ShowCursor = true;
            this._flexGroup.Grid.Size = new System.Drawing.Size(752, 351);
            this._flexGroup.Grid.StyleInfo = resources.GetString("_flexGroup.Grid.StyleInfo");
            this._flexGroup.Grid.TabIndex = 1;
            this._flexGroup.Grid.Tree.Style = C1.Win.FlexGrid.TreeStyleFlags.Symbols;
            this._flexGroup.Image = null;
            this._flexGroup.Location = new System.Drawing.Point(0, 0);
            this._flexGroup.Name = "_flexGroup";
            this._flexGroup.Size = new System.Drawing.Size(756, 394);
            this._flexGroup.TabIndex = 0;
            this._flexGroup.TabStop = false;
            // 
            // _licensing
            // 
            this._licensing.ColumnInfo = "10,1,0,0,0,115,Columns:";
            this._licensing.Location = new System.Drawing.Point(0, 0);
            this._licensing.Name = "_licensing";
            this._licensing.Rows.DefaultSize = 23;
            this._licensing.Size = new System.Drawing.Size(87, 29);
            this._licensing.StyleInfo = resources.GetString("_licensing.StyleInfo");
            this._licensing.TabIndex = 2;
            this._licensing.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 19);
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Controls.Add(this._licensing);
            this.Controls.Add(this._flexGroup);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Outlook-style Grouping with Filtering";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexGroup.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._flexGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._licensing)).EndInit();
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

		// load data and bind to grid
		void Form1_Load(object sender, System.EventArgs e)
		{
			// constants
			string conn = GetConnectionString();
			string rs = "select * from customers";

			// create data table
			OleDbDataAdapter da = new OleDbDataAdapter(rs, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);

			// bind grid to database
			_flexGroup.Grid.DataSource = dt;
			_flexGroup.Grid.Cols["Region"].Visible = false;
		}

		// toggle filter row
		void _chkFilterRow_CheckedChanged(object sender, System.EventArgs e)
		{
			_flexGroup.FilterRow = _chkFilterRow.Checked;
		}

		// apply pre-defined views
		void button1_Click(object sender, System.EventArgs e)
		{
			_flexGroup.Groups = "Country";
		}
		void button2_Click(object sender, System.EventArgs e)
		{
			_flexGroup.Groups = "Country, Region";
		}
		void button3_Click(object sender, System.EventArgs e)
		{
			_flexGroup.Groups = "ContactTitle";
		}
        void button4_Click(object sender, EventArgs e)
        {
            _flexGroup.Groups = string.Empty;
        }

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
