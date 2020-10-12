namespace BitmapSamples
{
    partial class Transform
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRotateCW = new System.Windows.Forms.Button();
            this.btnRotateCCW = new System.Windows.Forms.Button();
            this.btnFlipV = new System.Windows.Forms.Button();
            this.btnFlipH = new System.Windows.Forms.Button();
            this.btnScaleIn = new System.Windows.Forms.Button();
            this.btnScaleOut = new System.Windows.Forms.Button();
            this.btnCrop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(3, 36);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(122, 27);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export Image";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(3, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(122, 27);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Image";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnRotateCW
            // 
            this.btnRotateCW.Location = new System.Drawing.Point(4, 188);
            this.btnRotateCW.Name = "btnRotateCW";
            this.btnRotateCW.Size = new System.Drawing.Size(122, 27);
            this.btnRotateCW.TabIndex = 7;
            this.btnRotateCW.Text = "Rotate 90º CW";
            this.btnRotateCW.UseVisualStyleBackColor = true;
            this.btnRotateCW.Click += new System.EventHandler(this.btnRotateCW_Click);
            // 
            // btnRotateCCW
            // 
            this.btnRotateCCW.Location = new System.Drawing.Point(3, 155);
            this.btnRotateCCW.Name = "btnRotateCCW";
            this.btnRotateCCW.Size = new System.Drawing.Size(122, 27);
            this.btnRotateCCW.TabIndex = 6;
            this.btnRotateCCW.Text = "Rotate 90º CCW";
            this.btnRotateCCW.UseVisualStyleBackColor = true;
            this.btnRotateCCW.Click += new System.EventHandler(this.btnRotateCCW_Click);
            // 
            // btnFlipV
            // 
            this.btnFlipV.Location = new System.Drawing.Point(4, 254);
            this.btnFlipV.Name = "btnFlipV";
            this.btnFlipV.Size = new System.Drawing.Size(122, 27);
            this.btnFlipV.TabIndex = 9;
            this.btnFlipV.Text = "Flip Vertical";
            this.btnFlipV.UseVisualStyleBackColor = true;
            this.btnFlipV.Click += new System.EventHandler(this.btnFlipV_Click);
            // 
            // btnFlipH
            // 
            this.btnFlipH.Location = new System.Drawing.Point(4, 221);
            this.btnFlipH.Name = "btnFlipH";
            this.btnFlipH.Size = new System.Drawing.Size(122, 27);
            this.btnFlipH.TabIndex = 8;
            this.btnFlipH.Text = "Flip Horizontal";
            this.btnFlipH.UseVisualStyleBackColor = true;
            this.btnFlipH.Click += new System.EventHandler(this.btnFlipH_Click);
            // 
            // btnScaleIn
            // 
            this.btnScaleIn.Location = new System.Drawing.Point(3, 297);
            this.btnScaleIn.Name = "btnScaleIn";
            this.btnScaleIn.Size = new System.Drawing.Size(122, 27);
            this.btnScaleIn.TabIndex = 11;
            this.btnScaleIn.Text = "Scale to 160%";
            this.btnScaleIn.UseVisualStyleBackColor = true;
            this.btnScaleIn.Click += new System.EventHandler(this.btnScaleIn_Click);
            // 
            // btnScaleOut
            // 
            this.btnScaleOut.Location = new System.Drawing.Point(3, 330);
            this.btnScaleOut.Name = "btnScaleOut";
            this.btnScaleOut.Size = new System.Drawing.Size(122, 27);
            this.btnScaleOut.TabIndex = 12;
            this.btnScaleOut.Text = "Scale to 62.5%";
            this.btnScaleOut.UseVisualStyleBackColor = true;
            this.btnScaleOut.Click += new System.EventHandler(this.btnScaleOut_Click);
            // 
            // btnCrop
            // 
            this.btnCrop.Location = new System.Drawing.Point(3, 112);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(122, 27);
            this.btnCrop.TabIndex = 4;
            this.btnCrop.Text = "Crop to Selection";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 167);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(3, 69);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(122, 27);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(4, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 2);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(4, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 2);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(4, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 2);
            this.label3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 361);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnFlipH);
            this.panel2.Controls.Add(this.btnRotateCW);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnRotateCCW);
            this.panel2.Controls.Add(this.btnFlipV);
            this.panel2.Controls.Add(this.btnScaleIn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnScaleOut);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCrop);
            this.panel2.Controls.Add(this.btnRestart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 367);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(130, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(453, 367);
            this.panel3.TabIndex = 1;
            // 
            // Transform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Transform";
            this.Size = new System.Drawing.Size(583, 367);
            this.Load += new System.EventHandler(this.Transform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRotateCW;
        private System.Windows.Forms.Button btnRotateCCW;
        private System.Windows.Forms.Button btnFlipV;
        private System.Windows.Forms.Button btnFlipH;
        private System.Windows.Forms.Button btnScaleIn;
        private System.Windows.Forms.Button btnScaleOut;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
