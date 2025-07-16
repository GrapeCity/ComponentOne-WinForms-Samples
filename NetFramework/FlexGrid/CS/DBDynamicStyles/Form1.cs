using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace DynamicStyles
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
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(591, 484);
			this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.OwnerDrawCell += new C1.Win.FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(591, 484);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Dynamic Styles";
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
            // get the data
            string strSelect = "select * from Products;";
            string strConn   = GetConnectionString();
            OleDbDataAdapter da = new OleDbDataAdapter(strSelect, strConn);
            DataTable dt = new DataTable("Products");
            da.Fill(dt);

            // bind to grid
            _flex.ShowCursor = true;
            _flex.Cols[0].Width = _flex.Rows.DefaultSize;
            _flex.DataSource = dt;

            // create custom style and use OwnerDraw to apply them
            C1.Win.FlexGrid.CellStyle s = _flex.Styles.Add("Critical");
            s.BackColor = Color.DarkOrchid;
            s.ForeColor = Color.White;
            s.Font = new Font(_flex.Font, FontStyle.Bold);
            _flex.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
        }

        void _flex_OwnerDrawCell(object sender, C1.Win.FlexGrid.OwnerDrawCellEventArgs e)
        {
            // ignore fixed cells
            if (e.Row < _flex.Rows.Fixed || e.Col < _flex.Cols.Fixed)
                return;

            // apply custom style if reorder level is critical
			if (_flex.Cols[e.Col].Name == "UnitsInStock")
			{
				if ((short)_flex[e.Row, "UnitsInStock"] < (short)_flex[e.Row, "ReorderLevel"])
					e.Style = _flex.Styles["Critical"];
			}
        }

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
