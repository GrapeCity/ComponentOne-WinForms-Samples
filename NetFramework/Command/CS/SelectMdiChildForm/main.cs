using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SelectMdiChildForm
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.Command.C1MainMenu c1MainMenu1;
        private C1.Win.Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.Command.C1CommandLink c1CommandLink1;
        private C1.Win.Command.C1CommandMenu cmdFile;
        private C1.Win.Command.C1CommandLink c1CommandLink2;
        private C1.Win.Command.C1Command cmdFileNew;
        private C1.Win.Command.C1CommandLink c1CommandLink4;
        private C1.Win.Command.C1Command cmdExit;
        private C1.Win.Command.C1CommandLink c1CommandLink5;
        private C1.Win.Command.C1CommandMenu cmdWindow;
        private C1.Win.Command.C1CommandLink c1CommandLink6;
        private C1.Win.Command.C1CommandMdiList c1CommandMdiList1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.c1MainMenu1 = new C1.Win.Command.C1MainMenu();
            this.c1CommandHolder1 = new C1.Win.Command.C1CommandHolder();
            this.cmdFile = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink2 = new C1.Win.Command.C1CommandLink();
            this.cmdFileNew = new C1.Win.Command.C1Command();
            this.c1CommandLink4 = new C1.Win.Command.C1CommandLink();
            this.cmdExit = new C1.Win.Command.C1Command();
            this.cmdWindow = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink6 = new C1.Win.Command.C1CommandLink();
            this.c1CommandMdiList1 = new C1.Win.Command.C1CommandMdiList();
            this.c1CommandLink1 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink5 = new C1.Win.Command.C1CommandLink();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1MainMenu1
            // 
            this.c1MainMenu1.CommandHolder = this.c1CommandHolder1;
            this.c1MainMenu1.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink5});
            this.c1MainMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.c1MainMenu1.Name = "c1MainMenu1";
            this.c1MainMenu1.Size = new System.Drawing.Size(544, 34);
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.cmdFile);
            this.c1CommandHolder1.Commands.Add(this.cmdFileNew);
            this.c1CommandHolder1.Commands.Add(this.cmdExit);
            this.c1CommandHolder1.Commands.Add(this.cmdWindow);
            this.c1CommandHolder1.Commands.Add(this.c1CommandMdiList1);
            this.c1CommandHolder1.Owner = this;
            this.c1CommandHolder1.SelectMdiChildFormClassName = "SelectMdiChildForm.SelectMdiChildForm";
            // 
            // cmdFile
            // 
            this.cmdFile.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink2,
            this.c1CommandLink4});
            this.cmdFile.Name = "cmdFile";
            this.cmdFile.ShortcutText = "";
            this.cmdFile.Text = "&File";
            this.cmdFile.Virgin = false;
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.Command = this.cmdFileNew;
            // 
            // cmdFileNew
            // 
            this.cmdFileNew.Name = "cmdFileNew";
            this.cmdFileNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.cmdFileNew.ShortcutText = "";
            this.cmdFileNew.Text = "&New";
            this.cmdFileNew.Virgin = false;
            this.cmdFileNew.Click += new C1.Win.Command.ClickEventHandler(this.cmdFileNew_Click);
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Command = this.cmdExit;
            this.c1CommandLink4.Delimiter = true;
            this.c1CommandLink4.MergeOrder = 2;
            // 
            // cmdExit
            // 
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.cmdExit.ShortcutText = "";
            this.cmdExit.Text = "E&xit";
            this.cmdExit.Virgin = false;
            this.cmdExit.Click += new C1.Win.Command.ClickEventHandler(this.cmdExit_Click);
            // 
            // cmdWindow
            // 
            this.cmdWindow.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink6});
            this.cmdWindow.Name = "cmdWindow";
            this.cmdWindow.ShortcutText = "";
            this.cmdWindow.Text = "&Window";
            this.cmdWindow.Virgin = false;
            // 
            // c1CommandLink6
            // 
            this.c1CommandLink6.Command = this.c1CommandMdiList1;
            // 
            // c1CommandMdiList1
            // 
            this.c1CommandMdiList1.Name = "c1CommandMdiList1";
            this.c1CommandMdiList1.ShortcutText = "";
            this.c1CommandMdiList1.Virgin = false;
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.Command = this.cmdFile;
            this.c1CommandLink1.MergeType = C1.Win.Command.MenuMerge.MergeItems;
            // 
            // c1CommandLink5
            // 
            this.c1CommandLink5.Command = this.cmdWindow;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 22);
            this.ClientSize = new System.Drawing.Size(544, 411);
            this.Controls.Add(this.c1MainMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "SelectMdiChildForm Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
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

        private void cmdFileNew_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            createNewMdiChild();
        }

        private void cmdExit_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            Application.Exit();
        }

        private void createNewMdiChild()
        {
            MdiChild mc = new MdiChild();
            mc.MdiParent = this;
            mc.Text = string.Format("MDI Child Window {0}", this.MdiChildren.Length);
            mc.Show();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // create some child windows
            for (int i = 0; i < 20; ++i)
                createNewMdiChild();
            // force the form to show
            this.Show();
            // present the user with the (customized) list of child windows
            this.c1CommandMdiList1.ShowSelectorWindow();
        }
    }
}
