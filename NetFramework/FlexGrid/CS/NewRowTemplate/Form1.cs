using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;


namespace TemplateRow
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
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:1{DataType:System.String;TextAlign:LeftCenter;}\t2{DataType:" +
				"System.DateTime;Format:\"d\";TextAlign:LeftCenter;}\t3{DataType:System.Boolean;Imag" +
				"eAlign:CenterCenter;}\t4{DataType:System.String;TextAlign:LeftCenter;ComboList:\"a" +
				"aa|bbb|ccc\";}\t";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.KeyActionTab = C1.Win.FlexGrid.KeyActionEnum.MoveAcross;
			this._flex.Name = "_flex";
			this._flex.Rows.DefaultSize = 17;
			this._flex.Size = new System.Drawing.Size(469, 292);
			this._flex.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(469, 292);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: AddNewRow template above grid";
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
            string conn = GetConnectionString();
			string rs = "select * from customers";

			// create data table
			OleDbDataAdapter da = new OleDbDataAdapter(rs, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);

			// initialize grid
			_flex.DataSource = dt;
			_flex.Cols[0].Width = _flex.Rows.DefaultSize;
			_flex.ShowCursor = true;

			// add template row
			TemplateRow tr = new TemplateRow(_flex);
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
