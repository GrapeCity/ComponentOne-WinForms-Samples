namespace ExportFromFlexReportAndPdf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnFile = new Button();
            cbAction = new ComboBox();
            label2 = new Label();
            btnExecute = new Button();
            c1PdfDocumentSource1 = new C1.Document.C1PdfDocumentSource(components);
            openFileDialog1 = new OpenFileDialog();
            printDialog1 = new PrintDialog();
            saveFileDialog1 = new SaveFileDialog();
            label3 = new Label();
            cbReportName = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tbFile = new TextBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "File:";
            // 
            // btnFile
            // 
            btnFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFile.Location = new Point(656, 20);
            btnFile.Margin = new Padding(4, 5, 4, 5);
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(34, 30);
            btnFile.TabIndex = 2;
            btnFile.Text = "...";
            btnFile.UseVisualStyleBackColor = true;
            btnFile.Click += button1_Click;
            // 
            // cbAction
            // 
            cbAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAction.FormattingEnabled = true;
            cbAction.Location = new Point(86, 2);
            cbAction.Margin = new Padding(4, 5, 4, 5);
            cbAction.Name = "cbAction";
            cbAction.Size = new Size(276, 28);
            cbAction.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 5);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 4;
            label2.Text = "Action:";
            // 
            // btnExecute
            // 
            btnExecute.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExecute.Location = new Point(587, 143);
            btnExecute.Margin = new Padding(4, 5, 4, 5);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(100, 35);
            btnExecute.TabIndex = 6;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "pdf";
            openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|FlexReport files (*.flxr)|*.flxr";
            // 
            // printDialog1
            // 
            printDialog1.AllowSomePages = true;
            printDialog1.UseEXDialog = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 3);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 7;
            label3.Text = "Report:";
            // 
            // cbReportName
            // 
            cbReportName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReportName.FormattingEnabled = true;
            cbReportName.Location = new Point(86, 0);
            cbReportName.Margin = new Padding(4, 5, 4, 5);
            cbReportName.Name = "cbReportName";
            cbReportName.Size = new Size(276, 28);
            cbReportName.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbReportName);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 29);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cbAction);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(703, 39);
            panel2.TabIndex = 10;
            // 
            // tbFile
            // 
            tbFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFile.Location = new Point(85, 23);
            tbFile.Margin = new Padding(4, 5, 4, 5);
            tbFile.Name = "tbFile";
            tbFile.Size = new Size(557, 27);
            tbFile.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(-1, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(703, 68);
            panel3.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 197);
            Controls.Add(panel3);
            Controls.Add(btnExecute);
            Controls.Add(btnFile);
            Controls.Add(label1);
            Controls.Add(tbFile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Export";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExecute;
        private C1.Document.C1PdfDocumentSource c1PdfDocumentSource1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbReportName;
        private Panel panel1;
        private Panel panel2;
        private TextBox tbFile;
        private Panel panel3;
    }
}
