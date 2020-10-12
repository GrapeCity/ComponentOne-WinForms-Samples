namespace LogPlots
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
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.checkYLOG = new System.Windows.Forms.CheckBox();
			this.checkXLOG = new System.Windows.Forms.CheckBox();
			this.comboBoxLogBase = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.Location = new System.Drawing.Point(13, 77);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
			this.c1Chart1.Size = new System.Drawing.Size(559, 374);
			this.c1Chart1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.checkYLOG);
			this.panel1.Controls.Add(this.checkXLOG);
			this.panel1.Location = new System.Drawing.Point(12, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(296, 58);
			this.panel1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Select Axis for Log Scale:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// checkYLOG
			// 
			this.checkYLOG.AutoSize = true;
			this.checkYLOG.Checked = true;
			this.checkYLOG.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkYLOG.Location = new System.Drawing.Point(160, 38);
			this.checkYLOG.Name = "checkYLOG";
			this.checkYLOG.Size = new System.Drawing.Size(136, 17);
			this.checkYLOG.TabIndex = 1;
			this.checkYLOG.Text = "Y-Axis Using Log Scale";
			this.checkYLOG.UseVisualStyleBackColor = true;
			this.checkYLOG.CheckedChanged += new System.EventHandler(this.checkLOG_CheckedChanged);
			// 
			// checkXLOG
			// 
			this.checkXLOG.AutoSize = true;
			this.checkXLOG.Location = new System.Drawing.Point(160, 10);
			this.checkXLOG.Name = "checkXLOG";
			this.checkXLOG.Size = new System.Drawing.Size(136, 17);
			this.checkXLOG.TabIndex = 0;
			this.checkXLOG.Text = "X-Axis Using Log Scale";
			this.checkXLOG.UseVisualStyleBackColor = true;
			this.checkXLOG.CheckedChanged += new System.EventHandler(this.checkLOG_CheckedChanged);
			// 
			// comboBoxLogBase
			// 
			this.comboBoxLogBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLogBase.FormattingEnabled = true;
			this.comboBoxLogBase.Location = new System.Drawing.Point(468, 6);
			this.comboBoxLogBase.Name = "comboBoxLogBase";
			this.comboBoxLogBase.Size = new System.Drawing.Size(64, 21);
			this.comboBoxLogBase.TabIndex = 2;
			this.comboBoxLogBase.SelectedIndexChanged += new System.EventHandler(this.comboBoxLogBase_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(314, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Select Logarithmic Base:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Ivory;
			this.ClientSize = new System.Drawing.Size(584, 463);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxLogBase);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.c1Chart1);
			this.Name = "Form1";
			this.Text = "ComponentOne Chart.Net 2D-Log Plots";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkYLOG;
		private System.Windows.Forms.CheckBox checkXLOG;
		private System.Windows.Forms.ComboBox comboBoxLogBase;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

