namespace BitmapSamples
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cropPage1 = new BitmapSamples.CropPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.faceWarp1 = new BitmapSamples.FaceWarp();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.transform1 = new BitmapSamples.Transform();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 446);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cropPage1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crop";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cropPage1
            // 
            this.cropPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cropPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cropPage1.Location = new System.Drawing.Point(3, 3);
            this.cropPage1.Name = "cropPage1";
            this.cropPage1.Size = new System.Drawing.Size(658, 412);
            this.cropPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.faceWarp1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Face Warp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // faceWarp1
            // 
            this.faceWarp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faceWarp1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faceWarp1.Location = new System.Drawing.Point(3, 3);
            this.faceWarp1.Name = "faceWarp1";
            this.faceWarp1.Size = new System.Drawing.Size(658, 412);
            this.faceWarp1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.transform1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(664, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transform";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // transform1
            // 
            this.transform1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transform1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transform1.Location = new System.Drawing.Point(3, 3);
            this.transform1.Name = "transform1";
            this.transform1.Size = new System.Drawing.Size(658, 412);
            this.transform1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(672, 446);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "C1Bitmap Samples";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CropPage cropPage1;
        private FaceWarp faceWarp1;
        private System.Windows.Forms.TabPage tabPage3;
        private Transform transform1;
    }
}

