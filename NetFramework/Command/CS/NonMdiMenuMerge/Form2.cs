using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsApplication5
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
        public C1.Win.Command.C1MainMenu c1MainMenu1;
        private C1.Win.Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.Command.C1CommandLink c1CommandLink1;
        private C1.Win.Command.C1CommandMenu c1CommandMenu1;
        private C1.Win.Command.C1CommandLink c1CommandLink2;
        private C1.Win.Command.C1Command c1Command1;
        private C1.Win.Command.C1CommandLink c1CommandLink3;
        private C1.Win.Command.C1Command c1Command2;
        private C1.Win.Command.C1CommandLink c1CommandLink4;
        private C1.Win.Command.C1CommandMenu c1CommandMenu2;
        private C1.Win.Command.C1CommandLink c1CommandLink5;
        private C1.Win.Command.C1Command c1Command3;
        private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form2()
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
            this.c1MainMenu1 = new C1.Win.Command.C1MainMenu();
            this.c1CommandHolder1 = new C1.Win.Command.C1CommandHolder();
            this.c1CommandMenu1 = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink2 = new C1.Win.Command.C1CommandLink();
            this.c1Command1 = new C1.Win.Command.C1Command();
            this.c1CommandLink3 = new C1.Win.Command.C1CommandLink();
            this.c1Command2 = new C1.Win.Command.C1Command();
            this.c1CommandLink1 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink4 = new C1.Win.Command.C1CommandLink();
            this.c1CommandMenu2 = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink5 = new C1.Win.Command.C1CommandLink();
            this.c1Command3 = new C1.Win.Command.C1Command();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1MainMenu1
            // 
            this.c1MainMenu1.CommandHolder = this.c1CommandHolder1;
            this.c1MainMenu1.CommandLinks.Add(this.c1CommandLink1);
            this.c1MainMenu1.CommandLinks.Add(this.c1CommandLink4);
            this.c1MainMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1MainMenu1.Name = "c1MainMenu1";
            this.c1MainMenu1.Size = new System.Drawing.Size(296, 22);
            this.c1MainMenu1.Text = "c1MainMenu1";
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.c1CommandMenu1);
            this.c1CommandHolder1.Commands.Add(this.c1Command1);
            this.c1CommandHolder1.Commands.Add(this.c1Command2);
            this.c1CommandHolder1.Commands.Add(this.c1CommandMenu2);
            this.c1CommandHolder1.Commands.Add(this.c1Command3);
            this.c1CommandHolder1.Owner = this;
            // 
            // c1CommandMenu1
            // 
            this.c1CommandMenu1.CommandLinks.Add(this.c1CommandLink2);
            this.c1CommandMenu1.CommandLinks.Add(this.c1CommandLink3);
            this.c1CommandMenu1.Name = "c1CommandMenu1";
            this.c1CommandMenu1.Text = "&Do something on Form2";
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.Command = this.c1Command1;
            this.c1CommandLink2.Text = "Set foreground";
            // 
            // c1Command1
            // 
            this.c1Command1.Name = "c1Command1";
            this.c1Command1.Text = "Do &1";
            this.c1Command1.Click += new C1.Win.Command.ClickEventHandler(this.c1Command1_Click);
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.Command = this.c1Command2;
            this.c1CommandLink3.Text = "Set background";
            // 
            // c1Command2
            // 
            this.c1Command2.Name = "c1Command2";
            this.c1Command2.Text = "Do &2";
            this.c1Command2.Click += new C1.Win.Command.ClickEventHandler(this.c1Command2_Click);
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.Command = this.c1CommandMenu1;
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Command = this.c1CommandMenu2;
            this.c1CommandLink4.MergeType = C1.Win.Command.MenuMerge.MergeItems;
            // 
            // c1CommandMenu2
            // 
            this.c1CommandMenu2.CommandLinks.Add(this.c1CommandLink5);
            this.c1CommandMenu2.Name = "c1CommandMenu2";
            this.c1CommandMenu2.Text = "&Window";
            // 
            // c1CommandLink5
            // 
            this.c1CommandLink5.Command = this.c1Command3;
            // 
            // c1Command3
            // 
            this.c1Command3.Name = "c1Command3";
            this.c1Command3.Text = "Maximize Form2";
            this.c1Command3.Click += new C1.Win.Command.ClickEventHandler(this.c1Command3_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 221);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is a non-MDI child form. Its main menu  is merged into the main form\'s menu " +
                "when this form is created.";
            // 
            // Form2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(296, 243);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.label1,
                                                                          this.c1MainMenu1});
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

        private void c1Command1_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            this.ForeColor = Color.Brown;
        }

        private void c1Command2_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            this.BackColor = Color.Aquamarine;
        }

        private void c1Command3_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
	}
}
