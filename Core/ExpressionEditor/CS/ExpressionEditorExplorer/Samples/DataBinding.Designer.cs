using System.Data;

namespace ExpressionEditorExplorer.Samples
{
    partial class DataBinding
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
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory11 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory12 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory13 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory14 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory15 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory16 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory17 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory18 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory19 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory20 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.c1ExpressionEditorPanel1 = new C1.Win.ExpressionEditor.C1ExpressionEditorPanel();
            this.c1ExpressionEditor1 = new C1.Win.ExpressionEditor.C1ExpressionEditor();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditorPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditor1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1ExpressionEditorPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Panel2.Controls.Add(this.c1ExpressionEditor1);
            this.splitContainer1.Size = new System.Drawing.Size(721, 479);
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(252, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 23);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Location = new System.Drawing.Point(1, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Prev";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(76, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // c1ExpressionEditorPanel1
            // 
            expressionItemCategory12.Type = C1.Win.ExpressionEditor.Model.CategoryType.AggregateFuncs;
            expressionItemCategory13.Type = C1.Win.ExpressionEditor.Model.CategoryType.TextFuncs;
            expressionItemCategory14.Type = C1.Win.ExpressionEditor.Model.CategoryType.DateTimeFuncs;
            expressionItemCategory15.Type = C1.Win.ExpressionEditor.Model.CategoryType.LogicalFuncs;
            expressionItemCategory16.Type = C1.Win.ExpressionEditor.Model.CategoryType.MathFuncs;
            expressionItemCategory17.Type = C1.Win.ExpressionEditor.Model.CategoryType.ConvertFuncs;
            expressionItemCategory11.SubCategories.Add(expressionItemCategory12);
            expressionItemCategory11.SubCategories.Add(expressionItemCategory13);
            expressionItemCategory11.SubCategories.Add(expressionItemCategory14);
            expressionItemCategory11.SubCategories.Add(expressionItemCategory15);
            expressionItemCategory11.SubCategories.Add(expressionItemCategory16);
            expressionItemCategory11.SubCategories.Add(expressionItemCategory17);
            expressionItemCategory11.Type = C1.Win.ExpressionEditor.Model.CategoryType.Functions;
            expressionItemCategory18.Type = C1.Win.ExpressionEditor.Model.CategoryType.Operator;
            expressionItemCategory19.Type = C1.Win.ExpressionEditor.Model.CategoryType.Field;
            expressionItemCategory20.Type = C1.Win.ExpressionEditor.Model.CategoryType.Constant;
            this.c1ExpressionEditorPanel1.Categories.Add(expressionItemCategory11);
            this.c1ExpressionEditorPanel1.Categories.Add(expressionItemCategory18);
            this.c1ExpressionEditorPanel1.Categories.Add(expressionItemCategory19);
            this.c1ExpressionEditorPanel1.Categories.Add(expressionItemCategory20);
            this.c1ExpressionEditorPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1ExpressionEditorPanel1.ExpressionEditor = this.c1ExpressionEditor1;
            this.c1ExpressionEditorPanel1.Location = new System.Drawing.Point(0, 72);
            this.c1ExpressionEditorPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c1ExpressionEditorPanel1.Name = "c1ExpressionEditorPanel1";
            this.c1ExpressionEditorPanel1.Size = new System.Drawing.Size(721, 353);
            this.c1ExpressionEditorPanel1.TabIndex = 10;
            this.c1ExpressionEditorPanel1.Text = "c1ExpressionEditorPanel1";
            // 
            // c1ExpressionEditor1
            // 
            this.c1ExpressionEditor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1ExpressionEditor1.Location = new System.Drawing.Point(0, 0);
            this.c1ExpressionEditor1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c1ExpressionEditor1.Name = "c1ExpressionEditor1";
            this.c1ExpressionEditor1.Size = new System.Drawing.Size(721, 69);
            this.c1ExpressionEditor1.TabIndex = 6;
            this.c1ExpressionEditor1.Text = "c1ExpressionEditor1";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 69);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(721, 3);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(9, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(238, 23);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Result of the Expression for the current row:";
            // 
            // DataBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DataBinding";
            this.Size = new System.Drawing.Size(721, 479);
            this.Load += new System.EventHandler(this.DataBinding_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditorPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditor1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private C1.Win.ExpressionEditor.C1ExpressionEditorPanel c1ExpressionEditorPanel1;
        private C1.Win.ExpressionEditor.C1ExpressionEditor c1ExpressionEditor1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

