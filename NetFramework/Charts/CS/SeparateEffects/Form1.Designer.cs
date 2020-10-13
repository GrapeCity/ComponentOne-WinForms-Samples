namespace SeparateEffects
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnVisualEffectsEditor = new System.Windows.Forms.Button();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.checkGroup0Effects = new System.Windows.Forms.CheckBox();
			this.checkGroup1Effects = new System.Windows.Forms.CheckBox();
			this.checkDefaultEffects = new System.Windows.Forms.CheckBox();
			this.btnClearEffects = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkDefaultEffects);
			this.groupBox1.Controls.Add(this.checkGroup1Effects);
			this.groupBox1.Controls.Add(this.checkGroup0Effects);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(180, 104);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Data Group Effects Selection";
			// 
			// btnVisualEffectsEditor
			// 
			this.btnVisualEffectsEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnVisualEffectsEditor.Location = new System.Drawing.Point(317, 21);
			this.btnVisualEffectsEditor.Name = "btnVisualEffectsEditor";
			this.btnVisualEffectsEditor.Size = new System.Drawing.Size(136, 36);
			this.btnVisualEffectsEditor.TabIndex = 3;
			this.btnVisualEffectsEditor.Text = "VisualEffects Editor";
			this.btnVisualEffectsEditor.UseVisualStyleBackColor = true;
			this.btnVisualEffectsEditor.Click += new System.EventHandler(this.btnVisualEffectsEditor_Click);
			// 
			// c1Chart1
			// 
			this.c1Chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Chart1.Location = new System.Drawing.Point(12, 145);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
			this.c1Chart1.Size = new System.Drawing.Size(441, 313);
			this.c1Chart1.TabIndex = 0;
			// 
			// checkGroup0Effects
			// 
			this.checkGroup0Effects.AutoSize = true;
			this.checkGroup0Effects.Location = new System.Drawing.Point(15, 28);
			this.checkGroup0Effects.Name = "checkGroup0Effects";
			this.checkGroup0Effects.Size = new System.Drawing.Size(123, 17);
			this.checkGroup0Effects.TabIndex = 3;
			this.checkGroup0Effects.Text = "Data Group0 Effects";
			this.checkGroup0Effects.UseVisualStyleBackColor = true;
			this.checkGroup0Effects.CheckedChanged += new System.EventHandler(this.CheckBoxEffects_Changed);
			// 
			// checkGroup1Effects
			// 
			this.checkGroup1Effects.AutoSize = true;
			this.checkGroup1Effects.Location = new System.Drawing.Point(15, 51);
			this.checkGroup1Effects.Name = "checkGroup1Effects";
			this.checkGroup1Effects.Size = new System.Drawing.Size(123, 17);
			this.checkGroup1Effects.TabIndex = 4;
			this.checkGroup1Effects.Text = "Data Group1 Effects";
			this.checkGroup1Effects.UseVisualStyleBackColor = true;
			this.checkGroup1Effects.CheckedChanged += new System.EventHandler(this.CheckBoxEffects_Changed);
			// 
			// checkDefaultEffects
			// 
			this.checkDefaultEffects.AutoSize = true;
			this.checkDefaultEffects.Checked = true;
			this.checkDefaultEffects.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkDefaultEffects.Location = new System.Drawing.Point(15, 74);
			this.checkDefaultEffects.Name = "checkDefaultEffects";
			this.checkDefaultEffects.Size = new System.Drawing.Size(122, 17);
			this.checkDefaultEffects.TabIndex = 5;
			this.checkDefaultEffects.Text = "Default Data Effects";
			this.checkDefaultEffects.UseVisualStyleBackColor = true;
			this.checkDefaultEffects.CheckedChanged += new System.EventHandler(this.CheckBoxEffects_Changed);
			// 
			// btnClearEffects
			// 
			this.btnClearEffects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearEffects.Location = new System.Drawing.Point(317, 75);
			this.btnClearEffects.Name = "btnClearEffects";
			this.btnClearEffects.Size = new System.Drawing.Size(136, 36);
			this.btnClearEffects.TabIndex = 4;
			this.btnClearEffects.Text = "Clear Effects";
			this.btnClearEffects.UseVisualStyleBackColor = true;
			this.btnClearEffects.Click += new System.EventHandler(this.btnClearEffects_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(467, 470);
			this.Controls.Add(this.btnClearEffects);
			this.Controls.Add(this.btnVisualEffectsEditor);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.c1Chart1);
			this.MinimumSize = new System.Drawing.Size(475, 497);
			this.Name = "Form1";
			this.Text = "Separate Group Visual Effects";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnVisualEffectsEditor;
		private System.Windows.Forms.CheckBox checkDefaultEffects;
		private System.Windows.Forms.CheckBox checkGroup1Effects;
		private System.Windows.Forms.CheckBox checkGroup0Effects;
		private System.Windows.Forms.Button btnClearEffects;
	}
}

