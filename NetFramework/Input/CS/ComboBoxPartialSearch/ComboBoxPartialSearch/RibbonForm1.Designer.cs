namespace ComboBoxPartialSearch
{
    partial class RibbonForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonForm1));

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.c1StatusBar1 = new C1.Win.Ribbon.C1StatusBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1ComboBox2 = new C1.Win.C1Input.C1ComboBox();
            this.c1ComboBox1 = new C1.Win.C1Input.C1ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.c1SplitButton1 = new C1.Win.C1Input.C1SplitButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1StatusBar1
            // 
            this.c1StatusBar1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1StatusBar1.Location = new System.Drawing.Point(0, 473);
            this.c1StatusBar1.Name = "c1StatusBar1";
            this.c1StatusBar1.Size = new System.Drawing.Size(725, 23);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c1ComboBox2);
            this.panel1.Controls.Add(this.c1ComboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.c1TextBox1);
            this.panel1.Controls.Add(this.c1SplitButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 131);
            this.panel1.TabIndex = 1;
            // 
            // c1ComboBox2
            // 
            this.c1ComboBox2.AllowSpinLoop = false;
            this.c1ComboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.c1ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.c1ComboBox2.AutoSuggestMode = C1.Win.C1Input.AutoSuggestMode.Contains;
            this.c1ComboBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1ComboBox2.GapHeight = 0;
            this.c1ComboBox2.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox2.ItemsDisplayMember = "";
            this.c1ComboBox2.ItemsValueMember = "";
            this.c1ComboBox2.Location = new System.Drawing.Point(219, 56);
            this.c1ComboBox2.Name = "c1ComboBox2";
            this.c1ComboBox2.Size = new System.Drawing.Size(494, 18);
            this.c1ComboBox2.TabIndex = 6;
            this.c1ComboBox2.Tag = null;
            // 
            // c1ComboBox1
            // 
            this.c1ComboBox1.AllowSpinLoop = false;
            this.c1ComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.c1ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.c1ComboBox1.AutoSuggestMode = C1.Win.C1Input.AutoSuggestMode.Contains;
            this.c1ComboBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1ComboBox1.GapHeight = 0;
            this.c1ComboBox1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox1.ItemsDisplayMember = "";
            this.c1ComboBox1.ItemsValueMember = "";
            this.c1ComboBox1.Location = new System.Drawing.Point(219, 22);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Size = new System.Drawing.Size(494, 18);
            this.c1ComboBox1.TabIndex = 5;
            this.c1ComboBox1.Tag = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subject";
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1TextBox1.AutoSize = false;
            this.c1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox1.Location = new System.Drawing.Point(219, 88);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Size = new System.Drawing.Size(494, 24);
            this.c1TextBox1.TabIndex = 1;
            this.c1TextBox1.Tag = null;
            this.c1TextBox1.TextDetached = true;
            this.c1TextBox1.Value = "Get Started with Visual Studio for Mac";
            // 
            // c1SplitButton1
            // 
            this.c1SplitButton1.Location = new System.Drawing.Point(12, 12);
            this.c1SplitButton1.Name = "c1SplitButton1";
            this.c1SplitButton1.Size = new System.Drawing.Size(115, 100);
            this.c1SplitButton1.TabIndex = 0;
            this.c1SplitButton1.Text = "Send";
            this.c1SplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.c1SplitButton1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(725, 342);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "As you most likely know, Visual Studio 2017 was launched on March 7 with many gre" +
    "at new features.";
            // 
            // RibbonForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 496);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.c1StatusBar1);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "RibbonForm1";
            this.Text = "New message";
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1StatusBar c1StatusBar1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Input.C1ComboBox c1ComboBox2;
        private C1.Win.C1Input.C1ComboBox c1ComboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private C1.Win.C1Input.C1SplitButton c1SplitButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
