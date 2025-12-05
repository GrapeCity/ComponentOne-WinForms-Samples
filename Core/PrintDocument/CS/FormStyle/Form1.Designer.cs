namespace FormStyle
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
            cbFormStyle = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
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
            panel1.Controls.Add(cbFormStyle);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(878, 51);
            panel1.TabIndex = 0;
            // 
            // cbFormStyle
            // 
            cbFormStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFormStyle.FormattingEnabled = true;
            cbFormStyle.Location = new System.Drawing.Point(90, 14);
            cbFormStyle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbFormStyle.Name = "cbFormStyle";
            cbFormStyle.Size = new System.Drawing.Size(291, 23);
            cbFormStyle.TabIndex = 1;
            cbFormStyle.SelectedIndexChanged += cbFormStyle_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 15);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 21);
            label1.TabIndex = 0;
            label1.Text = "FormStyle:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.UseCompatibleTextRendering = true;
            // 
            // c1PrintPreviewControl1
            // 
            c1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1PrintPreviewControl1.Location = new System.Drawing.Point(0, 51);
            c1PrintPreviewControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            c1PrintPreviewControl1.Name = "c1PrintPreviewControl1";
            c1PrintPreviewControl1.NavigationPanelVisible = false;
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
            c1PrintPreviewControl1.PreviewPane.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.ActualSize;
            c1PrintPreviewControl1.Size = new System.Drawing.Size(878, 544);
            c1PrintPreviewControl1.TabIndex = 1;
            c1PrintPreviewControl1.Text = "c1PrintPreviewControl1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(878, 595);
            Controls.Add(c1PrintPreviewControl1);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Demonstrates C1PrintDocument.FormStyle property";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doc).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1PrintPreviewControl1.PreviewPane).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1PrintPreviewControl1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFormStyle;
        private C1.C1Preview.C1PrintDocument doc;
        private C1.Win.C1Preview.C1PrintPreviewControl c1PrintPreviewControl1;
    }
}

