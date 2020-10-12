namespace ControlExplorer.ExpressionEditor
{
    partial class Overview
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVariable2 = new C1.Win.C1Input.C1TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVariable1 = new C1.Win.C1Input.C1TextBox();
            this.c1ExpressionEditor1 = new C1.Win.ExpressionEditor.C1ExpressionEditor();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.c1ExpressionEditorPanel1 = new C1.Win.ExpressionEditor.C1ExpressionEditorPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxVariable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxVariable1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxResult);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxVariable2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxVariable1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Location = new System.Drawing.Point(83, 71);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(866, 20);
            this.textBoxResult.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Variable2";
            // 
            // textBoxVariable2
            // 
            this.textBoxVariable2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVariable2.Location = new System.Drawing.Point(83, 45);
            this.textBoxVariable2.Name = "textBoxVariable2";
            this.textBoxVariable2.Size = new System.Drawing.Size(866, 18);
            this.textBoxVariable2.TabIndex = 2;
            this.textBoxVariable2.Tag = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Variable1";
            // 
            // textBoxVariable1
            // 
            this.textBoxVariable1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVariable1.Location = new System.Drawing.Point(83, 19);
            this.textBoxVariable1.Name = "textBoxVariable1";
            this.textBoxVariable1.Size = new System.Drawing.Size(866, 18);
            this.textBoxVariable1.TabIndex = 0;
            this.textBoxVariable1.Tag = null;
            // 
            // c1ExpressionEditor1
            // 
            this.c1ExpressionEditor1.DataSource = null;
            this.c1ExpressionEditor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1ExpressionEditor1.Location = new System.Drawing.Point(0, 99);
            this.c1ExpressionEditor1.Name = "c1ExpressionEditor1";
            this.c1ExpressionEditor1.Size = new System.Drawing.Size(961, 60);
            this.c1ExpressionEditor1.TabIndex = 2;
            this.c1ExpressionEditor1.Text = "c1ExpressionEditor1";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 159);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(961, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // c1ExpressionEditorPanel1
            // 
            this.c1ExpressionEditorPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1ExpressionEditorPanel1.ExpressionEditor = this.c1ExpressionEditor1;
            this.c1ExpressionEditorPanel1.Location = new System.Drawing.Point(0, 162);
            this.c1ExpressionEditorPanel1.Name = "c1ExpressionEditorPanel1";
            this.c1ExpressionEditorPanel1.Size = new System.Drawing.Size(961, 322);
            this.c1ExpressionEditorPanel1.TabIndex = 4;
            this.c1ExpressionEditorPanel1.Text = "c1ExpressionEditorPanel1";
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 484);
            this.Controls.Add(this.c1ExpressionEditorPanel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.c1ExpressionEditor1);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(497, 383);
            this.Name = "Overview";
            this.Text = "Overview";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxVariable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxVariable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1Input.C1TextBox textBoxVariable2;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1TextBox textBoxVariable1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResult;
        private C1.Win.ExpressionEditor.C1ExpressionEditor c1ExpressionEditor1;
        private System.Windows.Forms.Splitter splitter1;
        private C1.Win.ExpressionEditor.C1ExpressionEditorPanel c1ExpressionEditorPanel1;
    }
}