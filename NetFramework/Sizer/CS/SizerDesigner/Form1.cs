using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1Sizer;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBar toolBar1;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
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
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(488, 42);
			this.toolBar1.TabIndex = 0;
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Controls.Add(this.button1);
			this.c1Sizer1.Controls.Add(this.button2);
			this.c1Sizer1.Controls.Add(this.button3);
			this.c1Sizer1.Controls.Add(this.button4);
			this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Sizer1.GridDefinition = @"11.6438356164384:False:False;11.3013698630137:False:False;11.6438356164384:False:False;11.6438356164384:False:False;11.6438356164384:False:False;11.6438356164384:False:False;11.3013698630137:False:False;11.6438356164384:False:False;	8.60655737704918:False:False;8.81147540983607:False:False;8.19672131147541:False:False;8.60655737704918:False:False;8.60655737704918:False:False;8.81147540983607:False:False;8.60655737704918:False:False;8.60655737704918:False:False;8.40163934426229:False:False;8.40163934426229:False:False;8.60655737704918:False:False;";
			this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.c1Sizer1.Location = new System.Drawing.Point(0, 42);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(488, 292);
			this.c1Sizer1.SplitterWidth = 2;
			this.c1Sizer1.TabIndex = 1;
			this.c1Sizer1.TabStop = false;
			this.c1Sizer1.Paint += new System.Windows.Forms.PaintEventHandler(this.c1Sizer1_Paint);
			this.c1Sizer1.DragDrop += new System.Windows.Forms.DragEventHandler(this.c1Sizer1_DragDrop);
			this.c1Sizer1.DragOver += new System.Windows.Forms.DragEventHandler(this.c1Sizer1_DragOver);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.button1.Location = new System.Drawing.Point(4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(42, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.button2.Location = new System.Drawing.Point(4, 40);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(42, 33);
			this.button2.TabIndex = 0;
			this.button2.Text = "button1";
			this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.button3.Location = new System.Drawing.Point(4, 75);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(42, 34);
			this.button3.TabIndex = 0;
			this.button3.Text = "button1";
			this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.button4.Location = new System.Drawing.Point(4, 111);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(42, 34);
			this.button4.TabIndex = 0;
			this.button4.Text = "button1";
			this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(488, 334);
			this.Controls.Add(this.c1Sizer1);
			this.Controls.Add(this.toolBar1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
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

		private void c1Sizer1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			// paint sizer grid
			foreach (Band row in this.c1Sizer1.Grid.Rows)
			{
				Rectangle rcrow = row.Bounds;
				foreach (Band col in this.c1Sizer1.Grid.Columns)
				{
					Rectangle rccol = col.Bounds;
					Rectangle rccel = Rectangle.Intersect(rcrow, rccol);
					ControlPaint.DrawBorder3D(e.Graphics, rccel, Border3DStyle.SunkenOuter);
				}
			}
		}

		private void button1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// start dragging control on mouse down
			this.c1Sizer1.DoDragDrop(sender, DragDropEffects.Move);
		}
		private void c1Sizer1_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			// allow move effect if dragging control and over a cell
			Control ctl = e.Data.GetData(typeof(Button)) as Control;
			if (ctl != null)
			{
				Rectangle rc = GetCellAt(e.X, e.Y);
				if (rc.Width > 0)
				{
					e.Effect = DragDropEffects.Move;
				}
			}
		}
		private void c1Sizer1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			// move control when finished dragging
			Control ctl = e.Data.GetData(typeof(Button)) as Control;
			if (ctl != null)
			{
				Rectangle rc = GetCellAt(e.X, e.Y);
				if (rc.Width > 0)
				{
					ctl.Bounds = rc;
					Console.WriteLine(this.c1Sizer1.GridDefinition);
				}
			}
		}
		private Rectangle GetCellAt(int x, int y)
		{
			// find point
			Point pt = new Point(x, y);
			pt = this.c1Sizer1.PointToClient(pt);

			// find cell
			foreach (Band row in this.c1Sizer1.Grid.Rows)
			{
				Rectangle rcrow = row.Bounds;
				if (rcrow.Contains(pt))
				{
					foreach (Band col in this.c1Sizer1.Grid.Columns)
					{
						Rectangle rccol = col.Bounds;
						if (rccol.Contains(pt))
						{
							return Rectangle.Intersect(rcrow, rccol);
						}
					}
				}
			}

			// point is not on a cell
			return Rectangle.Empty;
		}
	}
}
