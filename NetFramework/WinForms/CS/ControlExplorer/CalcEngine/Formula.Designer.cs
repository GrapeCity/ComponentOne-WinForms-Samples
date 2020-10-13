namespace ControlExplorer.CalcEngine
{
    partial class Formula
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.expressionButton1 = new C1.Win.C1Input.C1Button();
            this.txtExpression = new C1.Win.C1Input.C1TextBox();
            this.txtResult = new C1.Win.C1Input.C1TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEvaluate = new C1.Win.C1Input.C1Button();
            this.btnReset = new C1.Win.C1Input.C1Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expressionButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpression)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEvaluate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.expressionButton1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtExpression, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtResult, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEvaluate, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 24);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // expressionButton1
            // 
            this.expressionButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expressionButton1.Image = global::ControlExplorer.Properties.Resources.Expression;
            this.expressionButton1.Location = new System.Drawing.Point(52, 0);
            this.expressionButton1.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.expressionButton1.Name = "expressionButton1";
            this.expressionButton1.Size = new System.Drawing.Size(24, 24);
            this.expressionButton1.TabIndex = 0;
            this.expressionButton1.UseVisualStyleBackColor = true;
            this.expressionButton1.Click += new System.EventHandler(this.expressionButton1_Click);
            // 
            // txtExpression
            // 
            this.txtExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpression.HideSelection = false;
            this.txtExpression.Location = new System.Drawing.Point(79, 3);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(280, 18);
            this.txtExpression.TabIndex = 1;
            this.txtExpression.Tag = null;
            this.txtExpression.TextDetached = true;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(435, 3);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(185, 18);
            this.txtResult.TabIndex = 2;
            this.txtResult.Tag = null;
            this.txtResult.TextDetached = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(365, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Result:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEvaluate.Image = global::ControlExplorer.Properties.Resources.play;
            this.btnEvaluate.Location = new System.Drawing.Point(26, 0);
            this.btnEvaluate.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(24, 24);
            this.btnEvaluate.TabIndex = 4;
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.c1Button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Image = global::ControlExplorer.Properties.Resources.Repeat;
            this.btnReset.Location = new System.Drawing.Point(0, 0);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(24, 24);
            this.btnReset.TabIndex = 5;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Formula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Formula";
            this.Size = new System.Drawing.Size(623, 24);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expressionButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpression)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEvaluate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.C1Input.C1Button expressionButton1;
        private C1.Win.C1Input.C1TextBox txtExpression;
        private C1.Win.C1Input.C1TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1Button btnEvaluate;
        private C1.Win.C1Input.C1Button btnReset;
    }
}
