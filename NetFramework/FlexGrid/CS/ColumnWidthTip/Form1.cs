using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace ColumnWidthTip
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.C1FlexGrid.C1FlexGrid _flex;
        private System.Windows.Forms.ToolTip _tip;
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
            this.components = new System.ComponentModel.Container();
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this._tip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:25;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Name = "_flex";
            this._flex.ShowCursor = true;
            this._flex.Size = new System.Drawing.Size(584, 368);
            this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Microsoft Sans Serif, 7.8pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
            this._flex.TabIndex = 0;
            this._flex.MouseMove += new System.Windows.Forms.MouseEventHandler(this._flex_MouseMove);
            this._flex.AfterResizeColumn += new C1.Win.C1FlexGrid.RowColEventHandler(this._flex_AfterResizeColumn);
            this._flex.BeforeResizeColumn += new C1.Win.C1FlexGrid.RowColEventHandler(this._flex_BeforeResizeColumn);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(584, 368);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this._flex});
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Column Sizing Tooltips";
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
            string sql = "select * from employees";
            string conn = GetConnectionString();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _flex.DataSource = dt;
        }

        int _colResize = -1;
        int _startX = 0;
        void _flex_BeforeResizeColumn(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                // user is about to resize a column
                _colResize = e.Col;
                _startX = Control.MousePosition.X;
            }
        }
        void _flex_AfterResizeColumn(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (_colResize > -1)
            {
                // user is done resizing column
                Console.WriteLine("col[{0}].width is now {1} pixels.", _colResize, _flex.Cols[_colResize].WidthDisplay);
                _colResize = -1;
                _tip.SetToolTip(_flex, null);
            }
        }
        void _flex_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (_colResize > -1)
            {
                // user canceled resizing
                if (_flex.Cursor == Cursors.Default)
                {
                    _colResize = -1;
                    _tip.SetToolTip(_flex, null);
                    return;
                }

                // update tooltip
                int width = _flex.Cols[_colResize].WidthDisplay;
                width += Control.MousePosition.X - _startX;
                if (width < 0) width = 0;
                string tip = string.Format("{0} pixels", width);
                if (tip != _tip.GetToolTip(_flex))
                    _tip.SetToolTip(_flex, tip);
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
