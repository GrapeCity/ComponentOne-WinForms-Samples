namespace DataBinding
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
            panel1 = new System.Windows.Forms.Panel();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            doc = new C1.C1Preview.C1PrintDocument();
            c1PrintPreviewControl1 = new C1.Win.C1Preview.C1PrintPreviewControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1PrintPreviewControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1PrintPreviewControl1.PreviewPane).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(858, 68);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(405, 14);
            button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(212, 39);
            button4.TabIndex = 3;
            button4.Text = "Integrated sample uses Grouping, Aggregates, RenderTable";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(260, 14);
            button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(138, 39);
            button3.TabIndex = 2;
            button3.Text = "Displays data from MS Access database";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(156, 14);
            button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(97, 39);
            button2.TabIndex = 1;
            button2.Text = "Binding to an empty list";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(14, 14);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(135, 39);
            button1.TabIndex = 0;
            button1.Text = "Displays all elements in list";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // c1PrintPreviewControl1
            // 
            c1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1PrintPreviewControl1.Location = new System.Drawing.Point(0, 68);
            c1PrintPreviewControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            c1PrintPreviewControl1.Name = "c1PrintPreviewControl1";
            // 
            // 
            // 
            c1PrintPreviewControl1.PreviewPane.Document = doc;
            c1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = true;
            c1PrintPreviewControl1.PreviewPane.Location = new System.Drawing.Point(0, 0);
            c1PrintPreviewControl1.PreviewPane.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            c1PrintPreviewControl1.PreviewPane.Name = "previewPane";
            c1PrintPreviewControl1.PreviewPane.Size = new System.Drawing.Size(233, 300);
            c1PrintPreviewControl1.PreviewPane.TabIndex = 0;
            c1PrintPreviewControl1.Size = new System.Drawing.Size(858, 534);
            c1PrintPreviewControl1.TabIndex = 1;
            c1PrintPreviewControl1.Text = "c1PrintPreviewControl1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(858, 602);
            Controls.Add(c1PrintPreviewControl1);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Data binding in C1PrintDocument";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)doc).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1PrintPreviewControl1.PreviewPane).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1PrintPreviewControl1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private C1.C1Preview.C1PrintDocument doc;
        private C1.Win.C1Preview.C1PrintPreviewControl c1PrintPreviewControl1;
    }
}

