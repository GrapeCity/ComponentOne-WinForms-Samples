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
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory1 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory2 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory3 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory4 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory5 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory6 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory7 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory8 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory9 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory10 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            this.c1ExpressionEditor1 = new C1.Win.ExpressionEditor.C1ExpressionEditor();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.c1ExpressionEditorPanel1 = new C1.Win.ExpressionEditor.C1ExpressionEditorPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditor1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditorPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1ExpressionEditor1
            // 
            this.c1ExpressionEditor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1ExpressionEditor1.Location = new System.Drawing.Point(0, 0);
            this.c1ExpressionEditor1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c1ExpressionEditor1.Name = "c1ExpressionEditor1";
            this.c1ExpressionEditor1.Size = new System.Drawing.Size(528, 69);
            this.c1ExpressionEditor1.TabIndex = 0;
            this.c1ExpressionEditor1.Text = "c1ExpressionEditor1";
            this.c1ExpressionEditor1.ExpressionChanged += new System.EventHandler(this.c1ExpressionEditor1_ExpressionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(0, 288);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(528, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result of the Expression for the current row:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(371, 17);
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
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(5, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(307, 23);
            this.textBox1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 69);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(528, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 285);
            this.splitter2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(528, 3);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // c1ExpressionEditorPanel1
            // 
            expressionItemCategory2.Type = C1.Win.ExpressionEditor.Model.CategoryType.AggregateFuncs;
            expressionItemCategory3.Type = C1.Win.ExpressionEditor.Model.CategoryType.TextFuncs;
            expressionItemCategory4.Type = C1.Win.ExpressionEditor.Model.CategoryType.DateTimeFuncs;
            expressionItemCategory5.Type = C1.Win.ExpressionEditor.Model.CategoryType.LogicalFuncs;
            expressionItemCategory6.Type = C1.Win.ExpressionEditor.Model.CategoryType.MathFuncs;
            expressionItemCategory7.Type = C1.Win.ExpressionEditor.Model.CategoryType.ConvertFuncs;
            expressionItemCategory1.SubCategories.Add(expressionItemCategory2);
            expressionItemCategory1.SubCategories.Add(expressionItemCategory3);
            expressionItemCategory1.SubCategories.Add(expressionItemCategory4);
            expressionItemCategory1.SubCategories.Add(expressionItemCategory5);
            expressionItemCategory1.SubCategories.Add(expressionItemCategory6);
            expressionItemCategory1.SubCategories.Add(expressionItemCategory7);
            expressionItemCategory1.Type = C1.Win.ExpressionEditor.Model.CategoryType.Functions;
            expressionItemCategory8.Type = C1.Win.ExpressionEditor.Model.CategoryType.Operator;
            expressionItemCategory9.Type = C1.Win.ExpressionEditor.Model.CategoryType.Field;
            expressionItemCategory10.Type = C1.Win.ExpressionEditor.Model.CategoryType.Constant;
            this.c1ExpressionEditorPanel1.Categories.Add(expressionItemCategory1);
            this.c1ExpressionEditorPanel1.Categories.Add(expressionItemCategory8);
            this.c1ExpressionEditorPanel1.Categories.Add(expressionItemCategory9);
            this.c1ExpressionEditorPanel1.Categories.Add(expressionItemCategory10);
            this.c1ExpressionEditorPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1ExpressionEditorPanel1.ExpressionEditor = this.c1ExpressionEditor1;
            this.c1ExpressionEditorPanel1.Location = new System.Drawing.Point(0, 72);
            this.c1ExpressionEditorPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c1ExpressionEditorPanel1.Name = "c1ExpressionEditorPanel1";
            this.c1ExpressionEditorPanel1.Size = new System.Drawing.Size(528, 213);
            this.c1ExpressionEditorPanel1.TabIndex = 5;
            this.c1ExpressionEditorPanel1.Text = "c1ExpressionEditorPanel1";
            // 
            // DataBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1ExpressionEditorPanel1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.c1ExpressionEditor1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DataBinding";
            this.Size = new System.Drawing.Size(528, 335);
            this.Load += new System.EventHandler(this.DataBinding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditor1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditorPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.ExpressionEditor.C1ExpressionEditor c1ExpressionEditor1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private C1.Win.ExpressionEditor.C1ExpressionEditorPanel c1ExpressionEditorPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

