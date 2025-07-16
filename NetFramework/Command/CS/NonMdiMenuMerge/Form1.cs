using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WindowsApplication5
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.Command.C1MainMenu c1MainMenu1;
        private C1.Win.Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.Command.C1CommandLink c1CommandLink1;
        private C1.Win.Command.C1CommandMenu c1CommandMenu1;
        private C1.Win.Command.C1CommandLink c1CommandLink2;
        private C1.Win.Command.C1Command c1Command1;
        private C1.Win.Command.C1CommandLink c1CommandLink3;
        private C1.Win.Command.C1Command c1Command2;
        private C1.Win.Command.C1CommandLink c1CommandLink4;
        private C1.Win.Command.C1Command c1Command3;
        private C1.Win.Command.C1CommandLink c1CommandLink5;
        private C1.Win.Command.C1Command c1Command4;
        private C1.Win.Command.C1CommandLink c1CommandLink6;
        private C1.Win.Command.C1CommandMenu c1CommandMenu2;
        private C1.Win.Command.C1CommandLink c1CommandLink7;
        private C1.Win.Command.C1Command c1Command5;
        private C1.Win.Command.C1CommandMenu c1CommandMenu3;
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
            this.c1MainMenu1 = new C1.Win.Command.C1MainMenu();
            this.c1CommandHolder1 = new C1.Win.Command.C1CommandHolder();
            this.c1CommandMenu1 = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink2 = new C1.Win.Command.C1CommandLink();
            this.c1Command1 = new C1.Win.Command.C1Command();
            this.c1CommandLink3 = new C1.Win.Command.C1CommandLink();
            this.c1Command2 = new C1.Win.Command.C1Command();
            this.c1CommandLink4 = new C1.Win.Command.C1CommandLink();
            this.c1Command3 = new C1.Win.Command.C1Command();
            this.c1CommandLink5 = new C1.Win.Command.C1CommandLink();
            this.c1Command4 = new C1.Win.Command.C1Command();
            this.c1CommandMenu2 = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink7 = new C1.Win.Command.C1CommandLink();
            this.c1Command5 = new C1.Win.Command.C1Command();
            this.c1CommandMenu3 = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink1 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink6 = new C1.Win.Command.C1CommandLink();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1MainMenu1
            // 
            this.c1MainMenu1.CommandHolder = this.c1CommandHolder1;
            this.c1MainMenu1.CommandLinks.Add(this.c1CommandLink1);
            this.c1MainMenu1.CommandLinks.Add(this.c1CommandLink6);
            this.c1MainMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1MainMenu1.Name = "c1MainMenu1";
            this.c1MainMenu1.Size = new System.Drawing.Size(360, 22);
            this.c1MainMenu1.Text = "c1MainMenu1";
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.c1CommandMenu1);
            this.c1CommandHolder1.Commands.Add(this.c1Command1);
            this.c1CommandHolder1.Commands.Add(this.c1Command2);
            this.c1CommandHolder1.Commands.Add(this.c1Command3);
            this.c1CommandHolder1.Commands.Add(this.c1Command4);
            this.c1CommandHolder1.Commands.Add(this.c1CommandMenu2);
            this.c1CommandHolder1.Commands.Add(this.c1Command5);
            this.c1CommandHolder1.Commands.Add(this.c1CommandMenu3);
            this.c1CommandHolder1.Owner = this;
            // 
            // c1CommandMenu1
            // 
            this.c1CommandMenu1.CommandLinks.Add(this.c1CommandLink2);
            this.c1CommandMenu1.CommandLinks.Add(this.c1CommandLink3);
            this.c1CommandMenu1.CommandLinks.Add(this.c1CommandLink4);
            this.c1CommandMenu1.CommandLinks.Add(this.c1CommandLink5);
            this.c1CommandMenu1.Name = "c1CommandMenu1";
            this.c1CommandMenu1.Text = "&File";
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.Command = this.c1Command1;
            // 
            // c1Command1
            // 
            this.c1Command1.Name = "c1Command1";
            this.c1Command1.Text = "&New";
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.Command = this.c1Command2;
            // 
            // c1Command2
            // 
            this.c1Command2.Name = "c1Command2";
            this.c1Command2.Text = "&Open";
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Command = this.c1Command3;
            // 
            // c1Command3
            // 
            this.c1Command3.Name = "c1Command3";
            this.c1Command3.Text = "&Close";
            // 
            // c1CommandLink5
            // 
            this.c1CommandLink5.Command = this.c1Command4;
            this.c1CommandLink5.Delimiter = true;
            // 
            // c1Command4
            // 
            this.c1Command4.Name = "c1Command4";
            this.c1Command4.Text = "E&xit";
            this.c1Command4.Click += new C1.Win.Command.ClickEventHandler(this.c1Command4_Click);
            // 
            // c1CommandMenu2
            // 
            this.c1CommandMenu2.CommandLinks.Add(this.c1CommandLink7);
            this.c1CommandMenu2.Name = "c1CommandMenu2";
            this.c1CommandMenu2.Text = "&Window";
            // 
            // c1CommandLink7
            // 
            this.c1CommandLink7.Command = this.c1Command5;
            // 
            // c1Command5
            // 
            this.c1Command5.Name = "c1Command5";
            this.c1Command5.Text = "&New child window";
            this.c1Command5.CommandStateQuery += new C1.Win.Command.CommandStateQueryEventHandler(this.c1Command5_CommandStateQuery);
            this.c1Command5.Click += new C1.Win.Command.ClickEventHandler(this.c1Command5_Click);
            // 
            // c1CommandMenu3
            // 
            this.c1CommandMenu3.Name = "c1CommandMenu3";
            this.c1CommandMenu3.Text = "&Window";
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.Command = this.c1CommandMenu1;
            // 
            // c1CommandLink6
            // 
            this.c1CommandLink6.Command = this.c1CommandMenu2;
            this.c1CommandLink6.MergeType = C1.Win.Command.MenuMerge.MergeItems;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 141);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click Window | New Child Window to create a non-MDI child form. That form\'s menu " +
                "will be merged with the current menu. ";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(360, 163);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.label1,
                                                                          this.c1MainMenu1});
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
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

        // This will keep track of the currently open child form.
        // If we want to support multiple child forms, we must take
        // additional steps for that (e.g. unmerge one child's menus
        // when it is deactivated, merge another when it is activated,
        // etc. - depending on our needs).
        private Form2 _form2 = null;

        private void c1Command5_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            System.Diagnostics.Debug.Assert(_form2 == null);
            // Create the child form
            _form2 = new Form2();
            // Use C1CommandHolder.MergeCommandLinks to merge the links from the
            // current menu with the links in the child form's menu.
            // We pass the current main menu's CommandLinks as both one of the
            // inputs and the output, so that the merged links will replace
            // the current links.
            this.c1CommandHolder1.MergeCommandLinks(this.c1MainMenu1.CommandLinks,
                this.c1MainMenu1.CommandLinks, _form2.c1MainMenu1.CommandLinks);
            // Hide the child form's menu - its commands are now available via
            // the main form's main menu
            _form2.c1MainMenu1.Hide();
            // When the child is closed, we want to restore the main form's menu.
            // Wire up an event handler to do that.
            _form2.Closing += new CancelEventHandler(Form2_Closing);
            // Finally, show the child form.
            _form2.Show();
        }

        private void Form2_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // This will restore the original menu of the main form
            this.c1CommandHolder1.UnmergeCommandLinks(this.c1MainMenu1.CommandLinks,
                this.c1MainMenu1.CommandLinks, ((Form2)sender).c1MainMenu1.CommandLinks);
            _form2 = null;
        }

        private void c1Command5_CommandStateQuery(object sender, C1.Win.Command.CommandStateQueryEventArgs e)
        {
            // we do not allow to create more than 1 child
            e.Enabled = _form2 == null;
        }

        private void c1Command4_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            Application.Exit();
        }
    }
}
