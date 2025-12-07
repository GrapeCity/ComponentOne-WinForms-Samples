using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SelectMdiChildForm
{
	/// <summary>
	/// Summary description for MdiChild.
	/// </summary>
	public class MdiChild : System.Windows.Forms.Form
	{
        private C1.Win.Command.C1MainMenu c1MainMenu1;
        private C1.Win.Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.Command.C1CommandLink c1CommandLink1;
        private C1.Win.Command.C1CommandMenu cmdFile;
        private C1.Win.Command.C1CommandLink c1CommandLink2;
        private C1.Win.Command.C1Command cmdClose;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MdiChild()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiChild));
            this.c1MainMenu1 = new C1.Win.Command.C1MainMenu();
            this.c1CommandHolder1 = new C1.Win.Command.C1CommandHolder();
            this.cmdFile = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink2 = new C1.Win.Command.C1CommandLink();
            this.cmdClose = new C1.Win.Command.C1Command();
            this.c1CommandLink1 = new C1.Win.Command.C1CommandLink();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1MainMenu1
            // 
            this.c1MainMenu1.CommandHolder = this.c1CommandHolder1;
            this.c1MainMenu1.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink1});
            this.c1MainMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.c1MainMenu1.Name = "c1MainMenu1";
            this.c1MainMenu1.Size = new System.Drawing.Size(292, 34);
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.cmdFile);
            this.c1CommandHolder1.Commands.Add(this.cmdClose);
            this.c1CommandHolder1.Owner = this;
            // 
            // cmdFile
            // 
            this.cmdFile.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink2});
            this.cmdFile.Name = "cmdFile";
            this.cmdFile.ShortcutText = "";
            this.cmdFile.Text = "&File";
            this.cmdFile.Virgin = false;
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.Command = this.cmdClose;
            this.c1CommandLink2.MergeOrder = 1;
            // 
            // cmdClose
            // 
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Shortcut = System.Windows.Forms.Shortcut.CtrlF4;
            this.cmdClose.ShortcutText = "";
            this.cmdClose.Text = "&Close";
            this.cmdClose.Virgin = false;
            this.cmdClose.Click += new C1.Win.Command.ClickEventHandler(this.cmdClose_Click);
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.Command = this.cmdFile;
            this.c1CommandLink1.MergeType = C1.Win.Command.MenuMerge.MergeItems;
            // 
            // MdiChild
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 22);
            this.ClientSize = new System.Drawing.Size(292, 271);
            this.Controls.Add(this.c1MainMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MdiChild";
            this.Text = "MdiChild";
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

        private void cmdClose_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            // Note this the child's menu is set up to merge into the main
            // window's menu.
            this.Close();
        }
	}
}
