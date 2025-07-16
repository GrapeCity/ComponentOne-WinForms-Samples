using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WrapToolbar
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
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
		private System.Windows.Forms.ToolBarButton toolBarButton10;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
        private System.Windows.Forms.Button button1;
        private C1.Win.Sizer.C1SizerLight _sizerLight;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
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
			this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.button1 = new System.Windows.Forms.Button();
			this._sizerLight = new C1.Win.Sizer.C1SizerLight(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._sizerLight)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
																						this.toolBarButton9,
																						this.toolBarButton10,
																						this.toolBarButton11,
																						this.toolBarButton12});
			this.toolBar1.ButtonSize = new System.Drawing.Size(30, 36);
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(376, 39);
			this.toolBar1.TabIndex = 0;
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Text = "1";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.Text = "2";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.Text = "3";
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.Text = "4";
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Text = "5";
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.Text = "6";
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Text = "7";
			// 
			// toolBarButton8
			// 
			this.toolBarButton8.Text = "8";
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.Text = "9";
			// 
			// toolBarButton10
			// 
			this.toolBarButton10.Text = "10";
			// 
			// toolBarButton11
			// 
			this.toolBarButton11.Text = "11";
			// 
			// toolBarButton12
			// 
			this.toolBarButton12.Text = "12";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Gold;
			this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(172, 50);
			this.button1.TabIndex = 0;
			this.button1.Text = "One";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label1,
																				 this.button1,
																				 this.button2,
																				 this.button3,
																				 this.button4,
																				 this.button5,
																				 this.button6,
																				 this.button7,
																				 this.button8});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(376, 278);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 232);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(352, 40);
			this.label1.TabIndex = 1;
			this.label1.Text = "Resize the form and the buttons will be automatically resized. If the toolbar wra" +
				"ps, that will also be taken into account.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Gold;
			this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.button2.Location = new System.Drawing.Point(8, 64);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(172, 50);
			this.button2.TabIndex = 0;
			this.button2.Text = "Two";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Gold;
			this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.button3.Location = new System.Drawing.Point(8, 120);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(172, 50);
			this.button3.TabIndex = 0;
			this.button3.Text = "Three";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Gold;
			this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.button4.Location = new System.Drawing.Point(8, 176);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(172, 50);
			this.button4.TabIndex = 0;
			this.button4.Text = "Four";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Gold;
			this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.button5.Location = new System.Drawing.Point(192, 120);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(172, 50);
			this.button5.TabIndex = 0;
			this.button5.Text = "Seven";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Gold;
			this.button6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.button6.Location = new System.Drawing.Point(192, 64);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(172, 50);
			this.button6.TabIndex = 0;
			this.button6.Text = "Six";
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Gold;
			this.button7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.button7.Location = new System.Drawing.Point(192, 176);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(172, 50);
			this.button7.TabIndex = 0;
			this.button7.Text = "Eight";
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.Gold;
			this.button8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.button8.Location = new System.Drawing.Point(192, 8);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(172, 50);
			this.button8.TabIndex = 0;
			this.button8.Text = "Five";
			// 
			// Form1
			// 
			this._sizerLight.SetAutoResize(this, true);
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(376, 317);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.toolBar1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1SizerLight: Wrapping toolbar";
			((System.ComponentModel.ISupportInitialize)(this._sizerLight)).EndInit();
			this.panel1.ResumeLayout(false);
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

        private void c1SizerLight1_SizingFont(object sender, C1.Win.Sizer.C1SizerLightEventArgs e)
        {
            if (e.Control is Button)
                e.Cancel = true;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            // save Form's current size
            int wid = Width;
            int hei = Height;

            // show Button's current bounds
            Console.WriteLine("Before: Button bounds = {0}", button1.Bounds);

            // go crazy
            Random rnd = new Random();
            for (int i = 0; i < 500; i++)
            {
                Width  += rnd.Next(-50, 50);
                Height += rnd.Next(-50, 50);
                Application.DoEvents();
            }

            // restore Form's original size
            Width  = wid;
            Height = hei;

            // show Button's original bounds
            Console.WriteLine("After: Button bounds = {0}", button1.Bounds);
        }
	}
}
