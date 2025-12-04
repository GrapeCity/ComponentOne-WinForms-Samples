using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using C1.Win.FlexGrid;

namespace BarChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this._flex = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:25;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 0);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 17;
            this._flex.Size = new System.Drawing.Size(808, 382);
            this._flex.TabIndex = 0;
            this._flex.OwnerDrawCell += new C1.Win.FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(808, 382);
            this.Controls.Add(this._flex);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: OwnerDraw Chart";
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

            // hide ID columns so the bars stand out more
            foreach (Column col in _flex.Cols)
                if (col.Name.EndsWith("ID"))
                    col.Visible = false;

            // attach scaling info to each numeric column
            int r1 = _flex.Rows.Fixed;
            int r2 = _flex.Rows.Count-1;
            string[] barCols = new string[] { "UnitPrice", "UnitsInStock", "UnitsOnOrder", "ReorderLevel" };
            foreach (string s in barCols)
            {
                Column col = _flex.Cols[s];
                double max = _flex.Aggregate(AggregateEnum.Max, r1, col.Index, r2, col.Index);
                col.UserData = max;
            }

            // turn on ownerdraw
            _flex.DrawMode = DrawModeEnum.OwnerDraw;
        }

        void _flex_OwnerDrawCell(object sender, C1.Win.FlexGrid.OwnerDrawCellEventArgs e)
        {
            if (_flex.Cols[e.Col].UserData != null && e.Row >= _flex.Rows.Fixed)
            {
                double value;
                if (double.TryParse(_flex.GetDataDisplay(e.Row, e.Col), NumberStyles.Any, CultureInfo.CurrentCulture, out value))
                {
                    // calculate bar extent
                    Rectangle rc = e.Bounds;
                    double max = (double)_flex.Cols[e.Col].UserData;
                    rc.Width = (int)(_flex.Cols[e.Col].WidthDisplay * value / max);

                    // draw background
                    e.DrawCell(DrawCellFlags.Background | DrawCellFlags.Border);

                    // draw bar
                    rc.Inflate(-2,-2);
                    e.Graphics.FillRectangle(Brushes.Gold, rc);
                    rc.Inflate(-1,-1);
                    e.Graphics.FillRectangle(Brushes.LightGoldenrodYellow, rc);

                    // draw cell content
                    e.DrawCell(DrawCellFlags.Content);
                }
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
