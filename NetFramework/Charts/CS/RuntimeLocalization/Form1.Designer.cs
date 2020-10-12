namespace RuntimeLocalization
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
			this.c1Chart3D1 = new C1.Win.C1Chart3D.C1Chart3D();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.btnAddPrefix = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnShowLocalizations = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnShowPropGrids = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.Location = new System.Drawing.Point(8, 198);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
			this.c1Chart1.Size = new System.Drawing.Size(271, 259);
			this.c1Chart1.TabIndex = 0;
			this.c1Chart1.Click += new System.EventHandler(this.c1Chart1_Click);
			// 
			// c1Chart3D1
			// 
			this.c1Chart3D1.Location = new System.Drawing.Point(294, 198);
			this.c1Chart3D1.Name = "c1Chart3D1";
			this.c1Chart3D1.PropBag = resources.GetString("c1Chart3D1.PropBag");
			this.c1Chart3D1.Size = new System.Drawing.Size(274, 259);
			this.c1Chart3D1.TabIndex = 1;
			this.c1Chart3D1.Click += new System.EventHandler(this.c1Chart3D1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Location = new System.Drawing.Point(8, 479);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(271, 86);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select Charts for Operations";
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(94, 51);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(68, 17);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Chart 3D";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(94, 28);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(68, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Chart 2D";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton4);
			this.groupBox2.Controls.Add(this.radioButton3);
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Location = new System.Drawing.Point(294, 479);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(274, 85);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Select Prefix String";
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(169, 51);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(47, 17);
			this.radioButton4.TabIndex = 3;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "\"dd\"";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(169, 24);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(47, 17);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "\"cc\"";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(48, 51);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(47, 17);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "\"bb\"";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(48, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(47, 17);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "\"aa\"";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// btnAddPrefix
			// 
			this.btnAddPrefix.Location = new System.Drawing.Point(8, 585);
			this.btnAddPrefix.Name = "btnAddPrefix";
			this.btnAddPrefix.Size = new System.Drawing.Size(134, 38);
			this.btnAddPrefix.TabIndex = 5;
			this.btnAddPrefix.Text = "Add Selected Prefix";
			this.btnAddPrefix.UseVisualStyleBackColor = true;
			this.btnAddPrefix.Click += new System.EventHandler(this.btnAddPrefix_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(145, 585);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(134, 38);
			this.btnReset.TabIndex = 6;
			this.btnReset.Text = "Reset Localization";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnShowLocalizations
			// 
			this.btnShowLocalizations.Location = new System.Drawing.Point(294, 585);
			this.btnShowLocalizations.Name = "btnShowLocalizations";
			this.btnShowLocalizations.Size = new System.Drawing.Size(134, 38);
			this.btnShowLocalizations.TabIndex = 7;
			this.btnShowLocalizations.Text = "Show Localizations";
			this.btnShowLocalizations.UseVisualStyleBackColor = true;
			this.btnShowLocalizations.Click += new System.EventHandler(this.btnShowLocalizations_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(119, 175);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(338, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Click a chart to show its properties dialog";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(12, 23);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(563, 123);
			this.textBox1.TabIndex = 8;
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// btnShowPropGrids
			// 
			this.btnShowPropGrids.Location = new System.Drawing.Point(434, 585);
			this.btnShowPropGrids.Name = "btnShowPropGrids";
			this.btnShowPropGrids.Size = new System.Drawing.Size(134, 38);
			this.btnShowPropGrids.TabIndex = 9;
			this.btnShowPropGrids.Text = "Show Prop Grids";
			this.btnShowPropGrids.UseVisualStyleBackColor = true;
			this.btnShowPropGrids.Click += new System.EventHandler(this.btnShowPropGrids_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(579, 630);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Controls.Add(this.btnShowPropGrids);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnShowLocalizations);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnAddPrefix);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.c1Chart3D1);
			this.Controls.Add(this.c1Chart1);
			this.Name = "Form1";
			this.Text = "Runtime Localizations";
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private C1.Win.C1Chart.C1Chart c1Chart1;
		private C1.Win.C1Chart3D.C1Chart3D c1Chart3D1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button btnAddPrefix;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnShowLocalizations;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnShowPropGrids;
	}
}

