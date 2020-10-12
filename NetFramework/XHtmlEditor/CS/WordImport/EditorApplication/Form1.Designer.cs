namespace EditorApplication
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.c1EditorToolStripMain1 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain();
			this.c1Editor1 = new C1.Win.C1Editor.C1Editor();
			this.c1EditorToolStripObjects1 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripObjects();
			this.c1EditorToolStripStyle1 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripStyle();
			((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1EditorToolStripMain1
			// 
			this.c1EditorToolStripMain1.Editor = this.c1Editor1;
			this.c1EditorToolStripMain1.Location = new System.Drawing.Point(0, 0);
			this.c1EditorToolStripMain1.Name = "c1EditorToolStripMain1";
			this.c1EditorToolStripMain1.Size = new System.Drawing.Size(1000, 25);
			this.c1EditorToolStripMain1.TabIndex = 0;
			this.c1EditorToolStripMain1.Text = "c1EditorToolStripMain1";
			// 
			// c1Editor1
			// 
			this.c1Editor1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Editor1.Location = new System.Drawing.Point(0, 75);
			this.c1Editor1.Name = "c1Editor1";
			this.c1Editor1.Size = new System.Drawing.Size(1000, 493);
			this.c1Editor1.TabIndex = 1;
			this.c1Editor1.Xml = resources.GetString("c1Editor1.Xml");
			// 
			// c1EditorToolStripObjects1
			// 
			this.c1EditorToolStripObjects1.Editor = this.c1Editor1;
			this.c1EditorToolStripObjects1.Location = new System.Drawing.Point(0, 25);
			this.c1EditorToolStripObjects1.Name = "c1EditorToolStripObjects1";
			this.c1EditorToolStripObjects1.Size = new System.Drawing.Size(1000, 25);
			this.c1EditorToolStripObjects1.TabIndex = 2;
			this.c1EditorToolStripObjects1.Text = "c1EditorToolStripObjects1";
			// 
			// c1EditorToolStripStyle1
			// 
			this.c1EditorToolStripStyle1.Editor = this.c1Editor1;
			this.c1EditorToolStripStyle1.Location = new System.Drawing.Point(0, 50);
			this.c1EditorToolStripStyle1.Name = "c1EditorToolStripStyle1";
			this.c1EditorToolStripStyle1.Size = new System.Drawing.Size(1000, 25);
			this.c1EditorToolStripStyle1.TabIndex = 4;
			this.c1EditorToolStripStyle1.Text = "c1EditorToolStripStyle1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 568);
			this.Controls.Add(this.c1Editor1);
			this.Controls.Add(this.c1EditorToolStripStyle1);
			this.Controls.Add(this.c1EditorToolStripObjects1);
			this.Controls.Add(this.c1EditorToolStripMain1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain c1EditorToolStripMain1;
		private C1.Win.C1Editor.C1Editor c1Editor1;
		private C1.Win.C1Editor.ToolStrips.C1EditorToolStripObjects c1EditorToolStripObjects1;
		private C1.Win.C1Editor.ToolStrips.C1EditorToolStripStyle c1EditorToolStripStyle1;
	}
}

