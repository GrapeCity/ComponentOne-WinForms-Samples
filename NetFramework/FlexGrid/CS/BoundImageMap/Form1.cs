using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace BoundImageMap
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
			this._flex.AllowEditing = false;
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(520, 333);
			this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(520, 333);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Bound ImageMap";
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
			// bind grid to a data source
			string conn = GetConnectionString();
			OleDbDataAdapter da = new OleDbDataAdapter("select * from products", conn);
			DataTable dt = new DataTable("Products");
			da.Fill(dt);
			_flex.DataSource = dt;

			// open categories map
			da = new OleDbDataAdapter("select * from categories", conn);
			dt = new DataTable("Categories");
			da.Fill(dt);

			// build data map
			Hashtable ht = new Hashtable();
			foreach (DataRow dr in dt.Rows)
			{
				ht.Add(dr["CategoryID"], LoadImage(dr["Picture"] as byte[]));
			}

			// assign ImageMap to categories column
			_flex.Cols["CategoryID"].ImageMap = ht;
			_flex.Cols["CategoryID"].ImageAndText = false;

			// finish setting up the grid
			_flex.Cols[0].Width = _flex.Rows[0].HeightDisplay;
			_flex.ShowCursor = true;
			_flex.AutoSizeCols();
			_flex.AutoSizeRows();
		}

		static Image LoadImage(byte[] picData)
		{
			// make sure this is an embedded object
			const int bmData = 78;
			if (picData == null || picData.Length < bmData + 2) return null;
			if (picData[0] != 0x15 || picData[1] != 0x1c) return null;

			// we only handle bitmaps for now
			if (picData[bmData] != 'B' || picData[bmData + 1] != 'M') return null;

			// load the picture
			Image img = null;
			try
			{
				System.IO.MemoryStream ms = new System.IO.MemoryStream(picData, bmData, picData.Length - bmData);
				img = Image.FromStream(ms);
			} 
			catch {}

			// return what we got
			return img;
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
