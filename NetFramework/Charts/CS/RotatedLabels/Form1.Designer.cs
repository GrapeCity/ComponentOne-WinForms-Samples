namespace RotatedLabels
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.picSelect = new System.Windows.Forms.PictureBox();
			this.radioRotation = new System.Windows.Forms.RadioButton();
			this.radioCompass = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picSelect)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.BackColor = System.Drawing.Color.Tan;
			this.c1Chart1.Location = new System.Drawing.Point(12, 13);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
			this.c1Chart1.Size = new System.Drawing.Size(330, 348);
			this.c1Chart1.TabIndex = 0;
			this.c1Chart1.DoubleClick += new System.EventHandler(this.c1Chart1_DoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Tan;
			this.groupBox1.Controls.Add(this.picSelect);
			this.groupBox1.Controls.Add(this.radioRotation);
			this.groupBox1.Controls.Add(this.radioCompass);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(357, 110);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(216, 251);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Selections";
			// 
			// picSelect
			// 
			this.picSelect.Location = new System.Drawing.Point(18, 51);
			this.picSelect.Name = "picSelect";
			this.picSelect.Size = new System.Drawing.Size(180, 180);
			this.picSelect.TabIndex = 2;
			this.picSelect.TabStop = false;
			this.picSelect.Paint += new System.Windows.Forms.PaintEventHandler(this.picSelect_Paint);
			this.picSelect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picSelect_MouseDown);
			// 
			// radioRotation
			// 
			this.radioRotation.AutoSize = true;
			this.radioRotation.Location = new System.Drawing.Point(93, 19);
			this.radioRotation.Name = "radioRotation";
			this.radioRotation.Size = new System.Drawing.Size(105, 17);
			this.radioRotation.TabIndex = 1;
			this.radioRotation.Text = "RotationOverride";
			this.radioRotation.UseVisualStyleBackColor = true;
			this.radioRotation.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
			// 
			// radioCompass
			// 
			this.radioCompass.AutoSize = true;
			this.radioCompass.Checked = true;
			this.radioCompass.Location = new System.Drawing.Point(19, 19);
			this.radioCompass.Name = "radioCompass";
			this.radioCompass.Size = new System.Drawing.Size(68, 17);
			this.radioCompass.TabIndex = 0;
			this.radioCompass.TabStop = true;
			this.radioCompass.Text = "Compass";
			this.radioCompass.UseVisualStyleBackColor = true;
			this.radioCompass.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(357, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 76);
			this.label1.TabIndex = 2;
			this.label1.Text = "Rotated labels orient the text as upright as possible.  The pivot of the rotation" +
    " is the label connection point.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(589, 373);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.c1Chart1);
			this.Name = "Form1";
			this.Text = "RotatedLabels";
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picSelect)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox picSelect;
		private System.Windows.Forms.RadioButton radioRotation;
		private System.Windows.Forms.RadioButton radioCompass;
		private System.Windows.Forms.Label label1;
	}
}

