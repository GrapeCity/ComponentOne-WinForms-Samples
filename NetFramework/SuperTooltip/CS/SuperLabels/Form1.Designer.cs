namespace SuperLabels
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
            this.c1SuperLabel2 = new C1.Win.SuperTooltip.C1SuperLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.c1SuperLabel3 = new C1.Win.SuperTooltip.C1SuperLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.c1SuperLabel4 = new C1.Win.SuperTooltip.C1SuperLabel();
            this.c1SuperLabel1 = new C1.Win.SuperTooltip.C1SuperLabel();
            this.c1SuperLabel5 = new C1.Win.SuperTooltip.C1SuperLabel();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1SuperLabel2
            // 
            this.c1SuperLabel2.AutoSize = true;
            this.c1SuperLabel2.Location = new System.Drawing.Point(8, 9);
            this.c1SuperLabel2.Name = "c1SuperLabel2";
            this.c1SuperLabel2.Size = new System.Drawing.Size(126, 19);
            this.c1SuperLabel2.TabIndex = 0;
            this.c1SuperLabel2.Text = "&Select <b>Html</b> content:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 8);
            this.comboBox1.MaxDropDownItems = 16;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // c1SuperLabel3
            // 
            this.c1SuperLabel3.AutoSize = true;
            this.c1SuperLabel3.Location = new System.Drawing.Point(372, 9);
            this.c1SuperLabel3.Name = "c1SuperLabel3";
            this.c1SuperLabel3.Size = new System.Drawing.Size(96, 19);
            this.c1SuperLabel3.TabIndex = 2;
            this.c1SuperLabel3.Text = "&Open <b>Html</b> file:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.c1SuperLabel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1SuperLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.c1SuperLabel5);
            this.splitContainer1.Size = new System.Drawing.Size(730, 362);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(342, 341);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // c1SuperLabel4
            // 
            this.c1SuperLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1SuperLabel4.Location = new System.Drawing.Point(0, 0);
            this.c1SuperLabel4.Name = "c1SuperLabel4";
            this.c1SuperLabel4.Size = new System.Drawing.Size(342, 21);
            this.c1SuperLabel4.TabIndex = 0;
            this.c1SuperLabel4.Text = "&Html Source";
            // 
            // c1SuperLabel1
            // 
            this.c1SuperLabel1.BackColor = System.Drawing.Color.White;
            this.c1SuperLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.c1SuperLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SuperLabel1.Location = new System.Drawing.Point(0, 21);
            this.c1SuperLabel1.Name = "c1SuperLabel1";
            this.c1SuperLabel1.Size = new System.Drawing.Size(383, 341);
            this.c1SuperLabel1.TabIndex = 1;
            // 
            // c1SuperLabel5
            // 
            this.c1SuperLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1SuperLabel5.Location = new System.Drawing.Point(0, 0);
            this.c1SuperLabel5.Name = "c1SuperLabel5";
            this.c1SuperLabel5.Size = new System.Drawing.Size(383, 21);
            this.c1SuperLabel5.TabIndex = 0;
            this.c1SuperLabel5.Text = "Preview";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 397);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.c1SuperLabel3);
            this.Controls.Add(this.c1SuperLabel2);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1SuperLabel: Show Html text in labels";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private C1.Win.SuperTooltip.C1SuperLabel c1SuperLabel1;
        private C1.Win.SuperTooltip.C1SuperLabel c1SuperLabel2;
        private C1.Win.SuperTooltip.C1SuperLabel c1SuperLabel3;
        private C1.Win.SuperTooltip.C1SuperLabel c1SuperLabel4;
        private C1.Win.SuperTooltip.C1SuperLabel c1SuperLabel5;

    }
}

