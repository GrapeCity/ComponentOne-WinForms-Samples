using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.Win.FlexGrid;

namespace BoundDelete
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private C1.Win.FlexGrid.C1FlexGrid _flex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._flex = new C1.Win.FlexGrid.C1FlexGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right);
            this._flex.BackColor = System.Drawing.SystemColors.Window;
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this._flex.Location = new System.Drawing.Point(8, 8);
            this._flex.Name = "_flex";
            this._flex.Size = new System.Drawing.Size(344, 240);
            this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
            this._flex.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.button1.Location = new System.Drawing.Point(8, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Data";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.button2.Location = new System.Drawing.Point(136, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete Selection";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(360, 285);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this._flex,
																		  this.button2});
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Delete rows in bound/listbox mode";
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
            // set up the grid
            _flex.Cols[0].Width = _flex.Rows[0].HeightDisplay;
            _flex.SelectionMode = SelectionModeEnum.ListBox;
            _flex.ShowCursor = true;
            _flex.AllowAddNew = _flex.AllowDelete = true;

            // load the data
            string rs = "select * from customers;";
            string cn = GetConnectionString();
            OleDbDataAdapter da = new OleDbDataAdapter(rs, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _flex.DataSource = dt;
        }
        void button1_Click(object sender, System.EventArgs e)
        {
            // restore original data
            DataTable dt = (DataTable)_flex.DataSource;
            dt.RejectChanges();
        }
        void button2_Click(object sender, System.EventArgs e)
        {
            // delete selected rows
            _flex.Redraw = false;
            foreach (Row r in _flex.Rows.Selected)
                _flex.Rows.Remove(r.Index);
            _flex.Redraw = true;
        }
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
