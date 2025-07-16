using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Blinker
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.CheckBox _chkBlink;
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
			this._flex = new C1.Win.FlexGrid.C1FlexGrid();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this._chkBlink = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Location = new System.Drawing.Point(0, 32);
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(376, 173);
			this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// _chkBlink
			// 
			this._chkBlink.Checked = true;
			this._chkBlink.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkBlink.Dock = System.Windows.Forms.DockStyle.Top;
			this._chkBlink.Name = "_chkBlink";
			this._chkBlink.Size = new System.Drawing.Size(376, 32);
			this._chkBlink.TabIndex = 1;
			this._chkBlink.Text = "&Blink";
			this._chkBlink.CheckedChanged += new System.EventHandler(this._chkBlink_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(376, 205);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex,
																		  this._chkBlink});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Blinking Cells";
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
			// initialize the grid
			_flex.Cols[0].Width = _flex.Rows[0].HeightDisplay;
			_flex[1,1] = "This row blinks";

			// create new style and assign it to row 1
			_flex.Rows[1].Style = _flex.Styles.Add("Blink");

			// start flashing
			timer1.Interval = 400;
			timer1.Enabled = true;
		}
		private void _chkBlink_CheckedChanged(object sender, System.EventArgs e)
		{
			timer1.Enabled = _chkBlink.Checked;		
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			// toggle forecolor
			C1.Win.FlexGrid.CellStyle cs = _flex.Styles["Blink"];
			cs.ForeColor = (cs.ForeColor == Color.Black)
				? Color.Red
				: Color.Black;
		}
	}
}
