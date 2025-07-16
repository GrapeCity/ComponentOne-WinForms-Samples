using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.Sizer;

namespace FindControl
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.Sizer.C1Sizer c1Sizer1;
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
            this.c1Sizer1 = new C1.Win.Sizer.C1Sizer();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Border.Color = System.Drawing.Color.DimGray;
            this.c1Sizer1.Border.Thickness = new System.Windows.Forms.Padding(6);
            this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Sizer1.GridDefinition = "87.3684210526316:False:False;\t90:False:False;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 0);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Padding = new System.Windows.Forms.Padding(12);
            this.c1Sizer1.Size = new System.Drawing.Size(360, 285);
            this.c1Sizer1.TabIndex = 0;
            this.c1Sizer1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(360, 285);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
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
			// create the grid
			C1.Win.Sizer.Grid g = this.c1Sizer1.Grid;
			g.Rows.Count = 8;
			g.Columns.Count = 5;

            Label lbl = new Label();
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Name = lbl.Text = "label with ColSpan = 4";
            lbl.AutoSize = false;
            lbl.BackColor = Color.Red;
            this.c1Sizer1.AddControl(lbl, 0, 0, 1, 4);

            lbl = new Label();
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Name = lbl.Text = "label with RowSpan = 7";
            lbl.AutoSize = false;
            lbl.BackColor = Color.Green;
            this.c1Sizer1.AddControl(lbl, 1, 0, 7, 1);

            // create some controls
			for (int r = 0; r < g.Rows.Count; r++)
			{
				for (int c = 0; c < g.Columns.Count; c++)
				{
					Button btn = new Button();
					btn.Parent = this.c1Sizer1;
                    btn.Bounds = this.c1Sizer1.GetCellBounds(r, c);
					btn.Name = btn.Text = "Btn " + c1Sizer1.Controls.Count;
				}
			}
            
            // find controls at specific row/col coordinates
			for (int r = 0; r < g.Rows.Count; r++)
			{
				for (int c = 0; c < g.Columns.Count; c++)
				{
					Control ctl = this.c1Sizer1.GetControlAtCell(r, c);
                    if (ctl != null)
					    Console.WriteLine(ctl.Name);
				}
			}
		}
    }
}
