using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Mdi
{
	/// <summary>
	/// Summary description for ChildForm.
	/// </summary>
	public class ChildForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Sizer.C1SizerLight _sizerLight;
		private System.ComponentModel.IContainer components;

		public ChildForm()
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
				if(components != null)
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this._sizerLight = new C1.Win.C1Sizer.C1SizerLight(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._sizerLight)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.133928F, System.Drawing.FontStyle.Italic);
			this.button1.Location = new System.Drawing.Point(160, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 39);
			this.button1.TabIndex = 0;
			this.button1.Text = "Undo Nothing";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.133928F, System.Drawing.FontStyle.Italic);
			this.button2.Location = new System.Drawing.Point(8, 58);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(296, 39);
			this.button2.TabIndex = 1;
			this.button2.Text = "Resize form 20 times.";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.133928F, System.Drawing.FontStyle.Italic);
			this.button3.Location = new System.Drawing.Point(8, 9);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(144, 39);
			this.button3.TabIndex = 2;
			this.button3.Text = "Do Nothing";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(8, 108);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(296, 92);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "Welcome to C1SizerLight. It works in MDI Forms too.";
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton2,
																						this.toolBarButton3,
																						this.toolBarButton4,
																						this.toolBarButton5,
																						this.toolBarButton6,
																						this.toolBarButton7,
																						this.toolBarButton8,
																						this.toolBarButton9});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(312, 25);
			this.toolBar1.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.button3,
																				 this.button2,
																				 this.textBox1,
																				 this.button1});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(312, 212);
			this.panel1.TabIndex = 5;
			// 
			// _sizerLight
			// 
			this._sizerLight.ResizingFont += new C1.Win.C1Sizer.C1SizerLightEventHandler(this._sizerLight_ResizingFont);
			// 
			// ChildForm
			// 
			this._sizerLight.SetAutoResize(this, true);
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(312, 237);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.toolBar1});
			this.Name = "ChildForm";
			this.Text = "ChildForm";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._sizerLight)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		// only resize fonts for button controls
        private void _sizerLight_ResizingFont(object sender, C1.Win.C1Sizer.C1SizerLightEventArgs e)
        {
            if (!(e.Control is System.Windows.Forms.Button))
                e.Cancel = true;
        }

		// resize the child form 20 times
		private void button2_Click(object sender, System.EventArgs e)
		{
			FormWindowState ws = WindowState;
			WindowState = FormWindowState.Normal;
			Random r = new Random();
			for (int i = 0; i < 20; i++)
				Size = new Size(r.Next(50,300), r.Next(50,300));
			WindowState = ws;
		}
	}
}
