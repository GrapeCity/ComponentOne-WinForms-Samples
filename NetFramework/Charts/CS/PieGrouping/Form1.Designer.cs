namespace PieGrouping
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
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.chk3D = new System.Windows.Forms.CheckBox();
			this.chkStacked = new System.Windows.Forms.CheckBox();
			this.chkAscending = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Chart1.Location = new System.Drawing.Point(0, 31);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
			this.c1Chart1.Size = new System.Drawing.Size(571, 561);
			this.c1Chart1.TabIndex = 0;
			// 
			// chk3D
			// 
			this.chk3D.AutoSize = true;
			this.chk3D.Checked = true;
			this.chk3D.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk3D.Location = new System.Drawing.Point(0, 8);
			this.chk3D.Name = "chk3D";
			this.chk3D.Size = new System.Drawing.Size(76, 17);
			this.chk3D.TabIndex = 1;
			this.chk3D.Text = "3D Effects";
			this.chk3D.UseVisualStyleBackColor = true;
			this.chk3D.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
			// 
			// chkStacked
			// 
			this.chkStacked.AutoSize = true;
			this.chkStacked.Checked = true;
			this.chkStacked.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkStacked.Location = new System.Drawing.Point(82, 8);
			this.chkStacked.Name = "chkStacked";
			this.chkStacked.Size = new System.Drawing.Size(66, 17);
			this.chkStacked.TabIndex = 2;
			this.chkStacked.Text = "Stacked";
			this.chkStacked.UseVisualStyleBackColor = true;
			this.chkStacked.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
			// 
			// chkAscending
			// 
			this.chkAscending.AutoSize = true;
			this.chkAscending.Checked = true;
			this.chkAscending.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAscending.Location = new System.Drawing.Point(154, 8);
			this.chkAscending.Name = "chkAscending";
			this.chkAscending.Size = new System.Drawing.Size(76, 17);
			this.chkAscending.TabIndex = 3;
			this.chkAscending.Text = "Ascending";
			this.chkAscending.UseVisualStyleBackColor = true;
			this.chkAscending.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(348, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Click each pie element for a tooltip.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 593);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chkAscending);
			this.Controls.Add(this.chkStacked);
			this.Controls.Add(this.chk3D);
			this.Controls.Add(this.c1Chart1);
			this.Name = "Form1";
			this.Text = "ComponentOne Chart.Net 2D Pie Grouping";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.CheckBox chk3D;
		private System.Windows.Forms.CheckBox chkStacked;
		private System.Windows.Forms.CheckBox chkAscending;
		private System.Windows.Forms.Label label1;
	}
}

