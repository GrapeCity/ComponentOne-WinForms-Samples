//===============================================================================
// Microsoft patterns & practices
// CompositeUI Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

namespace BankShell
{
	partial class BankShellForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sideBarWorkspace = new Microsoft.Practices.CompositeUI.WinForms.DeckWorkspace();
            this.contentWorkspace = new Microsoft.Practices.CompositeUI.WinForms.DeckWorkspace();
            this.c1StatusBar1 = new C1.Win.C1Ribbon.C1StatusBar();
            this.ribbonLabel1 = new C1.Win.C1Ribbon.RibbonLabel();
            this.ribbonWorkspace = new C1.Win.C1Ribbon.CAB.RibbonWorkspace();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 105);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sideBarWorkspace);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.contentWorkspace);
            this.splitContainer1.Size = new System.Drawing.Size(836, 440);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // sideBarWorkspace
            // 
            this.sideBarWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBarWorkspace.Location = new System.Drawing.Point(0, 0);
            this.sideBarWorkspace.Name = "sideBarWorkspace";
            this.sideBarWorkspace.Size = new System.Drawing.Size(251, 440);
            this.sideBarWorkspace.TabIndex = 0;
            this.sideBarWorkspace.Text = "sideBarWorkspace";
            // 
            // contentWorkspace
            // 
            this.contentWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentWorkspace.Location = new System.Drawing.Point(0, 0);
            this.contentWorkspace.Name = "contentWorkspace";
            this.contentWorkspace.Size = new System.Drawing.Size(580, 440);
            this.contentWorkspace.TabIndex = 0;
            this.contentWorkspace.Text = "contentWorkspace";
            // 
            // c1StatusBar1
            // 
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonLabel1);
            this.c1StatusBar1.Location = new System.Drawing.Point(0, 545);
            this.c1StatusBar1.Name = "c1StatusBar1";
            this.c1StatusBar1.Size = new System.Drawing.Size(836, 23);
            // 
            // ribbonLabel1
            // 
            this.ribbonLabel1.Name = "ribbonLabel1";
            this.ribbonLabel1.Text = "Status";
            // 
            // ribbonWorkspace
            // 
            this.ribbonWorkspace.Location = new System.Drawing.Point(0, 0);
            this.ribbonWorkspace.Name = "ribbonWorkspace";
            this.ribbonWorkspace.Size = new System.Drawing.Size(836, 105);
            this.ribbonWorkspace.TabIndex = 4;
            // 
            // BankShellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 568);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.c1StatusBar1);
            this.Controls.Add(this.ribbonWorkspace);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "BankShellForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bank Shell";
            this.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Windows7;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private Microsoft.Practices.CompositeUI.WinForms.DeckWorkspace sideBarWorkspace;
		private System.Windows.Forms.SplitContainer splitContainer1;
        public Microsoft.Practices.CompositeUI.WinForms.DeckWorkspace contentWorkspace;
        private C1.Win.C1Ribbon.C1StatusBar c1StatusBar1;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel1;
        private C1.Win.C1Ribbon.CAB.RibbonWorkspace ribbonWorkspace;
	}
}

