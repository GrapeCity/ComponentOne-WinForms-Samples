namespace TouchToolKitDemo.MultiScaleImagePages
{
    partial class MultiScaleImageDemo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            C1.Win.TouchToolKit.ImageItem imageItem1 = new C1.Win.TouchToolKit.ImageItem();
            C1.Win.TouchToolKit.ImageItem imageItem2 = new C1.Win.TouchToolKit.ImageItem();
            C1.Win.TouchToolKit.ImageItem imageItem3 = new C1.Win.TouchToolKit.ImageItem();
            C1.Win.TouchToolKit.ImageItem imageItem4 = new C1.Win.TouchToolKit.ImageItem();
            C1.Win.TouchToolKit.ImageItem imageItem5 = new C1.Win.TouchToolKit.ImageItem();
            C1.Win.TouchToolKit.ImageItem imageItem6 = new C1.Win.TouchToolKit.ImageItem();
            this.zoomFactorLabel = new System.Windows.Forms.Label();
            this.C1ZoomPanel1 = new C1.Win.TouchToolKit.C1ZoomPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.C1MultiScaleImage1 = new C1.Win.TouchToolKit.C1MultiScaleImage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.C1ZoomPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C1MultiScaleImage1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // zoomFactorLabel
            // 
            this.zoomFactorLabel.Location = new System.Drawing.Point(3, 322);
            this.zoomFactorLabel.Name = "zoomFactorLabel";
            this.zoomFactorLabel.Size = new System.Drawing.Size(650, 50);
            this.zoomFactorLabel.TabIndex = 1;
            this.zoomFactorLabel.Text = "ZoomFactor:";
            // 
            // C1ZoomPanel1
            // 
            this.C1ZoomPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C1ZoomPanel1.Controls.Add(this.tableLayoutPanel2);
            this.C1ZoomPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C1ZoomPanel1.Location = new System.Drawing.Point(0, 0);
            this.C1ZoomPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.C1ZoomPanel1.Name = "C1ZoomPanel1";
            this.C1ZoomPanel1.Size = new System.Drawing.Size(690, 322);
            this.C1ZoomPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(688, 320);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 314);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TouchToolKitDemo.Properties.Resources.airplane1;
            this.pictureBox1.Location = new System.Drawing.Point(56, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "PictureBox";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.C1MultiScaleImage1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(347, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 314);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "C1MultiScaleImage";
            // 
            // C1MultiScaleImage1
            // 
            this.C1MultiScaleImage1.Image = global::TouchToolKitDemo.Properties.Resources.airplane1;
            imageItem1.Image = global::TouchToolKitDemo.Properties.Resources.airplane1_5;
            imageItem1.ZoomFactor = 1.5F;
            imageItem2.Image = global::TouchToolKitDemo.Properties.Resources.airplane2;
            imageItem3.Image = global::TouchToolKitDemo.Properties.Resources.airplane2_5;
            imageItem3.ZoomFactor = 2.5F;
            imageItem4.Image = global::TouchToolKitDemo.Properties.Resources.airplane3;
            imageItem4.ZoomFactor = 3F;
            imageItem5.Image = global::TouchToolKitDemo.Properties.Resources.airplane3_5;
            imageItem5.ZoomFactor = 3.5F;
            imageItem6.Image = global::TouchToolKitDemo.Properties.Resources.F22;
            imageItem6.ZoomFactor = 4F;
            this.C1MultiScaleImage1.Images.Add(imageItem1);
            this.C1MultiScaleImage1.Images.Add(imageItem2);
            this.C1MultiScaleImage1.Images.Add(imageItem3);
            this.C1MultiScaleImage1.Images.Add(imageItem4);
            this.C1MultiScaleImage1.Images.Add(imageItem5);
            this.C1MultiScaleImage1.Images.Add(imageItem6);
            this.C1MultiScaleImage1.Location = new System.Drawing.Point(42, 70);
            this.C1MultiScaleImage1.Name = "C1MultiScaleImage1";
            this.C1MultiScaleImage1.Size = new System.Drawing.Size(236, 136);
            this.C1MultiScaleImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.C1MultiScaleImage1.TabIndex = 2;
            this.C1MultiScaleImage1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.zoomFactorLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.C1ZoomPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 372);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // MultiScaleImageDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MultiScaleImageDemo";
            this.panel1.ResumeLayout(false);
            this.C1ZoomPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C1MultiScaleImage1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zoomFactorLabel;
        private C1.Win.TouchToolKit.C1ZoomPanel C1ZoomPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private C1.Win.TouchToolKit.C1MultiScaleImage C1MultiScaleImage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;



    }
}
