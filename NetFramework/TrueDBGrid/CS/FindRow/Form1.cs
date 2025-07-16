using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FindRow
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DataTable dt;
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
            this.c1TrueDBGrid1 = new C1.Win.TrueDBGrid.C1TrueDBGrid();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(16, 24);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.c1TrueDBGrid1.PrintInfo.MeasurementPrinterName = null;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(261, 195);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(408, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
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
		// fills the grid with random data
		private void _fillGrid()
		{
			int maxrows = 5;

			dt = new DataTable("testdatatable");

			DataColumn dc;
			DataRow dr;

			// set up an integer column
			dc = new DataColumn();
			dc.DataType = System.Type.GetType("System.Int32");
			dc.ColumnName = "Integer";
			dt.Columns.Add(dc);

			// do string
			dc = new DataColumn();
			dc.DataType = System.Type.GetType("System.String");
			dc.ColumnName = "String";
			dt.Columns.Add(dc);

			Random rnd = new Random();
			for(int i=0; i < maxrows; i++)
			{
				dr = dt.NewRow();
				dr["Integer"] = (int) (rnd.NextDouble() * 1000.0);
				dr["String"] = "Row: " + i.ToString();
				dt.Rows.Add(dr);
			}
			this.c1TrueDBGrid1.DataSource = dt;
			dt.DefaultView.Sort = "Integer";
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			_fillGrid();
		}

		// find the newly added record in the grid and select it
		private void _findrow(int i)
		{
			// get the currency manager that the grid is bound to
			CurrencyManager cm = this.BindingContext[this.c1TrueDBGrid1.DataSource, this.c1TrueDBGrid1.DataMember] as CurrencyManager;
			// get the property descriptor for the "integer" column
			PropertyDescriptor prop = cm.GetItemProperties()["Integer"];

			// get the binding list
			IBindingList blist = cm.List as IBindingList;

			// find the newly added record
			int row = blist.Find(prop, i);
			// now show it as selected in the grid
			this.c1TrueDBGrid1.SelectedRows.Clear();
			this.c1TrueDBGrid1.SelectedRows.Add(row);

		}
		private void button1_Click(object sender, System.EventArgs e)
		{
			Form2 f = new Form2();
			if (f.ShowDialog(this) == DialogResult.OK)
			{
				// add the new record to the datasource
				DataRow dr = dt.NewRow();
				int i = System.Convert.ToInt32(f.textBox1.Text);
				dr["Integer"] = i;
				dr["String"] = f.textBox2.Text;
				dt.Rows.Add(dr);
				// sort the data
				dt.DefaultView.Sort = "Integer";
				// now select it in the grid
				_findrow(i);
			}
		}
	}
}