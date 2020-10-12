using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ScrollPosition
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.C1FlexGrid.C1FlexGrid _flex;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
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
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Rows;
            this._flex.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right);
            this._flex.BackColor = System.Drawing.SystemColors.Window;
            this._flex.ColumnInfo = "2,1,0,0,0,75,Columns:0{Width:24;}\t1{Caption:\"Row Top\";}\t";
            this._flex.ExtendLastCol = true;
            this._flex.Location = new System.Drawing.Point(8, 56);
            this._flex.Name = "_flex";
            this._flex.Rows.Fixed = 2;
            this._flex.Size = new System.Drawing.Size(592, 456);
            this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
            this._flex.TabIndex = 0;
            this._flex.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this._flex_AfterScroll);
            this._flex.AfterResizeRow += new C1.Win.C1FlexGrid.RowColEventHandler(this._flex_AfterResizeRow);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "12";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "&go";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scroll to Row:";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(608, 520);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.label1,
                                                                          this.button1,
                                                                          this.textBox1,
                                                                          this._flex});
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: ScrollPosition";
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

        private void Form1_Load(object sender, System.EventArgs e)
        {
            _flex.Rows.DefaultSize = 20;
            for (int i = 1; i < _flex.Rows.Count; i++)
            {
                _flex[i,0] = i;
                _flex[i,1] = _flex.Rows[i].Top;
            }
        }
        private void _flex_AfterScroll(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
        {
            Console.WriteLine("ScrollPosition.Y = {0}", _flex.ScrollPosition.Y);
        }
        private void _flex_AfterResizeRow(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            for (int i = 1; i < _flex.Rows.Count; i++)
                _flex[i,1] = _flex.Rows[i].Top;
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                int topRow = int.Parse(textBox1.Text);
                int fixRow = _flex.Rows.Fixed + _flex.Rows.Frozen;
                int y = _flex.Rows[topRow].Top - _flex.Rows[fixRow].Top;
                _flex.ScrollPosition = new Point(0, -y);
            }
            catch (Exception x) // invalid input
            {
                MessageBox.Show(x.Message);
            }
        }
	}
}
