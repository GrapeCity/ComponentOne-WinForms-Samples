using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace MasterDetail
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid _flex1;
		private C1.Win.C1FlexGrid.C1FlexGrid _flex2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Button button1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._flex1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this._flex2 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._flex1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._flex2)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex1
            // 
            this._flex1.ColumnInfo = resources.GetString("_flex1.ColumnInfo");
            this._flex1.Dock = System.Windows.Forms.DockStyle.Top;
            this._flex1.Location = new System.Drawing.Point(0, 35);
            this._flex1.Name = "_flex1";
            this._flex1.Rows.Count = 1;
            this._flex1.Rows.DefaultSize = 19;
            this._flex1.Size = new System.Drawing.Size(520, 230);
            this._flex1.StyleInfo = resources.GetString("_flex1.StyleInfo");
            this._flex1.TabIndex = 0;
            // 
            // _flex2
            // 
            this._flex2.ColumnInfo = resources.GetString("_flex2.ColumnInfo");
            this._flex2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex2.Location = new System.Drawing.Point(0, 275);
            this._flex2.Name = "_flex2";
            this._flex2.Rows.Count = 1;
            this._flex2.Rows.DefaultSize = 19;
            this._flex2.Size = new System.Drawing.Size(520, 170);
            this._flex2.StyleInfo = resources.GetString("_flex2.StyleInfo");
            this._flex2.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 265);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(520, 10);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check for changes";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(520, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._flex2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this._flex1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.Text = "C1FlexGrid: Master-Detail tables";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._flex2)).EndInit();
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

		// create data set
		DataSet _ds = new DataSet("test");

		void Form1_Load(object sender, System.EventArgs e)
		{
			// build connection string
			string conn = GetConnectionString();

			// fill two tables
			OleDbDataAdapter da = new OleDbDataAdapter("select * from products", conn);
			da.Fill(_ds, "Products");
			da = new OleDbDataAdapter("select * from categories", conn);
			da.Fill(_ds, "Categories");

			// create a relation
			_ds.Relations.Add("CategoriesProducts",
				_ds.Tables["Categories"].Columns["CategoryID"],
				_ds.Tables["Products"].Columns["CategoryID"]);

			// bind master/detail grids
			_flex1.Cols[0].Width = _flex2.Cols[0].Width = 20;
			_flex1.SetDataBinding(_ds, "Categories");
			_flex2.SetDataBinding(_ds, "Categories.CategoriesProducts");
		}

		void button1_Click(object sender, System.EventArgs e)
		{
			string msg = _ds.HasChanges()? "Has changes": "No changes";
			MessageBox.Show(msg);
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
