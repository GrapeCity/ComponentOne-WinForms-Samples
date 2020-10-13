namespace ControlExplorer.Chart
{
    partial class AlarmZones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmZones));
            this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegData = new System.Windows.Forms.Button();
            this.chkPatterns = new System.Windows.Forms.CheckBox();
            this.radShapes = new System.Windows.Forms.RadioButton();
            this.radZones = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1Chart1
            // 
            this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Chart1.Interaction.Enabled = true;
            this.c1Chart1.Interaction.RotateData = "AxesXY;Alt;Left";
            this.c1Chart1.Interaction.ScaleData = "AxesXY;Control;Left";
            this.c1Chart1.Interaction.TranslationData = "AxesXY;Shift;Left";
            this.c1Chart1.Interaction.ZoomData = "AxesXY;None;Left";
            this.c1Chart1.Location = new System.Drawing.Point(0, 30);
            this.c1Chart1.Name = "c1Chart1";
            this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
            this.c1Chart1.Size = new System.Drawing.Size(592, 416);
            this.c1Chart1.TabIndex = 1;
            this.c1Chart1.Resize += new System.EventHandler(this.c1Chart1_Resize);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.btnRegData);
            this.panel1.Controls.Add(this.chkPatterns);
            this.panel1.Controls.Add(this.radShapes);
            this.panel1.Controls.Add(this.radZones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 30);
            this.panel1.TabIndex = 0;
            // 
            // btnRegData
            // 
            this.btnRegData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegData.Location = new System.Drawing.Point(469, 3);
            this.btnRegData.Name = "btnRegData";
            this.btnRegData.Size = new System.Drawing.Size(111, 23);
            this.btnRegData.TabIndex = 3;
            this.btnRegData.Text = "Regenerate Data";
            this.btnRegData.UseVisualStyleBackColor = true;
            this.btnRegData.Click += new System.EventHandler(this.btnRegData_Click);
            // 
            // chkPatterns
            // 
            this.chkPatterns.AutoSize = true;
            this.chkPatterns.Location = new System.Drawing.Point(180, 7);
            this.chkPatterns.Name = "chkPatterns";
            this.chkPatterns.Size = new System.Drawing.Size(105, 17);
            this.chkPatterns.TabIndex = 2;
            this.chkPatterns.Text = "Use HatchStyles";
            this.chkPatterns.UseVisualStyleBackColor = true;
            this.chkPatterns.CheckedChanged += new System.EventHandler(this.chkPatterns_CheckedChanged);
            // 
            // radShapes
            // 
            this.radShapes.AutoSize = true;
            this.radShapes.Location = new System.Drawing.Point(73, 6);
            this.radShapes.Name = "radShapes";
            this.radShapes.Size = new System.Drawing.Size(61, 17);
            this.radShapes.TabIndex = 1;
            this.radShapes.Text = "Shapes";
            this.radShapes.UseVisualStyleBackColor = true;
            // 
            // radZones
            // 
            this.radZones.AutoSize = true;
            this.radZones.Checked = true;
            this.radZones.Location = new System.Drawing.Point(12, 6);
            this.radZones.Name = "radZones";
            this.radZones.Size = new System.Drawing.Size(55, 17);
            this.radZones.TabIndex = 0;
            this.radZones.TabStop = true;
            this.radZones.Text = "Zones";
            this.radZones.UseVisualStyleBackColor = true;
            this.radZones.CheckedChanged += new System.EventHandler(this.radZones_CheckedChanged);
            // 
            // AlarmZones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1Chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AlarmZones";
            this.Text = "AlarmZones";
            this.Load += new System.EventHandler(this.AlarmZones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radShapes;
        private System.Windows.Forms.RadioButton radZones;
        private C1.Win.C1Chart.C1Chart c1Chart1;
        private System.Windows.Forms.CheckBox chkPatterns;
        private System.Windows.Forms.Button btnRegData;
    }
}