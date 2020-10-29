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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel(); 
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();            
            this.c1ExpressionEditorPanel1 = new C1.Win.ExpressionEditor.C1ExpressionEditorPanel();
            this.c1ExpressionEditor1 = new C1.Win.ExpressionEditor.C1ExpressionEditor();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditorPanel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.c1ExpressionEditorPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.c1ExpressionEditor1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(721, 479);
            this.tableLayoutPanel1.TabIndex = 0;            
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 40);
            this.panel1.TabIndex = 12;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(252, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 23);
            this.panel2.TabIndex = 11;
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
            this.c1ExpressionEditorPanel1.Location = new System.Drawing.Point(0, 287);
            this.c1ExpressionEditorPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c1ExpressionEditorPanel1.Name = "c1ExpressionEditorPanel1";
            this.c1ExpressionEditorPanel1.Size = new System.Drawing.Size(721, 353);
            this.c1ExpressionEditorPanel1.TabIndex = 10;
            this.c1ExpressionEditorPanel1.Text = "c1ExpressionEditorPanel1";
            // 
            // c1ExpressionEditor1
            // 
            this.c1ExpressionEditor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1ExpressionEditor1.Location = new System.Drawing.Point(0, 132);
            this.c1ExpressionEditor1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c1ExpressionEditor1.Name = "c1ExpressionEditor1";
            this.c1ExpressionEditor1.Size = new System.Drawing.Size(721, 69);
            this.c1ExpressionEditor1.TabIndex = 6;
            this.c1ExpressionEditor1.Text = "c1ExpressionEditor1";
            this.c1ExpressionEditor1.ExpressionChanged += new System.EventHandler(this.c1ExpressionEditor1_ExpressionChanged);
            // 
            // DataBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DataBinding";
            this.Size = new System.Drawing.Size(721, 479);
            this.Load += new System.EventHandler(this.DataBinding_Load);
            this.tableLayoutPanel1.ResumeLayout(false);            
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditorPanel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private C1.Win.ExpressionEditor.C1ExpressionEditorPanel c1ExpressionEditorPanel1;
        private C1.Win.ExpressionEditor.C1ExpressionEditor c1ExpressionEditor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;        
    }
}

